using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsGreaterThan:
        IBinaryComparisonOperator
    {

        LinqExpressionType IBinaryOperator.OperatorExpressionType
        {
            get
            {
                return LinqExpressionType.GreaterThan;
            }
        }
    }
#pragma warning restore 3009
}
