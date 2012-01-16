using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gml311=OgcToolkit.Ogc.Gml.V311;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinarySpatialOperator
    {

        IList<PropertyName> PropertyName { get; }
        Gml311._Geometry Geometry { get; }
        Gml311.Envelope Envelope { get; }
        string Operation { get; }
    }
}
