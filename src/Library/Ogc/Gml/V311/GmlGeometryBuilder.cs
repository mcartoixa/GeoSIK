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
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;

namespace GeoSik.Ogc.Gml.V311
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class that builds <see cref="_Geometry" /> instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class GmlGeometryBuilder:
        GeometryTransformerSink,
        IGeometryBuilder
    {

        /// <summary>Creates a new instance of the <see cref="GmlGeometryBuilder" /> class.</summary>
        public GmlGeometryBuilder():
            base()
        {
        }

        /// <summary>Creates a new instance of the <see cref="GmlGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public GmlGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
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

            _Geometry.CoordinateSystem=TargetSystem;
        }

        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        public override void EndFigure()
        {
            _Geometry.EndFigure();
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            _Geometry.AddLine(x, y, z);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Geometry.BeginFigure(x, y, z);
        }

        /// <summary>Parses the geometry defined by the specified WKT representation, in the specified coordinate system.</summary>
        /// <param name="text">The WKT representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKT representation.</param>
        public void Parse(string text, ICoordinateSystem system)
        {
            //TODO: implement parsing
            throw new NotImplementedException();
        }

        /// <summary>Returns the geometry resulting from the actions on the current <see cref="GmlGeometryBuilder" />.</summary>
        internal _Geometry ConstructedGeometry
        {
            get
            {
                return _Geometry;
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        private _Geometry _Geometry;
    }
}
