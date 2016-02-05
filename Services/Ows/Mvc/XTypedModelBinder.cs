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
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using Xml.Schema.Linq;

namespace GeoSik.Ogc.Ows.Mvc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Model binder that handles <see cref="XTypedElement" /> instances.</summary>
    /// <typeparam name="TXTypedElement">THe specific type to bind.</typeparam>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class XTypedModelBinder<TXTypedElement>:
        IModelBinder
        where TXTypedElement:
            XTypedElement,
            new()
    {

        /// <summary>Binds the model to a value by using the specified controller context and binding context.</summary>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="bindingContext">The binding context.</param>
        /// <returns>The bound value.</returns>
        public TXTypedElement BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            using (var reader=new StreamReader(controllerContext.HttpContext.Request.InputStream))
                return XTypedServices.Load<TXTypedElement>(reader);
        }

        /// <summary>Binds the model to a value by using the specified controller context and binding context.</summary>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="bindingContext">The binding context.</param>
        /// <returns>The bound value.</returns>
        object IModelBinder.BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return BindModel(controllerContext, bindingContext);
        }
    }
}
