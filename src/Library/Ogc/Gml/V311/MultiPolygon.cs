using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class MultiPolygon
    {

        protected internal override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.MultiPolygon);

            foreach (polygonMember p in polygonMember)
                p.Polygon.Populate(sink);

            sink.EndGeometry();
        }
    }
#pragma warning restore 3009
}
