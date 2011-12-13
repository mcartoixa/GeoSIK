using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Gml311=OgcToolkit.Ogc.Gml.V311;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IDistanceBufferOperator
    {

        PropertyName PropertyName { get; }
        Gml311._Geometry Geometry { get; }
        double Distance { get; }
        Func<Expression, Expression, BinaryExpression> OperatorExpression { get; }
    }
}
