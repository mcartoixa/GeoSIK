using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
using Xml.Schema.Linq;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

    /// <summary>Interface implemented by a binary logical operator.</summary>
    /// <remarks>
    ///   <para>It seems that for the OGC, binary really means more than 2...</para>
    /// </remarks>
    public interface IBinaryLogicalOperator:
        IExpressionBuilder
    {

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="comparison", Justification="Interface to be implemented by generated code")]
        IList<comparisonOps> comparisonOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="spatial", Justification="Interface to be implemented by generated code")]
        IList<spatialOps> spatialOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="logic", Justification="Interface to be implemented by generated code")]
        IList<logicOps> logicOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId="Function", Justification="Interface to be implemented by generated code")]
        IList<Function> Function { get; }

        LinqExpressionType OperatorExpressionType { get; }
    }

}
