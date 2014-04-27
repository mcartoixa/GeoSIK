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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace GeoSik.Ogc.Filter
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
