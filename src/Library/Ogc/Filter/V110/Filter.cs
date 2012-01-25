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

        internal LambdaExpression CreateLambda(IQueryable source, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied, IOperatorImplementationProvider operatorImplementationProvider, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            ParameterExpression[] parameters=new ParameterExpression[] {
                Expression.Parameter(source.ElementType)
            };

            var ebp=new ExpressionBuilderParameters(parameters, source.Provider, source.ElementType, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider, navigatorCreator);

            Type st=typeof(bool);
            Expression body=null;
            if (logicOps!=null)
                body=logicOps.CreateExpression(ebp, st, null);
            else if (comparisonOps!=null)
                body=comparisonOps.CreateExpression(ebp, st, null);
            else if (spatialOps!=null)
                body=spatialOps.CreateExpression(ebp, st, null);

            if (body==null)
                throw new InvalidOperationException("Invalid filter definition");

            return Expression.Lambda(body, parameters);
        }

    }
#pragma warning restore 3009
}
