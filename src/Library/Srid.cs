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
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OgcToolkit
{

    public struct Srid:
        IEquatable<Srid>,
        IFormattable
    {

        public Srid(int value)
        {
            _Value=value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Srid))
                return false;

            return Equals((Srid)obj);
        }

        public bool Equals(Srid other)
        {
            return other.Value==Value;
        }

        public override int GetHashCode()
        {
            return _Value.GetHashCode();
        }

        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format="G";

            switch (format)
            {
            case "G":
                return string.Format(
                    formatProvider,
                    "urn:ogc:def:crs:EPSG::{0}",
                    Value
                );
            case "X":
                return string.Format(
                    formatProvider,
                    "urn:x-ogc:def:crs:EPSG::{0}",
                    Value
                );
            default:
                throw new FormatException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.UnsupportedFormatString,
                        format
                    )
                );
            }
        }

        public static Srid CreateFromCrs(Uri crs)
        {
            return new Srid() {
                Crs=crs
            };
        }

        public static bool operator==(Srid idl, Srid idr)
        {
            return idl.Equals(idr);
        }

        public static bool operator!=(Srid idl, Srid idr)
        {
            return !idl.Equals(idr);
        }

        public Uri Crs
        {
            get
            {
                return new Uri(ToString());
            }
            [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Justification="value is the indeed the name of the parameter.")]
            private set
            {
                if (value==null)
                    throw new ArgumentNullException("value");

                Match m=_CrsRegEx.Match(value.AbsolutePath);
                if (!m.Success)
                    throw new ArgumentException("value");

                Value=Convert.ToInt32(m.Groups["VALUE"].Value, CultureInfo.InvariantCulture);
            }
        }

        public int Value
        {
            get
            {
                return _Value;
            }
            private set
            {
                _Value=value;
            }
        }

        private int _Value;

        private static readonly Regex _CrsRegEx=new Regex(@"(ogc|x-ogc):def:crs:EPSG:(?<VERSION>[\d\.]*):(?<VALUE>\d+)", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
    }
}
