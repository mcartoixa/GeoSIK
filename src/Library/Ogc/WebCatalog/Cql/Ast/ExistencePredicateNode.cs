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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.XPath;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public sealed class ExistencePredicateNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);
            _Negated=treeNode.MappedChildNodes[1].Term.Name.Contains("NOT");

        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            if (!_Result.HasValue)
            {
                Csw.V202.XPathQueryableNavigator xptn=new Csw.V202.XPathQueryableNavigator(parameters.ElementType);
                XPathNodeIterator xpni=xptn.Select(_AttributeName.Identifier.Symbol, parameters.NamespaceResolver, true);
                _Result=xpni.MoveNext();
                if (_Negated)
                    _Result=!_Result;
            }

            return Expression.Constant(_Result.Value, typeof(bool));
        }

        public override bool IsConstant()
        {
            return true;
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            //TODO: Initialize _Result...
            return _Result.Value;
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private AttributeNameNode _AttributeName;
        private bool _Negated;
        private bool? _Result;
    }
#pragma warning restore 3001, 3009
}
