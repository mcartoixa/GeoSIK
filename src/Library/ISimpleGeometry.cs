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
using System.Xml.Serialization;
using Newtonsoft.Json;
using ProjNet.CoordinateSystems;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Interface implemented by a simple geometry representation.</summary>
    /// <remarks>
    ///   <para>A simple geometry is a type that holds spatial geometric data but does not allow
    /// complex calculation on these data (like intersections, or hulls).</para>
    ///   <para>Types that implement this interface are automatically serializable in <see href="http://geojson.org/">GeoJSON</see>
    /// when using the <see href="http://json.codeplex.com/">JSON.NET</see> serializer.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    [JsonConverter(typeof(Ogc.SimpleFeature.GeometryJsonConverter))]
    public interface ISimpleGeometry:
        IGeometryTap,
        IXmlSerializable
    {

        /// <summary>Returns the envelope of the current geometry.</summary>
        /// <returns>The envelope of the current geometry.</returns>
        ISimpleGeometry Envelope();

        /// <summary>Gets the coordinate system for the geometry.</summary>
        ICoordinateSystem CoordinateSystem { get; }
    }
}
