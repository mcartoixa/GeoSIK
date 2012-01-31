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
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
using Xml.Schema.Linq;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;

namespace OgcToolkit.Ogc.Filter.V110
{

    /// <summary>Interface implemented by a unary logical operator.</summary>
    public interface IUnaryLogicalOperator:
        IExpressionBuilder
    {

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="comparison", Justification="Interface to be implemented by generated code")]
        comparisonOps comparisonOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="spatial", Justification="Interface to be implemented by generated code")]
        spatialOps spatialOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId="logic", Justification="Interface to be implemented by generated code")]
        logicOps logicOps { get; }
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId="Function", Justification="Interface to be implemented by generated code")]
        Function Function { get; }

        LinqExpressionType OperatorExpressionType { get; }
    }

}
