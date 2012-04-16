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
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class used to build <see cref="SqlGeometry" /> instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class SqlGeometryBuilder:
        GeometryTransformerSink,
        IGeometryBuilder,
        SqlTypes.IGeographySink,
        SqlTypes.IGeometrySink
    {

        /// <summary>Creates a new instance of the <see cref="SqlGeometryBuilder" /> class.</summary>
        public SqlGeometryBuilder():
            base()
        {
        }

        /// <summary>Creates a new instance of the <see cref="SqlGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public SqlGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
        public override void BeginGeometry(GeometryType type)
        {
            _Builder.BeginGeometry(type);
        }

        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        public override void EndFigure()
        {
            _Builder.EndFigure();
        }

        /// <summary>Finishes the call sequence for a geometry.</summary>
        public override void EndGeometry()
        {
            _Builder.EndGeometry();
        }

        /// <summary>Parses the geometry defined by the specified WKT representation, in the specified coordinate system.</summary>
        /// <param name="text">The WKT representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKT representation.</param>
        public void Parse(string text, ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            IGeometryBuilder builder=CreateBuilder(system);
            builder.Parse(text, system);
            IGeometry g=(IGeometry)builder.ConstructedGeometry;

            if ((TargetSystem!=null) && !system.SpatialReferenceEquals(TargetSystem))
                g.Populate(this);
            else
                _Geometry=g;
        }

        /// <summary>Parses the geometry defined by the specified WKB representation, in the specified coordinate system.</summary>
        /// <param name="data">The WKB representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKB representation.</param>
        public void Parse(byte[] data, ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            IGeometryBuilder builder=CreateBuilder(system);
            builder.Parse(data, system);
            IGeometry g=(IGeometry)builder.ConstructedGeometry;

            if ((TargetSystem!=null) && !system.SpatialReferenceEquals(TargetSystem))
                g.Populate(this);
            else
                _Geometry=g;
        }

        /// <summary>Sets the coordinate system of the geometry representation.</summary>
        /// <param name="system">The coordinate system of the geometry representation. Equivalent to <see cref="GeometryTransformerSink.TargetSystem" />.</param>
        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            base.DoSetCoordinateSystem(system);

            _Builder=CreateBuilder(system);
            _Builder.SetCoordinateSystem(system);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Builder.BeginFigure(x, y, z);
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            _Builder.AddLine(x, y, z);
        }

        private static IGeometryBuilder CreateBuilder(ICoordinateSystem system)
        {
            if ((system is IGeographicCoordinateSystem) || (system is IGeocentricCoordinateSystem))
                return new SqlGeographyBuilderWrapper();
            else
                return new SqlGeometryBuilderWrapper();
        }

        void SqlTypes.IGeographySink.AddLine(double latitude, double longitude, double? z, double? m)
        {
            AddLine(longitude, latitude, z);
        }

        void SqlTypes.IGeographySink.BeginFigure(double latitude, double longitude, double? z, double? m)
        {
            BeginFigure(longitude, latitude, z);
        }

        void SqlTypes.IGeographySink.BeginGeography(SqlTypes.OpenGisGeographyType type)
        {
            BeginGeometry(GeometryTypeUtils.Convert(type));
        }

        void SqlTypes.IGeographySink.EndFigure()
        {
            EndFigure();
        }

        void SqlTypes.IGeographySink.EndGeography()
        {
            EndGeometry();
        }

        void SqlTypes.IGeographySink.SetSrid(int srid)
        {
            SetCoordinateSystem(CoordinateSystemProvider.Instance.GetById(new Srid(srid)));
        }

        void SqlTypes.IGeometrySink.AddLine(double x, double y, double? z, double? m)
        {
            AddLine(x, y, z);
        }

        void SqlTypes.IGeometrySink.BeginFigure(double x, double y, double? z, double? m)
        {
            BeginFigure(x, y, z);
        }

        void SqlTypes.IGeometrySink.BeginGeometry(SqlTypes.OpenGisGeometryType type)
        {
            BeginGeometry(GeometryTypeUtils.Convert(type));
        }

        void SqlTypes.IGeometrySink.EndFigure()
        {
            EndFigure();
        }

        void SqlTypes.IGeometrySink.EndGeometry()
        {
            EndGeometry();
        }

        void SqlTypes.IGeometrySink.SetSrid(int srid)
        {
            SetCoordinateSystem(CoordinateSystemProvider.Instance.GetById(new Srid(srid)));
        }

        /// <summary>Returns the geometry resulting from the actions on the current <see cref="SqlGeometryBuilder" />.</summary>
        public IGeometry ConstructedGeometry
        {
            get
            {
                if (_Geometry==null)
                    _Geometry=(IGeometry)_Builder.ConstructedGeometry;

                return _Geometry;
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        private IGeometry _Geometry;
        private IGeometryBuilder _Builder;
    }
}
