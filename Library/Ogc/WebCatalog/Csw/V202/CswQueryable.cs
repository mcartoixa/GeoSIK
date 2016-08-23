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

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{

    public abstract class CswQueryable
    {

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static CswQueryable()
        {
            _Queryables=new Dictionary<string, CswQueryable>();
        }

        private CswQueryable()
        {
        }

        protected CswQueryable(string name, Type type):
            base()
        {
            Name=name;
            QueryableType=type;
        }

        protected static void AddQueryable(string name, CswQueryable queryable)
        {
            _Queryables.Add(name, queryable);
        }

        public static CswQueryable GetFromName(string name)
        {
            return _Queryables[name];
        }

        public static bool IsValidName(string name)
        {
            return _Queryables.ContainsKey(name);
        }

        public string Name
        {
            get;
            private set;
        }

        public Type QueryableType
        {
            get;
            private set;
        }

        private static Dictionary<string, CswQueryable> _Queryables;
    }
}
