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
using ProjNet.CoordinateSystems;
using SmGeometries=SharpMap.Geometries;

namespace GeoSik.SharpMap
{

    public class SharpGeometryBuilder:
        GeometryBuilder
    {

        public SharpGeometryBuilder():
            base()
        {
        }

        public SharpGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            _TargetSystem=system;
        }

        public override void BeginGeometry(GeometryType type)
        {
            _GeometryType=GeometryTypeUtils.Convert(type);
        }

        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Figures.AddLast(new List<SmGeometries.Point>());
            DoAddLine(x, y, z);
        }

        protected override void DoAddLine(double x, double y, double? z)
        {
            LinkedListNode<IList<SmGeometries.Point>> last=_Figures.Last;
            if (z.HasValue)
                last.Value.Add(new SmGeometries.Point3D(x, y, z.Value));
            else
                last.Value.Add(new SmGeometries.Point(x, y));
        }

        public override ISimpleGeometry Parse(string text, ICoordinateSystem system)
        {
            var g=SmGeometries.Geometry.GeomFromText(text);
            g.SpatialReference=system;
            return new SharpGeometry(g);
        }

        public override ISimpleGeometry ConstructedGeometry
        {
            get
            {
                if (_Geometry==null)
                {
                    SmGeometries.Geometry g=null;
                    switch (_GeometryType)
                    {
                    case SmGeometries.GeometryType2.Point:
                        g=(SmGeometries.Geometry)_Figures.First.Value[0];
                        break;
                    case SmGeometries.GeometryType2.Polygon:
                        {
                            var exterior=new SmGeometries.LinearRing(_Figures.First.Value);
                            var interior=new List<SmGeometries.LinearRing>();

                            var current=_Figures.First;
                            while (current.Next!=_Figures.First)
                                interior.Add(new SmGeometries.LinearRing(current.Value));

                            g=new SmGeometries.Polygon(exterior, interior);
                        }
                        break;
                    default:
                        //TODO: implement other geometry types...
                        throw new NotImplementedException();
                    }

                    _Geometry=new SharpGeometry(g);
                }

                return _Geometry;
            }
        }

        private SmGeometries.GeometryType2 _GeometryType;
        private LinkedList<IList<SmGeometries.Point>> _Figures=new LinkedList<IList<SmGeometries.Point>>();
        private ICoordinateSystem _TargetSystem;

        private SharpGeometry _Geometry;
    }
}
