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
using System.Data.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using ProjNet.CoordinateSystems;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.WebSample.Models.ModelFirst
{

    public class OperatorsImplementationProvider:
        IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider()
        {
        }

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, ref Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=null;

            switch (operatorName)
            {
            case OperationNames.Contains:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTContains", arguments);
            case OperationNames.Crosses:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTCrosses", arguments);
            case OperationNames.Disjoint:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTDisjoint", arguments);
            case OperationNames.Distance:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTDistance", arguments);
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1]==typeof(IGeometry)))
                {
                    arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                    values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                    return typeof(OperatorsImplementationProvider).GetMethod("GeographySTEquals", arguments);
                }
                if ((arguments.Length==3) && (arguments[2]==typeof(StringComparison)))
                {
                    // Comparisons are case insensitive by default: use them
                    if (IsCaseSensitive((StringComparison)values[2]))
                    {
                        arguments=new Type[] { typeof(string), typeof(string), typeof(int) };
                        values=new object[] { values[0], values[1], (int)((StringComparison)values[2]) };
                        return typeof(OperatorsImplementationProvider).GetMethod("StringEquals", arguments);
                    }
                }
                break;
            case OperationNames.Intersects:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTIntersects", arguments);
            case OperationNames.Like:
                {
                    StringComparison comparison=(StringComparison)values[3];
                    arguments=new Type[] { typeof(string), typeof(string), typeof(string), typeof(int) };
                    values=new object[] { values[0], values[1], (values[2]!=null ? values[2].ToString() : null), (int)comparison };

                    // case insensitive and no escape char uses ESQL
                    if (!IsCaseSensitive(comparison) && (values[2]==null))
                        return typeof(OperatorsImplementationProvider).GetMethod("StringCILike", arguments);

                    // Stored procedure by default
                    return typeof(OperatorsImplementationProvider).GetMethod("StringLike", arguments);
                }
            case OperationNames.NotEqual:
                if ((arguments.Length==3) && (arguments[2]==typeof(StringComparison)))
                {
                    // Comparisons are case insensitive by default: use them
                    if (IsCaseSensitive((StringComparison)values[2]))
                    {
                        arguments=new Type[] { typeof(string), typeof(string), typeof(int) };
                        values=new object[] { values[0], values[1], (int)((StringComparison)values[2]) };
                        return typeof(OperatorsImplementationProvider).GetMethod("StringNotEqual", arguments);
                    }
                }
                break;
            case OperationNames.Overlaps:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTOverlaps", arguments);
            case OperationNames.Touches:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTTouches", arguments);
            case OperationNames.Within:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeographySTWithin", arguments);
            }

            return ret;
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STContains")]
        public static int? GeographySTContains(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Contains(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STCrosses")]
        public static int? GeographySTCrosses(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Crosses(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STDisjoint")]
        public static int? GeographySTDisjoint(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Disjoint(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STDistance")]
        public static double? GeographySTDistance(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return g1.Distance(g2);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STEquals")]
        public static int? GeographySTEquals(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Equals(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STIntersects")]
        public static int? GeographySTIntersects(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Intersects(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STOverlaps")]
        public static int? GeographySTOverlaps(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Overlaps(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STTouches")]
        public static int? GeographySTTouches(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Touches(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geography_STWithin")]
        public static int? GeographySTWithin(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Within(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STContains")]
        public static int? GeometrySTContains(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Contains(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STCrosses")]
        public static int? GeometrySTCrosses(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Crosses(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STDisjoint")]
        public static int? GeometrySTDisjoint(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Disjoint(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STDistance")]
        public static double? GeometrySTDistance(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return g1.Distance(g2);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STEquals")]
        public static int? GeometrySTEquals(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Equals(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STIntersects")]
        public static int? GeometrySTIntersects(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Intersects(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STOverlaps")]
        public static int? GeometrySTOverlaps(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Overlaps(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STTouches")]
        public static int? GeometrySTTouches(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Touches(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STWithin")]
        public static int? GeometrySTWithin(byte[] geom1, byte[] geom2)
        {
            IGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            IGeometry g2=GetGeometry(geom2);

            return Convert.ToInt32(g1.Within(g2));
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "String_Equals")]
        public static int? StringEquals(string string1, string string2, int comparison)
        {
            if (string1==null)
                return null;

            var ret=string1.Equals(string2, (StringComparison)comparison);
            return Convert.ToInt32(ret);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "String_Like")]
        public static int? StringLike(string @string, string pattern, string escape, int comparison)
        {
            throw new NotSupportedException();
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst", "StringCILike")]
        public static bool StringCILike(string @string, string pattern, string escape, int comparison)
        {
            throw new NotSupportedException();
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "String_NotEqual")]
        public static int? StringNotEqual(string string1, string string2, int comparison)
        {
            if (string1==null)
                return null;

            var ret=!string1.Equals(string2, (StringComparison)comparison);
            return Convert.ToInt32(ret);
        }

        private static bool IsCaseSensitive(StringComparison comparison)
        {
            return (comparison==StringComparison.CurrentCulture) || (comparison==StringComparison.InvariantCulture) || (comparison==StringComparison.Ordinal);
        }

        private static byte[] GetBinary(ISimpleGeometry geometry)
        {
            if (geometry==null)
                return null;

            byte[] ret=null;

            var sgw=geometry as SqlServer.SqlGeographyWrapper;
            if ((sgw==null) || !sgw.CoordinateSystem.EqualParams(GeographicCoordinateSystem.WGS84))
            {
                var b=new SqlServer.SqlGeometryBuilder(GeographicCoordinateSystem.WGS84);
                geometry.Populate(b);
                sgw=(SqlServer.SqlGeographyWrapper)b.ConstructedGeometry;
            }

            using (var ms=new MemoryStream())
                using (var bw=new BinaryWriter(ms))
                {
                    ((SqlTypes.SqlGeography)sgw).Write(bw);
                    ret=ms.ToArray();
                }

            return ret;
        }

        private static IGeometry GetGeometry(byte[] binary)
        {
            if (binary==null)
                return null;

            var ret=new SqlServer.SqlGeographyWrapper();
            using (var ms=new MemoryStream(binary))
                using (var br=new BinaryReader(ms))
                    ((SqlTypes.SqlGeography)ret).Read(br);

            return ret;
        }
    }
}
