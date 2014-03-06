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
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace GeoSik
{

    internal static class QueryableExtensions
    {

        public static Task<int> CountAsync(this IQueryable source)
        {
            MethodInfo mi=GetAsyncMethod(source.Provider, "ToList", typeof(IQueryable<>));
            if (mi!=null)
                return mi.Invoke(null, new object[] { source.Cast<object>() }) as Task<int>;

            return Task.FromResult(System.Linq.Enumerable.Count(source.Cast<object>()));
        }

        public static Task<List<object>> ToListAsync(this IQueryable source)
        {
            MethodInfo mi=GetAsyncMethod(source.Provider, "ToList", typeof(IQueryable));
            if (mi!=null)
                return mi.Invoke(null, new object[] { source }) as Task<List<object>>;

            return Task.FromResult(System.Linq.Enumerable.ToList(source.Cast<object>()));
        }

        private static MethodInfo GetAsyncMethod(IQueryProvider provider, string name, Type sourceType)
        {
            Type adpType=provider.GetType().GetInterface("System.Data.Entity.Infrastructure.IDbAsyncQueryProvider");
            if (adpType!=null)
            {
                Type qType=Type.GetType("System.Data.Entity.QueryableExtensions", false);
                if (qType!=null)
                    return qType.GetMethod(string.Join(name, "Async"), BindingFlags.ExactBinding | BindingFlags.InvokeMethod | BindingFlags.Public, null, new Type[] { sourceType }, null);
            }

            return null;
        }

    }
}
