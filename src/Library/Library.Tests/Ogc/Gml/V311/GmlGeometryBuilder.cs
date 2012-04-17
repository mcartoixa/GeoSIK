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
using Microsoft.Practices.ServiceLocation;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Gml.V311.Tests
{

    public class GmlGeometryBuilderTests:
        IDisposable
    {

        public GmlGeometryBuilderTests()
        {
            var wgs84Mock=new Mock<ICoordinateSystem>(MockBehavior.Loose);
            wgs84Mock.Setup(wgs => wgs.Code).Returns(4326);
            wgs84Mock.Setup(wgs => wgs.Equals(It.IsAny<ICoordinateSystem>())).Returns(true);
            wgs84Mock.Setup(wgs => wgs.IsEquivalentTo(It.IsAny<ICoordinateSystem>())).Returns(true);
            var cspMock=new Mock<ICoordinateSystemProvider>(MockBehavior.Loose);
            cspMock.Setup(csp => csp.Wgs84).Returns(wgs84Mock.Object);
            cspMock.Setup(csp => csp.GetById(new Srid(4326))).Returns(wgs84Mock.Object);

            var serviceLocatorMock=new Mock<IServiceLocator>(MockBehavior.Loose);
            serviceLocatorMock.Setup(x => x.GetInstance<ICoordinateSystemProvider>()).Returns(cspMock.Object);

            ServiceLocator.SetLocatorProvider(() => serviceLocatorMock.Object);
        }

        public void Dispose()
        {
            ServiceLocator.SetLocatorProvider(null);
        }

        [Theory]
        [InlineData("Point (10 10)", "POINT (10 10)")]
        [InlineData("Point Empty", "POINT EMPTY")]
        [InlineData("LineString ( 10 10, 20 20, 30 40)", "LINESTRING (10 10, 20 20, 30 40)")]
        [InlineData("LineString Empty", "LINESTRING EMPTY")]
        [InlineData("Polygon ((10 10, 20 15, 20 20, 10 20, 10 10))", "POLYGON ((10 10, 20 15, 20 20, 10 20, 10 10))")]
        [InlineData("Polygon Empty", "POLYGON EMPTY")]
        [InlineData("MultiPoint ((10 10), (20 20))", "MULTIPOINT ((10 10), (20 20))")]
        [InlineData("MultiPoint Empty", "MULTIPOINT EMPTY")]
        [InlineData("MultiLineString ( (10 10, 20 20), (15 15, 30 15) )", "MULTILINESTRING ((10 10, 20 20), (15 15, 30 15))")]
        [InlineData("MultiLineString Empty", "MULTILINESTRING EMPTY")]
        [InlineData("MultiPolygon ( ((10 10, 20 15, 20 20, 10 20, 10 10)), ((60 60, 70 70, 80 60, 60 60 )) )", "MULTIPOLYGON (((10 10, 20 15, 20 20, 10 20, 10 10)), ((60 60, 70 70, 80 60, 60 60)))")]
        [InlineData("MultiPolygon Empty", "MULTIPOLYGON EMPTY")]
        [InlineData("GeometryCollection ( POINT (10 10), POINT (30 30), LINESTRING (15 15, 20 20) )", "GEOMETRYCOLLECTION (POINT (10 10), POINT (30 30), LINESTRING (15 15, 20 20))")]
        [InlineData("GeometryCollection Empty", "GEOMETRYCOLLECTION EMPTY")]
        public void ShouldParseWkt(string input, string expected)
        {
            var builder=new GmlGeometryBuilder();
            builder.Parse(input, CommonServiceLocator.GetCoordinateSystemProvider().Wgs84);

            var g=builder.ConstructedGeometry;

            Assert.Equal<string>(expected, g.ToString());
        }
    }
}
