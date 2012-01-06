using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinaryOperator
    {

        IList<expression> expression { get; }

        LinqExpressionType OperatorExpressionType { get; }
    }
}
