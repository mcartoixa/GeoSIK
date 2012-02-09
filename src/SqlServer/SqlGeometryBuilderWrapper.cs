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
using System.Text;
using ProjNet.CoordinateSystems;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{

    internal sealed class SqlGeometryBuilderWrapper:
        IGeometrySink
    {

        public SqlGeometryBuilderWrapper()
        {
            _Builder=new SqlTypes.SqlGeometryBuilder();
        }

        public void SetCoordinateSystem(ICoordinateSystem system)
        {
            if (system==null)
                _Builder.SetSrid(0);
            else
                _Builder.SetSrid((int)system.AuthorityCode);

            _TargetSystem=system;
        }

        public void BeginGeometry(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.GeometryCollection:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.GeometryCollection);
                break;
            case GeometryType.LineString:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.LineString);
                break;
            case GeometryType.MultiLineString:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.MultiLineString);
                break;
            case GeometryType.MultiPoint:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.MultiPoint);
                break;
            case GeometryType.MultiPolygon:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.MultiPolygon);
                break;
            case GeometryType.Point:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.Point);
                break;
            case GeometryType.Polygon:
                _Builder.BeginGeometry(SqlTypes.OpenGisGeometryType.Polygon);
                break;
            default:
                throw new NotSupportedException();
            }
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

        public IGeometry ConstructedGeometry
        {
            get
            {
                return new SqlGeometryWrapper(_Builder.ConstructedGeometry, _TargetSystem);
            }
        }

        private SqlTypes.SqlGeometryBuilder _Builder;
        private ICoordinateSystem _TargetSystem;
    }
}
