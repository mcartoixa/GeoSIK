using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class LineString
    {

        internal protected override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.LineString);

            sink.BeginFigure(posList.TypedValue[0], posList.TypedValue[1], null, null);
            for (int i=2; i<posList.TypedValue.Count; i+=2)
                sink.AddLine(posList.TypedValue[i], posList.TypedValue[i+1], null, null);
            sink.EndFigure();
            sink.EndGeometry();
        }

        public override SqlGeometry Geometry
        {
            get
            {
                if ((posList==null) || (posList.TypedValue==null) || (posList.TypedValue.Count<2))
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
