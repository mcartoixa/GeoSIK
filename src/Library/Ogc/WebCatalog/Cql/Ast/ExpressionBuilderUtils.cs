using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Irony.Interpreter.Ast;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

    internal static class ExpressionBuilderUtils
    {

        public static Expression CreateComparisonExpression(ExpressionBuilderParameters parameters, ExpressionType exType, AttributeNameNode left, object right)
        {
            Type subtype=left.GetExpressionStaticType(parameters);

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                object[] pa=new object[] { null, right };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(exType.ToString(), new Type[] { subtype, subtype }, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(pa.Length==2);
                    Type st=(pa[1]!=null ? pa[1].GetType() : subtype); // Parameter types may have been changed

                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            left.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );
                    else
                        op=Expression.Call(
                            method,
                            left.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );


                    Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    if (method.ReturnType==typeof(bool))
                        return Expression.IsTrue(op);
                    else
                        return Expression.Equal(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                }
            }

            if ((subtype==typeof(string)) && (exType!=ExpressionType.Equal) && (exType!=ExpressionType.NotEqual))
                // string comparisons require CompareTo
                return Expression.MakeBinary(
                    exType,
                    Expression.Call(
                        left.CreateExpression(parameters, subtype),
                        typeof(string).GetMethod("CompareTo", new Type[] { typeof(string) }),
                        Expression.Constant(right, subtype)
                    ),
                    Expression.Constant(0, typeof(int))
                );
            else
                // Standard implementation
                return Expression.MakeBinary(
                    exType,
                    left.CreateExpression(parameters, subtype),
                    Expression.Constant(right, subtype)
                );
        }
    }
}
