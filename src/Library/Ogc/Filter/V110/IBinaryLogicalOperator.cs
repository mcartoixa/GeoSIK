using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
using Xml.Schema.Linq;

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

        Func<Expression, Expression, BinaryExpression> OperatorExpression { get; }
    }

    internal static class BinaryLogicalOperatorExtensions
    {

        public static IEnumerable<XTypedElement> GetLogicalElements(this Or op)
        {
            return GetLogicalElements(op, op.Untyped.Elements());
        }

        public static IEnumerable<XTypedElement> GetLogicalElements(this And op)
        {
            return GetLogicalElements(op, op.Untyped.Elements());
        }

        public static IEnumerable<XTypedElement> GetLogicalElements(this IBinaryLogicalOperator op)
        {
            return GetLogicalElements(op, ((XTypedElement)op).Untyped.Elements());
        }

        private static IEnumerable<XTypedElement> GetLogicalElements(IBinaryLogicalOperator op, IEnumerable<XElement> descendants)
        {
            var ret=new List<XTypedElement>();
            int icmp, ispa, ilog, ifun;
            icmp=ispa=ilog=ifun=0;

            foreach (XElement d in descendants)
            {
                if ((op.comparisonOps!=null) && (op.comparisonOps.Count>icmp) && (d.Name==op.comparisonOps[icmp].Untyped.Name))
                    yield return op.comparisonOps[icmp++];
                else if ((op.spatialOps!=null) && (op.spatialOps.Count>ispa) && (d.Name==op.spatialOps[ispa].Untyped.Name))
                    yield return op.spatialOps[ispa++];
                else if ((op.logicOps!=null) && (op.logicOps.Count>ilog) && (d.Name==op.logicOps[ilog].Untyped.Name))
                    yield return op.logicOps[ilog++];
                else if ((op.Function!=null) && (op.Function.Count>ifun) && (d.Name==op.Function[ifun].Untyped.Name))
                    yield return op.Function[ifun++];
                else
                    throw new InvalidOperationException();
            }

        }
    }
}
