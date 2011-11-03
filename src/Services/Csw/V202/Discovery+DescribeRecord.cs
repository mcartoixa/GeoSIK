using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        protected virtual DescribeRecord CreateDescribeRecordRequestFromParameters(NameValueCollection parameters)
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

            return request;
        }

        protected virtual void CheckDescribeRecordRequest(DescribeRecord request)
        {
            CheckRequest(request);

            if ((request.outputFormat!=null) && (Array.IndexOf<string>(XmlMimeTypes, request.outputFormat)<0))
                throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                    Locator=OutputFormatParameter
                };

            // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default, so we have to consider it valid...
            Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
            if ((request.schemaLanguage!=null) && (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
                throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                    Locator=SchemaLanguageParameter
                };
        }

        private DescribeRecordResponse _ProcessDescribeRecord(DescribeRecord request)
        {
            var ret=new DescribeRecordResponse();

            // Get the names of record types
            List<XName> names=_SupportedRecordTypesInstances.Select<IXMetaData, XName>(m => m.SchemaName).ToList<XName>();
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
                    if (!_SupportedRecordTypesInstances.Any<IXMetaData>(m => (m.GetType().Name==name) && (m.SchemaName.Namespace==@namespace)))
                        break;

                    names.Add(string.Concat("{", @namespace, "}", name));
                }
            }

            // Create the csw:schemaComponents
            var componentTypes=new List<SchemaComponentType>(request.TypeName.Count);
            foreach (XName name in names)
            {
                var recordComponentType=new SchemaComponentType()
                {
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

        protected virtual void OnProcessDescribeRecord(Ows.OwsRequestEventArgs<DescribeRecord, DescribeRecordResponse> e)
        {
            var eh=ProcessDescribeRecord;
            if (eh!=null)
                eh(this, e);
        }

        public event EventHandler<Ows.OwsRequestEventArgs<DescribeRecord, DescribeRecordResponse>> ProcessDescribeRecord;
    }
}
