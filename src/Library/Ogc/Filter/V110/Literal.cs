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
using System.Xml.XPath;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Literal
    {

        internal protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            Expression ret=null;

            if (expectedStaticType!=null)
            {
                object value=Untyped.Value;

                // Convert the string to the expectedStaticType
                switch (Type.GetTypeCode(expectedStaticType))
                {
                case TypeCode.Boolean:
                    value=XmlConvert.ToBoolean(Untyped.Value);
                    break;
                case TypeCode.Byte:
                    value=XmlConvert.ToByte(Untyped.Value);
                    break;
                case TypeCode.Char:
                    value=XmlConvert.ToChar(Untyped.Value);
                    break;
                case TypeCode.DateTime:
                    value=XmlConvert.ToDateTime(Untyped.Value, XmlDateTimeSerializationMode.RoundtripKind);
                    break;
                case TypeCode.Decimal:
                    value=XmlConvert.ToDecimal(Untyped.Value);
                    break;
                case TypeCode.Double:
                    value=XmlConvert.ToDouble(Untyped.Value);
                    break;
                case TypeCode.Int16:
                    value=XmlConvert.ToInt16(Untyped.Value);
                    break;
                case TypeCode.Int32:
                    value=XmlConvert.ToInt32(Untyped.Value);
                    break;
                case TypeCode.Int64:
                    value=XmlConvert.ToInt64(Untyped.Value);
                    break;
                case TypeCode.SByte:
                    value=XmlConvert.ToSByte(Untyped.Value);
                    break;
                case TypeCode.Single:
                    value=XmlConvert.ToSingle(Untyped.Value);
                    break;
                case TypeCode.String:
                    // We are already there
                    break;
                case TypeCode.UInt16:
                    value=XmlConvert.ToUInt16(Untyped.Value);
                    break;
                case TypeCode.UInt32:
                    value=XmlConvert.ToUInt32(Untyped.Value);
                    break;
                case TypeCode.UInt64:
                    value=XmlConvert.ToUInt64(Untyped.Value);
                    break;
                default:
                    if (expectedStaticType==typeof(DateTimeOffset))
                    {
                        value=XmlConvert.ToDateTimeOffset(Untyped.Value);
                    } else
                        // Last resort conversion
                        value=Convert.ChangeType(Untyped.Value, expectedStaticType, CultureInfo.InvariantCulture);
                    break;
                }

                ret=Expression.Constant(value, expectedStaticType);
            }

            if (ret==null)
            {
                Logger.Info(m => m("The literal \"{0}\" will be interpreted as a string by default", Untyped.Value));
                ret=Expression.Constant(Untyped.Value);
            }

            if (operatorCreator!=null)
                return operatorCreator(ret);

            return ret;
        }

        internal protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            // Cannot decide at this time
            return null;
        }
    }
#pragma warning restore 3009
}
