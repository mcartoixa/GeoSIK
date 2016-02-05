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
using Microsoft.Practices.ServiceLocation;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Iso.Ts19139.Gmd.Tests
{
    public class EX_GeographicBoundingBoxTests:
        IDisposable
    {

        public EX_GeographicBoundingBoxTests()
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
        [InlineData("POLYGON ((-3.52879655219845 47.7719574934302, -3.46039886496209 47.6454843161542, -3.44038685599905 47.6268771314444, -3.43683697349613 47.6262076000154, -3.43621486447034 47.6262215132217, -3.41898015734558 47.6279030271727, -3.30903540493192 47.708677095979, -3.27711150235127 47.7945479077246, -3.27845414469145 47.8022681500519, -3.27978244446548 47.8034644884428, -3.28316070972901 47.8057996153151, -3.52875406458948 47.7728182542147, -3.52879655219845 47.7719574934302))",
            -3.27711150235127D, 47.8057996153151D, 47.6262076000154D, -3.52879655219845D)]
        public void InitFromGeometry_ShouldCreateValidBoundingBox(string wkt, double east, double north, double south, double west)
        {
            var wgs84=CommonServiceLocator.GetCoordinateSystemProvider().Wgs84;
            var builder=new Ogc.Gml.V311.GmlGeometryBuilder(wgs84);
            builder.Parse(wkt, wgs84);
            var input=builder.ConstructedGeometry;

            var res=new EX_GeographicBoundingBox();
            res.InitFromGeometry(input);

            Assert.Equal(east, (double)res.eastBoundLongitude.Decimal.TypedValue);
            Assert.Equal(north, (double)res.northBoundLatitude.Decimal.TypedValue);
            Assert.Equal(south, (double)res.southBoundLatitude.Decimal.TypedValue);
            Assert.Equal(west, (double)res.westBoundLongitude.Decimal.TypedValue);
        }
    }
}
