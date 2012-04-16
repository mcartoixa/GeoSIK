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

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Utility extensions for <see cref="ICoordinateSystem" /> types.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public static class CoordinateSystemExtensions
    {

        /// <summary>Indicates whether the specified spatial references are the same.</summary>
        /// <param name="left">The first spatial reference to test.</param>
        /// <param name="right">The second spatial reference to test.</param>
        /// <returns><c>true</c> if the two spatial refernces are the same; or else <c>false</c>.</returns>
        public static bool SpatialReferenceEquals(this IInfo left, IInfo right)
        {
            if (left==null)
                return right==null;

            if (object.ReferenceEquals(left, right))
                return true;

            return left.EqualParams(right);
        }
    }
}
