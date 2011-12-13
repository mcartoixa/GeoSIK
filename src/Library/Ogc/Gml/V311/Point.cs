using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Point
    {

        internal protected override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.Point);

            Debug.Assert((pos.TypedValue!=null) && (pos.TypedValue.Count==2));
            sink.BeginFigure(pos.TypedValue[0], pos.TypedValue[1], null, null);
            sink.EndFigure();
            sink.EndGeometry();
        }

        public override SqlGeometry Geometry
        {
            get
            {
                if ((pos==null) || (pos.TypedValue==null) || (pos.TypedValue.Count<2))
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
