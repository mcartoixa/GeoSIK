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

    /// <summary>Handles a node for a <see cref="XPathTypeNavigator" /> navigator.</summary>
    internal class XPathTypeNode
    {

        /// <summary>Creates a new instance of the <see cref="XPathTypeNode" /> class that will act as a root node.</summary>
        /// <param name="root"></param>
        /// <param name="context"></param>
        internal protected XPathTypeNode(Type root, XPathTypeContext context):
            this(root, null, null, context)
        {

        }

        internal XPathTypeNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context)
        {
            Debug.Assert(context!=null);
            if (context==null)
                throw new ArgumentNullException("context");
            Debug.Assert(node!=null);
            if (node==null)
                throw new ArgumentNullException("node");

            _Node=node;
            _MemberInfo=memberInfo;
            _Parent=parent;
            _Context=context;
        }

        /// <summary>Creates an <see cref="Expression" /> from the current node and the specified <paramref name="parameter" />.</summary>
        /// <param name="parameter">A parameter that represents an instance of the root node, which is the furthest <see cref="Parent" /> from the current node.</param>
        /// <returns>The expression that gives access to the current node.</returns>
        /// <remarks>
        ///   <para></para>
        /// </remarks>
        public Expression CreateExpression(ParameterExpression parameter)
        {
            Expression prop=parameter;

            if ((_Parent!=null) && !(_Parent is XPathTypeRootNode))
                prop=_Parent.CreateExpression(parameter);

            if (_MemberInfo!=null)
                return Expression.PropertyOrField(parameter, _MemberInfo.Name);

            return prop;
        }

        private void GetChildren()
        {
            if ((_AttributesChildren==null) || (_ElementsChildren==null))
            {
                // Attributes dont't have children
                if (
                    (NodeType==XmlNodeType.Attribute) ||
                    (Type.GetTypeCode(_Node)!=TypeCode.Object)
                )
                {
                    _AttributesChildren=new XPathTypeNode[0];
                    _ElementsChildren=new XPathTypeNode[0];
                    return;
                }

                var ac=new List<XPathTypeNode>();
                var ec=new List<XPathTypeNode>();
                foreach (MemberInfo mi in _Node.GetMembers(BindingFlags.Public | BindingFlags.Instance))
                {
                    var ignore=Attribute.GetCustomAttributes(mi, typeof(XmlIgnoreAttribute), true);
                    if (ignore.Length>0)
                        continue;

                    Type type=null;
                    var pi=mi as PropertyInfo;
                    if (pi!=null)
                        type=pi.PropertyType;
                    var fi=mi as FieldInfo;
                    if (fi!=null)
                        type=fi.FieldType;

                    if (type==null)
                        continue;

                    XPathTypeNode node=new XPathTypeNode(type, mi, this, _Context);
                    switch (node.NodeType)
                    {
                    case XmlNodeType.Attribute:
                        ac.Add(node);
                        break;
                    case XmlNodeType.Element:
                        ec.Add(node);
                        break;
                    }
                }

                _AttributesChildren=ac.ToArray<XPathTypeNode>();
                _ElementsChildren=ec.ToArray<XPathTypeNode>();
            }
        }

        public virtual XPathTypeNode[] Attributes
        {
            get
            {
                GetChildren();
                return _AttributesChildren;
            }
        }

        public virtual XPathTypeNode[] Elements
        {
            get
            {
                GetChildren();
                return _ElementsChildren;
            }
        }

        public int Index
        {
            get
            {
                // TODO: optimize...
                if (_Parent==null)
                    return -1;

                switch (NodeType)
                {
                case XmlNodeType.Attribute:
                    return Array.IndexOf<XPathTypeNode>(_Parent.Attributes, this);
                case XmlNodeType.Element:
                    return Array.IndexOf<XPathTypeNode>(_Parent.Elements, this);
                }

                return -1;
            }
        }

        public Type Node
        {
            get
            {
                return _Node;
            }
        }

        public MemberInfo MemberInfo
        {
            get
            {
                return _MemberInfo;
            }
        }

        public XPathTypeNode Parent
        {
            get
            {
                return _Parent;
            }
        }

        public string LocalName
        {
            get
            {
                if (_MemberInfo!=null)
                {
                    switch (NodeType)
                    {
                    case XmlNodeType.Attribute:
                        foreach (XmlAttributeAttribute xaa in NodeAttributes)
                            if (!string.IsNullOrEmpty(xaa.AttributeName))
                                return xaa.AttributeName;
                        break;
                    case XmlNodeType.Element:
                    default:
                        foreach (XmlElementAttribute xea in NodeAttributes)
                            if (!string.IsNullOrEmpty(xea.ElementName))
                                return xea.ElementName;
                        break;
                    }

                    return _MemberInfo.Name;
                } else
                {
                    foreach (XmlRootAttribute xra in NodeAttributes)
                        if (!string.IsNullOrEmpty(xra.ElementName))
                            return xra.ElementName;

                    return _Node.Name;
                }
            }
        }

        public string Name
        {
            get
            {
                string ret=LocalName;
                string prefix=_Context.NamespaceManager.LookupPrefix(Namespace);
                if (!string.IsNullOrEmpty(prefix))
                    ret=string.Concat(prefix, ":", ret);

                return ret;
            }
        }

        public string Namespace
        {
            get
            {
                if (_MemberInfo!=null)
                {
                    switch (NodeType)
                    {
                    case XmlNodeType.Attribute:
                        foreach (XmlAttributeAttribute xaa in NodeAttributes)
                            if (!string.IsNullOrEmpty(xaa.AttributeName))
                                return xaa.Namespace;
                        break;
                    case XmlNodeType.Element:
                    default:
                        foreach (XmlElementAttribute xea in NodeAttributes)
                            if (!string.IsNullOrEmpty(xea.ElementName))
                                return xea.Namespace;
                        break;
                    }
                } else
                {
                    foreach (XmlRootAttribute xra in NodeAttributes)
                        if (!string.IsNullOrEmpty(xra.ElementName))
                            return xra.Namespace;
                }

                return string.Empty;
            }
        }

        public XmlNodeType NodeType
        {
            get
            {
                if (_MemberInfo==null)
                    return XmlNodeType.Element;

                if (NodeAttributes.Any<Attribute>(a => a is XmlAttributeAttribute))
                    return XmlNodeType.Attribute;

                return XmlNodeType.Element;
            }
        }

        /// <summary>Gets the type of the current node.</summary>
        public Type Type
        {
            get
            {
                if (_MemberInfo==null)
                    return _Node;

                var pi=_MemberInfo as PropertyInfo;
                if (pi!=null)
                    return pi.PropertyType;

                var fi=_MemberInfo as FieldInfo;
                if (fi!=null)
                    return fi.FieldType;

                throw new InvalidOperationException();
            }
        }

        protected XPathTypeContext Context
        {
            get
            {
                return _Context;
            }
        }

        private IEnumerable<Attribute> NodeAttributes
        {
            get
            {
                if (_NodeAttributes==null)
                {
                    if (_MemberInfo!=null)
                    {
                        _NodeAttributes=Attribute.GetCustomAttributes(_MemberInfo, typeof(XmlElementAttribute), true);
                        _NodeAttributes.Concat<Attribute>(Attribute.GetCustomAttributes(_MemberInfo, typeof(XmlAttributeAttribute), true));
                    } else
                        _NodeAttributes=_Node.GetCustomAttributes(typeof(XmlRootAttribute), true).Cast<Attribute>();
                }

                return _NodeAttributes;
            }
        }

        private Type _Node;
        private MemberInfo _MemberInfo;
        private XPathTypeNode _Parent;
        private XPathTypeContext _Context;

        private IEnumerable<Attribute> _NodeAttributes;
        private XPathTypeNode[] _AttributesChildren;
        private XPathTypeNode[] _ElementsChildren;
    }
}
