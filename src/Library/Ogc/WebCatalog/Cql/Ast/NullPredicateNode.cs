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

#pragma warning disable 3009
    public sealed class NullPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            var on=treeNode.MappedChildNodes[2].AstNode as NotKeywordNode;
            if (on!=null)
                _OptionalNot=(NotKeywordNode)AddChild("", treeNode.MappedChildNodes[2]);
            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);

            AsString="IsNull";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return ExpressionBuilderUtils.CreateComparisonExpression(
                parameters,
                _OptionalNot!=null ? ExpressionType.NotEqual : ExpressionType.Equal,
                _AttributeName,
                null
            );
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private NotKeywordNode _OptionalNot;
        private AttributeNameNode _AttributeName;
    }
#pragma warning restore 3009
}
