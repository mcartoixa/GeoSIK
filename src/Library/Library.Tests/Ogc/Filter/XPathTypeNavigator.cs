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
            Assert.IsType<XPathTypeNavigator>(xpni.Current);
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

        [Fact]
        public void Select_ShouldSimpleNodeHaveValidProperties()
        {
            var navigator=new XPathTypeNavigator(typeof(TestRecordType), XPathTypeNodeTests.RecordsNamespacesManager);
            XPathNodeIterator xpni=navigator.Select("/csw:Record/dc:identifier", XPathTypeNodeTests.RecordsNamespacesManager, true);

            Assert.True(xpni.MoveNext());

            var current=(XPathTypeNavigator)xpni.Current;
            Assert.False(current.HasAttributes);
            Assert.False(current.HasChildren);
            Assert.False(current.IsEmptyElement);
            Assert.False(current.IsList);
            Assert.True(current.IsNode);
            Assert.Equal<string>("identifier", current.LocalName);
            Assert.Equal<string>("dc:identifier", current.Name);
            Assert.Equal<string>(Namespaces.DublinCoreElementsV11, current.NamespaceURI);
            Assert.Equal<XPathNodeType>(XPathNodeType.Element, current.NodeType);
            Assert.Equal<string>("dc", current.Prefix);
            Assert.Equal<Type>(typeof(string), current.Type);
        }

        [Fact]
        public void Select_ShouldCollectionNodeHaveValidProperties()
        {
            var navigator=new XPathTypeNavigator(typeof(TestRecordType), XPathTypeNodeTests.RecordsNamespacesManager);
            XPathNodeIterator xpni=navigator.Select("/csw:Record/dc:subject", XPathTypeNodeTests.RecordsNamespacesManager, true);

            Assert.True(xpni.MoveNext());

            var current=(XPathTypeNavigator)xpni.Current;
            Assert.False(current.HasAttributes);
            Assert.False(current.HasChildren);
            Assert.False(current.IsEmptyElement);
            Assert.True(current.IsList);
            Assert.True(current.IsNode);
            Assert.Equal<string>("subject", current.LocalName);
            Assert.Equal<string>("dc:subject", current.Name);
            Assert.Equal<string>(Namespaces.DublinCoreElementsV11, current.NamespaceURI);
            Assert.Equal<XPathNodeType>(XPathNodeType.Element, current.NodeType);
            Assert.Equal<string>("dc", current.Prefix);
            Assert.Equal<Type>(typeof(string), current.Type);
        }
    }
}
