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
using System.Globalization;
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;
using ProjNet.CoordinateSystems;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class GeometryLiteralNode:
        DeferredLiteralNode<IGeometry>
    {

        protected override IGeometry GetValue(ParseTreeNode treeNode, ExpressionBuilderParameters parameters)
        {
            IGeometryBuilder builder=parameters.GeometryBuilderProvider.CreateBuilder();
            return builder.Parse(treeNode.Token.Text, GeographicCoordinateSystem.WGS84);
        }
    }
#pragma warning restore 3001, 3009
}
