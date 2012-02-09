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
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace GeoSik.Ogc.WebCatalog.Cql
{

    public sealed class ExpressionBuilderParameters
    {

        public ExpressionBuilderParameters(ParameterExpression[] parameters, IQueryProvider queryProvider, Type elementType, IXmlNamespaceResolver namespaceResolver, bool mayRootPathBeImplied, IGeometryBuilderProvider geometryBuilderProvider, IOperatorImplementationProvider operatorImplementationProvider)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");
            Debug.Assert(parameters.Length>0);
            if (parameters.Length==0)
                throw new ArgumentException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.ArrayShouldHaveElementsException,
                        1,
                        parameters.Length
                    ),
                    "parameters"
                );
            Debug.Assert(queryProvider!=null);
            if (queryProvider==null)
                throw new ArgumentNullException("queryProvider");
            Debug.Assert(elementType!=null);
            if (elementType==null)
                throw new ArgumentNullException("elementType");
            Debug.Assert(geometryBuilderProvider!=null);
            if (geometryBuilderProvider==null)
                throw new ArgumentNullException("geometryBuilderProvider");

            Parameters=new ReadOnlyCollection<ParameterExpression>(parameters);
            ElementType=elementType;
            QueryProvider=queryProvider;
            NamespaceResolver=namespaceResolver;
            MayRootPathBeImplied=mayRootPathBeImplied;
            GeometryBuilderProvider=geometryBuilderProvider;
            OperatorImplementationProvider=operatorImplementationProvider;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters
        {
            get;
            private set;
        }

        public Type ElementType
        {
            get;
            private set;
        }

        public IQueryProvider QueryProvider
        {
            get;
            private set;
        }

        public IXmlNamespaceResolver NamespaceResolver
        {
            get;
            private set;
        }

        public bool MayRootPathBeImplied
        {
            get;
            private set;
        }

        public IGeometryBuilderProvider GeometryBuilderProvider
        {
            get;
            private set;
        }

        public IOperatorImplementationProvider OperatorImplementationProvider
        {
            get;
            private set;
        }
    }
}
