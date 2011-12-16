using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using OgcToolkit.Ogc.Filter;

namespace OgcToolkit.Services.Csw.V202
{

    internal class XPathQueryableNodeProvider:
        IXPathTypeNodeProvider
    {

        private XPathQueryableNodeProvider()
        {
        }

        public XPathTypeNode GetNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context)
        {
            if ((parent==null) && (memberInfo==null))
                return GetRootNode(node, context);

            return new XPathQueryableNode(node, memberInfo, parent, context);
        }

        public XPathTypeRootNode GetRootNode(Type root, XPathTypeContext context)
        {
            if (_RootNodes.ContainsKey(root))
                return (XPathTypeRootNode)_RootNodes[root].Copy(context);

            var ret=new XPathTypeRootNode(root, context);
            _RootNodes.Add(root, ret);
            return ret;
        }

        public static XPathQueryableNodeProvider Instance
        {
            get
            {
                return _Instance.Value;
            }
        }

        private Dictionary<Type, XPathTypeRootNode> _RootNodes=new Dictionary<Type, XPathTypeRootNode>();

        private static readonly Lazy<XPathQueryableNodeProvider> _Instance=new Lazy<XPathQueryableNodeProvider>(() => new XPathQueryableNodeProvider());
    }
}
