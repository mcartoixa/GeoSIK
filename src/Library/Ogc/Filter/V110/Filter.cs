using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Filter
    {

        internal LambdaExpression CreateLambda(Type elementType, XmlNamespaceManager namespaceManager)
        {
            ParameterExpression[] parameters=new ParameterExpression[] {
                Expression.Parameter(elementType)
            };

            Expression body=null;
            if (logicOps!=null)
                body=CreateExpression(logicOps, parameters, elementType, namespaceManager);
            else if (comparisonOps!=null)
                body=CreateExpression(comparisonOps, parameters, elementType, namespaceManager);
            else if (spatialOps!=null)
                body=CreateExpression(spatialOps, parameters);

            if (body==null)
                throw new InvalidOperationException("Invalid filter definition");

            return Expression.Lambda(body, parameters);
        }

        private static Expression CreateExpression(logicOps ops, ParameterExpression[] parameters, Type elementType, XmlNamespaceManager namespaceManager)
        {
            // Not
            var not=ops as Not;
            if (not!=null)
            {
                Expression subexpr=null;
                if (not.logicOps!=null)
                    subexpr=CreateExpression(not.logicOps, parameters, elementType, namespaceManager);
                else if (not.comparisonOps!=null)
                    subexpr=CreateExpression(not.comparisonOps, parameters, elementType, namespaceManager);
                else if (not.spatialOps!=null)
                    subexpr=CreateExpression(not.spatialOps, parameters);
                else if (not.Function!=null)
                    subexpr=CreateExpression(not.Function, parameters);

                if (subexpr==null)
                    throw new InvalidOperationException("Invalid binary logical operator content");

                return Expression.Negate(subexpr);
            }

            // And, Or
            var blo=ops as IBinaryLogicalOperator;
            if (blo!=null)
            {
                Expression[] subexpr=CreateLogicalSubExpressions(blo.GetLogicalElements(), parameters, elementType, namespaceManager).ToArray<Expression>();
                Debug.Assert(subexpr.Length>1);

                Expression ret=blo.OperatorExpression(subexpr[0], subexpr[1]);
                for (int i=2; i<subexpr.Length; ++i)
                    ret=blo.OperatorExpression(ret, subexpr[i]);

                return ret;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    "Unrecognized logical operator '{0}'",
                    ops.GetType().Name
                )
            );
        }

        private static Expression CreateExpression(comparisonOps ops, ParameterExpression[] parameters, Type elementType, XmlNamespaceManager namespaceManager)
        {
            // =, <, >, >=, <=, <>
            var bco=ops as IBinaryComparisonOperator;
            if (bco!=null)
            {
                if (bco.expression!=null)
                {
                    Expression[] subexpr=bco.expression.Select<expression, Expression>(e => CreateExpression(e, parameters, elementType, namespaceManager)).ToArray<Expression>();
                    Debug.Assert(subexpr.Length==2);
                    return bco.OperatorExpression(subexpr[0], subexpr[1]);
                } else
                    // TODO: Wrong type here...
                    return Expression.Default(elementType);
            }

            throw new NotImplementedException();
        }

        private static Expression CreateExpression(spatialOps ops, ParameterExpression[] parameters)
        {
            throw new NotImplementedException();
        }

        private static Expression CreateExpression(Function function, ParameterExpression[] parameters)
        {
            throw new NotImplementedException();
        }

        private static Expression CreateExpression(expression value, ParameterExpression[] parameters, Type elementType, XmlNamespaceManager namespaceManager)
        {
            var pn=value as PropertyName;
            if (pn!=null)
            {
                XPathTypeNavigator xptn=new XPathTypeNavigator(elementType, namespaceManager);
                XPathNodeIterator xpni=xptn.Select(pn.Untyped.Value, namespaceManager, true);
                Debug.Assert(xpni.Count==1);
                foreach (XPathTypeNavigator n in xpni)
                    return n.CreateExpression(parameters[0]);
            }

            var li=value as Literal;
            if (li!=null)
            {
                // TODO: support other literals than strings...
                return Expression.Constant(li.Untyped.Value);
            }

            // +, -, *, /
            var bo=value as IBinaryOperator;
            if (bo!=null)
            {
                if (bo.expression!=null)
                {
                    Expression[] subexpr=bo.expression.Select<expression, Expression>(e => CreateExpression(e, parameters, elementType, namespaceManager)).ToArray<Expression>();
                    Debug.Assert(subexpr.Length==2);
                    return bo.OperatorExpression(subexpr[0], subexpr[1]);
                } else
                    // TODO: Wrong type here...
                    return Expression.Default(elementType);
            }

            throw new NotImplementedException();
        }

        private static IEnumerable<Expression> CreateLogicalSubExpressions(IEnumerable<XTypedElement> elements, ParameterExpression[] parameters, Type elementType, XmlNamespaceManager namespaceManager)
        {
            foreach (XTypedElement e in elements)
            {
                var lo=e as logicOps;
                if (lo!=null)
                    yield return CreateExpression(lo, parameters, elementType, namespaceManager);

                var co=e as comparisonOps;
                if (co!=null)
                    yield return CreateExpression(co, parameters, elementType, namespaceManager);

                var so=e as spatialOps;
                if (so!=null)
                    yield return CreateExpression(so, parameters);

                var fu=e as Function;
                if (fu!=null)
                    yield return CreateExpression(fu, parameters);

                throw new InvalidOperationException();
            }
        }
    }
#pragma warning restore 3009
}
