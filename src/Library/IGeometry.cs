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
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Interface implemented by a geometry.</summary>
    /// <remarks>
    ///   <para>A simple geometry is a type that holds spatial geometric data and allows
    /// complex calculation on these data (like intersections, or centroid).</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface IGeometry:
        ISimpleGeometry
    {

        ///// <summary>Returns the centroid for the current geometry.</summary>
        ///// <returns>The centroid for the current geometry.</returns>
        //ISimpleGeometry Centroid();
        /// <summary>Returns the shortest distance between any 2 points in the 2 geometries.</summary>
        /// <param name="geometry">The geometry to calculate the distance from.</param>
        /// <returns>The shortest distance between any 2 points in the 2 geometries.</returns>
        double Distance(ISimpleGeometry geometry);
        /// <summary>Indicates whether the 2 geometries are disjoint or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries are disjoint, or else <c>false</c>.</returns>
        bool Disjoint(ISimpleGeometry geometry);
        /// <summary>Indicates whether the 2 geometries touch themselves or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries touch themselves, or else <c>false</c>.</returns>
        bool Touches(ISimpleGeometry geometry);
        /// <summary>Indicates whether the current geometry is within the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry is within the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        bool Within(ISimpleGeometry geometry);
        /// <summary>Indicates whether the current geometry overlaps the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry overlaps the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        bool Overlaps(ISimpleGeometry geometry);
        /// <summary>Indicates whether the 2 geometries cross or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries cross, or else <c>false</c>.</returns>
        bool Crosses(ISimpleGeometry geometry);
        /// <summary>Indicates whether the 2 geometries intersect or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the 2 geometries intersect, or else <c>false</c>.</returns>
        bool Intersects(ISimpleGeometry geometry);
        /// <summary>Indicates whether the current geometry contains the specified <paramref name="geometry" /> or not.</summary>
        /// <param name="geometry">The geometry to test against.</param>
        /// <returns><c>true</c> if the current geometry contains the specified <paramref name="geometry" />, or else <c>false</c>.</returns>
        bool Contains(ISimpleGeometry geometry);
    }
}
