using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using Csw202=OgcToolkit.Services.Csw.V202;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Ogc.Filter.Tests
{

    public class XPathTypeNavigatorTests
    {

        [Theory]
        [InlineData(typeof(TestRecordType), "dc:identifier")]
        [InlineData(typeof(TestRecordType), "/dc:identifier")]
        [InlineData(typeof(TestRecordType), "dc:title")]
        [InlineData(typeof(TestRecordType), "/dc:title")]
        [InlineData(typeof(TestRecordType), "csw:Record")]
        [InlineData(typeof(TestRecordType), "/csw:Record")]
        [InlineData(typeof(TestRecordType), "/csw:Record/dc:title")]
        public void Select_ShouldFindCswRecordsNodes(Type root, string xpath)
        {
            var navigator=new XPathTypeNavigator(root, XPathTypeNodeTests.RecordsNamespacesManager);
            XPathNodeIterator xpni=navigator.Select(xpath, XPathTypeNodeTests.RecordsNamespacesManager, true);

            Assert.Equal<int>(1, xpni.Count);
            Assert.True(xpni.MoveNext());
            Assert.NotNull(xpni.Current);
        }

        [Theory]
        [InlineData(typeof(TestRecordType), "dc:dummy")]
        [InlineData(typeof(TestRecordType), "/dc:dummy")]
        [InlineData(typeof(TestRecordType), "csw:dummy")]
        [InlineData(typeof(TestRecordType), "/csw:dummy")]
        [InlineData(typeof(TestRecordType), "/csw:Record/dc:dummy")]
        public void Select_ShouldNotFindInvalidCswRecordsNodes(Type root, string xpath)
        {
            var navigator=new XPathTypeNavigator(root, XPathTypeNodeTests.RecordsNamespacesManager);
            XPathNodeIterator xpni=navigator.Select(xpath, XPathTypeNodeTests.RecordsNamespacesManager, true);

            Assert.Equal<int>(0, xpni.Count);
        }
    }
}
