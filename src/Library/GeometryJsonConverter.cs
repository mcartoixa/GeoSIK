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
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ProjNet.CoordinateSystems;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Converts a <see cref="IGeometryTap" /> to JSON.</summary>
    /// <remarks>
    ///   <para>The returned JSON is in the <a href="http://en.wikipedia.org/wiki/World_Geodetic_System">WGS84</a>
    /// coordinate reference system.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class GeometryJsonConverter:
        JsonConverter
    {

        internal class JsonSink:
            GeometryTransformerSink
        {

            public JsonSink(JsonWriter writer):
                base(GeographicCoordinateSystem.WGS84)
            {
                Debug.Assert(writer!=null);
                if (writer==null)
                    throw new ArgumentNullException("writer");

                _Writer=writer;
                _CurrentType=new Stack<GeometryType>();
            }

            public override void BeginGeometry(GeometryType type)
            {
                _CurrentType.Push(type);

                _Writer.WriteStartObject();
                _Writer.WritePropertyName("type");
                _Writer.WriteValue(type.ToString("G"));
            }

            public override void EndFigure()
            {
                if (_CurrentType.Peek()!=GeometryType.Point)
                    _Writer.WriteEndArray();
            }

            public override void EndGeometry()
            {
                _Writer.WriteEndObject();

                _CurrentType.Pop();
            }

            protected override void DoSetCoordinateSystem(ProjNet.CoordinateSystems.ICoordinateSystem system)
            {
                // Do nothing (for now): crs is WGS84 by default.
                // cf. http://geojson.org/geojson-spec.html#coordinate-reference-system-objects
            }

            protected override void DoBeginFigure(double x, double y, double? z)
            {
                _Writer.WritePropertyName("coordinates");

                if (_CurrentType.Peek()!=GeometryType.Point)
                    _Writer.WriteStartArray();

                DoAddLine(x, y, z);
            }

            protected override void DoAddLine(double x, double y, double? z)
            {
                _Writer.WriteStartArray();

                _Writer.WriteValue(x);
                _Writer.WriteValue(y);
                if (z.HasValue)
                    _Writer.WriteValue(z);

                _Writer.WriteEndArray();
            }

            private JsonWriter _Writer;
            private Stack<GeometryType> _CurrentType;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IGeometryTap).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new InvalidOperationException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value==null)
            {
                writer.WriteNull();
                return;
            }

            var sink=new JsonSink(writer);
            ((IGeometryTap)value).Populate(sink);
        }

        /// <summary>Gets a value indicating whether this <see cref="GeometryJsonConverter" /> can read JSON.</summary>
        /// <value><c>false</c>, as this converter cannot read JSON.</value>
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }
    }
}
