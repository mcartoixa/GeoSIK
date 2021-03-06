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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GeoSik.Ogc.Ows
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Interface implemented by an OWS request.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public interface IRequest :
        IXmlSerializable
    {

        /// <summary>Transforms the current request in a collection of corresponding key-value pairs.</summary>
        /// <returns>The collection of key-value pairs.</returns>
        NameValueCollection ToKeyValuePairs();

        /// <summary>Gets the version of this request.</summary>
        [XmlIgnore]
        string Version { get; }
        /// <summary>Gets the name of the service concerned by this request.</summary>
        [XmlIgnore]
        string Service { get; }
    }
}
