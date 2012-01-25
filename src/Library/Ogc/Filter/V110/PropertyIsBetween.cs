using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsBetween:
        IBinaryLogicalOperator
    {

        internal protected override  IExpressionCreator GetExpressionCreator()
        {
            return new logicOps.BinaryLogicalExpressionCreator(this);
        }

        IList<comparisonOps> IBinaryLogicalOperator.comparisonOps
        {
            get
            {
                return new comparisonOps[] {
                    new PropertyIsGreaterThanOrEqualTo() {
                        expression=new expression[] { expression, LowerBoundary.expression}
                    },
                    new PropertyIsLessThanOrEqualTo() {
                        expression=new expression[] { expression, UpperBoundary.expression}
                    }
                };
            }
        }

        IList<spatialOps> IBinaryLogicalOperator.spatialOps
        {
            get { return new List<spatialOps>(); }
        }

        IList<logicOps> IBinaryLogicalOperator.logicOps
        {
            get { return new List<logicOps>(); }
        }

        IList<Function> IBinaryLogicalOperator.Function
        {
            get { return new List<Function>(); }
        }

        LinqExpressionType IBinaryLogicalOperator.OperatorExpressionType
        {
            get { return LinqExpressionType.And; }
        }
    }
#pragma warning restore 3009
}
