////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services.Csw.V202
{

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited=true, AllowMultiple=true)]
    public sealed class CoreQueryableAttribute:
        Attribute
    {

        private CoreQueryableAttribute(CoreQueryable queryable)
        {
            Queryable=queryable;
        }

        public CoreQueryableAttribute(string queryableName)
        {
            Queryable=CoreQueryable.GetFromName(queryableName);
        }

        public CoreQueryable Queryable
        {
            get;
            private set;
        }
    }
}
