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
using System.Globalization;
using System.Linq;
using System.Text;
using ProjNet.CoordinateSystems;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Gml.V311.Tests
{

    public class PointTests
    {

        [Theory]
        [InlineData(30, 10, null, "POINT (30 10)")]
        [InlineData(0, 0, null, "POINT (0 0)")]
        [InlineData(1.2345, 9.8765, null, "POINT (1.2345 9.8765)")]
        public void ShouldSerializeToWkt(double x, double y, double? z, string expectedWkt)
        {
            var coords=new List<double>(new double[] { x, y });
            if (z.HasValue)
                coords.Add(z.Value);

            var point=new Point() {
                pos=new pos(),
                CoordinateSystem=GeographicCoordinateSystem.WGS84
            };
            point.pos.Untyped.Value=string.Join(
                " ",
                coords.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );

            Assert.Equal<string>(expectedWkt, point.ToString());
        }
    }
}
