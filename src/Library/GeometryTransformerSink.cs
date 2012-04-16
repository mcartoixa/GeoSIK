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
using System.Diagnostics.CodeAnalysis;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Base implementation of a <see cref="IGeometrySink" /> that can be used to 
    /// transform the <see cref="ICoordinateSystem" /> of the source.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public abstract class GeometryTransformerSink:
        IGeometrySink
    {

        /// <summary>Creates a new instance of the <see cref="GeometryTransformerSink" /> class, that will perform no transformation.</summary>
        protected GeometryTransformerSink()
        {
        }

        /// <summary>Creates a new instance of the <see cref="GeometryTransformerSink" /> class.</summary>
        /// <param name="targetSystem">If <paramref name="targetSystem" /> is <c>null</c>, no transformation will occur.
        /// If <paramref name="targetSystem" /> is not <c>null</c>, it represents the coordinate system in which the geometry
        /// will be represented.</param>
        protected GeometryTransformerSink(ICoordinateSystem targetSystem)
        {
            _TargetSystem=targetSystem;
        }

        /// <summary>Defines the coordinate system of the geometry source.</summary>
        /// <param name="sourceSystem">The coordinate system of the geometry source.</param>
        /// <remarks>
        ///   <para>If <paramref name="sourceSystem" /> is the same coordinate system as the target coordinate system,
        /// no transformation will occur.</para>
        /// </remarks>
        public void SetCoordinateSystem(ICoordinateSystem sourceSystem)
        {
            Debug.Assert(sourceSystem!=null);
            if (sourceSystem==null)
                throw new ArgumentNullException("sourceSystem");

            if (_TargetSystem==null)
                _TargetSystem=sourceSystem;

            DoSetCoordinateSystem(_TargetSystem);
            _SourceSystem=sourceSystem;

            if (!_TargetSystem.SpatialReferenceEquals(_SourceSystem))
                _Transformation=new CoordinateTransformationFactory().CreateFromCoordinateSystems(_SourceSystem, _TargetSystem);
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry.</param>
        public abstract void BeginGeometry(GeometryType type);

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the coordinate system of the source.</param>
        /// <param name="y">The northing of the point, in the coordinate system of the source.</param>
        /// <param name="z">The elevation of the point, in the coordinate system of the source.</param>
        public void BeginFigure(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            DoBeginFigure(x, y, z);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the coordinate system of the source.</param>
        /// <param name="y">The northings of the point, in the coordinate system of the source.</param>
        /// <param name="z">The elevation of the point, in the coordinate system of the source.</param>
        public void AddLine(double x, double y, double? z)
        {
            double[] coord=TransformCoordinates(x, y, z);
            x=coord[0];
            y=coord[1];
            if (z.HasValue)
                z=coord[2];

            DoAddLine(x, y, z);
        }

        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        public virtual void EndFigure()
        {
        }

        /// <summary>Finishes the call sequence for a geometry representation.</summary>
        public virtual void EndGeometry()
        {
        }

        /// <summary>Sets the coordinate system of the geometry representation.</summary>
        /// <param name="system">The coordinate system of the geometry representation. Equivalent to <see cref="GeometryTransformerSink.TargetSystem" />.</param>
        protected virtual void DoSetCoordinateSystem(ICoordinateSystem system)
        {
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="x")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="y")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="z")]
        protected abstract void DoBeginFigure(double x, double y, double? z);

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="x")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="y")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="z")]
        protected abstract void DoAddLine(double x, double y, double? z);

        private double[] TransformCoordinates(double x, double y, double? z)
        {
            Debug.Assert(_TargetSystem!=null);
            Debug.Assert(_SourceSystem!=null);
            if ((_Transformation==null) && ((_SourceSystem==null) || (_TargetSystem==null)))
                throw new InvalidOperationException(SR.CannotBuildGeometryWithoutCoordinateSystemException);

            double[] ret=null;
            if (z.HasValue)
                ret=new double[] { x, y, z.Value };
            else
                ret=new double[] { x, y };

            if (_Transformation!=null)
                ret=_Transformation.MathTransform.Transform(ret);

            return ret;
        }

        /// <summary>Gets the coordinate system of the</summary>
        protected ICoordinateSystem TargetSystem
        {
            get
            {
                return _TargetSystem;
            }
        }

        private ICoordinateSystem _SourceSystem;
        private ICoordinateSystem _TargetSystem;
        private ICoordinateTransformation _Transformation;
    }
}
