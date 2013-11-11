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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DsProjections=DotSpatial.Projections;

namespace GeoSik.DotSpatial
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Represents a coordinate system provider.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class CoordinateSystemProvider:
        ICoordinateSystemProvider
    {

        /// <summary>Creates a new instance of the <see cref="CoordinateSystemProvider" /> class.</summary>
        public CoordinateSystemProvider()
        {
        }

        /// <summary>Creates a coordinate system transformer from the specified coordinate systems.</summary>
        /// <param name="source">The source coordinate system.</param>
        /// <param name="target">The target coordinate system.</param>
        /// <returns>The resulting coordinate transformer.</returns>
        public CoordinatesTransformer CreateTransformer(ICoordinateSystem source, ICoordinateSystem target)
        {
            return new CoordinatesTransformer(source, target);
        }

        /// <summary>Creates the coordinate system from the specified WKT representation.</summary>
        /// <param name="text">The WKT representation of the coordinate system to create.</param>
        /// <param name="id">The identifier of the coordinate system to get.</param>
        /// <returns>The coordinate system.</returns>
        public ICoordinateSystem CreateFromWkt(string text, Srid id)
        {
            var ret=new CoordinateSystem(DsProjections.ProjectionInfo.FromEsriString(text));
            // DotSpatial does not fill this field automatically
            ret.Projection.EpsgCode=id.Value;
            return ret;
        }

        /// <summary>Gets the coordinate system with the specified <paramref name="id" />.</summary>
        /// <param name="id">The identifier of the coordinate system to get.</param>
        /// <returns>The coordinate system with the specified <paramref name="id" />.</returns>
        public CoordinateSystem GetById(Srid id)
        {
            // WGS84 by default
            if (id.Value==0)
                return Wgs84;

            CoordinateSystem ret=null;

            var args=new CreatingCoordinateSystemEventArgs(id);
            OnCreatingCoordinateSystem(args);

            if (args.CoordinateSystem!=null)
                ret=(CoordinateSystem)args.CoordinateSystem;
            else if (!string.IsNullOrEmpty(args.WellKnownText))
                ret=new CoordinateSystem(DsProjections.ProjectionInfo.FromEsriString(args.WellKnownText));

            if (ret!=null)
            {
                // DotSpatial does not fill this field automatically
                if (ret.Projection.EpsgCode==0)
                    ret.Projection.EpsgCode=id.Value;
                OnCreatedCoordinateSystem(new CreatedCoordinateSystemEventArgs(id, ret));
                return ret;
            }

            throw new InvalidOperationException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.CouldNotFindCoordinateSystemDefinitionException,
                    id.Value
                )
            );
        }

        ICoordinateSystem ICoordinateSystemProvider.CreateFromWkt(string text)
        {
            throw new NotSupportedException(SR.CannotCreateCoordinateSystemFromWktException);
        }

        ICoordinatesTransformer ICoordinateSystemProvider.CreateTransformer(ICoordinateSystem source, ICoordinateSystem target)
        {
            return CreateTransformer(source, target);
        }

        ICoordinateSystem ICoordinateSystemProvider.GetById(Srid id)
        {
            return GetById(id);
        }

        private void OnCreatingCoordinateSystem(CreatingCoordinateSystemEventArgs e)
        {
            var eh=CreatingCoordinateSystem;
            if (eh!=null)
                eh(this, e);
        }

        private void OnCreatedCoordinateSystem(CreatedCoordinateSystemEventArgs e)
        {
            var eh=CreatedCoordinateSystem;
            if (eh!=null)
                eh(this, e);
        }

        /// <summary>Gets the WGS84 coordinate system.</summary>
        public CoordinateSystem Wgs84
        {
            get
            {
                return GetById(new Srid(4326));
            }
        }

        ICoordinateSystem ICoordinateSystemProvider.Wgs84
        {
            get
            {
                return Wgs84;
            }
        }

        /// <summary>Event triggered when a coordinate system has to be created.</summary>
        public event EventHandler<CreatingCoordinateSystemEventArgs> CreatingCoordinateSystem;
        /// <summary>Event triggered when a coordinate system has been created.</summary>
        public event EventHandler<CreatedCoordinateSystemEventArgs> CreatedCoordinateSystem;
    }
}
