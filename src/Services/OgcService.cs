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

    public abstract class OgcService
    {

        protected OgcService()
        {
            RequestCulture=CultureInfo.CurrentCulture;
            _Logger=LogManager.GetCurrentClassLogger();
        }

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

        internal protected string ToTraceString(IXmlSerializable xml)
        {
            var sb=new StringBuilder();
            using (var xw=XmlWriter.Create(sb))
                xml.WriteXml(xw);
            return sb.ToString();
        }

        public CultureInfo RequestCulture
        {
            get;
            set;
        }

        protected ILog Logger
        {
            get
            {
                return _Logger;
            }
        }

        internal protected ILog InternalLogger
        {
            get
            {
                return _Logger;
            }
        }

        public abstract string ServiceName { get; }
        public abstract string ServiceVersion { get; }

        private ILog _Logger;

        protected static readonly string[] XmlMimeTypes=new string[] { "application/xml", "text/xml" };

        internal const string RequestParameter="request";
        internal const string ServiceParameter="service";
        internal const string VersionParameter="version";
        internal const string AcceptVersionsParameter="acceptversions";
        internal const string SectionsParameter="sections";
    }
}
