using System;
using System.Collections.Generic;
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
    public interface IBinaryLogicalOperator
    {

        IList<comparisonOps> comparisonOps { get; }
        IList<spatialOps> spatialOps { get; }
        IList<logicOps> logicOps { get; }
        IList<Function> Function { get; }

        Func<Expression, Expression, BinaryExpression> OperatorExpression { get; }
    }

    internal static class BinaryLogicalOperatorExtensions
    {

        public static IEnumerable<XTypedElement> GetLogicalElements(this Or op)
        {
            return GetLogicalElements(op, op.Untyped.Descendants());
        }

        public static IEnumerable<XTypedElement> GetLogicalElements(this And op)
        {
            return GetLogicalElements(op, op.Untyped.Descendants());
        }

        public static IEnumerable<XTypedElement> GetLogicalElements(this IBinaryLogicalOperator op)
        {
            return GetLogicalElements(op, ((XTypedElement)op).Untyped.Descendants());
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
                if ((op.spatialOps!=null) && (op.spatialOps.Count>ispa) && (d.Name==op.spatialOps[ispa].Untyped.Name))
                    yield return op.spatialOps[ispa++];
                if ((op.logicOps!=null) && (op.logicOps.Count>ilog) && (d.Name==op.logicOps[ilog].Untyped.Name))
                    yield return op.logicOps[ilog++];
                if ((op.Function!=null) && (op.Function.Count>ifun) && (d.Name==op.Function[ifun].Untyped.Name))
                    yield return op.Function[ifun++];
            }

            throw new InvalidOperationException();
        }
    }
}
