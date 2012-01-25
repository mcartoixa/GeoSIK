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

        internal protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            // We only want literals in this case
            if (operatorCreator==null)
                return null;

            return GetNavigator(parameters)
                .CreateExpression(parameters.Parameters[0], expectedStaticType, operatorCreator);
        }

        internal protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetNavigator(parameters).Type;
        }

        private XPathTypeNavigator GetNavigator(ExpressionBuilderParameters parameters)
        {
            if (_Navigator==null)
            {
                XPathTypeNavigator xptn=parameters.CreateNavigator();
                XPathNodeIterator xpni=xptn.Select(Untyped.Value, parameters.NamespaceResolver, true);
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
