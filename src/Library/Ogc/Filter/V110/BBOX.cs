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
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class BBOX:
        IExpressionBuilder
    {

        // BBOX is !geometry.STDisjoint(envelope)
        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            SqlGeometry envelope=Envelope.Geometry;

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                Type[] arguments=new Type[] { typeof(SqlGeometry), typeof(SqlGeometry) };
                object[] pa=new object[] { null, envelope };

                object instance;
                MethodInfo binaryMethod=parameters.OperatorImplementationProvider.GetImplementation(OperationNames.Disjoint, ref arguments, ref pa, out instance);
                Debug.Assert(pa.Length==2);

                if (binaryMethod!=null)
                {
                    Expression op=null;
                    if (instance!=null)
                        op=Expression.Call(
                            Expression.Constant(instance),
                            binaryMethod,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );
                    else
                        op=Expression.Call(
                            binaryMethod,
                            ((IExpressionBuilder)PropertyName).CreateExpression(parameters, arguments[0]),
                            Expression.Constant(pa[1], arguments[1])
                        );

                    Type rt=Nullable.GetUnderlyingType(binaryMethod.ReturnType) ?? binaryMethod.ReturnType;
                    if (binaryMethod.ReturnType==typeof(bool))
                        return Expression.Negate(op);
                    else
                        return Expression.NotEqual(
                            op,
                            Expression.Constant(Convert.ChangeType(true, rt, CultureInfo.InvariantCulture), binaryMethod.ReturnType)
                        );
                }
            }

            throw new NotSupportedException();
        }
    }
#pragma warning restore 3009
}
