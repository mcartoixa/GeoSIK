using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.ServiceLocation;
using Moq;
using Newtonsoft.Json;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Gml.V311.Tests
{

    public class GeometryJsonConverterTests
    {

        public GeometryJsonConverterTests()
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

        [Theory]
        [InlineData("{ \"type\": \"Point\", \"coordinates\": [100.0, 0.0] }", typeof(Point))]
        [InlineData("{ \"type\": \"LineString\", \"coordinates\": [ [100.0, 0.0], [101.0, 1.0] ] }", typeof(LineString))]
        [InlineData("{ \"type\": \"MultiLineString\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 1.0] ], [ [102.0, 2.0], [103.0, 3.0] ] ] }", typeof(MultiLineString))]
        [InlineData("{ \"type\": \"Polygon\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ] ] }", typeof(Polygon))]
        public void ReadJson_ShouldParseGeoJson(string json, Type expectedType)
        {
            var g=JsonConvert.DeserializeObject(json, typeof(_Geometry), new GeometryJsonConverter());

            Assert.NotNull(g);
            Assert.IsAssignableFrom(expectedType, g);
            Console.WriteLine(g.ToString());
        }
    }
}
