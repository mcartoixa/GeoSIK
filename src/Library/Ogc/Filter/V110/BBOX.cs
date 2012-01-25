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

        internal class BboxExpressionCreator:
            ExpressionCreator<BBOX>
        {

            public BboxExpressionCreator(BBOX op):
                base(op)
            {
                _Envelope=op.Envelope.Geometry;
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                throw new NotSupportedException();
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(typeof(SqlGeometry));
                paramValues.Add(_Envelope);

                return OperationNames.Disjoint;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                if (method.ReturnType==typeof(bool))
                    return Expression.Negate(op);
                else
                    return Expression.NotEqual(
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

            private SqlGeometry _Envelope;
        }

        internal protected override IExpressionCreator GetExpressionCreator()
        {
            return new BboxExpressionCreator(this);
        }
    }
#pragma warning restore 3009
}
