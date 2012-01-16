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

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, ref Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=_Context;

            switch (operatorName)
            {
            case OperationNames.Contains:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STContains", arguments);
            case OperationNames.Crosses:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STCrosses", arguments);
            case OperationNames.Disjoint:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STDisjoint", arguments);
            case OperationNames.Distance:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STDistance", arguments);
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1])==typeof(SqlGeometry))
                {
                    values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                    return typeof(RecordsDataContext).GetMethod("Geometry_STEquals", arguments);
                }
                if ((arguments.Length==3) && (arguments[2]==typeof(StringComparison)))
                {
                    // Comparisons are case insensitive by default: use them
                    if (IsCaseSensitive((StringComparison)values[2]))
                    {
                        arguments=new Type[] { typeof(string), typeof(string), typeof(int) };
                        values=new object[] { values[0], values[1], (int)((StringComparison)values[2]) };
                        return typeof(RecordsDataContext).GetMethod("String_Equals", arguments);
                    }
                }
                break;
            case OperationNames.Intersects:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STIntersects", arguments);
            case OperationNames.Like:
                // LIKE is case insensitive by default: use it
                if ((bool)values[3])
                {
                    arguments=new Type[] { typeof(string), typeof(string), typeof(char?), typeof(int) };
                    values=new object[] { values[0], values[1], values[2], (int)StringComparison.CurrentCulture };
                    return typeof(RecordsDataContext).GetMethod("String_Like", arguments);
                }
                break;
            case OperationNames.NotEqual:
                if ((arguments.Length==3) && (arguments[2]==typeof(StringComparison)))
                {
                    // Comparisons are case insensitive by default: use them
                    if (IsCaseSensitive((StringComparison)values[2]))
                    {
                        arguments=new Type[] { typeof(string), typeof(string), typeof(int) };
                        values=new object[] { values[0], values[1], (int)((StringComparison)values[2]) };
                        return typeof(RecordsDataContext).GetMethod("String_NotEqual", arguments);
                    }
                }
                break;
            case OperationNames.Overlaps:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STOverlaps", arguments);
            case OperationNames.Touches:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STTouches", arguments);
            case OperationNames.Within:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((SqlGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STWithin", arguments);
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

        private static bool IsCaseSensitive(StringComparison comparison)
        {
            return (comparison==StringComparison.CurrentCulture) || (comparison==StringComparison.InvariantCulture) || (comparison==StringComparison.Ordinal);
        }

        private RecordsDataContext _Context;
    }
}