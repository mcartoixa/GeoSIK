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
            [InlineData("dummy=dummy", null)]
            [InlineData("Namespace=xmlns(http%3A%2F%2Fwww.dummy.xxx%2F)", ";http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)", "dum;http://www.dummy.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)", "dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("Namespace=xmlns(dum1=http%3A%2F%2Fwww.dummy1.xxx%2F),xmlns(http%3A%2F%2Fwww.dummy.xxx%2F),xmlns(dum2=http%3A%2F%2Fwww.dummy2.xxx%2F)", ";http://www.dummy.xxx/,dum1;http://www.dummy1.xxx/,dum2;http://www.dummy2.xxx/")]
            [InlineData("dummy=dummy&Namespace=xmlns(dum=http%3A%2F%2Fwww.dummy.xxx%2F)&dummy=dummy", "dum;http://www.dummy.xxx/")]
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
            [InlineData("dummy=dummy", null)]
            [InlineData("RequestId=http%3A%2F%2Fwww.dummy.xxx", "http://www.dummy.xxx")]
            [InlineData("requestid=urn%3Auuid%3Af81d4fae-7dec-11d0-a765-00a0c91e6bf6", "urn:uuid:f81d4fae-7dec-11d0-a765-00a0c91e6bf6")]
            [InlineData("requestId=http%3A%2F%2Fwww.dummy.xxx%2F", "http://www.dummy.xxx/")]
            [InlineData("dummy=dummy&requestid=http%3A%2F%2Fwww.dummy.xxx%2Ftest", "http://www.dummy.xxx/test")]
            [InlineData("requestId=urn%3Auuid%3Ace8627a0-685c-11db-bd13-0800200c9a66&dummy=dummy", "urn:uuid:ce8627a0-685c-11db-bd13-0800200c9a66")]
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
            [InlineData("resultType=hits", "hits")]
            [InlineData("resultType=results", "results")]
            [InlineData("resultType=validate", "validate")]
            public void CreateRequestFromParameters_ShouldParseValidResultType(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, request.resultType);
            }

            [Theory]
            [InlineData("outputFormat=application%2Fxml", "application/xml")]
            [InlineData("outputFormat=text%2Fxml", "text/xml")]
            public void CreateRequestFromParameters_ShouldParseValidOutputFormat(string query, string expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<string>(expected, request.outputFormat);
            }

            [Theory]
            [InlineData("outputSchema=http%3A%2F%2Fwww.dummy.xxx", "http://www.dummy.xxx")]
            [InlineData("outputSchema=urn%3Aoasis%3Anames%3Atc%3Aebxml-regrep%3Arim%3Axsd%3A2.5", "urn:oasis:names:tc:ebxml-regrep:rim:xsd:2.5")]
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
            [InlineData("dummy=dummy", 1)]
            [InlineData("startPosition=1", 1)]
            [InlineData("startPosition=10", 10)]
            [InlineData("startPosition=12345", 12345)]
            public void CreateRequestFromParameters_ShouldParseValidStartPosition(string query, int expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<decimal>(expected, request.startPosition);
            }

            [Theory]
            [InlineData("dummy=dummy", 10)]
            [InlineData("maxRecords=1", 1)]
            [InlineData("maxRecords=10", 10)]
            [InlineData("maxRecords=12345", 12345)]
            public void CreateRequestFromParameters_ShouldParseValidMaxRecords(string query, int expected)
            {
                var discovery=new Mock<GetRecordsDiscoveryAccessor>();
                var parameters=HttpUtility.ParseQueryString(query);

                var request=discovery.Object.CreateGetRecordsRequestFromParameters(parameters);

                Assert.Equal<decimal>(expected, request.maxRecords);
            }

            [Theory]
            [InlineData("dummy=dummy", null)]
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
                    string[] typeNames=request.Content.AbstractQuery.Untyped.Attribute("{http://www.opengis.net/cat/csw/2.0.2}typeNames").Value.Split(' ');
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
            // Namespace
            [InlineData("Namespace=http%3A%2F%2Fwww.dummy.xxx%2F")]
            // RequestId
            [InlineData("RequestId=3")]
            [InlineData("requestId=test")]
            [InlineData("dummy=dummy&requestId=test")]
            [InlineData("requestId=test&dummy=dummy")]
            // resultType: values are validated at the GetRecords processing level
            // outputFormat: values are validated at the GetRecords processing level
            // outputSchema
            [InlineData("outputSchema=dummy")]
            // startPosition
            [InlineData("startPosition=-1")]
            [InlineData("startPosition=0x15")]
            [InlineData("startPosition=dummy")]
            // maxRecords
            [InlineData("maxRecords=-1")]
            [InlineData("maxRecords=0x15")]
            [InlineData("maxRecords=dummy")]
            // typeNames
            [InlineData("typeNames=dum%3ADummy")]
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
