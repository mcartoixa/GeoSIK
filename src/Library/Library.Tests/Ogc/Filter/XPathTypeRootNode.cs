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
using Csw202=GeoSik.Services.Csw.V202;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Filter.Tests
{

    public class XPathTypeRootNodeTests
    {

        [Theory]
        [InlineData(typeof(string))]
        [InlineData(typeof(bool))]
        [InlineData(typeof(int))]
        public void Constructor_ShouldAcceptCommonRootTypes(Type root)
        {
            var node=new XPathTypeRootNode(root, new XPathTypeContext(XPathTypeNodeProvider.Instance));

            Assert.NotNull(node.AttributeChildrenNodes);
            Assert.Equal<int>(0, node.AttributeChildrenNodes.Length);

            Assert.NotNull(node.ElementChildrenNodes);
            Assert.Equal<int>(1, node.ElementChildrenNodes.Length);

            Assert.Equal<int>(-1, node.Index);
            Assert.Equal<string>(root.Name, node.LocalName);
            Assert.Equal<string>(root.Name, node.Name);
            Assert.Equal<string>(string.Empty, node.Namespace);
            Assert.Null(node.MemberInfo);
            Assert.Equal<Type>(root, node.Node);
            Assert.Equal<XmlNodeType>(XmlNodeType.Element, node.NodeType);
            Assert.Null(node.Parent);
            Assert.Equal<Type>(root, node.Type);
        }

        [Theory]
        [InlineData(typeof(TestRecordType), Namespaces.OgcWebCatalogCswV202, "csw:Record")]
        public void Constructor_ShouldAcceptXmlRootTypes(Type root, string expectedNamespace, string expectedName)
        {
            var node=new XPathTypeRootNode(root, new XPathTypeContext(XPathTypeNodeProvider.Instance, XPathTypeNodeTests.RecordsNamespacesManager));

            Assert.NotNull(node.AttributeChildrenNodes);
            Assert.Equal<int>(0, node.AttributeChildrenNodes.Length);

            Assert.NotNull(node.ElementChildrenNodes);
            Assert.Equal<int>(1, node.ElementChildrenNodes.Length);

            Assert.Equal<int>(-1, node.Index);
            Assert.Equal<string>(expectedName.Substring(expectedName.LastIndexOf(':')+1), node.LocalName);
            Assert.Equal<string>(expectedName, node.Name);
            Assert.Equal<string>(expectedNamespace, node.Namespace);
            Assert.Null(node.MemberInfo);
            Assert.Equal<Type>(root, node.Node);
            Assert.Equal<XmlNodeType>(XmlNodeType.Element, node.NodeType);
            Assert.Null(node.Parent);
            Assert.Equal<Type>(root, node.Type);
        }
    }
}
