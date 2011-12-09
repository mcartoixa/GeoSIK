using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

    public interface IExpressionBuilder
    {

        Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType);
        Type GetExpressionStaticType(ExpressionBuilderParameters parameters);
    }

    public class ExpressionBuilderParameters
    {

        public ExpressionBuilderParameters(ParameterExpression[] parameters, IQueryProvider queryProvider, Type elementType, XmlNamespaceManager namespaceManager, bool mayRootPathBeImplied, IOperatorImplementationProvider operatorImplementationProvider)
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

            Parameters=parameters;
            ElementType=elementType;
            QueryProvider=queryProvider;
            NamespaceManager=namespaceManager;
            MayRootPathBeImplied=mayRootPathBeImplied;
            OperatorImplementationProvider=operatorImplementationProvider;
        }

        public ParameterExpression[] Parameters
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

        public XmlNamespaceManager NamespaceManager
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
