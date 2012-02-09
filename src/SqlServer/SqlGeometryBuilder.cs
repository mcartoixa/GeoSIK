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
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{

    public sealed class SqlGeometryBuilder:
        IGeometryBuilder,
        SqlTypes.IGeographySink,
        SqlTypes.IGeometrySink
    {

        public SqlGeometryBuilder()
        {}

        public SqlGeometryBuilder(ICoordinateSystem sourceSystem)
        {
            _SourceSystem=sourceSystem;
        }

        public void SetCoordinateSystem(ICoordinateSystem targetSystem)
        {
            if (targetSystem==null)
                targetSystem=GeographicCoordinateSystem.WGS84;

            if ((targetSystem is IGeographicCoordinateSystem) || (targetSystem is IGeocentricCoordinateSystem))
                _Builder=new SqlGeometryBuilderWrapper();
            else
                _Builder=new SqlGeometryBuilderWrapper();

            _Builder.SetCoordinateSystem(targetSystem);
            _TargetSystem=targetSystem;

            if ((_SourceSystem!=null) && !_SourceSystem.Equals(_TargetSystem) && !_SourceSystem.EqualParams(_TargetSystem))
                _Transformation=new CoordinateTransformationFactory().CreateFromCoordinateSystems(_SourceSystem, _TargetSystem);
        }

        public void BeginGeometry(GeometryType type)
        {
            _Builder.BeginGeometry(type);
        }

        public void BeginFigure(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            _Builder.BeginFigure(x, y, z);
        }

        public void BeginFigure(double x, double y)
        {
            _Builder.BeginFigure(x, y, null);
        }

        public void AddLine(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            _Builder.AddLine(x, y, z);
        }

        public void AddLine(double x, double y)
        {
            _Builder.AddLine(x, y, null);
        }

        public void EndFigure()
        {
            _Builder.EndFigure();
        }

        public void EndGeometry()
        {
            _Builder.EndGeometry();
        }

        public IGeometry Parse(string text, ICoordinateSystem system)
        {
            return new SqlGeometryWrapper(SqlTypes.SqlGeometry.STGeomFromText((SqlChars)((SqlString)text), (int)system.AuthorityCode), system);
        }

        private double[] TransformCoordinates(double x, double y, double? z)
        {
            double[] ret=null;
            if (z.HasValue)
                ret=new double[] { x, y, z.Value };
            else
                ret=new double[] { x, y };

            if (_Transformation!=null)
                ret=_Transformation.MathTransform.Transform(ret);

            return ret;
        }

        void SqlTypes.IGeographySink.AddLine(double x, double y, double? z, double? m)
        {
            AddLine(x, y, z);
        }

        void SqlTypes.IGeographySink.BeginFigure(double x, double y, double? z, double? m)
        {
            BeginFigure(x, y, z);
        }

        void SqlTypes.IGeographySink.BeginGeography(SqlTypes.OpenGisGeographyType type)
        {
            switch (type)
            {
            case SqlTypes.OpenGisGeographyType.GeometryCollection:
                BeginGeometry(GeometryType.GeometryCollection);
                return;
            case SqlTypes.OpenGisGeographyType.LineString:
                BeginGeometry(GeometryType.LineString);
                return;
            case SqlTypes.OpenGisGeographyType.MultiLineString:
                BeginGeometry(GeometryType.MultiLineString);
                return;
            case SqlTypes.OpenGisGeographyType.MultiPoint:
                BeginGeometry(GeometryType.MultiPoint);
                return;
            case SqlTypes.OpenGisGeographyType.MultiPolygon:
                BeginGeometry(GeometryType.MultiPolygon);
                return;
            case SqlTypes.OpenGisGeographyType.Point:
                BeginGeometry(GeometryType.Point);
                return;
            case SqlTypes.OpenGisGeographyType.Polygon:
                BeginGeometry(GeometryType.Polygon);
                return;
            }

            throw new InvalidOperationException();
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
            switch (type)
            {
            case SqlTypes.OpenGisGeometryType.GeometryCollection:
                BeginGeometry(GeometryType.GeometryCollection);
                return;
            case SqlTypes.OpenGisGeometryType.LineString:
                BeginGeometry(GeometryType.LineString);
                return;
            case SqlTypes.OpenGisGeometryType.MultiLineString:
                BeginGeometry(GeometryType.MultiLineString);
                return;
            case SqlTypes.OpenGisGeometryType.MultiPoint:
                BeginGeometry(GeometryType.MultiPoint);
                return;
            case SqlTypes.OpenGisGeometryType.MultiPolygon:
                BeginGeometry(GeometryType.MultiPolygon);
                return;
            case SqlTypes.OpenGisGeometryType.Point:
                BeginGeometry(GeometryType.Point);
                return;
            case SqlTypes.OpenGisGeometryType.Polygon:
                BeginGeometry(GeometryType.Polygon);
                return;
            }

            throw new InvalidOperationException();
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

        public IGeometry ConstructedGeometry
        {
            get
            {
                var geomw=_Builder as SqlGeometryBuilderWrapper;
                if (geomw!=null)
                    return geomw.ConstructedGeometry;

                throw new InvalidOperationException();
            }
        }

        private IGeometrySink _Builder;
        private ICoordinateSystem _SourceSystem;
        private ICoordinateSystem _TargetSystem;
        private ICoordinateTransformation _Transformation;
    }
}
