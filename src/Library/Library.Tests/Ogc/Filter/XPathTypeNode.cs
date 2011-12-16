using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Csw202=OgcToolkit.Services.Csw.V202;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Ogc.Filter.Tests
{

    public class XPathTypeNodeTests
    {

        [Theory]
        [InlineData(typeof(string), 0, 0)]
        [InlineData(typeof(bool), 0, 0)]
        [InlineData(typeof(int), 0, 0)]
        [InlineData(typeof(object), 0, 0)]
        [InlineData(typeof(Version), 0, 6)]
        public void Constructor_ShouldCommonRootTypesHaveValidSingleChildElement(Type root, int expectedAttributes, int expectedElements)
        {
            var node=new XPathTypeRootNode(root, new XPathTypeContext(XPathTypeNodeProvider.Instance)).ElementChildrenNodes[0];

            Assert.NotNull(node.AttributeChildrenNodes);
            Assert.Equal<int>(expectedAttributes, node.AttributeChildrenNodes.Length);

            Assert.NotNull(node.ElementChildrenNodes);
            Assert.Equal<int>(expectedElements, node.ElementChildrenNodes.Length);

            Assert.Equal<int>(0, node.Index);
            Assert.Equal<string>(root.Name, node.LocalName);
            Assert.Equal<string>(root.Name, node.Name);
            Assert.Equal<string>(string.Empty, node.Namespace);
            Assert.Null(node.MemberInfo);
            Assert.Equal<Type>(root, node.Node);
            Assert.Equal<XmlNodeType>(XmlNodeType.Element, node.NodeType);
            Assert.NotNull(node.Parent);
            Assert.Equal<Type>(root, node.Type);
        }

        //[Theory]
        //[InlineData(typeof(Csw202.IBriefRecord), Namespaces.OgcWebCatalogCswV202, "csw:Record", 0, 3)]
        //public void Constructor_ShouldXmlRootTypesHaveValidSingleChildElement(Type root, string expectedNamespace, string expectedName, int expectedAttributes, int expectedElements)
        //{
        //    var node=new XPathTypeRootNode(root, new XPathTypeContext(RecordsNamespacesManager)).ElementChildrenNodes[0];

        //    Assert.NotNull(node.AttributeChildrenNodes);
        //    Assert.Equal<int>(expectedAttributes, node.AttributeChildrenNodes.Length);

        //    Assert.NotNull(node.ElementChildrenNodes);
        //    Assert.Equal<int>(expectedElements, node.ElementChildrenNodes.Length);

        //    Assert.Equal<int>(0, node.Index);
        //    Assert.Equal<string>(expectedName.Substring(expectedName.LastIndexOf(':')+1), node.LocalName);
        //    Assert.Equal<string>(expectedName, node.Name);
        //    Assert.Equal<string>(expectedNamespace, node.Namespace);
        //    Assert.Null(node.MemberInfo);
        //    Assert.Equal<Type>(root, node.Node);
        //    Assert.Equal<XmlNodeType>(XmlNodeType.Element, node.NodeType);
        //    Assert.NotNull(node.Parent);
        //    Assert.Equal<Type>(root, node.Type);
        //}

        //internal class SimpleType
        //{
        //    public string String { get; set; }
        //    public int Integer { get; set; }
        //    public SimpleType Embedded { get; set; }
        //}

        internal static XmlNamespaceManager RecordsNamespacesManager
        {
            get
            {
                if (_RecordsNamespacesManager==null)
                {
                    _RecordsNamespacesManager=new XmlNamespaceManager(new NameTable());
                    _RecordsNamespacesManager.AddNamespace(string.Empty, Namespaces.OgcWebCatalogCswV202);
                    _RecordsNamespacesManager.AddNamespace("csw", Namespaces.OgcWebCatalogCswV202);
                    _RecordsNamespacesManager.AddNamespace("dc", Namespaces.DublinCoreElementsV11);
                    _RecordsNamespacesManager.AddNamespace("gmd", Namespaces.IsoTs19139Gmd);
                    _RecordsNamespacesManager.AddNamespace("gml", Namespaces.OgcGml);
                }
                return _RecordsNamespacesManager;
            }
        }

        private static XmlNamespaceManager _RecordsNamespacesManager;
    }
}
