﻿using System;
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

#pragma warning disable 3009
    public sealed class NullPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        internal class NullExpressionCreator:
            ExpressionCreator<NullPredicateNode>
        {

            public NullExpressionCreator(NullPredicateNode op) :
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                return Expression.MakeBinary(
                    Node._OptionalNot!=null ? ExpressionType.NotEqual : ExpressionType.Equal,
                    subexpr.ElementAt<Expression>(0),
                    Expression.Constant(null, subType)
                );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(paramTypes[0]);
                paramValues.Add(null);

                return Node._OptionalNot!=null ? OperationNames.NotEqual : OperationNames.Equal;
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
        }

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            var on=treeNode.MappedChildNodes[2].AstNode as NotKeywordNode;
            if (on!=null)
                _OptionalNot=on;
            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);

            AsString="IsNull";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            return new NullExpressionCreator(this);
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
