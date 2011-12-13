﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class Contains:
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
            get { return OperationNames.Contains; }
        }
    }
}
