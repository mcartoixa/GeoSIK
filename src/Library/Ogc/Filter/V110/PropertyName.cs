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
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace GeoSik.Ogc.Filter.V110
{

#pragma warning disable 1591, 3009
    partial class PropertyName
    {

        internal protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, ParameterExpression, Expression> operatorCreator)
        {
            // We only want literals in this case
            if (operatorCreator==null)
                return null;

            return GetNavigator(parameters)
                .CreateExpression(parameters.Parameters[0], expectedStaticType, operatorCreator);
        }

        internal protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetNavigator(parameters).Type;
        }

        private XPathTypeNavigator GetNavigator(ExpressionBuilderParameters parameters)
        {
            if (_Navigator==null)
            {
                XPathTypeNavigator xptn=parameters.CreateNavigator();
                XPathNodeIterator xpni=xptn.Select(Untyped.Value, parameters.NamespaceResolver, true);
                while (xpni.MoveNext())
                    _Navigator=xpni.Current as XPathTypeNavigator;

                Debug.Assert(_Navigator!=null);
                if (_Navigator==null)
                    throw new InvalidOperationException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.InvalidPropertyNameExpressionException,
                            Untyped.Value
                        )
                    );
            }

            return _Navigator;
        }

        private XPathTypeNavigator _Navigator;
    }
#pragma warning restore 1591, 3009
}
