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
using System.Data.Entity.Spatial;
using System.Diagnostics;
using Gml=GeoSik.Ogc.Gml.V311;

namespace GeoSik.Data.Entity
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class used to build <see cref="SpatialGeometry" /> instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class SpatialGeometryBuilder:
        GeometryTransformerSink,
        IGeometryBuilder
    {

        /// <summary>Creates a new instance of the <see cref="SpatialGeometryBuilder" /> class.</summary>
        public SpatialGeometryBuilder():
            base()
        {
            _Builder=new Gml.GmlGeometryBuilder();
        }

        /// <summary>Creates a new instance of the <see cref="SpatialGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public SpatialGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
            _Builder=new Gml.GmlGeometryBuilder();
            _CoordinateSystem=targetSystem;
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

            _Builder=new Gml.GmlGeometryBuilder(system);
            _Builder.Parse(text, system);
        }

        /// <summary>Parses the geometry defined by the specified WKB representation, in the specified coordinate system.</summary>
        /// <param name="data">The WKB representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKB representation.</param>
        void IGeometryBuilder.Parse(byte[] data, ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            var g=DbGeometry.FromBinary(data);
            _Builder=new Gml.GmlGeometryBuilder(system);
            _Builder.Parse(g.AsText(), system);
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

        /// <summary>Returns the geometry resulting from the actions on the current <see cref="SpatialGeometryBuilder" />.</summary>
        public IGeometry ConstructedGeometry
        {
            get
            {
                if ((_CoordinateSystem==null) || (_CoordinateSystem.IsProjected))
                    return new SpatialGeometry(DbGeometry.FromGml(_Builder.ConstructedGeometry.ToString()));
                return new SpatialGeography(DbGeography.FromGml(_Builder.ConstructedGeometry.ToString()));
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        private Gml.GmlGeometryBuilder _Builder;
        private ICoordinateSystem _CoordinateSystem;
    }
}
