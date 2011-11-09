using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinaryComparisonOperator:
        IBinaryOperator
    {

        bool matchCase { get; }
    }
}
