using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class comparisonOps:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bcop=this as IBinaryComparisonOperator;
            if (bcop!=null)
            {
                if (bcop.expression==null)
                    throw new InvalidOperationException();

                Type[] subtypes=bcop.expression
                    .Select<expression, Type>(e => ((IExpressionBuilder)e).GetExpressionStaticType(parameters))
                    .Where<Type>(t => t!=null)
                    .ToArray<Type>();
                //TODO: probably needs more checking on other subtypes there...
                Type st=(subtypes.Length>0 ? subtypes[0] : null);

                Expression[] subexpr=bcop.expression
                    .Select<expression, Expression>(e => ((IExpressionBuilder)e).CreateExpression(parameters, st))
                    .ToArray<Expression>();
                Debug.Assert(subexpr.Length==2);

                return bcop.OperatorExpression(subexpr[0], subexpr[1]);
            }

            throw new NotSupportedException();
        }

        protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return CreateExpression(parameters, expectedStaticType);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
#pragma warning restore 3009
}
