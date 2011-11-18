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

        /// <summary>Creates a new instance of the <see cref="XPathTypeRootNode" /> class that will act as a root node.</summary>
        /// <param name="root"></param>
        /// <param name="context"></param>
        internal protected XPathTypeRootNode(Type root, XPathTypeContext context):
            base(root, context)
        {
            _Elements=new XPathTypeNode[] { new XPathTypeNode(Node, null, this, Context) };
        }

        public override XPathTypeNode[] Attributes
        {
            get
            {
                return _Attributes;
            }
        }

        public override XPathTypeNode[] Elements
        {
            get
            {
                return _Elements;
            }
        }

        private static XPathTypeNode[] _Attributes=new XPathTypeNode[0];

        private XPathTypeNode[] _Elements;
    }
}
