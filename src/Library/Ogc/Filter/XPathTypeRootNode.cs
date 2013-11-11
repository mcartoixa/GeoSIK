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
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace GeoSik.Ogc.Filter
{
    internal class XPathTypeRootNode:
        XPathTypeNode
    {

        protected XPathTypeRootNode()
        {
        }

        /// <summary>Creates a new instance of the <see cref="XPathTypeRootNode" /> class that will act as a root node.</summary>
        /// <param name="root"></param>
        /// <param name="context"></param>
        internal protected XPathTypeRootNode(Type root, XPathTypeContext context):
            base(root, context)
        {
            _ElementChildrenNodes=new XPathTypeNode[] { context.NodeProvider.GetNode(Node, null, this, Context) };
        }

        public override XPathTypeNode Clone()
        {
            XPathTypeRootNode ret=new XPathTypeRootNode();

            ret._ElementChildrenNodes=ElementChildrenNodes;

            return ret;
        }

        protected override void GetChildren()
        {
            // Do nothing
        }

        public override XPathTypeNode[] AttributeChildrenNodes
        {
            get
            {
                return _AttributeChildrenNodes;
            }
        }

        public override XPathTypeNode[] ElementChildrenNodes
        {
            get
            {
                return _ElementChildrenNodes;
            }
        }

        public override XPathTypeNode[] IgnoredChildrenNodes
        {
            get
            {
                return _IgnoredChildrenNodes;
            }
        }

        private static XPathTypeNode[] _AttributeChildrenNodes=new XPathTypeNode[0];
        private static XPathTypeNode[] _IgnoredChildrenNodes=new XPathTypeNode[0];

        private XPathTypeNode[] _ElementChildrenNodes;
    }
}
