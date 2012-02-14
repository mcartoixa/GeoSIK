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

    public sealed partial class SqlGeographyWrapper:
        IGeometry
    {

        public SqlGeographyWrapper():
            this(new SqlTypes.SqlGeography())
        {
        }

        public SqlGeographyWrapper(SqlTypes.SqlGeography sg):
            this(sg, null)
        {
        }

        public SqlGeographyWrapper(SqlTypes.SqlGeography sg, ICoordinateSystem coordinateSystem)
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

            var sgw=geometry as SqlGeographyWrapper;
            if (sgw!=null)
            {
                var r=_Geography.STEquals(sgw._Geography);
                return r.IsTrue;
            }

            throw new NotImplementedException();
        }

        public double Distance(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Disjoint(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Touches(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Within(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Crosses(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Intersects(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Contains(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public bool Relate(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public double Length()
        {
            throw new NotImplementedException();
        }

        public int NumPoints()
        {
            throw new NotImplementedException();
        }

        public ISimpleGeometry Envelope()
        {
            // We would do this if we dealt with geometries anyway. Not sure it makes much sense, though...

            SqlTypes.SqlGeometry geom=SqlTypes.SqlGeometry.STGeomFromText((SqlChars)((SqlString)_Geography.ToString()), _Geography.STSrid.Value);
            SqlTypes.SqlGeometry env=geom.STEnvelope();

            return new SqlGeographyWrapper(
                SqlTypes.SqlGeography.STGeomFromText(
                    (SqlChars)((SqlString)env.ToString()),
                    _Geography.STSrid.Value
                ),
                CoordinateSystem
            );
        }

        public double GetLength()
        {
            throw new NotImplementedException();
        }

        public IGeometry GetPoint(int index)
        {
            return new SqlGeographyWrapper(_Geography.STPointN(index), CoordinateSystem);
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

        private IEnumerator<IGeometry> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IGeometry> GetPoints()
        {
            for (int i=0; i<_Geography.STNumPoints().Value; ++i)
                yield return new SqlGeographyWrapper(_Geography.STPointN(i));
        }

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        IEnumerator<IGeometry> IEnumerable<IGeometry>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private static SqlGeographyWrapper FromGeometry(IGeometry geometry)
        {
            var ret=geometry as SqlGeographyWrapper;
            if (ret!=null)
                return ret;

            var sgbw=new SqlGeographyBuilderWrapper();
            geometry.Populate(sgbw);
            ret=sgbw.ConstructedGeometry;

            return ret;
        }

        public static implicit operator SqlTypes.SqlGeography(SqlGeographyWrapper wrapper)
        {
            return wrapper._Geography;
        }

        public double X
        {
            get { return _Geography.Long.Value; }
        }

        public double Y
        {
            get { return _Geography.Lat.Value; }
        }

        public double? Z
        {
            get
            {
                double? ret=null;
                if (!_Geography.Z.IsNull)
                    ret=_Geography.Z.Value;
                return ret;
            }
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
