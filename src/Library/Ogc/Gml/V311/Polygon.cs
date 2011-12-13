using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Polygon
    {

        internal protected override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.Polygon);

            if ((exterior!=null) && (exterior._Ring!=null))
                exterior._Ring.Populate(sink);

            sink.EndGeometry();
        }

        public override SqlGeometry Geometry
        {
            get
            {
                if ((exterior==null) || (exterior._Ring==null))
                    return null;

                return base.Geometry;
            }
            set
            {
                base.Geometry=value;
            }
        }
    }
#pragma warning restore 3009
}
