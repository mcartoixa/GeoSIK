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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Cql=OgcToolkit.Ogc.WebCatalog.Cql;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Filter110=OgcToolkit.Ogc.Filter.V110;

namespace OgcToolkit.Services.Csw.V202
{

    internal static class QueryableExtensions
    {

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        internal static IQueryable<T> Where<T>(this IQueryable<T> source, Csw202.Constraint constraint, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null)
        {
            return (IQueryable<T>)Where((IQueryable)source, constraint, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        internal static IQueryable Where(this IQueryable source, Csw202.Constraint constraint, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null)
        {
            Debug.Assert(source!=null);
            if (source==null)
                throw new ArgumentNullException("source");
            Debug.Assert(constraint!=null);
            if (constraint==null)
                throw new ArgumentNullException("constraint");

            IQueryable ret=source;

            //if (constraint.Filter!=null)
            if (constraint.Untyped.Descendants("{http://www.opengis.net/ogc}Filter").Any<XElement>())
                ret=Filter110.FilterQueryable.Where(ret, constraint.Filter, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider, (t, r) => new XPathQueryableNavigator(t, r));

            if (!string.IsNullOrEmpty(constraint.CqlText))
                ret=Cql.CqlQueryable.Where(ret, constraint.CqlText, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);

            return ret;
        }

    }
}
