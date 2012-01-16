using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter
{

    internal class XPathTypeContext
    {

        public XPathTypeContext(IXPathTypeNodeProvider nodeProvider)
        {
            Debug.Assert(nodeProvider!=null);

            NodeProvider=nodeProvider;
        }

        public XPathTypeContext(IXPathTypeNodeProvider typeNodeProvider, IXmlNamespaceResolver namespaceResolver):
            this(typeNodeProvider)
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

        internal IXPathTypeNodeProvider NodeProvider
        {
            get;
            private set;
        }

        private IXmlNamespaceResolver _NamespaceResolver;
    }
}
