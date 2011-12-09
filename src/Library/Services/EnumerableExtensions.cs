using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Services
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

        internal static IEnumerable<T> StaticCast<T>(this IEnumerable source)
        {
            foreach (object o in source)
                yield return (T)o;
        }

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
    }
}
