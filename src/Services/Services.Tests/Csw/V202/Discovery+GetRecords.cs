using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Xunit;
using Xunit.Extensions;
using Moq;

namespace OgcToolkit.Services.Csw.V202.Tests
{

    partial class DiscoveryTests
    {

        public class GetRecordsTests
        {

            [Theory]
            [InlineData("typeNames=Dummy", null)]
            [InlineData("Namespace=xmlns(http%3A%2F%2Fwww.dummy.xxx%2F)&typeNames=Dummy", ";http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)&typeNames=Dummy", "dum;http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)&typeNames=Dummy", "dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(http%3A%2F%2Fwww.dummy.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)&typeNames=Dummy", ";http://www.dummy.xxx/,dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("dummy=dummy&Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)&dummy=dummy&typeNames=Dummy", "dum;http://www.dummy.xxx/")]
            public void CreateRequest_ShouldParseValidNamespace(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var prefixesNamespaces=expected.Split(';', ',');
                    Assert.True((prefixesNamespaces.Length%2)==0);

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
            [InlineData("typeNames=Dummy", null)]
            [InlineData("RequestId=http%3A%2F%2Fwww.dummy.xxx&typeNames=Dummy", "http://www.dummy.xxx")]
            [InlineData("requestid=urn%3Auuid%3Af81d4fae-7dec-11d0-a765-00a0c91e6bf6&typeNames=Dummy", "urn:uuid:f81d4fae-7dec-11d0-a765-00a0c91e6bf6")]
            [InlineData("requestId=http%3A%2F%2Fwww.dummy.xxx%2F&typeNames=Dummy", "http://www.dummy.xxx/")]
            [InlineData("dummy=dummy&requestid=http%3A%2F%2Fwww.dummy.xxx%2Ftest&typeNames=Dummy", "http://www.dummy.xxx/test")]
            [InlineData("requestId=urn%3Auuid%3Ace8627a0-685c-11db-bd13-0800200c9a66&dummy=dummy&typeNames=Dummy", "urn:uuid:ce8627a0-685c-11db-bd13-0800200c9a66")]
            public void CreateRequest_ShouldParseValidRequestId(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exUri=new Uri(expected);
                    Assert.Equal<Uri>(exUri, request.requestId);
                } else
                    Assert.Null(request.requestId);
            }

            [Theory]
            [InlineData("typeNames=Dummy", "hits")]
            [InlineData("resultType=hits&typeNames=Dummy", "hits")]
            [InlineData("resultType=results&typeNames=Dummy", "results")]
            [InlineData("resultType=validate&typeNames=Dummy", "validate")]
            public void CreateRequest_ShouldParseValidResultType(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<string>(expected, request.resultType);
            }

            [Theory]
            [InlineData("typeNames=Dummy", "application/xml")]
            [InlineData("outputFormat=application%2Fxml&typeNames=Dummy", "application/xml")]
            [InlineData("outputFormat=text%2Fxml&typeNames=Dummy", "text/xml")]
            public void CreateRequest_ShouldParseValidOutputFormat(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<string>(expected, request.outputFormat);
            }

            [Theory]
            [InlineData("typeNames=Dummy", null)]
            [InlineData("outputSchema=http%3A%2F%2Fwww.dummy.xxx&typeNames=Dummy", "http://www.dummy.xxx")]
            [InlineData("outputSchema=urn%3Aoasis%3Anames%3Atc%3Aebxml-regrep%3Arim%3Axsd%3A2.5&typeNames=Dummy", "urn:oasis:names:tc:ebxml-regrep:rim:xsd:2.5")]
            public void CreateRequest_ShouldParseValidOutputSchema(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exUri=new Uri(expected);
                    Assert.Equal<Uri>(exUri, request.outputSchema);
                } else
                    Assert.Null(request.outputSchema);
            }

            [Theory]
            [InlineData("typeNames=Dummy", 1)]
            [InlineData("startPosition=1&typeNames=Dummy", 1)]
            [InlineData("startPosition=10&typeNames=Dummy", 10)]
            [InlineData("startPosition=12345&typeNames=Dummy", 12345)]
            public void CreateRequest_ShouldParseValidStartPosition(string query, int expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<decimal>(expected, request.startPosition);
            }

            [Theory]
            [InlineData("typeNames=Dummy", 10)]
            [InlineData("maxRecords=1&typeNames=Dummy", 1)]
            [InlineData("maxRecords=10&typeNames=Dummy", 10)]
            [InlineData("maxRecords=12345&typeNames=Dummy", 12345)]
            public void CreateRequest_ShouldParseValidMaxRecords(string query, int expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<decimal>(expected, request.maxRecords);
            }

