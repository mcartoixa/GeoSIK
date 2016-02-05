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
using Microsoft.Practices.ServiceLocation;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Gml.V311.Tests
{

    public class PointTests:
        IDisposable
    {

        public PointTests()
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
        [InlineData(30, 10, null, "POINT (30 10)")]
        [InlineData(0, 0, null, "POINT (0 0)")]
        [InlineData(1.2345, 9.8765, null, "POINT (1.2345 9.8765)")]
        public void ShouldSerializeToWkt(double x, double y, double? z, string expectedWkt)
        {
            var wgs84Mock=new Mock<ICoordinateSystem>(MockBehavior.Loose);

            var coords=new List<double>(new double[] { x, y });
            if (z.HasValue)
                coords.Add(z.Value);

            var point=new Point() {
                pos=new pos(),
                CoordinateSystem=CommonServiceLocator.GetCoordinateSystemProvider().Wgs84
            };
            point.pos.Untyped.Value=string.Join(
                " ",
                coords.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );

            Assert.Equal<string>(expectedWkt, point.ToString());
        }
    }
}
