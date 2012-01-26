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
using System.Text;
using System.Xml;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class logicOps:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var blop=this as IBinaryLogicalOperator;
            if (blop!=null)
            {
                IEnumerable<XTypedElement> elements=blop.GetLogicalElements();

                Type[] subtypes=GetSubExpressionStaticTypes(elements, parameters)
                    .Where<Type>(t => t!=null)
                    .ToArray<Type>();
                //TODO: probably needs more checking on other subtypes there...
                Type st=(subtypes.Length>0 ? subtypes[0]  :null);

                Expression[] subexpr=CreateSubExpressions(elements, parameters, st)
                    .ToArray<Expression>();
                Debug.Assert(subexpr.Length>1);

                Expression ret=blop.OperatorExpression(subexpr[0], subexpr[1]);
                for (int i=2; i<subexpr.Length; ++i)
                    ret=blop.OperatorExpression(ret, subexpr[i]);

                return ret;
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

        private static IEnumerable<Expression> CreateSubExpressions(IEnumerable<XTypedElement> elements, ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            foreach (XTypedElement e in elements)
            {
                var eb=e as IExpressionBuilder;
                if (eb!=null)
                    yield return eb.CreateExpression(parameters, expectedStaticType);
                else
                    throw new NotSupportedException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.UnsupportedFilterElement,
                            e.GetType().Name
                        )
                    );
            }
        }

        private static IEnumerable<Type> GetSubExpressionStaticTypes(IEnumerable<XTypedElement> elements, ExpressionBuilderParameters parameters)
        {
            foreach (XTypedElement e in elements)
            {
                var eb=e as IExpressionBuilder;
                if (eb!=null)
                    yield return eb.GetExpressionStaticType(parameters);
                else
                    throw new NotSupportedException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.UnsupportedFilterElement,
                            e.GetType().Name
                        )
                    );
            }
        }
    }
#pragma warning restore 3009
}
