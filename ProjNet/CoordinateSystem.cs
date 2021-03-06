﻿////////////////////////////////////////////////////////////////////////////////
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
    /// <summary>Represents a coordinate system.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class CoordinateSystem:
        ICoordinateSystem
    {

        private CoordinateSystem()
        {}

        /// <summary>Creates a new instance of the <see cref="CoordinateSystem" /> class.</summary>
        /// <param name="system">The original system to encapsulate.</param>
        internal CoordinateSystem(ProjNetCS.ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            _System=system;
        }

        /// <summary>Indicates whether the current coordinate system is equal to the specified one.</summary>
        /// <param name="other">The coordinate system to compare the current one against.</param>
        /// <returns><c>true</c> if the coordinate systems are equal; or else <c>false</c>.</returns>
        public bool Equals(ICoordinateSystem other)
        {
            if (other==null)
                return false;

            var cs=other as CoordinateSystem;
            if (cs!=null)
                return _System.Equals(cs._System) || _System.EqualParams(cs._System);

            return false;
        }

        /// <summary>Indicates whether the current coordinate system is equivalent to the specified one.</summary>
        /// <param name="other">The coordinate system to compare the current one against.</param>
        /// <returns><c>true</c> if the coordinate systems are equivalent; or else <c>false</c>.</returns>
        public bool IsEquivalentTo(ICoordinateSystem other)
        {
            if (other==null)
                return false;

            if (Equals(other))
                return true;

            return false;
        }

        /// <summary>Gets the code associated with the current coordinate system.</summary>
        public int Code
        {
            get { return (int)_System.AuthorityCode; }
        }

        /// <summary>Gets the dimension for the current coordinate system.</summary>
        public int Dimension
        {
            get { return _System.Dimension; }
        }

        /// <summary>Indicates whether the coordinate system is projected or not.</summary>
        public bool IsProjected
        {
            get { return (_System is ProjNetCS.GeographicCoordinateSystem); }
        }

        internal ProjNetCS.ICoordinateSystem System
        {
            get
            {
                return _System;
            }
        }

        private ProjNetCS.ICoordinateSystem _System;
    }
}
