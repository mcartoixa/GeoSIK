////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

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
                Type[] arguments=new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) };
                object[] pa=new object[] { null, _GeometryLiteral.Value };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Distance, ref arguments, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(arguments.Length==2);
                    Debug.Assert(pa.Length==2);

                    Expression dop=null;
                    if (instance!=null)
                        dop=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );
                    else
                        dop=Expression.Call(
                            method,
                            _AttributeName.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );

                    Type drt=Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                    Expression.MakeBinary(
                        _OperatorExpression,
                        dop,
                        Expression.Constant(Convert.ChangeType(_Tolerance.Value, drt, CultureInfo.InvariantCulture), method.ReturnType)
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
