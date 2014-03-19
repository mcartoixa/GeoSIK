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
            Expression exp=GetAsyncExpression(source, "Count");
            var ret=source.Provider.Execute(exp);
            var rett=ret as Task<int>;
            if (rett!=null)
                return rett;
            return Task.FromResult((int)ret);
        }

        public static IQueryable Skip(this IQueryable source, int count)
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

        /// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
        /// <param name="source">The sequence to return elements from.</param>
        /// <param name="count">The number of elements to return.</param>
        /// <returns>An <see cref="IQueryable" /> that contains the specified number of elements from the start of <paramref name="source" />.</returns>
        public static IQueryable Take(this IQueryable source, int count)
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

        private static Expression GetAsyncExpression(IQueryable source, string name)
        {
            Type adpType=source.Provider.GetType().GetInterface("System.Data.Entity.Infrastructure.IDbAsyncQueryProvider");
            if (adpType!=null)
            {
                Type qType=Type.GetType("System.Data.Entity.QueryableExtensions", false);
                if (qType!=null)
                    return Expression.Call(
                        qType,
                        string.Concat(name, "Async"),
                        new Type[] { source.ElementType },
                        source.Expression
                    );
            }

            return Expression.Call(
                typeof(Queryable),
                name,
                new Type[] { source.ElementType },
                source.Expression
            );
        }

    }
}
