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
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Xml.Schema.Linq;
using GeoSik.Ogc.Ows;
using Filter110=GeoSik.Ogc.Filter.V110;
using Ows100=GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{

    partial class Discovery
    {

        /// <summary>Base implementation of a GetCapabilities request processor.</summary>
        public class GetCapabilitiesProcessorBase:
            OgcRequestProcessor<Types.GetCapabilities, Types.Capabilities>
        {

            /// <summary>Creates a new instance of the <see cref="GetCapabilitiesProcessorBase" /> type.</summary>
            /// <param name="service">The discovery service this processor is associated to.</param>
            public GetCapabilitiesProcessorBase(Discovery service):
                base(service)
            {
            }

            /// <summary>Creates a <see cref="Types.Getcapabilities" /> instance from the specified key/value parameters.</summary>
            /// <param name="parameters">The key/value parameters.</param>
            /// <returns>The request.</returns>
            protected override Types.GetCapabilities CreateRequest(NameValueCollection parameters)
            {
                var request=new Types.GetCapabilities();

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

            /// <summary>Checks that the specified request is valid.</summary>
            /// <param name="request">The request to check.</param>
            protected override void CheckRequest(Types.GetCapabilities request)
            {
                // Do not do standard checks
                //base.CheckRequest(request);

                // [OCG 05-008 §7.3.2]
                if ((request.Content.AcceptVersions!=null) && (!request.Content.AcceptVersions.Version.Contains(Version)))
                    throw new OwsException(OwsExceptionCode.VersionNegotiationFailed);
            }

            /// <summary>Processes the specified request.</summary>
            /// <param name="request">The request to process.</param>
            /// <returns>The response to the specified request.</returns>
            protected override Types.Capabilities ProcessRequest(Types.GetCapabilities request)
            {

                // When sections is specified but empty, the abbreviated version of GetCapabilities should be returned
                // cf. [OGC CITE TEAMEngine csw:csw-2.0.2-GetCapabilities-tc7.1]
                bool returnAll=((request.Content.Sections==null) || request.Content.Sections.Section.Contains("All"));

                var ret=new Types.Capabilities();
                ret.Untyped.Add(
                    new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(Namespaces.OgcOws, ret.Untyped, "ows"), Namespaces.OgcOws)
                );
                ret.Filter_Capabilities=CreateFilterCapabilitiesSection();

                if (returnAll || (request.Content.Sections.Section.Contains("OperationsMetadata")))
                {
                    Ows100.OperationsMetadata om=CreateOperationsMetadataSection();
                    if (om!=null)
                    {
                        ret.Untyped.Add(
                            new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(Namespaces.XLinkNamespace, ret.Untyped, "xl"), Namespaces.XLinkNamespace)
                        );
                        ret.Content.OperationsMetadata=om;
                    }
                }

                if (returnAll || (request.Content.Sections.Section.Contains("ServiceProvider")))
                {
                    string xl=ret.Untyped.GetPrefixOfNamespace(Namespaces.XLinkNamespace);
                    if (string.IsNullOrEmpty(xl))
                        ret.Untyped.Add(
                            new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(Namespaces.XLinkNamespace, ret.Untyped, "xl"), Namespaces.XLinkNamespace)
                        );
                    ret.Content.ServiceProvider=CreateServiceProviderSection();
                }

                if (returnAll || (request.Content.Sections.Section.Contains("ServiceIdentification")))
                    ret.Content.ServiceIdentification=CreateServiceIdentificationSection();

                ret.Content.version=Version;
                return ret;
            }

            /// <summary>Creates a Filter_Capabilities section for the current request.</summary>
            /// <returns>The Filter_Capabilities section for the current request.</returns>
            protected virtual Filter110.Filter_Capabilities CreateFilterCapabilitiesSection()
            {
                var ret=new Filter110.Filter_Capabilities() {
                    Id_Capabilities=new Filter110.Id_CapabilitiesType() {
                            EID=new Filter110.EID[] {
                            new Filter110.EID()
                        }
                    },
                    Scalar_Capabilities=new Filter110.Scalar_CapabilitiesType() {
                        ComparisonOperators=new Filter110.ComparisonOperatorsType() {
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
                        LogicalOperators=new Filter110.LogicalOperators()
                    },
                    Spatial_Capabilities=new Filter110.Spatial_CapabilitiesType() {
                        GeometryOperands=new Filter110.GeometryOperandsType() {
                                GeometryOperand=new string[] {
                                "gml:Envelope",
                                "gml:Point",
                                "gml:LineString",
                                "gml:Polygon"
                            }
                        },
                        SpatialOperators=new Filter110.SpatialOperatorsType() {
                            SpatialOperator=new Filter110.SpatialOperatorType[] {
                                new Filter110.SpatialOperatorType() { name="BBOX" },
                                new Filter110.SpatialOperatorType() { name="Equals" },
                                new Filter110.SpatialOperatorType() { name="Disjoint" },
                                new Filter110.SpatialOperatorType() { name="Touches" },
                                new Filter110.SpatialOperatorType() { name="Within" },
                                new Filter110.SpatialOperatorType() { name="Overlaps" },
                                new Filter110.SpatialOperatorType() { name="Crosses" },
                                new Filter110.SpatialOperatorType() { name="Intersects" },
                                new Filter110.SpatialOperatorType() { name="Contains" },
                                new Filter110.SpatialOperatorType() { name="DWithin" },
                                new Filter110.SpatialOperatorType() { name="Beyond" }
                            }
                        }
                    }
                };

                ret.Untyped.Add(
                    new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(Namespaces.OgcGml, ret.Untyped, "gml"), Namespaces.OgcGml)
                );

                return ret;
            }

            /// <summary>Creates an OperationsMetadata section for the current request.</summary>
            /// <returns>The OperationsMetadata section for the current request.</returns>
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
                    foreach (IXMetaData st in supportedTypes)
                    {
                        string p=describeRecord.Untyped.GetPrefixOfNamespace(st.SchemaName.Namespace);
                        if (string.IsNullOrEmpty(p))
                            describeRecord.Untyped.Add(
                                new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(st.SchemaName.Namespace, describeRecord.Untyped, null), st.SchemaName.Namespace)
                            );
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
                    foreach (IXMetaData st in supportedTypes)
                    {
                        string p=getRecords.Untyped.GetPrefixOfNamespace(st.SchemaName.Namespace);
                        if (string.IsNullOrEmpty(p))
                            getRecords.Untyped.Add(
                                new XAttribute(XNamespace.Xmlns+CreateUniquePrefix(st.SchemaName.Namespace, getRecords.Untyped, null), st.SchemaName.Namespace)
                            );
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
                        },
                        new Ows100.DomainType() {
                            name=Discovery.ConstraintLanguageParameter,
                            Value=new string[] { "FILTER", "CQL_TEXT" }
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
                    return new Ows100.OperationsMetadata() {
                        Operation=operations
                    };

                return null;
            }

            /// <summary>Creates a ServiceProvider section for the current request.</summary>
            /// <returns>The ServiceProvider section for the current request.</returns>
            protected virtual Ows100.ServiceProvider CreateServiceProviderSection()
            {
                return new Ows100.ServiceProvider() {
                    ProviderName=((Discovery)Service).ProviderName
                };
            }

            /// <summary>Creates a ServiceIdentification section for the current request.</summary>
            /// <returns>The ServiceIdentification section for the current request.</returns>
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
                            SR.DiscoveryGetCapabilitiesDefaultAbstract,
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

            /// <summary>Gets the end points for the current discovery service.</summary>
            /// <returns>The end points for the current discovery service.</returns>
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

            internal static string CreateUniquePrefix(XNamespace ns, XElement parent, string basePrefix)
            {
                string ret=parent.GetPrefixOfNamespace(ns);
                if (!string.IsNullOrEmpty(ret))
                    throw new InvalidOperationException();

                if (string.IsNullOrWhiteSpace(basePrefix))
                {
                    var matches=_NamespacePrefixSelector.Matches(ns.NamespaceName);
                    if (matches.Count>0)
                        basePrefix=matches[matches.Count-1].Value;
                    else
                        basePrefix="ns";
                }

                ret=basePrefix;
                if (parent.GetNamespaceOfPrefix(ret)!=null)
                {
                    int n=0;
                    string bp=basePrefix.Substring(0, 2);
                    do
                    {
                        ret=string.Format(
                            CultureInfo.InvariantCulture,
                            "{0}{1}",
                            basePrefix,
                            n++
                        );
                    } while (parent.GetNamespaceOfPrefix(ret)!=null);
                }

                return ret;
            }

            private static Regex _NamespacePrefixSelector=new Regex(@"(?<=/)[a-zA-Z]+(?=/?)", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        }

    }
}
