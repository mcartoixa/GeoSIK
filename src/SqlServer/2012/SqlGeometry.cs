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
using System.Xml.Schema;
using System.Xml.Serialization;
using SqlTypes=Microsoft.SqlServer.Types;
using Microsoft.Practices.ServiceLocation;

namespace GeoSik.SqlServer
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="SqlTypes.SqlGeometry" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed partial class SqlGeometry:
        IGeometry
    {

        /// <summary>Creates a new instance of the <see cref="SqlGeometry" /> class.</summary>
        public SqlGeometry():
            this(new SqlTypes.SqlGeometry())
        {
        }

        /// <summary>Creates a new instance of the <see cref="SqlGeometry" /> class.</summary>
        public SqlGeometry(SqlTypes.SqlGeometry sg):
            this(sg, null)
        {
        }

        internal SqlGeometry(SqlTypes.SqlGeometry sg, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(sg!=null);
            if (sg==null)
                throw new ArgumentNullException("sg");

            _Geometry=sg;
            _CoordinateSystem=coordinateSystem;
        }

        /// <summary>Returns the string representation of this geometry.</summary>
        /// <returns>The string representation of this geometry.</returns>
        public override string ToString()
        {
            return _Geometry.ToString();
        }

        //public bool Equals(IGeometry geometry)
        //{
        //    if (geometry==null)
        //        return false;

        //    var sgw=geometry as SqlGeometry;
        //    if (sgw!=null)
        //    {
        //        var r=_Geometry.STEquals(sgw._Geometry);
        //        return r.IsTrue;
        //    }

        //    throw new NotImplementedException();
        //}

        /// <summary>Returns the centroid for the current geometry.</summary>
        /// <returns>The centroid for the current geometry.</returns>
        public ISimpleGeometry Centroid()
        {
            return new SqlGeometry(_Geometry.STCentroid(), CoordinateSystem);
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STDistance(other._Geometry).Value;
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STDisjoint(other._Geometry).Value;
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STTouches(other._Geometry).Value;
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STWithin(other._Geometry).Value;
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STOverlaps(other._Geometry).Value;
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STCrosses(other._Geometry).Value;
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STIntersects(other._Geometry).Value;
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            SqlGeometry other=ToGeometry(geometry);
            return _Geometry.STContains(other._Geometry).Value;
        }

        //public bool Relate(ISimpleGeometry geometry, string intersectionPatternMatrix)
        //{
        //    SqlGeometry other=ToGeometry(geometry);
        //    return _Geometry.STRelate(other._Geometry, intersectionPatternMatrix).Value;
        //}

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        public ISimpleGeometry Envelope()
        {
            return new SqlGeometry(_Geometry.STEnvelope(), CoordinateSystem);
        }

        /// <summary>Returns a valid representation of the current geometry.</summary>
        /// <returns>The valid representation of the current geometry.</returns>
        public SqlGeometry MakeValid()
        {
            return new SqlGeometry(_Geometry.MakeValid());
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            var sgs=sink as SqlTypes.IGeometrySink110;
            if (sgs==null)
                sgs=new Sink(sink);

            _Geometry.Populate(sgs);
        }

        /// <summary>Converts a geometry into its GML representation.</summary>
        /// <param name="writer">The stream to which the geometry is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            ((IXmlSerializable)_Geometry.AsGml()).WriteXml(writer);
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        /// <summary>Generates a geometry from its GML representation.</summary>
        /// <param name="reader">The stream from which the geometry is deserialized. </param>
        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            _Geometry=SqlTypes.SqlGeometry.GeomFromGml(new SqlXml(reader), _Geometry.STSrid.Value);
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SqlGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static SqlGeometry ToGeometry(ISimpleGeometry geometry)
        {
            var sg=geometry as SqlGeometry;
            if (sg!=null)
                return sg;

            var sgb=new SqlGeometryBuilderWrapper();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="SqlTypes.SqlGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static implicit operator SqlTypes.SqlGeometry(SqlGeometry geometry)
        {
            return geometry._Geometry;
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (_CoordinateSystem==null)
                    _CoordinateSystem=CommonServiceLocator.GetCoordinateSystemProvider().GetById(new Srid(_Geometry.STSrid.Value));

                return _CoordinateSystem;
            }
        }

        private SqlTypes.SqlGeometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
