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

        internal static Filter CreateFilter(string constraint)
        {
            var namespaceManager=new XmlNamespaceManager(new NameTable());
            namespaceManager.AddNamespace(string.Empty, "http://www.opengis.net/ogc");
            namespaceManager.AddNamespace("ogc", "http://www.opengis.net/ogc");

            var ret=new Filter();
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"ogc", "http://www.opengis.net/ogc")
            );
            XmlParserContext context=new XmlParserContext(null, namespaceManager, null, XmlSpace.None);
            using (var r=new XmlTextReader(constraint, XmlNodeType.Element, context))
            {
                var c=XElement.Load(r);
                ret.Untyped.AddFirst(c);
            }

            return ret;
        }

        internal static IEnumerable<SimpleType> CreateCollection(int number)
        {
            var ret=new List<SimpleType>(number);
            for (int i=0; i<number; ++i)
                ret.Add(new SimpleType() { String=i.ToString(CultureInfo.InvariantCulture), Integer=i });
            return ret;
        }

        public class SimpleType
        {

            public string String { get; set; }
            public int Integer { get; set; }
        }
    }
}
