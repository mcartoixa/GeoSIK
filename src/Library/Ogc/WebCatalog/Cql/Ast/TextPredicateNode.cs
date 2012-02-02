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
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3009
    public sealed class TextPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        internal class TextExpressionCreator:
            ExpressionCreator<TextPredicateNode>
        {

            public TextExpressionCreator(TextPredicateNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;

                // LINQ to SQL. Case sensitivity depends on database configuration
                if (parameters.QueryProvider is ITable)
                    ret=Expression.Call(
                        typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string) }),
                        subexpr
                    );

                if (ret!=null)
                {
                    if (Node._OptionalNot!=null)
                        return Expression.Not(ret);

                    return ret;
                }

                throw new NotSupportedException();
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(typeof(char?));
                paramValues.Add(null);

                paramTypes.Add(typeof(StringComparison));
                paramValues.Add(StringComparison.CurrentCultureIgnoreCase);

                return OperationNames.Like;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;

                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                if (method.ReturnType==typeof(bool))
                {
                    if (Node._OptionalNot!=null)
                        return Expression.Not(op);
                    return ret;
                } else
                {
                    if (Node._OptionalNot!=null)
                        return Expression.NotEqual(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                    else
                        return Expression.Equal(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                }
            }
        }

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            var on=treeNode.MappedChildNodes[1].AstNode as NotKeywordNode;
            if (on!=null)
                _OptionalNot=on;
            AddChild("", treeNode.MappedChildNodes[0]);
            AddChild("", treeNode.MappedChildNodes[treeNode.MappedChildNodes.Count-1]);

            AsString="IsLike";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            return new TextExpressionCreator(this);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private NotKeywordNode _OptionalNot;
    }
#pragma warning restore 3009
}
