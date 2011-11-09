using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;
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

        public XPathTypeNavigator(Type root, XmlNamespaceManager namespaceManager)
        {
            Debug.Assert(root!=null);
            if (root==null)
                throw new ArgumentNullException("root");

            _Context=new XPathTypeContext(namespaceManager);
            _Root=new XPathTypeNode(root, _Context);
            _Current=_Root;
        }

        private XPathTypeNavigator(XPathTypeNavigator other)
        {
            _Context=other._Context;
            _Root=other._Root;
            _Current=other._Current;
        }

        public override XPathNavigator Clone()
        {
            return new XPathTypeNavigator(this);
        }

        public Expression CreateExpression(ParameterExpression parameter)
        {
            return _Current.CreateExpression(parameter);
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

        public override bool MoveToFirstAttribute()
        {
            if ((NodeType!=XPathNodeType.Root) && (NodeType!=XPathNodeType.Element))
                return false;

            XPathTypeNode[] attributes=_Current.Attributes;
            if (attributes.Length<1)
                return false;

            _Current=attributes[0];
            return true;
        }

        public override bool MoveToFirstChild()
        {
            if ((NodeType!=XPathNodeType.Root) && (NodeType!=XPathNodeType.Element))
                return false;

            XPathTypeNode[] elements=_Current.Elements;
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

            XPathTypeNode[] elements=_Current.Elements;
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

            XPathTypeNode[] attributes=_Current.Attributes;
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

            XPathTypeNode[] elements=_Current.Elements;
            if (--index<0)
                return false;

            _Current=elements[index];
            return true;
        }

        public override string BaseURI
        {
            get { return string.Empty; }
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
                return _Context.NamespaceManager.NameTable;
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
                return _Context.NamespaceManager.LookupPrefix(NamespaceURI);
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

        private XPathTypeNode _Root;
        private XPathTypeNode _Current;
        private XPathTypeContext _Context;

    }
}
