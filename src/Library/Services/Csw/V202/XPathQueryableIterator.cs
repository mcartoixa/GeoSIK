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
using System.Xml.XPath;

namespace GeoSik.Services.Csw.V202
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
