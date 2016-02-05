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
using System.Data.Entity.Spatial;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using Gml=GeoSik.Ogc.Gml.V311;

namespace GeoSik.Data.Entity
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="DbGeometry" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class SpatialGeometry:
        IGeometry
    {

        /// <summary>Creates a new instance of the <see cref="SpatialGeometry" /> class.</summary>
        internal SpatialGeometry()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SpatialGeometry" /> class.</summary>
        public SpatialGeometry(DbGeometry g) :
            this(g, null)
        {
        }

        internal SpatialGeometry(DbGeometry g, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(g!=null);
            if (g==null)
                throw new ArgumentNullException("g");

            _Geometry=g;
            _CoordinateSystem=coordinateSystem;
        }

        /// <summary>Returns the string representation of this geometry.</summary>
        /// <returns>The string representation of this geometry.</returns>
        public override string ToString()
        {
            return _Geometry.ToString();
        }

        /// <summary>Returns the total surface area of the current geometry.</summary>
        /// <returns>The total surface area of the current geometry.</returns>
        public double Area()
        {
            return _Geometry.Area.Value;
        }

        /// <summary>Returns the centroid for the current geometry.</summary>
        /// <returns>The centroid for the current geometry.</returns>
        public ISimpleGeometry Centroid()
        {
            return new SpatialGeometry(_Geometry.Centroid, CoordinateSystem);
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Distance(other._Geometry).Value;
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Disjoint(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Touches(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Within(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Overlaps(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Crosses(other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Intersects(other._Geometry);
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            SpatialGeometry other=ToGeometry(geometry);
            return _Geometry.Contains(other._Geometry);
        }

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        public ISimpleGeometry Envelope()
        {
            return new SpatialGeometry(_Geometry.Envelope, _CoordinateSystem);
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            Gml._Geometry g=Gml._Geometry.Parse(_Geometry.AsGml());
            g.Populate(sink);
        }

        /// <summary>Converts a geometry into its GML representation.</summary>
        /// <param name="writer">The stream to which the geometry is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            var builder=new Gml.GmlGeometryBuilder(_CoordinateSystem);
            Populate(builder);
            IXmlSerializable xg=builder.ConstructedGeometry;

            xg.WriteXml(writer);
        }

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        /// <summary>Generates a geometry from its GML representation.</summary>
        /// <param name="reader">The stream from which the geometry is deserialized. </param>
        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            var xdoc=new XmlDocument();
            xdoc.Load(reader);
            Gml._Geometry g=Gml._Geometry.Parse(xdoc.DocumentElement.OuterXml);

            var builder=new SpatialGeometryBuilder();
            g.Populate(builder);

            _Geometry=SpatialGeometry.ToGeometry(builder.ConstructedGeometry);
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SpatialGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SpatialGeometry ToGeometry(ISimpleGeometry geometry)
        {
            var sg=geometry as SpatialGeometry;
            if (sg!=null)
                return sg;

            var sgb=new SpatialGeometryBuilder();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry as SpatialGeometry;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="DbGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static implicit operator DbGeometry(SpatialGeometry geometry)
        {
            return geometry._Geometry;
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (_CoordinateSystem==null)
                    _CoordinateSystem=CommonServiceLocator.GetCoordinateSystemProvider().GetById(new Srid(_Geometry.CoordinateSystemId));

                return _CoordinateSystem;
            }
        }

        private DbGeometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
