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
    /// <summary>Interface implemented by coordinate system provider.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface ICoordinateSystemProvider
    {

        /// <summary>Creates the coordinate system from the specified WKT representation.</summary>
        /// <param name="text">The WKT representation of the coordinate system to create.</param>
        /// <returns>The coordinate system.</returns>
        ICoordinateSystem CreateFromWkt(string text);
        /// <summary>Creates a coordinate system transformer from the specified coordinate systems.</summary>
        /// <param name="source">The source coordinate system.</param>
        /// <param name="target">The target coordinate system.</param>
        /// <returns>The resulting coordinate transformer.</returns>
        ICoordinatesTransformer CreateTransformer(ICoordinateSystem source, ICoordinateSystem target);
        /// <summary>Gets the coordinate system with the specified <paramref name="id" />.</summary>
        /// <param name="id">The identifier of the coordinate system to get.</param>
        /// <returns>The coordinate system with the specified <paramref name="id" />.</returns>
        ICoordinateSystem GetById(Srid id);

        /// <summary>Gets the WGS84 coordinate system.</summary>
        ICoordinateSystem Wgs84 { get; }

        /// <summary>Event triggered when a coordinate system has to be created.</summary>
        event EventHandler<CreatingCoordinateSystemEventArgs> CreatingCoordinateSystem;
        /// <summary>Event triggered when a coordinate system has been created.</summary>
        event EventHandler<CreatedCoordinateSystemEventArgs> CreatedCoordinateSystem;
    }



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Arguments for the <see cref="ICoordinateSystemProvider.CreatedCoordinateSystem" /> event.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class CreatedCoordinateSystemEventArgs:
        EventArgs
    {

        private CreatedCoordinateSystemEventArgs()
        {
        }

        /// <summary>Creates a new instance of the <see cref="CreatedCoordinateSystemEventArgs" /> class.</summary>
        /// <param name="id">The identifier of the coordinate system.</param>
        /// <param name="system">The coordinate system instance.</param>
        public CreatedCoordinateSystemEventArgs(Srid id, ICoordinateSystem coordinateSystem)
        {
            Id=id;
            CoordinateSystem=coordinateSystem;
        }

        /// <summary>Gets the identifier of the coordinate system being created.</summary>
        public Srid Id
        {
            get;
            private set;
        }

        /// <summary>Gets the coordinate system that has been created.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get;
            private set;
        }
    }



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Arguments for the <see cref="ICoordinateSystemProvider.CreatingCoordinateSystem" /> event.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class CreatingCoordinateSystemEventArgs:
        EventArgs
    {

        private CreatingCoordinateSystemEventArgs()
        {
        }

        /// <summary>Creates a new instance of the <see cref="CreatingCoordinateSystemEventArgs" /> class.</summary>
        /// <param name="id">The identifier of the coordinate system being created.</param>
        public CreatingCoordinateSystemEventArgs(Srid id)
        {
            Id=id;
        }

        /// <summary>Gets the identifier of the coordinate system being created.</summary>
        public Srid Id
        {
            get;
            private set;
        }

        /// <summary>Gets or sets the <see href="html/fdc71072-323b-442a-989d-651ca9a41f4d.htm#wkt">WKT</see> of the coordinate system being created.</summary>
        public string WellKnownText
        {
            get;
            set;
        }

        /// <summary>Gets or sets the coordinate system being created.</summary>
        public ICoordinateSystem CoordinateSystem
        {
            get;
            set;
        }
    }
}
