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
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Common.Logging;
using Xml.Schema.Linq;
using GeoSik.Ogc.Ows;
using Filter110=GeoSik.Ogc.Filter.V110;
using Ows100=GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{
    partial class Discovery
    {

        public class GetRecordsProcessorBase:
            OgcRequestProcessor<Types.GetRecords, Types.IGetRecordsResponse>
        {

            public GetRecordsProcessorBase(Discovery service):
                base(service)
            {
            }

            protected override Types.GetRecords CreateRequest(NameValueCollection parameters)
            {
                var request=new Types.GetRecords();

                var namespaceManager=new XmlNamespaceManager(new NameTable());
                namespaceManager.AddNamespace(string.Empty, ((IXMetaData)request).SchemaName.NamespaceName);

                // [OCG 07-006r1 §10.8.4.1]
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

                            string prefix=m.Groups["PREFIX"].Value;
                            string url=m.Groups["URL"].Value;
                            if (!string.IsNullOrEmpty(prefix))
                            {
                                namespaceManager.AddNamespace(prefix, url);
                                request.Untyped.Add(
                                    new XAttribute(XNamespace.Xmlns+prefix, url)
                                );
                            } else
                            {
                                namespaceManager.AddNamespace(string.Empty, url);
                                request.Untyped.Add(
                                    new XAttribute("xmlns", url)
                                );
                            }
                        }
                }

                // [OCG 07-006r1 §10.8.4.2]
                string requestId=parameters[RequestIdParameter];
                if (!string.IsNullOrEmpty(requestId))
                    try
                    {
                        request.requestId=new Uri(requestId);
                    } catch (UriFormatException ufex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                            Locator=RequestIdParameter
                        };
                    }

                // [OCG 07-006r1 §10.8.4.3]
                string resultType=parameters[ResultTypeParameter];
                if (!string.IsNullOrEmpty(resultType))
                    request.resultType=resultType; //TODO: does not check inputs ("hits", "results" or "validate")

                // [OCG 07-006r1 §10.8.4.4]
                string outputFormat=parameters[OutputFormatParameter];
                if (!string.IsNullOrEmpty(outputFormat))
                    request.outputFormat=outputFormat;

                // [OCG 07-006r1 §10.8.4.5]
                string outputSchema=parameters[OutputSchemaParameter];
                if (!string.IsNullOrEmpty(outputSchema))
                    try
                    {
                        request.outputSchema=new Uri(outputSchema);
                    } catch (UriFormatException ufex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                            Locator=OutputSchemaParameter
                        };
                    }

                // [OCG 07-006r1 §10.8.4.6]
                string startPosition=parameters[StartPositionParameter];
                if (!string.IsNullOrEmpty(startPosition))
                    try
                    {
                        request.startPosition=uint.Parse(startPosition, CultureInfo.InvariantCulture);
                    } catch (FormatException fex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex) {
                            Locator=StartPositionParameter
                        };
                    } catch (OverflowException oex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, oex) {
                            Locator=StartPositionParameter
                        };
                    }

                // [OCG 07-006r1 §10.8.4.7]
                string maxRecords=parameters[MaxRecordsParameter];
                if (!string.IsNullOrEmpty(maxRecords))
                    try
                    {
                        request.maxRecords=uint.Parse(maxRecords, CultureInfo.InvariantCulture);
                    } catch (FormatException fex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex) {
                            Locator=MaxRecordsParameter
                        };
                    } catch (OverflowException oex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, oex) {
                            Locator=MaxRecordsParameter
                        };
                    }

                // [OCG 07-006r1 §10.8.4.8]
                string[] typeNames=parameters.GetValues(TypeNamesParameter);
                if (typeNames!=null)
                {
                    IList<string> tnp=string.Join(",", typeNames).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    var rtn=new List<XmlQualifiedName>(tnp.Count);
                    foreach (string tn in tnp)
                    {
                        try
                        {
                            // Works because we have already parsed the namespaces
                            XName name=GetXmlNameFromString(tn, request.Untyped);
                        } catch (XmlException xex)
                        {
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue, xex) {
                                Locator=TypeNamesParameter
                            };
                        }
                    }

                    // Cannot seem to be able to use the Query.typeNames property here...
                    if (tnp.Count>0)
                    {
                        request.Content.AbstractQuery=new Types.Query();
                        request.Content.AbstractQuery.Untyped.SetAttributeValue("typeNames", string.Join(" ", tnp));
                    } else
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                            Locator=TypeNamesParameter
                        };
                } else
                    throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                        Locator=TypeNamesParameter
                    };

                // This can never be null at this point
                Types.Query query=(Types.Query)request.Content.AbstractQuery;

                // [OCG 07-006r1 §10.8.4.9]
                string[] elementName=parameters.GetValues(ElementNameParameter);
                if (elementName!=null)
                {
                    IList<string> enp=string.Join(",", elementName).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    var ren=new List<XmlQualifiedName>(enp.Count);
                    foreach (string en in enp)
                    {
                        try
                        {
                            // Works because we have already parsed the namespaces
                            XName name=GetXmlNameFromString(en, request.Untyped);
                            ren.Add(string.IsNullOrEmpty(name.NamespaceName) ? new XmlQualifiedName(name.LocalName) : new XmlQualifiedName(name.LocalName, name.NamespaceName));
                        } catch (XmlException xex)
                        {
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue, xex) {
                                Locator=TypeNamesParameter
                            };
                        }
                    }

                    if (ren.Count>0)
                        query.ElementName=ren;
                }
                string elementSetName=parameters[ElementSetNameParameter];
                if (!string.IsNullOrEmpty(elementSetName))
                    query.ElementSetName=new Types.ElementSetName() {
                        TypedValue=elementSetName
                    };

                // [OCG 07-006r1 §10.8.4.10]
                string constraintLanguage=parameters[ConstraintLanguageParameter];
                string constraint=parameters[ConstraintParameter];
                if (!string.IsNullOrEmpty(constraint))
                {
                    if (string.IsNullOrEmpty(constraintLanguage))
                        throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                            Locator=ConstraintLanguageParameter
                        };

                    switch (constraintLanguage)
                    {
                    case "CQL_TEXT":
                        query.Constraint=new Types.Constraint() {
                            CqlText=constraint
                        };
                        break;
                    case "FILTER":
                        query.Constraint=new Types.Constraint();
                        try
                        {
                            // We cannot use XElement.Parse() because of the likely use of namespaces (and prefixes)
                            XmlParserContext context=new XmlParserContext(null, namespaceManager, null, XmlSpace.None);
                            using (var r=new XmlTextReader(constraint, XmlNodeType.Element, context))
                            {
                                var c=XElement.Load(r);
                                query.Constraint.Untyped.Add(c);

                                // Will throw when the input XML is invalid
                                GC.KeepAlive(query.Constraint.Filter);
                            }
                        } catch (Exception ex)
                        {
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue, ex) {
                                Locator=ConstraintParameter
                            };
                        }
                        break;
                    default:
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                            Locator=ConstraintLanguageParameter
                        };
                    }
                }

                // [OCG 07-006r1 §10.8.4.12]
                string[] sortBy=parameters.GetValues(SortByParameter);
                if (sortBy!=null)
                {
                    IList<string> sbList=string.Join(",", sortBy).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    var sptList=new List<Filter110.SortPropertyType>(sbList.Count);
                    foreach (string sb in sbList)
                    {
                        string pn=sb;
                        string so=null;
                        if (sb.EndsWith(":A", StringComparison.OrdinalIgnoreCase))
                        {
                            pn=sb.Substring(0, sb.Length-2);
                            so="ASC";
                        } else if (sb.EndsWith(":D", StringComparison.OrdinalIgnoreCase))
                        {
                            pn=sb.Substring(0, sb.Length-2);
                            so="DESC";
                        }

                        var spt=new Filter110.SortPropertyType() {
                            PropertyName=new Filter110.PropertyName()
                        };
                        if (so!=null)
                            spt.SortOrder=so;
                        spt.PropertyName.Untyped.SetValue(pn);
                        sptList.Add(spt);
                    }

                    query.SortBy=new Filter110.SortBy() {
                        SortProperty=sptList
                    };
                }

                // [OCG 07-006r1 §10.8.4.13]
                bool isDistributedSearch=false;
                string distributedSearch=parameters[DistributedSearchParameter];
                if (!string.IsNullOrEmpty(distributedSearch))
                    try
                    {
                        isDistributedSearch=bool.Parse(distributedSearch);
                    } catch (FormatException fex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex) {
                            Locator=DistributedSearchParameter
                        };
                    }

                string hopCount=parameters[HopCountParameter];
                if (!string.IsNullOrEmpty(hopCount))
                    try
                    {
                        if (isDistributedSearch)
                            request.DistributedSearch=new Types.DistributedSearchType() {
                                hopCount=uint.Parse(hopCount, CultureInfo.InvariantCulture)
                            };
                    } catch (FormatException fex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex) {
                            Locator=HopCountParameter
                        };
                    } catch (OverflowException oex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, oex) {
                            Locator=HopCountParameter
                        };
                    } else if (isDistributedSearch)
                    request.DistributedSearch=new Types.DistributedSearchType();

                // [OCG 07-006r1 §10.8.4.14]
                string responseHandler=parameters[ResponseHandlerParameter];
                if (!string.IsNullOrEmpty(responseHandler))
                    try
                    {
                        request.ResponseHandler=new Uri[] { new Uri(responseHandler) };
                    } catch (UriFormatException ufex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                            Locator=ResponseHandlerParameter
                        };
                    }

                return request;
            }

            protected override void CheckRequest(Types.GetRecords request)
            {
                base.CheckRequest(request);

                // Initialize namespace manager
                _NamespaceManager=new XmlNamespaceManager(new NameTable());
                XNamespace dn=request.Untyped.GetDefaultNamespace();
                if (dn!=XNamespace.None)
                    _NamespaceManager.AddNamespace(string.Empty, dn.NamespaceName);
                var namespaces=from at in request.Untyped.Attributes()
                               where at.IsNamespaceDeclaration
                               select new {
                                   Prefix=at.Parent.GetPrefixOfNamespace(at.Value),
                                   Uri=at.Value
                               };
                namespaces.ToList().ForEach(n => _NamespaceManager.AddNamespace(n.Prefix, n.Uri));

                // Invalid output format
                if ((request.outputFormat!=null) && (Array.IndexOf<string>(OgcService.XmlMimeTypes, request.outputFormat)<0))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputFormatParameter
                    };

                // No type name defined
                if (!request.Content.AbstractQuery.Untyped.Attributes("typeNames").Any<XAttribute>())
                    throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                        Locator=TypeNamesParameter
                    };
                // Invalid type name
                string[] typeNames=request.Content.AbstractQuery.Untyped.Attribute("typeNames").Value.Split(' ');
                if (typeNames.Any<string>(
                    a => !((Discovery)Service).SupportedRecordTypes.Any<IXMetaData>(
                        m => string.Compare(string.Concat(_NamespaceManager.LookupPrefix(m.SchemaName.NamespaceName), ":", m.SchemaName.LocalName), a, StringComparison.Ordinal)==0
                    )
                ))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=TypeNamesParameter
                    };

                if (request.outputSchema==null)
                    request.outputSchema=new Uri(Namespaces.OgcWebCatalogCswV202);

                // Invalid output schema
                if (!((Discovery)Service).SupportedRecordTypes.Select<IXMetaData, XNamespace>(s => s.SchemaName.Namespace).Contains<XNamespace>(request.outputSchema.ToString()))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputSchemaParameter
                    };

                // We should be able to use foreach (Uri uri in request.ResponseHandler) here...
                var rh=from el in request.Untyped.Elements()
                       where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ResponseHandler"
                       select new Uri(el.Value);
                // Check that uris are absolute...
                var invrh=from uri in rh
                          where !uri.IsAbsoluteUri
                          select uri;
                if (invrh.Any<Uri>())
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=ResponseHandlerParameter
                    };


                //TODO: implement additional checks

                // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default, so we have to consider it valid...
                //Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
                //if ((request.schemaLanguage!=null) && (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
                //    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                //        Locator=SchemaLanguageParameter
                //    };
            }

            public override Types.IGetRecordsResponse Process(Types.GetRecords request)
            {
                Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing started"));
                Logger.Debug(CultureInfo.InvariantCulture, m => m("> {0}", OgcService.ToTraceString(request)));

                CheckRequest(request);

                var task=new Task<Types.IGetRecordsResponse>(
                    r => {
                        Types.GetRecords req=(Types.GetRecords)r;
                        var response=ProcessRequest(req);

                        var args=new Ows.OwsRequestEventArgs<Types.GetRecords, Types.IGetRecordsResponse>(req, response);
                        OnProcessed(args);

                        Debug.Assert(args.Response!=null);
                        return args.Response;
                    },
                    request,
                    TaskCreationOptions.LongRunning
                );

                // Asynchronous processing
                if ((request.ResponseHandler!=null) && (request.ResponseHandler.Count>0))
                {
                    task
                        .ContinueWith(_SendRecordsResponse)
                        .ContinueWith(_LogAsynchronousExceptions, TaskContinuationOptions.OnlyOnFaulted);
                    task.Start();

                    var echo=new Types.EchoedRequestType();
                    echo.Untyped.Add(request.Untyped);

                    var ret=new Types.Acknowledgement() {
                        EchoedRequest=echo,
                        timeStamp=DateTime.UtcNow
                    };

                    Logger.Debug(CultureInfo.InvariantCulture, m => m("< {0}", OgcService.ToTraceString(ret)));
                    Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing finished"));
                    return ret;
                }

                // Synchronous processing
                using (task)
                {
                    task.RunSynchronously();
                    Types.IGetRecordsResponse ret=task.Result;

                    Logger.Debug(CultureInfo.InvariantCulture, m => m("< {0}", OgcService.ToTraceString(ret)));
                    Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing finished"));
                    return ret;
                }
            }

            protected override Types.IGetRecordsResponse ProcessRequest(Types.GetRecords request)
            {
                var ret=new Types.GetRecordsResponse();
                if (request.requestId!=null)
                    ret.RequestId=request.requestId;

                ret.SearchStatus=new Types.RequestStatusType() {
                    timestamp=DateTime.UtcNow
                };

                var query=request.Content.AbstractQuery as Types.Query;

                // Cannot seem to be able to use the query.typeNames property here...
                var typeNames=request.Content.AbstractQuery.Untyped.Attributes("typeNames")
                    .SelectMany<XAttribute, string>(a => a.Value.Split(' '))
                    .Select<string, XName>(s => GetXmlNameFromString(s, request.Content.AbstractQuery.Untyped))
                    .ToArray<XName>();

                bool mayRootPathBeImplied=false;

                IQueryable records=((Discovery)Service).GetRecordsSource(request.outputSchema);

                // Where
                if (query!=null)
                {
                    mayRootPathBeImplied=(typeNames.Length<2);

                    //if (query.Constraint!=null)
                    if (query.Untyped.Descendants("{http://www.opengis.net/cat/csw/2.0.2}Constraint").Any<XElement>())
                        records=records.Where(query.Constraint, _NamespaceManager, mayRootPathBeImplied, ((Discovery)Service).GetOperatorImplementationProvider());
                }

                if (Logger.IsDebugEnabled)
                {
                    string t=records.ToTraceString();
                    if (!string.IsNullOrEmpty(t))
                        Logger.Debug(t);
                }

                int recordsMatched=records.Count();
                if (string.CompareOrdinal(request.resultType, "hits")==0)
                {
                    ret.SearchResults=new Types.SearchResultsType() {
                        numberOfRecordsMatched=recordsMatched,
                        numberOfRecordsReturned=0,
                        nextRecord=Math.Min(1, recordsMatched)
                    };
                    return ret;
                } else if (string.CompareOrdinal(request.resultType, "validate")==0)
                {
                    var echo=new Types.EchoedRequestType();
                    echo.Untyped.Add(request.Untyped);

                    var r=new Types.Acknowledgement() {
                        EchoedRequest=echo,
                        timeStamp=DateTime.UtcNow
                    };
                    if (request.requestId!=null)
                        r.RequestId=request.requestId;
                    else
                        r.RequestId=new Uri(string.Concat("urn:uuid:", Guid.NewGuid().ToString("D", CultureInfo.InvariantCulture)));
                    return r;
                }

                // Order by
                if (query!=null)
                {
                    //if (query.SortBy!=null)
                    if (query.Untyped.Descendants("{http://www.opengis.net/ogc}SortBy").Any<XElement>())
                        records=Filter110.FilterQueryable.OrderBy(records, query.SortBy, _NamespaceManager, mayRootPathBeImplied, (t, r) => new XPathQueryableNavigator(t, r));
                }

                // Paging must be done after a sort
                if (request.startPosition>1)
                    records=records.Skip(Convert.ToInt32(request.startPosition)-1);

                if (request.maxRecords>=0)
                    records=records.Take(Convert.ToInt32(request.maxRecords));

                if (Logger.IsDebugEnabled)
                {
                    string t=records.ToTraceString();
                    if (!string.IsNullOrEmpty(t))
                        Logger.Debug(t);
                }

                // Results
                IEnumerable<IXmlSerializable> results=null;
                //if ((query.ElementSetName!=null) && !string.IsNullOrEmpty(query.ElementSetName.TypedValue))
                if ((query!=null) && query.Untyped.Elements("{http://www.opengis.net/cat/csw/2.0.2}ElementSetName").Any<XElement>() && !string.IsNullOrEmpty(query.ElementSetName.TypedValue))
                {
                    results=records.StaticCast<IRecord>()
                        .Select<IRecord, IXmlSerializable>(r => r.GetConverter(_NamespaceManager).Convert(r, query.ElementSetName.TypedValue));
                } else if ((query!=null) && (query.ElementName!=null) && (query.ElementName.Count>0))
                {
                    var elementNames=from el in query.Untyped.Descendants()
                                        where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ElementName"
                                        select el.Value;
                    results=records.StaticCast<IRecord>()
                        .Select<IRecord, IXmlSerializable>(r => r.GetConverter(_NamespaceManager).Convert(r, elementNames, mayRootPathBeImplied));
                } else
                    results=records.StaticCast<IRecord>()
                        .Select<IRecord, IXmlSerializable>(r => r.GetConverter(_NamespaceManager).Convert(r, "full"));

                // Performs the query
                results=results.ToArray<IXmlSerializable>();

                // Core Record types
                var arl=results.OfType<Types.AbstractRecord>();

                int recordsReturned=results.Count<IXmlSerializable>();
                int nextRecord=Convert.ToInt32(request.startPosition+recordsReturned);
                ret.SearchResults=new Types.SearchResultsType() {
                    AbstractRecord=arl.ToList<Types.AbstractRecord>(),
                    numberOfRecordsMatched=recordsMatched,
                    numberOfRecordsReturned=recordsReturned,
                    nextRecord=(nextRecord>recordsMatched ? 0 : nextRecord)
                };

                // Other types
                var xsl=results.Except<IXmlSerializable>(arl.Cast<IXmlSerializable>());

                XmlWriterSettings xws=new XmlWriterSettings();
                xws.Indent=false;
                xws.NamespaceHandling=NamespaceHandling.OmitDuplicates;
                xws.OmitXmlDeclaration=true;

                foreach (IXmlSerializable xs in xsl)
                {
                    StringBuilder sb=new StringBuilder();
                    using (XmlWriter xw=XmlWriter.Create(sb))
                        xs.WriteXml(xw);

                    XElement element=XElement.Parse(sb.ToString(), LoadOptions.None);
                    ret.SearchResults.Untyped.Add(element);
                }

                return ret;
            }

            private void _SendRecordsResponse(Task<Types.IGetRecordsResponse> task)
            {
                Types.GetRecords request=(Types.GetRecords)task.AsyncState;

                IXmlSerializable response=task.Result;
                if (task.Exception!=null)
                {
                    IList<Ows100.Exception> exceptions=task.Exception.InnerExceptions
                        .Select<Exception, OwsException>(e => {
                            var oex=e as OwsException;
                            if (oex!=null)
                                return oex;
                            return new OwsException(OwsExceptionCode.NoApplicableCode, e);
                        })
                        .SelectMany<OwsException, Ows100.Exception>(e => ((Ows100.ExceptionReport)e).Exception)
                        .ToList<Ows100.Exception>();

                    response=new Ows100.ExceptionReport() {
                        version="1.2.0",
                        Exception=exceptions
                    };
                }

                if (response==null)
                {
                    Logger.Warn("No response to handle");
                    return;
                }

                byte[] binResponse=new byte[0];
                using (var ms=new MemoryStream())
                {
                    using (var xw=XmlWriter.Create(ms, new XmlWriterSettings() { CloseOutput=false }))
                        response.WriteXml(xw);
                    binResponse=ms.ToArray();
                }

                // We should be able to use foreach (Uri uri in request.ResponseHandler) here...
                var rh=from el in request.Untyped.Descendants()
                       where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ResponseHandler"
                       select new Uri(el.Value);
                foreach (Uri uri in rh)
                {
                    switch (uri.Scheme)
                    {
                    case "ftp":
                        {
                            Uri ftpuri=uri.IsFile ? uri : new Uri(uri, string.Concat(request.requestId.Host, ".xml"));
                            Logger.Info(CultureInfo.InvariantCulture, m => m("Opening FTP connection to {0}", ftpuri));

                            FtpWebRequest ftpreq=(FtpWebRequest)WebRequest.Create(ftpuri);
                            ftpreq.Method=WebRequestMethods.Ftp.UploadFile;
                            ftpreq.ContentLength=binResponse.Length;

                            using (var grst=Task<Stream>.Factory.FromAsync(ftpreq.BeginGetRequestStream, ftpreq.EndGetRequestStream, null))
                                using (grst.Result)
                                {
                                    var wt=Task.Factory.FromAsync(grst.Result.BeginWrite, grst.Result.EndWrite, binResponse, 0, binResponse.Length, null, TaskCreationOptions.AttachedToParent);
                                    wt.Start();
                                }
                        }
                        break;
                    }
                }
            }

            private void _LogAsynchronousExceptions(Task task)
            {
                if (task.Exception!=null)
                    Logger.Error("An exception occured during an asynchronous operation", task.Exception);
            }

            private XmlNamespaceManager _NamespaceManager;
        }

    }
}
