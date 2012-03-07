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
using System.Data.Linq;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using ProjNet.CoordinateSystems;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.WebSample.Models.LinqToSql
{

    public class OperatorsImplementationProvider:
        Ogc.IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider(RecordsDataContext context)
        {
            Debug.Assert(context!=null);
            if (context==null)
                throw new ArgumentNullException("context");

            _Context=context;
        }

        MethodInfo Ogc.IOperatorImplementationProvider.GetImplementation(string operatorName, ref Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=_Context;

            switch (operatorName)
            {
            case OperationNames.Contains:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STContains", arguments);
            case OperationNames.Crosses:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STCrosses", arguments);
            case OperationNames.Disjoint:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STDisjoint", arguments);
            case OperationNames.Distance:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STDistance", arguments);
            case OperationNames.Equal:
                if ((arguments.Length==2) && (arguments[1])==typeof(ISimpleGeometry))
                {
                    values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                    return typeof(RecordsDataContext).GetMethod("Geography_STEquals", arguments);
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
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STIntersects", arguments);
            case OperationNames.Like:
                // LIKE is case insensitive by default: use it
                {
                    StringComparison comparison=(StringComparison)values[3];
                    if (IsCaseSensitive(comparison))
                    {
                        arguments=new Type[] { typeof(string), typeof(string), typeof(char?), typeof(int) };
                        values=new object[] { values[0], values[1], values[2], (int)comparison };
                        return typeof(RecordsDataContext).GetMethod("String_Like", arguments);
                    }
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
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STOverlaps", arguments);
            case OperationNames.Touches:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STTouches", arguments);
            case OperationNames.Within:
                arguments=new Type[] { typeof(Binary), typeof(Binary) };
                values=values.Select<object, object>(v => GetBinary((ISimpleGeometry)v)).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geography_STWithin", arguments);
            }

            return ret;
        }

        private static Binary GetBinary(ISimpleGeometry geometry)
        {
            if (geometry==null)
                return null;

            Binary ret=null;

            var sgw=geometry as SqlServer.SqlGeography;
            if ((sgw==null) || !sgw.CoordinateSystem.ReferenceEquals(CoordinateSystemProvider.Instance.Wgs84))
            {
                var b=new SqlServer.SqlGeometryBuilder(CoordinateSystemProvider.Instance.Wgs84);
                geometry.Populate(b);
                sgw=(SqlServer.SqlGeography)b.ConstructedGeometry;
            }

            using (var ms=new MemoryStream())
                using (var bw=new BinaryWriter(ms))
                {
                    ((SqlTypes.SqlGeography)sgw).Write(bw);
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
