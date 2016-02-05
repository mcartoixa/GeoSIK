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



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="FGeometry.IEnvelope" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class FdoEnvelope:
        ISimpleGeometry,
        IDisposable
    {

        private FdoEnvelope()
        {
        }

        /// <summary>Creates a new instance of the <see cref="FdoGeometry" /> class that encapsulates
        /// a copy of the specified FDO envelope, in the specified coordinate system.</summary>
        /// <param name="envelope">The FDO envelope for which a copy will be encapsulated.</param>
        /// <param name="coordinateSystem">The coordinate system of the encapsulated FDO geometry.</param>
        /// <remarks>
        ///   <para>This instance encapsulates a copy of the specified <paramref name="envelope" />. It is thus
        /// the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the specified <paramref name="envelope" />.</para>
        /// </remarks>
        public FdoEnvelope(FGeometry.IEnvelope envelope, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(envelope!=null);
            if (envelope==null)
                throw new ArgumentNullException("envelope");
            Debug.Assert(coordinateSystem!=null);
            if (coordinateSystem==null)
                throw new ArgumentNullException("coordinateSystem");

            _Envelope=FdoGeometryBuilder.Factory.CreateEnvelope(envelope);
            _CoordinateSystem=coordinateSystem;
        }

        /// <summary>Finalizes the current instance.</summary>
        ~FdoEnvelope()
        {
            Dispose(false);
        }

        /// <summary>Releases native resources associated with the current instance.</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Gets a copy of the current envelope.</summary>
        /// <returns>The copy of the current envelope.</returns>
        /// <remarks>
        ///   <para>It is the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the returned instance.</para>
        /// </remarks>
        public FdoEnvelope Envelope()
        {
            // Create a copy that can be disposed
            return new FdoEnvelope(this._Envelope, CoordinateSystem);
        }

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
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
            throw new NotImplementedException();
        }

        /// <summary>Converts the specified <paramref name="envelope" /> into a <see cref="FGeometry.IEnvelope" />.</summary>
        /// <param name="envelope">The envelope to convert.</param>
        /// <returns>The converted envelope.</returns>
        public static FGeometry.IEnvelope ToEnvelope(FdoEnvelope envelope)
        {
            return envelope._Envelope;
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Envelope!=null)
                    _Envelope.Dispose();
            }

            _Envelope=null;
        }

        ISimpleGeometry ISimpleGeometry.Envelope()
        {
            return Envelope();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _CoordinateSystem;
            }
        }

        private FGeometry.IEnvelope _Envelope;
        private ICoordinateSystem _CoordinateSystem;
    }
}
