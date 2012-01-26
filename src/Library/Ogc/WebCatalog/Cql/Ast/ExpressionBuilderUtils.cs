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
using Irony.Interpreter.Ast;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

    internal static class ExpressionBuilderUtils
    {

        public static Expression CreateComparisonExpression(ExpressionBuilderParameters parameters, ExpressionType exType, AttributeNameNode left, object right)
        {
            Type subtype=left.GetExpressionStaticType(parameters);

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                Type[] arguments=new Type[] { subtype, subtype };
                object[] pa=new object[] { null, right };

                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(exType.ToString(), ref arguments, ref pa, out instance);
                if (method!=null)
                {
                    Debug.Assert(arguments.Length==2);
                    Debug.Assert(pa.Length==2);

                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            method,
                            left.CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );
                    else
                        op=Expression.Call(
                            method,
                            left.CreateExpression(parameters, arguments[0]),
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

            if (subtype==typeof(string))
                // string comparisons require Compare
                return Expression.MakeBinary(
                    exType,
                    Expression.Call(
                        typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string), typeof(StringComparison) }),
                        left.CreateExpression(parameters, subtype),
                        Expression.Constant(right, subtype),
                        Expression.Constant(StringComparison.CurrentCulture)
                    ),
                    Expression.Constant(0, typeof(int))
                );
            else
                // Standard implementation
                return Expression.MakeBinary(
                    exType,
                    left.CreateExpression(parameters, subtype),
                    Expression.Constant(right, subtype)
                );
        }
    }
}
