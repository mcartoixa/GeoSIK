using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class And:
        IBinaryLogicalOperator
    {

        LinqExpressionType IBinaryLogicalOperator.OperatorExpressionType
        {
            get
            {
                return LinqExpressionType.And;
            }
        }
    }
#pragma warning restore 3009
}
