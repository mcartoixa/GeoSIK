////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

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

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class spatialOps:
        IExpressionBuilder
    {

        internal class BinarySpatialExpressionCreator:
            ExpressionCreator<IBinarySpatialOperator>
        {

            public BinarySpatialExpressionCreator(IBinarySpatialOperator op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                throw new NotSupportedException("Only custom implementations are supported");
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues, ExpressionBuilderParameters parameters)
            {
                if (FilterElement.Envelope!=null)
                {
                    paramTypes.Add(typeof(IGeometry));
                    IGeometryBuilder builder=parameters.GeometryBuilderProvider.CreateBuilder();
                    FilterElement.Envelope.Populate(builder);
                    paramValues.Add(builder.ConstructedGeometry);
                } else if (FilterElement.Geometry!=null)
                {
                    paramTypes.Add(typeof(IGeometry));
                    IGeometryBuilder builder=parameters.GeometryBuilderProvider.CreateBuilder();
                    FilterElement.Geometry.Populate(builder);
                    paramValues.Add(builder.ConstructedGeometry);
                }

                Debug.Assert(paramValues.Count==2);
                Debug.Assert(paramTypes.Count==2);

                return FilterElement.Operation;
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
                return FilterElement.PropertyName.Cast<IExpressionBuilder>().GetEnumerator();
            }
        }

        internal class DistanceBufferExpressionCreator:
            ExpressionCreator<IDistanceBufferOperator>
        {

            public DistanceBufferExpressionCreator(IDistanceBufferOperator op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                throw new NotSupportedException("Only custom implementations are supported");
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues, ExpressionBuilderParameters parameters)
            {
                Debug.Assert(paramTypes.Count==2);

                IGeometryBuilder builder=parameters.GeometryBuilderProvider.CreateBuilder();
                FilterElement.Geometry.Populate(builder);
                paramValues.Add(builder.ConstructedGeometry);
                Debug.Assert(paramValues.Count==2);

                return OperationNames.Distance;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                return FilterElement.OperatorExpression(
                    op,
                    Expression.Constant(Convert.ChangeType(FilterElement.Distance, rt, CultureInfo.InvariantCulture), method.ReturnType)
                );
            }

            protected override IEnumerator<IExpressionBuilder> GetEnumerator()
            {
                var ret=new List<IExpressionBuilder>(1);
                ret.Add(FilterElement.PropertyName);
                return ret.GetEnumerator();
            }
        }

        internal protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        internal protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        internal protected virtual IExpressionCreator GetExpressionCreator()
        {
            var bcop=this as IBinarySpatialOperator;
            if (bcop!=null)
                return new BinarySpatialExpressionCreator(bcop);

            var dbop=this as IDistanceBufferOperator;
            if (dbop!=null)
                return new DistanceBufferExpressionCreator(dbop);

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedFilterElement,
                    GetType().Name
                )
            );
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
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
