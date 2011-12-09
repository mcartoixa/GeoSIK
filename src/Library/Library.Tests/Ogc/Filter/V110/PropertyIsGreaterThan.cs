using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Ogc.Filter.V110.Tests
{

    public class PropertyIsGreaterThanTests
    {

        [Theory]
        [InlineData("<ogc:PropertyIsGreaterThan><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsGreaterThan>", 11, 10, 0)]
        [InlineData("<ogc:PropertyIsGreaterThan><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsGreaterThan>", 20, 10, 9)]
        [InlineData("<ogc:PropertyIsGreaterThan><ogc:Literal>{0}</ogc:Literal><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName></ogc:PropertyIsGreaterThan>", 11, 10, 0)]
        [InlineData("<ogc:PropertyIsGreaterThan><ogc:Literal>{0}</ogc:Literal><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName></ogc:PropertyIsGreaterThan>", 20, 10, 9)]
        public void Filter_ShouldFindIntegerConstraint(string constraint, int elements, int threshold, int expectedNumber)
        {
            string c=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsGreaterThan><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsGreaterThan>",
                threshold
            );

            var filter=FilterTests.CreateFilter(c);
            var selected=FilterTests.CreateCollection(elements).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(filter);

            Assert.Equal<int>(expectedNumber, selected.Count<FilterTests.SimpleType>());
            foreach (FilterTests.SimpleType s in selected)
                Assert.True(s.Integer>threshold);
        }
    }
}
