using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OgcToolkit
{

    public struct Srid
    {

        public Srid(int value)
        {
            _Value=value;
        }

        public static Srid CreateFromCrs(Uri crs)
        {
            return new Srid() {
                Crs=crs
            };
        }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "urn:ogc:def:crs:EPSG::{0}",
                Value
            );
        }

        public Uri Crs
        {
            get
            {
                return new Uri(ToString());
            }
            private set
            {
                if (value==null)
                    throw new ArgumentNullException("value");

                Match m=_CrsRegEx.Match(value.AbsolutePath);
                if (!m.Success)
                    throw new ArgumentException("value");

                Value=Convert.ToInt32(m.Groups["VALUE"].Value);
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
