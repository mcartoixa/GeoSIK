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

using Newtonsoft.Json;
using SqlTypes = Microsoft.SqlServer.Types;

namespace GeoSik.SqlServer
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Converts a <see cref="SqlGeography" /> to JSON.</summary>
    /// <remarks>
    ///   <para>The returned JSON is in the <see href="http://en.wikipedia.org/wiki/World_Geodetic_System">WGS84</see>
    /// coordinate reference system.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class SqlGeographyJsonConverter:
        Ogc.SimpleFeature.GeometryJsonConverter
    {

        /// <summary>Writes the GeoJSON representation of the object.</summary>
        /// <param name="writer">The <see cref="JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var g = value as SqlGeography;
            if ((g!=null) && ((SqlTypes.SqlGeography)g).InstanceOf("FULLGLOBE"))
            {
                // ?
                writer.WriteNull();
                return;
            } else
                base.WriteJson(writer, value, serializer);
        }

        /// <summary>Creates the <see cref="IGeometryBuilder" /> that will be used to deserialize the
        /// JSON input into a <see cref="SqlGeography" /> instance.</summary>
        /// <returns>A <see cref="SqlGeometryBuilder" />.</returns>
        protected override IGeometryBuilder CreateGeometryBuilder()
        {
            return new SqlGeometryBuilder();
        }
    }
}
