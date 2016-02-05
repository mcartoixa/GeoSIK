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
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using GeoSik.Ogc.Ows;
using GeoSik.Ogc.WebCatalog.Csw.V202.Types;
using Xunit;
using Xunit.Extensions;
using Moq;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Tests
{
    partial class DiscoveryTests
    {

        public class DescribeRecordTests
        {

            [Theory]
            [InlineData("dummy=dummy", null)]
            [InlineData("Namespace=xmlns(http%3A%2F%2Fwww.dummy.xxx%2F)", ";http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)", "dum;http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)", "dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(http%3A%2F%2Fwww.dummy.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)", ";http://www.dummy.xxx/,dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("dummy=dummy&Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)&dummy=dummy", "dum;http://www.dummy.xxx/")]
            public void CreateRequest_ShouldParseValidNamespace(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var prefixesNamespaces=expected.Split(';', ',');
                    Assert.True((prefixesNamespaces.Length % 2)==0);

                    for (int i=0; i<prefixesNamespaces.Length/2; ++i)
                    {
                        var prefix=prefixesNamespaces[2*i];
                        var @namespace=prefixesNamespaces[2*i+1];
                        if (!string.IsNullOrEmpty(prefix))
                        {
                            Assert.Equal<string>(prefix, request.Untyped.GetPrefixOfNamespace(@namespace));
                            Assert.Equal<string>(@namespace, request.Untyped.GetNamespaceOfPrefix(prefix).NamespaceName);
                        } else
                            Assert.Equal<string>(@namespace, request.Untyped.GetDefaultNamespace().NamespaceName);
                    }
                }
            }

            
            [Theory]
            [InlineData("typeName=Dummy", "Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeName=dum%3ADummy", "{urn:dummy}Dummy")]
            [InlineData("typeName=dum%3ADummy&namespace=xmlns(dum=urn%3Adummy)", "{urn:dummy}Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeName=dum%3ADummy1,dum%3ADummy2", "{urn:dummy}Dummy1,{urn:dummy}Dummy2")]
            public void CreateRequest_ShouldParseValidTypeNames(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exNames=expected
                        .Split(',')
                        .Select<string, XName>(n => XName.Get(n));

                    Assert.NotNull(request.TypeName);

                    // Cannot seem to be able to use the request.TypeName property here...

                    var elementNames=from el in request.Untyped.Descendants()
                                     where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}TypeName"
                                     select el;
                    var xen=elementNames.Select<XElement, XName>(
                        e => (Discovery.GetXmlNameFromString(e.Value, e))
                    );

                    Assert.Equal<int>(exNames.Count<XName>(), xen.Count<XName>());
                    foreach (XName n in exNames)
                        Assert.Contains<XName>(n, xen);
                }
            }

            [Theory]
            [InlineData("dummy=dummy", "application/xml")]
            [InlineData("outputFormat=application%2Fxml", "application/xml")]
            [InlineData("outputFormat=text%2Fxml", "text/xml")]
            public void CreateRequest_ShouldParseValidOutputFormat(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<string>(expected, request.outputFormat);
            }

            [Theory]
            [InlineData("dummy=dummy", Namespaces.StrangeXmlSchemaNamespace)]
            [InlineData("schemaLanguage=http%3A%2F%2Fwww.dummy.xxx", "http://www.dummy.xxx")]
            [InlineData("schemaLanguage=urn%3Adummy", "urn:dummy")]
            public void CreateRequest_ShouldParseValidSchemaLanguage(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exUri=new Uri(expected);
                    Assert.Equal<Uri>(exUri, request.schemaLanguage);
                } else
                    Assert.Null(request.schemaLanguage);
            }

            [Theory]
            // Namespace
            [InlineData("Namespace=http%3A%2F%2Fwww.dummy.xxx%2F")]
            // typeName
            [InlineData("typeName=dum%3ADummy")]
            // outputFormat: values are validated at the GetRecords processing level
            // schemaLanguage
            [InlineData("schemaLanguage=dummy")]
            public void CreateRequest_ShouldThrowOnInvalidParameters(string query)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                Assert.Throws<OwsException>(() => processor.CreateRequest(parameters));
            }

            [Theory]
            [InlineData("dummy")]
            public void CheckRequest_ShouldThrowWhenOutputFormatIsInvalid(string format)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var request=new DescribeRecord()
                {
                    outputFormat=format
                };

                Assert.Throws<OwsException>(() => processor.CheckRequest(request));
            }

            [Theory]
            [InlineData("urn:dummy")]
            public void CheckRequest_ShouldThrowWhenSchemaLanguageIsInvalid(string language)
            {
                var discovery=new Mock<Discovery>();
                var processor=new DescribeRecordProcessorAccessor(discovery.Object);

                var request=new DescribeRecord() {
                    schemaLanguage=(language!=null ? new Uri(language) : null)
                };

                Assert.Throws<OwsException>(() => processor.CheckRequest(request));
            }
        }

        // Gives access to protected methods
        public class DescribeRecordProcessorAccessor:
            Discovery.DescribeRecordProcessorBase
        {

            public DescribeRecordProcessorAccessor(Discovery service):
                base(service)
            {}

            public new void CheckRequest(DescribeRecord request)
            {
                base.CheckRequest(request);
            }

            public new DescribeRecord CreateRequest(NameValueCollection parameters)
            {
                return base.CreateRequest(parameters);
            }
        }
    }
}
