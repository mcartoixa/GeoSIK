using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            public void CreateRequestFromParameters_ShouldParseValidNamespace(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

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
            public void CreateRequestFromParameters_ShouldParseValidRequestId(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

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
            public void CreateRequestFromParameters_ShouldParseValidResultType(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, request.resultType);
            }

            [Theory]
            [InlineData("typeNames=Dummy", "application/xml")]
            [InlineData("outputFormat=application%2Fxml&typeNames=Dummy", "application/xml")]
            [InlineData("outputFormat=text%2Fxml&typeNames=Dummy", "text/xml")]
            public void CreateRequestFromParameters_ShouldParseValidOutputFormat(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, request.outputFormat);
            }

            [Theory]
            [InlineData("typeNames=Dummy", null)]
            [InlineData("outputSchema=http%3A%2F%2Fwww.dummy.xxx&typeNames=Dummy", "http://www.dummy.xxx")]
            [InlineData("outputSchema=urn%3Aoasis%3Anames%3Atc%3Aebxml-regrep%3Arim%3Axsd%3A2.5&typeNames=Dummy", "urn:oasis:names:tc:ebxml-regrep:rim:xsd:2.5")]
            public void CreateRequestFromParameters_ShouldParseValidOutputSchema(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

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
            public void CreateRequestFromParameters_ShouldParseValidStartPosition(string query, int expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<decimal>(expected, request.startPosition);
            }

            [Theory]
            [InlineData("typeNames=Dummy", 10)]
            [InlineData("maxRecords=1&typeNames=Dummy", 1)]
            [InlineData("maxRecords=10&typeNames=Dummy", 10)]
            [InlineData("maxRecords=12345&typeNames=Dummy", 12345)]
            public void CreateRequestFromParameters_ShouldParseValidMaxRecords(string query, int expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<decimal>(expected, request.maxRecords);
            }

            [Theory]
            [InlineData("typeNames=Dummy", "Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeNames=dum%3ADummy", "{urn:dummy}Dummy")]
            [InlineData("typeNames=dum%3ADummy&namespace=xmlns(dum=urn%3Adummy)", "{urn:dummy}Dummy")]
            [InlineData("namespace=xmlns(dum=urn%3Adummy)&typeNames=dum%3ADummy1,dum%3ADummy2", "{urn:dummy}Dummy1,{urn:dummy}Dummy2")]
            public void CreateRequestFromParameters_ShouldParseValidTypeNames(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

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
            public void CreateRequestFromParameters_ShouldParseValidElementName(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

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
            public void CreateRequestFromParameters_ShouldParseValidElementSetName(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, ((Query)request.AbstractQuery).ElementSetName.TypedValue);
            }

            [Theory]
            [InlineData("constraintLanguage=CQL_TEXT&constraint=prop1!%3D10&typeNames=Dummy", "prop1!=10")]
            public void CreateRequestFromParameters_ShouldParseValidCqlConstraint(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, ((Query)request.AbstractQuery).Constraint.CqlText);
            }

            [Theory]
            [InlineData("namespace=xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&constraintLanguage=FILTER&constraint=%3Cogc:Filter%3E%3Cogc:Not%3E%3Cogc:PropertyIsEqualTo%3E%3Cogc:PropertyName%3Eprop1%3C/ogc:PropertyName%3E%3Cogc:Literal%3E10%3C/ogc:Literal%3E%3C/ogc:PropertyIsEqualTo%3E%3C/ogc:Not%3E%3C/ogc:Filter%3E&typeNames=Dummy", "prop1!=10")]
            public void CreateRequestFromParameters_ShouldParseValidFilterConstraint(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                // Should check the inner XML too...
                Assert.NotNull(((Query)request.AbstractQuery).Constraint.Filter);
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
            public void CreateRequestFromParameters_ShouldThrowOnInvalidParameters(string query)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                Assert.Throws<OwsException>(() => discovery.Object.CreateGetRecordsRequestFromParameters(parameters));
            }

        }

        // Gives access to protected methods
        public abstract class GetRecordsDiscoveryAccessor:
            Discovery
        {
            public new GetRecords CreateGetRecordsRequestFromParameters(NameValueCollection parameters)
            {
                return base.CreateGetRecordsRequestFromParameters(parameters);
            }
        }
    }
}
