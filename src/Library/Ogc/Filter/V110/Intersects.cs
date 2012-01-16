using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Intersects:
        IBinarySpatialOperator
    {

        public Gml.V311._Geometry Geometry
        {
            get
            {
                return _Geometry;
            }
        }

        public string Operation
        {
            get { return OperationNames.Intersects; }
        }
    }
#pragma warning restore 3009
}
