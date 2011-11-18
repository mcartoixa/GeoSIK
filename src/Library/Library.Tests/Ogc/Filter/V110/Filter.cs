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

    public class FilterTests
    {

        [Fact]
        public void CreateLambda_ShouldParseSimpleStringConstraint()
        {
            const string constraint="<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/String</ogc:PropertyName><ogc:Literal>10</ogc:Literal></ogc:PropertyIsEqualTo>";

            var namespaceManager=new XmlNamespaceManager(new NameTable());
            namespaceManager.AddNamespace(string.Empty, "http://www.opengis.net/ogc");
            namespaceManager.AddNamespace("ogc", "http://www.opengis.net/ogc");

            var Filter=new Filter();
            Filter.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"ogc", "http://www.opengis.net/ogc")
            );
            XmlParserContext context=new XmlParserContext(null, namespaceManager, null, XmlSpace.None);
            using (var r=new XmlTextReader(constraint, XmlNodeType.Element, context))
            {
                var c=XElement.Load(r);
                Filter.Untyped.AddFirst(c);
            }

            var source=new List<SimpleType>(20);
            for (int i=0; i<20; ++i)
                source.Add(new SimpleType() { String=i.ToString(CultureInfo.InvariantCulture), Integer=i });

            var st=source.AsQueryable<SimpleType>().Where<SimpleType>(Filter, null);

            Assert.Equal<int>(1, st.Count<SimpleType>());
            Assert.Equal<string>("10", st.First<SimpleType>().String);
        }

        public class SimpleType
        {

            public string String { get; set; }
            public int Integer { get; set; }
        }
    }
}
