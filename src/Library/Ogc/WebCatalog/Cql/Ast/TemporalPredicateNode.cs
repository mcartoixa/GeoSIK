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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public sealed class TemporalPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        internal class DateComparisonExpressionCreator:
            ExpressionCreator<TemporalPredicateNode>
        {

            public DateComparisonExpressionCreator(TemporalPredicateNode op, DateTime date, ExpressionType expressionType):
                base(op)
            {
                _ExpressionType=expressionType;
                _Date=date;
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                return Expression.MakeBinary(
                    _ExpressionType,
                    subexpr.ElementAt<Expression>(0),
                    Expression.Constant(_Date)
                );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(typeof(DateTime));
                paramValues.Add(_Date);

                return _ExpressionType.ToString();
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

            private ExpressionType _ExpressionType;
            private DateTime _Date;
        }

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            AddChild("", treeNode.MappedChildNodes[0]);

            StringBuilder sb=new StringBuilder();
            for (int i=1; i<treeNode.MappedChildNodes.Count-1; ++i)
                sb.Append(((OperatorNameNode)treeNode.MappedChildNodes[i].AstNode).Name);
            _OperatorName=sb.ToString();

            _DateTimeExpression=(AstNode)treeNode.MappedChildNodes[treeNode.MappedChildNodes.Count-1].AstNode;

            AsString=_OperatorName;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            switch (_OperatorName)
            {
            case AfterOperatorName:
                {
                    var dtln=_DateTimeExpression as DateTimeLiteralNode;
                    if (dtln!=null)
                        return new DateComparisonExpressionCreator(this, dtln.Value, ExpressionType.GreaterThan);
                    else
                        return new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).EndDate, ExpressionType.GreaterThan);
                }
            case AfterOrDuringOperatorName:
                return new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).StartDate, ExpressionType.GreaterThanOrEqual);
            case BeforeOperatorName:
                {
                    var dtln=_DateTimeExpression as DateTimeLiteralNode;
                    if (dtln!=null)
                        return new DateComparisonExpressionCreator(this, dtln.Value, ExpressionType.LessThan);
                    else
                        return new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).StartDate, ExpressionType.GreaterThan);
                }
            case BeforeOrDuringOperatorName:
                return new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).EndDate, ExpressionType.LessThanOrEqual);
            case DuringOperatorName:
                return new CombinedExpressionCreator(
                    new IExpressionCreator[] {
                        new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).StartDate, ExpressionType.GreaterThanOrEqual),
                        new DateComparisonExpressionCreator(this, ((DateTimePeriodNode)_DateTimeExpression).EndDate, ExpressionType.LessThanOrEqual),
                    },
                    ExpressionType.AndAlso
                );
            }

            throw new NotSupportedException();
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        internal const string AfterOperatorName="After";
        internal const string AfterOrDuringOperatorName="AfterOrDuring";
        internal const string BeforeOperatorName="Before";
        internal const string BeforeOrDuringOperatorName="BeforeOrDuring";
        internal const string DuringOperatorName="During";

        private AstNode _DateTimeExpression;
        private string _OperatorName;
    }
#pragma warning restore 3001, 3009
}
