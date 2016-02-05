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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xml.Schema.Linq;
using GeoSik.Ogc.Ows;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{
    partial class Discovery
    {

        /// <summary>Base implementation of a DescribeRecord request processor.</summary>
        public class DescribeRecordProcessorBase:
            OgcRequestProcessor<Types.DescribeRecord, Types.DescribeRecordResponse>
        {

            /// <summary>Creates a new instance of the <see cref="DescribeRecordProcessorBase" /> type.</summary>
            /// <param name="service">The discovery service this processor is associated to.</param>
            public DescribeRecordProcessorBase(Discovery service) :
                base(service)
            {
            }

            /// <summary>Creates a <see cref="Types.DescribeRecord" /> instance from the specified key/value parameters.</summary>
            /// <param name="parameters">The key/value parameters.</param>
            /// <returns>The request.</returns>
            protected override Types.DescribeRecord CreateRequest(NameValueCollection parameters)
            {
                var request=new Types.DescribeRecord();

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
                            {
                                var ex=new OwsException(OwsExceptionCode.InvalidParameterValue) {
                                    Locator=NamespaceParameter
                                };
                                ex.Data.Add(NamespaceParameter, nsp);
                                throw ex;
                            }

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
                            rtn.Add(string.IsNullOrEmpty(name.NamespaceName) ? new XmlQualifiedName(name.LocalName) : new XmlQualifiedName(name.LocalName, name.NamespaceName));
                        } catch (XmlException xex)
                        {
                            var ex=new OwsException(OwsExceptionCode.InvalidParameterValue, xex.Message, xex) {
                                Locator=TypeNamesParameter
                            };
                            ex.Data.Add(TypeNamesParameter, tn);
                            throw ex;
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
                        var ex=new OwsException(OwsExceptionCode.InvalidParameterValue, ufex) {
                            Locator=SchemaLanguageParameter
                        };
                        ex.Data.Add(SchemaLanguageParameter, schemaLanguage);
                        throw ex;
                    }

                return request;
            }

            /// <summary>Checks that the specified request is valid.</summary>
            /// <param name="request">The request to check.</param>
            protected override void CheckRequest(Types.DescribeRecord request)
            {
                base.CheckRequest(request);

                if ((request.outputFormat==null) || (Array.IndexOf<string>(XmlMimeTypes, request.outputFormat)<0))
                {
                    var ex=new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OutputFormatParameter
                    };
                    ex.Data.Add(OutputFormatParameter, request.outputFormat);
                    throw ex;
                }

                // The schemaLanguage property is initialized to the strange "http://www.w3.org/XML/Schema" namespace by default, so we have to consider it valid...
                Uri[] schemaNamespaces=new Uri[] { XmlSchemaLanguageUri, StrangeXmlSchemaLanguageUri };
                if ((request.schemaLanguage==null) || (Array.IndexOf<Uri>(schemaNamespaces, request.schemaLanguage)<0))
                {
                    var ex=new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=SchemaLanguageParameter
                    };
                    ex.Data.Add(SchemaLanguageParameter, request.schemaLanguage);
                    throw ex;
                }
            }

            /// <summary>Processes the specified request.</summary>
            /// <param name="request">The request to process.</param>
            /// <returns>The response to the specified request.</returns>
            protected override Task<Types.DescribeRecordResponse> ProcessRequestAsync(Types.DescribeRecord request)
            {
                var ret=new Types.DescribeRecordResponse();

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
                var componentTypes=new List<Types.SchemaComponentType>(request.TypeName.Count);
                foreach (XName name in names)
                {
                    var recordComponentType=new Types.SchemaComponentType() {
                        schemaLanguage=XmlSchemaLanguageUri,
                        targetNamespace=new Uri(name.NamespaceName)
                    };
                    recordComponentType.Untyped.Add(GetRecordSchema(name.Namespace).Root);
                    componentTypes.Add(recordComponentType);
                }
                if (componentTypes.Count>0)
                    ret.SchemaComponent=componentTypes;

                return Task.FromResult(ret);
            }
        }

    }
}
