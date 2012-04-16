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
using System.Globalization;
using System.Linq;
using System.Text;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{
    internal static class GeometryTypeUtils
    {

        public static GeometryType Convert(SqlTypes.OpenGisGeometryType type)
        {
            switch (type)
            {
            case SqlTypes.OpenGisGeometryType.GeometryCollection:
                return GeometryType.GeometryCollection;
            case SqlTypes.OpenGisGeometryType.LineString:
                return GeometryType.LineString;
            case SqlTypes.OpenGisGeometryType.MultiLineString:
                return GeometryType.MultiLineString;
            case SqlTypes.OpenGisGeometryType.MultiPoint:
                return GeometryType.MultiPoint;
            case SqlTypes.OpenGisGeometryType.MultiPolygon:
                return GeometryType.MultiPolygon;
            case SqlTypes.OpenGisGeometryType.Point:
                return GeometryType.Point;
            case SqlTypes.OpenGisGeometryType.Polygon:
                return GeometryType.Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }

        public static GeometryType Convert(SqlTypes.OpenGisGeographyType type)
        {
            switch (type)
            {
            case SqlTypes.OpenGisGeographyType.GeometryCollection:
                return GeometryType.GeometryCollection;
            case SqlTypes.OpenGisGeographyType.LineString:
                return GeometryType.LineString;
            case SqlTypes.OpenGisGeographyType.MultiLineString:
                return GeometryType.MultiLineString;
            case SqlTypes.OpenGisGeographyType.MultiPoint:
                return GeometryType.MultiPoint;
            case SqlTypes.OpenGisGeographyType.MultiPolygon:
                return GeometryType.MultiPolygon;
            case SqlTypes.OpenGisGeographyType.Point:
                return GeometryType.Point;
            case SqlTypes.OpenGisGeographyType.Polygon:
                return GeometryType.Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }

        public static SqlTypes.OpenGisGeometryType ConvertToGeometry(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.GeometryCollection:
                return SqlTypes.OpenGisGeometryType.GeometryCollection;
            case GeometryType.LineString:
                return SqlTypes.OpenGisGeometryType.LineString;
            case GeometryType.MultiLineString:
                return SqlTypes.OpenGisGeometryType.MultiLineString;
            case GeometryType.MultiPoint:
                return SqlTypes.OpenGisGeometryType.MultiPoint;
            case GeometryType.MultiPolygon:
                return SqlTypes.OpenGisGeometryType.MultiPolygon;
            case GeometryType.Point:
                return SqlTypes.OpenGisGeometryType.Point;
            case GeometryType.Polygon:
                return SqlTypes.OpenGisGeometryType.Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }

        public static SqlTypes.OpenGisGeographyType ConvertToGeography(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.GeometryCollection:
                return SqlTypes.OpenGisGeographyType.GeometryCollection;
            case GeometryType.LineString:
                return SqlTypes.OpenGisGeographyType.LineString;
            case GeometryType.MultiLineString:
                return SqlTypes.OpenGisGeographyType.MultiLineString;
            case GeometryType.MultiPoint:
                return SqlTypes.OpenGisGeographyType.MultiPoint;
            case GeometryType.MultiPolygon:
                return SqlTypes.OpenGisGeographyType.MultiPolygon;
            case GeometryType.Point:
                return SqlTypes.OpenGisGeographyType.Point;
            case GeometryType.Polygon:
                return SqlTypes.OpenGisGeographyType.Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }
    }
}
