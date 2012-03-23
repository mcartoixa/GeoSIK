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
using GeoSik.Ogc.Ows;
using Ows100=GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.Ows.Mvc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>MVC error handler that conforms to the OWS 1.0.0 specifications.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class HandleOws100ErrorAttribute:
        FilterAttribute,
        IExceptionFilter
    {

        /// <summary>Handles the exception raised in the specified context.</summary>
        /// <param name="filterContext">The exception context.</param>
        protected virtual void OnException(ExceptionContext filterContext)
        {
            filterContext.HandleOws100Error();
        }

        /// <summary>Handles the exception raised in the specified context.</summary>
        /// <param name="filterContext">The exception context.</param>
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            OnException(filterContext);
        }
    }
}
