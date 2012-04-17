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
/*
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ProjNet.CoordinateSystems;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Type that provides coordinate systems.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class CoordinateSystemProvider
    {

        private CoordinateSystemProvider()
        {
            _CoordinateSystemFactory=new CoordinateSystemFactory();
            _WktDictionary=new Dictionary<Srid, string>();
        }

        /// <summary>Gets the coordinate system with the specified <paramref name="id" />.</summary>
        /// <param name="id">The identifier of the coordinate system to get.</param>
        /// <returns>The coordinate system with the specified <paramref name="id" />.</returns>
        public ICoordinateSystem GetById(Srid id)
        {
            // WGS84 by default
            if (id.Value==0)
                return Wgs84;

            // Has the id already been used ?
            if (_WktDictionary.ContainsKey(id))
                return _CoordinateSystemFactory.CreateFromWkt(_WktDictionary[id]);

            // Try custom implementation
            var args=new CoordinateSystemCreateEventArgs(id);
            OnCreatingCoordinateSystem(args);
            if (!string.IsNullOrEmpty(args.WellKnownText))
            {
                _WktDictionary.Add(id, args.WellKnownText);
                return _CoordinateSystemFactory.CreateFromWkt(args.WellKnownText);
            }

            // Load resources in memory
            if (!_InternalRead)
            {
                using (StreamReader sr=new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("GeoSik.Srid.csv")))
                    while (!sr.EndOfStream)
                    {
                        string[] def=sr.ReadLine().Split(new char[] { ';' }, 2);
                        if (def.Length>1)
                        {
                            Srid srid=new Srid(int.Parse(def[0], CultureInfo.InvariantCulture));
                            if (!_WktDictionary.ContainsKey(srid))
                                _WktDictionary.Add(srid, def[1]);
                        }
                    }
                _InternalRead=true;

                if (_WktDictionary.ContainsKey(id))
                    return _CoordinateSystemFactory.CreateFromWkt(_WktDictionary[id]);
            }

            throw new InvalidOperationException();
        }

        /// <summary>Creates the coordinate system from the specified WKT representation.</summary>
        /// <param name="text">The WKT representation of the coordinate system to create.</param>
        /// <returns>The coordinate system.</returns>
        public ICoordinateSystem CreateFromWkt(string text)
        {
            ICoordinateSystem ret=_CoordinateSystemFactory.CreateFromWkt(text);

            var srid=new Srid((int)ret.AuthorityCode);
            if (!_WktDictionary.ContainsKey(srid))
                _WktDictionary.Add(srid, text);

            return ret;
        }

        private void OnCreatingCoordinateSystem(CoordinateSystemCreateEventArgs e)
        {
            var eh=CreatingCoordinateSystem;
            if (eh!=null)
                eh(this, e);
        }

        /// <summary>Gets the WGS84 coordinate system.</summary>
        public ICoordinateSystem Wgs84
        {
            get
            {
                return GetById(new Srid(4326));
            }
        }

        /// <summary>Gets the single instance of the the <see cref="CoordinateSystemProvider" /> class.</summary>
        public static CoordinateSystemProvider Instance
        {
            get
            {
                if (_Instance==null)
                    lock (_SyncRoot)
                        if (_Instance==null)
                            _Instance=new CoordinateSystemProvider();

                return _Instance;
            }
        }

        /// <summary>Event triggered when a coordinate system has to be created.</summary>
        public event EventHandler<CoordinateSystemCreateEventArgs> CreatingCoordinateSystem;

        private Dictionary<Srid, string> _WktDictionary;
        private CoordinateSystemFactory _CoordinateSystemFactory;
        private bool _InternalRead;

        private static volatile CoordinateSystemProvider _Instance;
        private static object _SyncRoot=new object();
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
*/