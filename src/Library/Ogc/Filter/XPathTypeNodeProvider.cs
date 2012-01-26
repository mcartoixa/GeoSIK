////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

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
