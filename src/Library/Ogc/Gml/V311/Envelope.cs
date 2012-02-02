////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

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
                    builder.SetSrid(4326); // WGS84
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
