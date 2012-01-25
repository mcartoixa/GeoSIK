using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OgcToolkit.Ogc.Filter
{

    internal class XPathTypeNodeProvider:
        IXPathTypeNodeProvider
    {

        private XPathTypeNodeProvider()
        {
        }

        public XPathTypeNode GetNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context)
        {
            if ((parent==null) && (memberInfo==null))
                return GetRootNode(node, context);

            if (node!=typeof(string)) // string implements IEnumerable<char>
            {
                Type entype=node.GetInterface("IEnumerable`1");
                if (entype!=null)
                {
                    Debug.Assert(entype.IsGenericType);

                    Type[] intypes=entype.GetGenericArguments();
                    Debug.Assert(intypes.Length==1);

                    return new XPathTypeEnumerableNode(intypes[0], memberInfo, parent, context);
                }
            }

            return new XPathTypeNode(node, memberInfo, parent, context);
        }

        public XPathTypeRootNode GetRootNode(Type root, XPathTypeContext context)
        {
            if (_RootNodes.ContainsKey(root))
                return (XPathTypeRootNode)_RootNodes[root].Copy(context);

            var ret=new XPathTypeRootNode(root, context);
            _RootNodes.Add(root, ret);
            return ret;
        }

        public static XPathTypeNodeProvider Instance
        {
            get
            {
                return _Instance.Value;
            }
        }

        private Dictionary<Type, XPathTypeRootNode> _RootNodes=new Dictionary<Type, XPathTypeRootNode>();

        private static readonly Lazy<XPathTypeNodeProvider> _Instance=new Lazy<XPathTypeNodeProvider>(() => new XPathTypeNodeProvider());
    }
}
