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
    public sealed class GeoOperatorRoutineNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _OperatorName=((OperatorNameNode)treeNode.MappedChildNodes[0].AstNode).Name;
            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[1]);
            _GeometryLiteral=(GeometryLiteralNode)AddChild("", treeNode.MappedChildNodes[2]);

            AsString=_OperatorName;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                Type[] arguments=new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) };
                object[] pa=new object[] { null, _GeometryLiteral.Value };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(_OperatorName, ref arguments, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(pa.Length==2);

                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );
                    else
                        op=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );


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

            throw new NotSupportedException();
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private string _OperatorName;
        private AttributeNameNode _AttributeName;
        private GeometryLiteralNode _GeometryLiteral;
    }
#pragma warning restore 3001, 3009
}
