using System;
using System.Collections.Generic;
using System.Diagnostics;
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
