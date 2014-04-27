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
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Gml311=GeoSik.Ogc.Gml.V311;

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class 1591, BBOX:
        IExpressionBuilder
    {

        internal class BboxExpressionCreator:
            ExpressionCreator<BBOX>
        {

            public BboxExpressionCreator(BBOX op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                throw new NotSupportedException();
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues, ExpressionBuilderParameters parameters)
            {
                paramTypes.Add(typeof(IGeometry));
                IGeometryBuilder builder=new Gml311.GmlGeometryBuilder();
                FilterElement.Envelope.Populate(builder);
                paramValues.Add(builder.ConstructedGeometry);

                return OperationNames.Intersects;
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
                var ret=new List<IExpressionBuilder>(1);
                ret.Add(FilterElement.PropertyName);
                return ret.GetEnumerator();
            }
        }

        internal protected override IExpressionCreator GetExpressionCreator()
        {
            return new BboxExpressionCreator(this);
        }
    }
#pragma warning restore 1591, 3009
}
