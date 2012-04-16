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
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class MultiPoint
    {

        protected internal override void InternalPopulate(IGeometrySink sink)
        {
            sink.BeginGeometry(GeometryType.MultiPoint);

            //if ((pointMember!=null)
            if (Untyped.Descendants("{http://www.opengis.net/gml}pointMember").Any<XElement>())
                foreach (pointMember p in pointMember)
                    p.Point.Populate(sink);

            sink.EndGeometry();
        }

        internal override void BeginGeometry(GeometryType type)
        {
            Debug.Assert(type==GeometryType.Point);
        }

        internal override void BeginFigure(double x, double y, double? z)
        {
            var p=new Point();
            p.BeginFigure(x, y, z);
            pointMember.Add(new pointMember() { Point=p });
        }

        internal override void AddLine(double x, double y, double? z)
        {
            throw new InvalidOperationException();
        }
    }
#pragma warning restore 3009
}
