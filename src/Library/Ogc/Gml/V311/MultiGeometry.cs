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
    partial class MultiGeometry
    {

        protected internal override void InternalPopulate(IGeometrySink sink)
        {
            sink.BeginGeometry(GeometryType.GeometryCollection);

            //if ((geometryMember!=null)
            if (Untyped.Descendants("{http://www.opengis.net/gml}geometryMember").Any<XElement>())
                foreach (geometryMember g in geometryMember)
                    g._Geometry.Populate(sink);

            sink.EndGeometry();
        }

        internal override void BeginGeometry(GeometryType type)
        {
            if (_Builder==null)
            {
                Debug.Assert(_CurrentType.Count==0);
                _Builder=new GmlGeometryBuilder();
                _Builder.SetCoordinateSystem(CoordinateSystem);
            }
            _Builder.BeginGeometry(type);
            _CurrentType.Push(type);
        }

        internal override void BeginFigure(double x, double y, double? z)
        {
            _Builder.BeginFigure(x, y, z);
        }

        internal override void AddLine(double x, double y, double? z)
        {
            _Builder.AddLine(x, y, z);
        }

        internal override void EndFigure()
        {
            _Builder.EndFigure();
        }

        internal override void EndGeometry()
        {
            if (_CurrentType.Count>0)
            {
                _CurrentType.Pop();
                if (_CurrentType.Count==0)
                {
                    geometryMember.Add(new geometryMember() { _Geometry=_Builder.ConstructedGeometry });
                    _Builder=null;
                }
            }
        }

        private GmlGeometryBuilder _Builder;
        private Stack<GeometryType> _CurrentType=new Stack<GeometryType>();
    }
#pragma warning restore 3009
}
