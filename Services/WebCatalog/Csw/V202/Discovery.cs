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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xml.Schema.Linq;

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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.Capabilities" /> for the current discovery service.</returns>
        public Task<Types.Capabilities> GetCapabilitiesAsync(NameValueCollection parameters, CancellationToken cancellationToken)
        {
            return CreateGetCapabilitiesProcessor().ProcessAsync(parameters, cancellationToken);
        }

        /// <summary>Processes the standard GetCapabilities operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.Capabilities" /> for the current discovery service.</returns>
        public Task<Types.Capabilities> GetCapabilitiesAsync(Types.GetCapabilities request, CancellationToken cancellationToken)
        {
            return CreateGetCapabilitiesProcessor().ProcessAsync(request, cancellationToken);
        }

        /// <summary>Processes the standard DescribeRecord operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.DescribeRecordResponse" /> for the operation.</returns>
        public Task<Types.DescribeRecordResponse> DescribeRecordAsync(NameValueCollection parameters, CancellationToken cancellationToken)
        {
            return CreateDescribeRecordProcessor().ProcessAsync(parameters, cancellationToken);
        }

        /// <summary>Processes the standard DescribeRecord operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.DescribeRecordResponse" /> for the operation.</returns>
        public Task<Types.DescribeRecordResponse> DescribeRecordAsync(Types.DescribeRecord request, CancellationToken cancellationToken)
        {
            return CreateDescribeRecordProcessor().ProcessAsync(request, cancellationToken);
        }

        /// <summary>Processes the standard GetRecords operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.IGetRecordsResponse" /> for the operation.</returns>
        public Task<Types.IGetRecordsResponse> GetRecordsAsync(NameValueCollection parameters, CancellationToken cancellationToken)
        {
            return CreateGetRecordsProcessor().ProcessAsync(parameters, cancellationToken);
        }

        /// <summary>Processes the standard GetRecords operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.IGetRecordsResponse" /> for the operation.</returns>
        public Task<Types.IGetRecordsResponse> GetRecordsAsync(Types.GetRecords request, CancellationToken cancellationToken)
        {
            return CreateGetRecordsProcessor().ProcessAsync(request, cancellationToken);
        }

        /// <summary>Processes the standard GetDomain operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.GetDomainResponse" /> for the operation.</returns>
        public Task<Types.GetDomainResponse> GetDomainAsync(Types.GetDomain request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>Processes the standard GetRecordById operation for the current discovery service.</summary>
        /// <param name="parameters">The parameters for the operation in key/value format.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.GetRecordByIdResponse" /> for the operation.</returns>
        public Task<Types.GetRecordByIdResponse> GetRecordByIdAsync(NameValueCollection parameters, CancellationToken cancellationToken)
        {
            return CreateGetRecordByIdProcessor().ProcessAsync(parameters, cancellationToken);
        }

        /// <summary>Processes the standard GetRecordById operation for the current discovery service.</summary>
        /// <param name="request">The parameters for the operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Types.GetRecordByIdResponse" /> for the operation.</returns>
        public Task<Types.GetRecordByIdResponse> GetRecordByIdAsync(Types.GetRecordById request, CancellationToken cancellationToken)
        {
            return CreateGetRecordByIdProcessor().ProcessAsync(request, cancellationToken);
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

        /// <summary>Converts the specified records into the specified XML representation.</summary>
        /// <param name="records">The records to convert.</param>
        /// <param name="outputSchema">The XML schema of the destination representation.</param>
        /// <param name="namespaceManager">The current XML namespace manager.</param>
        /// <param name="elementSet">The element set.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <remarks>By default the records are converted one by one. By overriding this method, you get a chance to
        /// convert the whole batch of records in one go.</remarks>
        /// <returns>The converted records.</returns>
        public virtual async Task<IEnumerable<IXmlSerializable>> ConvertRecordsAsync(IEnumerable<IRecord> records, Uri outputSchema, XmlNamespaceManager namespaceManager, string elementSet, CancellationToken cancellationToken)
        {
            IEnumerable<Task<IXmlSerializable>> tasks=records.Select(r => r.GetConverter(this, outputSchema, namespaceManager).ConvertAsync(r, elementSet, cancellationToken));
            return await Task.WhenAll(tasks)
                .ConfigureAwait(false);
        }

        /// <summary>Converts the specified records into the specified XML representation.</summary>
        /// <param name="records">The records to convert.</param>
        /// <param name="outputSchema">The XML schema of the destination representation.</param>
        /// <param name="namespaceManager">The current XML namespace manager.</param>
        /// <param name="elements">The elements, in XPath representation.</param>
        /// <param name="mayRootPathBeImplied">Whether the XPath elements may omit the root path, or not.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <remarks>By default the records are converted one by one. By overriding this method, you get a chance to
        /// convert the whole batch of records in one go.</remarks>
        /// <returns>The converted records.</returns>
        public virtual async Task<IEnumerable<IXmlSerializable>> ConvertRecordsAsync(IEnumerable<IRecord> records, Uri outputSchema, XmlNamespaceManager namespaceManager, IEnumerable<string> elements, bool mayRootPathBeImplied, CancellationToken cancellationToken)
        {
            IEnumerable<Task<IXmlSerializable>> tasks=records.Select(r => r.GetConverter(this, outputSchema, namespaceManager).ConvertAsync(r, elements, mayRootPathBeImplied, cancellationToken));
            return await Task.WhenAll(tasks)
                .ConfigureAwait(false);
        }

#pragma warning disable 3003
        /// <summary>Gets the list of supported CSW record types for the current discovery service.</summary>
        public virtual IEnumerable<IXMetaData> SupportedRecordTypes
        {
            get
            {
                return _SupportedRecordTypesInstances;
            }
        }
#pragma warning restore 3003

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
