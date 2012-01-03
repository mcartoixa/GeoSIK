using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using Microsoft.SqlServer.Types;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class spatialOps:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bsop=this as IBinarySpatialOperator;
            if (bsop!=null)
            {

                // Custom implementation
                if (parameters.OperatorImplementationProvider!=null)
                {
                    object[] pa=new object[] { null, null };
                    if (bsop.Envelope!=null)
                        pa=new object[] { null, bsop.Envelope.Geometry };
                    else if (bsop.Geometry!=null)
                        pa=new object[] { null, bsop.Geometry.Geometry };

                    object instance;
                    MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(bsop.Operation, new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) }, ref pa, out instance);
                    Debug.Assert(pa.Length==2);

                    if (binaryMethod!=null)
                    {
                        Type gt=typeof(SqlGeometry);
                        Expression gex=null;

                        // 2nd parameter is a constant ?
                        if (pa[1]!=null)
                        {
                            gt=pa[1].GetType();
                            gex=Expression.Constant(pa[1]);
                        }

                        // 2nd parameter is a property ?
                        if ((gex==null) && (bsop.PropertyName.Count>1))
                            gex=((IExpressionBuilder)bsop.PropertyName[1]).CreateExpression(parameters, gt);

                        Expression op=null;
                        if (instance!=null)
                            op=Expression.Call(
                                Expression.Constant(instance),
                                binaryMethod,
                                ((IExpressionBuilder)bsop.PropertyName[0]).CreateExpression(parameters, gt),
                                gex
                            );
                        else
                            op=Expression.Call(
                                binaryMethod,
                                ((IExpressionBuilder)bsop.PropertyName[0]).CreateExpression(parameters, gt),
                                gex
                            );

                        Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                        if (binaryMethod.ReturnType==typeof(bool))
                            return Expression.IsTrue(op);
                        else
                            return Expression.Equal(
                                op,
                                Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                            );
                    }
                }
            }

            var dbop=this as IDistanceBufferOperator;
            if (dbop!=null)
            {

                // Custom implementation
                if (parameters.OperatorImplementationProvider!=null)
                {
                    object[] pa=new object[] { null, dbop.Geometry.Geometry };

                    object instance;
                    MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Distance, new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) }, ref pa, out instance);
                    Debug.Assert(pa.Length==2);

                    if (binaryMethod!=null)
                    {
                        Expression op=null;
                        if (instance!=null)
                            op=Expression.Call(
                                Expression.Constant(instance),
                                binaryMethod,
                                ((IExpressionBuilder)dbop.PropertyName).CreateExpression(parameters, pa[1].GetType()),
                                Expression.Constant(pa[1])
                            );
                        else
                            op=Expression.Call(
                                binaryMethod,
                                ((IExpressionBuilder)dbop.PropertyName).CreateExpression(parameters, pa[1].GetType()),
                                Expression.Constant(pa[1])
                            );

                        Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                        return dbop.OperatorExpression(
                            op,
                            Expression.Constant(Convert.ChangeType(dbop.Distance, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                        );
                    }
                }
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
