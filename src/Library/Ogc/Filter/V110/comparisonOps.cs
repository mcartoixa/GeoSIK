using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using Xml.Schema.Linq;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class comparisonOps:
        IExpressionBuilder
    {

        internal class BinaryComparisonExpressionCreator:
            ExpressionCreator<IBinaryComparisonOperator>
        {

            public BinaryComparisonExpressionCreator(IBinaryComparisonOperator op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                if (subType==typeof(string))
                    // string comparisons require Compare
                    return Expression.MakeBinary(
                        FilterElement.OperatorExpressionType,
                        Expression.Call(
                            typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string), typeof(StringComparison) }),
                            subexpr.ElementAt<Expression>(0),
                            subexpr.ElementAt<Expression>(1),
                            Expression.Constant(FilterElement.matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase)
                        ),
                        Expression.Constant(0, typeof(int))
                    );
                else
                    return Expression.MakeBinary(
                        FilterElement.OperatorExpressionType,
                        subexpr.ElementAt<Expression>(0),
                        subexpr.ElementAt<Expression>(1)
                    );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                if (paramTypes[0]==typeof(string))
                {
                    paramTypes.Add(typeof(StringComparison));
                    paramValues.Add(FilterElement.matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase);
                }

                return FilterElement.OperatorExpressionType.ToString();
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
                Debug.Assert(FilterElement.expression.Count==2);
                return FilterElement.expression.GetEnumerator();
            }
        }

        internal protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        internal protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        internal protected virtual IExpressionCreator GetExpressionCreator()
        {
            var bcop=this as IBinaryComparisonOperator;
            if (bcop!=null)
                return new BinaryComparisonExpressionCreator(bcop);

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedFilterElement,
                    GetType().Name
                )
            );
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            return CreateExpression(parameters, expectedStaticType, operatorCreator);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
#pragma warning restore 3009
}
