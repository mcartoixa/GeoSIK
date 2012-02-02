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
using System.Xml.Linq;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3008, 3009
    partial class _Geometry:
        IGeometryProvider
    {

        internal protected abstract void Populate(IGeometrySink sink);

        public virtual SqlGeometry Geometry
        {
            get
            {
                var builder=new SqlGeometryBuilder();
                if (srsName!=null)
                    builder.SetSrid(Srid.CreateFromCrs(srsName).Value);
                else
                    builder.SetSrid(4326); // WGS84

                Populate(builder);

                return builder.ConstructedGeometry;
            }
            set
            {
                Untyped=XElement.Parse(value.AsGml().Value, LoadOptions.None);
            }
        }
    }
#pragma warning restore 3008, 3009
}
