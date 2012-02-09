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
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class RelativeGeoOperatorRoutineNode:
        AstNode,
        IExpressionBuilder
    {

        internal class RelativeGeoExpressionCreator:
            ExpressionCreator<RelativeGeoOperatorRoutineNode>
        {

            public RelativeGeoExpressionCreator(RelativeGeoOperatorRoutineNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                throw new NotSupportedException("Only custom implementations are supported");
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                return OperationNames.Distance;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                return Expression.MakeBinary(
                    Node._OperatorExpression,
                    op,
                    Expression.Constant(Convert.ChangeType(Node._Tolerance.Value, rt, CultureInfo.InvariantCulture), method.ReturnType)
                );
            }
        }

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _OperatorExpression=context.GetOperatorExpressionType(treeNode.MappedChildNodes[0].FindTokenAndGetText());

            AddChild("", treeNode.MappedChildNodes[1]);
            AddChild("", treeNode.MappedChildNodes[2]);
            _Tolerance=(ToleranceNode)treeNode.MappedChildNodes[3].AstNode;

            AsString=((OperatorNameNode)treeNode.MappedChildNodes[0].AstNode).Name;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        internal protected virtual IExpressionCreator GetExpressionCreator()
        {
            return new RelativeGeoExpressionCreator(this);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private ExpressionType _OperatorExpression;
        private ToleranceNode _Tolerance;
    }
#pragma warning restore 3001, 3009
}
