﻿////////////////////////////////////////////////////////////////////////////////
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
using System.Collections.Specialized;
using System.Xml.Serialization;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Types
{

#pragma warning disable 3009
    partial class DescribeRecord:
        Ows.IRequest
    {

        /// <summary>Transforms the current request in a collection of corresponding key-value pairs.</summary>
        /// <returns>The collection of key-value pairs.</returns>
        NameValueCollection Ows.IRequest.ToKeyValuePairs() {
            var ret = new NameValueCollection();

            throw new NotImplementedException();
        }

        /// <summary>Gets the version of this request.</summary>
        [XmlIgnore]
        string Ows.IRequest.Version
        {
            get { return Content.version; }
        }

        /// <summary>Gets the name of the service concerned by this request.</summary>
        [XmlIgnore]
        string Ows.IRequest.Service
        {
            get { return Content.service; }
        }
    }
#pragma warning restore 3009
}
