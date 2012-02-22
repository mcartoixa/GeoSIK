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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ProjNet.CoordinateSystems;
using SmGeometries=SharpMap.Geometries;

namespace GeoSik.SharpMap
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="SmGeometries.Geometry" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

#pragma warning disable 3001, 3002
    public class SharpGeometry:
        IGeometry
    {

        /// <summary>Creates a new instance of the <see cref="SharpGeometry" /> class.</summary>
        private SharpGeometry()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SharpGeometry" /> class.</summary>
        /// <param name="geometry">The <see cref="SmGeometries.Geometry" /> to encapsulate.</param>
        public SharpGeometry(SmGeometries.Geometry geometry)
        {
            Debug.Assert(geometry!=null);
            if (geometry==null)
                throw new ArgumentNullException("geometry");
            Debug.Assert(geometry.SpatialReference!=null);
            if (geometry.SpatialReference==null)
                throw new ArgumentException(SR.SharpMapSpatialReferenceMustBeInitiliazed, "geometry");

            _Geometry=geometry;
        }

        /// <summary>Returns the centroid for the current geometry.</summary>
        /// <returns>The centroid for the current geometry.</returns>
        public SharpGeometry Centroid()
        {
            var p=_Geometry as SmGeometries.Point;
            if (p!=null)
                return this;

            var pol=_Geometry as SmGeometries.Polygon;
            if (pol!=null)
                return new SharpGeometry(pol.Centroid);

            throw new NotSupportedException();
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Distance(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Disjoint(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Touches(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Within(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Overlaps(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Crosses(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Intersects(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Contains(other._Geometry);
        }

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        public SharpGeometry Envelope()
        {
            return new SharpGeometry(_Geometry.Envelope());
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            sink.SetCoordinateSystem(CoordinateSystem);
            sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.GeometryType));

            switch (_Geometry.GeometryType)
            {
            case SmGeometries.GeometryType2.LineString:
                CreateFigure(sink, ((SmGeometries.LineString)_Geometry).Vertices);
                break;
            case SmGeometries.GeometryType2.Point:
                CreateFigure(sink, new SmGeometries.Point[] { (SmGeometries.Point)_Geometry });
                break;
            case SmGeometries.GeometryType2.Polygon:
                {
                    var pol=(SmGeometries.Polygon)_Geometry;
                    CreateFigure(sink, pol.ExteriorRing.Vertices);

                    if (pol.InteriorRings!=null)
                        foreach (SmGeometries.LinearRing lr in pol.InteriorRings)
                            CreateFigure(sink, lr.Vertices);
                }
                break;
            default:
                //TODO: implement other geometry types...
                throw new NotSupportedException();
            }

            sink.EndGeometry();
        }

        /// <summary>Generates a geometry from its GML representation.</summary>
        /// <param name="reader">The stream from which the geometry is deserialized. </param>
        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>Converts a geometry into its GML representation.</summary>
        /// <param name="writer">The stream to which the geometry is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        ISimpleGeometry IGeometry.Centroid()
        {
            return Centroid();
        }

        ISimpleGeometry ISimpleGeometry.Envelope()
        {
            return Envelope();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        private static SharpGeometry Convert(ISimpleGeometry geometry)
        {
            var sg=geometry as SharpGeometry;
            if (sg!=null)
                return sg;

            var sgb=new SharpGeometryBuilder();
            geometry.Populate(sgb);
            return (SharpGeometry)sgb.ConstructedGeometry;
        }

        private static void CreateFigure(IGeometrySink sink, IList<SmGeometries.Point> points)
        {
            if ((points==null) || (points.Count==0))
                return;

            var p0=points[0];
            var p03=p0 as SmGeometries.Point3D;
            if (p03!=null)
                sink.BeginFigure(p03.X, p03.Y, p03.Z);
            else
                sink.BeginFigure(p0.X, p0.Y, null);

            for (int i=1; i<points.Count; ++i)
            {
                var pi=points[i];
                var pi3=pi as SmGeometries.Point3D;
                if (pi3!=null)
                    sink.AddLine(pi3.X, pi3.Y, pi3.Z);
                else
                    sink.AddLine(pi.X, pi.Y, null);
            }

            sink.EndFigure();
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SmGeometries.Geometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SmGeometries.Geometry ToGeometry(SharpGeometry geometry)
        {
            return geometry._Geometry;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SharpGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SharpGeometry ToSharpGeometry(SmGeometries.Geometry geometry)
        {
            return new SharpGeometry(geometry);
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SmGeometries.Geometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static implicit operator SmGeometries.Geometry(SharpGeometry geometry)
        {
            return geometry._Geometry;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SharpGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static explicit operator SharpGeometry(SmGeometries.Geometry geometry)
        {
            return new SharpGeometry(geometry);
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _Geometry.SpatialReference;
            }
        }

        private SmGeometries.Geometry _Geometry;
    }
#pragma warning restore 3001, 3002
}
