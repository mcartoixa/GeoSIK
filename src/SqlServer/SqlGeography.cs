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

    public sealed partial class SqlGeography:
        IGeometry
    {

        public SqlGeography():
            this(new SqlTypes.SqlGeography())
        {
        }

        public SqlGeography(SqlTypes.SqlGeography sg):
            this(sg, null)
        {
        }

        public SqlGeography(SqlTypes.SqlGeography sg, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(sg!=null);
            if (sg==null)
                throw new ArgumentNullException("sg");

            _Geography=sg;
            _CoordinateSystem=coordinateSystem;
        }

        public override string ToString()
        {
            return _Geography.ToString();
        }

        public bool Equals(IGeometry geometry)
        {
            if (geometry==null)
                return false;

            var sgw=geometry as SqlGeography;
            if (sgw!=null)
            {
                var r=_Geography.STEquals(sgw._Geography);
                return r.IsTrue;
            }

            throw new NotImplementedException();
        }

        public IGeometry Centroid()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SqlGeometry.ToGeometry(this).Centroid());
        }

        public double Distance(IGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STDistance(other._Geography).Value;
        }

        public bool Disjoint(IGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STDisjoint(other._Geography).Value;
        }

        public bool Touches(IGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Touches(geometry);
        }

        public bool Within(IGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Within(geometry);
        }

        public bool Overlaps(IGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Overlaps(geometry);
        }

        public bool Crosses(IGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Crosses(geometry);
        }

        public bool Intersects(IGeometry geometry)
        {
            SqlGeography other=ToGeography(geometry);
            return _Geography.STIntersects(other._Geography).Value;
        }

        public bool Contains(IGeometry geometry)
        {
            // Transform into SqlGeometry, then calculate
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return SqlGeometry.ToGeometry(this).Contains(geometry);
        }

        public ISimpleGeometry Envelope()
        {
            // Transform into SqlGeometry, calculate, then back to SqlGeography
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            return ToGeography(SqlGeometry.ToGeometry(this).Envelope());
        }

        public void Populate(IGeometrySink sink)
        {
            var sgs=sink as SqlTypes.IGeographySink;
            if (sgs==null)
                sgs=new Sink(sink);

            _Geography.Populate(sgs);
        }

        public void ReadXml(XmlReader xr)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter xw)
        {
            xw.WriteRaw(_Geography.AsGml().Value);
        }

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        public static SqlGeography ToGeography(ISimpleGeometry geometry)
        {
            var sg=geometry as SqlGeography;
            if (sg!=null)
                return sg;

            var sgb=new SqlGeographyBuilderWrapper();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry;
        }

        public static implicit operator SqlTypes.SqlGeography(SqlGeography wrapper)
        {
            return wrapper._Geography;
        }

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
