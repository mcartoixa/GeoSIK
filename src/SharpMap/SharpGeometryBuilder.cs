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
using System.Text;
using ProjNet.CoordinateSystems;
using SmGeometries=SharpMap.Geometries;

namespace GeoSik.SharpMap
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class used to build <see cref="SharpGeometry" /> instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class SharpGeometryBuilder:
        GeometryTransformerSink,
        IGeometryBuilder
    {

        internal sealed class Sink:
            IGeometrySink
        {

            public void SetCoordinateSystem(ICoordinateSystem system)
            {
                _SpatialReference=system;
            }

            public void BeginGeometry(GeometryType type)
            {
                _CurrentType.Push(type);
            }

            public void BeginFigure(double x, double y, double? z)
            {
                AddLine(x, y, z);
            }

            public void AddLine(double x, double y, double? z)
            {
                SmGeometries.Point point=null;
                if (z.HasValue)
                    point=new SmGeometries.Point3D(x, y, z.Value);
                else
                    point=new SmGeometries.Point(x, y);
                _CurrentPoints.Add(point);
            }

            public void EndFigure()
            {
                GeometryType type=_CurrentType.Peek();
                switch (type)
                {
                case GeometryType.GeometryCollection:
                    {
                        var g=new SmGeometries.GeometryCollection();
                        g.Collection=_Figures;
                        _Figures=new SmGeometries.Geometry[] { g };
                    }
                    break;
                case GeometryType.LineString:
                    _Figures.Add(new SmGeometries.LineString(_CurrentPoints));
                    break;
                case GeometryType.MultiLineString:
                    {
                        var g=new SmGeometries.MultiLineString();
                        g.LineStrings=_Figures.Cast<SmGeometries.LineString>().ToList<SmGeometries.LineString>();
                        _Figures=new SmGeometries.Geometry[] { g };
                    }
                    break;
                case GeometryType.MultiPoint:
                    {
                        var g=new SmGeometries.MultiPoint();
                        g.Points=_Figures.Cast<SmGeometries.Point>().ToList<SmGeometries.Point>();
                        _Figures=new SmGeometries.Geometry[] { g };
                    }
                    break;
                case GeometryType.MultiPolygon:
                    {
                        var g=new SmGeometries.MultiPolygon();
                        g.Polygons=_Figures.Cast<SmGeometries.Polygon>().ToList<SmGeometries.Polygon>();
                        _Figures=new SmGeometries.Geometry[] { g };
                    }
                    break;
                case GeometryType.Point:
                    if (_CurrentPoints.Count>0)
                        _Figures.Add(_CurrentPoints[0]);
                    else
                        _Figures.Add(new SmGeometries.Point());
                    break;
                case GeometryType.Polygon:
                    _Figures.Add(new SmGeometries.LinearRing(_CurrentPoints));
                    break;
                default:
                    throw new NotSupportedException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.UnsupportedGeometryTypeException,
                            type
                        )
                    );
                }

                _CurrentPoints.Clear();
            }

            public void EndGeometry()
            {
                GeometryType type=_CurrentType.Peek();
                switch (type)
                {
                case GeometryType.Polygon:
                    if (_Figures.Count>0)
                    {
                        var g=new SmGeometries.Polygon(
                            (SmGeometries.LinearRing)_Figures[0],
                            _Figures.Skip(1).Cast<SmGeometries.LinearRing>().ToList<SmGeometries.LinearRing>()
                        );
                        _Figures=new SmGeometries.Geometry[] { g };
                    } else
                        _Figures=new SmGeometries.Geometry[] { new SmGeometries.Polygon() };
                    break;
                }

                _CurrentType.Pop();

                if (_CurrentType.Count==0)
                    _Figures[0].SpatialReference=_SpatialReference;
            }

            public SmGeometries.Geometry Geometry
            {
                get
                {
                    Debug.Assert(_Figures.Count==1);
                    return _Figures[0];
                }
            }

            private ICoordinateSystem _SpatialReference;
            private Stack<GeometryType> _CurrentType=new Stack<GeometryType>();
            private IList<SmGeometries.Point> _CurrentPoints=new List<SmGeometries.Point>();
            private IList<SmGeometries.Geometry> _Figures=new List<SmGeometries.Geometry>();
        }

        /// <summary>Creates a new instance of the <see cref="SharpGeometryBuilder" /> class.</summary>
        public SharpGeometryBuilder():
            base()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SharpGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public SharpGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
        public override void BeginGeometry(GeometryType type)
        {
            _Sink.BeginGeometry(type);
        }

        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        /// <inheritdoc />
        public override void EndFigure()
        {
            base.EndFigure();

            _Sink.EndFigure();
        }

        /// <summary>Finishes the call sequence for a geometry representation.</summary>
        /// <inheritdoc />
        public override void EndGeometry()
        {
            base.EndGeometry();

            _Sink.EndGeometry();
        }

        /// <summary>Sets the coordinate system of the geometry representation.</summary>
        /// <inheritdoc />
        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            base.DoSetCoordinateSystem(system);

            _Sink.SetCoordinateSystem(system);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Sink.BeginFigure(x, y, z);
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            _Sink.AddLine(x, y, z);
        }

        /// <summary>Returns the geometry defined by the specified WKT representation, in the specified coordinate system.</summary>
        /// <param name="text">The WKT representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKT representation.</param>
        public void Parse(string text, ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            var g=SmGeometries.Geometry.GeomFromText(text);
            g.SpatialReference=system;

            if ((TargetSystem!=null) && ((system!=TargetSystem) || !system.EqualParams(TargetSystem)))
            {
                _Geometry=null;
                var orig=new SharpGeometry(g);
                orig.Populate(this);
            } else
                _Geometry=new SharpGeometry(g);
        }

        /// <summary>Returns the geometry resulting from the actions on the current <see cref="SharpGeometryBuilder" />.</summary>
        public SharpGeometry ConstructedGeometry
        {
            get
            {
                if (_Geometry==null)
                    _Geometry=new SharpGeometry(_Sink.Geometry);

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

        private Sink _Sink=new Sink();
        private SharpGeometry _Geometry;
    }
}
