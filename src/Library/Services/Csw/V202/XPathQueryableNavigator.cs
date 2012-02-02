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
using Filter=GeoSik.Ogc.Filter;

namespace GeoSik.Services.Csw.V202
{

    public class XPathQueryableNavigator:
        Filter.XPathTypeNavigator
    {

        public XPathQueryableNavigator(Type root):
            this(root, null)
        { }

        public XPathQueryableNavigator(Type root, IXmlNamespaceResolver namespaceResolver):
            base(root, namespaceResolver, new Filter.XPathTypeContext(XPathQueryableNodeProvider.Instance, namespaceResolver))
        {
        }

        protected XPathQueryableNavigator(XPathQueryableNavigator other):
            base(other)
        {
            _Queryables=other._Queryables;
        }

        public override XPathNavigator Clone()
        {
            var ret=new XPathQueryableNavigator(this);
            if (ret._Queryables==null)
                ret._Queryables=Queryables;
            return ret;
        }

        public override XPathNodeIterator Select(XPathExpression expr)
        {
            if (Queryables.ContainsKey(expr.Expression))
                return new XPathQueryableIterator(Queryables[expr.Expression]);

            return base.Select(expr);
        }

        protected Dictionary<string, IList<XPathNavigator>> Queryables
        {
            get
            {
                if (_Queryables==null)
                {
                    _Queryables=new Dictionary<string, IList<XPathNavigator>>();
                    foreach (Filter.XPathTypeNode xptn in Root.ElementChildrenNodes)
                    {
                        var xpqn=xptn as XPathQueryableNode;
                        if (xpqn!=null)
                            xpqn.InitQueryables(this, _Queryables);
                    }
                }

                return _Queryables;
            }
        }

        private Dictionary<string, IList<XPathNavigator>> _Queryables;
    }
}
