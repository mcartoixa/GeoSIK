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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Common.Logging;
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Filter110=OgcToolkit.Ogc.Filter.V110;
using Ows100=OgcToolkit.Ogc.Ows.V100;

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

                // Where
                //if (query!=null)
                //{
                //    mayRootPathBeImplied=(typeNames.Length<2);

                //    //if (query.Constraint!=null)
                //    if (query.Untyped.Descendants("{http://www.opengis.net/cat/csw/2.0.2}Constraint").Any<XElement>())
                //        records=records.Where(query.Constraint, namespaceManager, mayRootPathBeImplied, ((Discovery)Service).GetOperatorImplementationProvider());
                //}

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
        }

    }
}
