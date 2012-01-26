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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter
{

    public class XPathTypeNavigator:
        XPathNavigator
    {

        public XPathTypeNavigator(Type root):
            this(root, null)
        {
        }

        public XPathTypeNavigator(Type root, IXmlNamespaceResolver namespaceResolver):
            this(root, namespaceResolver, null)
        {
        }

        internal XPathTypeNavigator(Type root, IXmlNamespaceResolver namespaceResolver, XPathTypeContext context)
        {
            Debug.Assert(root!=null);
            if (root==null)
                throw new ArgumentNullException("root");

            _Context=context ?? new XPathTypeContext(XPathTypeNodeProvider.Instance, namespaceResolver);
            _Root=_Context.NodeProvider.GetRootNode(root, _Context);
            _Current=_Root;
        }

        protected XPathTypeNavigator(XPathTypeNavigator other)
        {
            _Context=other._Context;
            _Root=other._Root;
            _Current=other._Current;
        }

        public override XPathNavigator Clone()
        {
            return new XPathTypeNavigator(this);
        }

        public Expression CreateExpression(ParameterExpression parameter, Type expectedType=null, Func<Expression, Expression> expressionCreator=null)
        {
            return _Current.CreateExpression(parameter, expectedType, expressionCreator);
        }

        public override bool IsSamePosition(XPathNavigator other)
        {
            var xptn=other as XPathTypeNavigator;
            if (other==null)
                return false;

            return ((_Root==xptn._Root) && (_Current==xptn._Current));
        }

        public override bool MoveTo(XPathNavigator other)
        {
            var xptn=other as XPathTypeNavigator;
            if ((other==null) || (_Root!=xptn._Root))
                return false;

            _Current=xptn._Current;
            return true;
        }

        internal void MoveTo(XPathTypeNode node)
        {
            _Current=node;
        }

        public override bool MoveToFirstAttribute()
        {
            if ((NodeType!=XPathNodeType.Root) && (NodeType!=XPathNodeType.Element))
                return false;

            XPathTypeNode[] attributes=_Current.AttributeChildrenNodes;
            if (attributes.Length<1)
                return false;

            _Current=attributes[0];
            return true;
        }

        public override bool MoveToFirstChild()
        {
            if ((NodeType!=XPathNodeType.Root) && (NodeType!=XPathNodeType.Element))
                return false;

            XPathTypeNode[] elements=_Current.ElementChildrenNodes;
            if (elements.Length<1)
                return false;

            _Current=elements[0];
            return true;
        }

        public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
        {
            return false;
        }

        public override bool MoveToId(string id)
        {
            return false;
        }

        public override bool MoveToNext()
        {
            if (NodeType!=XPathNodeType.Element)
                return false;

            int index=_Current.Index;
            if (index<0)
                return false;

            if (_Current.Parent==null)
                return false;

            XPathTypeNode[] elements=_Current.Parent.ElementChildrenNodes;
            if (++index>=elements.Length)
                return false;

            _Current=elements[index];
            return true;
        }

        public override bool MoveToNextAttribute()
        {
            if (NodeType!=XPathNodeType.Attribute)
                return false;

            int index=_Current.Index;
            if (index<0)
                return false;

            if (_Current.Parent==null)
                return false;

            XPathTypeNode[] attributes=_Current.Parent.AttributeChildrenNodes;
            if (++index>=attributes.Length)
                return false;

            _Current=attributes[index];
            return true;
        }

        public override bool MoveToNextNamespace(XPathNamespaceScope namespaceScope)
        {
            return false;
        }

        public override bool MoveToParent()
        {
            if (_Current.Parent==null)
                return false;

            _Current=_Current.Parent;
            return true;
        }

        public override bool MoveToPrevious()
        {
            if (NodeType!=XPathNodeType.Element)
                return false;

            int index=_Current.Index;
            if (index<0)
                return false;

            if (_Current.Parent==null)
                return false;

            XPathTypeNode[] elements=_Current.Parent.ElementChildrenNodes;
            if (--index<0)
                return false;

            _Current=elements[index];
            return true;
        }

        public override void MoveToRoot()
        {
            _Current=_Root;
        }

        public override XPathNodeIterator Select(string xpath)
        {
            return Select(XPathExpression.Compile(xpath, _Context.NamespaceResolver));
        }

        public virtual XPathNodeIterator Select(string xpath, bool mayRootPathBeImplied)
        {
            return Select(XPathExpression.Compile(xpath), mayRootPathBeImplied);
        }

        public virtual XPathNodeIterator Select(string xpath, IXmlNamespaceResolver resolver, bool mayRootPathBeImplied)
        {
            return Select(XPathExpression.Compile(xpath, resolver), mayRootPathBeImplied);
        }

        public virtual XPathNodeIterator Select(XPathExpression expr, bool mayRootPathBeImplied)
        {
            // [OCG 07-006r1 §10.8.4.11]
            if (mayRootPathBeImplied && !expr.Expression.StartsWith("//", StringComparison.OrdinalIgnoreCase))
            {
                var xptn=Clone();
                var ex=expr;
                if (ex.Expression.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                {
                    ex=Compile(ex.Expression.Substring(1));
                    ex.SetContext(_Context.NamespaceResolver);
                }
                xptn.MoveToRoot();
                xptn.MoveToFirstChild();
                var xpni=xptn.Select(ex);
                if (xpni.Count>0)
                    return xpni;
            }

            return base.Select(expr);
        }

        public object GetValue(object instance)
        {
            return _Current.GetValue(instance);
        }

        public override string BaseURI
        {
            get
            {
                return string.Empty;
            }
        }

        public override bool HasAttributes
        {
            get
            {
                return _Current.AttributeChildrenNodes.Length>0;
            }
        }

        public override bool HasChildren
        {
            get
            {
                return _Current.ElementChildrenNodes.Length>0;
            }
        }

        public bool IsList
        {
            get
            {
                return _Current is XPathTypeEnumerableNode;
            }
        }

        public override bool IsEmptyElement
        {
            get
            {
                return false;
            }
        }

        public override string LocalName
        {
            get
            {
                return _Current.LocalName;
            }
        }

        public override string Name
        {
            get
            {
                return _Current.Name;
            }
        }

        public override XmlNameTable NameTable
        {
            get
            {
                var xnp=_Context.NamespaceResolver as XmlNamespaceManager;
                if (xnp!=null)
                    return xnp.NameTable;

                return null;
            }
        }

        public override string NamespaceURI
        {
            get
            {
                return _Current.Namespace;
            }
        }

        public override XPathNodeType NodeType
        {
            get
            {
                if (_Current==_Root)
                    return XPathNodeType.Root;

                switch (_Current.NodeType)
                {
                case XmlNodeType.Attribute:
                    return XPathNodeType.Attribute;
                case XmlNodeType.Element:
                    return XPathNodeType.Element;
                }

                throw new InvalidOperationException("Invalid node type encountered");
            }
        }

        public override string Prefix
        {
            get
            {
                return _Context.NamespaceResolver.LookupPrefix(NamespaceURI);
            }
        }

        public Type Type
        {
            get
            {
                return _Current.Type;
            }
        }

        public override string Value
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        internal XPathTypeNode Root
        {
            get
            {
                return _Root;
            }
        }

        private XPathTypeNode _Root;
        private XPathTypeNode _Current;
        private XPathTypeContext _Context;
    }
}
