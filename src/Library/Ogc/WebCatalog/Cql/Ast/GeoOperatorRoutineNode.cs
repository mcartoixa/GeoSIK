using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class GeoOperatorRoutineNode:
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
                object[] pa=new object[] { null, _GeometryLiteral.Value };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(_OperatorName, new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) }, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(pa.Length==2);
                    Type st=(pa[1]!=null ? pa[1].GetType() : typeof(SqlGeometry)); // Parameter types may have been changed

                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );
                    else
                        op=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );


                    Type rt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    if (method.ReturnType==typeof(bool))
                        return Expression.IsTrue(op);
                    else
                        return Expression.Equal(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt), method.ReturnType)
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
