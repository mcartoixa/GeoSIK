using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyName
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return GetNavigator(parameters.ElementType, parameters.NamespaceManager, parameters.MayRootPathBeImplied)
                .CreateExpression(parameters.Parameters[0], expectedStaticType);
        }

        protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetNavigator(parameters.ElementType, parameters.NamespaceManager, parameters.MayRootPathBeImplied).Type;
        }

        protected XPathTypeNavigator GetNavigator(Type elementType, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied)
        {
            if (_Navigator==null)
            {
                XPathTypeNavigator xptn=new XPathTypeNavigator(elementType, namespaceManager);
                XPathNodeIterator xpni=xptn.Select(Untyped.Value, namespaceManager, true);
                while (xpni.MoveNext())
                    _Navigator=xpni.Current as XPathTypeNavigator;

                Debug.Assert(_Navigator!=null);
                if (_Navigator==null)
                    throw new InvalidOperationException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.InvalidPropertyNameExpressionException,
                            Untyped.Value
                        )
                    );
            }

            return _Navigator;
        }

        private XPathTypeNavigator _Navigator;
    }
#pragma warning restore 3009
}
