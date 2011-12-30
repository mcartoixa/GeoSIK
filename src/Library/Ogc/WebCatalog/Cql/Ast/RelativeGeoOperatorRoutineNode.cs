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
    public class RelativeGeoOperatorRoutineNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _OperatorExpression=context.GetOperatorExpressionType(treeNode.MappedChildNodes[0].FindTokenAndGetText());

            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[1]);
            _GeometryLiteral=(GeometryLiteralNode)AddChild("", treeNode.MappedChildNodes[2]);
            _Tolerance=(ToleranceNode)AddChild("", treeNode.MappedChildNodes[3]);

            AsString=((OperatorNameNode)treeNode.MappedChildNodes[0].AstNode).Name;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                object[] pa=new object[] { null, _GeometryLiteral.Value };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Distance, new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) }, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(pa.Length==2);
                    Type st=(pa[1]!=null ? pa[1].GetType() : typeof(SqlGeometry)); // Parameter types may have been changed

                    Expression dop=null;
                    if (instance!=null)
                        dop=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );
                    else
                        dop=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, st),
                            Expression.Constant(pa[1], st)
                        );

                    Type drt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    Expression.MakeBinary(
                        _OperatorExpression,
                        dop,
                        Expression.Constant(Convert.ChangeType(_Tolerance.Value, drt), method.ReturnType)
                    );
                }
            }

            throw new NotSupportedException();
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
