using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

    partial class MultiPoint
    {

        protected internal override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.MultiPoint);

            foreach (pointMember p in pointMember)
                p.Point.Populate(sink);

            sink.EndGeometry();
        }
    }
}
