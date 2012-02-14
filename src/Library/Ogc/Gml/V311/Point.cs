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

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Point
    {

        internal override void BeginFigure(double x, double y, double? z)
        {
            pos=new pos();
            pos.TypedValue=new List<double>();

            pos.TypedValue.Add(x);
            pos.TypedValue.Add(y);
            if (z.HasValue)
                pos.TypedValue.Add(z.Value);
        }

        internal override void AddLine(double x, double y, double? z)
        {
            throw new InvalidOperationException();
        }

        internal protected override void InternalPopulate(IGeometrySink sink)
        {
            sink.BeginGeometry(GeometryType.Point);

            if ((pos!=null) && (pos.TypedValue!=null) && (pos.TypedValue.Count<2))
            {
                sink.BeginFigure(pos.TypedValue[0], pos.TypedValue[1], null);
                sink.EndFigure();
            }

            sink.EndGeometry();
        }
    }
#pragma warning restore 3009
}
