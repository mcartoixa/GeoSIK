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

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class that helps build reversed geometry instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class ReversedGeometrySink:
        GeometryTransformerSink
    {

        internal struct Point
        {

            public Point(double x, double y, double? z)
            {
                X=x;
                Y=y;
                Z=z;
            }

            public double X;
            public double Y;
            public double? Z;
        }

        /// <summary>Creates a new instance of the <see cref="ReversedGeometrySink" /> class.</summary>
        public ReversedGeometrySink(IGeometrySink sink) :
            base()
        {
            Debug.Assert(sink!=null);
            if (sink==null)
                throw new ArgumentNullException("sink");
            _Sink=sink;

            _Figures=new Stack<LinkedList<Point>>();
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
        public override void BeginGeometry(GeometryType type)
        {
            _Sink.BeginGeometry(type);
        }

        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        public override void EndFigure()
        {
            var f=_Figures.Pop();
            var p=f.First.Value;
            _Sink.BeginFigure(p.X, p.Y, p.Z);
            f.RemoveFirst();

            while (f.First!=null)
            {
                p=f.First.Value;
                _Sink.AddLine(p.X, p.Y, p.Z);
                f.RemoveFirst();
            }

            base.EndFigure();

            _Sink.EndFigure();
        }

        /// <summary>Finishes the call sequence for a geometry representation.</summary>
        public override void EndGeometry()
        {
            base.EndGeometry();

            _Sink.EndGeometry();
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            _Figures.Peek().AddFirst(new Point(x, y, z));
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            var f=new LinkedList<Point>();
            f.AddFirst(new Point(x, y, z));
            _Figures.Push(f);
        }

        /// <summary>Sets the coordinate system of the geometry representation.</summary>
        /// <param name="system">The coordinate system of the geometry representation. Equivalent to <see cref="GeometryTransformerSink.TargetSystem" />.</param>
        protected override void DoSetCoordinateSystem(ICoordinateSystem system)
        {
            base.DoSetCoordinateSystem(system);

            _Sink.SetCoordinateSystem(system);
        }

        private IGeometrySink _Sink;
        private Stack<LinkedList<Point>> _Figures;
    }
}
