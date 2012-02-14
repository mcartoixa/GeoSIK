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
using System.Linq;
using System.Text;

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Polygon
    {

        protected override void PopulateEnvelope(Envelope envelope)
        {
            if ((exterior!=null)&&(exterior._Ring!=null))
                exterior._Ring.Populate(envelope);
        }

        internal override void BeginFigure(double x, double y, double? z)
        {
            _CurrentRing.Push(new LinearRing());
            _CurrentRing.Peek().BeginFigure(x, y, z);
        }

        internal override void AddLine(double x, double y, double? z)
        {
            _CurrentRing.Peek().AddLine(x, y, z);
        }

        internal override void EndFigure()
        {
            LinearRing ring=_CurrentRing.Pop();
            if (exterior!=null)
                interior.Add(new interior() { _Ring=ring });
            else
                exterior=new exterior() { _Ring=ring };
        }

        internal protected override void InternalPopulate(IGeometrySink sink)
        {
            sink.BeginGeometry(GeometryType.Polygon);

            if ((exterior!=null) && (exterior._Ring!=null))
                exterior._Ring.Populate(sink);
            if (interior!=null)
                foreach (interior intr in interior)
                    intr._Ring.Populate(sink);

            sink.EndGeometry();
        }

        private Stack<LinearRing> _CurrentRing=new Stack<LinearRing>();
    }
#pragma warning restore 3009
}
