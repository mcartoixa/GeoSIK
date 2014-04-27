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
using Xunit;
using Xunit.Extensions;

namespace GeoSik.ProjNet.Tests
{

    public class CoordinatesTransformerTests
    {

        [Fact]
        public void ShouldConvertPointsFromWgs84ToLambert93()
        {
            var csp=new CoordinateSystemProvider();
            var ct=csp.CreateTransformer(csp.Wgs84, csp.GetById(new Srid(2154)));

            foreach (var coordinates in new double[][][] { _Paris, _NewYorkCity })
            {
                var input=coordinates[0];
                var expected=coordinates[1];
                var result=ct.Convert(input);

                Assert.Equal(expected, result, new CoordinateComparer(1));
            }
        }

        // Original transformations from http://cs2cs.mygeodata.eu/
        private static readonly double[][] _Paris=new double[][] {
            new double [] { 48.856601, 2.352221 }, // WGS84
            new double [] { 6960801.94817, 3114985.8595 } // RGF93 / Lambert 93
        };
        private static readonly double[][] _NewYorkCity=new double[][] {
            new double [] { 40.712685, -74.006066 }, // WGS84
            new double [] { 23039517.165, -30506903.8026 } // RGF93 / Lambert 93
        };
    }
}
