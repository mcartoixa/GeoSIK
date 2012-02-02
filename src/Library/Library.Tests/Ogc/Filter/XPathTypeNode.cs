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
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Csw202=GeoSik.Services.Csw.V202;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Filter.Tests
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

        [Theory]
        [InlineData(typeof(TestRecordType), Namespaces.OgcWebCatalogCswV202, "csw:Record", 0, 9)]
        public void Constructor_ShouldXmlRootTypesHaveValidSingleChildElement(Type root, string expectedNamespace, string expectedName, int expectedAttributes, int expectedElements)
        {
            var node=new XPathTypeRootNode(root, new XPathTypeContext(XPathTypeNodeProvider.Instance, RecordsNamespacesManager)).ElementChildrenNodes[0];

            Assert.NotNull(node.AttributeChildrenNodes);
            Assert.Equal<int>(expectedAttributes, node.AttributeChildrenNodes.Length);

            Assert.NotNull(node.ElementChildrenNodes);
            Assert.Equal<int>(expectedElements, node.ElementChildrenNodes.Length);

            Assert.Equal<int>(0, node.Index);
            Assert.Equal<string>(expectedName.Substring(expectedName.LastIndexOf(':')+1), node.LocalName);
            Assert.Equal<string>(expectedName, node.Name);
            Assert.Equal<string>(expectedNamespace, node.Namespace);
            Assert.Null(node.MemberInfo);
            Assert.Equal<Type>(root, node.Node);
            Assert.Equal<XmlNodeType>(XmlNodeType.Element, node.NodeType);
            Assert.NotNull(node.Parent);
            Assert.Equal<Type>(root, node.Type);
        }

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

    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    public class TestRecordType
    {

        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=0, IsNullable=false)]
        public string Identifier { get; set; }

        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=1, IsNullable=false)]
        public string Title { get; set; }

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        public IList<string> Subject { get; set; }

        [XmlElement("abstract", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=3, IsNullable=false)]
        public string Description { get; set; }

        [XmlElement("date", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=4)]
        public string Date { get; set; }

        [XmlElement("type", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=5, IsNullable=false)]
        public string Type { get; set; }

        [XmlElement("format", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=6, IsNullable=false)]
        public string Format { get; set; }

        [XmlElement("spatial", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=7, IsNullable=false)]
        public string Spatial { get; set; }

        [XmlElement("relation", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=9, IsNullable=false)]
        public string Relation { get; set; }
    }
}
