using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class BBOX:
        IExpressionBuilder
    {

        // BBOX is !geometry.STDisjoint(envelope)
        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            SqlGeometry envelope=Envelope.Geometry;

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                object[] pa=new object[] { null, envelope };

                object instance;
                MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Disjoint, new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) }, ref pa, out instance);
                Debug.Assert(pa.Length==2);

                if (binaryMethod!=null)
                {
                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            binaryMethod,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, pa[1].GetType()),
                            Expression.Constant(pa[1])
                        );
                    else
                        op=Expression.Call(
                            binaryMethod,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, pa[1].GetType()),
                            Expression.Constant(pa[1])
                        );

                    Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                    if (binaryMethod.ReturnType==typeof(bool))
                        return Expression.IsFalse(op);
                    else
                        return Expression.NotEqual(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                        );
                }
            }

            throw new NotSupportedException();
        }
    }
#pragma warning restore 3009
}
