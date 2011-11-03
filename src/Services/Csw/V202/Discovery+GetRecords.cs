using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using OgcToolkit.Ogc.WebCatalog.Csw.V202;

namespace OgcToolkit.Services.Csw.V202
{
    partial class Discovery
    {

        protected virtual GetRecords CreateGetRecordsRequestFromParameters(NameValueCollection parameters)
        {
            var request=new GetRecords();

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
                        if (!string.IsNullOrEmpty(prefix))
                            request.Untyped.Add(
                                new XAttribute(XNamespace.Xmlns+prefix, m.Groups["URL"])
                            );
                        else
                            request.Untyped.Add(
                                new XAttribute("xmlns", m.Groups["URL"])
                            );
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
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex.Message, ufex) {
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
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex.Message, ufex) {
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
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex.Message, fex) {
                        Locator=StartPositionParameter
                    };
                } catch (OverflowException oex)
                {
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, oex.Message, oex) {
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
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, fex.Message, fex) {
                        Locator=MaxRecordsParameter
                    };
                } catch (OverflowException oex)
                {
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, oex.Message, oex) {
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
                    string[] nameElements=tn.Split(new char[] { ':' }, 2);
                    if (nameElements.Length>1)
                    {
                        // Works because we have already parsed the namespaces
                        XNamespace ns=request.Untyped.GetNamespaceOfPrefix(nameElements[0]);
                        if (ns==null)
                            throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                                Locator=TypeNameParameter
                            };
                        }
                }

                // Cannot seem to be able to use the Query.typeNames property here...
                if (tnp.Count>0)
                {
                    request.Content.AbstractQuery=new Query();
                    request.Content.AbstractQuery.Untyped.SetAttributeValue("{http://www.opengis.net/cat/csw/2.0.2}typeNames", string.Join(" ", tnp));
                }
            }

            // [OCG 07-006r1 §10.6.4.4]
            /*string schemaLanguage=parameters[SchemaLanguageParameter];
            if (!string.IsNullOrEmpty(schemaLanguage))
                try
                {
                    request.schemaLanguage=new Uri(schemaLanguage);
                } catch (UriFormatException ufex)
                {
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue, ufex)
                    {
                        Locator=SchemaLanguageParameter
                    };
                }*/

            return request;
        }
    }
}
