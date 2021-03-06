﻿////////////////////////////////////////////////////////////////////////////////
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
using System.Linq.Expressions;
using Irony.Ast;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public abstract class DeferredLiteralNode<T>:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Node=treeNode;
            AsString=treeNode.Token.Text;
        }

        protected abstract T GetValue(ParseTreeNode treeNode, ExpressionBuilderParameters parameters);

        public override bool IsConstant()
        {
            return true;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            Expression ret=Expression.Constant(GetValue(_Node, parameters), GetExpressionStaticType(parameters));

            if (operatorCreator!=null)
                ret=operatorCreator(ret, null);

            return ret;
        }

        internal protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(T);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }

        private ParseTreeNode _Node;
    }
#pragma warning restore 3001, 3009
}
