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
using FCommon=OSGeo.FDO.Common;

namespace GeoSik.Fdo
{

    internal static class GeometryTypeUtils
    {

        public static FCommon.GeometryType Convert(GeometryType type)
        {
            switch (type)
            {
            case GeometryType.GeometryCollection:
                return FCommon.GeometryType.GeometryType_MultiGeometry;
            case GeometryType.LineString:
                return FCommon.GeometryType.GeometryType_LineString;
            case GeometryType.MultiLineString:
                return FCommon.GeometryType.GeometryType_MultiLineString;
            case GeometryType.MultiPoint:
                return FCommon.GeometryType.GeometryType_MultiPoint;
            case GeometryType.MultiPolygon:
                return FCommon.GeometryType.GeometryType_MultiPolygon;
            case GeometryType.Point:
                return FCommon.GeometryType.GeometryType_Point;
            case GeometryType.Polygon:
                return FCommon.GeometryType.GeometryType_Polygon;
            }

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedGeometryTypeException,
                    type
                )
            );
        }

        public static GeometryType Convert(FCommon.GeometryType type)
        {

            switch (type)
            {
            case FCommon.GeometryType.GeometryType_MultiGeometry:
                return GeometryType.GeometryCollection;
            case FCommon.GeometryType.GeometryType_LineString:
                return GeometryType.LineString;
            case FCommon.GeometryType.GeometryType_MultiLineString:
                return GeometryType.MultiLineString;
            case FCommon.GeometryType.GeometryType_MultiPoint:
                return GeometryType.MultiPoint;
            case FCommon.GeometryType.GeometryType_MultiPolygon:
                return GeometryType.MultiPolygon;
            case FCommon.GeometryType.GeometryType_Point:
                return GeometryType.Point;
            case FCommon.GeometryType.GeometryType_Polygon:
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
