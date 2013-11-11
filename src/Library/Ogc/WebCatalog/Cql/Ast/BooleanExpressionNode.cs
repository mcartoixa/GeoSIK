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
using System.Text;
using Irony.Ast;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public abstract class BooleanExpressionNode:
        AstNode,
        IExpressionBuilder
    {

        internal class BooleanExpressionCreator:
            ExpressionCreator<BooleanExpressionNode>
        {

            public BooleanExpressionCreator(BooleanExpressionNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;
                foreach (Expression ex in subexpr)
                {
                    if (ret!=null)
                        ret=Expression.MakeBinary(
                            Node.ExpressionType,
                            ret,
                            ex
                        );
                    else
                        ret=ex;
                }
                return ret;
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                return Node.ExpressionType.ToString();
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;
                foreach (Expression exp in subexpr)
                {
                    if (ret!=null)
                    {
                        if (instance!=null)
                            ret=Expression.Call(
                                Expression.Constant(instance),
                                method,
                                ret,
                                exp
                            );
                        else
                            ret=Expression.Call(
                                method,
                                ret,
                                exp
                            );

                        Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                        if (method.ReturnType!=typeof(bool))
                            ret=Expression.Equal(
                                ret,
                                Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                            );
                    } else
                        ret=exp;
                }
                return ret;
            }
        }

        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            foreach (ParseTreeNode ptn in treeNode.ChildNodes)
                AddChild("", ptn);

            AsString=ExpressionType.ToString();
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        protected static Type GetExpressionStaticType()
        {
            return typeof(bool);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType();
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            thread.CurrentNode=this;

            object ret=ChildNodes[0].Evaluate(thread);
            for (int i=1; i<ChildNodes.Count; ++i)
                ret=thread.Runtime.ExecuteBinaryOperator(ExpressionType, ret, ChildNodes[i].Evaluate(thread), ref _LastUsed);

            thread.CurrentNode=Parent;
            return ret;
        }

        internal protected virtual IExpressionCreator GetExpressionCreator()
        {
            return new BooleanExpressionCreator(this);
        }

        private OperatorImplementation _LastUsed;
    }

    public sealed class BooleanValueExpressionNode:
        BooleanExpressionNode
    {

        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            ExpressionType=ExpressionType.OrElse;

            base.Init(context, treeNode);
        }
    }

    public sealed class BooleanTermNode:
        BooleanExpressionNode
    {

        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            ExpressionType=ExpressionType.AndAlso;

            base.Init(context, treeNode);
        }
    }
#pragma warning restore 3001, 3009
}
