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
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using ProjNet.CoordinateSystems;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="SqlTypes.SqlGeography" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed partial class SqlGeography:
        IGeometry
    {

        /// <summary>Creates a new instance of the <see cref="SqlGeometry" /> class.</summary>
        public SqlGeography() :
            this(new SqlTypes.SqlGeography())
        {
        }

        /// <summary>Creates a new instance of the <see cref="SqlGeometry" /> class.</summary>
        public SqlGeography(SqlTypes.SqlGeography sg) :
            this(sg, null)
        {
        }

        internal SqlGeography(SqlTypes.SqlGeography sg, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(sg!=null);
            if (sg==null)
                throw new ArgumentNullException("sg");

            _Geography=sg;
            _CoordinateSystem=coordinateSystem;
        }

        /// <summary>Returns the string representation of this geometry.</summary>
        /// <returns>The string representation of this geometry.</returns>
        public override string ToString()
        {
            return _Geography.ToString();
        }

        //public bool Equals(IGeometry geometry)
        //{
        //    if (geometry==null)
        //        return false;

        //    var sgw=geometry as SqlGeography;
        //    if (sgw!=null)
        //    {
        //        var r=_Geography.STEquals(sgw._Geography);
        //        return r.IsTrue;
        //    }

        //    throw new NotImplementedException();
        //}

        /// <summary>Returns the centroid for the current geometry.</summary>
        /// <returns>The centroid for the current geometry.</returns>
        public ISimpleGeometry Centroid()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SqlGeometry.ToGeometry(this).Centroid());
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STDistance(other._Geography).Value;
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STDisjoint(other._Geography).Value;
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Touches(geometry);
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Within(geometry);
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Overlaps(geometry);
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Crosses(geometry);
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STIntersects(other._Geography).Value;
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Contains(geometry);
        }

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        public ISimpleGeometry Envelope()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SqlGeometry.ToGeometry(this).Envelope());
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            var sgs=sink as SqlTypes.IGeographySink;
            if (sgs==null)
                sgs=new Sink(sink);

            _Geography.Populate(sgs);
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
            writer.WriteRaw(_Geography.AsGml().Value);
        }

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SqlGeography" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SqlGeography ToGeography(ISimpleGeometry geometry)
        {
            var sg=geometry as SqlGeography;
            if (sg!=null)
                return sg;

            var sgb=new SqlGeographyBuilderWrapper();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry;
        }

        /// <summary>Converts the specified <paramref name="geography" /> into a <see cref="SqlTypes.SqlGeometry" />.</summary>
        /// <param name="geography">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static implicit operator SqlTypes.SqlGeography(SqlGeography geography)
        {
            return geography._Geography;
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (_CoordinateSystem==null)
                    _CoordinateSystem=CoordinateSystemProvider.Instance.GetById(new Srid(_Geography.STSrid.Value));

                return _CoordinateSystem;
            }
        }

        private SqlTypes.SqlGeography _Geography;
        private ICoordinateSystem _CoordinateSystem;
    }
}
