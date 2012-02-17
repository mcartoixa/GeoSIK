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
using System.Drawing;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{

    public sealed class SqlGeometryBuilder:
        GeometryBuilder,
        SqlTypes.IGeographySink,
        SqlTypes.IGeometrySink
    {

        public SqlGeometryBuilder():
            base()
        {
        }

        public SqlGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            if ((system is IGeographicCoordinateSystem) || (system is IGeocentricCoordinateSystem))
                _Builder=new SqlGeographyBuilderWrapper();
            else
                _Builder=new SqlGeometryBuilderWrapper();

            _Builder.SetCoordinateSystem(system);
        }

        public override void BeginGeometry(GeometryType type)
        {
            _Builder.BeginGeometry(type);
        }

        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Builder.BeginFigure(x, y, z);
        }

        protected override void DoAddLine(double x, double y, double? z)
        {
            _Builder.AddLine(x, y, z);
        }

        public override void EndFigure()
        {
            _Builder.EndFigure();
        }

        public override void EndGeometry()
        {
            _Builder.EndGeometry();
        }

        public override ISimpleGeometry Parse(string text, ICoordinateSystem system)
        {
            return _Builder.Parse(text, system);
        }

        void SqlTypes.IGeographySink.AddLine(double latitude, double longitude, double? z, double? m)
        {
            AddLine(longitude, latitude, z);
        }

        void SqlTypes.IGeographySink.BeginFigure(double latitude, double longitude, double? z, double? m)
        {
            BeginFigure(longitude, latitude, z);
        }

        void SqlTypes.IGeographySink.BeginGeography(SqlTypes.OpenGisGeographyType type)
        {
            BeginGeometry(GeometryTypeUtils.Convert(type));
        }

        void SqlTypes.IGeographySink.EndFigure()
        {
            EndFigure();
        }

        void SqlTypes.IGeographySink.EndGeography()
        {
            EndGeometry();
        }

        void SqlTypes.IGeographySink.SetSrid(int srid)
        {
            SetCoordinateSystem(CoordinateSystemProvider.Instance.GetById(new Srid(srid)));
        }

        void SqlTypes.IGeometrySink.AddLine(double x, double y, double? z, double? m)
        {
            AddLine(x, y, z);
        }

        void SqlTypes.IGeometrySink.BeginFigure(double x, double y, double? z, double? m)
        {
            BeginFigure(x, y, z);
        }

        void SqlTypes.IGeometrySink.BeginGeometry(SqlTypes.OpenGisGeometryType type)
        {
            BeginGeometry(GeometryTypeUtils.Convert(type));
        }

        void SqlTypes.IGeometrySink.EndFigure()
        {
            EndFigure();
        }

        void SqlTypes.IGeometrySink.EndGeometry()
        {
            EndGeometry();
        }

        void SqlTypes.IGeometrySink.SetSrid(int srid)
        {
            SetCoordinateSystem(CoordinateSystemProvider.Instance.GetById(new Srid(srid)));
        }

        public override ISimpleGeometry ConstructedGeometry
        {
            get
            {
                return _Builder.ConstructedGeometry;
            }
        }

        private IGeometryBuilder _Builder;
    }
}
