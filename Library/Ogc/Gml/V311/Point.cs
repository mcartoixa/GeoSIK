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
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Point
    {

        internal override void BeginFigure(double x, double y, double? z)
        {
            var coords=new List<double>(new double[] { x, y });
            if (z.HasValue)
            {
                srsDimension=3;
                coords.Add(z.Value);
            }

            pos=new pos();
            pos.Untyped.Value=string.Join(
                " ",
                coords.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );
        }

        internal override void AddLine(double x, double y, double? z)
        {
            throw new InvalidOperationException();
        }

        internal protected override void InternalPopulate(IGeometrySink sink)
        {
            int dim=2;
            if (srsDimension.HasValue)
                dim=Convert.ToInt32(srsDimension.Value);

            sink.BeginGeometry(GeometryType.Point);

            //if (pos!=null)
            if (Untyped.Descendants("{http://www.opengis.net/gml}pos").Any<XElement>())
            {
                if (pos.srsDimension.HasValue)
                    dim=Convert.ToInt32(pos.srsDimension.Value);

                if ((pos.TypedValue!=null) && (pos.TypedValue.Count>=dim))
                {
                    sink.BeginFigure(pos.TypedValue[0], pos.TypedValue[1], dim>2 ? pos.TypedValue[2] : (double?)null);
                    sink.EndFigure();
                }
            }

            sink.EndGeometry();
        }
    }
#pragma warning restore 3009
}
