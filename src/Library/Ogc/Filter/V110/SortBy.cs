using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class SortBy
    {

        internal Expression CreateExpression(Type elementType, Expression query, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied=false, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            XPathTypeNavigator xptn=(navigatorCreator!=null ? navigatorCreator(elementType, namespaceManager) : new XPathTypeNavigator(elementType, namespaceManager));

            bool first=true;
            foreach (SortPropertyType spt in SortProperty)
            {
                ParameterExpression arg=Expression.Parameter(elementType);
                Expression selector=null;

                XPathNodeIterator xpni=((XPathTypeNavigator)xptn.Clone()).Select(spt.PropertyName.Untyped.Value, namespaceManager, mayRootPathBeImplied);
                Debug.Assert(xpni.Count==1);

                foreach (XPathTypeNavigator n in xpni)
                    selector=n.CreateExpression(arg);

                query=Expression.Call(
                    typeof(Queryable),
                    OrderMethodName(spt.SortOrder, first),
                    new Type[] { elementType, selector.Type },
                    query,
                    Expression.Quote(Expression.Lambda(selector, arg))
                );

                first=false;
            }

            return query;
        }

        private static string OrderMethodName(string order, bool first)
        {
            switch (order)
            {
            case "DESC":
                return first ? "OrderByDescending" : "ThenByDescending";
            case "ASC":
            default:
                return first ? "OrderBy" : "ThenBy";

            }
        }
    }
#pragma warning restore 3009
}
