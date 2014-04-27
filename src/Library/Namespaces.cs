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
using System.Text;

namespace GeoSik
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Holds the URLs of several standard XML namespaces.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public static class Namespaces
    {

        /// <summary><c>"http://purl.org/dc/elements/1.1/"</c></summary>
        public const string DublinCoreElementsV11="http://purl.org/dc/elements/1.1/";
        /// <summary><c>"http://purl.org/dc/terms/"</c></summary>
        public const string DublinCoreTerms="http://purl.org/dc/terms/";
        /// <summary><c>"http://www.isotc211.org/2005/gmd"</c></summary>
        public const string IsoTs19139Gmd="http://www.isotc211.org/2005/gmd";
        /// <summary><c>"http://www.opengis.net/cat/csw/2.0.2"</c></summary>
        public const string OgcWebCatalogCswV202="http://www.opengis.net/cat/csw/2.0.2";
        /// <summary><c>"http://www.opengis.net/ogc"</c></summary>
        public const string OgcFilterV110="http://www.opengis.net/ogc";
        /// <summary><c>"http://www.opengis.net/gml"</c></summary>
        public const string OgcGml="http://www.opengis.net/gml";
        /// <summary><c>"http://www.opengis.net/ow"</c></summary>
        public const string OgcOws="http://www.opengis.net/ows";
        /// <summary><c>"http://www.w3.org/1999/xlink"</c></summary>
        public const string XLinkNamespace="http://www.w3.org/1999/xlink";
        /// <summary><c>"http://www.w3.org/2001/XMLSchema"</c></summary>
        public const string XmlSchemaNamespace="http://www.w3.org/2001/XMLSchema";
        /// <summary><c>"http://www.w3.org/XML/Schema"</c></summary>
        public const string StrangeXmlSchemaNamespace="http://www.w3.org/XML/Schema";
    }
}
