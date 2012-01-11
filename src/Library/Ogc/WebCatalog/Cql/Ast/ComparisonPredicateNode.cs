using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed class ComparisonPredicateNode:
        BinaryOperationNode,
        IExpressionBuilder
    {

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            // According to grammar:
            //  Left is "attribute name"
            //  Right is "general literal"
            return ExpressionBuilderUtils.CreateComparisonExpression(parameters, Op, (AttributeNameNode)Left, Right.Evaluate(null));
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }
    }
#pragma warning restore 3009
}
