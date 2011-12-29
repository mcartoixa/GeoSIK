﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.XPath;
using OgcToolkit.Ogc.Filter;

namespace OgcToolkit.Services.Csw.V202
{

    internal class XPathQueryableNode:
        XPathTypeNode
    {

        internal XPathQueryableNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context):
            base(node, memberInfo, parent, context)
        {
        }

        internal void InitQueryables(XPathQueryableNavigator navigator, IDictionary<string, IList<XPathNavigator>> queryables)
        {
            var subNodes=new List<XPathTypeNode>(ElementChildrenNodes);
            subNodes.AddRange(AttributeChildrenNodes);
            subNodes.AddRange(IgnoredChildrenNodes);

            foreach (XPathTypeNode xptn in subNodes)
            {
                var xpqn=xptn as XPathQueryableNode;
                if (xpqn!=null)
                    xpqn.InitQueryables(navigator, queryables);
            }

            foreach (CoreQueryable cq in AssociatedQueryables)
            {
                if (!queryables.ContainsKey(cq.Name))
                    queryables.Add(cq.Name, new List<XPathNavigator>());

                var n=(XPathQueryableNavigator)navigator.Clone();
                n.MoveTo(this);
                queryables[cq.Name].Add(n);
            }
        }

        internal CoreQueryable[] AssociatedQueryables
        {
            get
            {
                if (_AssociatedQueryables==null)
                {
                    if (MetadataMemberInfos!=null)
                    {
                        _AssociatedQueryables=MetadataMemberInfos
                            .SelectMany<MemberInfo, CoreQueryableAttribute>(m => m.GetCustomAttributes(typeof(CoreQueryableAttribute), true).Cast<CoreQueryableAttribute>())
                            .Select<CoreQueryableAttribute, CoreQueryable>(a => a.Queryable)
                            .ToArray<CoreQueryable>();
                    } else
                        _AssociatedQueryables=new CoreQueryable[0];

                }

                return _AssociatedQueryables;
            }
        }

        private CoreQueryable[] _AssociatedQueryables;
    }
}