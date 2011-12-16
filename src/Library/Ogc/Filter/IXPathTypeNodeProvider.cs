using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OgcToolkit.Ogc.Filter
{

    internal interface IXPathTypeNodeProvider
    {

        XPathTypeRootNode GetRootNode(Type root, XPathTypeContext context);
        XPathTypeNode GetNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context);
    }
}
