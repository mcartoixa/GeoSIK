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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Not
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Type st=typeof(bool);
            Expression subexpr=null;
            if (logicOps!=null)
                subexpr=((IExpressionBuilder)logicOps).CreateExpression(parameters, st);
            else if (comparisonOps!=null)
                subexpr=((IExpressionBuilder)comparisonOps).CreateExpression(parameters, st);
            else if (spatialOps!=null)
                subexpr=((IExpressionBuilder)spatialOps).CreateExpression(parameters, st);
            else if (Function!=null)
                subexpr=((IExpressionBuilder)Function).CreateExpression(parameters, st);

            if (subexpr==null)
                throw new InvalidOperationException("Invalid binary logical operator content");

            return Expression.Not(subexpr);
        }
    }
#pragma warning restore 3009
}
