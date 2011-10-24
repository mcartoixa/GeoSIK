using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using Ows100=OgcToolkit.Ogc.Ows.V100;
using Filter=OgcToolkit.Ogc.Filter.V110;

namespace OgcToolkit.Services.Csw.V202
{

    [OwsDescription(Discovery.Service, Discovery.Version)]
    public class Discovery:
        OgcService,
        IDiscovery
    {

        public Capabilities GetCapabilities(NameValueCollection parameters)
        {
            var request=new GetCapabilities();

            string[] versions=parameters.GetValues(AcceptVersionsParameter);
            if (versions!=null)
            {
                IList<string> ver=string.Join(",", versions).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                if (ver.Count>0)
                    request.Content.AcceptVersions=new Ows100.AcceptVersionsType() {
                        Version=ver
                }   ;
            }

            // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
            // cf. [Test csw:csw-2.0.2-GetCapabilities-tc7.1]
            string[] sections=parameters.GetValues(SectionsParameter);
            if (sections!=null)
            {
                IList<string> sec=string.Join(",", sections).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                request.Content.Sections=new Ows100.SectionsType() {
                    Section=sec
                };
            }

            return GetCapabilities(request);
        }

        public Capabilities GetCapabilities(GetCapabilities request)
        {
            // [OCG 05-008 §7.3.2]
            if ((request.Content.AcceptVersions!=null) && (!request.Content.AcceptVersions.Version.Contains(Version)))
                throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);

            // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
            // cf. [Test csw:csw-2.0.2-GetCapabilities-tc7.1]
            bool returnAll=((request.Content.Sections==null) || request.Content.Sections.Section.Contains("All"));

            var ret=new Capabilities();
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"gml", "http://www.opengis.net/gml")
            );

            ret.Filter_Capabilities=new Filter.Filter_Capabilities() {
                Id_Capabilities=new Filter.Id_CapabilitiesType() {
                    EID=new Filter.EID[] {
                        new Filter.EID()
                    }
                },
                Scalar_Capabilities=new Filter.Scalar_CapabilitiesType() {
                    ComparisonOperators=new Filter.ComparisonOperatorsType() {
                        ComparisonOperator=new string[] {
                            "LessThan",
                            "GreaterThan",
                            "LessThanEqualTo",
                            "GreaterThanEqualTo",
                            "EqualTo",
                            "NotEqualTo",
                            "Like"
                        }
                    },
                    LogicalOperators=new Filter.LogicalOperators()
                },
                Spatial_Capabilities=new Filter.Spatial_CapabilitiesType() {
                    GeometryOperands=new Filter.GeometryOperandsType() {
                        GeometryOperand=new string[] {
                            "gml:Envelope"
                        }
                    },
                    SpatialOperators=new Filter.SpatialOperatorsType() {
                        SpatialOperator=new Filter.SpatialOperatorType[] { new Filter.SpatialOperatorType() { name="BBOX" } }
                    }
                }
            };

            if (returnAll || (request.Content.Sections.Section.Contains("OperationsMetadata")))
            {
                var operations=new List<Ows100.Operation>();

                Ows100.Operation getCapabilities=CreateOperation("GetCapabilities", GetEndPoints());
                if (getCapabilities!=null)
                {
                    getCapabilities.Parameter=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name=SectionsParameter,
                            Value=new string[] { "ServiceIdentification", "ServiceProvider", "OperationsMetadata", "Filter_Capabilities" }
                        }
                    };
                    operations.Add(getCapabilities);
                }

                Ows100.Operation describeRecord=CreateOperation("DescribeRecord", GetEndPoints());
                if (describeRecord!=null)
                {
                    ret.Untyped.Add(
                        new XAttribute(XNamespace.Xmlns+"csw", "http://www.opengis.net/cat/csw")
                    );
                    describeRecord.Parameter=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name=TypeNameParameter,
                            Value=_SupportedRecordTypes.Select<Type, string>(t => string.Concat("csw:", t.Name)).ToList<string>()
                        }
                    };
                    operations.Add(describeRecord);
                }

                Ows100.Operation getRecords=CreateOperation("GetRecords", GetEndPoints());
                if (getRecords!=null)
                {

                    operations.Add(getRecords);
                }


                if (operations.Count>0)
                    ret.Content.OperationsMetadata=new Ows100.OperationsMetadata() {
                        Operation=operations/*,
                        Parameter=new Ows.DomainType[] {
                            new Ows.DomainType() {
                                name=OgcService.ServiceParameter,
                                Value=new string[] { Service }
                            },
                            new Ows.DomainType() {
                                name=OgcService.VersionParameter,
                                Value=new string[] { Version }
                            }
                        }*/
                    };
            }

            if (returnAll || (request.Content.Sections.Section.Contains("ServiceProvider")))
                ret.Content.ServiceProvider=new Ows100.ServiceProvider() {
                    ProviderName="Isogeo",
                    ProviderSite=new Ows100.OnlineResourceType() {
                        href=new Uri("http://www.isogeo.fr/")
                    },
                    ServiceContact=new Ows100.ResponsiblePartySubsetType() {
                        ContactInfo=new Ows100.ContactInfo() {
                            Address=new Ows100.AddressType() {
                                City="Paris",
                                Country="France",
                                ElectronicMailAddress=new string[] { "mathieu.cartoixa@isogeo.fr" },
                                PostalCode="75017"
                            }
                        }
                    }
                };

            if (returnAll || (request.Content.Sections.Section.Contains("ServiceIdentification")))
                ret.Content.ServiceIdentification=new Ows100.ServiceIdentification() {

                    ServiceType=new Ows100.CodeType() {
                        TypedValue=Service
                    },
                    ServiceTypeVersion=new string[] { Version },
                    Title=new Ows100.Title() {
                        TypedValue=string.Concat("Isogeo", " ", Service)
                    },
                    Abstract=new Ows100.Abstract() {
                        TypedValue=string.Format(
                            CultureInfo.CurrentCulture,
                            "A catalogue service that conforms to the OpenGIS Catalogue Service specification version {0}.",
                            Version
                        )
                    },
                    Keywords=new Ows100.Keywords[] {
                        new Ows100.Keywords() {
                            Keyword=new string[] { Service, "Isogeo", "geospatial", "catalog" }
                        }
                    }
                };

            ret.Content.version=Version;
            return ret;
        }


        public GetRecordsResponse GetRecords(GetRecords request)
        {
            throw new NotImplementedException();
        }

        public DescribeRecordResponse DescribeRecord(NameValueCollection parameters)
        {
            var request=new DescribeRecord();

            // [OCG 07-006r1 §10.6.4.1]
            string[] namespaces=parameters.GetValues(NamespaceParameter);
            if (namespaces!=null)
            {
                IList<string> nspList=string.Join(",", namespaces).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                foreach (string nsp in nspList)
                    if (!string.IsNullOrEmpty(nsp))
                    {
                        Match m=_NamespacesRegEx.Match(nsp);
                        if (!m.Success)
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                                Locator=NamespaceParameter
                            };

                        request.Untyped.Add(
                            new XAttribute(XNamespace.Xmlns+m.Groups["PREFIX"].Value, m.Groups["URL"])
                        );
                    }
            }

            // [OCG 07-006r1 §10.6.4.2]
            string[] typeNames=parameters.GetValues(TypeNameParameter);
            if (typeNames!=null)
            {
                IList<string> tnp=string.Join(",", typeNames).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                var rtn=new List<XmlQualifiedName>(tnp.Count);
                foreach (string tn in tnp)
                {
                    string[] nameElements=tn.Split(new char[] { ':' }, 2);
                    if (nameElements.Length>1)
                        rtn.Add(new XmlQualifiedName(nameElements[0], nameElements[1]));
                    else
                        rtn.Add(new XmlQualifiedName(nameElements[0]));
                }
                request.Content.TypeName=rtn;
            }

            // [OCG 07-006r1 §10.6.4.3]
            string outputFormat=parameters[OutputFormatParameter];
            if (!string.IsNullOrEmpty(outputFormat))
                request.outputFormat=outputFormat;

            // [OCG 07-006r1 §10.6.4.4]
            string schemaLanguage=parameters[SchemaLanguageParameter];
            if (!string.IsNullOrEmpty(schemaLanguage))
                try
                {
                    request.schemaLanguage=new Uri(schemaLanguage);
                } catch (UriFormatException ufex)
                {
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                        Locator=SchemaLanguageParameter
                    };
                }

            return DescribeRecord(request);
        }

        public DescribeRecordResponse DescribeRecord(DescribeRecord request)
        {
            CheckParameters(request);

            if ((request.outputFormat!=null) && (Array.IndexOf<string>(XmlMimeTypes, request.outputFormat)<0))
                throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                    Locator=OutputFormatParameter
                };

            // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default...
            Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
            if ((request.schemaLanguage!=null) && (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
                throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                    Locator=SchemaLanguageParameter
                };

            // We will use the 'csw' prefix
            var ret=new DescribeRecordResponse();
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"csw", "http://www.opengis.net/cat/csw/2.0.2")
            );

            // Get the names of record types
            List<string> names=_SupportedRecordTypes.Select<Type, string>(t => t.Name).ToList<string>();
            if ((request.TypeName!=null) && (request.TypeName.Count>0))
            {
                names.Clear();

                // Type names cannot be retrieved as XmlQualifiedName: there are prefixes instead of namespaces
                // So we take the long way via XElement
                var typeNamesElements=from el in request.Untyped.Descendants()
                              where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}TypeName"
                              select el;
                foreach (XElement tne in typeNamesElements)
                {
                    string[] tn=tne.Value.Split(new char[] { ':' }, 2);
                    string name=tn[0];
                    if (tn.Length>1)
                    {
                        name=tn[1];
                        // Our supported types belong to the CSW namespace
                        if (tne.GetNamespaceOfPrefix(tn[0])!="http://www.opengis.net/cat/csw/2.0.2")
                            break;
                    } else
                        // Our supported types belong to the CSW namespace
                        if (tne.GetDefaultNamespace()!="http://www.opengis.net/cat/csw/2.0.2")
                            break;

                    // Check the name is a supported type
                    if (!_SupportedRecordTypes.Any<Type>(t => t.Name==name))
                        break;

                    names.Add(name);
                }
            }

            // Create the csw:schemaComponents
            var componentTypes=new List<SchemaComponentType>(request.TypeName.Count);
            foreach (string name in names)
            {
                var recordComponentType=new SchemaComponentType() {
                    schemaLanguage=XmlSchemaLanguageUri,
                    targetNamespace=new Uri("http://www.opengis.net/cat/csw/2.0.2"),
                    parentSchema=new Uri("http://www.opengis.net/cat/csw/2.0.2")
                };
                recordComponentType.Untyped.Add(
                    from el in RecordsSchema.Descendants(string.Format(CultureInfo.InvariantCulture, "{{{0}}}element", XmlSchemaNamespace))
                    where (string)el.Attribute("name")==name
                    select el
                );
                componentTypes.Add(recordComponentType);
            }
            if (componentTypes.Count>0)
                ret.SchemaComponent=componentTypes;

            return ret;
        }

        public GetDomainResponse GetDomain(GetDomain request)
        {
            throw new NotImplementedException();
        }

        public GetRecordByIdResponse GetRecordById(NameValueCollection parameters)
        {
            var request=new GetRecordById()
            {

            };

            return GetRecordById(request);
        }

        public GetRecordByIdResponse GetRecordById(GetRecordById request)
        {
            CheckParameters(request);

            throw new NotImplementedException();
        }

        private static Ows100.Operation CreateOperation(string operationName, IEnumerable<OwsEndPoint> endPoints)
        {
            Ows100.Operation ret=null;

            var getMethods=new List<Ows100.RequestMethodType>();
            var postMethods=new List<Ows100.RequestMethodType>();
            foreach (OwsEndPoint ep in GetEndPoints())
            {
                UriBuilder ub=new UriBuilder(ep.BaseUri);
                if (ep.AddOperationName)
                    ub.Path+=operationName;

                if (ep.Method==OwsMethod.Get)
                {
                    getMethods.Add(
                        new Ows100.RequestMethodType() {
                            href=ub.Uri
                        }
                    );
                } else
                {
                    postMethods.Add(
                        new Ows100.RequestMethodType() {
                            href=ub.Uri,
                            Constraint=new Ows100.DomainType[] {
                                new Ows100.DomainType() {
                                    name="PostEncoding",
                                    Value=new string[] { (ep.Method==OwsMethod.Soap ? "SOAP" : "XML") }
                                }
                            }
                        }
                    );
                }
            }

            if ((getMethods.Count>0) || (postMethods.Count>0))
            {
                ret=new Ows100.Operation() {
                    name=operationName,
                    DCP=new Ows100.DCP[] {
                        new Ows100.DCP() {
                            HTTP=new Ows100.HTTP()
                        }
                    }
                };
                if (getMethods.Count>0)
                    ret.DCP[0].HTTP.Get=getMethods;
                if (postMethods.Count>0)
                    ret.DCP[0].HTTP.Post=postMethods;
            }

            return ret;
        }

        private static IEnumerable<OwsEndPoint> GetEndPoints()
        {
            IEnumerable<OwsEndPoint> ret=new List<OwsEndPoint>();

            var eh=GettingServiceEndPoints;
            if (eh!=null)
            {
                var args=new OwsServiceEndPointsEventArgs();
                eh(null, args);
                ret=args.EndPoints;
            }

            return ret;
        }

        private static XDocument RecordsSchema
        {
            get
            {
                using (var sr=new StringReader(Schemas.record))
                    return XDocument.Load(sr);
            }
        }

        protected override string ServiceName
        {
            get { return Service; }
        }

        protected override string ServiceVersion
        {
            get { return Version; }
        }

        public static event EventHandler<OwsServiceEndPointsEventArgs> GettingServiceEndPoints;

        protected static readonly Uri XmlSchemaLanguageUri=new Uri(XmlSchemaNamespace);
        protected static readonly Uri StrangeXmlSchemaLanguageUri=new Uri("http://www.w3.org/XML/Schema");

        protected const string NamespaceParameter="namespace";
        protected const string TypeNameParameter="typename";
        protected const string SchemaLanguageParameter="schemalanguage";
        protected const string OutputFormatParameter="outputformat";

        private static readonly Regex _NamespacesRegEx=new Regex(@"^xmlns\((?<PREFIX>\w+=)?(?<URL>.+)\)$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
        private static readonly Type[] _SupportedRecordTypes=new Type[] { typeof(BriefRecord), typeof(DCMIRecord), typeof(Record), typeof(SummaryRecord) };

        internal const string Service="CSW";
        internal const string Version="2.0.2";
    }
}
