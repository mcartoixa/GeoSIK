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
        IEquatable<Srid>
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
            return string.Format(
                CultureInfo.InvariantCulture,
                "urn:ogc:def:crs:EPSG::{0}",
                Value
            );
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
