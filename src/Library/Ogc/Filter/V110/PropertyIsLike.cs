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

        internal class PropertyIsLikeExpressionCreator:
            ExpressionCreator<PropertyIsLike>
        {

            public PropertyIsLikeExpressionCreator(PropertyIsLike op):
                base(op)
            {
                _EscapeChar=(!string.IsNullOrEmpty(op.escapeChar) ? (char?)op.escapeChar[0] : null);
                _Pattern=TranslateToSqlLikePattern(op.Literal.Untyped.Value, op.wildCard, op.singleChar, _EscapeChar);
                _MatchCase=op.matchCase;
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                // LINQ to SQL. Case sensitivity depends on database configuration
                if (parameters.QueryProvider is ITable)
                {
                    List<Expression> pars=new List<Expression>(subexpr);
                    pars.Add(Expression.Constant(_Pattern));

                    if (_EscapeChar.HasValue)
                    {
                        pars.Add(Expression.Constant(_EscapeChar.Value, typeof(char)));
                        return Expression.Call(
                            typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string), typeof(char) }),
                            pars
                        );
                    } else
                        return Expression.Call(
                            typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string) }),
                            pars
                        );
                }

                throw new NotSupportedException();
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(typeof(string));
                paramValues.Add(_Pattern);

                paramTypes.Add(typeof(char?));
                paramValues.Add(_EscapeChar);

                paramTypes.Add(typeof(bool?));
                paramValues.Add(_MatchCase);

                return OperationNames.Like;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                if (method.ReturnType==typeof(bool))
                    return op;
                else
                    return Expression.Equal(
                        op,
                        Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                    );
            }

            protected override IEnumerator<IExpressionBuilder> GetEnumerator()
            {
                var ret=new List<IExpressionBuilder>(1);
                ret.Add(FilterElement.PropertyName);
                return ret.GetEnumerator();
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

            private string _Pattern;
            private char? _EscapeChar;
            private bool _MatchCase;
        }

        internal protected override IExpressionCreator GetExpressionCreator()
        {
            return new PropertyIsLikeExpressionCreator(this);
        }
    }
#pragma warning restore 3009
}
