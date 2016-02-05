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
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.Practices.ServiceLocation;
using Newtonsoft.Json;

namespace GeoSik.Ogc.Gml.V311
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Converts a <see cref="IGeometryTap" /> to JSON.</summary>
    /// <remarks>
    ///   <para>The returned JSON is in the <see href="http://en.wikipedia.org/wiki/World_Geodetic_System">WGS84</see>
    /// coordinate reference system.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class GeometryJsonConverter:
        SimpleFeature.GeometryJsonConverter
    {

        protected override IGeometryBuilder CreateGeometryBuilder()
        {
            return new GmlGeometryBuilder();
        }
    }
}
