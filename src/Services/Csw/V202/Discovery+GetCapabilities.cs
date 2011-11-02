using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Filter=OgcToolkit.Ogc.Filter.V110;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Csw.V202
{

    partial class Discovery
    {

        protected virtual GetCapabilities CreateGetCapabilitiesRequestFromParameters(NameValueCollection parameters)
        {
            var request=new GetCapabilities();

            string[] versions=parameters.GetValues(AcceptVersionsParameter);
            if (versions!=null)
            {
                IList<string> ver=string.Join(",", versions).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                if (ver.Count>0)
                    request.Content.AcceptVersions=new Ows100.AcceptVersionsType()
                    {
                        Version=ver
                    };
            }

            // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
            // cf. [Test csw:csw-2.0.2-GetCapabilities-tc7.1]
            string[] sections=parameters.GetValues(SectionsParameter);
            if (sections!=null)
            {
                IList<string> sec=string.Join(",", sections).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                request.Content.Sections=new Ows100.SectionsType()
                {
                    Section=sec
                };
            }

            return request;
        }

        protected virtual void CheckGetCapabilitiesRequest(GetCapabilities request)
        {
            // [OCG 05-008 §7.3.2]
            if ((request.Content.AcceptVersions!=null) && (!request.Content.AcceptVersions.Version.Contains(Version)))
                throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);
        }

        protected virtual void OnGetCapabilities()
        {

        }

        protected virtual Filter.Filter_Capabilities CreateCapabilitiesFilterCapabilitiesSection()
        {
            var ret=new Filter.Filter_Capabilities() {
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
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"gml", "http://www.opengis.net/gml")
            );

            return ret;
        }

        protected virtual Ows100.OperationsMetadata CreateCapabilitiesOperationsMetadataSection()
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
                //TODO: Namespaces are hard coded there...
                describeRecord.Untyped.Add(
                    new XAttribute(XNamespace.Xmlns+"csw", "http://www.opengis.net/cat/csw/2.0.2"),
                    new XAttribute(XNamespace.Xmlns+"gmd", "http://www.isotc211.org/2005/gmd")
                );
                describeRecord.Parameter=new Ows100.DomainType[] {
                    new Ows100.DomainType() {
                        name=TypeNameParameter,
                        Value=_SupportedRecordTypesInstances
                            .Select<IXMetaData, string>(
                                m => string.Concat(describeRecord.Untyped.GetPrefixOfNamespace(m.SchemaName.Namespace), ":", m.GetType().Name)
                            ).ToList<string>()
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
                return new Ows100.OperationsMetadata() {
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

            return null;
        }

        protected virtual Ows100.ServiceProvider CreateCapabilitiesServiceProviderSection()
        {
            return new Ows100.ServiceProvider() {
                ProviderName=ProviderName/*,
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
                }*/
            };
        }

        protected virtual Ows100.ServiceIdentification CreateCapabilitiesServiceIdentificationSection()
        {
            return new Ows100.ServiceIdentification() {
                ServiceType=new Ows100.CodeType() {
                    TypedValue=ServiceName
                },
                ServiceTypeVersion=new string[] { Version },
                Title=new Ows100.Title() {
                    TypedValue=string.Concat(ProviderName, " ", ServiceName)
                },
                Abstract=new Ows100.Abstract() {
                    TypedValue=string.Format(
                        CultureInfo.CurrentCulture,
                        "A catalogue service that conforms to the OpenGIS Catalogue Service specification version {0}.",
                        ServiceVersion
                    )
                },
                Keywords=new Ows100.Keywords[] {
                        new Ows100.Keywords() {
                            Keyword=new string[] { ServiceName, ProviderName, "geospatial", "catalog" }
                        }
                    }
            };
        }

        protected abstract IEnumerable<OwsEndPoint> GetEndPoints();

        private Ows100.Operation CreateOperation(string operationName, IEnumerable<OwsEndPoint> endPoints)
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
    }
}
