﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

    partial class OrientableCurve
    {

        internal protected override void Populate(IGeometrySink sink)
        {
            throw new NotImplementedException();
        }

        public override SqlGeometry Geometry
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                base.Geometry=value;
            }
        }
    }
}
