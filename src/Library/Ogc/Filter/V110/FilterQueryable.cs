////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

    public static class FilterQueryable
    {

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static IQueryable<T> Where<T>(this IQueryable<T> source, Filter filter, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            return (IQueryable<T>)Where((IQueryable)source, filter, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static IQueryable Where(this IQueryable source, Filter filter, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            Debug.Assert(source!=null);
            if (source==null)
                throw new ArgumentNullException("source");
            Debug.Assert(filter!=null);
            if (filter==null)
                throw new ArgumentNullException("filter");

            LambdaExpression lambda=filter.CreateLambda(source, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider, navigatorCreator);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    "Where",
                    new Type[] { source.ElementType },
                    source.Expression,
                    Expression.Quote(lambda)
                )
            );
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, SortBy ordering, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied=false, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            return (IQueryable<T>)OrderBy((IQueryable)source, ordering, namespaceManager, mayRootPathBeImplied, navigatorCreator);
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static IQueryable OrderBy(this IQueryable source, SortBy ordering, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied=false, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            if (source==null)
                throw new ArgumentNullException("source");
            if (ordering==null)
                throw new ArgumentNullException("ordering");

            Expression query=ordering.CreateExpression(source.ElementType, source.Expression, namespaceManager, mayRootPathBeImplied, navigatorCreator);
            return source.Provider.CreateQuery(query);
        }
    }
}
