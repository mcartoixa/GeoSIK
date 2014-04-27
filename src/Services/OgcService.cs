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
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using Common.Logging;

namespace GeoSik.Ogc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Base implementation of an OWS service.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public abstract class OgcService
    {

        /// <summary>Creates a new instance of the <see cref="OgcService" /> type.</summary>
        protected OgcService()
        {
            RequestCulture=CultureInfo.CurrentCulture;
            _Logger=LogManager.GetCurrentClassLogger();
        }

        /// <summary>Basic checks for a standard request.</summary>
        /// <param name="request">The request to check.</param>
        internal protected void CheckRequest(Ows.IRequest request)
        {
            Debug.Assert(request!=null);
            if (request==null)
                throw new ArgumentNullException("request");

            if (request.Service!=ServiceName)
                throw new Ows.OwsException(Ows.OwsExceptionCode.NoApplicableCode);

            if (request.Version!=ServiceVersion)
                throw new Ows.OwsException(Ows.OwsExceptionCode.VersionNegotiationFailed);
        }

        /// <summary>Transforms the specified type into a string that is fit to be traced.</summary>
        /// <param name="xml">The type to transform.</param>
        /// <returns>The string.</returns>
        internal protected static string ToTraceString(IXmlSerializable xml)
        {
            var sb=new StringBuilder();
            using (var xw=XmlWriter.Create(sb))
                xml.WriteXml(xw);
            return sb.ToString();
        }

        /// <summary>Gets or sets the <see cref="CultureInfo" /> for the current service.</summary>
        public CultureInfo RequestCulture
        {
            get;
            set;
        }

        /// <summary>Gets a logger for the current service.</summary>
        protected ILog Logger
        {
            get
            {
                return _Logger;
            }
        }

        /// <summary>Gets a logger for the current service.</summary>
        internal protected ILog InternalLogger
        {
            get
            {
                return _Logger;
            }
        }

        /// <summary>Gets the standard name of the current service.</summary>
        public abstract string ServiceName { get; }
        /// <summary>Gets the standard version of the current service.</summary>
        public abstract string ServiceVersion { get; }

        private ILog _Logger;

        /// <summary>An array of standard mime types for XML content.</summary>
        protected static readonly string[] XmlMimeTypes=new string[] { "application/xml", "text/xml" };

        internal const string RequestParameter="request";
        internal const string ServiceParameter="service";
        internal const string VersionParameter="version";
        internal const string AcceptVersionsParameter="acceptversions";
        internal const string SectionsParameter="sections";
    }
}
