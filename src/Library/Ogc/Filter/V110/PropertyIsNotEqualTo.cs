﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsNotEqualTo:
        IBinaryComparisonOperator
    {

        Func<Expression, Expression, BinaryExpression> IBinaryOperator.OperatorExpression
        {
            get
            {
                return Expression.NotEqual;
            }
        }
    }
#pragma warning restore 3009
}
