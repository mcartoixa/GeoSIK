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

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Interface implemented by coordinate system.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface ICoordinateSystem:
        IEquatable<ICoordinateSystem>
    {

        /// <summary>Indicates whether the current coordinate system is equivalent to the specified one.</summary>
        /// <param name="other">The coordinate system to compare the current one against.</param>
        /// <returns><c>true</c> if the coordinate systems are equivalent; or else <c>false</c>.</returns>
        bool IsEquivalentTo(ICoordinateSystem other);

        /// <summary>Gets the code associated with the current coordinate system.</summary>
        int Code { get; }
        /// <summary>Gets the dimension for the current coordinate system.</summary>
        int Dimension { get; }
        /// <summary>Indicates whether the coordinate system is projected or not.</summary>
        bool IsProjected { get; }
    }
}
