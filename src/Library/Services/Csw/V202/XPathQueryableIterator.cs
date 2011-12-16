using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace OgcToolkit.Services.Csw.V202
{

    internal class XPathQueryableIterator:
        XPathNodeIterator
    {

        public XPathQueryableIterator(IList<XPathNavigator> nodes)
        {
            Debug.Assert(nodes!=null);
            if (nodes==null)
                throw new ArgumentNullException("nodes");

            Nodes=nodes;
        }

        public override XPathNodeIterator Clone()
        {
            var ret=new XPathQueryableIterator(Nodes);
            ret._Index=_Index;
            return ret;
        }

        public override XPathNavigator Current
        {
            get { return Nodes[_Index-1]; }
        }

        public override int CurrentPosition
        {
            get { return _Index; }
        }

        public override bool MoveNext()
        {
            if (_Index>=Nodes.Count)
                return false;

            _Index++;
            return true;
        }

        internal IList<XPathNavigator> Nodes
        {
            get;
            private set;
        }

        private int _Index;
    }
}
