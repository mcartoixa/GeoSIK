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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Irony.Interpreter.Ast;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3009
    public sealed class ComparisonPredicateNode:
        BinaryOperationNode,
        IExpressionBuilder
    {

        internal class ComparisonExpressionCreator:
            ExpressionCreator<ComparisonPredicateNode>
        {

            public ComparisonExpressionCreator(ComparisonPredicateNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                var exp1 = subexpr.ElementAt(0);
                var exp2 = subexpr.ElementAt(1);
                if (subType!=typeof(string))
                {
                    if (exp1.Type!=exp2.Type)
                    {
                        if (exp2.NodeType==ExpressionType.Constant)
                            exp2=Expression.Convert(exp2, exp1.Type);
                        else if (exp1.NodeType==ExpressionType.Constant)
                            exp1=Expression.Convert(exp1, exp2.Type);
                    }

                    return Expression.MakeBinary(
                        Node.Op,
                        exp1,
                        exp2,
                        true,
                        null
                    );
                } else
                    // string comparisons require Compare
                    return Expression.MakeBinary(
                        Node.Op,
                        Expression.Call(
                            typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string), typeof(StringComparison) }),
                            exp1,
                            exp2,
                            Expression.Constant(StringComparison.CurrentCulture)
                        ),
                        Expression.Constant(0, typeof(int))
                    );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                if (paramTypes[0]==typeof(string))
                {
                    paramTypes.Add(typeof(StringComparison));
                    paramValues.Add(StringComparison.CurrentCulture);
                }

                return Node.ExpressionType.ToString();
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
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            return new ComparisonExpressionCreator(this);
        }
    }
#pragma warning restore 3009
}
