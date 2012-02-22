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

        /// <summary>Creates a new instance of the <see cref="SharpGeometryBuilder" /> class.</summary>
        public SharpGeometryBuilder():
            base()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SharpGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public SharpGeometryBuilder(ICoordinateSystem targetSystem) :
            base(targetSystem)
        {
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
        public override void BeginGeometry(GeometryType type)
        {
            _GeometryType=GeometryTypeUtils.Convert(type);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Figures.AddLast(new List<SmGeometries.Point>());
            DoAddLine(x, y, z);
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            LinkedListNode<IList<SmGeometries.Point>> last=_Figures.Last;
            if (z.HasValue)
                last.Value.Add(new SmGeometries.Point3D(x, y, z.Value));
            else
                last.Value.Add(new SmGeometries.Point(x, y));
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
                {
                    SmGeometries.Geometry g=null;
                    switch (_GeometryType)
                    {
                    case SmGeometries.GeometryType2.LineString:
                        g=new SmGeometries.LineString(_Figures.First.Value);
                        break;
                    case SmGeometries.GeometryType2.Point:
                        g=(SmGeometries.Geometry)_Figures.First.Value[0];
                        break;
                    case SmGeometries.GeometryType2.Polygon:
                        {
                            var exterior=new SmGeometries.LinearRing(_Figures.First.Value);
                            var interior=new List<SmGeometries.LinearRing>();

                            var current=_Figures.First;
                            while (current.Next!=_Figures.First)
                                interior.Add(new SmGeometries.LinearRing(current.Value));

                            g=new SmGeometries.Polygon(exterior, interior);
                        }
                        break;
                    default:
                        //TODO: implement other geometry types...
                        throw new NotImplementedException();
                    }

                    _Geometry=new SharpGeometry(g);
                }

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

        private SmGeometries.GeometryType2 _GeometryType;
        private LinkedList<IList<SmGeometries.Point>> _Figures=new LinkedList<IList<SmGeometries.Point>>();

        private SharpGeometry _Geometry;
    }
}
