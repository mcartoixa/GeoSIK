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
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{

    internal sealed class SqlGeographyBuilderWrapper:
        IGeometryBuilder
    {

        public SqlGeographyBuilderWrapper()
        {
            _Builder=new SqlTypes.SqlGeographyBuilder();
        }

        public void SetCoordinateSystem(ICoordinateSystem system)
        {
            _Builder.SetSrid(system.Code);
            _TargetSystem=system;
        }

        public void BeginGeometry(GeometryType type)
        {
            _Builder.BeginGeography(GeometryTypeUtils.ConvertToGeography(type));
        }

        public void BeginFigure(double x, double y, double? z)
        {
            // latitude, longitude is y, x...
            _Builder.BeginFigure(y, x, z, null);
        }

        public void AddLine(double x, double y, double? z)
        {
            // latitude, longitude is y, x...
            _Builder.AddLine(y, x, z, null);
        }

        public void EndFigure()
        {
            _Builder.EndFigure();
        }

        public void EndGeometry()
        {
            _Builder.EndGeography();
        }

        public void Parse(string text, ICoordinateSystem system)
        {
            _Geography=new SqlGeography(SqlTypes.SqlGeography.STGeomFromText((SqlChars)((SqlString)text), system.Code), system);
        }

        public void Parse(byte[] data, ICoordinateSystem system)
        {
            _Geography=new SqlGeography(SqlTypes.SqlGeography.STGeomFromWKB(new SqlBytes(data), system.Code), system);
        }

        public SqlGeography ConstructedGeometry
        {
            get
            {
                if (_Geography==null)
                    _Geography=new SqlGeography(_Builder.ConstructedGeography, _TargetSystem);

                Debug.Assert(_Geography!=null);
                return _Geography;
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        private SqlTypes.SqlGeographyBuilder _Builder;
        private SqlGeography _Geography;
        private ICoordinateSystem _TargetSystem;

    }
}
