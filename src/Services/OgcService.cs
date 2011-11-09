﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.ServiceModel.Web;
using Common.Logging;

namespace OgcToolkit.Services
{

    public abstract class OgcService
    {

        public OgcService()
        {
            RequestCulture=CultureInfo.CurrentCulture;
            _Logger=LogManager.GetCurrentClassLogger();
        }

        protected void CheckRequest(Ows.IRequest request)
        {
            Debug.Assert(request!=null);
            if (request==null)
                throw new ArgumentNullException("request");

            if (request.Service!=ServiceName)
                throw new OwsException(OwsExceptionCode.NoApplicableCode);

            if (request.Version!=ServiceVersion)
                throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);
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

        protected abstract string ServiceName { get; }
        protected abstract string ServiceVersion { get; }

        private ILog _Logger;

        protected static readonly string[] XmlMimeTypes=new string[] { "application/xml", "text/xml" };

        internal const string RequestParameter="request";
        internal const string ServiceParameter="service";
        internal const string VersionParameter="version";
        internal const string AcceptVersionsParameter="acceptversions";
        internal const string SectionsParameter="sections";
    }
}
