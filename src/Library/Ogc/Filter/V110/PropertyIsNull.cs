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
using System.Xml.XPath;

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsNull
    {

        internal class PropertyIsNullExpressionCreator:
            ExpressionCreator<PropertyIsNull>
        {

            public PropertyIsNullExpressionCreator(PropertyIsNull op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                List<Expression> pars=new List<Expression>(subexpr);
                pars.Add(Expression.Constant(null, subType));

                return Expression.Equal(
                    pars[0],
                    pars[1]
                );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues, ExpressionBuilderParameters parameters)
            {
                paramTypes.Add(paramTypes[0]);
                paramValues.Add(null);

                return OperationNames.Equal;
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
            return new PropertyIsNullExpressionCreator(this);
        }
    }
#pragma warning restore 3009
}
