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

    public class PropertyIsEqualToTests
    {

        [Theory]
        [InlineData(11, "10")]
        [InlineData(20, "10")]
        public void Filter_ShouldFindStringConstraint(int number, string selection)
        {
            string constraint=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/String</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsEqualTo>",
                selection
            );

            var Filter=FilterTests.CreateFilter(constraint);
            var selected=FilterTests.CreateCollection(number).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(Filter);

            Assert.Equal<int>(1, selected.Count<FilterTests.SimpleType>());
            Assert.Equal<string>(selection, selected.First<FilterTests.SimpleType>().String);
        }
    }
}
