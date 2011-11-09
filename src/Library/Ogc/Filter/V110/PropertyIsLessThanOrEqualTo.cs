﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class PropertyIsLessThanOrEqualTo:
        IBinaryComparisonOperator
    {

        Func<Expression, Expression, BinaryExpression> IBinaryOperator.OperatorExpression
        {
            get
            {
                return Expression.LessThanOrEqual;
            }
        }
    }
}
