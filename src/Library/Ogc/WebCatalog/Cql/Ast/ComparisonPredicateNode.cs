using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3009
    public sealed class ComparisonPredicateNode:
        BinaryOperationNode,
        IExpressionBuilder
    {

        internal class ComparisonExpressionCreator:
            ExpressionCreator<ComparisonPredicateNode>
        {

            public ComparisonExpressionCreator(ComparisonPredicateNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                if (subType==typeof(string))
                    // string comparisons require Compare
                    return Expression.MakeBinary(
                        Node.Op,
                        Expression.Call(
                            typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string), typeof(StringComparison) }),
                            subexpr.ElementAt<Expression>(0),
                            subexpr.ElementAt<Expression>(1),
                            Expression.Constant(StringComparison.CurrentCulture)
                        ),
                        Expression.Constant(0, typeof(int))
                    );
                else
                    return Expression.MakeBinary(
                        Node.Op,
                        subexpr.ElementAt<Expression>(0),
                        subexpr.ElementAt<Expression>(1)
                    );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                if (paramTypes[0]==typeof(string))
                {
                    paramTypes.Add(typeof(StringComparison));
                    paramValues.Add(StringComparison.CurrentCulture);
                }

                return Node.ExpressionType.ToString();
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
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            return new ComparisonExpressionCreator(this);
        }
    }
#pragma warning restore 3009
}
