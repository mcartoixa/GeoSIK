using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class BBOX:
        IExpressionBuilder
    {

        // BBOX is !geometry.STDisjoint(envelope)
        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            byte[] envelope=null;
            using (var ms=new MemoryStream())
                using (var bw=new BinaryWriter(ms))
                {
                    Envelope.Geometry.Write(bw);
                    envelope=ms.ToArray();
                }

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                object instance;
                object[] pa=new object[] { null, envelope };
                MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation("STDisjoint", new Type[] { typeof(byte[]), typeof(byte[]) }, ref pa, out instance);
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
                    return Expression.Equal(
                        op,
                        Expression.Constant(Convert.ChangeType(1, rt), binaryMethod.ReturnType)
                    );
                }
            }

            throw new NotSupportedException();
        }
    }
}
