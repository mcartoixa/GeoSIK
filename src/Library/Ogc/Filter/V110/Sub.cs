using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Sub:
        IBinaryOperator
    {

        protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return base.GetExpressionStaticType(parameters) ?? typeof(decimal);
        }

        Func<Expression, Expression, BinaryExpression> IBinaryOperator.OperatorExpression
        {
            get
            {
                return Expression.Subtract;
            }
        }
    }
#pragma warning restore 3009
}
