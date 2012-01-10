using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    internal class XPathTypeNode:
        ICloneable
    {

        protected XPathTypeNode()
        {
        }

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

            // Initialize optional external metadata holding types
            foreach (MetadataTypeAttribute mta in node.GetCustomAttributes(typeof(MetadataTypeAttribute), true))
                _MetadataNodes=new Type[] { node, mta.MetadataClassType };
            if (_MetadataNodes==null)
                _MetadataNodes=new Type[] { node };

            if (memberInfo!=null)
            {
                if (parent!=null)
                    _MetadataMemberInfos=parent.MetadataNodes
                        .SelectMany<Type, MemberInfo>(t => t.GetMember(memberInfo.Name, memberInfo.MemberType, BindingFlags.Instance | BindingFlags.Public))
                        .ToArray<MemberInfo>();
                else
                    _MetadataMemberInfos=new MemberInfo[] { memberInfo };
            }
        }

        /// <summary>Creates an <see cref="Expression" /> from the current node and the specified <paramref name="parameter" />.</summary>
        /// <param name="parameter">A parameter that represents an instance of the root node, which is the furthest <see cref="Parent" /> from the current node.</param>
        /// <returns>The expression that gives access to the current node.</returns>
        /// <remarks>
        ///   <para></para>
        /// </remarks>
        public Expression CreateExpression(ParameterExpression parameter, Type expectedType=null)
        {
            Expression ret=CreateExpressionBase(parameter);

            GetChildren();
            if (_ValueMemberInfo!=null)
                ret=Expression.PropertyOrField(ret, _ValueMemberInfo.Name);

            var mex=(MemberExpression)ret;
            Type exType=GetMemberType(mex.Member);

            // Find synonyms
            if ((expectedType!=null) && (exType!=expectedType) && (_Parent!=null))
            {
                IEnumerable<XPathTypeNode> xptnc=_Parent.IgnoredChildrenNodes.Where<XPathTypeNode>(n => (n.MemberInfo!=null) && (GetMemberType(n.MemberInfo)==expectedType) && (n.LocalName==LocalName) && (n.Namespace==Namespace));
                foreach (XPathTypeNode xptn in xptnc)
                {
                    ret=Expression.PropertyOrField(mex.Expression, xptn.MemberInfo.Name);
                    break;
                }
            }

            return ret;
        }

        public object GetValue(object instance)
        {
            object ret=GetValueBase(instance);

            GetChildren();
            if ((ret!=null) && (_ValueMemberInfo!=null))
                ret=GetMemberValue(ret, _ValueMemberInfo);

            return ret;
        }

        protected virtual Expression CreateExpressionBase(ParameterExpression parameter)
        {
            Expression prop=parameter;

            if ((_Parent!=null) && !(_Parent is XPathTypeRootNode))
                prop=_Parent.CreateExpressionBase(parameter);

            if (_MemberInfo!=null)
                return Expression.PropertyOrField(prop, _MemberInfo.Name);

            return prop;
        }

        protected virtual object GetValueBase(object instance)
        {
            object ret=instance;

            if ((_Parent!=null) && !(_Parent is XPathTypeRootNode))
                ret=_Parent.GetValueBase(instance);

            if (_MemberInfo!=null)
                ret=GetMemberValue(ret, _MemberInfo);

            return ret;
        }

        public virtual XPathTypeNode Clone()
        {
            var ret=new XPathTypeNode();

            ret._AttributeChildrenNodes=AttributeChildrenNodes;
            ret._Context=_Context;
            ret._ElementChildrenNodes=ElementChildrenNodes;
            ret._IgnoredChildrenNodes=IgnoredChildrenNodes;
            ret._MemberInfo=_MemberInfo;
            ret._MetadataMemberInfos=_MetadataMemberInfos;
            ret._MetadataNodes=_MetadataNodes;
            ret._Node=_Node;
            ret._NodeAttributes=NodeAttributes.ToList<Attribute>();
            ret._Parent=_Parent;
            ret._ValueMemberInfo=ValueMemberInfo;

            return ret;
        }

        public XPathTypeNode Copy(XPathTypeContext context)
        {
            XPathTypeNode ret=Clone();
            ret._Context=context;
            return ret;
        }

        protected virtual void GetChildren()
        {
            if ((_AttributeChildrenNodes==null) || (_ElementChildrenNodes==null) || (_IgnoredChildrenNodes==null))
            {
                // Attributes and simple types dont't have children nodes
                if (
                    (NodeType==XmlNodeType.Attribute) ||
                    (Type.GetTypeCode(_Node)!=TypeCode.Object)
                )
                {
                    _AttributeChildrenNodes=new XPathTypeNode[0];
                    _ElementChildrenNodes=new XPathTypeNode[0];
                    _IgnoredChildrenNodes=new XPathTypeNode[0];
                    return;
                }

                var ac=new List<XPathTypeNode>();
                var ec=new List<XPathTypeNode>();
                var ic=new List<XPathTypeNode>();

                foreach (MemberInfo mi in _Node.GetMembers(BindingFlags.Instance | BindingFlags.Public))
                {
                    Type type=GetMemberType(mi);
                    if (type==null)
                        continue;

                    XPathTypeNode node=_Context.NodeProvider.GetNode(type, mi, this, _Context);

                    // XmlIgnore ?
                    if (node.NodeAttributes.Any<Attribute>(a => a is XmlIgnoreAttribute))
                    {
                        ic.Add(node);
                        continue;
                    }

                    // XmlText ?
                    if (node.NodeAttributes.Any<Attribute>(a => a is XmlTextAttribute))
                    {
                        _ValueMemberInfo=mi;
                        continue;
                    }

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

                _AttributeChildrenNodes=ac.ToArray<XPathTypeNode>();
                _ElementChildrenNodes=ec.OrderBy<XPathTypeNode, int>(n => n.Order).ToArray<XPathTypeNode>();
                _IgnoredChildrenNodes=ic.ToArray<XPathTypeNode>();
            }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        private static Type GetMemberType(MemberInfo member)
        {
            Type ret=null;

            var pi=member as PropertyInfo;
            if (pi!=null)
                ret=pi.PropertyType;
            var fi=member as FieldInfo;
            if (fi!=null)
                ret=fi.FieldType;

            return ret;
        }

        private static object GetMemberValue(object instance, MemberInfo member)
        {
            object ret=null;

            var pi=member as PropertyInfo;
            if (pi!=null)
                ret=pi.GetValue(instance, null);

            var fi=member as FieldInfo;
            if (fi!=null)
                ret=fi.GetValue(instance);

            return ret;
        }

        public virtual XPathTypeNode[] AttributeChildrenNodes
        {
            get
            {
                GetChildren();
                return _AttributeChildrenNodes;
            }
        }

        public virtual XPathTypeNode[] ElementChildrenNodes
        {
            get
            {
                GetChildren();
                return _ElementChildrenNodes;
            }
        }

        public virtual XPathTypeNode[] IgnoredChildrenNodes
        {
            get
            {
                GetChildren();
                return _IgnoredChildrenNodes;
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
                    return Array.IndexOf<XPathTypeNode>(_Parent.AttributeChildrenNodes, this);
                case XmlNodeType.Element:
                    return Array.IndexOf<XPathTypeNode>(_Parent.ElementChildrenNodes, this);
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

        public MemberInfo ValueMemberInfo
        {
            get
            {
                GetChildren();
                return _ValueMemberInfo;
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
                StringBuilder ret=new StringBuilder(LocalName);
                string prefix=_Context.NamespaceResolver.LookupPrefix(Namespace);
                if (!string.IsNullOrEmpty(prefix))
                    ret.Insert(0, string.Concat(prefix, ":"));

                return ret.ToString();
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
                                return xaa.Namespace ?? string.Empty;
                        break;
                    case XmlNodeType.Element:
                    default:
                        foreach (XmlElementAttribute xea in NodeAttributes)
                            if (!string.IsNullOrEmpty(xea.ElementName))
                                return xea.Namespace ?? string.Empty;
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
                if (_MetadataMemberInfos==null)
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
                if (_ValueMemberInfo!=null)
                    return GetMemberType(_ValueMemberInfo);

                if (_MemberInfo==null)
                    return _Node;

                return GetMemberType(_MemberInfo);

                throw new InvalidOperationException();
            }
        }

        public MemberInfo Value
        {
            get
            {
                return _MemberInfo;
            }
        }

        protected XPathTypeContext Context
        {
            get
            {
                return _Context;
            }
        }

        protected int Order
        {
            get
            {
                int ret=NodeAttributes.OfType<XmlElementAttribute>().Select<XmlElementAttribute, int>(a => a.Order).DefaultIfEmpty<int>(-1).Max();
                if (ret<0)
                    return int.MaxValue;
                return ret;
            }
        }

        public IEnumerable<MemberInfo> MetadataMemberInfos
        {
            get
            {
                return _MetadataMemberInfos;
            }
        }

        protected IEnumerable<Type> MetadataNodes
        {
            get
            {
                return _MetadataNodes;
            }
        }

        internal virtual IEnumerable<Attribute> NodeAttributes
        {
            get
            {
                if (_NodeAttributes==null)
                {
                    if (MetadataMemberInfos!=null)
                    {
                        _NodeAttributes=new List<Attribute>(MetadataMemberInfos.SelectMany<MemberInfo, Attribute>(m => m.GetCustomAttributes(typeof(XmlRootAttribute), true).Cast<Attribute>()));
                        _NodeAttributes.AddRange(MetadataMemberInfos.SelectMany<MemberInfo, Attribute>(m => m.GetCustomAttributes(typeof(XmlElementAttribute), true).Cast<Attribute>()));
                        _NodeAttributes.AddRange(MetadataMemberInfos.SelectMany<MemberInfo, Attribute>(m => m.GetCustomAttributes(typeof(XmlAttributeAttribute), true).Cast<Attribute>()));
                        _NodeAttributes.AddRange(MetadataMemberInfos.SelectMany<MemberInfo, Attribute>(m => m.GetCustomAttributes(typeof(XmlTextAttribute), true).Cast<Attribute>()));
                    } else
                        _NodeAttributes=MetadataNodes
                            .SelectMany<Type, Attribute>(t => t.GetCustomAttributes(typeof(XmlRootAttribute), true).Cast<Attribute>())
                            .ToList<Attribute>();
                }

                return _NodeAttributes;
            }
        }

        private Type _Node;
        private IEnumerable<Type> _MetadataNodes;
        private MemberInfo _MemberInfo;
        private IEnumerable<MemberInfo> _MetadataMemberInfos;
        private MemberInfo _ValueMemberInfo;
        private XPathTypeNode _Parent;
        private XPathTypeContext _Context;

        private List<Attribute> _NodeAttributes;
        private XPathTypeNode[] _AttributeChildrenNodes;
        private XPathTypeNode[] _ElementChildrenNodes;
        private XPathTypeNode[] _IgnoredChildrenNodes;
    }
}
