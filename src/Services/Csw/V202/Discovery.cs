using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Gmd=OgcToolkit.Iso.Ts19139.Gmd;
using Ows100=OgcToolkit.Ogc.Ows.V100;
using Filter=OgcToolkit.Ogc.Filter.V110;

namespace OgcToolkit.Services.Csw.V202
{

    public abstract partial class Discovery:
        OgcService,
        IDiscovery
    {

        public Capabilities GetCapabilities(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return GetCapabilities(CreateGetCapabilitiesRequestFromParameters(parameters));
        }

        public Capabilities GetCapabilities(GetCapabilities request)
        {
            CheckGetCapabilitiesRequest(request);

            // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
            // cf. [OGC CITE TEAMEngine csw:csw-2.0.2-GetCapabilities-tc7.1]
            bool returnAll=((request.Content.Sections==null) || request.Content.Sections.Section.Contains("All"));

            var ret=new Capabilities();
            ret.Filter_Capabilities=CreateCapabilitiesFilterCapabilitiesSection();

            if (returnAll || (request.Content.Sections.Section.Contains("OperationsMetadata")))
            {
                Ows100.OperationsMetadata om=CreateCapabilitiesOperationsMetadataSection();
                if (om!=null)
                    ret.Content.OperationsMetadata=om;
            }

            if (returnAll || (request.Content.Sections.Section.Contains("ServiceProvider")))
                ret.Content.ServiceProvider=CreateCapabilitiesServiceProviderSection();

            if (returnAll || (request.Content.Sections.Section.Contains("ServiceIdentification")))
                ret.Content.ServiceIdentification=CreateCapabilitiesServiceIdentificationSection();

            ret.Content.version=Version;
            return ret;
        }

        public GetRecordsResponse GetRecords(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return GetRecords(CreateGetRecordsRequestFromParameters(parameters));
        }

        public GetRecordsResponse GetRecords(GetRecords request)
        {
            throw new NotImplementedException();
        }

        public DescribeRecordResponse DescribeRecord(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return DescribeRecord(CreateDescribeRecordRequestFromParameters(parameters));
        }

        public DescribeRecordResponse DescribeRecord(DescribeRecord request)
        {
            CheckDescribeRecordRequest(request);

            var response=_ProcessDescribeRecord(request);

            var args=new Ows.OwsRequestEventArgs<DescribeRecord, DescribeRecordResponse>(request, response);
            OnProcessDescribeRecord(args);

            Debug.Assert(args.Response!=null);

            return args.Response;
        }

        public GetDomainResponse GetDomain(GetDomain request)
        {
            throw new NotImplementedException();
        }

        public GetRecordByIdResponse GetRecordById(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            var request=new GetRecordById()
            {

            };

            return GetRecordById(request);
        }

        public GetRecordByIdResponse GetRecordById(GetRecordById request)
        {
            CheckRequest(request);

            throw new NotImplementedException();
        }

        private static XDocument GetRecordSchema(XNamespace ns)
        {
            using (var sr=new StringReader(Schemas.ResourceManager.GetString(GetResourceNameFromNamespace(ns.NamespaceName), Schemas.Culture)))
                return XDocument.Load(sr);
        }

        internal static string GetResourceNameFromNamespace(string @namespace)
        {
            return _InvalidFileNameCharsRegEx.Replace(@namespace, "_");
        }

        protected override string ServiceName
        {
            get { return Service; }
        }

        protected override string ServiceVersion
        {
            get { return Version; }
        }

        protected abstract string ProviderName { get; }

        protected static readonly Uri XmlSchemaLanguageUri=new Uri(XmlSchemaNamespace);
        protected static readonly Uri StrangeXmlSchemaLanguageUri=new Uri("http://www.w3.org/XML/Schema");

        protected const string ConstraintParameter="constraint";
        protected const string ConstraintLanguageParameter="constraintlanguage";
        protected const string ElementNameParameter="elementname";
        protected const string ElementSetNameParameter="elementsetname";
        protected const string MaxRecordsParameter="maxrecords";
        protected const string NamespaceParameter="namespace";
        protected const string OutputFormatParameter="outputformat";
        protected const string OutputSchemaParameter="outputschema";
        protected const string RequestIdParameter="requestid";
        protected const string ResultTypeParameter="resulttype";
        protected const string StartPositionParameter="startposition";
        protected const string TypeNameParameter="typename";
        protected const string TypeNamesParameter="typenames";
        protected const string SchemaLanguageParameter="schemalanguage";

        private static readonly Regex _NamespacesRegEx=new Regex(@"^xmlns\(((?<PREFIX>\w+)=)?(?<URL>.+)\)$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
        private static readonly Regex _InvalidFileNameCharsRegEx=new Regex(@"\W", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static readonly IXMetaData[] _SupportedRecordTypesInstances=new IXMetaData[] { new Record(), new Gmd.MD_Metadata() };

        public const string Service="CSW";
        public const string Version="2.0.2";
    }
}
