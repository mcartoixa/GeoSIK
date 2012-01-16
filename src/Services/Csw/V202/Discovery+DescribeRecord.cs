using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Xml.Schema.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;

namespace OgcToolkit.Services.Csw.V202
{
    partial class Discovery
    {

        public class DescribeRecordProcessorBase:
            OgcRequestProcessor<DescribeRecord, DescribeRecordResponse>
        {

            public DescribeRecordProcessorBase(Discovery service):
                base(service)
            {
            }

            protected override DescribeRecord CreateRequest(NameValueCollection parameters)
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

                            string prefix=m.Groups["PREFIX"].Value;
                            string url=m.Groups["URL"].Value;
                            if (!string.IsNullOrEmpty(prefix))
                                request.Untyped.Add(
                                    new XAttribute(XNamespace.Xmlns+prefix, url)
                                );
                            else
                                request.Untyped.Add(
                                    new XAttribute("xmlns", url)
                                );
                        }
                }

                // [OCG 07-006r1 §10.6.4.2]
                string[] typeName=parameters.GetValues(TypeNameParameter);
                if (typeName!=null)
                {
                    IList<string> tnp=string.Join(",", typeName).Split(',').Where<string>(s => !string.IsNullOrWhiteSpace(s)).ToList<string>();
                    var rtn=new List<XmlQualifiedName>(tnp.Count);
                    foreach (string tn in tnp)
                    {
                        try
                        {
                            // Works because we have already parsed the namespaces
                            XName name=GetXmlNameFromString(tn, request.Untyped);
                            rtn.Add(string.IsNullOrEmpty(name.NamespaceName)?new XmlQualifiedName(name.LocalName):new XmlQualifiedName(name.LocalName, name.NamespaceName));
                        } catch (XmlException xex)
                        {
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue, xex.Message, xex) {
                                Locator=TypeNamesParameter
                            };
                        }
                    }

                    if (rtn.Count>0)
                        request.TypeName=rtn;
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

                return request;
            }

            protected override void CheckRequest(DescribeRecord request)
            {
                base.CheckRequest(request);

                if ((request.outputFormat==null) || (Array.IndexOf<string>(XmlMimeTypes, request.outputFormat)<0))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputFormatParameter
                    };

                // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default, so we have to consider it valid...
                Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
                if ((request.schemaLanguage==null) || (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=SchemaLanguageParameter
                    };
            }

            protected override DescribeRecordResponse ProcessRequest(DescribeRecord request)
            {
                var ret=new DescribeRecordResponse();

                // Get the names of record types
                List<XName> names=((Discovery)Service).SupportedRecordTypes.Select<IXMetaData, XName>(m => m.SchemaName).ToList<XName>();
                if ((request.TypeName!=null) && (request.TypeName.Count>0))
                {
                    names.Clear();

                    // We should be able to write foreach (XmlQualifiedName xqn in request.TypeName) { }
                    // But type names cannot be retrieved as XmlQualifiedName: there are prefixes instead of namespaces
                    // So we take the long way via XElement
                    var typeNamesElements=from el in request.Untyped.Descendants()
                                          where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}TypeName"
                                          select el;
                    foreach (XElement tne in typeNamesElements)
                    {
                        string[] tn=tne.Value.Split(new char[] { ':' }, 2);
                        string name=tn[0];
                        XNamespace @namespace=tne.GetDefaultNamespace();
                        if (tn.Length>1)
                        {
                            name=tn[1];
                            @namespace=tne.GetNamespaceOfPrefix(tn[0]);
                        }

                        // Check the name is a supported type
                        if (!((Discovery)Service).SupportedRecordTypes.Any<IXMetaData>(m => (m.GetType().Name==name) && (m.SchemaName.Namespace==@namespace)))
                            break;

                        names.Add(string.Concat("{", @namespace, "}", name));
                    }
                }

                // Create the csw:schemaComponents
                var componentTypes=new List<SchemaComponentType>(request.TypeName.Count);
                foreach (XName name in names)
                {
                    var recordComponentType=new SchemaComponentType() {
                        schemaLanguage=XmlSchemaLanguageUri,
                        targetNamespace=new Uri(name.NamespaceName)
                    };
                    recordComponentType.Untyped.Add(GetRecordSchema(name.Namespace).Root);
                    componentTypes.Add(recordComponentType);
                }
                if (componentTypes.Count>0)
                    ret.SchemaComponent=componentTypes;

                return ret;
            }
        }

    }
}
