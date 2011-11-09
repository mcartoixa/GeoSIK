using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class And:
        IBinaryLogicalOperator
    {

        Func<Expression, Expression, BinaryExpression> IBinaryLogicalOperator.OperatorExpression
        {
            get
            {
                return Expression.AndAlso;
            }
        }
    }
}
