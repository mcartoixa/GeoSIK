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
                object[] pa=new object[] { null, _PatternNode.Value, null, false };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Like, new Type[] { typeof(string), typeof(string), typeof(char), typeof(bool) }, ref pa, out instance);

                if (method!=null)
                {
                    if (instance!=null)
                        ret=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, expectedStaticType),
                            Expression.Constant(pa[1], pa[1].GetType()),
                            Expression.Constant(pa[2], pa[2]!=null ? pa[2].GetType() : typeof(char?)),
                            Expression.Constant(pa[3], pa[3]!=null ? pa[3].GetType() : typeof(bool?))
                        );
                    else
                        ret=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, expectedStaticType),
                            Expression.Constant(pa[1], pa[1].GetType()),
                            Expression.Constant(pa[2], pa[2]!=null ? pa[2].GetType() : typeof(char?)),
                            Expression.Constant(pa[3], pa[3]!=null ? pa[3].GetType() : typeof(bool?))
                        );

                    Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    if (method.ReturnType==typeof(bool))
                        return (_OptionalNot!=null ? Expression.IsFalse(ret) : ret);
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
                    ret=Expression.IsFalse(ret);
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
