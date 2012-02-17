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
using System.Text;

namespace GeoSik
{

    internal static class EnumerableExtensions
    {

        internal static int Count(this IQueryable source)
        {
            return (int)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable),
                    "Count",
                    new Type[] { source.ElementType },
                    source.Expression
                )
            );
        }

        internal static IQueryable Skip(this IQueryable source, int count)
        {
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    "Skip",
                    new Type[] { source.ElementType },
                    source.Expression,
                    Expression.Constant(count, typeof(int))
                )
            );
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

        /// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
        /// <param name="source">The sequence to return elements from.</param>
        /// <param name="count">The number of elements to return.</param>
        /// <returns>An <see cref="IQueryable" /> that contains the specified number of elements from the start of <paramref name="source" />.</returns>
        internal static IQueryable Take(this IQueryable source, int count)
        {
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    "Take",
                    new Type[] { source.ElementType },
                    source.Expression,
                    Expression.Constant(count, typeof(int))
                )
            );
        }

        internal static string ToTraceString(this IQueryable source)
        {
            MethodInfo ttsmi=source.GetType().GetMethod("ToTraceString");
            if (ttsmi!=null)
                return (string)ttsmi.Invoke(source, null);

            return null;
        }
    }
}
