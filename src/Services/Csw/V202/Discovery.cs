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
            return CreateGetCapabilitiesProcessor().Process(parameters);
        }

        public Capabilities GetCapabilities(GetCapabilities request)
        {
            return CreateGetCapabilitiesProcessor().Process(request);
        }

        public DescribeRecordResponse DescribeRecord(NameValueCollection parameters)
        {
            return CreateDescribeRecordProcessor().Process(parameters);
        }

        public DescribeRecordResponse DescribeRecord(DescribeRecord request)
        {
            return CreateDescribeRecordProcessor().Process(request);
        }

        public IGetRecordsResponse GetRecords(NameValueCollection parameters)
        {
            return CreateGetRecordsProcessor().Process(parameters);
        }

        public IGetRecordsResponse GetRecords(GetRecords request)
        {
            return CreateGetRecordsProcessor().Process(request);
        }

        public GetDomainResponse GetDomain(GetDomain request)
        {
            throw new NotImplementedException();
        }

        public GetRecordByIdResponse GetRecordById(NameValueCollection parameters)
        {
            return CreateGetRecordByIdProcessor().Process(parameters);
        }

        public GetRecordByIdResponse GetRecordById(GetRecordById request)
        {
            return CreateGetRecordByIdProcessor().Process(request);
        }

        protected virtual GetCapabilitiesProcessorBase CreateGetCapabilitiesProcessor()
        {
            return new GetCapabilitiesProcessorBase(this);
        }

        protected virtual DescribeRecordProcessorBase CreateDescribeRecordProcessor()
        {
            return new DescribeRecordProcessorBase(this);
        }

        protected virtual GetRecordsProcessorBase CreateGetRecordsProcessor()
        {
            return new GetRecordsProcessorBase(this);
        }

        protected virtual GetRecordByIdProcessorBase CreateGetRecordByIdProcessor()
        {
            return new GetRecordByIdProcessorBase(this);
        }

        protected abstract IQueryable GetRecordsSource(Uri outputSchema);

        public virtual IEnumerable<IXMetaData> SupportedRecordTypes
        {
            get
            {
                return _SupportedRecordTypesInstances;
            }
        }

        protected virtual IOperatorImplementationProvider GetOperatorImplementationProvider()
        {
            return null;
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

        internal static XName GetXmlNameFromString(string value, XElement parent)
        {
            Debug.Assert(parent!=null);
            if (parent==null)
                throw new ArgumentNullException("parent");

            string[] ne=value.Split(new char[] { ':' }, 2);
            string name=ne[0];
            if (ne.Length>1)
            {
                name=ne[1];
                XNamespace @namespace=parent.GetNamespaceOfPrefix(ne[0]);
                if (@namespace==null)
                    throw new XmlException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.CouldNotFindNamespaceFromPrefix,
                            ne[0]
                        )
                    );

                return XName.Get(name, @namespace.NamespaceName);
            }

            return XName.Get(name);
        }

        public override string ServiceName
        {
            get { return Service; }
        }

        public override string ServiceVersion
        {
            get { return Version; }
        }

        public abstract string ProviderName { get; }

        protected static readonly Uri XmlSchemaLanguageUri=new Uri(Namespaces.XmlSchemaNamespace);
        protected static readonly Uri StrangeXmlSchemaLanguageUri=new Uri(Namespaces.StrangeXmlSchemaNamespace);

        protected const string ConstraintParameter="constraint";
        protected const string ConstraintLanguageParameter="constraintlanguage";
        protected const string DistributedSearchParameter="distributedsearch";
        protected const string ElementNameParameter="elementname";
        protected const string ElementSetNameParameter="elementsetname";
        protected const string HopCountParameter="hopcount";
        protected const string IdParameter="id";
        protected const string MaxRecordsParameter="maxrecords";
        protected const string NamespaceParameter="namespace";
        protected const string OutputFormatParameter="outputformat";
        protected const string OutputSchemaParameter="outputschema";
        protected const string RequestIdParameter="requestid";
        protected const string ResponseHandlerParameter="responsehandler";
        protected const string ResultTypeParameter="resulttype";
        protected const string SchemaLanguageParameter="schemalanguage";
        protected const string SortByParameter="sortby";
        protected const string StartPositionParameter="startposition";
        protected const string TypeNameParameter="typename";
        protected const string TypeNamesParameter="typenames";

        private static readonly Regex _NamespacesRegEx=new Regex(@"^xmlns\(((?<PREFIX>\w+)=)?(?<URL>.+)\)$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
        private static readonly Regex _InvalidFileNameCharsRegEx=new Regex(@"\W", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static readonly IXMetaData[] _SupportedRecordTypesInstances=new IXMetaData[] { new Record() };

        public const string Service="CSW";
        public const string Version="2.0.2";
    }
}
