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
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Not:
        IBinaryLogicalOperator // I know it's not binary, but it should work anyway...
    {

        IList<comparisonOps> IBinaryLogicalOperator.comparisonOps
        {
            get { return comparisonOps!=null ? new comparisonOps[] { comparisonOps } : new comparisonOps[0]; }
        }

        IList<spatialOps> IBinaryLogicalOperator.spatialOps
        {
            get { return spatialOps!=null ? new spatialOps[] { spatialOps } : new spatialOps[0]; }
        }

        IList<logicOps> IBinaryLogicalOperator.logicOps
        {
            get { return logicOps!=null ? new logicOps[] { logicOps } : new logicOps[0]; }
        }

        IList<Function> IBinaryLogicalOperator.Function
        {
            get { return Function!=null ? new Function[] { Function } : new Function[0]; }
        }

        LinqExpressionType IBinaryLogicalOperator.OperatorExpressionType
        {
            get { return LinqExpressionType.Not; }
        }
    }
#pragma warning restore 3009
}
