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
using FCommon=OSGeo.FDO.Common;
using FGeometry=OSGeo.FDO.Geometry;

namespace GeoSik.Fdo
{

    public sealed class FdoGeometryBuilder:
        GeometryBuilder,
        IDisposable
    {

        public FdoGeometryBuilder():
            base()
        {
        }

        public FdoGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        ~FdoGeometryBuilder()
        {
            Dispose(false);
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
            _Figures.AddLast(new FGeometry.DirectPositionCollection());
            DoAddLine(x, y, z);
        }

        protected override void DoAddLine(double x, double y, double? z)
        {
            LinkedListNode<FGeometry.DirectPositionCollection> last=_Figures.Last;
            if (z.HasValue)
                last.Value.Add(_Factory.CreatePositionXYZ(x, y, z.Value));
            else
                last.Value.Add(_Factory.CreatePositionXY(x, y));
        }

        public override ISimpleGeometry Parse(string text, ICoordinateSystem system)
        {
            return new FdoGeometry(_Factory.CreateGeometry(text), system);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!_Factory.Disposed)
                    _Factory.Dispose();

                if (_Geometry!=null)
                    _Geometry.Dispose();

                foreach (FGeometry.DirectPositionCollection dpc in _Figures)
                    if (!dpc.Disposed)
                        dpc.Dispose();
            }

            _Factory=null;
            _Geometry=null;

            if (_Figures!=null)
                _Figures.Clear();
            _Figures=null;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public override ISimpleGeometry ConstructedGeometry
        {
            get
            {
                if (_Geometry==null)
                {
                    switch (_GeometryType)
                    {
                    case FCommon.GeometryType.GeometryType_Point:
                        _Geometry=_Factory.CreatePoint(_Figures.First.Value[0]);
                        break;
                    case FCommon.GeometryType.GeometryType_Polygon:
                        using (FGeometry.ILinearRing exterior=_Factory.CreateLinearRing(_Figures.First.Value))
                            using (var interior=new FGeometry.LinearRingCollection())
                            {
                                LinkedListNode<FGeometry.DirectPositionCollection> current=_Figures.First;
                                while (current.Next!=_Figures.First)
                                    interior.Add(_Factory.CreateLinearRing(current.Value));

                                _Geometry=_Factory.CreatePolygon(exterior, interior);
                            }
                        break;
                    default:
                        //TODO: implement other geometry types...
                        throw new NotImplementedException();
                    }
                }

                return new FdoGeometry(_Factory.CreateGeometry(_Geometry), _TargetSystem);
            }
        }

        private FGeometry.FgfGeometryFactory _Factory=new FGeometry.FgfGeometryFactory();
        private FCommon.GeometryType _GeometryType;
        private LinkedList<FGeometry.DirectPositionCollection> _Figures=new LinkedList<FGeometry.DirectPositionCollection>();
        private ICoordinateSystem _TargetSystem;

        private FGeometry.IGeometry _Geometry;
    }
}
