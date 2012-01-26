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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using Common.Logging;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class expression:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bop=this as IBinaryOperator;
            if (bop!=null)
            {
                if (bop.expression==null)
                    throw new InvalidOperationException();

                Type st=GetExpressionStaticType(parameters);
                Expression[] subexpr=bop.expression
                    .Select<expression, Expression>(e => ((IExpressionBuilder)e).CreateExpression(parameters, st))
                    .ToArray<Expression>();
                Debug.Assert(subexpr.Length==2);
                return Expression.MakeBinary(
                    bop.OperatorExpressionType,
                    subexpr[0],
                    subexpr[1]
                );
            }

            throw new NotSupportedException();
        }

        protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            var bop=this as IBinaryOperator;
            if (bop!=null)
            {
                Type[] subtypes=bop.expression
                    .Select<expression, Type>(e => ((IExpressionBuilder)e).GetExpressionStaticType(parameters))
                    .Where<Type>(t => t!=null)
                    .ToArray<Type>();

                if (subtypes.Length==0)
                    return null;

                //TODO: probably needs more checking on other subtypes there...
                return subtypes[0];
            }

            return null;
        }


        protected ILog Logger
        {
            get
            {
                if (_Logger==null)
                    return _Logger=LogManager.GetCurrentClassLogger();

                return _Logger;
            }
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return CreateExpression(parameters, expectedStaticType);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }

        private ILog _Logger;
    }
#pragma warning restore 3009
}
