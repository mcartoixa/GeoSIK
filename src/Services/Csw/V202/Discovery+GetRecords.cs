using System;
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
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Csw.V202
{
    partial class Discovery
    {

        public IGetRecordsResponse GetRecords(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return GetRecords(CreateGetRecordsRequestFromParameters(parameters));
        }

        public IGetRecordsResponse GetRecords(GetRecords request)
        {
            CheckRequest(request);
            CheckGetRecordsRequest(request);

            var task=new Task<GetRecordsResponse>(
                r => {
                    GetRecords req=(GetRecords)r;
                    var response=_ProcessGetRecords(req);

                    var args=new Ows.OwsRequestEventArgs<GetRecords, GetRecordsResponse>(req, response);
                    OnProcessGetRecords(args);

                    Debug.Assert(args.Response!=null);

                    return args.Response;
                },
                request,
                TaskCreationOptions.LongRunning
            );

            // Asynchronous processing
            if ((request.ResponseHandler!=null) && (request.ResponseHandler.Count>0))
            {
                task.ContinueWith(_SendRecordsResponse);
                task.Start();

                var echo=new EchoedRequestType();
                echo.Untyped.Add(request.Untyped);

                return new Acknowledgement() {
                    EchoedRequest=echo,
                    timeStamp=DateTime.UtcNow
                };
            }

            //// Synchronous processing
            using (task)
            {
                task.RunSynchronously();
                return task.Result;
            }
        }

        protected virtual GetRecords CreateGetRecordsRequestFromParameters(NameValueCollection parameters)
        {
            var request=new GetRecords();

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
                    request.Content.AbstractQuery=new Query();
                    request.Content.AbstractQuery.Untyped.SetAttributeValue("typeNames", string.Join(" ", tnp));
                } else
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=TypeNamesParameter
                    };
            } else
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=TypeNamesParameter
                };

            // This cannot be null at this point
            Query query=(Query)request.Content.AbstractQuery;

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
                query.ElementSetName=new ElementSetName() {
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
                    query.Constraint=new Constraint() {
                        CqlText=constraint
                    };
                    break;
                case "FILTER":
                    query.Constraint=new Constraint();
                    try
                    {
                        // We cannot use XElement.Parse() because of likely use of namespaces
                        XmlParserContext context=new XmlParserContext(null, namespaceManager, null, XmlSpace.None);
                        using (var r=new XmlTextReader(constraint, XmlNodeType.Element, context))
                        {
                            var c=XElement.Load(r);
                            query.Constraint.Untyped.Add(c);
                        }
                    } catch (XmlException xex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, xex) {
                            Locator=ConstraintParameter
                        };
                    } catch (InvalidOperationException ioex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, ioex) {
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

            //TODO: distributedSearch parameter
            //TODO: hopCount parameter
            //TODO: responseHandler parameter

            return request;
        }

        protected virtual void CheckGetRecordsRequest(GetRecords request)
        {
            if ((request.outputFormat!=null) && (Array.IndexOf<string>(XmlMimeTypes, request.outputFormat)<0))
                throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                    Locator=OutputFormatParameter
                };

            if (!request.Content.AbstractQuery.Untyped.Attributes("typeNames").Any<XAttribute>())
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=TypeNamesParameter
                };

            //TODO: implement additional checks

            // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default, so we have to consider it valid...
            //Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
            //if ((request.schemaLanguage!=null) && (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
            //    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
            //        Locator=SchemaLanguageParameter
            //    };
        }

        private GetRecordsResponse _ProcessGetRecords(GetRecords request)
        {
            var ret=new GetRecordsResponse();

            if (request.requestId!=null)
                ret.RequestId=request.requestId;

            return ret;
        }

        private void _SendRecordsResponse(Task<GetRecordsResponse> task)
        {
            GetRecords request=(GetRecords)task.AsyncState;

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

            byte[] binResponse=new byte[0];
            using (var ms=new MemoryStream())
            {
                using (var xw=XmlWriter.Create(ms, new XmlWriterSettings() { CloseOutput=false }))
                    response.WriteXml(xw);
                binResponse=ms.ToArray();
            }

            foreach (Uri uri in request.ResponseHandler)
            {
                switch (uri.Scheme)
                {
                case "ftp":
                    {
                        FtpWebRequest ftpreq=(FtpWebRequest)WebRequest.Create(uri);
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

        protected virtual void OnProcessGetRecords(Ows.OwsRequestEventArgs<GetRecords, GetRecordsResponse> e)
        {
            var eh=ProcessGetRecords;
            if (eh!=null)
                eh(this, e);
        }

        public event EventHandler<Ows.OwsRequestEventArgs<GetRecords, GetRecordsResponse>> ProcessGetRecords;
    }
}
