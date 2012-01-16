using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinaryComparisonOperator:
        IBinaryOperator
    {

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="match", Justification="Interface to be implemented by generated code")]
        bool matchCase { get; }
    }
}
