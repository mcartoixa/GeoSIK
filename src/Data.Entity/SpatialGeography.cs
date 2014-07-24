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
    /// <summary>Encapsulates a <see cref="DbGeography" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class SpatialGeography:
        IGeometry
    {

        /// <summary>Creates a new instance of the <see cref="SpatialGeography" /> class.</summary>
        internal SpatialGeography()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SpatialGeography" /> class.</summary>
        public SpatialGeography(DbGeography g) :
            this(g, null)
        {
        }

        internal SpatialGeography(DbGeography g, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(g!=null);
            if (g==null)
                throw new ArgumentNullException("g");

            _Geography=g;
            _CoordinateSystem=coordinateSystem;
        }

        /// <summary>Returns the string representation of this geometry.</summary>
        /// <returns>The string representation of this geometry.</returns>
        public override string ToString()
        {
            return _Geography.ToString();
        }

        /// <summary>Returns the total surface area of the current geometry.</summary>
        /// <returns>The total surface area of the current geometry.</returns>
        public double Area()
        {
            return _Geography.Area.Value;
        }

        /// <summary>Returns the centroid for the current geometry.</summary>
        /// <returns>The centroid for the current geometry.</returns>
        public ISimpleGeometry Centroid()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SpatialGeometry.ToGeometry(this).Centroid());
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            SpatialGeography other=ToGeography(geometry);
            return _Geography.Distance(other._Geography).Value;
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            SpatialGeography other=ToGeography(geometry);
            return _Geography.Disjoint(other._Geography);
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SpatialGeometry.ToGeometry(this).Touches(geometry);
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SpatialGeometry.ToGeometry(this).Within(geometry);
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SpatialGeometry.ToGeometry(this).Overlaps(geometry);
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SpatialGeometry.ToGeometry(this).Crosses(geometry);
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            SpatialGeography other=ToGeography(geometry);
            return _Geography.Intersects(other._Geography);
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SpatialGeometry.ToGeometry(this).Contains(geometry);
        }

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        public ISimpleGeometry Envelope()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SpatialGeometry.ToGeometry(this).Envelope());
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            Gml._Geometry g=Gml._Geometry.Parse(_Geography.AsGml());
            g.Populate(sink);
        }

        /// <summary>Converts a geometry into its GML representation.</summary>
        /// <param name="writer">The stream to which the geometry is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            var builder=new Gml.GmlGeometryBuilder();
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

            _Geography=SpatialGeography.ToGeography(builder.ConstructedGeometry);
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SpatialGeography" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SpatialGeography ToGeography(ISimpleGeometry geometry)
        {
            var sg=geometry as SpatialGeography;
            if (sg!=null)
                return sg;

            var sgb=new SpatialGeometryBuilder();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry as SpatialGeography;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="DbGeography" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static implicit operator DbGeography(SpatialGeography geometry)
        {
            return geometry._Geography;
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (_CoordinateSystem==null)
                    _CoordinateSystem=CommonServiceLocator.GetCoordinateSystemProvider().GetById(new Srid(_Geography.CoordinateSystemId));

                return _CoordinateSystem;
            }
        }

        private DbGeography _Geography;
        private ICoordinateSystem _CoordinateSystem;
    }
}
