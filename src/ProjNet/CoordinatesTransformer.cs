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
using ProjNetCS=ProjNet.CoordinateSystems;

namespace GeoSik.ProjNet
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Represents a coordinates transformer.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class CoordinatesTransformer:
        ICoordinatesTransformer
    {

        private CoordinatesTransformer()
        {}

        internal CoordinatesTransformer(ICoordinateSystem source, ICoordinateSystem target)
        {
            Debug.Assert(source!=null);
            if (source==null)
                throw new ArgumentNullException("source");
            Debug.Assert(target!=null);
            if (target==null)
                throw new ArgumentNullException("target");

            var factory=new ProjNetCS.Transformations.CoordinateTransformationFactory();
            _Transformer=factory.CreateFromCoordinateSystems(
                CoordinateSystemUtils.Convert(source),
                CoordinateSystemUtils.Convert(target)
            ).MathTransform;
        }

        /// <summary>Transforms the specified coordinates.</summary>
        /// <param name="coordinates">The coordinates to transform.</param>
        /// <returns>The transformed coordinates.</returns>
        public double[] Convert(double[] coordinates)
        {
            return _Transformer.Transform(coordinates);
        }

        /// <summary>Transforms all the specified coordinates.</summary>
        /// <param name="coordinates">The coordinates to transform.</param>
        /// <returns>The transformed coordinates.</returns>
        public IEnumerable<double[]> Convert(IEnumerable<double[]> coordinates)
        {
            return _Transformer.TransformList(coordinates.ToList());
        }

        private ProjNetCS.Transformations.IMathTransform _Transformer;
    }
}
