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
using SmGeometries=SharpMap.Geometries;

namespace GeoSik.SharpMap
{

    internal static class GeometryTypeUtils
    {

        public static SmGeometries.GeometryType2 Convert(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.GeometryCollection:
                return SmGeometries.GeometryType2.GeometryCollection;
            case GeometryType.LineString:
                return SmGeometries.GeometryType2.LineString;
            case GeometryType.MultiLineString:
                return SmGeometries.GeometryType2.MultiLineString;
            case GeometryType.MultiPoint:
                return SmGeometries.GeometryType2.MultiPoint;
            case GeometryType.MultiPolygon:
                return SmGeometries.GeometryType2.MultiPolygon;
            case GeometryType.Point:
                return SmGeometries.GeometryType2.Point;
            case GeometryType.Polygon:
                return SmGeometries.GeometryType2.Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }

        public static GeometryType Convert(SmGeometries.GeometryType2 type)
        {

            switch (type)
            {
            case SmGeometries.GeometryType2.GeometryCollection:
                return GeometryType.GeometryCollection;
            case SmGeometries.GeometryType2.LineString:
                return GeometryType.LineString;
            case SmGeometries.GeometryType2.MultiLineString:
                return GeometryType.MultiLineString;
            case SmGeometries.GeometryType2.MultiPoint:
                return GeometryType.MultiPoint;
            case SmGeometries.GeometryType2.MultiPolygon:
                return GeometryType.MultiPolygon;
            case SmGeometries.GeometryType2.MultiSurface:
                return GeometryType.Point;
            case SmGeometries.GeometryType2.Polygon:
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
    }
}
