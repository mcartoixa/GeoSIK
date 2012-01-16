using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Not
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Type st=typeof(bool);
            Expression subexpr=null;
            if (logicOps!=null)
                subexpr=((IExpressionBuilder)logicOps).CreateExpression(parameters, st);
            else if (comparisonOps!=null)
                subexpr=((IExpressionBuilder)comparisonOps).CreateExpression(parameters, st);
            else if (spatialOps!=null)
                subexpr=((IExpressionBuilder)spatialOps).CreateExpression(parameters, st);
            else if (Function!=null)
                subexpr=((IExpressionBuilder)Function).CreateExpression(parameters, st);

            if (subexpr==null)
                throw new InvalidOperationException("Invalid binary logical operator content");

            return Expression.Not(subexpr);
        }
    }
#pragma warning restore 3009
}
