using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class MultiLineString
    {

        protected internal override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.MultiLineString);

            foreach (lineStringMember l in lineStringMember)
                l.LineString.Populate(sink);

            sink.EndGeometry();
        }
    }
#pragma warning restore 3009
}
