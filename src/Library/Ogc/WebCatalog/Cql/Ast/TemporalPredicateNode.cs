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
    public sealed class TemporalPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);

            StringBuilder sb=new StringBuilder();
            for (int i=1; i<treeNode.MappedChildNodes.Count-1; ++i)
                sb.Append(((OperatorNameNode)treeNode.MappedChildNodes[i].AstNode).Name);
            _OperatorName=sb.ToString();

            _DateTimeExpression=AddChild("", treeNode.MappedChildNodes[treeNode.MappedChildNodes.Count-1]);

            AsString=_OperatorName;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            switch (_OperatorName)
            {
            case AfterOperatorName:
                {
                    var dtln=_DateTimeExpression as DateTimeLiteralNode;
                    if (dtln!=null)
                        return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.GreaterThan, _AttributeName, dtln.Value);
                    else
                        return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.GreaterThan, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).EndDate);
                }
            case AfterOrDuringOperatorName:
                return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.GreaterThanOrEqual, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).StartDate);
            case BeforeOperatorName:
                {
                    var dtln=_DateTimeExpression as DateTimeLiteralNode;
                    if (dtln!=null)
                        return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.LessThan, _AttributeName, dtln.Value);
                    else
                        return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.LessThan, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).StartDate);
                }
            case BeforeOrDuringOperatorName:
                return ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.LessThanOrEqual, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).EndDate);
            case DuringOperatorName:
                {
                    var l=ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.GreaterThanOrEqual, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).StartDate);
                    var r=ExpressionBuilderUtils.CreateComparisonExpression(parameters, ExpressionType.LessThanOrEqual, _AttributeName, ((DateTimePeriodNode)_DateTimeExpression).EndDate);
                    return Expression.AndAlso(l, r);
                }
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

        private AttributeNameNode _AttributeName;
        private AstNode _DateTimeExpression;
        private string _OperatorName;
    }
#pragma warning restore 3001, 3009
}
