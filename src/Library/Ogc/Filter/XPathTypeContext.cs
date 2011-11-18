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

        public XPathTypeContext(XmlNamespaceManager namespaceManager)
        {
            _NamespaceManager=namespaceManager;
        }

        public XmlNamespaceManager NamespaceManager
        {
            get
            {
                if (_NamespaceManager==null)
                    _NamespaceManager=new XmlNamespaceManager(new NameTable());

                return _NamespaceManager;
            }
        }

        private XmlNamespaceManager _NamespaceManager;
    }
}
