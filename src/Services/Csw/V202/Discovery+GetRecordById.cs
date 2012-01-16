using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Common.Logging;
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Filter110=OgcToolkit.Ogc.Filter.V110;
using Ows100=OgcToolkit.Ogc.Ows.V100;
using CqlQueryable=OgcToolkit.Ogc.WebCatalog.Cql.CqlQueryable;

namespace OgcToolkit.Services.Csw.V202
{
    partial class Discovery
    {

        public class GetRecordByIdProcessorBase:
            OgcRequestProcessor<GetRecordById, GetRecordByIdResponse>
        {

            public GetRecordByIdProcessorBase(Discovery service):
                base(service)
            {
            }

            protected override GetRecordById CreateRequest(NameValueCollection parameters)
            {
                var request=new GetRecordById();

                // [OCG 07-006r1 §10.9.4.1]
                string elementSetName=parameters[ElementSetNameParameter];
                if (!string.IsNullOrEmpty(elementSetName))
                    request.ElementSetName=new ElementSetName() {
                        TypedValue=elementSetName
                    };

                // [OCG 07-006r1 §10.9.4.2]
                string[] ids=parameters.GetValues(IdParameter);
                if (ids!=null)
                {
                    IList<string> idl=string.Join(",", ids).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    try
                    {
                        request.Id=idl.Select<string, Uri>(s => new Uri(s)).ToList<Uri>();
                    } catch (UriFormatException ufex)
                    {
                        throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                            Locator=IdParameter
                        };
                    }
                }

                // [OCG 07-006r1 §10.9.4.3]
                string outputFormat=parameters[OutputFormatParameter];
                if (!string.IsNullOrEmpty(outputFormat))
                    request.outputFormat=outputFormat;

                // [OCG 07-006r1 §10.9.4.4]
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

                return request;
            }

            protected override void CheckRequest(GetRecordById request)
            {
                base.CheckRequest(request);

                if ((request.outputFormat!=null) && (Array.IndexOf<string>(OgcService.XmlMimeTypes, request.outputFormat)<0))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputFormatParameter
                    };

                if ((request.Id==null) || (request.Id.Count==0))
                    throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                        Locator=IdParameter
                    };

                if (request.outputSchema==null)
                    request.outputSchema=new Uri(Namespaces.OgcWebCatalogCswV202);

                if (!((Discovery)Service).SupportedRecordTypes.Select<IXMetaData, XNamespace>(s => s.SchemaName.Namespace).Contains<XNamespace>(request.outputSchema.ToString()))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputSchemaParameter
                    };

                //if (request.ElementSetName!=null)
                if (!request.Untyped.Elements("{http://www.opengis.net/cat/csw/2.0.2}ElementSetName").Any<XElement>() || string.IsNullOrEmpty(request.ElementSetName.TypedValue))
                    request.ElementSetName=new ElementSetName(
                        new ElementSetNameType() {
                            TypedValue="summary"
                        }
                    );

                //TODO: implement additional checks
            }

            protected override GetRecordByIdResponse ProcessRequest(GetRecordById request)
            {
                var ret=new GetRecordByIdResponse();

                var namespaceManager=new XmlNamespaceManager(new NameTable());
                XNamespace dn=request.Untyped.GetDefaultNamespace();
                if (dn!=XNamespace.None)
                    namespaceManager.AddNamespace(string.Empty, dn.NamespaceName);
                var namespaces=from at in request.Untyped.Attributes()
                               where at.IsNamespaceDeclaration
                               select new {
                                   Prefix=at.Parent.GetPrefixOfNamespace(at.Value),
                                   Uri=at.Value
                               };
                namespaces.ToList().ForEach(n => namespaceManager.AddNamespace(n.Prefix, n.Uri));

                IQueryable records=((Discovery)Service).GetRecordsSource(null);
                records=Where(records, request.Id, namespaceManager, ((Discovery)Service).GetOperatorImplementationProvider());

                if (Service.Logger.IsDebugEnabled)
                {
                    string t=records.ToTraceString();
                    if (!string.IsNullOrEmpty(t))
                        Service.Logger.Debug(t);
                }

                // Performs the query
                IEnumerable<IXmlSerializable> results=records.StaticCast<IRecord>()
                    .Select<IRecord, IXmlSerializable>(r => r.GetConverter(namespaceManager).Convert(r, request.ElementSetName.TypedValue))
                    .ToArray<IXmlSerializable>();

                // Core Record types
                var arl=results.OfType<AbstractRecord>();
                ret.AbstractRecord=arl.ToList<AbstractRecord>();

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
                    ret.Untyped.Add(element);
                }

                return ret;
            }

            protected virtual TypeConverter GetIdentifierUriConverter(Type destinationType)
            {
                return new UriTypeConverter();
            }

            internal IQueryable Where(IQueryable source, IEnumerable<Uri> ids, XmlNamespaceManager namespaceManager=null, IOperatorImplementationProvider operatorImplementationProvider=null)
            {
                var parameters=new ParameterExpression[] {
                    Expression.Parameter(source.ElementType)
                };

                var xpqn=new XPathQueryableNavigator(source.ElementType, namespaceManager);
                XPathNodeIterator xpni=xpqn.Select(CoreQueryable.Identifier.Name, namespaceManager);
                if (xpni.MoveNext())
                {
                    var idn=(XPathQueryableNavigator)xpni.Current;
                    Type idType=idn.Type;
                    TypeConverter converter=GetIdentifierUriConverter(idType);

                    // Convert ids from Uris to identifier type
                    var urip=Expression.Parameter(typeof(Uri));
                    var conex=Expression.Lambda(
                        typeof(Func<,>).MakeGenericType(typeof(Uri), idType),
                        Expression.Convert(
                            Expression.Call(
                                Expression.Constant(converter),
                                "ConvertTo",
                                null,
                                urip,
                                Expression.Constant(idType)
                            ),
                            idType
                        ),
                        urip
                    );
                    var urilistp=Expression.Parameter(typeof(IEnumerable<Uri>));
                    var convertids=Expression.Lambda(
                        Expression.Call(
                            typeof(Enumerable),
                            "Select",
                            new Type[] { typeof(Uri), idType },
                            Expression.Constant(ids),
                            conex
                        ),
                        urilistp
                    ).Compile();
                    var convertedIds=convertids.DynamicInvoke(ids);

                    // Creates the Where clause
                    LambdaExpression lambda=Expression.Lambda(
                        Expression.Call(
                            typeof(Enumerable),
                            "Contains",
                            new Type[] { idType },
                            Expression.Constant(convertedIds),
                            idn.CreateExpression(parameters[0])
                        ),
                        parameters
                    );
                    return source.Provider.CreateQuery(
                        Expression.Call(
                            typeof(Queryable),
                            "Where",
                            new Type[] { source.ElementType },
                            source.Expression,
                            Expression.Quote(lambda)
                        )
                    );
                }

                throw new InvalidOperationException();
            }
        }
    }
}
