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

    public sealed class SqlGeometryWrapper:
        IGeometry
    {

        public SqlGeometryWrapper():
            this(new SqlTypes.SqlGeometry())
        {
        }

        public SqlGeometryWrapper(SqlTypes.SqlGeometry sg):
            this(sg, null)
        {
        }

        public SqlGeometryWrapper(SqlTypes.SqlGeometry sg, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(sg!=null);
            if (sg==null)
                throw new ArgumentNullException("sg");

            _Geometry=sg;
            _CoordinateSystem=coordinateSystem;
        }

        public override string ToString()
        {
            return _Geometry.ToString();
        }

        public bool Equals(IGeometry geometry)
        {
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

        public IGeometry GetEnvelope()
        {
            return new SqlGeometryWrapper(_Geometry.STEnvelope(), CoordinateSystem);
        }

        public double GetLength()
        {
            throw new NotImplementedException();
        }

        public IGeometry GetPoint(int index)
        {
            return new SqlGeometryWrapper(_Geometry.STPointN(index), CoordinateSystem);
        }

        public void Populate(IGeometrySink sink)
        {
            var sgs=sink as SqlTypes.IGeometrySink;
            if (sgs!=null)
                _Geometry.Populate(sgs);
            else
                throw new NotSupportedException();
        }

        public void ReadXml(XmlReader xr)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter xw)
        {
            xw.WriteRaw(_Geometry.AsGml().Value);
        }

        private IEnumerator<IGeometry> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IGeometry> GetPoints()
        {
            for (int i=0; i<_Geometry.STNumPoints().Value; ++i)
                yield return new SqlGeometryWrapper(_Geometry.STPointN(i));
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

        public static implicit operator SqlTypes.SqlGeometry(SqlGeometryWrapper wrapper)
        {
            return wrapper._Geometry;
        }

        public double X
        {
            get { return _Geometry.STX.Value; }
        }

        public double Y
        {
            get { return _Geometry.STY.Value; }
        }

        public double? Z
        {
            get
            {
                double? ret=null;
                if (!_Geometry.Z.IsNull)
                    ret=_Geometry.Z.Value;
                return ret;
            }
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (_CoordinateSystem==null)
                    _CoordinateSystem=CoordinateSystemProvider.Instance.GetById(new Srid(_Geometry.STSrid.Value));

                return _CoordinateSystem;
            }
        }

        private SqlTypes.SqlGeometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
