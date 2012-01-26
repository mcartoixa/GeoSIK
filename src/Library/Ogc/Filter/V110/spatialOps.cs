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
using System.Xml;
using Microsoft.SqlServer.Types;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class spatialOps:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bsop=this as IBinarySpatialOperator;
            if (bsop!=null)
            {

                // Custom implementation
                if (parameters.OperatorImplementationProvider!=null)
                {
                    Type[] arguments=new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) };
                    object[] pa=new object[] { null, null };
                    if (bsop.Envelope!=null)
                        pa=new object[] { null, bsop.Envelope.Geometry };
                    else if (bsop.Geometry!=null)
                        pa=new object[] { null, bsop.Geometry.Geometry };

                    object instance;
                    MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(bsop.Operation, ref arguments, ref pa, out instance);
                    Debug.Assert(pa.Length==2);

                    if (binaryMethod!=null)
                    {
                        Expression gex=null;

                        // 2nd parameter is a constant ?
                        if (pa[1]!=null)
                            gex=Expression.Constant(pa[1], arguments[1]);

                        // 2nd parameter is a property ?
                        if ((gex==null) && (bsop.PropertyName.Count>1))
                            gex=((IExpressionBuilder)bsop.PropertyName[1]).CreateExpression(parameters, arguments[1]);

                        Expression op=null;
                        if (instance!=null)
                            op=Expression.Call(
                                Expression.Constant(instance),
                                binaryMethod,
                                ((IExpressionBuilder)bsop.PropertyName[0]).CreateExpression(parameters, arguments[0]),
                                gex
                            );
                        else
                            op=Expression.Call(
                                binaryMethod,
                                ((IExpressionBuilder)bsop.PropertyName[0]).CreateExpression(parameters, arguments[0]),
                                gex
                            );

                        Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                        if (binaryMethod.ReturnType==typeof(bool))
                            return op;
                        else
                            return Expression.Equal(
                                op,
                                Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                            );
                    }
                }
            }

            var dbop=this as IDistanceBufferOperator;
            if (dbop!=null)
            {

                // Custom implementation
                if (parameters.OperatorImplementationProvider!=null)
                {
                    Type[] arguments=new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) };
                    object[] pa=new object[] { null, dbop.Geometry.Geometry };

                    object instance;
                    MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Distance, ref arguments, ref pa, out instance);
                    Debug.Assert(pa.Length==2);

                    if (binaryMethod!=null)
                    {
                        Expression op=null;
                        if (instance!=null)
                            op=Expression.Call(
                                Expression.Constant(instance),
                                binaryMethod,
                                ((IExpressionBuilder)dbop.PropertyName).CreateExpression(parameters, arguments[0]),
                                Expression.Constant(pa[1], arguments[1])
                            );
                        else
                            op=Expression.Call(
                                binaryMethod,
                                ((IExpressionBuilder)dbop.PropertyName).CreateExpression(parameters, arguments[0]),
                                Expression.Constant(pa[1], arguments[1])
                            );

                        Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                        return dbop.OperatorExpression(
                            op,
                            Expression.Constant(Convert.ChangeType(dbop.Distance, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                        );
                    }
                }
            }

            throw new NotSupportedException();
        }

        protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return CreateExpression(parameters, expectedStaticType);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
#pragma warning restore 3009
}
