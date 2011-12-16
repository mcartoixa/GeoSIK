using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Filter=OgcToolkit.Ogc.Filter;

namespace OgcToolkit.Services.Csw.V202
{

    public class XPathQueryableNavigator:
        Filter.XPathTypeNavigator
    {

        public XPathQueryableNavigator(Type root):
            base(root)
        {}

        public XPathQueryableNavigator(Type root, IXmlNamespaceResolver namespaceResolver):
            base(root, namespaceResolver)
        {}

        public override XPathNodeIterator Select(XPathExpression expr)
        {
            if (_Queryables.ContainsKey(expr.Expression))
                return _Queryables[expr.Expression];

            return Select(expr);
        }

        private Dictionary<string, XPathNodeIterator> _Queryables=new Dictionary<string, XPathNodeIterator>();
    }
}
