using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class Beyond:
        IDistanceBufferOperator
    {

        public Gml.V311._Geometry Geometry
        {
            get
            {
                return _Geometry;
            }
        }

        double IDistanceBufferOperator.Distance
        {
            get
            {
                // TODO: units transformation
                return Distance.TypedValue;
            }
        }

        Func<Expression, Expression, BinaryExpression> IDistanceBufferOperator.OperatorExpression
        {
            get
            {
                return Expression.GreaterThanOrEqual;
            }
        }
    }
}
