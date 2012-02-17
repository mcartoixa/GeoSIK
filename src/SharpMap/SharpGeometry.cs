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

#pragma warning disable 3001
    public class SharpGeometry:
        IGeometry
    {

        private SharpGeometry()
        {
        }

        public SharpGeometry(SmGeometries.Geometry geometry)
        {
            Debug.Assert(geometry!=null);
            if (geometry==null)
                throw new ArgumentNullException("geometry");

            _Geometry=geometry;
        }

        public IGeometry Centroid()
        {
            var pol=_Geometry as SmGeometries.Polygon;
            if (pol!=null)
                return new SharpGeometry(pol.Centroid);

            throw new NotSupportedException();
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

        public ISimpleGeometry Envelope()
        {
            return new SharpGeometry(_Geometry.Envelope());
        }

        public void Populate(IGeometrySink sink)
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _Geometry.SpatialReference;
            }
        }

        private SmGeometries.Geometry _Geometry;
    }
#pragma warning restore 3001
}
