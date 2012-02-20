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
using FCommon=OSGeo.FDO.Common;
using FGeometry=OSGeo.FDO.Geometry;

namespace GeoSik.Fdo
{

    public class FdoGeometry:
        ISimpleGeometry,
        IDisposable
    {

        private FdoGeometry()
        {
        }

        /// <summary>Creates a new instance of the <see cref="FdoGeometry" /> class that encapsulates
        /// a copy of the specified FDO geometry, in the specified coordinate system.</summary>
        /// <param name="geometry">The FDO geometry for which a copy will be encapsulated.</param>
        /// <param name="coordinateSystem">The coordinate system of the encapsulated FDO geometry.</param>
        /// <remarks>
        ///   <para>This instance encapsulates a copy of the specified <paramref name="geometry" />. It is thus
        /// the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the specified <paramref name="geometry" />.</para>
        /// </remarks>
        public FdoGeometry(FGeometry.IGeometry geometry, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(geometry!=null);
            if (geometry==null)
                throw new ArgumentNullException("geometry");
            Debug.Assert(coordinateSystem!=null);
            if (coordinateSystem==null)
                throw new ArgumentNullException("coordinateSystem");

            _Geometry=FdoGeometryBuilder.Factory.CreateGeometry(geometry);
            _CoordinateSystem=coordinateSystem;
        }

        ~FdoGeometry()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Gets the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        /// <remarks>
        ///   <para>It is the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the returned envelope.</para>
        /// </remarks>
        public FdoEnvelope Envelope()
        {
            return new FdoEnvelope(_Geometry.Envelope, CoordinateSystem);
        }

        public void Populate(IGeometrySink sink)
        {
            sink.SetCoordinateSystem(CoordinateSystem);
            sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.DerivedType));

            switch (_Geometry.DerivedType)
            {
            case FCommon.GeometryType.GeometryType_LineString:
                using (FGeometry.DirectPositionCollection positions=((FGeometry.ILineString)_Geometry).Positions)
                    CreateFigure(sink, positions);
                break;
            case FCommon.GeometryType.GeometryType_Point:
                using (FGeometry.DirectPositionCollection positions=new FGeometry.DirectPositionCollection())
                    using (FGeometry.IDirectPosition p=((FGeometry.IPoint)_Geometry).Position)
                    {
                        positions.Add(p);
                        CreateFigure(sink, positions);
                    }
                break;
            case FCommon.GeometryType.GeometryType_Polygon:
                {
                    var polygon=(FGeometry.IPolygon)_Geometry;
                    using (FGeometry.ILinearRing exterior=polygon.ExteriorRing)
                        using (FGeometry.DirectPositionCollection positions=exterior.Positions)
                            CreateFigure(sink, positions);

                    for (int i=0; i<polygon.InteriorRingCount; ++i)
                        using (FGeometry.ILinearRing interior=polygon.GetInteriorRing(i))
                            using (FGeometry.DirectPositionCollection positions=interior.Positions)
                                CreateFigure(sink, positions);
                }
                break;
            default:
                //TODO: implement other geometry types...
                throw new NotSupportedException();
            }

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

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Geometry!=null)
                    _Geometry.Dispose();
            }

            _Geometry=null;
        }

        ISimpleGeometry ISimpleGeometry.Envelope()
        {
            return Envelope();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        public static FGeometry.IGeometry ToNativeGeometry(FdoGeometry geometry)
        {
            return geometry._Geometry;
        }

        private static void CreateFigure(IGeometrySink sink, FGeometry.DirectPositionCollection positions)
        {
            if ((positions==null) || (positions.Count==0))
                return;

            using (FGeometry.IDirectPosition p0=positions[0])
            {
                if (p0.Dimensionality>2)
                    sink.BeginFigure(p0.X, p0.Y, p0.Z);
                else
                    sink.BeginFigure(p0.X, p0.Y, null);
            }

            for (int i=1; i<positions.Count; ++i)
                using (FGeometry.IDirectPosition pi=positions[i])
                {
                    if (pi.Dimensionality>2)
                        sink.BeginFigure(pi.X, pi.Y, pi.Z);
                    else
                        sink.BeginFigure(pi.X, pi.Y, null);
                }

            sink.EndFigure();
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _CoordinateSystem;
            }
        }

        private FGeometry.IGeometry _Geometry;
        private ICoordinateSystem _CoordinateSystem;
    }
}
