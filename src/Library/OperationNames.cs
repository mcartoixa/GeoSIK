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
    /// <summary>Holds the names for standard spatial operations.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public static class OperationNames
    {
        /// <summary>The name of the Contains operation.</summary>
        public const string Contains="Contains";
        /// <summary>The name of the Crosses operation.</summary>
        public const string Crosses="Crosses";
        /// <summary>The name of the Disjoint operation.</summary>
        public const string Disjoint="Disjoint";
        /// <summary>The name of the Distance operation.</summary>
        public const string Distance="Distance";
        /// <summary>The name of the Equal operation.</summary>
        public const string Equal="Equal";
        /// <summary>The name of the Intersects operation.</summary>
        public const string Intersects="Intersects";
        /// <summary>The name of the Like operation.</summary>
        public const string Like="Like";
        /// <summary>The name of the NotEqual operation.</summary>
        public const string NotEqual="NotEqual";
        /// <summary>The name of the Overlaps operation.</summary>
        public const string Overlaps="Overlaps";
        /// <summary>The name of the Relate operation.</summary>
        public const string Relate="Relate";
        /// <summary>The name of the Touches operation.</summary>
        public const string Touches="Touches";
        /// <summary>The name of the Within operation.</summary>
        public const string Within="Within";
    }
}
