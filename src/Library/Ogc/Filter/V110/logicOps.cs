using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xml.Schema.Linq;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class logicOps:
        IExpressionBuilder
    {

        internal class BinaryLogicalExpressionCreator:
            ExpressionCreator<IBinaryLogicalOperator>
        {

            public BinaryLogicalExpressionCreator(IBinaryLogicalOperator op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;
                foreach (Expression ex in subexpr)
                {
                    if (ret!=null)
                        ret=Expression.MakeBinary(
                            FilterElement.OperatorExpressionType,
                            ret,
                            ex
                        );
                    else
                        ret=ex;
                }
                return ret;
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                return FilterElement.OperatorExpressionType.ToString();
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;
                foreach (Expression exp in subexpr)
                {
                    if (ret!=null)
                    {
                        if (instance!=null)
                            ret=Expression.Call(
                                Expression.Constant(instance),
                                method,
                                ret,
                                exp
                            );
                        else
                            ret=Expression.Call(
                                method,
                                ret,
                                exp
                            );

                        Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                        if (method.ReturnType!=typeof(bool))
                            ret=Expression.Equal(
                                ret,
                                Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                            );
                    } else
                        ret=exp;
                }
                return ret;
            }

            protected override IEnumerator<IExpressionBuilder> GetEnumerator()
            {
                return GetLogicalElements(FilterElement).GetEnumerator();
            }

            private static IEnumerable<IExpressionBuilder> GetLogicalElements(IBinaryLogicalOperator op)
            {
                int icmp, ispa, ilog, ifun;
                icmp=ispa=ilog=ifun=0;

                // We want them in the order they were declared...
                foreach (XElement d in ((XTypedElement)op).Untyped.Elements())
                {
                    if ((op.comparisonOps!=null) && (op.comparisonOps.Count>icmp) && (d.Name==op.comparisonOps[icmp].Untyped.Name))
                        yield return op.comparisonOps[icmp++];
                    else if ((op.spatialOps!=null) && (op.spatialOps.Count>ispa) && (d.Name==op.spatialOps[ispa].Untyped.Name))
                        yield return op.spatialOps[ispa++];
                    else if ((op.logicOps!=null) && (op.logicOps.Count>ilog) && (d.Name==op.logicOps[ilog].Untyped.Name))
                        yield return op.logicOps[ilog++];
                    else if ((op.Function!=null) && (op.Function.Count>ifun) && (d.Name==op.Function[ifun].Untyped.Name))
                        yield return op.Function[ifun++];
                    else
                        throw new NotSupportedException();
                }
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
            var blop=this as IBinaryLogicalOperator;
            if (blop!=null)
                return new BinaryLogicalExpressionCreator(blop);

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
