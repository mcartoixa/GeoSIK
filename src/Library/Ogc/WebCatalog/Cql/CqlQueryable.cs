using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql
{

    public static class CqlQueryable
    {

        public static IQueryable<T> Where<T>(this IQueryable<T> source, string constraint, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null)
        {
            return (IQueryable<T>)Where((IQueryable)source, constraint, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);
        }

        public static IQueryable Where(this IQueryable source, string constraint, XmlNamespaceManager namespaceManager=null, bool mayRootPathBeImplied=false, IOperatorImplementationProvider operatorImplementationProvider=null)
        {
            Debug.Assert(source!=null);
            if (source==null)
                throw new ArgumentNullException("source");
            Debug.Assert(!string.IsNullOrEmpty(constraint));
            if (constraint==null)
                throw new ArgumentNullException("constraint");

            var parser=new Parser(LanguageData);
            parser.Parse(constraint);

            //LambdaExpression lambda=filter.CreateLambda(source, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);
            //return source.Provider.CreateQuery(
            //    Expression.Call(
            //        typeof(Queryable),
            //        "Where",
            //        new Type[] { source.ElementType },
            //        source.Expression,
            //        Expression.Quote(lambda)
            //    )
            //);
            throw new NotImplementedException();
        }

        private static LanguageData LanguageData
        {
            get
            {
                if (_LanguageData==null)
                    _LanguageData=new LanguageData(new CqlGrammar());
                return _LanguageData;
            }
        }

        private static LanguageData _LanguageData;
    }
}
