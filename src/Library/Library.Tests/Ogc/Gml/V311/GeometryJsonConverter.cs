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
        [InlineData("{ \"type\": \"Point\", \"coordinates\": [100.0, 0.0] }", typeof(Point), "POINT (100 0)")]
        [InlineData("{ \"type\": \"MultiPoint\", \"coordinates\": [ [100.0, 0.0], [101.0, 1.0] ] }", typeof(MultiPoint), "MULTIPOINT ((100 0), (101 1))")]
        [InlineData("{ \"type\": \"LineString\", \"coordinates\": [ [100.0, 0.0], [101.0, 1.0] ] }", typeof(LineString), "LINESTRING (100 0, 101 1)")]
        [InlineData("{ \"type\": \"MultiLineString\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 1.0] ], [ [102.0, 2.0], [103.0, 3.0] ] ] }", typeof(MultiLineString), "MULTILINESTRING ((100 0, 101 1), (102 2, 103 3))")]
        [InlineData("{ \"type\": \"Polygon\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ] ] }", typeof(Polygon), "POLYGON ((100 0, 101 0, 101 1, 100 1, 100 0))")]
        [InlineData("{ \"type\": \"Polygon\", \"coordinates\": [ [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ], [ [100.2, 0.2], [100.8, 0.2], [100.8, 0.8], [100.2, 0.8], [100.2, 0.2] ] ] }", typeof(Polygon), "POLYGON ((100 0, 101 0, 101 1, 100 1, 100 0), (100.2 0.2, 100.8 0.2, 100.8 0.8, 100.2 0.8, 100.2 0.2))")]
        [InlineData("{ \"type\": \"MultiPolygon\", \"coordinates\":[ [[[-6.0, 41.0],[10.0, 41.0],[10.0, 52.0],[-6.0, 52.0],[-6.0, 41.0]]], [[[-70.0, 10.0],[-60.0, 10.0],[-60.0, 20.0],[-70.0, 20.0],[-70.0, 10.0]]], [[[-60.0, 0.0],[-50.0, 0.0],[-50.0, 10.0],[-60.0, 10.0],[-60.0, 0.0]]], [[[60.0, -20.0],[50.0, -20.0],[50.0, -30.0],[60.0, -30.0],[60.0, -20.0]]] ]}", typeof(MultiPolygon), "MULTIPOLYGON (((-6 41, 10 41, 10 52, -6 52, -6 41)), ((-70 10, -60 10, -60 20, -70 20, -70 10)), ((-60 0, -50 0, -50 10, -60 10, -60 0)), ((60 -20, 50 -20, 50 -30, 60 -30, 60 -20)))")]
        public void ReadJson_ShouldParseValidGeoJson(string json, Type expectedType, string expectedWkt)
        {
            var g=JsonConvert.DeserializeObject(json, typeof(_Geometry), new GeometryJsonConverter());

            Assert.NotNull(g);
            Assert.IsAssignableFrom(expectedType, g);
            Assert.Equal(expectedWkt, g.ToString());
            Console.WriteLine(g.ToString());
        }

        [Theory]
        [InlineData("POINT (100 0)", "{\"type\":\"Point\",\"coordinates\":[100.0,0.0]}")]
        [InlineData("MULTIPOINT ((100 0), (101 1))", "{\"type\":\"MultiPoint\",\"coordinates\":[[100.0,0.0],[101.0,1.0]]}")]
        [InlineData("LINESTRING (100 0, 101 1)", "{\"type\":\"LineString\",\"coordinates\":[[100.0,0.0],[101.0,1.0]]}")]
        [InlineData("MULTILINESTRING ((100 0, 101 1), (102 2, 103 3))", "{\"type\":\"MultiLineString\",\"coordinates\":[[[100.0,0.0],[101.0,1.0]],[[102.0,2.0],[103.0,3.0]]]}")]
        [InlineData("POLYGON ((100 0, 101 0, 101 1, 100 1, 100 0))", "{\"type\":\"Polygon\",\"coordinates\":[[[100.0,0.0],[101.0,0.0],[101.0,1.0],[100.0,1.0],[100.0,0.0]]]}")]
        [InlineData("POLYGON ((100 0, 101 0, 101 1, 100 1, 100 0), (100.2 0.2, 100.8 0.2, 100.8 0.8, 100.2 0.8, 100.2 0.2))", "{\"type\":\"Polygon\",\"coordinates\":[[[100.0,0.0],[101.0,0.0],[101.0,1.0],[100.0,1.0],[100.0,0.0]],[[100.2,0.2],[100.8,0.2],[100.8,0.8],[100.2,0.8],[100.2,0.2]]]}")]
        [InlineData("MULTIPOLYGON (((-6 41, 10 41, 10 52, -6 52, -6 41)), ((-70 10, -60 10, -60 20, -70 20, -70 10)), ((-60 0, -50 0, -50 10, -60 10, -60 0)), ((60 -20, 50 -20, 50 -30, 60 -30, 60 -20)))", "{\"type\":\"MultiPolygon\",\"coordinates\":[[[[-6.0,41.0],[10.0,41.0],[10.0,52.0],[-6.0,52.0],[-6.0,41.0]]],[[[-70.0,10.0],[-60.0,10.0],[-60.0,20.0],[-70.0,20.0],[-70.0,10.0]]],[[[-60.0,0.0],[-50.0,0.0],[-50.0,10.0],[-60.0,10.0],[-60.0,0.0]]],[[[60.0,-20.0],[50.0,-20.0],[50.0,-30.0],[60.0,-30.0],[60.0,-20.0]]]]}")]
        public void WriteJson_ShouldGenerateValidGeoJson(string wkt, string expectedJson)
        {
            var builder=new GmlGeometryBuilder(CommonServiceLocator.GetCoordinateSystemProvider().Wgs84);
            builder.Parse(wkt, CommonServiceLocator.GetCoordinateSystemProvider().Wgs84);
            var g=builder.ConstructedGeometry;

            var json=JsonConvert.SerializeObject(g, Formatting.None);

            Assert.Equal(expectedJson, json);
        }
    }
}
