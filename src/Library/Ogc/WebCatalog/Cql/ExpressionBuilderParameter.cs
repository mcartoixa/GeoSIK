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

namespace OgcToolkit.Ogc.WebCatalog.Cql
{

    public sealed class ExpressionBuilderParameters
    {

        public ExpressionBuilderParameters(ParameterExpression[] parameters, IQueryProvider queryProvider, Type elementType, IXmlNamespaceResolver namespaceResolver, bool mayRootPathBeImplied, IOperatorImplementationProvider operatorImplementationProvider)
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
    }
}
