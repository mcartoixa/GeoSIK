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
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace GeoSik.Ogc.SimpleFeature
{

    public class GeometryConverter:
        TypeConverter
    {

        internal class WktSink:
            IGeometrySink
        {

            public void SetCoordinateSystem(ICoordinateSystem system)
            {
                // unused
            }

            public void BeginGeometry(GeometryType type)
            {
                if ((_Builder.Length>0) && (_Builder[_Builder.Length-1]==')'))
                    _Builder.Append(", ");

                if ((_CurrentType.Count==0) || (_CurrentType.Peek()==GeometryType.GeometryCollection))
                {
                    _Builder.Append(type.ToString("G").ToUpperInvariant());
                    _Builder.Append(" ");
                }

                _CurrentType.Push(type);

                switch (type)
                {
                case GeometryType.GeometryCollection:
                case GeometryType.MultiLineString:
                case GeometryType.MultiPoint:
                case GeometryType.MultiPolygon:
                case GeometryType.Polygon:
                    _Builder.Append("(");
                    break;
                }
            }

            public void BeginFigure(double x, double y, double? z)
            {
                if (_Builder[_Builder.Length-1]==')')
                    _Builder.Append(", ");

                _Builder.AppendFormat(CultureInfo.InvariantCulture, "({0:G} {1:G}", x, y);
                _HasContent=true;
            }

            public void AddLine(double x, double y, double? z)
            {
                _Builder.AppendFormat(CultureInfo.InvariantCulture, ", {0:G} {1:G}", x, y);
            }

            public void EndFigure()
            {
                _Builder.Append(")");
            }

            public void EndGeometry()
            {
                GeometryType type=_CurrentType.Pop();
                bool isEmpty=(_CurrentType.Count==0) && !_HasContent;

                switch (type)
                {
                case GeometryType.GeometryCollection:
                case GeometryType.MultiLineString:
                case GeometryType.MultiPoint:
                case GeometryType.MultiPolygon:
                case GeometryType.Polygon:
                    if (isEmpty)
                        _Builder.Remove(_Builder.Length-1, 1);
                    else
                        _Builder.Append(")");
                    break;
                }

                if (isEmpty)
                    _Builder.Append("EMPTY");
            }

            public override string ToString()
            {
                return _Builder.ToString();
            }

            private StringBuilder _Builder=new StringBuilder();
            private Stack<GeometryType> _CurrentType=new Stack<GeometryType>();
            private bool _HasContent;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var gt=value as IGeometryTap;
            if (gt!=null)
            {
                if (destinationType==typeof(string))
                {
                    var sink=new WktSink();
                    gt.Populate(sink);
                    return sink.ToString();
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
