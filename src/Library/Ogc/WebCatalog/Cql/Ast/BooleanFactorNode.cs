////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public sealed class BooleanFactorNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            foreach (ParseTreeNode ptn in treeNode.MappedChildNodes)
            {
                AstNode node=AddChild("", ptn);

                var on=node as NotKeywordNode;
                if (on!=null)
                    _OptionalNot=on;
                else
                    _Primary=node;
            }

            AsString="(boolean factor)";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Expression ret=((IExpressionBuilder)_Primary).CreateExpression(parameters, typeof(bool));

            if (_OptionalNot!=null)
                ret=Expression.Not(ret);

            return ret;
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            thread.CurrentNode=this;

            object ret=_Primary.Evaluate(thread);
            if (_OptionalNot!=null)
                ret=thread.Runtime.ExecuteUnaryOperator(ExpressionType.Not, ret, ref _LastUsed);

            thread.CurrentNode=Parent;
            return ret;
        }

        private NotKeywordNode _OptionalNot;
        private AstNode _Primary;
        private OperatorImplementation _LastUsed;
    }
#pragma warning restore 3001, 3009
}
