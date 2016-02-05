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
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using Ows100=GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.Ows.Mvc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>MVC exceptions related extension methods.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public static class ExceptionContextExtensions
    {

        /// <summary>Handles the exception raised in the specified context according to the OWS 1.0.0 specifications.</summary>
        /// <param name="context">The exception context.</param>
        public static void HandleOws100Error(this ExceptionContext context)
        {
            Exception error=context.Exception;

            var aex=error as AggregateException;
            if (aex!=null)
                if (aex.InnerExceptions.Count>1)
                    error=new OwsException(OwsExceptionCode.NoApplicableCode, error);
                else
                    error=aex.InnerExceptions[0];

            if (error is NotImplementedException)
                error=new OwsException(OwsExceptionCode.OperationNotSupported, error);

            var oex=error as OwsException;
            if (oex==null)
                oex=new OwsException(OwsExceptionCode.NoApplicableCode, error);

            context.HttpContext.Response.Clear();
            context.HttpContext.Response.TrySkipIisCustomErrors=true;
            context.Result=new XmlSerializableResult((Ows100.ExceptionReport)oex);

            context.ExceptionHandled=true;
        }

        /// <summary>Handles the exception raised in the specified context according to the OWS 2.0.0 specifications.</summary>
        /// <param name="context">The exception context.</param>
        public static void HandleOws200Error(this ExceptionContext context)
        {
            HandleOws100Error(context);

            OwsException oex=context.Exception as OwsException;

            // [OGC 06-121r9, §8.6]
            var status=HttpStatusCode.InternalServerError;
            switch (oex.Code)
            {
            case OwsExceptionCode.InvalidParameterValue:
            case OwsExceptionCode.InvalidUpdateSequence:
            case OwsExceptionCode.MissingParameterValue:
                status=HttpStatusCode.BadRequest;
                break;
            case OwsExceptionCode.OperationNotSupported:
            case OwsExceptionCode.OptionNotSupported:
                status=HttpStatusCode.NotImplemented;
                break;
            }

            context.HttpContext.Response.StatusCode=(int)status;
        }
    }
}
