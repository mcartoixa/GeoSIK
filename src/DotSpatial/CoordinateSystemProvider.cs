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
            _WktDictionary=new Dictionary<Srid, string>();
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
            ret.Projection.EpsgCode=id.Value;

            if (!_WktDictionary.ContainsKey(id))
                _WktDictionary.Add(id, text);

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

            // Has the id already been used ?
            if (_WktDictionary.ContainsKey(id))
            {
                ret=new CoordinateSystem(DsProjections.ProjectionInfo.FromEsriString(_WktDictionary[id]));
            } else {
                // Try custom implementation
                var args=new CoordinateSystemCreateEventArgs(id);
                OnCreatingCoordinateSystem(args);
                if (!string.IsNullOrEmpty(args.WellKnownText))
                {
                    _WktDictionary.Add(id, args.WellKnownText);
                    ret=new CoordinateSystem(DsProjections.ProjectionInfo.FromEsriString(args.WellKnownText));
                }
            }

            if (ret!=null)
            {
                if (ret.Projection.EpsgCode==0)
                    ret.Projection.EpsgCode=id.Value;
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

        private void OnCreatingCoordinateSystem(CoordinateSystemCreateEventArgs e)
        {
            var eh=CreatingCoordinateSystem;
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
        public event EventHandler<CoordinateSystemCreateEventArgs> CreatingCoordinateSystem;

        private Dictionary<Srid, string> _WktDictionary;
    }



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Arguments for the <see cref="CoordinateSystemProvider.CreatingCoordinateSystem" /> event.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class CoordinateSystemCreateEventArgs:
        EventArgs
    {

        /// <summary>Creates a new instance of the <see cref="CoordinateSystemCreateEventArgs" /> class.</summary>
        /// <param name="id">The identifier of the coordinate system being created.</param>
        public CoordinateSystemCreateEventArgs(Srid id)
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
    }
}
