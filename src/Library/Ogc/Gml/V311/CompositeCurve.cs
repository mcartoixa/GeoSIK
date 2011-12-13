using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class CompositeCurve
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
#pragma warning restore 3009
}
