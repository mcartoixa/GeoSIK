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

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bcop=this as IBinaryComparisonOperator;
            if (bcop!=null)
            {
                if (bcop.expression==null)
                    throw new InvalidOperationException();

                Type[] subtypes=bcop.expression
                    .Select<expression, Type>(e => ((IExpressionBuilder)e).GetExpressionStaticType(parameters))
                    .Where<Type>(t => t!=null)
                    .ToArray<Type>();
                //TODO: probably needs more checking on other subtypes there...
                Type subtype=(subtypes.Length>0 ? subtypes[0] : null);

                Expression[] subexpr=bcop.expression
                    .Select<expression, Expression>(e => ((IExpressionBuilder)e).CreateExpression(parameters, subtype))
                    .ToArray<Expression>();
                Debug.Assert(subexpr.Length==2);

                // Custom implementation
                if (parameters.OperatorImplementationProvider!=null)
                {
                    List<object> pal=subexpr
                        .Select<Expression, object>(e => (e.NodeType==LinqExpressionType.Constant ? ((ConstantExpression)e).Value : null))
                        .ToList<object>();
                    object[] pa=new object[] { pal[0], pal[1] };
                    Type[] pt=new Type[] { subtype, subtype };

                    // String comparisons can be case (in)sensitive
                    if (subtype==typeof(string))
                    {
                        pa=new object[] { pal[0], pal[1], (bcop.matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase) };
                        pt=new Type[] { subtype, subtype, typeof(StringComparison) };
                    }

                    object instance;
                    MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(bcop.OperatorExpressionType.ToString(), ref pt, ref pa, out instance);
                    if (method!=null)
                    {
                        Debug.Assert(pa.Length==pt.Length);
                        object sto=pa.FirstOrDefault<object>(p => p!=null);
                        Type st=(sto!=null ? sto.GetType() : subtype); // Parameter types may have been changed

                        if (st!=subtype)
                            subexpr=bcop.expression
                                .Select<expression, Expression>(e => ((IExpressionBuilder)e).CreateExpression(parameters, st))
                                .ToArray<Expression>();

                        List<Expression> paex=new List<Expression>(3);
                        paex.Add(subexpr[0]);
                        paex.Add(subexpr[1]);
                        if ((pa.Length>2) && (pa[2]!=null))
                            paex.Add(Expression.Constant(pa[2]));

                        Expression op=null;
                        if (instance!=null)
                            op=Expression.Call(
                                Expression.Constant(instance),
                                method,
                                paex
                            );
                        else
                            op=Expression.Call(
                                method,
                                paex
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

                if (subtype==typeof(string))
                    // string comparisons require Compare
                    return Expression.MakeBinary(
                        bcop.OperatorExpressionType,
                        Expression.Call(
                            typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string), typeof(StringComparison) }),
                            subexpr[0],
                            subexpr[1],
                            Expression.Constant(bcop.matchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase)
                        ),
                        Expression.Constant(0, typeof(int))
                    );
                else
                    return Expression.MakeBinary(
                        bcop.OperatorExpressionType,
                        subexpr[0],
                        subexpr[1]
                    );
            }

            throw new NotSupportedException();
        }

        protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return CreateExpression(parameters, expectedStaticType);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
#pragma warning restore 3009
}
