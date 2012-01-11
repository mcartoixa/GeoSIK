using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsLike
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Debug.Assert(PropertyName!=null);
            Debug.Assert(Literal!=null);
            Debug.Assert((escapeChar==null) || (escapeChar.Length<=1));

            char? ec=(!string.IsNullOrEmpty(escapeChar) ? (char?)escapeChar[0] : null);
            string pattern=TranslateToSqlLikePattern(Literal.Untyped.Value, wildCard, singleChar, ec);

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                Type[] arguments=new Type[] { typeof(string), typeof(string), typeof(char?), typeof(bool?) };
                object[] pa=new object[] { null, pattern, ec, matchCase };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Like, ref arguments, ref pa, out instance);

                if (method!=null)
                {
                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, expectedStaticType),
                            Expression.Constant(pa[1], arguments[1]),
                            Expression.Constant(pa[2], arguments[2]),
                            Expression.Constant(pa[3], arguments[3])
                        );
                    else
                        op=Expression.Call(
                            method,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, expectedStaticType),
                            Expression.Constant(pa[1], arguments[1]),
                            Expression.Constant(pa[2], arguments[2]),
                            Expression.Constant(pa[3], arguments[3])
                        );

                    Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    if (method.ReturnType==typeof(bool))
                        return op;
                    else
                        return Expression.Equal(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                }
            }

            // LINQ to SQL. Case sensitivity depends on database configuration
            if (parameters.QueryProvider is ITable)
            {
                if (ec.HasValue)
                {
                    return Expression.Call(
                        typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string), typeof(char) }),
                        ((IExpressionBuilder)PropertyName).CreateExpression(parameters, expectedStaticType),
                        Expression.Constant(pattern),
                        Expression.Constant(ec.Value, typeof(char))
                    );
                } else
                    return Expression.Call(
                        typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string) }),
                        ((IExpressionBuilder)PropertyName).CreateExpression(parameters, expectedStaticType),
                        Expression.Constant(pattern)
                    );
            }

            throw new NotImplementedException();
        }

        internal static string TranslateToSqlLikePattern(string input, string wildCard, string singleChar, char? escapeChar)
        {
            if ((wildCard=="%") && (singleChar=="_"))
                return input;

            if (escapeChar.HasValue)
            {
                string translator=string.Format(
                    CultureInfo.InvariantCulture,
                    @"(?<!{2})((?<WILD>{0})|(?<SINGLE>{1}))",
                    Regex.Escape(wildCard),
                    Regex.Escape(singleChar),
                    Regex.Escape(escapeChar.Value.ToString())
                );
                return Regex.Replace(input, translator, _PatternTranslator, RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Singleline);
            } else
            {
                string translator=string.Format(
                    CultureInfo.InvariantCulture,
                    @"((?<WILD>{0})|(?<SINGLE>{1}))",
                    Regex.Escape(wildCard),
                    Regex.Escape(singleChar)
                );
                return Regex.Replace(input, translator, _PatternTranslator, RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Singleline);
            }
        }

        private static string _PatternTranslator(Match m)
        {
            Group wild=m.Groups["WILD"];
            if (wild.Success)
                return "%";

            Group single=m.Groups["SINGLE"];
            if (single.Success)
                return "_";

            return m.Value;
        }

    }
#pragma warning restore 3009
}
