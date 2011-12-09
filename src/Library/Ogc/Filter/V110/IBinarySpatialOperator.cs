using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gml311=OgcToolkit.Ogc.Gml.V311;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IBinarySpatialOperator
    {

        PropertyName PropertyName { get; set; }
        Gml311.Envelope Envelope { get; set; }
    }
}
