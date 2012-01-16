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
    public abstract class BooleanExpressionNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            foreach (ParseTreeNode ptn in treeNode.MappedChildNodes)
                AddChild("", ptn);

            AsString=ExpressionType.ToString();
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Expression ret=((IExpressionBuilder)ChildNodes[0]).CreateExpression(parameters, typeof(bool));
            for (int i=1; i<ChildNodes.Count; ++i)
                ret=Expression.MakeBinary(ExpressionType, ret, ((IExpressionBuilder)ChildNodes[i]).CreateExpression(parameters, typeof(bool)));

            return ret;
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

        private OperatorImplementation _LastUsed;
    }

    public sealed class BooleanValueExpressionNode:
        BooleanExpressionNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            ExpressionType=ExpressionType.OrElse;

            base.Init(context, treeNode);
        }
    }

    public sealed class BooleanTermNode:
        BooleanExpressionNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            ExpressionType=ExpressionType.AndAlso;

            base.Init(context, treeNode);
        }
    }
#pragma warning restore 3001, 3009
}
