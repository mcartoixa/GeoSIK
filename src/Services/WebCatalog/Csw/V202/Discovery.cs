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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Xml.Schema.Linq;
using Gmd=GeoSik.Iso.Ts19139.Gmd;
using Gml311=GeoSik.Ogc.Gml.V311;
using Filter=GeoSik.Ogc.Filter.V110;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Base implementation of a CSW discovery service.</summary>
    /// <remarks>
    ///   <para>The specification of the discovery service is defined in <token>CSW202Spec</token> §7.2.4.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public abstract partial class Discovery:
        OgcService,
        IDiscovery
    {

        /// <summary>Processes the standard GetCapabilities operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <returns>The <see cref="Types.Capabilities" /> for the current discovery service.</returns>
        public Types.Capabilities GetCapabilities(NameValueCollection parameters)
        {
            return CreateGetCapabilitiesProcessor().Process(parameters);
        }

        /// <summary>Processes the standard GetCapabilities operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <returns>The <see cref="Types.Capabilities" /> for the current discovery service.</returns>
        public Types.Capabilities GetCapabilities(Types.GetCapabilities request)
        {
            return CreateGetCapabilitiesProcessor().Process(request);
        }

        /// <summary>Processes the standard DescribeRecord operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <returns>The <see cref="Types.DescribeRecordResponse" /> for the operation.</returns>
        public Types.DescribeRecordResponse DescribeRecord(NameValueCollection parameters)
        {
            return CreateDescribeRecordProcessor().Process(parameters);
        }

        /// <summary>Processes the standard DescribeRecord operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <returns>The <see cref="Types.DescribeRecordResponse" /> for the operation.</returns>
        public Types.DescribeRecordResponse DescribeRecord(Types.DescribeRecord request)
        {
            return CreateDescribeRecordProcessor().Process(request);
        }

        /// <summary>Processes the standard GetRecords operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <returns>The <see cref="Types.IGetRecordsResponse" /> for the operation.</returns>
        public Types.IGetRecordsResponse GetRecords(NameValueCollection parameters)
        {
            return CreateGetRecordsProcessor().Process(parameters);
        }

        /// <summary>Processes the standard GetRecords operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <returns>The <see cref="Types.IGetRecordsResponse" /> for the operation.</returns>
        public Types.IGetRecordsResponse GetRecords(Types.GetRecords request)
        {
            return CreateGetRecordsProcessor().Process(request);
        }

        /// <summary>Processes the standard GetDomain operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <returns>The <see cref="Types.GetDomainResponse" /> for the operation.</returns>
        public Types.GetDomainResponse GetDomain(Types.GetDomain request)
        {
            throw new NotImplementedException();
        }

        /// <summary>Processes the standard GetRecordById operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <returns>The <see cref="Types.GetRecordByIdResponse" /> for the operation.</returns>
        public Types.GetRecordByIdResponse GetRecordById(NameValueCollection parameters)
        {
            return CreateGetRecordByIdProcessor().Process(parameters);
        }

        /// <summary>Processes the standard GetRecordById operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <returns>The <see cref="Types.GetRecordByIdResponse" /> for the operation.</returns>
        public Types.GetRecordByIdResponse GetRecordById(Types.GetRecordById request)
        {
            return CreateGetRecordByIdProcessor().Process(request);
        }

        /// <summary>Creates a processor for the standard GetCapabilities operation.</summary>
        /// <returns>The processor for the standard GetCapabilities operation.</returns>
        protected virtual GetCapabilitiesProcessorBase CreateGetCapabilitiesProcessor()
        {
            return new GetCapabilitiesProcessorBase(this);
        }

        /// <summary>Creates a processor for the standard DescribeRecord operation.</summary>
        /// <returns>The processor for the standard DescribeRecord operation.</returns>
        protected virtual DescribeRecordProcessorBase CreateDescribeRecordProcessor()
        {
            return new DescribeRecordProcessorBase(this);
        }

        /// <summary>Creates a processor for the standard Getrecords operation.</summary>
        /// <returns>The processor for the standard GetRecords operation.</returns>
        protected virtual GetRecordsProcessorBase CreateGetRecordsProcessor()
        {
            return new GetRecordsProcessorBase(this);
        }

        /// <summary>Creates a processor for the standard GetRecordById operation.</summary>
        /// <returns>The processor for the standard GetrecordById operation.</returns>
        protected virtual GetRecordByIdProcessorBase CreateGetRecordByIdProcessor()
        {
            return new GetRecordByIdProcessorBase(this);
        }

        /// <summary>Gets the source of CSW records for the current discovery service.</summary>
        /// <param name="outputSchema">The schema for the CSW records.</param>
        /// <returns>The source of CSW records for the current discovery service.</returns>
        protected abstract IQueryable GetRecordsSource(Uri outputSchema);

        /// <summary>Gets the list of supported CSW record types for the current discovery service.</summary>
        public virtual IEnumerable<IXMetaData> SupportedRecordTypes
        {
            get
            {
                return _SupportedRecordTypesInstances;
            }
        }

        /// <summary>Gets a custom <see cref="IOperatorImplementationProvider" /> for the current discovery service.</summary>
        /// <returns>a custom <see cref="IOperatorImplementationProvider" /> for the current discovery service.</returns>
        protected virtual IOperatorImplementationProvider GetOperatorImplementationProvider()
        {
            return null;
        }

        private static XDocument GetRecordSchema(XNamespace ns)
        {
            using (var sr=new StringReader(Schemas.ResourceManager.GetString(GetResourceNameFromNamespace(ns.NamespaceName), Schemas.Culture)))
                return XDocument.Load(sr);
        }

        internal static string GetResourceNameFromNamespace(string @namespace)
        {
            return _InvalidFileNameCharsRegEx.Replace(@namespace, "_");
        }

        internal static XName GetXmlNameFromString(string value, XElement parent)
        {
            Debug.Assert(parent!=null);
            if (parent==null)
                throw new ArgumentNullException("parent");

            string[] ne=value.Split(new char[] { ':' }, 2);
            string name=ne[0];
            if (ne.Length>1)
            {
                name=ne[1];
                XNamespace @namespace=parent.GetNamespaceOfPrefix(ne[0]);
                if (@namespace==null)
                    throw new XmlException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.CouldNotFindNamespaceFromPrefix,
                            ne[0]
                        )
                    );

                return XName.Get(name, @namespace.NamespaceName);
            }

            return XName.Get(name);
        }

        /// <summary>Gets the name of the discovery service.</summary>
        /// <remarks>
        ///   <para>A standard implementation should return <c>"CSW"</c>.</para>
        /// </remarks>
        public override string ServiceName
        {
            get { return Service; }
        }

        /// <summary>Gets the version of the discovery service.</summary>
        /// <remarks>
        ///   <para>An implementation based on this class should return <c>"2.0.2"</c>.</para>
        /// </remarks>
        public override string ServiceVersion
        {
            get { return Version; }
        }

        /// <summary>Gets the discovery provider name.</summary>
        public abstract string ProviderName { get; }

        /// <summary>The <see cref="Uri" /> for the XML Schema namespace.</summary>
        protected static readonly Uri XmlSchemaLanguageUri=new Uri(Namespaces.XmlSchemaNamespace);
        /// <summary>The <see cref="Uri" /> for an incorrect XML Schema namespace that is referenced in the CSW standard.</summary>
        protected static readonly Uri StrangeXmlSchemaLanguageUri=new Uri(Namespaces.StrangeXmlSchemaNamespace);

        /// <summary>The name of the Constraint parameter when passed in key/value format.</summary>
        protected const string ConstraintParameter="constraint";
        /// <summary>The name of the ConstraintLanguage parameter when passed in key/value format.</summary>
        protected const string ConstraintLanguageParameter="constraintlanguage";
        /// <summary>The name of the DistributedSearch parameter when passed in key/value format.</summary>
        protected const string DistributedSearchParameter="distributedsearch";
        /// <summary>The name of the ElementName parameter when passed in key/value format.</summary>
        protected const string ElementNameParameter="elementname";
        /// <summary>The name of the ElementSetName parameter when passed in key/value format.</summary>
        protected const string ElementSetNameParameter="elementsetname";
        /// <summary>The name of the HopCount parameter when passed in key/value format.</summary>
        protected const string HopCountParameter="hopcount";
        /// <summary>The name of the Id parameter when passed in key/value format.</summary>
        protected const string IdParameter="id";
        /// <summary>The name of the MaxRecords parameter when passed in key/value format.</summary>
        protected const string MaxRecordsParameter="maxrecords";
        /// <summary>The name of the Namespace parameter when passed in key/value format.</summary>
        protected const string NamespaceParameter="namespace";
        /// <summary>The name of the OutputFormat parameter when passed in key/value format.</summary>
        protected const string OutputFormatParameter="outputformat";
        /// <summary>The name of the OutputSchema parameter when passed in key/value format.</summary>
        protected const string OutputSchemaParameter="outputschema";
        /// <summary>The name of the RequestId parameter when passed in key/value format.</summary>
        protected const string RequestIdParameter="requestid";
        /// <summary>The name of the ResponseHandler parameter when passed in key/value format.</summary>
        protected const string ResponseHandlerParameter="responsehandler";
        /// <summary>The name of the ResultType parameter when passed in key/value format.</summary>
        protected const string ResultTypeParameter="resulttype";
        /// <summary>The name of the SchemaLanguage parameter when passed in key/value format.</summary>
        protected const string SchemaLanguageParameter="schemalanguage";
        /// <summary>The name of the SortBy parameter when passed in key/value format.</summary>
        protected const string SortByParameter="sortby";
        /// <summary>The name of the StartPosition parameter when passed in key/value format.</summary>
        protected const string StartPositionParameter="startposition";
        /// <summary>The name of the TypeName parameter when passed in key/value format.</summary>
        protected const string TypeNameParameter="typename";
        /// <summary>The name of the TypeNames parameter when passed in key/value format.</summary>
        protected const string TypeNamesParameter="typenames";

        private static readonly Regex _NamespacesRegEx=new Regex(@"^xmlns\(((?<PREFIX>\w+)=)?(?<URL>.+)\)$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
        private static readonly Regex _InvalidFileNameCharsRegEx=new Regex(@"\W", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static readonly IXMetaData[] _SupportedRecordTypesInstances=new IXMetaData[] { new Types.Record() };

        /// <summary>The name for the discovery service: <c>"CSW"</c>.</summary>
        public const string Service="CSW";
        /// <summary>The version for the discovery service: <c>"2.0.2"</c>.</summary>
        public const string Version="2.0.2";
    }
}
