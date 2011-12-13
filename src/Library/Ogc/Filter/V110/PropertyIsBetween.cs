using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsBetween
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Type st=((IExpressionBuilder)expression).GetExpressionStaticType(parameters);

            Expression ex=((IExpressionBuilder)expression).CreateExpression(parameters, st);
            Expression lbex=((IExpressionBuilder)LowerBoundary.expression).CreateExpression(parameters, st);
            Expression ubex=((IExpressionBuilder)UpperBoundary.expression).CreateExpression(parameters, st);

            return Expression.And(
                Expression.GreaterThanOrEqual(ex, lbex),
                Expression.LessThanOrEqual(ex, ubex)
            );
        }
    }
#pragma warning restore 3009
}
