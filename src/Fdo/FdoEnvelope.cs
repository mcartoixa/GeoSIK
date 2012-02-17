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

    public class FdoEnvelope:
        ISimpleGeometry,
        IDisposable
    {

        private FdoEnvelope()
        {
        }

        public FdoEnvelope(FGeometry.IEnvelope envelope, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(envelope!=null);
            if (envelope==null)
                throw new ArgumentNullException("envelope");
            Debug.Assert(coordinateSystem!=null);
            if (coordinateSystem==null)
                throw new ArgumentNullException("coordinateSystem");

            _Envelope=envelope;
            _CoordinateSystem=coordinateSystem;
        }

        ~FdoEnvelope()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public ISimpleGeometry Envelope()
        {
            return this;
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
            sink.SetCoordinateSystem(CoordinateSystem);

            sink.BeginGeometry(GeometryType.Polygon);

            sink.BeginFigure(_Envelope.MinX, _Envelope.MinY, null);
            sink.AddLine(_Envelope.MaxX, _Envelope.MinY, null);
            sink.AddLine(_Envelope.MaxX, _Envelope.MaxY, null);
            sink.AddLine(_Envelope.MinX, _Envelope.MaxY, null);
            sink.AddLine(_Envelope.MinX, _Envelope.MinY, null);
            sink.EndFigure();

            sink.EndGeometry();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _Envelope.Dispose();

            _Envelope=null;
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        private FGeometry.IEnvelope _Envelope;
        private ICoordinateSystem _CoordinateSystem;
    }
}
