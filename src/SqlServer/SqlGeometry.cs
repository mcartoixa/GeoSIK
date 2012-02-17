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

    public sealed partial class SqlGeometry:
        IGeometry
    {

        public SqlGeometry():
            this(new SqlTypes.SqlGeometry())
        {
        }

        public SqlGeometry(SqlTypes.SqlGeometry sg):
            this(sg, null)
        {
        }

        public SqlGeometry(SqlTypes.SqlGeometry sg, ICoordinateSystem coordinateSystem)
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
            if (geometry==null)
                return false;

            var sgw=geometry as SqlGeometry;
            if (sgw!=null)
            {
                var r=_Geometry.STEquals(sgw._Geometry);
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

        public IGeometry Centroid()
        {
            return new SqlGeometry(_Geometry.STCentroid(), CoordinateSystem);
        }

        public ISimpleGeometry Envelope()
        {
            return new SqlGeometry(_Geometry.STEnvelope(), CoordinateSystem);
        }

        public void Populate(IGeometrySink sink)
        {
            var sgs=sink as SqlTypes.IGeometrySink;
            if (sgs==null)
                sgs=new Sink(sink);

            _Geometry.Populate(sgs);
        }

        public void ReadXml(XmlReader xr)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter xw)
        {
            xw.WriteRaw(_Geometry.AsGml().Value);
        }

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        private static SqlGeometry FromGeometry(IGeometry geometry)
        {
            var ret=geometry as SqlGeometry;
            if (ret!=null)
                return ret;

            var sgbw=new SqlGeometryBuilderWrapper();
            geometry.Populate(sgbw);
            ret=sgbw.ConstructedGeometry;

            return ret;
        }

        public static implicit operator SqlTypes.SqlGeometry(SqlGeometry wrapper)
        {
            return wrapper._Geometry;
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
