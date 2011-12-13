using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.WebSample.Models.LinqToSql
{

    public class OperatorsImplementationProvider:
        IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider(RecordsDataContext context)
        {
            Debug.Assert(context!=null);
            if (context==null)
                throw new ArgumentNullException("context");

            _Context=context;
        }

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=_Context;

            switch (operatorName)
            {
            case OperationNames.Contains:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STContains", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Crosses:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STCrosses", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Disjoint:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STDisjoint", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Distance:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STDistance", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1])==typeof(SqlGeometry))
                {
                    values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                    return typeof(RecordsDataContext).GetMethod("Geometry_STEquals", new Type[] { typeof(Binary), typeof(Binary) });
                }
                break;
            case OperationNames.Intersects:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STIntersects", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Overlaps:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STOverlaps", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Touches:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STTouches", new Type[] { typeof(Binary), typeof(Binary) });
            case OperationNames.Within:
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STWithin", new Type[] { typeof(Binary), typeof(Binary) });
            }

            return ret;
        }

        private static Binary GetBinary(SqlGeometry geometry)
        {
            if (geometry==null)
                return null;

            Binary ret=null;
            using (var ms=new MemoryStream())
                using (var bw=new BinaryWriter(ms))
                {
                    geometry.Write(bw);
                    ret=new Binary(ms.ToArray());
                }

            return ret;
        }

        private RecordsDataContext _Context;
    }
}