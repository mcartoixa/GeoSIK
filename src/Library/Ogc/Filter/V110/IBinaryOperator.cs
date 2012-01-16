using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinaryOperator
    {

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="expression", Justification="Interface to be implemented by generated code")]
        IList<expression> expression { get; }
        LinqExpressionType OperatorExpressionType { get; }
    }
}
