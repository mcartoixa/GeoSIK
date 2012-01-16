using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter
{

    public sealed class ExpressionBuilderParameters:
        IXPathNavigable
    {

        public ExpressionBuilderParameters(ParameterExpression[] parameters, IQueryProvider queryProvider, Type elementType, IXmlNamespaceResolver namespaceResolver, bool mayRootPathBeImplied, IOperatorImplementationProvider operatorImplementationProvider, Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> navigatorCreator=null)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");
            Debug.Assert(parameters.Length>0);
            if (parameters.Length==0)
                throw new ArgumentException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.ArrayShouldHaveElementsException,
                        1,
                        parameters.Length
                    ),
                    "parameters"
                );
            Debug.Assert(queryProvider!=null);
            if (queryProvider==null)
                throw new ArgumentNullException("queryProvider");
            Debug.Assert(elementType!=null);
            if (elementType==null)
                throw new ArgumentNullException("elementType");

            Parameters=new ReadOnlyCollection<ParameterExpression>(parameters);
            ElementType=elementType;
            QueryProvider=queryProvider;
            NamespaceResolver=namespaceResolver;
            MayRootPathBeImplied=mayRootPathBeImplied;
            OperatorImplementationProvider=operatorImplementationProvider;
            NavigatorCreator=navigatorCreator;
        }

        public XPathTypeNavigator CreateNavigator()
        {
            if (NavigatorCreator!=null)
                return NavigatorCreator(ElementType, NamespaceResolver);

            return new XPathTypeNavigator(ElementType, NamespaceResolver);
        }

        XPathNavigator IXPathNavigable.CreateNavigator()
        {
            return CreateNavigator();
        }

        public ReadOnlyCollection<ParameterExpression> Parameters
        {
            get;
            private set;
        }

        public Type ElementType
        {
            get;
            private set;
        }

        public IQueryProvider QueryProvider
        {
            get;
            private set;
        }

        public IXmlNamespaceResolver NamespaceResolver
        {
            get;
            private set;
        }

        public bool MayRootPathBeImplied
        {
            get;
            private set;
        }

        public IOperatorImplementationProvider OperatorImplementationProvider
        {
            get;
            private set;
        }

        public Func<Type, IXmlNamespaceResolver, XPathTypeNavigator> NavigatorCreator
        {
            get;
            private set;
        }
    }
}
