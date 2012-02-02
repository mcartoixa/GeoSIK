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
using Microsoft.SqlServer.Types;

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
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTContains", arguments);
            case OperationNames.Crosses:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTCrosses", arguments);
            case OperationNames.Disjoint:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTDisjoint", arguments);
            case OperationNames.Distance:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTDistance", arguments);
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1]==typeof(SqlGeometry)))
                {
                    arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                    values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                    return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTEquals", arguments);
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
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTIntersects", arguments);
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
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTOverlaps", arguments);
            case OperationNames.Touches:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTTouches", arguments);
            case OperationNames.Within:
                arguments=new Type[] { typeof(byte[]), typeof(byte[]) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTWithin", arguments);
            }

            return ret;
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STContains")]
        public static int? GeometrySTContains(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STContains(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STCrosses")]
        public static int? GeometrySTCrosses(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STCrosses(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STDisjoint")]
        public static int? GeometrySTDisjoint(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STDisjoint(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STDistance")]
        public static double? GeometrySTDistance(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STDistance(g2);
            return (ret.IsNull ? (double?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STEquals")]
        public static int? GeometrySTEquals(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STEquals(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STIntersects")]
        public static int? GeometrySTIntersects(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STIntersects(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STOverlaps")]
        public static int? GeometrySTOverlaps(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STOverlaps(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STTouches")]
        public static int? GeometrySTTouches(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STTouches(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("GeoSik.WebSample.Models.ModelFirst.Store", "Geometry_STWithin")]
        public static int? GeometrySTWithin(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STWithin(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
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

        private static byte[] GetBinary(SqlGeometry geometry)
        {
            if (geometry==null)
                return null;

            byte[] ret=null;
            using (var ms=new MemoryStream())
                using (var bw=new BinaryWriter(ms))
                {
                    geometry.Write(bw);
                    ret=ms.ToArray();
                }

            return ret;
        }

        private static SqlGeometry GetGeometry(byte[] binary)
        {
            if (binary==null)
                return null;

            SqlGeometry ret=new SqlGeometry();
            using (var ms=new MemoryStream(binary))
                using (var br=new BinaryReader(ms))
                    ret.Read(br);

            return ret;
        }
    }
}
