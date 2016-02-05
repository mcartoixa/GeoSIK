////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
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
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 1591, 3009
    partial class PropertyIsBetween:
        IBinaryLogicalOperator
    {

        internal protected override  IExpressionCreator GetExpressionCreator()
        {
            return new logicOps.BinaryLogicalExpressionCreator(this);
        }

        IList<comparisonOps> IBinaryLogicalOperator.comparisonOps
        {
            get
            {
                return new comparisonOps[] {
                    new PropertyIsGreaterThanOrEqualTo() {
                        expression=new expression[] { expression, LowerBoundary.expression}
                    },
                    new PropertyIsLessThanOrEqualTo() {
                        expression=new expression[] { expression, UpperBoundary.expression}
                    }
                };
            }
        }

        IList<spatialOps> IBinaryLogicalOperator.spatialOps
        {
            get { return new List<spatialOps>(); }
        }

        IList<logicOps> IBinaryLogicalOperator.logicOps
        {
            get { return new List<logicOps>(); }
        }

        IList<Function> IBinaryLogicalOperator.Function
        {
            get { return new List<Function>(); }
        }

        LinqExpressionType IBinaryLogicalOperator.OperatorExpressionType
        {
            get { return LinqExpressionType.And; }
        }
    }
#pragma warning restore 1591, 3009
}
