using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using Common.Logging;
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
            ParseTree tree=parser.Parse(constraint);

            if (tree.ParserMessages.Count>0)
            {
                var logger=LogManager.GetCurrentClassLogger();
                var exl=new List<Exception>();

                foreach (ParserMessage pm in tree.ParserMessages)
                    switch (pm.Level)
                    {
                    case ParserErrorLevel.Error:
                        logger.Error(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", pm.Location.Line, pm.Location.Column, pm.Message));
                        exl.Add(
                            new ArgumentException(
                                string.Format(
                                    parser.Context.Culture,
                                    "({0},{1}): {2}: {3}",
                                    pm.Location.Line,
                                    pm.Location.Column,
                                    pm.Level,
                                    pm.Message
                                ),
                                "constraint"
                            )
                        );
                        break;
                    case ParserErrorLevel.Info:
                        logger.Info(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", pm.Location.Line, pm.Location.Column, pm.Message));
                        break;
                    default:
                        logger.Warn(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", pm.Location.Line, pm.Location.Column, pm.Message));
                        break;
                    }

                if (exl.Count>0)
                    throw new AggregateException(exl);
            }

            var parameters=new ParameterExpression[] {
                Expression.Parameter(source.ElementType)
            };
            var ebp=new ExpressionBuilderParameters(parameters, source.Provider, source.ElementType, namespaceManager, mayRootPathBeImplied, operatorImplementationProvider);

            LambdaExpression lambda=Expression.Lambda(((Ast.IExpressionBuilder)tree.Root.AstNode).CreateExpression(ebp, typeof(bool), null), parameters);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    "Where",
                    new Type[] { source.ElementType },
                    source.Expression,
                    Expression.Quote(lambda)
                )
            );
        }


        private static LanguageData LanguageData
        {
            get
            {
                if (_LanguageData==null)
                {
                    _LanguageData=new LanguageData(new CqlGrammar());

                    if (_LanguageData.Errors.Count>0)
                    {
                        var logger=LogManager.GetCurrentClassLogger();
                        foreach (GrammarError ge in _LanguageData.Errors)
                            switch (ge.Level)
                            {
                            case GrammarErrorLevel.InternalError:
                            case GrammarErrorLevel.Error:
                                logger.Error(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            case GrammarErrorLevel.Info:
                                logger.Info(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            case GrammarErrorLevel.NoError:
                                logger.Trace(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            default:
                                logger.Warn(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            }
                    }
                }

                return _LanguageData;
            }
        }

        private static LanguageData _LanguageData;
    }
}
