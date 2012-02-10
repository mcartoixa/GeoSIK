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
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace GeoSik
{



    public abstract class GeometryTransformerSink:
        IGeometrySink
    {

        protected GeometryTransformerSink()
        {
        }

        protected GeometryTransformerSink(ICoordinateSystem targetSystem)
        {
            _TargetSystem=targetSystem;
        }

        public void SetCoordinateSystem(ICoordinateSystem sourceSystem)
        {
            if (_TargetSystem==null)
                _TargetSystem=sourceSystem;

            DoSetCoordinateSystem(_TargetSystem);
            _SourceSystem=sourceSystem;

            if ((_TargetSystem!=null) && !_TargetSystem.Equals(_SourceSystem) && !_TargetSystem.EqualParams(_SourceSystem))
                _Transformation=new CoordinateTransformationFactory().CreateFromCoordinateSystems(_SourceSystem, _TargetSystem);
        }


        public void BeginFigure(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            DoBeginFigure(x, y, z);
        }

        public void BeginFigure(double x, double y)
        {
            BeginFigure(x, y, null);
        }

        public void AddLine(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            DoAddLine(x, y, z);
        }

        public void AddLine(double x, double y)
        {
            AddLine(x, y, null);
        }

        public abstract void BeginGeometry(GeometryType type);
        public abstract void EndFigure();
        public abstract void EndGeometry();

        protected abstract void DoAddLine(double x, double y, double? z);
        protected abstract void DoBeginFigure(double x, double y, double? z);
        protected abstract void DoSetCoordinateSystem(ICoordinateSystem system);

        private double[] TransformCoordinates(double x, double y, double? z)
        {
            double[] ret=null;
            if (z.HasValue)
                ret=new double[] { x, y, z.Value };
            else
                ret=new double[] { x, y };

            if (_Transformation!=null)
                ret=_Transformation.MathTransform.Transform(ret);

            return ret;
        }

        private ICoordinateSystem _SourceSystem;
        private ICoordinateSystem _TargetSystem;
        private ICoordinateTransformation _Transformation;
    }
}
