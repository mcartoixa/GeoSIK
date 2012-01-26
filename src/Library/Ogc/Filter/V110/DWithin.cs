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

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class DWithin:
        IDistanceBufferOperator
    {

        public Gml.V311._Geometry Geometry
        {
            get
            {
                return _Geometry;
            }
        }

        double IDistanceBufferOperator.Distance
        {
            get
            {
                // TODO: units transformation
                return Distance.TypedValue;
            }
        }

        Func<Expression, Expression, BinaryExpression> IDistanceBufferOperator.OperatorExpression
        {
            get
            {
                return Expression.LessThanOrEqual;
            }
        }
    }
#pragma warning restore 3009
}
