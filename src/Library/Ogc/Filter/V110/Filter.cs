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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Xml.Schema.Linq;

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Filter
    {

        internal LambdaExpression CreateLambda(IQueryable source, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied, IGeometryBuilderProvider geometryBuilderProvider, IOperatorImplementationProvider operatorImplementationProvider, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            ParameterExpression[] parameters=new ParameterExpression[] {
                Expression.Parameter(source.ElementType)
            };

            var ebp=new ExpressionBuilderParameters(parameters, source.Provider, source.ElementType, namespaceManager, mayRootPathBeImplied, geometryBuilderProvider, operatorImplementationProvider, navigatorCreator);

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
