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

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            var on=treeNode.MappedChildNodes[1].AstNode as NotKeywordNode;
            if (on!=null)
                _OptionalNot=(NotKeywordNode)AddChild("", treeNode.MappedChildNodes[1]);
            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);
            _PatternNode=(LiteralValueNode)AddChild("", treeNode.MappedChildNodes[treeNode.MappedChildNodes.Count-1]);

            AsString="IsLike";
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Expression ret=null;

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                Type[] arguments=new Type[] { typeof(string), typeof(string), typeof(char), typeof(bool) };
                object[] pa=new object[] { null, _PatternNode.Value, null, false };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Like, ref arguments, ref pa, out instance);

                if (method!=null)
                {
                    if (instance!=null)
                        ret=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1]),
                            Expression.Constant(pa[2], arguments[2]),
                            Expression.Constant(pa[3], arguments[3])
                        );
                    else
                        ret=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1]),
                            Expression.Constant(pa[2], arguments[2]),
                            Expression.Constant(pa[3], arguments[3])
                        );

                    Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    if (method.ReturnType==typeof(bool))
                        return (_OptionalNot!=null ? Expression.Negate(ret) : ret);
                    else
                        return Expression.MakeBinary(
                            _OptionalNot!=null ? ExpressionType.NotEqual : ExpressionType.Equal,
                            ret,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), method.ReturnType)
                        );
                }
            }

            // LINQ to SQL. Case sensitivity depends on database configuration
            if (parameters.QueryProvider is ITable)
                ret=Expression.Call(
                    typeof(SqlMethods).GetMethod("Like", new Type[] { typeof(string), typeof(string) }),
                    _AttributeName.CreateExpression(parameters, expectedStaticType),
                    Expression.Constant(_PatternNode.Value)
                );

            if (ret!=null)
            {
                if (_OptionalNot!=null)
                    ret=Expression.Negate(ret);
                return ret;
            }

            throw new NotImplementedException();
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
