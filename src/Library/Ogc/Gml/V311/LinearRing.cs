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

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class LinearRing
    {

        internal override void BeginFigure(double x, double y, double? z)
        {
            posList=new posList();
            posList.TypedValue=new List<double>();
            AddLine(x, y, z);
        }

        internal override void AddLine(double x, double y, double? z)
        {
            posList.Untyped.Value=string.Concat(posList.Untyped.Value, " ", x.ToString(CultureInfo.InvariantCulture)).TrimStart();
            posList.Untyped.Value=string.Concat(posList.Untyped.Value, " ", y.ToString(CultureInfo.InvariantCulture));
            if (z.HasValue) {
                posList.srsDimension=3;
                posList.Untyped.Value=string.Concat(posList.Untyped.Value, " ", z.Value.ToString(CultureInfo.InvariantCulture));
            }
        }

        protected internal override void InternalPopulate(IGeometrySink sink)
        {
            int dim=2;
            if (srsDimension.HasValue)
                dim=Convert.ToInt32(srsDimension.Value);
            if (posList.srsDimension.HasValue)
                dim=Convert.ToInt32(posList.srsDimension.Value);

            sink.BeginFigure(posList.TypedValue[0], posList.TypedValue[1], dim>2 ? posList.TypedValue[2] : (double?)null);
            for (int i=dim; i<posList.TypedValue.Count; i+=dim)
                sink.AddLine(posList.TypedValue[i], posList.TypedValue[i+1], dim>2 ? posList.TypedValue[i+2] : (double?)null);
            sink.EndFigure();
        }
    }
#pragma warning restore 3009
}
