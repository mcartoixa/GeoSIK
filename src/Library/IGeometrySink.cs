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
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Interface implemented by a class that can build geometry representations.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface IGeometrySink
    {

        /// <summary>Defines the coordinate system for the geometry representation.</summary>
        /// <param name="system">The coordinate system.</param>
        void SetCoordinateSystem(ICoordinateSystem system);
        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to represent.</param>
        void BeginGeometry(GeometryType type);
        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point.</param>
        /// <param name="y">The northing of the point.</param>
        /// <param name="z">The elevation of the point.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="x")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="y")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="z")]
        void BeginFigure(double x, double y, double? z);
        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point.</param>
        /// <param name="y">The northings of the point.</param>
        /// <param name="z">The elevation of the point.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="x")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="y")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="z")]
        void AddLine(double x, double y, double? z);
        /// <summary>Finishes the call sequence for a geometry figure.</summary>
        void EndFigure();
        /// <summary>Finishes the call sequence for a geometry.</summary>
        void EndGeometry();
    }
}
