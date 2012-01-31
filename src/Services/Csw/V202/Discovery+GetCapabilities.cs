////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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

        public class GetCapabilitiesProcessorBase:
            OgcRequestProcessor<GetCapabilities, Capabilities>
        {

            public GetCapabilitiesProcessorBase(Discovery service):
                base(service)
            {
            }

            protected override GetCapabilities CreateRequest(NameValueCollection parameters)
            {
                var request=new GetCapabilities();

                string[] versions=parameters.GetValues(AcceptVersionsParameter);
                if (versions!=null)
                {
                    IList<string> ver=string.Join(",", versions).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    if (ver.Count>0)
                        request.Content.AcceptVersions=new Ows100.AcceptVersionsType() {
                            Version=ver
                        };
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

                return request;
            }

            protected override void CheckRequest(GetCapabilities request)
            {
                // Do not do standard checks
                //base.CheckRequest(request);

                // [OCG 05-008 §7.3.2]
                if ((request.Content.AcceptVersions!=null) && (!request.Content.AcceptVersions.Version.Contains(Version)))
                    throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);
            }

            protected override Capabilities ProcessRequest(GetCapabilities request)
            {

                // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
                // cf. [OGC CITE TEAMEngine csw:csw-2.0.2-GetCapabilities-tc7.1]
                bool returnAll=((request.Content.Sections==null) || request.Content.Sections.Section.Contains("All"));

                var ret=new Capabilities();
                ret.Filter_Capabilities=CreateFilterCapabilitiesSection();

                if (returnAll || (request.Content.Sections.Section.Contains("OperationsMetadata")))
                {
                    Ows100.OperationsMetadata om=CreateOperationsMetadataSection();
                    if (om!=null)
                    {
                        ret.Untyped.Add(
                            new XAttribute(XNamespace.Xmlns+"xl", Namespaces.XLinkNamespace)
                        );
                        ret.Content.OperationsMetadata=om;
                    }
                }

                if (returnAll || (request.Content.Sections.Section.Contains("ServiceProvider")))
                {
                    string xl=ret.Untyped.GetPrefixOfNamespace(Namespaces.XLinkNamespace);
                    if (string.IsNullOrEmpty(xl))
                        ret.Untyped.Add(
                            new XAttribute(XNamespace.Xmlns+"xl", Namespaces.XLinkNamespace)
                        );
                    ret.Content.ServiceProvider=CreateServiceProviderSection();
                }

                if (returnAll || (request.Content.Sections.Section.Contains("ServiceIdentification")))
                    ret.Content.ServiceIdentification=CreateServiceIdentificationSection();

                ret.Content.version=Version;
                return ret;
            }


            protected virtual Filter.Filter_Capabilities CreateFilterCapabilitiesSection()
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
                                "gml:Envelope",
                                "gml:Point",
                                "gml:LineString",
                                "gml:Polygon"
                            }
                        },
                        SpatialOperators=new Filter.SpatialOperatorsType() {
                            SpatialOperator=new Filter.SpatialOperatorType[] {
                                new Filter.SpatialOperatorType() { name="BBOX" },
                                new Filter.SpatialOperatorType() { name="Equals" },
                                new Filter.SpatialOperatorType() { name="Disjoint" },
                                new Filter.SpatialOperatorType() { name="Touches" },
                                new Filter.SpatialOperatorType() { name="Within" },
                                new Filter.SpatialOperatorType() { name="Overlaps" },
                                new Filter.SpatialOperatorType() { name="Crosses" },
                                new Filter.SpatialOperatorType() { name="Intersects" },
                                new Filter.SpatialOperatorType() { name="Contains" },
                                new Filter.SpatialOperatorType() { name="DWithin" },
                                new Filter.SpatialOperatorType() { name="Beyond" }
                            }
                        }
                    }
                };

                ret.Untyped.Add(
                    new XAttribute(XNamespace.Xmlns+"gml", Namespaces.OgcGml)
                );

                return ret;
            }

            protected virtual Ows100.OperationsMetadata CreateOperationsMetadataSection()
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
                    IEnumerable<IXMetaData> supportedTypes=((Discovery)Service).SupportedRecordTypes;

                    // Creates prefixes for supported records namespaces
                    int n=0;
                    foreach (IXMetaData st in supportedTypes)
                    {
                        string p=describeRecord.Untyped.GetPrefixOfNamespace(st.SchemaName.Namespace);
                        if (string.IsNullOrEmpty(p))
                        {
                            string ns=null;
                            do
                            {
                                ns=string.Format(
                                    CultureInfo.InvariantCulture,
                                    "ns{0}",
                                    n++
                                );
                            } while (describeRecord.Untyped.GetNamespaceOfPrefix(ns)!=null);
                            describeRecord.Untyped.Add(
                                new XAttribute(XNamespace.Xmlns+ns, st.SchemaName.Namespace)
                            );
                        }
                    }

                    describeRecord.Parameter=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name=Discovery.OutputFormatParameter,
                            Value=OgcService.XmlMimeTypes
                        },
                        new Ows100.DomainType() {
                            name=TypeNameParameter,
                            Value=supportedTypes
                                .Select<IXMetaData, string>(
                                    m => string.Concat(describeRecord.Untyped.GetPrefixOfNamespace(m.SchemaName.Namespace), ":", m.GetType().Name)
                                ).ToArray<string>()
                        }
                    };
                    operations.Add(describeRecord);
                }

                Ows100.Operation getRecords=CreateOperation("GetRecords", GetEndPoints());
                if (getRecords!=null)
                {
                    IEnumerable<IXMetaData> supportedTypes=((Discovery)Service).SupportedRecordTypes;

                    // Creates prefixes for supported records namespaces
                    int n=0;
                    foreach (IXMetaData st in supportedTypes)
                    {
                        string p=getRecords.Untyped.GetPrefixOfNamespace(st.SchemaName.Namespace);
                        if (string.IsNullOrEmpty(p))
                        {
                            string ns=null;
                            do
                            {
                                ns=string.Format(
                                    CultureInfo.InvariantCulture,
                                    "ns{0}",
                                    n++
                                );
                            } while (getRecords.Untyped.GetNamespaceOfPrefix(ns)!=null);
                            getRecords.Untyped.Add(
                                new XAttribute(XNamespace.Xmlns+ns, st.SchemaName.Namespace)
                            );
                        }
                    }
                    getRecords.Parameter=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name=OutputFormatParameter,
                            Value=OgcService.XmlMimeTypes
                        },
                        new Ows100.DomainType() {
                            name=OutputSchemaParameter,
                            Value=supportedTypes.Select<IXMetaData, string>(m => m.SchemaName.NamespaceName).ToArray<string>()
                        },
                        new Ows100.DomainType() {
                            name=TypeNameParameter,
                            Value=supportedTypes
                                .Select<IXMetaData, string>(
                                    m => string.Concat(getRecords.Untyped.GetPrefixOfNamespace(m.SchemaName.Namespace), ":", m.GetType().Name)
                                ).ToArray<string>()
                        }
                    };
                    getRecords.Constraint=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name="SupportedISOQueryables",
                            Value=new string[] {
                                CoreQueryableNames.Abstract,
                                CoreQueryableNames.AnyText,
                                CoreQueryableNames.Association,
                                CoreQueryableNames.BoundingBox,
                                CoreQueryableNames.Format,
                                CoreQueryableNames.Identifier,
                                CoreQueryableNames.Modified,
                                CoreQueryableNames.Subject,
                                CoreQueryableNames.Title,
                                CoreQueryableNames.Type
                            }
                        }
                    };

                    operations.Add(getRecords);
                }

                Ows100.Operation getRecordById=CreateOperation("GetRecordById", GetEndPoints());
                if (getRecordById!=null)
                {
                    var parameters=new Ows100.DomainType[] {
                        new Ows100.DomainType() {
                            name=OutputFormatParameter,
                            Value=OgcService.XmlMimeTypes
                        },
                        new Ows100.DomainType() {
                            name=OutputSchemaParameter,
                            Value=((Discovery)Service).SupportedRecordTypes.Select<IXMetaData, string>(m => m.SchemaName.NamespaceName).ToArray<string>()
                        }
                    };
                    getRecordById.Parameter=parameters;

                    operations.Add(getRecordById);
                }


                if (operations.Count>0)
                    return new Ows100.OperationsMetadata()
                    {
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

            protected virtual Ows100.ServiceProvider CreateServiceProviderSection()
            {
                return new Ows100.ServiceProvider() {
                    ProviderName=((Discovery)Service).ProviderName/*,
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

            protected virtual Ows100.ServiceIdentification CreateServiceIdentificationSection()
            {
                return new Ows100.ServiceIdentification()
                {
                    ServiceType=new Ows100.CodeType() {
                        TypedValue=Service.ServiceName
                    },
                    ServiceTypeVersion=new string[] { Version },
                    Title=new Ows100.Title() {
                        TypedValue=string.Concat(((Discovery)Service).ProviderName, " ", Service.ServiceName)
                    },
                    Abstract=new Ows100.Abstract() {
                        TypedValue=string.Format(
                            CultureInfo.CurrentCulture,
                            "A catalogue service that conforms to the OpenGIS Catalogue Service specification version {0}.",
                            Service.ServiceVersion
                        )
                    },
                    Keywords=new Ows100.Keywords[] {
                        new Ows100.Keywords() {
                            Keyword=new string[] { Service.ServiceName, ((Discovery)Service).ProviderName, "geospatial", "catalog" }
                        }
                    }
                };
            }

            protected virtual IEnumerable<OwsEndPoint> GetEndPoints()
            {
                return new OwsEndPoint[0];
            }

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
}
