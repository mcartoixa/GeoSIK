using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Envelope:
        IGeometryProvider
    {

        public SqlGeometry Geometry
        {
            get
            {
                if ((lowerCorner==null) || (lowerCorner.TypedValue==null))
                    return null;
                if ((upperCorner==null) || (upperCorner.TypedValue==null))
                    return null;

                Debug.Assert(lowerCorner.TypedValue.Count==2);
                Debug.Assert(upperCorner.TypedValue.Count==2);

                var builder=new SqlGeometryBuilder();
                if (srsName!=null)
                    builder.SetSrid(Srid.CreateFromCrs(srsName).Value);
                else
                    builder.SetSrid(0);
                builder.BeginGeometry(OpenGisGeometryType.LineString);
                builder.BeginFigure(lowerCorner.TypedValue[0], lowerCorner.TypedValue[1]);
                builder.AddLine(upperCorner.TypedValue[0], upperCorner.TypedValue[1]);
                builder.EndFigure();
                builder.EndGeometry();

                return builder.ConstructedGeometry.STEnvelope();
            }
            set
            {
                if (value==null)
                {
                    lowerCorner=null;
                    upperCorner=null;
                }

                srsName=new Srid(value.STSrid.Value).Crs;

                var lc=new List<double>(2);
                var uc=new List<double>(2);

                var envelope=value.STEnvelope();
                var p1=envelope.STPointN(1);
                var p2=envelope.STPointN(3);

                var xmin=Math.Min(p1.STX.Value, p2.STX.Value);
                var ymin=Math.Min(p1.STY.Value, p2.STY.Value);
                var xmax=Math.Max(p1.STX.Value, p2.STX.Value);
                var ymax=Math.Max(p1.STY.Value, p2.STY.Value);

                lc.Add(xmin);
                lc.Add(ymin);
                uc.Add(xmax);
                uc.Add(ymax);

                // Bug in LinqToXsd: serialization is culture dependent...
                //lowerCorner=lc;
                //upperCorner=uc;

                lowerCorner=new DirectPositionType() {
                    TypedValue=new List<double>()
                };
                foreach (XElement el in lowerCorner.Untyped.Descendants("{http://www.opengis.net/gml}DirectPositionType"))
                    el.Value=string.Join(
                        " ",
                        lc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
                    );
                upperCorner=new DirectPositionType() {
                    TypedValue=new List<double>()
                };
                foreach (XElement el in upperCorner.Untyped.Descendants("{http://www.opengis.net/gml}DirectPositionType"))
                    el.Value=string.Join(
                        " ",
                        uc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
                    );
            }
        }
    }
#pragma warning restore 3009
}
