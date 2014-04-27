using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.ServiceLocation;
using Moq;
using Newtonsoft.Json;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.SqlServer.Tests
{

    public class SqlGeographyJsonConverterTests
    {

        public SqlGeographyJsonConverterTests()
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

        [Fact]
        public void ReadJson_ShouldParsePolygon()
        {
            string json="{ \"type\": \"Polygon\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ] ] }";
            var polygon=JsonConvert.DeserializeObject<SqlGeography>(json);

            Assert.NotNull(polygon);
            Assert.IsType<SqlGeography>(polygon);
        }
    }
}
