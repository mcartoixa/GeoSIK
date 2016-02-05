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
using DsProjections=DotSpatial.Projections;

namespace GeoSik.DotSpatial
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

            _Source=CoordinateSystemUtils.Convert(source);
            _Target=CoordinateSystemUtils.Convert(target);
        }

        /// <summary>Transforms the specified coordinates.</summary>
        /// <param name="coordinates">The coordinates to transform.</param>
        /// <returns>The transformed coordinates.</returns>
        public double[] Convert(double[] coordinates)
        {
            Debug.Assert(coordinates.Length>1);
            Debug.Assert(coordinates.Length<4);

            return Convert(new double[][] { coordinates }).ElementAt(0);
        }

        /// <summary>Transforms all the specified coordinates.</summary>
        /// <param name="coordinates">The coordinates to transform.</param>
        /// <returns>The transformed coordinates.</returns>
        public IEnumerable<double[]> Convert(IEnumerable<double[]> coordinates)
        {
            var coords=coordinates.ToList();

            if (coords.Count==0)
                return new double[][] { new double[0] };

            double[] xy=coords.SelectMany(c => new double[] { c[0], c[1] }).ToArray();
            double[] z=coords.Select(c => (c.Length>2 ? c[2] : 0d)).ToArray();

            DsProjections.Reproject.ReprojectPoints(xy, z, _Source, _Target, 0, coords.Count);

            var ret=new List<double[]>(coords.Count);
            for (int i=0; i<coords.Count; ++i)
            {
                var r=new double[coords[i].Length];
                Array.Copy(xy, i*2, r, i*2, 2);
                if (coords[i].Length>2)
                    r[2]=z[i];
                ret.Add(r);
            }

            return ret;
        }

        private DsProjections.ProjectionInfo _Source;
        private DsProjections.ProjectionInfo _Target;
    }
}
