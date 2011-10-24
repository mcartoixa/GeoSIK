using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services
{

    public abstract class OgcService
    {

        protected virtual void CheckParameters(IOwsRequest request)
        {
            if (request.Service!=ServiceName)
                throw new OwsException(OwsExceptionCode.NoApplicableCode);

            if (request.Version!=ServiceVersion)
                throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);
        }

        protected abstract string ServiceName { get; }
        protected abstract string ServiceVersion { get; }

        protected static readonly string[] XmlMimeTypes=new string[] { "application/xml", "text/xml" };

        internal const string RequestParameter="request";
        internal const string ServiceParameter="service";
        internal const string VersionParameter="version";
        internal const string AcceptVersionsParameter="acceptversions";
        internal const string SectionsParameter="sections";

        protected const string XmlSchemaNamespace="http://www.w3.org/2001/XMLSchema";
    }
}
