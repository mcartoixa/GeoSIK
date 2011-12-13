using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class LinearRing
    {

        protected internal override void Populate(IGeometrySink sink)
        {
            sink.BeginFigure(posList.TypedValue[0], posList.TypedValue[1], null, null);
            for (int i=2; i<posList.TypedValue.Count; i+=2)
                sink.AddLine(posList.TypedValue[i], posList.TypedValue[i+1], null, null);
        }
    }
#pragma warning restore 3009
}
