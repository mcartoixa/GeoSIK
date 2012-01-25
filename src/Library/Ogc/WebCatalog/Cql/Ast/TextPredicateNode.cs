using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
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
    public sealed class TextPredicateNode:
        AstNode,
        IExpressionBuilder
    {

        internal class TextExpressionCreator:
            ExpressionCreator<TextPredicateNode>
        {

            public TextExpressionCreator(TextPredicateNode op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;

                // LINQ to SQL. Case sensitivity depends on database configuration
                if (parameters.QueryProvider is ITable)
                    ret=Expression.Call(
                        typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string) }),
                        subexpr
                    );

                if (ret!=null)
                {
                    if (Node._OptionalNot!=null)
                        return Expression.Not(ret);

                    return ret;
                }

                throw new NotSupportedException();
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                paramTypes.Add(typeof(char?));
                paramValues.Add(null);

                paramTypes.Add(typeof(bool?));
                paramValues.Add(false);

                return OperationNames.Like;
            }

            protected override Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                Expression ret=null;

                Expression op=base.CreateCustomExpression(method, instance, subexpr, parameters, subType);

                Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                if (method.ReturnType==typeof(bool))
                {
                    if (Node._OptionalNot!=null)
                        return Expression.Not(op);
                    return ret;
                } else
                {
                    if (Node._OptionalNot!=null)
                        return Expression.NotEqual(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                    else
                        return Expression.Equal(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                }
            }
        }

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            var on=treeNode.MappedChildNodes[1].AstNode as NotKeywordNode;
            if (on!=null)
                _OptionalNot=on;
            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);
            _PatternNode=(LiteralValueNode)AddChild("", treeNode.MappedChildNodes[treeNode.MappedChildNodes.Count-1]);

            AsString="IsLike";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        private IExpressionCreator GetExpressionCreator()
        {
            return new TextExpressionCreator(this);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private NotKeywordNode _OptionalNot;
        private AttributeNameNode _AttributeName;
        private LiteralValueNode _PatternNode;
    }
#pragma warning restore 3009
}
