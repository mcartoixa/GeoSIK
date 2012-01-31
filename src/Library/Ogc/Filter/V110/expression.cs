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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

        internal class BinaryExpressionCreator:
            ExpressionCreator<IBinaryOperator>
        {

            public BinaryExpressionCreator(IBinaryOperator op):
                base(op)
            {
            }

            protected override Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
            {
                return Expression.MakeBinary(
                    FilterElement.OperatorExpressionType,
                    subexpr.ElementAt<Expression>(0),
                    subexpr.ElementAt<Expression>(1)
                );
            }

            protected override string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues)
            {
                return FilterElement.OperatorExpressionType.ToString();
            }

            protected override IEnumerator<IExpressionBuilder> GetEnumerator()
            {
                Debug.Assert(FilterElement.expression.Count==2);
                return FilterElement.expression.GetEnumerator();
            }
        }

        internal protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator=null)
        {
            return GetExpressionCreator().CreateExpression(parameters);
        }

        internal protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
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

        internal protected virtual IExpressionCreator GetExpressionCreator()
        {
            var bop=this as IBinaryOperator;
            if (bop!=null)
                return new BinaryExpressionCreator(bop);

            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedFilterElement,
                    GetType().Name
                )
            );
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

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            return CreateExpression(parameters, expectedStaticType, operatorCreator);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }

        private ILog _Logger;
    }
#pragma warning restore 3009
}
