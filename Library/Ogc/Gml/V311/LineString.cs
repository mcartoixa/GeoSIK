////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Xml.Schema.Linq;

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class LineString
    {

        internal protected override void InternalPopulate(IGeometrySink sink)
        {
            sink.BeginGeometry(GeometryType.LineString);

            //if (posList!=null)
            if (Untyped.Descendants("{http://www.opengis.net/gml}posList").Any<XElement>())
                if ((posList.TypedValue!=null) && (posList.TypedValue.Count>=2))
                {
                    sink.BeginFigure(posList.TypedValue[0], posList.TypedValue[1], null);
                    for (int i=2; i<posList.TypedValue.Count; i+=2)
                        sink.AddLine(posList.TypedValue[i], posList.TypedValue[i+1], null);
                    sink.EndFigure();
                }

            sink.EndGeometry();
        }

        internal override void BeginFigure(double x, double y, double? z)
        {
            List<double> coord=new List<double>(new double[] { x, y });
            if (z.HasValue)
                coord.Add(z.Value);

            posList=new posList();
            posList.Untyped.Value=string.Join(
                " ",
                coord.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );
        }

        internal override void AddLine(double x, double y, double? z)
        {
            List<double> coord=new List<double>(new double[] { x, y });
            if (z.HasValue)
                coord.Add(z.Value);

            posList.Untyped.Value=string.Concat(
                posList.Untyped.Value,
                " ",
                string.Join(
                    " ",
                    coord.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
                )
            );
        }
    }
#pragma warning restore 3009
}
