using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter
{

    internal class XPathTypeContext
    {

        public XPathTypeContext()
        {
        }

        public XPathTypeContext(IXmlNamespaceResolver namespaceResolver)
        {
            _NamespaceResolver=namespaceResolver;
        }

        public IXmlNamespaceResolver NamespaceResolver
        {
            get
            {
                if (_NamespaceResolver==null)
                    _NamespaceResolver=new XmlNamespaceManager(new NameTable());

                return _NamespaceResolver;
            }
        }

        private IXmlNamespaceResolver _NamespaceResolver;
    }
}
