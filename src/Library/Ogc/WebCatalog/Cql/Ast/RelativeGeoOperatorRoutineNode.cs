using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.SqlServer.Types;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
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

            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[1]);
            _GeometryLiteral=(GeometryLiteralNode)AddChild("", treeNode.MappedChildNodes[2]);
            _Tolerance=(ToleranceNode)treeNode.MappedChildNodes[3].AstNode;

            AsString=((OperatorNameNode)treeNode.MappedChildNodes[0].AstNode).Name;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
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
        private AttributeNameNode _AttributeName;
        private GeometryLiteralNode _GeometryLiteral;
        private ToleranceNode _Tolerance;
    }
#pragma warning restore 3001, 3009
}
