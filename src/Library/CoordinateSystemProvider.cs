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
using ProjNet.CoordinateSystems;

namespace GeoSik
{

    public sealed class CoordinateSystemProvider
    {

        private CoordinateSystemProvider()
        {
            _CoordinateSystemFactory=new CoordinateSystemFactory();
            _WktDictionary=new Dictionary<Srid, string>();
        }

        public ICoordinateSystem GetById(Srid id)
        {
            // WGS84 by default
            if (id.Value==0)
                return GeographicCoordinateSystem.WGS84;

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

        private void OnCreatingCoordinateSystem(CoordinateSystemCreateEventArgs e)
        {
            var eh=CreatingCoordinateSystem;
            if (eh!=null)
                eh(this, e);
        }

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

        public event EventHandler<CoordinateSystemCreateEventArgs> CreatingCoordinateSystem;

        private Dictionary<Srid, string> _WktDictionary;
        private CoordinateSystemFactory _CoordinateSystemFactory;
        private bool _InternalRead;

        private static volatile CoordinateSystemProvider _Instance;
        private static object _SyncRoot=new object();
    }

    public sealed class CoordinateSystemCreateEventArgs:
        EventArgs
    {

        public CoordinateSystemCreateEventArgs(Srid id)
        {
            Id=id;
        }

        public Srid Id
        {
            get;
            private set;
        }

        public string WellKnownText
        {
            get;
            set;
        }
    }
}
