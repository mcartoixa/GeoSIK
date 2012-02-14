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
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;

namespace GeoSik.Ogc.Gml.V311
{

    public class GmlGeometryBuilder:
        GeometryBuilder
    {

        public GmlGeometryBuilder():
            base()
        {
        }

        public GmlGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        public override IGeometry Parse(string text, ICoordinateSystem system)
        {
            throw new NotImplementedException();
        }

        public override void BeginGeometry(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.Curve:
                _Geometry=new Curve();
                break;
            case GeometryType.LineString:
                _Geometry=new LineString();
                break;
            case GeometryType.MultiCurve:
                _Geometry=new MultiCurve();
                break;
            case GeometryType.MultiLineString:
                _Geometry=new MultiLineString();
                break;
            case GeometryType.MultiPoint:
                _Geometry=new MultiPoint();
                break;
            case GeometryType.MultiPolygon:
                _Geometry=new MultiPolygon();
                break;
            case GeometryType.MultiSurface:
                _Geometry=new MultiSurface();
                break;
            case GeometryType.Point:
                _Geometry=new Point();
                break;
            case GeometryType.Polygon:
                _Geometry=new Polygon();
                break;
            case GeometryType.Surface:
                _Geometry=new Surface();
                break;
            }

            if (_Geometry==null)
                throw new NotSupportedException();

            _Geometry.CoordinateSystem=_CoordinateSystem;
        }

        public override void EndFigure()
        {
            _Geometry.EndFigure();
        }

        protected override void DoAddLine(double x, double y, double? z)
        {
            _Geometry.AddLine(x, y, z);
        }

        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Geometry.BeginFigure(x, y, z);
        }

        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            _CoordinateSystem=system;
        }

        public override ISimpleGeometry ConstructedGeometry
        {
            get
            {
                return _Geometry;
            }
        }

        private _Geometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
