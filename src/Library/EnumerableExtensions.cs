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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using System.Text;

namespace GeoSik
{

    internal static class EnumerableExtensions
    {

        public static Task<List<object>> ToListAsync(this IEnumerable source)
        {
            MethodInfo ami=GetAsyncMethod(source, "ToList");
            if (ami!=null)
            {
                var rop=new Func<dynamic>(() => ami.Invoke(null, new object[] { source }));
                if (ami.ReturnType.IsGenericType && ami.ReturnType.IsSubclassOf(typeof(Task)))
                    return rop();
                return Task.FromResult(rop());
            }

            return Task.FromResult(source.Cast<object>().ToList());
        }

        /// <summary>Performs a client side conversion of every element in the specified sequence.</summary>
        /// <typeparam name="T">The type to convert the elements of <paramref name="source" /> to.</typeparam>
        /// <param name="source">An <see cref="IEnumerable" /> that contains the elements to be converted. </param>
        /// <returns>An <see cref="IEnumerable{T}" /> that contains each element of the source sequence converted to the specified type.</returns>
        internal static IEnumerable<T> StaticCast<T>(this IEnumerable source)
        {
            foreach (object o in source)
                yield return (T)o;
        }

        private static MethodInfo GetAsyncMethod(IEnumerable source, string name)
        {
            var q=source as IQueryable;
            if (q!=null)
            {
                Type adpType=q.Provider.GetType().GetInterface("System.Data.Entity.Infrastructure.IDbAsyncQueryProvider");
                if (adpType!=null)
                {
                    Type qType=Type.GetType("System.Data.Entity.QueryableExtensions", false);
                    if (qType!=null)
                        return qType.GetMethod(
                            string.Concat(name, "Async"),
                            BindingFlags.InvokeMethod | BindingFlags.Public,
                            null,
                            new Type[] { typeof(IQueryable) },
                            null
                        );
                }
            }

            return null;
        }
    }
}