            [Theory]
            [InlineData("typeNames=Dummy", "Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeNames=dum%3ADummy", "{urn:dummy}Dummy")]
            [InlineData("typeNames=dum%3ADummy&namespace=xmlns(dum=urn%3Adummy)", "{urn:dummy}Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeNames=dum%3ADummy1,dum%3ADummy2", "{urn:dummy}Dummy1,{urn:dummy}Dummy2")]
            public void CreateRequest_ShouldParseValidTypeNames(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exNames=expected
                        .Split(',')
                        .Select<string, XName>(n => XName.Get(n));

                    Assert.NotNull(request.Content.AbstractQuery);
                    Assert.IsAssignableFrom<Query>(request.Content.AbstractQuery);

                    // Cannot seem to be able to use the Query.typeNames property here...
                    string[] typeNames=request.Content.AbstractQuery.Untyped.Attribute("typeNames").Value.Split(' ');
                    foreach (XName name in exNames)
                    {
                        string n=name.ToString();
                        if (!string.IsNullOrEmpty(name.NamespaceName))
                            n=string.Concat(request.Content.AbstractQuery.Untyped.GetPrefixOfNamespace(name.NamespaceName), ":", name.LocalName);
                        Assert.Contains<string>(n, typeNames);
                    }
                } else
                    Assert.Null(request.Content.AbstractQuery);
            }

            [Theory]
            [InlineData("elementName=Dummy&typeNames=Dummy", "Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&elementName=dum%3ADummy&typeNames=Dummy", "{urn:dummy}Dummy")]
            public void CreateRequest_ShouldParseValidElementName(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exNames=expected
                        .Split(',')
                        .Select<string, XName>(n => XName.Get(n));

                    Assert.NotNull(request.Content.AbstractQuery);
                    Assert.IsAssignableFrom<Query>(request.Content.AbstractQuery);

                    // Cannot seem to be able to use the Query.ElementName property here...

                    var elementNames=from el in request.Content.AbstractQuery.Untyped.Descendants()
                                     where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ElementName"
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
            [InlineData("elementSetName=brief&typeNames=Dummy", "brief")]
            [InlineData("elementSetName=summary&typeNames=Dummy", "summary")]
            [InlineData("elementSetName=full&typeNames=Dummy", "full")]
            public void CreateRequest_ShouldParseValidElementSetName(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<string>(expected, ((Query)request.AbstractQuery).ElementSetName.TypedValue);
            }

            [Theory]
            [InlineData("constraintLanguage=CQL_TEXT&constraint=prop1!%3D10&typeNames=Dummy", "prop1!=10")]
            public void CreateRequest_ShouldParseValidCqlConstraint(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                Assert.Equal<string>(expected, ((Query)request.AbstractQuery).Constraint.CqlText);
            }

            [Theory]
            [InlineData("namespace=xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3ANot%3E%3Cogc%3APropertyIsEqualTo%3E%3Cogc%3APropertyName%3Eprop1%3C/ogc%3APropertyName%3E%3Cogc%3ALiteral%3E10%3C/ogc%3ALiteral%3E%3C/ogc%3APropertyIsEqualTo%3E%3C/ogc%3ANot%3E%3C/ogc%3AFilter%3E&typeNames=Dummy", "prop1!=10")]
            public void CreateRequest_ShouldParseValidFilterConstraint(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                // Should check the inner XML too...
                Assert.NotNull(((Query)request.AbstractQuery).Constraint.Filter);
            }

            [Theory]
            //[InlineData("typeNames=Dummy", 0)]
            [InlineData("sortBy=dummy&typeNames=Dummy", 1)]
            [InlineData("sortBy=dummy%3AA&typeNames=Dummy", 1)]
            [InlineData("sortBy=dummy%3AD&typeNames=Dummy", 1)]
            [InlineData("sortBy=dummy%3AA,dummy%3AD,dummy&typeNames=Dummy", 3)]
            public void CreateRequest_ShouldParseValidSortBy(string query, int expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                // Should check the inner XML too...
                if (expected>0)
                {
                    Assert.NotNull(((Query)request.AbstractQuery).SortBy);
                    Assert.Equal<int>(expected, ((Query)request.AbstractQuery).SortBy.SortProperty.Count);
                } else
                    Assert.Null(((Query)request.AbstractQuery).SortBy);
            }

            [Theory]
            [InlineData("typeNames=Dummy", false)]
            [InlineData("distributedSearch=FALSE&typeNames=Dummy", false)]
            [InlineData("distributedSearch=TRUE&typeNames=Dummy", true)]
            public void CreateRequest_ShouldParseValidDistributedSearch(string query, bool expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                // LinqToXsd bug?
                //if (expected)
                //    Assert.NotNull<decimal>(expected, request.DistributedSearch);
                //else
                //    Assert.Null<decimal>(expected, request.DistributedSearch);

                var dc=from el in request.Untyped.Descendants()
                       where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}DistributedSearch"
                       select el;
                Assert.Equal<int>(expected ? 1 : 0, dc.Count<XElement>());
            }

