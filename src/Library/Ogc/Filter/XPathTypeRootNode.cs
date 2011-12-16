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

namespace OgcToolkit.Ogc.Filter
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
