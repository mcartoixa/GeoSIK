using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.WebSample.Models.ModelFirst
{

    public class OperatorsImplementationProvider:
        IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider()
        {
        }

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=null;

            switch (operatorName)
            {
            case OperationNames.Contains:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTContains", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Crosses:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTCrosses", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Disjoint:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTDisjoint", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Distance:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTDistance", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1])==typeof(SqlGeometry))
                {
                    values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                    return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTEquals", new Type[] { typeof(byte[]), typeof(byte[]) });
                }
                break;
            case OperationNames.Intersects:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTIntersects", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Overlaps:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTOverlaps", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Touches:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTTouches", new Type[] { typeof(byte[]), typeof(byte[]) });
            case OperationNames.Within:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(OperatorsImplementationProvider).GetMethod("GeometrySTWithin", new Type[] { typeof(byte[]), typeof(byte[]) });
            }

            return ret;
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STContains")]
        public static int? GeometrySTContains(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STContains(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STCrosses")]
        public static int? GeometrySTCrosses(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STCrosses(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STDisjoint")]
        public static int? GeometrySTDisjoint(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STDisjoint(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STDistance")]
        public static double? GeometrySTDistance(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STDistance(g2);
            return (ret.IsNull ? (double?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STEquals")]
        public static int? GeometrySTEquals(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STEquals(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STIntersects")]
        public static int? GeometrySTIntersects(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STIntersects(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STOverlaps")]
        public static int? GeometrySTOverlaps(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STOverlaps(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STTouches")]
        public static int? GeometrySTTouches(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STTouches(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
        }

        [EdmFunction("OgcToolkit.WebSample.Models.ModelFirst.Store", "Geometry_STWithin")]
        public static int? GeometrySTWithin(byte[] geom1, byte[] geom2)
        {
            SqlGeometry g1=GetGeometry(geom1);
            if (g1==null)
                return null;

            SqlGeometry g2=GetGeometry(geom2);

            var ret=g1.STWithin(g2).ToSqlInt32();
            return (ret.IsNull ? (int?)null : ret.Value);
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
