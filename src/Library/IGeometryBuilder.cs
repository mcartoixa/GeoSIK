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
    /// <summary>Interface implemented by a class that can build geometries.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface IGeometryBuilder:
        IGeometrySink
    {

        /// <summary>Returns the geometry defined by the specified WKT representation, in the specified coordinate system.</summary>
        /// <param name="text">The WKT representation of the geometry.</param>
        /// <param name="system">The coordinate system of the geometry.</param>
        /// <returns>The geometry.</returns>
        ISimpleGeometry Parse(string text, ICoordinateSystem system);

        /// <summary>When used as a <see cref="IGeometrySink" />, returns the resulting geometry.</summary>
        ISimpleGeometry ConstructedGeometry { get; }
    }
}