            [Theory]
            [InlineData("hopCount=1&distributedSearch=TRUE&typeNames=Dummy", 1)]
            [InlineData("hopCount=10&distributedSearch=TRUE&typeNames=Dummy", 10)]
            [InlineData("hopCount=12345&distributedSearch=TRUE&typeNames=Dummy", 12345)]
            public void CreateRequest_ShouldParseValidHopCount(string query, int expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                // LinqToXsd bug?
                //Assert.Equal<decimal>(expected, request.DistributedSearch.hopCount);

                var hc=from el in request.Untyped.Descendants()
                       where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}DistributedSearch"
                       select el.Attribute("hopCount").Value;
                Assert.Equal<int>(1, hc.Count<string>());
                Assert.Equal<int>(expected, int.Parse(hc.First<string>(), CultureInfo.InvariantCulture));
            }

            [Theory]
            [InlineData("typeNames=Dummy", null)]
            [InlineData("responseHandler=http%3A%2F%2Fwww.dummy.xxx&typeNames=Dummy", "http://www.dummy.xxx")]
            [InlineData("responseHandler=urn%3Adummy&typeNames=Dummy", "urn:dummy")]
            public void CreateRequest_ShouldParseValidResponseHandler(string query, string expected)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                var request=processor.CreateRequest(parameters);

                if (expected!=null)
                {
                    var exUri=new Uri(expected);

                    // LinqToXsd bug?
                    //Assert.Equal<int>(1, request.ResponseHandler.Count);
                    //Assert.Contains<Uri>(exUri, request.ResponseHandler);

                    var handlers=from el in request.Untyped.Descendants()
                                 where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ResponseHandler"
                                 select new Uri(el.Value);
                    Assert.Equal<int>(1, handlers.Count<Uri>());
                    Assert.Contains<Uri>(exUri, handlers);

                } else
                    Assert.Empty(request.ResponseHandler);
            }

            [Theory]
            // Namespace
            [InlineData("Namespace=http%3A%2F%2Fwww.dummy.xxx%2F&typeNames=Dummy")]
            // RequestId
            [InlineData("RequestId=3&typeNames=Dummy")]
            [InlineData("requestId=test&typeNames=Dummy")]
            [InlineData("dummy=dummy&requestId=test&typeNames=Dummy")]
            [InlineData("requestId=test&dummy=dummy&typeNames=Dummy")]
            // resultType: values are validated at the GetRecords processing level
            // outputFormat: values are validated at the GetRecords processing level
            // outputSchema
            [InlineData("outputSchema=dummy&typeNames=Dummy")]
            // startPosition
            [InlineData("startPosition=-1&typeNames=Dummy")]
            [InlineData("startPosition=0x15&typeNames=Dummy")]
            [InlineData("startPosition=dummy&typeNames=Dummy")]
            // maxRecords
            [InlineData("maxRecords=-1&typeNames=Dummy")]
            [InlineData("maxRecords=0x15&typeNames=Dummy")]
            [InlineData("maxRecords=dummy&typeNames=Dummy")]
            // typeNames
            [InlineData("dummy=dummy")]
            [InlineData("typeNames=dum%3ADummy")]
            // elementName
            [InlineData("elementName=dum%3ADummy&typeNames=Dummy")]
            // elementSetName: values are validated at the GetRecords processing level
            // constraint
            [InlineData("constraint=prop1!%3D10&typeNames=Dummy")]
            [InlineData("constraintLanguage=DUMMY&constraint=prop1!%3D10&typeNames=Dummy")]
            [InlineData("constraintLanguage=FILTER&constraint=prop1!%3D10&typeNames=Dummy")]
            // distributedSearch
            [InlineData("distributedSearch=dummy&typeNames=Dummy")]
            // hopCount
            [InlineData("hopCount=dummy&distributedSearch=TRUE&typeNames=Dummy")]
            // responseHandler
            [InlineData("responseHandler=dummy&typeNames=Dummy")]
            public void CreateRequest_ShouldThrowOnInvalidParameters(string query)
            {
                var discovery=new Mock<Discovery>();
                var processor=new GetRecordsProcessorAccessor(discovery.Object);

                var parameters=HttpUtility.ParseQueryString(query);

                Assert.Throws<OwsException>(() => processor.CreateRequest(parameters));
            }

        }

        // Gives access to protected methods
        public class GetRecordsProcessorAccessor:
            Discovery.GetRecordsProcessorBase
        {

            public GetRecordsProcessorAccessor(Discovery service):
                base(service)
            {}

            public new GetRecords CreateRequest(NameValueCollection parameters)
            {
                return base.CreateRequest(parameters);
            }
        }
    }
}
