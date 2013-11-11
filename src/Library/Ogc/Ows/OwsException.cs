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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace GeoSik.Ogc.Ows
{

    /// <summary>An exception that can gracefully be handled by an OGC Web Service.</summary>
    [Serializable]
    public class OwsException:
        Exception
    {

        public OwsException():
            base()
        {}

        public OwsException(string message) :
            base(message)
        { }

        public OwsException(V100.Types.Exception ex):
            this(_GetExceptionCode(ex), _GetExceptionText(ex))
        {
            Debug.Assert(ex!=null);

            Locator=ex.locator;
        }

        public OwsException(OwsExceptionCode code):
            this(code, _GetMessageFromCode(code))
        {}

        public OwsException(OwsExceptionCode code, string message):
            base(string.IsNullOrEmpty(message) ? _GetMessageFromCode(code) : message)
        {
            Data[_CodeKey]=code;
        }

        public OwsException(OwsExceptionCode code, Exception innerException):
            this(code, _GetMessageFromCode(code), innerException)
        {}

        public OwsException(OwsExceptionCode code, string message, Exception innerException):
            base(string.IsNullOrEmpty(message) ? _GetMessageFromCode(code) : message, innerException)
        {
            Data[_CodeKey]=code;
        }

        protected OwsException(SerializationInfo info, StreamingContext context):
            base(info, context)
        {}

        public static explicit operator V100.Types.ExceptionReport(OwsException ex)
        {
            var report=new V100.Types.ExceptionReport() {
                version="1.2.0",
                Exception=new V100.Types.Exception[] {
                    new V100.Types.Exception() { ExceptionText=_GetExceptionText(ex), exceptionCode=ex.Code.ToString(), locator=ex.Locator }
                }
            };

            return report;
        }

        private static IList<string> _GetExceptionText(Exception ex)
        {
            var ret=new List<string>();

            if (ex!=null)
            {
                ret.Add(ex.Message);

                var aex=ex as AggregateException;
                if (aex!=null)
                {
                    var faex=aex.Flatten();
                    foreach (Exception e in faex.InnerExceptions)
                        ret.AddRange(_GetExceptionText(e));
                } else if (ex.InnerException!=null)
                    ret.AddRange(_GetExceptionText(ex.InnerException));
            }

            return ret;
        }

        private static string _GetExceptionText(V100.Types.Exception ex)
        {
            if ((ex==null) || (ex.ExceptionText==null))
                return null;

            return string.Join("\n", ex.ExceptionText);
        }

        private static OwsExceptionCode _GetExceptionCode(V100.Types.Exception ex)
        {
            if ((ex==null) || string.IsNullOrEmpty(ex.exceptionCode))
                return OwsExceptionCode.NoApplicableCode;

            return (OwsExceptionCode)Enum.Parse(typeof(OwsExceptionCode), ex.exceptionCode, false);
        }

        private static string _GetMessageFromCode(OwsExceptionCode code)
        {
            switch (code)
            {
            case OwsExceptionCode.InvalidParameterValue:
                return "Invalid parameter value";
            case OwsExceptionCode.InvalidUpdateSequence:
                return "Invalid update sequence";
            case OwsExceptionCode.MissingParameterValue:
                return "Missing parameter";
            case OwsExceptionCode.OperationNotSupported:
                return "Operation not supported";
            case OwsExceptionCode.OptionNotSupported:
                return "Option not supported";
            case OwsExceptionCode.VersionNegotiationFailed:
                return "Version negotiation failed";
            default:
                return "Internal server error";
            }
        }

        public string Locator
        {
            get
            {
                return Data[_LocatorKey] as string;
            }
            set
            {
                Data[_LocatorKey]=value;
            }
        }

        public OwsExceptionCode Code
        {
            get
            {
                return (OwsExceptionCode)Data[_CodeKey];
            }
        }

        private const string _CodeKey="OwsExceptionCode";
        private const string _LocatorKey="OwsExceptionLocator";
    }

    public enum OwsExceptionCode
    {
        NoApplicableCode=0,
        OperationNotSupported,
        MissingParameterValue,
        InvalidParameterValue,
        VersionNegotiationFailed,
        InvalidUpdateSequence,
        OptionNotSupported
    }
}
