﻿////////////////////////////////////////////////////////////////////////////////
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
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{

    internal sealed class SqlGeographyBuilderWrapper:
        IGeometryBuilder
    {

        public SqlGeographyBuilderWrapper()
        {
            _Builder=new SqlTypes.SqlGeometryBuilder();
        }

        public void SetCoordinateSystem(ICoordinateSystem system)
        {
            _Builder.SetSrid((int)system.AuthorityCode);
            _TargetSystem=system;
        }

        public void BeginGeometry(GeometryType type)
        {
            _Builder.BeginGeometry(GeometryTypeUtils.ConvertToGeometry(type));
        }

        public void BeginFigure(double x, double y, double? z)
        {
            _Builder.BeginFigure(x, y, z, null);
        }

        public void AddLine(double x, double y, double? z)
        {
            _Builder.AddLine(x, y, z, null);
        }

        public void EndFigure()
        {
            _Builder.EndFigure();
        }

        public void EndGeometry()
        {
            _Builder.EndGeometry();
        }

        public SqlGeography Parse(string text, ICoordinateSystem system)
        {
            return new SqlGeography(SqlTypes.SqlGeography.STGeomFromText((SqlChars)((SqlString)text), (int)system.AuthorityCode), system);
        }

        ISimpleGeometry IGeometryBuilder.Parse(string text, ICoordinateSystem system)
        {
            return Parse(text, system);
        }

        public SqlGeography ConstructedGeometry
        {
            get
            {
                // cf. http://blogs.msdn.com/b/edkatibah/archive/2008/08/19/working-with-invalid-data-and-the-sql-server-2008-geography-data-type-part-1b.aspx
                SqlTypes.SqlGeometry geom=_Builder.ConstructedGeometry.MakeValid();
                return Parse(((SqlString)geom.STUnion(geom.STStartPoint()).STAsText()).Value, _TargetSystem);
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        private SqlTypes.SqlGeometryBuilder _Builder;
        private ICoordinateSystem _TargetSystem;

    }
}