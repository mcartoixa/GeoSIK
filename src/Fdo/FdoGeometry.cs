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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ProjNet.CoordinateSystems;
using FCommon=OSGeo.FDO.Common;
using FFilter=OSGeo.FDO.Filter;
using FGeometry=OSGeo.FDO.Geometry;
using FSpatial=OSGeo.FDO.Spatial;
using Gml=GeoSik.Ogc.Gml.V311;

namespace GeoSik.Fdo
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Encapsulates a <see cref="FGeometry.IGeometry" /> as a <see cref="IGeometry" />.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class FdoGeometry:
        IGeometry,
        IDisposable,
        ICloneable
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

        /// <summary>Finalizes the current instance.</summary>
        ~FdoGeometry()
        {
            Dispose(false);
        }

        /// <summary>Returns a copy of the current geometry.</summary>
        /// <returns>A copy of the current geometry.</returns>
        /// <remarks>
        ///   <para>It is the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the returned geometry.</para>
        /// </remarks>
        public FdoGeometry Clone()
        {
            return new FdoGeometry(
                FdoGeometryBuilder.Factory.CreateGeometry(_Geometry),
                CoordinateSystem
            );
        }

        /// <summary>Releases native resources associated with the current instance.</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Returns the total surface area of the current geometry.</summary>
        /// <returns>The total surface area of the current geometry.</returns>
        public double Area()
        {
            throw new NotImplementedException();
        }

        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        public double Distance(ISimpleGeometry geometry)
        {
            throw new NotSupportedException();
        }

        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        public bool Disjoint(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Disjoint, other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        public bool Touches(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Touches, other._Geometry);
        }

        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Within(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Within, other._Geometry);
        }

        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Overlaps(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Overlaps, other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        public bool Crosses(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Crosses, other._Geometry);
        }

        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        public bool Intersects(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Intersects, other._Geometry);
        }

        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        public bool Contains(ISimpleGeometry geometry)
        {
            using (FdoGeometry other=Convert(geometry))
                return FSpatial.SpatialUtility.Evaluate(_Geometry, FFilter.SpatialOperations.SpatialOperations_Contains, other._Geometry);
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

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        /// <param name="sink">The sink to populate.</param>
        /// <remarks>
        ///   <para>The call sequence is a set of figures, lines, and points for geometry types.</para>
        /// </remarks>
        public void Populate(IGeometrySink sink)
        {
            sink.SetCoordinateSystem(CoordinateSystem);

            switch (_Geometry.DerivedType)
            {
            case FCommon.GeometryType.GeometryType_LineString:
            case FCommon.GeometryType.GeometryType_Point:
            case FCommon.GeometryType.GeometryType_Polygon:
                _PopulateSimpleType(sink, _Geometry);
                break;
            case FCommon.GeometryType.GeometryType_MultiLineString:
                sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.DerivedType));
                {
                    var multiLineString=(FGeometry.IMultiLineString)_Geometry;
                    for (int i=0; i<multiLineString.Count; ++i)
                        using (FGeometry.ILineString lineString=multiLineString[i])
                            _PopulateSimpleType(sink, lineString);
                }
                sink.EndGeometry();
                break;
            case FCommon.GeometryType.GeometryType_MultiPoint:
                sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.DerivedType));
                {
                    var multiPoint=(FGeometry.IMultiPoint)_Geometry;
                    using (FGeometry.DirectPositionCollection positions=new FGeometry.DirectPositionCollection())
                        for (int i=0; i<multiPoint.Count; ++i)
                            using (FGeometry.IPoint point=multiPoint[i])
                                _PopulateSimpleType(sink, point);
                }
                sink.EndGeometry();
                break;
            case FCommon.GeometryType.GeometryType_MultiPolygon:
                sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.DerivedType));
                {
                    var multiPolygon=(FGeometry.IMultiPolygon)_Geometry;
                    for (int i=0; i<multiPolygon.Count; ++i)
                        using (FGeometry.IPolygon polygon=multiPolygon[i])
                            _PopulateSimpleType(sink, polygon);
                }
                sink.EndGeometry();
                break;
            case FCommon.GeometryType.GeometryType_MultiGeometry:
                sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.DerivedType));
                {
                    var multiGeometry=(FGeometry.IMultiGeometry)_Geometry;
                    for (int i=0; i<multiGeometry.Count; ++i)
                        using (FGeometry.IGeometry geometry=multiGeometry[i])
                            _PopulateSimpleType(sink, geometry);
                }
                sink.EndGeometry();
                break;
            default:
                throw new NotSupportedException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.UnsupportedGeometryTypeException,
                        _Geometry.DerivedType
                    )
                );
            }

        }

        /// <summary>Converts a geometry into its GML representation.</summary>
        /// <param name="writer">The stream to which the geometry is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            var builder=new Gml.GmlGeometryBuilder();
            Populate(builder);
            IXmlSerializable xg=builder.ConstructedGeometry;

            xg.WriteXml(writer);
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

        private static void _PopulateSimpleType(IGeometrySink sink, FGeometry.IGeometry geometry)
        {
            sink.BeginGeometry(GeometryTypeUtils.Convert(geometry.DerivedType));

            switch (geometry.DerivedType)
            {
            case FCommon.GeometryType.GeometryType_LineString:
                using (FGeometry.DirectPositionCollection positions=((FGeometry.ILineString)geometry).Positions)
                    CreateFigure(sink, positions);
                break;
            case FCommon.GeometryType.GeometryType_Point:
                using (FGeometry.DirectPositionCollection positions=new FGeometry.DirectPositionCollection())
                    using (FGeometry.IDirectPosition dp=((FGeometry.IPoint)geometry).Position)
                    {
                        positions.Add(dp);
                        CreateFigure(sink, positions);
                    }
                break;
            case FCommon.GeometryType.GeometryType_Polygon:
                {
                    var polygon=(FGeometry.IPolygon)geometry;
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
                throw new NotSupportedException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.UnsupportedGeometryTypeException,
                        geometry.DerivedType
                    )
                );
            }

            sink.EndGeometry();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        ISimpleGeometry ISimpleGeometry.Envelope()
        {
            return Envelope();
        }

        /// <summary>Generates a geometry from its GML representation.</summary>
        /// <param name="reader">The stream from which the geometry is deserialized. </param>
        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            var xdoc=new XmlDocument();
            xdoc.Load(reader);

            Gml._Geometry g=Gml._Geometry.Parse(xdoc.DocumentElement.OuterXml);
            using (var builder=new FdoGeometryBuilder())
            {
                g.Populate(builder);

                if (_Geometry!=null)
                {
                    _Geometry.Dispose();
                    _Geometry=null;
                    _CoordinateSystem=null;
                }
                using (FdoGeometry ng=builder.ConstructedGeometry)
                {
                    _Geometry=FdoGeometry.ToGeometry(ng);
                    _CoordinateSystem=ng._CoordinateSystem;
                }
            }
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        /// <summary>Converts the specified <paramref name="geometry" /> into a <see cref="FGeometry.IGeometry" />.</summary>
        /// <param name="geometry">The geometry to convert.</param>
        /// <returns>The converted geometry.</returns>
        public static FGeometry.IGeometry ToGeometry(FdoGeometry geometry)
        {
            return geometry._Geometry;
        }

        private static FdoGeometry Convert(ISimpleGeometry geometry)
        {
            var sg=geometry as FdoGeometry;
            if (sg!=null)
                return sg.Clone();

            var sgb=new FdoGeometryBuilder();
            geometry.Populate(sgb);
            return sgb.ConstructedGeometry;
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
                        sink.AddLine(pi.X, pi.Y, pi.Z);
                    else
                        sink.AddLine(pi.X, pi.Y, null);
                }

            sink.EndFigure();
        }

        /// <summary>Gets the coordinate system for the current geometry.</summary>
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
