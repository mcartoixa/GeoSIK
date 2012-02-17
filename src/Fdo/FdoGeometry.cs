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
using FGeometry=OSGeo.FDO.Geometry;

namespace GeoSik.Fdo
{

    public class FdoGeometry:
        ISimpleGeometry
    {

        private FdoGeometry()
        {
        }

        public FdoGeometry(FGeometry.IGeometry geometry, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(geometry!=null);
            if (geometry==null)
                throw new ArgumentNullException("geometry");
            Debug.Assert(coordinateSystem!=null);
            if (coordinateSystem==null)
                throw new ArgumentNullException("coordinateSystem");

            _Geometry=geometry;
            _CoordinateSystem=coordinateSystem;
        }

        public ISimpleGeometry Envelope()
        {
            return new FdoEnvelope(_Geometry.Envelope, CoordinateSystem);
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _CoordinateSystem;
            }
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

        public static FGeometry.IGeometry ToNativeGeometry(FdoGeometry geometry)
        {
            return geometry._Geometry;
        }

        private FGeometry.IGeometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
