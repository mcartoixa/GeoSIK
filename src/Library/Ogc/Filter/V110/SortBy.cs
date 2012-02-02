////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace GeoSik.Ogc.Filter.V110
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
