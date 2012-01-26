////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

#pragma warning disable 108, 114, 3002, 3003, 3008, 3009
namespace OgcToolkit.Ogc.Ows.V100
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using System.Xml.Linq;
    using Xml.Schema.Linq;
    using OgcToolkit.Ogc.Filter.V110;
    using OgcToolkit.Ogc.Gml.V311;
    using OgcToolkit.Ogc.WebCatalog.Csw.V202;
    using OgcToolkit.DublinCore.Elements.V11;
    using OgcToolkit.DublinCore.Terms;


    [XmlSchemaProviderAttribute("AbstractMetaDataSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractMetaData: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AbstractMetaData(XElement xe) { return (AbstractMetaData)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractMetaData()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AbstractMetaData", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static AbstractMetaData Load(string xmlFile)
        {
            return ((AbstractMetaData)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractMetaData Load(System.IO.TextReader xmlFile)
        {
            return ((AbstractMetaData)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractMetaData Parse(string xml)
        {
            return ((AbstractMetaData)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AbstractMetaDataSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractMetaData", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ServiceIdentificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ServiceIdentification: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Keywords> KeywordsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> ServiceTypeVersionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<AccessConstraints> AccessConstraintsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ServiceIdentification(XElement xe) { return XTypedServices.ToXTypedElement<ServiceIdentification>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ServiceIdentification()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Title", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Abstract", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Keywords", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ServiceType", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ServiceTypeVersion", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Fees", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("AccessConstraints", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public ServiceIdentification()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public Title Title
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Title", "http://www.opengis.net/ows"));
                return ((Title)(x));
            }
            set
            {
                this.SetElement(XName.Get("Title", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public @Abstract @Abstract
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Abstract", "http://www.opengis.net/ows"));
                return ((@Abstract)(x));
            }
            set
            {
                this.SetElement(XName.Get("Abstract", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public IList<Keywords> Keywords
        {
            get
            {
                if ((this.KeywordsField==null))
                {
                    this.KeywordsField=new XTypedList<Keywords>(this, LinqToXsdTypeManager.Instance, XName.Get("Keywords", "http://www.opengis.net/ows"));
                }
                return this.KeywordsField;
            }
            set
            {
                if ((value==null))
                {
                    this.KeywordsField=null;
                } else
                {
                    if ((this.KeywordsField==null))
                    {
                        this.KeywordsField=XTypedList<Keywords>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Keywords", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Keywords>(this.KeywordsField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// A service type name from a registry of services. For example, the values of the codeSpace URI and name and code string may be "OGC" and "catalogue." This type name is normally used for machine-to-machine communication. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public CodeType ServiceType
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ServiceType", "http://www.opengis.net/ows"));
                return ((CodeType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ServiceType", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Unordered list of one or more versions of this service type implemented by this server. This information is not adequate for version negotiation, and shall not be used for that purpose. 
        /// </para>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public IList<string> ServiceTypeVersion
        {
            get
            {
                if ((this.ServiceTypeVersionField==null))
                {
                    this.ServiceTypeVersionField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("ServiceTypeVersion", "http://www.opengis.net/ows"));
                }
                return this.ServiceTypeVersionField;
            }
            set
            {
                if ((value==null))
                {
                    this.ServiceTypeVersionField=null;
                } else
                {
                    if ((this.ServiceTypeVersionField==null))
                    {
                        this.ServiceTypeVersionField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("ServiceTypeVersion", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.ServiceTypeVersionField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// If this element is omitted, no meaning is implied. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public Fees Fees
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Fees", "http://www.opengis.net/ows"));
                return ((Fees)(x));
            }
            set
            {
                this.SetElement(XName.Get("Fees", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Unordered list of access constraints applied to assure the protection of privacy or intellectual property, and any other restrictions on retrieving or using data from or otherwise using this server. The reserved value NONE (case insensitive) shall be used to mean no access constraints are imposed. If this element is omitted, no meaning is implied. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, ServiceType, ServiceTypeVersion+, Fees?, AccessConstraints*)
        /// </para>
        /// </summary>
        public IList<AccessConstraints> AccessConstraints
        {
            get
            {
                if ((this.AccessConstraintsField==null))
                {
                    this.AccessConstraintsField=new XSimpleList<AccessConstraints>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("AccessConstraints", "http://www.opengis.net/ows"));
                }
                return this.AccessConstraintsField;
            }
            set
            {
                if ((value==null))
                {
                    this.AccessConstraintsField=null;
                } else
                {
                    if ((this.AccessConstraintsField==null))
                    {
                        this.AccessConstraintsField=XSimpleList<AccessConstraints>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("AccessConstraints", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<AccessConstraints>(this.AccessConstraintsField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ServiceIdentification", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static ServiceIdentification Load(string xmlFile)
        {
            return XTypedServices.Load<ServiceIdentification>(xmlFile);
        }

        public static ServiceIdentification Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ServiceIdentification>(xmlFile);
        }

        public static ServiceIdentification Parse(string xml)
        {
            return XTypedServices.Parse<ServiceIdentification>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ServiceIdentification>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Title", "http://www.opengis.net/ows"), typeof(Title));
            localElementDictionary.Add(XName.Get("Abstract", "http://www.opengis.net/ows"), typeof(@Abstract));
            localElementDictionary.Add(XName.Get("Keywords", "http://www.opengis.net/ows"), typeof(Keywords));
            localElementDictionary.Add(XName.Get("ServiceType", "http://www.opengis.net/ows"), typeof(CodeType));
            localElementDictionary.Add(XName.Get("ServiceTypeVersion", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("Fees", "http://www.opengis.net/ows"), typeof(Fees));
            localElementDictionary.Add(XName.Get("AccessConstraints", "http://www.opengis.net/ows"), typeof(AccessConstraints));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType ServiceIdentificationSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ServiceIdentification", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (ProviderName, ProviderSite?, ServiceContact)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ServiceProviderSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ServiceProvider: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ServiceProvider(XElement xe) { return XTypedServices.ToXTypedElement<ServiceProvider>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ServiceProvider()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("ProviderName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ProviderSite", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ServiceContact", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (ProviderName, ProviderSite?, ServiceContact)
        /// </para>
        /// </summary>
        public ServiceProvider()
        {
        }

        /// <summary>
        /// <para>
        /// A unique identifier for the service provider organization. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (ProviderName, ProviderSite?, ServiceContact)
        /// </para>
        /// </summary>
        public string ProviderName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ProviderName", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ProviderName", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Reference to the most relevant web site of the service provider. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (ProviderName, ProviderSite?, ServiceContact)
        /// </para>
        /// </summary>
        public OnlineResourceType ProviderSite
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ProviderSite", "http://www.opengis.net/ows"));
                return ((OnlineResourceType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ProviderSite", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Information for contacting the service provider. The OnlineResource element within this ServiceContact element should not be used to reference a web site of the service provider. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (ProviderName, ProviderSite?, ServiceContact)
        /// </para>
        /// </summary>
        public ResponsiblePartySubsetType ServiceContact
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ServiceContact", "http://www.opengis.net/ows"));
                return ((ResponsiblePartySubsetType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ServiceContact", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ServiceProvider", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static ServiceProvider Load(string xmlFile)
        {
            return XTypedServices.Load<ServiceProvider>(xmlFile);
        }

        public static ServiceProvider Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ServiceProvider>(xmlFile);
        }

        public static ServiceProvider Parse(string xml)
        {
            return XTypedServices.Parse<ServiceProvider>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ServiceProvider>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ProviderName", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("ProviderSite", "http://www.opengis.net/ows"), typeof(OnlineResourceType));
            localElementDictionary.Add(XName.Get("ServiceContact", "http://www.opengis.net/ows"), typeof(ResponsiblePartySubsetType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType ServiceProviderSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ServiceProvider", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("OperationsMetadataSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class OperationsMetadata: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Operation> OperationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainType> ParameterField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainType> ConstraintField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator OperationsMetadata(XElement xe) { return XTypedServices.ToXTypedElement<OperationsMetadata>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static OperationsMetadata()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Operation", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Parameter", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Constraint", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
        /// </para>
        /// </summary>
        public OperationsMetadata()
        {
        }

        /// <summary>
        /// <para>
        /// Metadata for unordered list of all the (requests for) operations that this server interface implements. The list of required and optional operations implemented shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
        /// </para>
        /// </summary>
        public IList<Operation> Operation
        {
            get
            {
                if ((this.OperationField==null))
                {
                    this.OperationField=new XTypedList<Operation>(this, LinqToXsdTypeManager.Instance, XName.Get("Operation", "http://www.opengis.net/ows"));
                }
                return this.OperationField;
            }
            set
            {
                if ((value==null))
                {
                    this.OperationField=null;
                } else
                {
                    if ((this.OperationField==null))
                    {
                        this.OperationField=XTypedList<Operation>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Operation", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Operation>(this.OperationField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of parameter valid domains that each apply to one or more operations which this server interface implements. The list of required and optional parameter domain limitations shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
        /// </para>
        /// </summary>
        public IList<DomainType> Parameter
        {
            get
            {
                if ((this.ParameterField==null))
                {
                    this.ParameterField=new XTypedList<DomainType>(this, LinqToXsdTypeManager.Instance, XName.Get("Parameter", "http://www.opengis.net/ows"));
                }
                return this.ParameterField;
            }
            set
            {
                if ((value==null))
                {
                    this.ParameterField=null;
                } else
                {
                    if ((this.ParameterField==null))
                    {
                        this.ParameterField=XTypedList<DomainType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Parameter", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DomainType>(this.ParameterField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of valid domain constraints on non-parameter quantities that each apply to this server. The list of required and optional constraints shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
        /// </para>
        /// </summary>
        public IList<DomainType> Constraint
        {
            get
            {
                if ((this.ConstraintField==null))
                {
                    this.ConstraintField=new XTypedList<DomainType>(this, LinqToXsdTypeManager.Instance, XName.Get("Constraint", "http://www.opengis.net/ows"));
                }
                return this.ConstraintField;
            }
            set
            {
                if ((value==null))
                {
                    this.ConstraintField=null;
                } else
                {
                    if ((this.ConstraintField==null))
                    {
                        this.ConstraintField=XTypedList<DomainType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Constraint", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DomainType>(this.ConstraintField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Operation+, Parameter*, Constraint*, ExtendedCapabilities?)
        /// </para>
        /// </summary>
        public ExtendedCapabilities ExtendedCapabilities
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows"));
                return ((ExtendedCapabilities)(x));
            }
            set
            {
                this.SetElement(XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("OperationsMetadata", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static OperationsMetadata Load(string xmlFile)
        {
            return XTypedServices.Load<OperationsMetadata>(xmlFile);
        }

        public static OperationsMetadata Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<OperationsMetadata>(xmlFile);
        }

        public static OperationsMetadata Parse(string xml)
        {
            return XTypedServices.Parse<OperationsMetadata>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<OperationsMetadata>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Operation", "http://www.opengis.net/ows"), typeof(Operation));
            localElementDictionary.Add(XName.Get("Parameter", "http://www.opengis.net/ows"), typeof(DomainType));
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/ows"), typeof(DomainType));
            localElementDictionary.Add(XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows"), typeof(ExtendedCapabilities));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType OperationsMetadataSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("OperationsMetadata", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("ExtendedCapabilitiesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ExtendedCapabilities: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator ExtendedCapabilities(XElement xe) { return XTypedServices.ToXTypedElement<ExtendedCapabilities>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ExtendedCapabilities()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static ExtendedCapabilities Load(string xmlFile)
        {
            return XTypedServices.Load<ExtendedCapabilities>(xmlFile);
        }

        public static ExtendedCapabilities Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ExtendedCapabilities>(xmlFile);
        }

        public static ExtendedCapabilities Parse(string xml)
        {
            return XTypedServices.Parse<ExtendedCapabilities>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ExtendedCapabilities>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ExtendedCapabilitiesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ExtendedCapabilities", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("OperationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Operation: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DCP> DCPField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainType> ParameterField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainType> ConstraintField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Metadata> MetadataField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Operation(XElement xe) { return XTypedServices.ToXTypedElement<Operation>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Operation()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DCP", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Parameter", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Constraint", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Metadata", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
        /// </para>
        /// </summary>
        public Operation()
        {
        }

        /// <summary>
        /// <para>
        /// Unordered list of Distributed Computing Platforms (DCPs) supported for this operation. At present, only the HTTP DCP is defined, so this element will appear only once. 
        /// </para>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
        /// </para>
        /// </summary>
        public IList<DCP> DCP
        {
            get
            {
                if ((this.DCPField==null))
                {
                    this.DCPField=new XTypedList<DCP>(this, LinqToXsdTypeManager.Instance, XName.Get("DCP", "http://www.opengis.net/ows"));
                }
                return this.DCPField;
            }
            set
            {
                if ((value==null))
                {
                    this.DCPField=null;
                } else
                {
                    if ((this.DCPField==null))
                    {
                        this.DCPField=XTypedList<DCP>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("DCP", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DCP>(this.DCPField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of parameter domains that each apply to this operation which this server implements. If one of these Parameter elements has the same "name" attribute as a Parameter element in the OperationsMetadata element, this Parameter element shall override the other one for this operation. The list of required and optional parameter domain limitations for this operation shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
        /// </para>
        /// </summary>
        public IList<DomainType> Parameter
        {
            get
            {
                if ((this.ParameterField==null))
                {
                    this.ParameterField=new XTypedList<DomainType>(this, LinqToXsdTypeManager.Instance, XName.Get("Parameter", "http://www.opengis.net/ows"));
                }
                return this.ParameterField;
            }
            set
            {
                if ((value==null))
                {
                    this.ParameterField=null;
                } else
                {
                    if ((this.ParameterField==null))
                    {
                        this.ParameterField=XTypedList<DomainType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Parameter", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DomainType>(this.ParameterField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of valid domain constraints on non-parameter quantities that each apply to this operation. If one of these Constraint elements has the same "name" attribute as a Constraint element in the OperationsMetadata element, this Constraint element shall override the other one for this operation. The list of required and optional constraints for this operation shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
        /// </para>
        /// </summary>
        public IList<DomainType> Constraint
        {
            get
            {
                if ((this.ConstraintField==null))
                {
                    this.ConstraintField=new XTypedList<DomainType>(this, LinqToXsdTypeManager.Instance, XName.Get("Constraint", "http://www.opengis.net/ows"));
                }
                return this.ConstraintField;
            }
            set
            {
                if ((value==null))
                {
                    this.ConstraintField=null;
                } else
                {
                    if ((this.ConstraintField==null))
                    {
                        this.ConstraintField=XTypedList<DomainType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Constraint", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DomainType>(this.ConstraintField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of additional metadata about this operation and its' implementation. A list of required and optional metadata elements for this operation should be specified in the Implementation Specification for this service. (Informative: This metadata might specify the operation request parameters or provide the XML Schemas for the operation request.) 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DCP+, Parameter*, Constraint*, Metadata*)
        /// </para>
        /// </summary>
        public IList<Metadata> Metadata
        {
            get
            {
                if ((this.MetadataField==null))
                {
                    this.MetadataField=new XTypedList<Metadata>(this, LinqToXsdTypeManager.Instance, XName.Get("Metadata", "http://www.opengis.net/ows"));
                }
                return this.MetadataField;
            }
            set
            {
                if ((value==null))
                {
                    this.MetadataField=null;
                } else
                {
                    if ((this.MetadataField==null))
                    {
                        this.MetadataField=XTypedList<Metadata>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Metadata", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Metadata>(this.MetadataField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Name or identifier of this operation (request) (for example, GetCapabilities). The list of required and optional operations implemented shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string name
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("name", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("name", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Operation", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Operation Load(string xmlFile)
        {
            return XTypedServices.Load<Operation>(xmlFile);
        }

        public static Operation Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Operation>(xmlFile);
        }

        public static Operation Parse(string xml)
        {
            return XTypedServices.Parse<Operation>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Operation>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DCP", "http://www.opengis.net/ows"), typeof(DCP));
            localElementDictionary.Add(XName.Get("Parameter", "http://www.opengis.net/ows"), typeof(DomainType));
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/ows"), typeof(DomainType));
            localElementDictionary.Add(XName.Get("Metadata", "http://www.opengis.net/ows"), typeof(Metadata));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType OperationSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Operation", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (HTTP)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DCPSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DCP: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DCP(XElement xe) { return XTypedServices.ToXTypedElement<DCP>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DCP()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new NamedContentModelEntity(XName.Get("HTTP", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (HTTP)
        /// </para>
        /// </summary>
        public DCP()
        {
        }

        public DCP(HTTP HTTP)
        {
            this.HTTP=HTTP;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (HTTP)
        /// </para>
        /// </summary>
        public HTTP HTTP
        {
            get
            {
                XElement x=this.GetElement(XName.Get("HTTP", "http://www.opengis.net/ows"));
                return ((HTTP)(x));
            }
            set
            {
                this.SetElement(XName.Get("HTTP", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DCP", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static DCP Load(string xmlFile)
        {
            return XTypedServices.Load<DCP>(xmlFile);
        }

        public static DCP Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DCP>(xmlFile);
        }

        public static DCP Parse(string xml)
        {
            return XTypedServices.Parse<DCP>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<DCP>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("HTTP", "http://www.opengis.net/ows"), typeof(HTTP));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType DCPSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DCP", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Get | Post)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("HTTPSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class HTTP: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<RequestMethodType> GetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<RequestMethodType> PostField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator HTTP(XElement xe) { return XTypedServices.ToXTypedElement<HTTP>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static HTTP()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Get | Post)+
        /// </para>
        /// </summary>
        public HTTP()
        {
        }

        /// <summary>
        /// <para>
        /// Connect point URL prefix and any constraints for the HTTP "Get" request method for this operation request. 
        /// </para>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Get | Post)+
        /// </para>
        /// </summary>
        public IList<RequestMethodType> Get
        {
            get
            {
                if ((this.GetField==null))
                {
                    this.GetField=new XTypedList<RequestMethodType>(this, LinqToXsdTypeManager.Instance, XName.Get("Get", "http://www.opengis.net/ows"));
                }
                return this.GetField;
            }
            set
            {
                if ((value==null))
                {
                    this.GetField=null;
                } else
                {
                    if ((this.GetField==null))
                    {
                        this.GetField=XTypedList<RequestMethodType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Get", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<RequestMethodType>(this.GetField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Connect point URL and any constraints for the HTTP "Post" request method for this operation request. 
        /// </para>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Get | Post)+
        /// </para>
        /// </summary>
        public IList<RequestMethodType> Post
        {
            get
            {
                if ((this.PostField==null))
                {
                    this.PostField=new XTypedList<RequestMethodType>(this, LinqToXsdTypeManager.Instance, XName.Get("Post", "http://www.opengis.net/ows"));
                }
                return this.PostField;
            }
            set
            {
                if ((value==null))
                {
                    this.PostField=null;
                } else
                {
                    if ((this.PostField==null))
                    {
                        this.PostField=XTypedList<RequestMethodType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Post", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<RequestMethodType>(this.PostField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("HTTP", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static HTTP Load(string xmlFile)
        {
            return XTypedServices.Load<HTTP>(xmlFile);
        }

        public static HTTP Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<HTTP>(xmlFile);
        }

        public static HTTP Parse(string xml)
        {
            return XTypedServices.Parse<HTTP>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<HTTP>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Get", "http://www.opengis.net/ows"), typeof(RequestMethodType));
            localElementDictionary.Add(XName.Get("Post", "http://www.opengis.net/ows"), typeof(RequestMethodType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType HTTPSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("HTTP", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Exception+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ExceptionReportSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ExceptionReport: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Exception> ExceptionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ExceptionReport(XElement xe) { return XTypedServices.ToXTypedElement<ExceptionReport>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ExceptionReport()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Exception", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Exception+)
        /// </para>
        /// </summary>
        public ExceptionReport()
        {
        }

        /// <summary>
        /// <para>
        /// Unordered list of one or more Exception elements that each describes an error. These Exception elements shall be interpreted by clients as being independent of one another (not hierarchical). 
        /// </para>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Exception+)
        /// </para>
        /// </summary>
        public IList<Exception> Exception
        {
            get
            {
                if ((this.ExceptionField==null))
                {
                    this.ExceptionField=new XTypedList<Exception>(this, LinqToXsdTypeManager.Instance, XName.Get("Exception", "http://www.opengis.net/ows"));
                }
                return this.ExceptionField;
            }
            set
            {
                if ((value==null))
                {
                    this.ExceptionField=null;
                } else
                {
                    if ((this.ExceptionField==null))
                    {
                        this.ExceptionField=XTypedList<Exception>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Exception", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Exception>(this.ExceptionField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Specification version for OWS operation. The string value shall contain one x.y.z "version" value (e.g., "2.1.3"). A version number shall contain three non-negative integers separated by decimal points, in the form "x.y.z". The integers y and z shall not exceed 99. Each version shall be for the Implementation Specification (document) and the associated XML Schemas to which requested operations will conform. An Implementation Specification version normally specifies XML Schemas against which an XML encoded operation response must conform and should be validated. See Version negotiation subclause for more information. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string version
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("version", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("version", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Identifier of the language used by all included exception text values. These language identifiers shall be as specified in IETF RFC 1766. When this attribute is omitted, the language used is not identified. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string language
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("language", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("language", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ExceptionReport", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static ExceptionReport Load(string xmlFile)
        {
            return XTypedServices.Load<ExceptionReport>(xmlFile);
        }

        public static ExceptionReport Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ExceptionReport>(xmlFile);
        }

        public static ExceptionReport Parse(string xml)
        {
            return XTypedServices.Parse<ExceptionReport>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ExceptionReport>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Exception", "http://www.opengis.net/ows"), typeof(Exception));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType ExceptionReportSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ExceptionReport", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded identifier of a standard MIME type, possibly a parameterized MIME type. 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class MimeType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(8)), null, 0, 0, null, null, 0, null, null, 0, new string[] {
                        "(application|audio|image|text|video|message|multipart|model)/.+(;\\s*.+=.+)*"}, 0, XmlSchemaWhiteSpace.Preserve));

        private MimeType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Specification version for OWS operation. The string value shall contain one x.y.z "version" value (e.g., "2.1.3"). A version number shall contain three non-negative integers separated by decimal points, in the form "x.y.z". The integers y and z shall not exceed 99. Each version shall be for the Implementation Specification (document) and the associated XML Schemas to which requested operations will conform. An Implementation Specification version normally specifies XML Schemas against which an XML encoded operation response must conform and should be validated. See Version negotiation subclause for more information. 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class VersionType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), null);

        private VersionType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// This element either references or contains more metadata about the element that includes this element. To reference metadata stored remotely, at least the xlinks:href attribute in xlink:simpleLink shall be included. Either at least one of the attributes in xlink:simpleLink or a substitute for the AbstractMetaData element shall be included, but not both. An Implementation Specification can restrict the contents of this element to always be a reference or always contain metadata. (Informative: This element was adapted from the metaDataProperty element in GML 3.0.) 
    /// </para>
    /// <para>
    /// Regular expression: (AbstractMetaData?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MetadataTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MetadataType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator MetadataType(XElement xe) { return XTypedServices.ToXTypedElement<MetadataType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static MetadataType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("AbstractMetaData", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// This element either references or contains more metadata about the element that includes this element. To reference metadata stored remotely, at least the xlinks:href attribute in xlink:simpleLink shall be included. Either at least one of the attributes in xlink:simpleLink or a substitute for the AbstractMetaData element shall be included, but not both. An Implementation Specification can restrict the contents of this element to always be a reference or always contain metadata. (Informative: This element was adapted from the metaDataProperty element in GML 3.0.) 
        /// </para>
        /// <para>
        /// Regular expression: (AbstractMetaData?)
        /// </para>
        /// </summary>
        public MetadataType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AbstractMetaData?)
        /// </para>
        /// </summary>
        public AbstractMetaData AbstractMetaData
        {
            get
            {
                XElement x=this.GetElement(XName.Get("AbstractMetaData", "http://www.opengis.net/ows"));
                return ((AbstractMetaData)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractMetaData", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type
        {
            get
            {
                return typeFixedValue;
            }
            set
            {
                if (value.Equals(typeFixedValue))
                {
                } else
                {
                    throw new Xml.Schema.Linq.LinqToXsdFixedValueException(value, typeFixedValue);
                }
                this.SetAttribute(XName.Get("type", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri href
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Optional reference to the aspect of the element which includes this "metadata" element that this metadata provides more information about. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri about
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("about", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("about", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("MetadataType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<MetadataType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractMetaData", "http://www.opengis.net/ows"), typeof(AbstractMetaData));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName MetadataTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("MetadataType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. 
    /// </para>
    /// <para>
    /// This type is adapted from the EnvelopeType of GML 3.1, with modified contents and documentation for encoding a MINIMUM size box SURROUNDING all associated data. 
    /// </para>
    /// <para>
    /// Regular expression: (LowerCorner, UpperCorner)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BoundingBoxTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BoundingBoxType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator BoundingBoxType(XElement xe) { return XTypedServices.ToXTypedElement<BoundingBoxType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BoundingBoxType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("LowerCorner", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("UpperCorner", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. 
        /// </para>
        /// <para>
        /// This type is adapted from the EnvelopeType of GML 3.1, with modified contents and documentation for encoding a MINIMUM size box SURROUNDING all associated data. 
        /// </para>
        /// <para>
        /// Regular expression: (LowerCorner, UpperCorner)
        /// </para>
        /// </summary>
        public BoundingBoxType()
        {
        }

        /// <summary>
        /// <para>
        /// Position of the bounding box corner at which the value of each coordinate normally is the algebraic minimum within this bounding box. In some cases, this position is normally displayed at the top, such as the top left for some image coordinates. For more information, see Subclauses 10.2.5 and C.13. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (LowerCorner, UpperCorner)
        /// </para>
        /// </summary>
        public IList<double> LowerCorner
        {
            get
            {
                XElement x=this.GetElement(XName.Get("LowerCorner", "http://www.opengis.net/ows"));
                return XTypedServices.ParseListValue<double>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
            set
            {
                this.SetListElement(XName.Get("LowerCorner", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Position of the bounding box corner at which the value of each coordinate normally is the algebraic maximum within this bounding box. In some cases, this position is normally displayed at the bottom, such as the bottom right for some image coordinates. For more information, see Subclauses 10.2.5 and C.13. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (LowerCorner, UpperCorner)
        /// </para>
        /// </summary>
        public IList<double> UpperCorner
        {
            get
            {
                XElement x=this.GetElement(XName.Get("UpperCorner", "http://www.opengis.net/ows"));
                return XTypedServices.ParseListValue<double>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
            set
            {
                this.SetListElement(XName.Get("UpperCorner", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Usually references the definition of a CRS, as specified in [OGC Topic 2]. Such a CRS definition can be XML encoded using the gml:CoordinateReferenceSystemType in [GML 3.1]. For well known references, it is not required that a CRS definition exist at the location the URI points to. If no anyURI value is included, the applicable CRS must be either:
        ///a)	Specified outside the bounding box, but inside a data structure that includes this bounding box, as specified for a specific OWS use of this bounding box type.
        ///b)	Fixed and specified in the Implementation Specification for a specific OWS use of the bounding box type. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri crs
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("crs", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("crs", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// The number of dimensions in this CRS (the length of a coordinate sequence in this use of the PositionType). This number is specified by the CRS definition, but can also be specified here. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> dimensions
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("dimensions", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("dimensions", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("BoundingBoxType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<BoundingBoxType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("LowerCorner", "http://www.opengis.net/ows"), typeof(double));
            localElementDictionary.Add(XName.Get("UpperCorner", "http://www.opengis.net/ows"), typeof(double));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName BoundingBoxTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BoundingBoxType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Position instances hold the coordinates of a position in a coordinate reference system (CRS) referenced by the related "crs" attribute or elsewhere. For an angular coordinate axis that is physically continuous for multiple revolutions, but whose recorded values can be discontinuous, special conditions apply when the bounding box is continuous across the value discontinuity:
    ///a)  If the bounding box is continuous clear around this angular axis, then ordinate values of minus and plus infinity shall be used.
    ///b)  If the bounding box is continuous across the value discontinuity but is not continuous clear around this angular axis, then some non-normal value can be used if specified for a specific OWS use of the BoundingBoxType. For more information, see Subclauses 10.2.5 and C.13. 
    /// </para>
    /// <para>
    /// This type is adapted from DirectPositionType and doubleList of GML 3.1. The adaptations include omission of all the attributes, since the needed information is included in the BoundingBoxType. 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class PositionType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.ListSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double), null, new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double), null));

        private PositionType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. This box is specialized for use with the 2D WGS 84 coordinate reference system with decimal values of longitude and latitude. 
    /// </para>
    /// <para>
    /// This type is adapted from the general BoundingBoxType, with modified contents and documentation for use with the 2D WGS 84 coordinate reference system. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("WGS84BoundingBoxTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class WGS84BoundingBoxType: global::OgcToolkit.Ogc.Ows.V100.BoundingBoxType, IXMetaData, IXmlSerializable
    {

        public static explicit operator WGS84BoundingBoxType(XElement xe) { return XTypedServices.ToXTypedElement<WGS84BoundingBoxType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. This box is specialized for use with the 2D WGS 84 coordinate reference system with decimal values of longitude and latitude. 
        /// </para>
        /// <para>
        /// This type is adapted from the general BoundingBoxType, with modified contents and documentation for use with the 2D WGS 84 coordinate reference system. 
        /// </para>
        /// </summary>
        public WGS84BoundingBoxType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("WGS84BoundingBoxType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<WGS84BoundingBoxType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName WGS84BoundingBoxTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("WGS84BoundingBoxType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Two-dimensional position instances hold the longitude and latitude coordinates of a position in the 2D WGS 84 coordinate reference system. The longitude value shall be listed first, followed by the latitude value, both in decimal degrees. Latitude values shall range from -90 to +90 degrees, and longitude values shall normally range from -180 to +180 degrees. For the longitude axis, special conditions apply when the bounding box is continuous across the +/- 180 degrees meridian longitude value discontinuity:
    ///a)  If the bounding box is continuous clear around the Earth, then longitude values of minus and plus infinity shall be used.
    ///b)  If the bounding box is continuous across the value discontinuity but is not continuous clear around the Earth, then some non-normal value can be used if specified for a specific OWS use of the WGS84BoundingBoxType. For more information, see Subclauses 10.4.5 and C.13. 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class PositionType2D
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.ListSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(1)), null, 0, 2, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Collapse), new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double), null));

        private PositionType2D()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Unordered list of one or more commonly used or formalised word(s) or phrase(s) used to describe the subject. When needed, the optional "type" can name the type of the associated list of keywords that shall all have the same type. Also when needed, the codeSpace attribute of that "type" can reference the type name authority and/or thesaurus. 
    /// </para>
    /// <para>
    /// For OWS use, the optional thesaurusName element was omitted as being complex information that could be referenced by the codeSpace attribute of the Type element. 
    /// </para>
    /// <para>
    /// Regular expression: (Keyword+, Type?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("KeywordsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class KeywordsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> KeywordField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator KeywordsType(XElement xe) { return XTypedServices.ToXTypedElement<KeywordsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static KeywordsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Keyword", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Type", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Unordered list of one or more commonly used or formalised word(s) or phrase(s) used to describe the subject. When needed, the optional "type" can name the type of the associated list of keywords that shall all have the same type. Also when needed, the codeSpace attribute of that "type" can reference the type name authority and/or thesaurus. 
        /// </para>
        /// <para>
        /// For OWS use, the optional thesaurusName element was omitted as being complex information that could be referenced by the codeSpace attribute of the Type element. 
        /// </para>
        /// <para>
        /// Regular expression: (Keyword+, Type?)
        /// </para>
        /// </summary>
        public KeywordsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Keyword+, Type?)
        /// </para>
        /// </summary>
        public IList<string> Keyword
        {
            get
            {
                if ((this.KeywordField==null))
                {
                    this.KeywordField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Keyword", "http://www.opengis.net/ows"));
                }
                return this.KeywordField;
            }
            set
            {
                if ((value==null))
                {
                    this.KeywordField=null;
                } else
                {
                    if ((this.KeywordField==null))
                    {
                        this.KeywordField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Keyword", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.KeywordField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Keyword+, Type?)
        /// </para>
        /// </summary>
        public CodeType Type
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Type", "http://www.opengis.net/ows"));
                return ((CodeType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Type", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("KeywordsType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<KeywordsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Keyword", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("Type", "http://www.opengis.net/ows"), typeof(CodeType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName KeywordsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("KeywordsType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
    /// </para>
    /// <para>
    /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("CodeTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CodeType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator CodeType(XElement xe) { return XTypedServices.ToXTypedElement<CodeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
        /// </para>
        /// <para>
        /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
        /// </para>
        /// </summary>
        public CodeType()
        {
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("codeSpace", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("codeSpace", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("CodeType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<CodeType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName CodeTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("CodeType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Identification of, and means of communication with, person responsible for the server. At least one of IndividualName, OrganisationName, or PositionName shall be included. 
    /// </para>
    /// <para>
    /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ResponsiblePartyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ResponsiblePartyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ResponsiblePartyType(XElement xe) { return XTypedServices.ToXTypedElement<ResponsiblePartyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ResponsiblePartyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("IndividualName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("OrganisationName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("PositionName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ContactInfo", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Role", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Identification of, and means of communication with, person responsible for the server. At least one of IndividualName, OrganisationName, or PositionName shall be included. 
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public ResponsiblePartyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public IndividualName IndividualName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("IndividualName", "http://www.opengis.net/ows"));
                return ((IndividualName)(x));
            }
            set
            {
                this.SetElement(XName.Get("IndividualName", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public OrganisationName OrganisationName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("OrganisationName", "http://www.opengis.net/ows"));
                return ((OrganisationName)(x));
            }
            set
            {
                this.SetElement(XName.Get("OrganisationName", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public PositionName PositionName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PositionName", "http://www.opengis.net/ows"));
                return ((PositionName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PositionName", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public ContactInfo ContactInfo
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ContactInfo", "http://www.opengis.net/ows"));
                return ((ContactInfo)(x));
            }
            set
            {
                this.SetElement(XName.Get("ContactInfo", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public Role Role
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Role", "http://www.opengis.net/ows"));
                return ((Role)(x));
            }
            set
            {
                this.SetElement(XName.Get("Role", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ResponsiblePartyType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ResponsiblePartyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("IndividualName", "http://www.opengis.net/ows"), typeof(IndividualName));
            localElementDictionary.Add(XName.Get("OrganisationName", "http://www.opengis.net/ows"), typeof(OrganisationName));
            localElementDictionary.Add(XName.Get("PositionName", "http://www.opengis.net/ows"), typeof(PositionName));
            localElementDictionary.Add(XName.Get("ContactInfo", "http://www.opengis.net/ows"), typeof(ContactInfo));
            localElementDictionary.Add(XName.Get("Role", "http://www.opengis.net/ows"), typeof(Role));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ResponsiblePartyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ResponsiblePartyType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Identification of, and means of communication with, person responsible for the server. 
    /// </para>
    /// <para>
    /// For OWS use in the ServiceProvider section of a service metadata document, the optional organizationName element was removed, since this type is always used with the ProviderName element which provides that information. The mandatory "role" element was changed to optional, since no clear use of this information is known in the ServiceProvider section. 
    /// </para>
    /// <para>
    /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ResponsiblePartySubsetTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ResponsiblePartySubsetType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ResponsiblePartySubsetType(XElement xe) { return XTypedServices.ToXTypedElement<ResponsiblePartySubsetType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ResponsiblePartySubsetType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("IndividualName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("PositionName", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ContactInfo", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Role", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Identification of, and means of communication with, person responsible for the server. 
        /// </para>
        /// <para>
        /// For OWS use in the ServiceProvider section of a service metadata document, the optional organizationName element was removed, since this type is always used with the ProviderName element which provides that information. The mandatory "role" element was changed to optional, since no clear use of this information is known in the ServiceProvider section. 
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
        /// </para>
        /// </summary>
        public ResponsiblePartySubsetType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
        /// </para>
        /// </summary>
        public IndividualName IndividualName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("IndividualName", "http://www.opengis.net/ows"));
                return ((IndividualName)(x));
            }
            set
            {
                this.SetElement(XName.Get("IndividualName", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
        /// </para>
        /// </summary>
        public PositionName PositionName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PositionName", "http://www.opengis.net/ows"));
                return ((PositionName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PositionName", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
        /// </para>
        /// </summary>
        public ContactInfo ContactInfo
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ContactInfo", "http://www.opengis.net/ows"));
                return ((ContactInfo)(x));
            }
            set
            {
                this.SetElement(XName.Get("ContactInfo", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, PositionName?, ContactInfo?, Role?)
        /// </para>
        /// </summary>
        public Role Role
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Role", "http://www.opengis.net/ows"));
                return ((Role)(x));
            }
            set
            {
                this.SetElement(XName.Get("Role", "http://www.opengis.net/ows"), value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ResponsiblePartySubsetType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ResponsiblePartySubsetType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("IndividualName", "http://www.opengis.net/ows"), typeof(IndividualName));
            localElementDictionary.Add(XName.Get("PositionName", "http://www.opengis.net/ows"), typeof(PositionName));
            localElementDictionary.Add(XName.Get("ContactInfo", "http://www.opengis.net/ows"), typeof(ContactInfo));
            localElementDictionary.Add(XName.Get("Role", "http://www.opengis.net/ows"), typeof(Role));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ResponsiblePartySubsetTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ResponsiblePartySubsetType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Information required to enable contact with the responsible person and/or organization. 
    /// </para>
    /// <para>
    /// For OWS use in the service metadata document, the optional hoursOfService and contactInstructions elements were retained, as possibly being useful in the ServiceProvider section. 
    /// </para>
    /// <para>
    /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ContactTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ContactType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ContactType(XElement xe) { return XTypedServices.ToXTypedElement<ContactType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ContactType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Phone", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Address", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("OnlineResource", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("HoursOfService", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ContactInstructions", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Information required to enable contact with the responsible person and/or organization. 
        /// </para>
        /// <para>
        /// For OWS use in the service metadata document, the optional hoursOfService and contactInstructions elements were retained, as possibly being useful in the ServiceProvider section. 
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public ContactType()
        {
        }

        /// <summary>
        /// <para>
        /// Telephone numbers at which the organization or individual may be contacted. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public TelephoneType Phone
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Phone", "http://www.opengis.net/ows"));
                return ((TelephoneType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Phone", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Physical and email address at which the organization or individual may be contacted. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public AddressType Address
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Address", "http://www.opengis.net/ows"));
                return ((AddressType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Address", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// On-line information that can be used to contact the individual or organization. OWS specifics: The xlink:href attribute in the xlink:simpleLink attribute group shall be used to reference this resource. Whenever practical, the xlink:href attribute with type anyURI should be a URL from which more contact information can be electronically retrieved. The xlink:title attribute with type "string" can be used to name this set of information. The other attributes in the xlink:simpleLink attribute group should not be used. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public OnlineResourceType OnlineResource
        {
            get
            {
                XElement x=this.GetElement(XName.Get("OnlineResource", "http://www.opengis.net/ows"));
                return ((OnlineResourceType)(x));
            }
            set
            {
                this.SetElement(XName.Get("OnlineResource", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Time period (including time zone) when individuals can contact the organization or individual. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public string HoursOfService
        {
            get
            {
                XElement x=this.GetElement(XName.Get("HoursOfService", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("HoursOfService", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Supplemental instructions on how or when to contact the individual or organization. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public string ContactInstructions
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ContactInstructions", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ContactInstructions", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ContactType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ContactType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Phone", "http://www.opengis.net/ows"), typeof(TelephoneType));
            localElementDictionary.Add(XName.Get("Address", "http://www.opengis.net/ows"), typeof(AddressType));
            localElementDictionary.Add(XName.Get("OnlineResource", "http://www.opengis.net/ows"), typeof(OnlineResourceType));
            localElementDictionary.Add(XName.Get("HoursOfService", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("ContactInstructions", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ContactTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ContactType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Reference to on-line resource from which data can be obtained. 
    /// </para>
    /// <para>
    /// For OWS use in the service metadata document, the CI_OnlineResource class was XML encoded as the attributeGroup "xlink:simpleLink", as used in GML. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("OnlineResourceTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class OnlineResourceType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        public static explicit operator OnlineResourceType(XElement xe) { return XTypedServices.ToXTypedElement<OnlineResourceType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Reference to on-line resource from which data can be obtained. 
        /// </para>
        /// <para>
        /// For OWS use in the service metadata document, the CI_OnlineResource class was XML encoded as the attributeGroup "xlink:simpleLink", as used in GML. 
        /// </para>
        /// </summary>
        public OnlineResourceType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type
        {
            get
            {
                return typeFixedValue;
            }
            set
            {
                if (value.Equals(typeFixedValue))
                {
                } else
                {
                    throw new Xml.Schema.Linq.LinqToXsdFixedValueException(value, typeFixedValue);
                }
                this.SetAttribute(XName.Get("type", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri href
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("OnlineResourceType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<OnlineResourceType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName OnlineResourceTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("OnlineResourceType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Telephone numbers for contacting the responsible individual or organization. 
    /// </para>
    /// <para>
    /// Regular expression: (Voice*, Facsimile*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TelephoneTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TelephoneType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> VoiceField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> FacsimileField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TelephoneType(XElement xe) { return XTypedServices.ToXTypedElement<TelephoneType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TelephoneType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Voice", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Facsimile", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Telephone numbers for contacting the responsible individual or organization. 
        /// </para>
        /// <para>
        /// Regular expression: (Voice*, Facsimile*)
        /// </para>
        /// </summary>
        public TelephoneType()
        {
        }

        /// <summary>
        /// <para>
        /// Telephone number by which individuals can speak to the responsible organization or individual. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Voice*, Facsimile*)
        /// </para>
        /// </summary>
        public IList<string> Voice
        {
            get
            {
                if ((this.VoiceField==null))
                {
                    this.VoiceField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Voice", "http://www.opengis.net/ows"));
                }
                return this.VoiceField;
            }
            set
            {
                if ((value==null))
                {
                    this.VoiceField=null;
                } else
                {
                    if ((this.VoiceField==null))
                    {
                        this.VoiceField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Voice", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.VoiceField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Telephone number of a facsimile machine for the responsible
        ///organization or individual. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Voice*, Facsimile*)
        /// </para>
        /// </summary>
        public IList<string> Facsimile
        {
            get
            {
                if ((this.FacsimileField==null))
                {
                    this.FacsimileField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Facsimile", "http://www.opengis.net/ows"));
                }
                return this.FacsimileField;
            }
            set
            {
                if ((value==null))
                {
                    this.FacsimileField=null;
                } else
                {
                    if ((this.FacsimileField==null))
                    {
                        this.FacsimileField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Facsimile", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.FacsimileField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("TelephoneType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<TelephoneType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Voice", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("Facsimile", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TelephoneTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TelephoneType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Location of the responsible individual or organization. 
    /// </para>
    /// <para>
    /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AddressTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AddressType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> DeliveryPointField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> ElectronicMailAddressField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator AddressType(XElement xe) { return XTypedServices.ToXTypedElement<AddressType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static AddressType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DeliveryPoint", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("City", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("AdministrativeArea", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("PostalCode", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Country", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ElectronicMailAddress", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Location of the responsible individual or organization. 
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public AddressType()
        {
        }

        /// <summary>
        /// <para>
        /// Address line for the location. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public IList<string> DeliveryPoint
        {
            get
            {
                if ((this.DeliveryPointField==null))
                {
                    this.DeliveryPointField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("DeliveryPoint", "http://www.opengis.net/ows"));
                }
                return this.DeliveryPointField;
            }
            set
            {
                if ((value==null))
                {
                    this.DeliveryPointField=null;
                } else
                {
                    if ((this.DeliveryPointField==null))
                    {
                        this.DeliveryPointField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("DeliveryPoint", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.DeliveryPointField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// City of the location. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public string City
        {
            get
            {
                XElement x=this.GetElement(XName.Get("City", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("City", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// State or province of the location. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public string AdministrativeArea
        {
            get
            {
                XElement x=this.GetElement(XName.Get("AdministrativeArea", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("AdministrativeArea", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// ZIP or other postal code. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public string PostalCode
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PostalCode", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("PostalCode", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Country of the physical address. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public string Country
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Country", "http://www.opengis.net/ows"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Country", "http://www.opengis.net/ows"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Address of the electronic mailbox of the responsible organization or individual. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DeliveryPoint*, City?, AdministrativeArea?, PostalCode?, Country?, ElectronicMailAddress*)
        /// </para>
        /// </summary>
        public IList<string> ElectronicMailAddress
        {
            get
            {
                if ((this.ElectronicMailAddressField==null))
                {
                    this.ElectronicMailAddressField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("ElectronicMailAddress", "http://www.opengis.net/ows"));
                }
                return this.ElectronicMailAddressField;
            }
            set
            {
                if ((value==null))
                {
                    this.ElectronicMailAddressField=null;
                } else
                {
                    if ((this.ElectronicMailAddressField==null))
                    {
                        this.ElectronicMailAddressField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("ElectronicMailAddress", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.ElectronicMailAddressField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AddressType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<AddressType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DeliveryPoint", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("City", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("AdministrativeArea", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("PostalCode", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("Country", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("ElectronicMailAddress", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName AddressTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AddressType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Human-readable descriptive information for the object it is included within.
    ///This type shall be extended if needed for specific OWS use to include additional metadata for each type of information. This type shall not be restricted for a specific OWS to change the multiplicity (or optionality) of some elements. 
    /// </para>
    /// <para>
    /// Regular expression: (Title?, @Abstract?, Keywords*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DescriptionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DescriptionType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Keywords> KeywordsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DescriptionType(XElement xe) { return XTypedServices.ToXTypedElement<DescriptionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DescriptionType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Title", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Abstract", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Keywords", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Human-readable descriptive information for the object it is included within.
        ///This type shall be extended if needed for specific OWS use to include additional metadata for each type of information. This type shall not be restricted for a specific OWS to change the multiplicity (or optionality) of some elements. 
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*)
        /// </para>
        /// </summary>
        public DescriptionType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*)
        /// </para>
        /// </summary>
        public Title Title
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Title", "http://www.opengis.net/ows"));
                return ((Title)(x));
            }
            set
            {
                this.SetElement(XName.Get("Title", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*)
        /// </para>
        /// </summary>
        public @Abstract @Abstract
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Abstract", "http://www.opengis.net/ows"));
                return ((@Abstract)(x));
            }
            set
            {
                this.SetElement(XName.Get("Abstract", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*)
        /// </para>
        /// </summary>
        public IList<Keywords> Keywords
        {
            get
            {
                if ((this.KeywordsField==null))
                {
                    this.KeywordsField=new XTypedList<Keywords>(this, LinqToXsdTypeManager.Instance, XName.Get("Keywords", "http://www.opengis.net/ows"));
                }
                return this.KeywordsField;
            }
            set
            {
                if ((value==null))
                {
                    this.KeywordsField=null;
                } else
                {
                    if ((this.KeywordsField==null))
                    {
                        this.KeywordsField=XTypedList<Keywords>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Keywords", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Keywords>(this.KeywordsField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DescriptionType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<DescriptionType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Title", "http://www.opengis.net/ows"), typeof(Title));
            localElementDictionary.Add(XName.Get("Abstract", "http://www.opengis.net/ows"), typeof(@Abstract));
            localElementDictionary.Add(XName.Get("Keywords", "http://www.opengis.net/ows"), typeof(Keywords));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DescriptionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DescriptionType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// General metadata identifying and describing a set of data. This type shall be extended if needed for each specific OWS to include additional metadata for each type of dataset. If needed, this type should first be restricted for each specific OWS to change the multiplicity (or optionality) of some elements. 
    /// </para>
    /// <para>
    /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("IdentificationTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class IdentificationType: global::OgcToolkit.Ogc.Ows.V100.DescriptionType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<BoundingBox> BoundingBoxField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<OutputFormat> OutputFormatField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<AvailableCRS> AvailableCRSField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Metadata> MetadataField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator IdentificationType(XElement xe) { return XTypedServices.ToXTypedElement<IdentificationType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static IdentificationType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Title", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Abstract", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Keywords", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Identifier", "http://www.opengis.net/ows")), new SubstitutedContentModelEntity(XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("OutputFormat", "http://www.opengis.net/ows")), new SubstitutedContentModelEntity(XName.Get("AvailableCRS", "http://www.opengis.net/ows"), XName.Get("SupportedCRS", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Metadata", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// General metadata identifying and describing a set of data. This type shall be extended if needed for each specific OWS to include additional metadata for each type of dataset. If needed, this type should first be restricted for each specific OWS to change the multiplicity (or optionality) of some elements. 
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public IdentificationType()
        {
        }

        /// <summary>
        /// <para>
        /// Optional unique identifier or name of this dataset. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public Identifier Identifier
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Identifier", "http://www.opengis.net/ows"));
                return ((Identifier)(x));
            }
            set
            {
                this.SetElement(XName.Get("Identifier", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Unordered list of zero or more bounding boxes whose union describes the extent of this dataset. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public IList<BoundingBox> BoundingBox
        {
            get
            {
                if ((this.BoundingBoxField==null))
                {
                    this.BoundingBoxField=new XTypedSubstitutedList<BoundingBox>(this, LinqToXsdTypeManager.Instance, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
                }
                return this.BoundingBoxField;
            }
            set
            {
                if ((value==null))
                {
                    this.BoundingBoxField=null;
                } else
                {
                    if ((this.BoundingBoxField==null))
                    {
                        this.BoundingBoxField=XTypedSubstitutedList<BoundingBox>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<BoundingBox>(this.BoundingBoxField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Unordered list of zero or more references to data formats supported for server outputs. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public IList<OutputFormat> OutputFormat
        {
            get
            {
                if ((this.OutputFormatField==null))
                {
                    this.OutputFormatField=new XSimpleList<OutputFormat>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("OutputFormat", "http://www.opengis.net/ows"));
                }
                return this.OutputFormatField;
            }
            set
            {
                if ((value==null))
                {
                    this.OutputFormatField=null;
                } else
                {
                    if ((this.OutputFormatField==null))
                    {
                        this.OutputFormatField=XSimpleList<OutputFormat>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("OutputFormat", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<OutputFormat>(this.OutputFormatField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Unordered list of zero or more available coordinate reference systems. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: AvailableCRS, SupportedCRS
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public IList<AvailableCRS> AvailableCRS
        {
            get
            {
                if ((this.AvailableCRSField==null))
                {
                    this.AvailableCRSField=new XTypedSubstitutedList<AvailableCRS>(this, LinqToXsdTypeManager.Instance, XName.Get("AvailableCRS", "http://www.opengis.net/ows"), XName.Get("SupportedCRS", "http://www.opengis.net/ows"));
                }
                return this.AvailableCRSField;
            }
            set
            {
                if ((value==null))
                {
                    this.AvailableCRSField=null;
                } else
                {
                    if ((this.AvailableCRSField==null))
                    {
                        this.AvailableCRSField=XTypedSubstitutedList<AvailableCRS>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("AvailableCRS", "http://www.opengis.net/ows"), XName.Get("SupportedCRS", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<AvailableCRS>(this.AvailableCRSField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of additional metadata about this data(set). A list of optional metadata elements for this data identification could be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Title?, @Abstract?, Keywords*, Identifier?, BoundingBox*, OutputFormat*, AvailableCRS*, Metadata*)
        /// </para>
        /// </summary>
        public IList<Metadata> Metadata
        {
            get
            {
                if ((this.MetadataField==null))
                {
                    this.MetadataField=new XTypedList<Metadata>(this, LinqToXsdTypeManager.Instance, XName.Get("Metadata", "http://www.opengis.net/ows"));
                }
                return this.MetadataField;
            }
            set
            {
                if ((value==null))
                {
                    this.MetadataField=null;
                } else
                {
                    if ((this.MetadataField==null))
                    {
                        this.MetadataField=XTypedList<Metadata>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Metadata", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Metadata>(this.MetadataField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("IdentificationType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<IdentificationType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Title", "http://www.opengis.net/ows"), typeof(Title));
            localElementDictionary.Add(XName.Get("Abstract", "http://www.opengis.net/ows"), typeof(@Abstract));
            localElementDictionary.Add(XName.Get("Keywords", "http://www.opengis.net/ows"), typeof(Keywords));
            localElementDictionary.Add(XName.Get("Identifier", "http://www.opengis.net/ows"), typeof(Identifier));
            localElementDictionary.Add(XName.Get("BoundingBox", "http://www.opengis.net/ows"), typeof(BoundingBox));
            localElementDictionary.Add(XName.Get("OutputFormat", "http://www.opengis.net/ows"), typeof(OutputFormat));
            localElementDictionary.Add(XName.Get("AvailableCRS", "http://www.opengis.net/ows"), typeof(AvailableCRS));
            localElementDictionary.Add(XName.Get("Metadata", "http://www.opengis.net/ows"), typeof(Metadata));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName IdentificationTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("IdentificationType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Connect point URL and any constraints for this HTTP request method for this operation request. In the OnlineResourceType, the xlink:href attribute in the xlink:simpleLink attribute group shall be used to contain this URL. The other attributes in the xlink:simpleLink attribute group should not be used. 
    /// </para>
    /// <para>
    /// Regular expression: (Constraint*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RequestMethodTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RequestMethodType: global::OgcToolkit.Ogc.Ows.V100.OnlineResourceType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainType> ConstraintField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator RequestMethodType(XElement xe) { return XTypedServices.ToXTypedElement<RequestMethodType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static RequestMethodType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Constraint", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Connect point URL and any constraints for this HTTP request method for this operation request. In the OnlineResourceType, the xlink:href attribute in the xlink:simpleLink attribute group shall be used to contain this URL. The other attributes in the xlink:simpleLink attribute group should not be used. 
        /// </para>
        /// <para>
        /// Regular expression: (Constraint*)
        /// </para>
        /// </summary>
        public RequestMethodType()
        {
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of valid domain constraints on non-parameter quantities that each apply to this request method for this operation. If one of these Constraint elements has the same "name" attribute as a Constraint element in the OperationsMetadata or Operation element, this Constraint element shall override the other one for this operation. The list of required and optional constraints for this request method for this operation shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Constraint*)
        /// </para>
        /// </summary>
        public IList<DomainType> Constraint
        {
            get
            {
                if ((this.ConstraintField==null))
                {
                    this.ConstraintField=new XTypedList<DomainType>(this, LinqToXsdTypeManager.Instance, XName.Get("Constraint", "http://www.opengis.net/ows"));
                }
                return this.ConstraintField;
            }
            set
            {
                if ((value==null))
                {
                    this.ConstraintField=null;
                } else
                {
                    if ((this.ConstraintField==null))
                    {
                        this.ConstraintField=XTypedList<DomainType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Constraint", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<DomainType>(this.ConstraintField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("RequestMethodType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<RequestMethodType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/ows"), typeof(DomainType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName RequestMethodTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RequestMethodType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Valid domain (or set of values) of one parameter or other quantity used by this server. A non-parameter quantity may not be explicitly represented in the server software. (Informative: An example is the outputFormat parameter of a WFS. Each WFS server should provide a Parameter element for the outputFormat parameter that lists the supported output formats, such as GML2, GML3, etc. as the allowed "Value" elements.) 
    /// </para>
    /// <para>
    /// Regular expression: (Value+, Metadata*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DomainTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DomainType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> ValueField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Metadata> MetadataField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DomainType(XElement xe) { return XTypedServices.ToXTypedElement<DomainType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DomainType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Value", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Metadata", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Valid domain (or set of values) of one parameter or other quantity used by this server. A non-parameter quantity may not be explicitly represented in the server software. (Informative: An example is the outputFormat parameter of a WFS. Each WFS server should provide a Parameter element for the outputFormat parameter that lists the supported output formats, such as GML2, GML3, etc. as the allowed "Value" elements.) 
        /// </para>
        /// <para>
        /// Regular expression: (Value+, Metadata*)
        /// </para>
        /// </summary>
        public DomainType()
        {
        }

        /// <summary>
        /// <para>
        /// Unordered list of all the valid values for this parameter or other quantity. For those parameters that contain a list or sequence of values, these values shall be for individual values in the list. The allowed set of values and the allowed server restrictions on that set of values shall be specified in the Implementation Specification for this service. 
        /// </para>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Value+, Metadata*)
        /// </para>
        /// </summary>
        public IList<string> Value
        {
            get
            {
                if ((this.ValueField==null))
                {
                    this.ValueField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Value", "http://www.opengis.net/ows"));
                }
                return this.ValueField;
            }
            set
            {
                if ((value==null))
                {
                    this.ValueField=null;
                } else
                {
                    if ((this.ValueField==null))
                    {
                        this.ValueField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Value", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.ValueField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Optional unordered list of additional metadata about this parameter. A list of required and optional metadata elements for this domain should be specified in the Implementation Specification for this service. (Informative: This metadata might specify the meanings of the valid values.) 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Value+, Metadata*)
        /// </para>
        /// </summary>
        public IList<Metadata> Metadata
        {
            get
            {
                if ((this.MetadataField==null))
                {
                    this.MetadataField=new XTypedList<Metadata>(this, LinqToXsdTypeManager.Instance, XName.Get("Metadata", "http://www.opengis.net/ows"));
                }
                return this.MetadataField;
            }
            set
            {
                if ((value==null))
                {
                    this.MetadataField=null;
                } else
                {
                    if ((this.MetadataField==null))
                    {
                        this.MetadataField=XTypedList<Metadata>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Metadata", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<Metadata>(this.MetadataField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Name or identifier of this parameter or other quantity. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string name
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("name", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("name", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DomainType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<DomainType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Value", "http://www.opengis.net/ows"), typeof(string));
            localElementDictionary.Add(XName.Get("Metadata", "http://www.opengis.net/ows"), typeof(Metadata));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DomainTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DomainType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded GetCapabilities operation response. This document provides clients with service metadata about a specific service instance, usually including metadata about the tightly-coupled data served. If the server does not implement the updateSequence parameter, the server shall always return the complete Capabilities document, without the updateSequence parameter. When the server implements the updateSequence parameter and the GetCapabilities operation request included the updateSequence parameter with the current value, the server shall return this element with only the "version" and "updateSequence" attributes. Otherwise, all optional elements shall be included or not depending on the actual value of the Contents parameter in the GetCapabilities operation request. This base type shall be extended by each specific OWS to include the additional contents needed. 
    /// </para>
    /// <para>
    /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("CapabilitiesBaseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CapabilitiesBaseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator CapabilitiesBaseType(XElement xe) { return XTypedServices.ToXTypedElement<CapabilitiesBaseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static CapabilitiesBaseType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("ServiceIdentification", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ServiceProvider", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("OperationsMetadata", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// XML encoded GetCapabilities operation response. This document provides clients with service metadata about a specific service instance, usually including metadata about the tightly-coupled data served. If the server does not implement the updateSequence parameter, the server shall always return the complete Capabilities document, without the updateSequence parameter. When the server implements the updateSequence parameter and the GetCapabilities operation request included the updateSequence parameter with the current value, the server shall return this element with only the "version" and "updateSequence" attributes. Otherwise, all optional elements shall be included or not depending on the actual value of the Contents parameter in the GetCapabilities operation request. This base type shall be extended by each specific OWS to include the additional contents needed. 
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?)
        /// </para>
        /// </summary>
        public CapabilitiesBaseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?)
        /// </para>
        /// </summary>
        public ServiceIdentification ServiceIdentification
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ServiceIdentification", "http://www.opengis.net/ows"));
                return ((ServiceIdentification)(x));
            }
            set
            {
                this.SetElement(XName.Get("ServiceIdentification", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?)
        /// </para>
        /// </summary>
        public ServiceProvider ServiceProvider
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ServiceProvider", "http://www.opengis.net/ows"));
                return ((ServiceProvider)(x));
            }
            set
            {
                this.SetElement(XName.Get("ServiceProvider", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?)
        /// </para>
        /// </summary>
        public OperationsMetadata OperationsMetadata
        {
            get
            {
                XElement x=this.GetElement(XName.Get("OperationsMetadata", "http://www.opengis.net/ows"));
                return ((OperationsMetadata)(x));
            }
            set
            {
                this.SetElement(XName.Get("OperationsMetadata", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string version
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("version", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("version", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string updateSequence
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("updateSequence", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("updateSequence", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("CapabilitiesBaseType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<CapabilitiesBaseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ServiceIdentification", "http://www.opengis.net/ows"), typeof(ServiceIdentification));
            localElementDictionary.Add(XName.Get("ServiceProvider", "http://www.opengis.net/ows"), typeof(ServiceProvider));
            localElementDictionary.Add(XName.Get("OperationsMetadata", "http://www.opengis.net/ows"), typeof(OperationsMetadata));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName CapabilitiesBaseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("CapabilitiesBaseType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded GetCapabilities operation request. This operation allows clients to retrieve service metadata about a specific service instance. In this XML encoding, no "request" parameter is included, since the element name specifies the specific operation. This base type shall be extended by each specific OWS to include the additional required "service" attribute, with the correct value for that OWS. 
    /// </para>
    /// <para>
    /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetCapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetCapabilitiesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GetCapabilitiesType(XElement xe) { return XTypedServices.ToXTypedElement<GetCapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetCapabilitiesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("AcceptVersions", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Sections", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("AcceptFormats", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// XML encoded GetCapabilities operation request. This operation allows clients to retrieve service metadata about a specific service instance. In this XML encoding, no "request" parameter is included, since the element name specifies the specific operation. This base type shall be extended by each specific OWS to include the additional required "service" attribute, with the correct value for that OWS. 
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public GetCapabilitiesType()
        {
        }

        /// <summary>
        /// <para>
        /// When omitted, server shall return latest supported version. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public AcceptVersionsType AcceptVersions
        {
            get
            {
                XElement x=this.GetElement(XName.Get("AcceptVersions", "http://www.opengis.net/ows"));
                return ((AcceptVersionsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("AcceptVersions", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return complete service metadata (Capabilities) document. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public SectionsType Sections
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Sections", "http://www.opengis.net/ows"));
                return ((SectionsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Sections", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return service metadata document using the MIME type "text/xml". 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public AcceptFormatsType AcceptFormats
        {
            get
            {
                XElement x=this.GetElement(XName.Get("AcceptFormats", "http://www.opengis.net/ows"));
                return ((AcceptFormatsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("AcceptFormats", "http://www.opengis.net/ows"), value);
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return latest complete service metadata document. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string updateSequence
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("updateSequence", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("updateSequence", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("GetCapabilitiesType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<GetCapabilitiesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AcceptVersions", "http://www.opengis.net/ows"), typeof(AcceptVersionsType));
            localElementDictionary.Add(XName.Get("Sections", "http://www.opengis.net/ows"), typeof(SectionsType));
            localElementDictionary.Add(XName.Get("AcceptFormats", "http://www.opengis.net/ows"), typeof(AcceptFormatsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GetCapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetCapabilitiesType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Service type identifier, where the string value is the OWS type abbreviation, such as "WMS" or "WFS". 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class ServiceType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), null);

        private ServiceType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Prioritized sequence of one or more specification versions accepted by client, with preferred versions listed first. See Version negotiation subclause for more information. 
    /// </para>
    /// <para>
    /// Regular expression: (Version+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AcceptVersionsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AcceptVersionsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> VersionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator AcceptVersionsType(XElement xe) { return XTypedServices.ToXTypedElement<AcceptVersionsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static AcceptVersionsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Version", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Prioritized sequence of one or more specification versions accepted by client, with preferred versions listed first. See Version negotiation subclause for more information. 
        /// </para>
        /// <para>
        /// Regular expression: (Version+)
        /// </para>
        /// </summary>
        public AcceptVersionsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Version+)
        /// </para>
        /// </summary>
        public IList<string> Version
        {
            get
            {
                if ((this.VersionField==null))
                {
                    this.VersionField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Version", "http://www.opengis.net/ows"));
                }
                return this.VersionField;
            }
            set
            {
                if ((value==null))
                {
                    this.VersionField=null;
                } else
                {
                    if ((this.VersionField==null))
                    {
                        this.VersionField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Version", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.VersionField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AcceptVersionsType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<AcceptVersionsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Version", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName AcceptVersionsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AcceptVersionsType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Unordered list of zero or more names of requested sections in complete service metadata document. Each Section value shall contain an allowed section name as specified by each OWS specification. See Sections parameter subclause for more information.  
    /// </para>
    /// <para>
    /// Regular expression: (Section*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SectionsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SectionsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> SectionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SectionsType(XElement xe) { return XTypedServices.ToXTypedElement<SectionsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SectionsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Section", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Unordered list of zero or more names of requested sections in complete service metadata document. Each Section value shall contain an allowed section name as specified by each OWS specification. See Sections parameter subclause for more information.  
        /// </para>
        /// <para>
        /// Regular expression: (Section*)
        /// </para>
        /// </summary>
        public SectionsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Section*)
        /// </para>
        /// </summary>
        public IList<string> Section
        {
            get
            {
                if ((this.SectionField==null))
                {
                    this.SectionField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("Section", "http://www.opengis.net/ows"));
                }
                return this.SectionField;
            }
            set
            {
                if ((value==null))
                {
                    this.SectionField=null;
                } else
                {
                    if ((this.SectionField==null))
                    {
                        this.SectionField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("Section", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.SectionField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SectionsType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<SectionsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Section", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SectionsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SectionsType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// Service metadata document version, having values that are "increased" whenever any change is made in service metadata document. Values are selected by each server, and are always opaque to clients. See updateSequence parameter use subclause for more information. 
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class UpdateSequenceType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), null);

        private UpdateSequenceType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Prioritized sequence of zero or more GetCapabilities operation response formats desired by client, with preferred formats listed first. Each response format shall be identified by its MIME type. See AcceptFormats parameter use subclause for more information. 
    /// </para>
    /// <para>
    /// Regular expression: (OutputFormat*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AcceptFormatsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AcceptFormatsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> OutputFormatField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator AcceptFormatsType(XElement xe) { return XTypedServices.ToXTypedElement<AcceptFormatsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static AcceptFormatsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("OutputFormat", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// Prioritized sequence of zero or more GetCapabilities operation response formats desired by client, with preferred formats listed first. Each response format shall be identified by its MIME type. See AcceptFormats parameter use subclause for more information. 
        /// </para>
        /// <para>
        /// Regular expression: (OutputFormat*)
        /// </para>
        /// </summary>
        public AcceptFormatsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (OutputFormat*)
        /// </para>
        /// </summary>
        public IList<string> OutputFormat
        {
            get
            {
                if ((this.OutputFormatField==null))
                {
                    this.OutputFormatField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("OutputFormat", "http://www.opengis.net/ows"));
                }
                return this.OutputFormatField;
            }
            set
            {
                if ((value==null))
                {
                    this.OutputFormatField=null;
                } else
                {
                    if ((this.OutputFormatField==null))
                    {
                        this.OutputFormatField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("OutputFormat", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.OutputFormatField, value);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AcceptFormatsType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<AcceptFormatsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("OutputFormat", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName AcceptFormatsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AcceptFormatsType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// An Exception element describes one detected error that a server chooses to convey to the client. 
    /// </para>
    /// <para>
    /// Regular expression: (ExceptionText*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ExceptionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ExceptionType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> ExceptionTextField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ExceptionType(XElement xe) { return XTypedServices.ToXTypedElement<ExceptionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ExceptionType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("ExceptionText", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// An Exception element describes one detected error that a server chooses to convey to the client. 
        /// </para>
        /// <para>
        /// Regular expression: (ExceptionText*)
        /// </para>
        /// </summary>
        public ExceptionType()
        {
        }

        /// <summary>
        /// <para>
        /// Ordered sequence of text strings that describe this specific exception or error. The contents of these strings are left open to definition by each server implementation. A server is strongly encouraged to include at least one ExceptionText value, to provide more information about the detected error than provided by the exceptionCode. When included, multiple ExceptionText values shall provide hierarchical information about one detected error, with the most significant information listed first. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (ExceptionText*)
        /// </para>
        /// </summary>
        public IList<string> ExceptionText
        {
            get
            {
                if ((this.ExceptionTextField==null))
                {
                    this.ExceptionTextField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("ExceptionText", "http://www.opengis.net/ows"));
                }
                return this.ExceptionTextField;
            }
            set
            {
                if ((value==null))
                {
                    this.ExceptionTextField=null;
                } else
                {
                    if ((this.ExceptionTextField==null))
                    {
                        this.ExceptionTextField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("ExceptionText", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.ExceptionTextField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// A code representing the type of this exception, which shall be selected from a set of exceptionCode values specified for the specific service operation and server. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string exceptionCode
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("exceptionCode", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("exceptionCode", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// When included, this locator shall indicate to the client where an exception was encountered in servicing the client's operation request. This locator should be included whenever meaningful information can be provided by the server. The contents of this locator will depend on the specific exceptionCode and OWS service, and shall be specified in the OWS Implementation Specification. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string locator
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("locator", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("locator", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                return localElementDictionary;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ExceptionType", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Fragment;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<ExceptionType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ExceptionText", "http://www.opengis.net/ows"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ExceptionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ExceptionType", "http://www.opengis.net/ows");
        }
    }

    /// <summary>
    /// <para>
    /// This element either references or contains more metadata about the element that includes this element. To reference metadata stored remotely, at least the xlinks:href attribute in xlink:simpleLink shall be included. Either at least one of the attributes in xlink:simpleLink or a substitute for the AbstractMetaData element shall be included, but not both. An Implementation Specification can restrict the contents of this element to always be a reference or always contain metadata. (Informative: This element was adapted from the metaDataProperty element in GML 3.0.) 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MetadataSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Metadata: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MetadataType ContentField;

        public static explicit operator Metadata(XElement xe) { return XTypedServices.ToXTypedElement<Metadata, MetadataType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This element either references or contains more metadata about the element that includes this element. To reference metadata stored remotely, at least the xlinks:href attribute in xlink:simpleLink shall be included. Either at least one of the attributes in xlink:simpleLink or a substitute for the AbstractMetaData element shall be included, but not both. An Implementation Specification can restrict the contents of this element to always be a reference or always contain metadata. (Informative: This element was adapted from the metaDataProperty element in GML 3.0.) 
        /// </para>
        /// </summary>
        public Metadata()
        {
            SetInnerType(new MetadataType());
        }

        /// <summary>
        /// <para>
        /// This element either references or contains more metadata about the element that includes this element. To reference metadata stored remotely, at least the xlinks:href attribute in xlink:simpleLink shall be included. Either at least one of the attributes in xlink:simpleLink or a substitute for the AbstractMetaData element shall be included, but not both. An Implementation Specification can restrict the contents of this element to always be a reference or always contain metadata. (Informative: This element was adapted from the metaDataProperty element in GML 3.0.) 
        /// </para>
        /// </summary>
        public Metadata(MetadataType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public MetadataType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AbstractMetaData?)
        /// </para>
        /// </summary>
        public AbstractMetaData AbstractMetaData
        {
            get
            {
                return this.ContentField.AbstractMetaData;
            }
            set
            {
                this.ContentField.AbstractMetaData=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type
        {
            get
            {
                return this.ContentField.type;
            }
            set
            {
                this.ContentField.type=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri href
        {
            get
            {
                return this.ContentField.href;
            }
            set
            {
                this.ContentField.href=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role
        {
            get
            {
                return this.ContentField.role;
            }
            set
            {
                this.ContentField.role=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole
        {
            get
            {
                return this.ContentField.arcrole;
            }
            set
            {
                this.ContentField.arcrole=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title
        {
            get
            {
                return this.ContentField.title;
            }
            set
            {
                this.ContentField.title=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show
        {
            get
            {
                return this.ContentField.show;
            }
            set
            {
                this.ContentField.show=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate
        {
            get
            {
                return this.ContentField.actuate;
            }
            set
            {
                this.ContentField.actuate=value;
            }
        }

        /// <summary>
        /// <para>
        /// Optional reference to the aspect of the element which includes this "metadata" element that this metadata provides more information about. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri about
        {
            get
            {
                return this.ContentField.about;
            }
            set
            {
                this.ContentField.about=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Metadata", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Metadata Load(string xmlFile)
        {
            return XTypedServices.Load<Metadata, MetadataType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Metadata Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Metadata, MetadataType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Metadata Parse(string xml)
        {
            return XTypedServices.Parse<Metadata, MetadataType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Metadata(((MetadataType)(this.Content.Clone())));
        }

        private void SetInnerType(MetadataType ContentField)
        {
            this.ContentField=((MetadataType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MetadataSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Metadata", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. 
    /// </para>
    /// <para>
    /// This type is adapted from the EnvelopeType of GML 3.1, with modified contents and documentation for encoding a MINIMUM size box SURROUNDING all associated data. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BoundingBoxSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BoundingBox: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BoundingBoxType ContentField;

        public static explicit operator BoundingBox(XElement xe) { return (BoundingBox)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected BoundingBox(bool setNull)
        {
        }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. 
        /// </para>
        /// <para>
        /// This type is adapted from the EnvelopeType of GML 3.1, with modified contents and documentation for encoding a MINIMUM size box SURROUNDING all associated data. 
        /// </para>
        /// </summary>
        public BoundingBox()
        {
            SetInnerType(new BoundingBoxType());
        }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. 
        /// </para>
        /// <para>
        /// This type is adapted from the EnvelopeType of GML 3.1, with modified contents and documentation for encoding a MINIMUM size box SURROUNDING all associated data. 
        /// </para>
        /// </summary>
        public BoundingBox(BoundingBoxType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                if ((this.ContentField!=null))
                {
                    this.ContentField.Untyped=value;
                }
            }
        }

        public BoundingBoxType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Position of the bounding box corner at which the value of each coordinate normally is the algebraic minimum within this bounding box. In some cases, this position is normally displayed at the top, such as the top left for some image coordinates. For more information, see Subclauses 10.2.5 and C.13. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (LowerCorner, UpperCorner)
        /// </para>
        /// </summary>
        public IList<double> LowerCorner
        {
            get
            {
                return this.ContentField.LowerCorner;
            }
            set
            {
                this.ContentField.LowerCorner=value;
            }
        }

        /// <summary>
        /// <para>
        /// Position of the bounding box corner at which the value of each coordinate normally is the algebraic maximum within this bounding box. In some cases, this position is normally displayed at the bottom, such as the bottom right for some image coordinates. For more information, see Subclauses 10.2.5 and C.13. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (LowerCorner, UpperCorner)
        /// </para>
        /// </summary>
        public IList<double> UpperCorner
        {
            get
            {
                return this.ContentField.UpperCorner;
            }
            set
            {
                this.ContentField.UpperCorner=value;
            }
        }

        /// <summary>
        /// <para>
        /// Usually references the definition of a CRS, as specified in [OGC Topic 2]. Such a CRS definition can be XML encoded using the gml:CoordinateReferenceSystemType in [GML 3.1]. For well known references, it is not required that a CRS definition exist at the location the URI points to. If no anyURI value is included, the applicable CRS must be either:
        ///a)	Specified outside the bounding box, but inside a data structure that includes this bounding box, as specified for a specific OWS use of this bounding box type.
        ///b)	Fixed and specified in the Implementation Specification for a specific OWS use of the bounding box type. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri crs
        {
            get
            {
                return this.ContentField.crs;
            }
            set
            {
                this.ContentField.crs=value;
            }
        }

        /// <summary>
        /// <para>
        /// The number of dimensions in this CRS (the length of a coordinate sequence in this use of the PositionType). This number is specified by the CRS definition, but can also be specified here. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> dimensions
        {
            get
            {
                return this.ContentField.dimensions;
            }
            set
            {
                this.ContentField.dimensions=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("BoundingBox", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static BoundingBox Load(string xmlFile)
        {
            return ((BoundingBox)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static BoundingBox Load(System.IO.TextReader xmlFile)
        {
            return ((BoundingBox)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static BoundingBox Parse(string xml)
        {
            return ((BoundingBox)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new BoundingBox(((BoundingBoxType)(this.Content.Clone())));
        }

        private void SetInnerType(BoundingBoxType ContentField)
        {
            this.ContentField=((BoundingBoxType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(BoundingBoxType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BoundingBoxSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("BoundingBox", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. This box is specialized for use with the 2D WGS 84 coordinate reference system with decimal values of longitude and latitude. 
    /// </para>
    /// <para>
    /// This type is adapted from the general BoundingBoxType, with modified contents and documentation for use with the 2D WGS 84 coordinate reference system. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("WGS84BoundingBoxSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class WGS84BoundingBox: global::OgcToolkit.Ogc.Ows.V100.BoundingBox, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WGS84BoundingBoxType ContentField;

        public static explicit operator WGS84BoundingBox(XElement xe) { return XTypedServices.ToXTypedElement<WGS84BoundingBox, WGS84BoundingBoxType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. This box is specialized for use with the 2D WGS 84 coordinate reference system with decimal values of longitude and latitude. 
        /// </para>
        /// <para>
        /// This type is adapted from the general BoundingBoxType, with modified contents and documentation for use with the 2D WGS 84 coordinate reference system. 
        /// </para>
        /// </summary>
        public WGS84BoundingBox() :
            base(true)
        {
            SetInnerType(new WGS84BoundingBoxType());
        }

        /// <summary>
        /// <para>
        /// XML encoded minimum rectangular bounding box (or region) parameter, surrounding all the associated data. This box is specialized for use with the 2D WGS 84 coordinate reference system with decimal values of longitude and latitude. 
        /// </para>
        /// <para>
        /// This type is adapted from the general BoundingBoxType, with modified contents and documentation for use with the 2D WGS 84 coordinate reference system. 
        /// </para>
        /// </summary>
        public WGS84BoundingBox(WGS84BoundingBoxType content) :
            base(true)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public new WGS84BoundingBoxType Content
        {
            get
            {
                return ContentField;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public new static WGS84BoundingBox Load(string xmlFile)
        {
            return XTypedServices.Load<WGS84BoundingBox, WGS84BoundingBoxType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static WGS84BoundingBox Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<WGS84BoundingBox, WGS84BoundingBoxType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static WGS84BoundingBox Parse(string xml)
        {
            return XTypedServices.Parse<WGS84BoundingBox, WGS84BoundingBoxType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new WGS84BoundingBox(((WGS84BoundingBoxType)(this.Content.Clone())));
        }

        private void SetInnerType(WGS84BoundingBoxType ContentField)
        {
            this.ContentField=((WGS84BoundingBoxType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType WGS84BoundingBoxSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("WGS84BoundingBox", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("TitleSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Title: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Title(XElement xe) { return XTypedServices.ToXTypedElement<Title>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Title()
        {
        }

        public Title(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Title", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Title Load(string xmlFile)
        {
            return XTypedServices.Load<Title>(xmlFile);
        }

        public static Title Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Title>(xmlFile);
        }

        public static Title Parse(string xml)
        {
            return XTypedServices.Parse<Title>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Title>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TitleSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Title", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("@AbstractSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class @Abstract: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator @Abstract(XElement xe) { return XTypedServices.ToXTypedElement<@Abstract>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public @Abstract()
        {
        }

        public @Abstract(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Abstract", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static @Abstract Load(string xmlFile)
        {
            return XTypedServices.Load<@Abstract>(xmlFile);
        }

        public static @Abstract Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<@Abstract>(xmlFile);
        }

        public static @Abstract Parse(string xml)
        {
            return XTypedServices.Parse<@Abstract>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<@Abstract>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType @AbstractSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Abstract", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Unordered list of one or more commonly used or formalised word(s) or phrase(s) used to describe the subject. When needed, the optional "type" can name the type of the associated list of keywords that shall all have the same type. Also when needed, the codeSpace attribute of that "type" can reference the type name authority and/or thesaurus. 
    /// </para>
    /// <para>
    /// For OWS use, the optional thesaurusName element was omitted as being complex information that could be referenced by the codeSpace attribute of the Type element. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("KeywordsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Keywords: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KeywordsType ContentField;

        public static explicit operator Keywords(XElement xe) { return XTypedServices.ToXTypedElement<Keywords, KeywordsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Unordered list of one or more commonly used or formalised word(s) or phrase(s) used to describe the subject. When needed, the optional "type" can name the type of the associated list of keywords that shall all have the same type. Also when needed, the codeSpace attribute of that "type" can reference the type name authority and/or thesaurus. 
        /// </para>
        /// <para>
        /// For OWS use, the optional thesaurusName element was omitted as being complex information that could be referenced by the codeSpace attribute of the Type element. 
        /// </para>
        /// </summary>
        public Keywords()
        {
            SetInnerType(new KeywordsType());
        }

        /// <summary>
        /// <para>
        /// Unordered list of one or more commonly used or formalised word(s) or phrase(s) used to describe the subject. When needed, the optional "type" can name the type of the associated list of keywords that shall all have the same type. Also when needed, the codeSpace attribute of that "type" can reference the type name authority and/or thesaurus. 
        /// </para>
        /// <para>
        /// For OWS use, the optional thesaurusName element was omitted as being complex information that could be referenced by the codeSpace attribute of the Type element. 
        /// </para>
        /// </summary>
        public Keywords(KeywordsType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public KeywordsType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Keyword+, Type?)
        /// </para>
        /// </summary>
        public IList<string> Keyword
        {
            get
            {
                return this.ContentField.Keyword;
            }
            set
            {
                this.ContentField.Keyword=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Keyword+, Type?)
        /// </para>
        /// </summary>
        public CodeType Type
        {
            get
            {
                return this.ContentField.Type;
            }
            set
            {
                this.ContentField.Type=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Keywords", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Keywords Load(string xmlFile)
        {
            return XTypedServices.Load<Keywords, KeywordsType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Keywords Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Keywords, KeywordsType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Keywords Parse(string xml)
        {
            return XTypedServices.Parse<Keywords, KeywordsType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Keywords(((KeywordsType)(this.Content.Clone())));
        }

        private void SetInnerType(KeywordsType ContentField)
        {
            this.ContentField=((KeywordsType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType KeywordsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Keywords", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Identification of, and means of communication with, person responsible for the server. At least one of IndividualName, OrganisationName, or PositionName shall be included. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("PointOfContactSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PointOfContact: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ResponsiblePartyType ContentField;

        public static explicit operator PointOfContact(XElement xe) { return XTypedServices.ToXTypedElement<PointOfContact, ResponsiblePartyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Identification of, and means of communication with, person responsible for the server. At least one of IndividualName, OrganisationName, or PositionName shall be included. 
        /// </para>
        /// </summary>
        public PointOfContact()
        {
            SetInnerType(new ResponsiblePartyType());
        }

        /// <summary>
        /// <para>
        /// Identification of, and means of communication with, person responsible for the server. At least one of IndividualName, OrganisationName, or PositionName shall be included. 
        /// </para>
        /// </summary>
        public PointOfContact(ResponsiblePartyType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public ResponsiblePartyType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public IndividualName IndividualName
        {
            get
            {
                return this.ContentField.IndividualName;
            }
            set
            {
                this.ContentField.IndividualName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public OrganisationName OrganisationName
        {
            get
            {
                return this.ContentField.OrganisationName;
            }
            set
            {
                this.ContentField.OrganisationName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public PositionName PositionName
        {
            get
            {
                return this.ContentField.PositionName;
            }
            set
            {
                this.ContentField.PositionName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public ContactInfo ContactInfo
        {
            get
            {
                return this.ContentField.ContactInfo;
            }
            set
            {
                this.ContentField.ContactInfo=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (IndividualName?, OrganisationName?, PositionName?, ContactInfo?, Role)
        /// </para>
        /// </summary>
        public Role Role
        {
            get
            {
                return this.ContentField.Role;
            }
            set
            {
                this.ContentField.Role=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("PointOfContact", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static PointOfContact Load(string xmlFile)
        {
            return XTypedServices.Load<PointOfContact, ResponsiblePartyType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PointOfContact Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PointOfContact, ResponsiblePartyType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PointOfContact Parse(string xml)
        {
            return XTypedServices.Parse<PointOfContact, ResponsiblePartyType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PointOfContact(((ResponsiblePartyType)(this.Content.Clone())));
        }

        private void SetInnerType(ResponsiblePartyType ContentField)
        {
            this.ContentField=((ResponsiblePartyType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PointOfContactSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PointOfContact", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("IndividualNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class IndividualName: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator IndividualName(XElement xe) { return XTypedServices.ToXTypedElement<IndividualName>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public IndividualName()
        {
        }

        public IndividualName(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("IndividualName", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static IndividualName Load(string xmlFile)
        {
            return XTypedServices.Load<IndividualName>(xmlFile);
        }

        public static IndividualName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<IndividualName>(xmlFile);
        }

        public static IndividualName Parse(string xml)
        {
            return XTypedServices.Parse<IndividualName>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<IndividualName>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType IndividualNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("IndividualName", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("OrganisationNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class OrganisationName: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator OrganisationName(XElement xe) { return XTypedServices.ToXTypedElement<OrganisationName>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public OrganisationName()
        {
        }

        public OrganisationName(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("OrganisationName", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static OrganisationName Load(string xmlFile)
        {
            return XTypedServices.Load<OrganisationName>(xmlFile);
        }

        public static OrganisationName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<OrganisationName>(xmlFile);
        }

        public static OrganisationName Parse(string xml)
        {
            return XTypedServices.Parse<OrganisationName>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<OrganisationName>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType OrganisationNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("OrganisationName", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PositionNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PositionName: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator PositionName(XElement xe) { return XTypedServices.ToXTypedElement<PositionName>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PositionName()
        {
        }

        public PositionName(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("PositionName", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static PositionName Load(string xmlFile)
        {
            return XTypedServices.Load<PositionName>(xmlFile);
        }

        public static PositionName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PositionName>(xmlFile);
        }

        public static PositionName Parse(string xml)
        {
            return XTypedServices.Parse<PositionName>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<PositionName>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PositionNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PositionName", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
    /// </para>
    /// <para>
    /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RoleSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Role: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CodeType ContentField;

        public static explicit operator Role(XElement xe) { return XTypedServices.ToXTypedElement<Role, CodeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
        /// </para>
        /// <para>
        /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
        /// </para>
        /// </summary>
        public Role()
        {
            SetInnerType(new CodeType());
        }

        /// <summary>
        /// <para>
        /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
        /// </para>
        /// <para>
        /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
        /// </para>
        /// </summary>
        public Role(CodeType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public CodeType Content
        {
            get
            {
                return ContentField;
            }
        }

        public string TypedValue
        {
            get
            {
                return this.ContentField.TypedValue;
            }
            set
            {
                this.ContentField.TypedValue=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace
        {
            get
            {
                return this.ContentField.codeSpace;
            }
            set
            {
                this.ContentField.codeSpace=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Role", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Role Load(string xmlFile)
        {
            return XTypedServices.Load<Role, CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Role Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Role, CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Role Parse(string xml)
        {
            return XTypedServices.Parse<Role, CodeType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Role(((CodeType)(this.Content.Clone())));
        }

        private void SetInnerType(CodeType ContentField)
        {
            this.ContentField=((CodeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RoleSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Role", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Information required to enable contact with the responsible person and/or organization. 
    /// </para>
    /// <para>
    /// For OWS use in the service metadata document, the optional hoursOfService and contactInstructions elements were retained, as possibly being useful in the ServiceProvider section. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ContactInfoSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ContactInfo: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContactType ContentField;

        public static explicit operator ContactInfo(XElement xe) { return XTypedServices.ToXTypedElement<ContactInfo, ContactType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Information required to enable contact with the responsible person and/or organization. 
        /// </para>
        /// <para>
        /// For OWS use in the service metadata document, the optional hoursOfService and contactInstructions elements were retained, as possibly being useful in the ServiceProvider section. 
        /// </para>
        /// </summary>
        public ContactInfo()
        {
            SetInnerType(new ContactType());
        }

        /// <summary>
        /// <para>
        /// Information required to enable contact with the responsible person and/or organization. 
        /// </para>
        /// <para>
        /// For OWS use in the service metadata document, the optional hoursOfService and contactInstructions elements were retained, as possibly being useful in the ServiceProvider section. 
        /// </para>
        /// </summary>
        public ContactInfo(ContactType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public ContactType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Telephone numbers at which the organization or individual may be contacted. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public TelephoneType Phone
        {
            get
            {
                return this.ContentField.Phone;
            }
            set
            {
                this.ContentField.Phone=value;
            }
        }

        /// <summary>
        /// <para>
        /// Physical and email address at which the organization or individual may be contacted. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public AddressType Address
        {
            get
            {
                return this.ContentField.Address;
            }
            set
            {
                this.ContentField.Address=value;
            }
        }

        /// <summary>
        /// <para>
        /// On-line information that can be used to contact the individual or organization. OWS specifics: The xlink:href attribute in the xlink:simpleLink attribute group shall be used to reference this resource. Whenever practical, the xlink:href attribute with type anyURI should be a URL from which more contact information can be electronically retrieved. The xlink:title attribute with type "string" can be used to name this set of information. The other attributes in the xlink:simpleLink attribute group should not be used. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public OnlineResourceType OnlineResource
        {
            get
            {
                return this.ContentField.OnlineResource;
            }
            set
            {
                this.ContentField.OnlineResource=value;
            }
        }

        /// <summary>
        /// <para>
        /// Time period (including time zone) when individuals can contact the organization or individual. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public string HoursOfService
        {
            get
            {
                return this.ContentField.HoursOfService;
            }
            set
            {
                this.ContentField.HoursOfService=value;
            }
        }

        /// <summary>
        /// <para>
        /// Supplemental instructions on how or when to contact the individual or organization. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Phone?, Address?, OnlineResource?, HoursOfService?, ContactInstructions?)
        /// </para>
        /// </summary>
        public string ContactInstructions
        {
            get
            {
                return this.ContentField.ContactInstructions;
            }
            set
            {
                this.ContentField.ContactInstructions=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ContactInfo", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static ContactInfo Load(string xmlFile)
        {
            return XTypedServices.Load<ContactInfo, ContactType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static ContactInfo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ContactInfo, ContactType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static ContactInfo Parse(string xml)
        {
            return XTypedServices.Parse<ContactInfo, ContactType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new ContactInfo(((ContactType)(this.Content.Clone())));
        }

        private void SetInnerType(ContactType ContentField)
        {
            this.ContentField=((ContactType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ContactInfoSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ContactInfo", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
    /// </para>
    /// <para>
    /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("IdentifierSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Identifier: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CodeType ContentField;

        public static explicit operator Identifier(XElement xe) { return XTypedServices.ToXTypedElement<Identifier, CodeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
        /// </para>
        /// <para>
        /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
        /// </para>
        /// </summary>
        public Identifier()
        {
            SetInnerType(new CodeType());
        }

        /// <summary>
        /// <para>
        /// Name or code with an (optional) authority. If the codeSpace attribute is present, its value should reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken. 
        /// </para>
        /// <para>
        /// Type copied from basicTypes.xsd of GML 3 with documentation edited, for possible use outside the ServiceIdentification section of a service metadata document. 
        /// </para>
        /// </summary>
        public Identifier(CodeType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public CodeType Content
        {
            get
            {
                return ContentField;
            }
        }

        public string TypedValue
        {
            get
            {
                return this.ContentField.TypedValue;
            }
            set
            {
                this.ContentField.TypedValue=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace
        {
            get
            {
                return this.ContentField.codeSpace;
            }
            set
            {
                this.ContentField.codeSpace=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Identifier", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Identifier Load(string xmlFile)
        {
            return XTypedServices.Load<Identifier, CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Identifier Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Identifier, CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Identifier Parse(string xml)
        {
            return XTypedServices.Parse<Identifier, CodeType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Identifier(((CodeType)(this.Content.Clone())));
        }

        private void SetInnerType(CodeType ContentField)
        {
            this.ContentField=((CodeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType IdentifierSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Identifier", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded identifier of a standard MIME type, possibly a parameterized MIME type. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("OutputFormatSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class OutputFormat: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator OutputFormat(XElement xe) { return XTypedServices.ToXTypedElement<OutputFormat>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// XML encoded identifier of a standard MIME type, possibly a parameterized MIME type. 
        /// </para>
        /// </summary>
        public OutputFormat()
        {
        }

        /// <summary>
        /// <para>
        /// XML encoded identifier of a standard MIME type, possibly a parameterized MIME type. 
        /// </para>
        /// </summary>
        public OutputFormat(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValueWithValidation(value, "TypedValue", global::OgcToolkit.Ogc.Ows.V100.MimeType.TypeDefinition);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("OutputFormat", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static OutputFormat Load(string xmlFile)
        {
            return XTypedServices.Load<OutputFormat>(xmlFile);
        }

        public static OutputFormat Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<OutputFormat>(xmlFile);
        }

        public static OutputFormat Parse(string xml)
        {
            return XTypedServices.Parse<OutputFormat>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<OutputFormat>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType OutputFormatSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("OutputFormat", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AvailableCRSSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AvailableCRS: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AvailableCRS(XElement xe) { return (AvailableCRS)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AvailableCRS()
        {
        }

        public AvailableCRS(System.Uri content)
        {
            this.TypedValue=content;
        }

        public System.Uri TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AvailableCRS", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static AvailableCRS Load(string xmlFile)
        {
            return ((AvailableCRS)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AvailableCRS Load(System.IO.TextReader xmlFile)
        {
            return ((AvailableCRS)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AvailableCRS Parse(string xml)
        {
            return ((AvailableCRS)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<AvailableCRS>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AvailableCRSSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AvailableCRS", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("SupportedCRSSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SupportedCRS: global::OgcToolkit.Ogc.Ows.V100.AvailableCRS, IXMetaData, IXmlSerializable
    {

        public static explicit operator SupportedCRS(XElement xe) { return XTypedServices.ToXTypedElement<SupportedCRS>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public SupportedCRS()
        {
        }

        public SupportedCRS(System.Uri content)
        {
            this.TypedValue=content;
        }

        public new System.Uri TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SupportedCRS", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public new static SupportedCRS Load(string xmlFile)
        {
            return XTypedServices.Load<SupportedCRS>(xmlFile);
        }

        public static SupportedCRS Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<SupportedCRS>(xmlFile);
        }

        public new static SupportedCRS Parse(string xml)
        {
            return XTypedServices.Parse<SupportedCRS>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<SupportedCRS>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType SupportedCRSSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SupportedCRS", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AccessConstraintsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AccessConstraints: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AccessConstraints(XElement xe) { return XTypedServices.ToXTypedElement<AccessConstraints>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AccessConstraints()
        {
        }

        public AccessConstraints(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AccessConstraints", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static AccessConstraints Load(string xmlFile)
        {
            return XTypedServices.Load<AccessConstraints>(xmlFile);
        }

        public static AccessConstraints Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<AccessConstraints>(xmlFile);
        }

        public static AccessConstraints Parse(string xml)
        {
            return XTypedServices.Parse<AccessConstraints>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<AccessConstraints>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AccessConstraintsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AccessConstraints", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("FeesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Fees: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Fees(XElement xe) { return XTypedServices.ToXTypedElement<Fees>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Fees()
        {
        }

        public Fees(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Fees", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Fees Load(string xmlFile)
        {
            return XTypedServices.Load<Fees>(xmlFile);
        }

        public static Fees Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Fees>(xmlFile);
        }

        public static Fees Parse(string xml)
        {
            return XTypedServices.Parse<Fees>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Fees>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType FeesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Fees", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("LanguageSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Language: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Language(XElement xe) { return XTypedServices.ToXTypedElement<Language>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Language()
        {
        }

        public Language(string content)
        {
            this.TypedValue=content;
        }

        public string TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Language", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Language Load(string xmlFile)
        {
            return XTypedServices.Load<Language>(xmlFile);
        }

        public static Language Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Language>(xmlFile);
        }

        public static Language Parse(string xml)
        {
            return XTypedServices.Parse<Language>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Language>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType LanguageSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Language", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// XML encoded GetCapabilities operation request. This operation allows clients to retrieve service metadata about a specific service instance. In this XML encoding, no "request" parameter is included, since the element name specifies the specific operation. This base type shall be extended by each specific OWS to include the additional required "service" attribute, with the correct value for that OWS. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetCapabilitiesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetCapabilities: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetCapabilitiesType ContentField;

        public static explicit operator GetCapabilities(XElement xe) { return XTypedServices.ToXTypedElement<GetCapabilities, GetCapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// XML encoded GetCapabilities operation request. This operation allows clients to retrieve service metadata about a specific service instance. In this XML encoding, no "request" parameter is included, since the element name specifies the specific operation. This base type shall be extended by each specific OWS to include the additional required "service" attribute, with the correct value for that OWS. 
        /// </para>
        /// </summary>
        public GetCapabilities()
        {
            SetInnerType(new GetCapabilitiesType());
        }

        /// <summary>
        /// <para>
        /// XML encoded GetCapabilities operation request. This operation allows clients to retrieve service metadata about a specific service instance. In this XML encoding, no "request" parameter is included, since the element name specifies the specific operation. This base type shall be extended by each specific OWS to include the additional required "service" attribute, with the correct value for that OWS. 
        /// </para>
        /// </summary>
        public GetCapabilities(GetCapabilitiesType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public GetCapabilitiesType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// When omitted, server shall return latest supported version. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public AcceptVersionsType AcceptVersions
        {
            get
            {
                return this.ContentField.AcceptVersions;
            }
            set
            {
                this.ContentField.AcceptVersions=value;
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return complete service metadata (Capabilities) document. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public SectionsType Sections
        {
            get
            {
                return this.ContentField.Sections;
            }
            set
            {
                this.ContentField.Sections=value;
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return service metadata document using the MIME type "text/xml". 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
        /// </para>
        /// </summary>
        public AcceptFormatsType AcceptFormats
        {
            get
            {
                return this.ContentField.AcceptFormats;
            }
            set
            {
                this.ContentField.AcceptFormats=value;
            }
        }

        /// <summary>
        /// <para>
        /// When omitted or not supported by server, server shall return latest complete service metadata document. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string updateSequence
        {
            get
            {
                return this.ContentField.updateSequence;
            }
            set
            {
                this.ContentField.updateSequence=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("GetCapabilities", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static GetCapabilities Load(string xmlFile)
        {
            return XTypedServices.Load<GetCapabilities, GetCapabilitiesType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetCapabilities Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetCapabilities, GetCapabilitiesType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetCapabilities Parse(string xml)
        {
            return XTypedServices.Parse<GetCapabilities, GetCapabilitiesType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetCapabilities(((GetCapabilitiesType)(this.Content.Clone())));
        }

        private void SetInnerType(GetCapabilitiesType ContentField)
        {
            this.ContentField=((GetCapabilitiesType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetCapabilitiesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetCapabilities", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// An Exception element describes one detected error that a server chooses to convey to the client. 
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ExceptionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Exception: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExceptionType ContentField;

        public static explicit operator Exception(XElement xe) { return XTypedServices.ToXTypedElement<Exception, ExceptionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// An Exception element describes one detected error that a server chooses to convey to the client. 
        /// </para>
        /// </summary>
        public Exception()
        {
            SetInnerType(new ExceptionType());
        }

        /// <summary>
        /// <para>
        /// An Exception element describes one detected error that a server chooses to convey to the client. 
        /// </para>
        /// </summary>
        public Exception(ExceptionType content)
        {
            SetInnerType(content);
        }

        public override XElement Untyped
        {
            get
            {
                return base.Untyped;
            }
            set
            {
                base.Untyped=value;
                this.ContentField.Untyped=value;
            }
        }

        public ExceptionType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Ordered sequence of text strings that describe this specific exception or error. The contents of these strings are left open to definition by each server implementation. A server is strongly encouraged to include at least one ExceptionText value, to provide more information about the detected error than provided by the exceptionCode. When included, multiple ExceptionText values shall provide hierarchical information about one detected error, with the most significant information listed first. 
        /// </para>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (ExceptionText*)
        /// </para>
        /// </summary>
        public IList<string> ExceptionText
        {
            get
            {
                return this.ContentField.ExceptionText;
            }
            set
            {
                this.ContentField.ExceptionText=value;
            }
        }

        /// <summary>
        /// <para>
        /// A code representing the type of this exception, which shall be selected from a set of exceptionCode values specified for the specific service operation and server. 
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string exceptionCode
        {
            get
            {
                return this.ContentField.exceptionCode;
            }
            set
            {
                this.ContentField.exceptionCode=value;
            }
        }

        /// <summary>
        /// <para>
        /// When included, this locator shall indicate to the client where an exception was encountered in servicing the client's operation request. This locator should be included whenever meaningful information can be provided by the server. The contents of this locator will depend on the specific exceptionCode and OWS service, and shall be specified in the OWS Implementation Specification. 
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string locator
        {
            get
            {
                return this.ContentField.locator;
            }
            set
            {
                this.ContentField.locator=value;
            }
        }

        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary
        {
            get
            {
                IXMetaData schemaMetaData=((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }

        XTypedElement IXMetaData.Content
        {
            get
            {
                return this.Content;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Exception", "http://www.opengis.net/ows");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin
        {
            get
            {
                return SchemaOrigin.Element;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager
        {
            get
            {
                return LinqToXsdTypeManager.Instance;
            }
        }

        public void Save(string xmlFile)
        {
            XTypedServices.Save(xmlFile, Untyped);
        }

        public void Save(System.IO.TextWriter tw)
        {
            XTypedServices.Save(tw, Untyped);
        }

        public void Save(System.Xml.XmlWriter xmlWriter)
        {
            XTypedServices.Save(xmlWriter, Untyped);
        }

        public static Exception Load(string xmlFile)
        {
            return XTypedServices.Load<Exception, ExceptionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Exception Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Exception, ExceptionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Exception Parse(string xml)
        {
            return XTypedServices.Parse<Exception, ExceptionType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Exception(((ExceptionType)(this.Content.Clone())));
        }

        private void SetInnerType(ExceptionType ContentField)
        {
            this.ContentField=((ExceptionType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ExceptionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Exception", "http://www.opengis.net/ows")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public class LinqToXsdTypeManager: ILinqToXsdTypeManager
    {

        static Dictionary<XName, System.Type> typeDictionary=new Dictionary<XName, System.Type>();

        static Dictionary<XName, System.Type> elementDictionary=new Dictionary<XName, System.Type>();

        static Dictionary<System.Type, System.Type> wrapperDictionary=new Dictionary<System.Type, System.Type>();

        private static XmlSchemaSet schemaSet;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static LinqToXsdTypeManager typeManagerSingleton=new LinqToXsdTypeManager();

        static LinqToXsdTypeManager()
        {
            BuildTypeDictionary();
            BuildElementDictionary();
            BuildWrapperDictionary();
        }

        XmlSchemaSet ILinqToXsdTypeManager.Schemas
        {
            get
            {
                if ((schemaSet==null))
                {
                    XmlSchemaSet tempSet=new XmlSchemaSet();
                    System.Threading.Interlocked.CompareExchange(ref schemaSet, tempSet, null);
                }
                return schemaSet;
            }
            set
            {
                schemaSet=value;
            }
        }

        Dictionary<XName, System.Type> ILinqToXsdTypeManager.GlobalTypeDictionary
        {
            get
            {
                return typeDictionary;
            }
        }

        Dictionary<XName, System.Type> ILinqToXsdTypeManager.GlobalElementDictionary
        {
            get
            {
                return elementDictionary;
            }
        }

        Dictionary<System.Type, System.Type> ILinqToXsdTypeManager.RootContentTypeMapping
        {
            get
            {
                return wrapperDictionary;
            }
        }

        public static LinqToXsdTypeManager Instance
        {
            get
            {
                return typeManagerSingleton;
            }
        }

        private static void BuildTypeDictionary()
        {
            typeDictionary.Add(XName.Get("AbstractRecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecordType));
            typeDictionary.Add(XName.Get("DCMIRecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecordType));
            typeDictionary.Add(XName.Get("BriefRecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecordType));
            typeDictionary.Add(XName.Get("SummaryRecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecordType));
            typeDictionary.Add(XName.Get("RecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordType));
            typeDictionary.Add(XName.Get("EmptyType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.EmptyType));
            typeDictionary.Add(XName.Get("RequestBaseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RequestBaseType));
            typeDictionary.Add(XName.Get("GetCapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilitiesType));
            typeDictionary.Add(XName.Get("CapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.CapabilitiesType));
            typeDictionary.Add(XName.Get("DescribeRecordType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordType));
            typeDictionary.Add(XName.Get("DescribeRecordResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponseType));
            typeDictionary.Add(XName.Get("SchemaComponentType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SchemaComponentType));
            typeDictionary.Add(XName.Get("GetRecordsType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsType));
            typeDictionary.Add(XName.Get("DistributedSearchType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DistributedSearchType));
            typeDictionary.Add(XName.Get("AbstractQueryType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQueryType));
            typeDictionary.Add(XName.Get("QueryType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.QueryType));
            typeDictionary.Add(XName.Get("QueryConstraintType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.QueryConstraintType));
            typeDictionary.Add(XName.Get("ElementSetNameType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetNameType));
            typeDictionary.Add(XName.Get("GetRecordsResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponseType));
            typeDictionary.Add(XName.Get("RequestStatusType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RequestStatusType));
            typeDictionary.Add(XName.Get("SearchResultsType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SearchResultsType));
            typeDictionary.Add(XName.Get("GetRecordByIdType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdType));
            typeDictionary.Add(XName.Get("GetRecordByIdResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponseType));
            typeDictionary.Add(XName.Get("GetDomainType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainType));
            typeDictionary.Add(XName.Get("GetDomainResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponseType));
            typeDictionary.Add(XName.Get("DomainValuesType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DomainValuesType));
            typeDictionary.Add(XName.Get("ListOfValuesType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ListOfValuesType));
            typeDictionary.Add(XName.Get("ConceptualSchemeType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ConceptualSchemeType));
            typeDictionary.Add(XName.Get("RangeOfValuesType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RangeOfValuesType));
            typeDictionary.Add(XName.Get("AcknowledgementType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AcknowledgementType));
            typeDictionary.Add(XName.Get("EchoedRequestType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.EchoedRequestType));
            typeDictionary.Add(XName.Get("TransactionType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionType));
            typeDictionary.Add(XName.Get("InsertType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.InsertType));
            typeDictionary.Add(XName.Get("UpdateType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.UpdateType));
            typeDictionary.Add(XName.Get("DeleteType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DeleteType));
            typeDictionary.Add(XName.Get("RecordPropertyType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordPropertyType));
            typeDictionary.Add(XName.Get("TransactionResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponseType));
            typeDictionary.Add(XName.Get("TransactionSummaryType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionSummaryType));
            typeDictionary.Add(XName.Get("InsertResultType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.InsertResultType));
            typeDictionary.Add(XName.Get("HarvestType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestType));
            typeDictionary.Add(XName.Get("HarvestResponseType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponseType));
            typeDictionary.Add(XName.Get("SimpleLiteral", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            typeDictionary.Add(XName.Get("elementContainer", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.elementContainer));
            typeDictionary.Add(XName.Get("MetadataType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.MetadataType));
            typeDictionary.Add(XName.Get("BoundingBoxType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.BoundingBoxType));
            typeDictionary.Add(XName.Get("WGS84BoundingBoxType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBoxType));
            typeDictionary.Add(XName.Get("KeywordsType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.KeywordsType));
            typeDictionary.Add(XName.Get("CodeType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.CodeType));
            typeDictionary.Add(XName.Get("ResponsiblePartyType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ResponsiblePartyType));
            typeDictionary.Add(XName.Get("ResponsiblePartySubsetType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ResponsiblePartySubsetType));
            typeDictionary.Add(XName.Get("ContactType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ContactType));
            typeDictionary.Add(XName.Get("OnlineResourceType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.OnlineResourceType));
            typeDictionary.Add(XName.Get("TelephoneType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.TelephoneType));
            typeDictionary.Add(XName.Get("AddressType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AddressType));
            typeDictionary.Add(XName.Get("DescriptionType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.DescriptionType));
            typeDictionary.Add(XName.Get("IdentificationType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.IdentificationType));
            typeDictionary.Add(XName.Get("RequestMethodType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.RequestMethodType));
            typeDictionary.Add(XName.Get("DomainType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.DomainType));
            typeDictionary.Add(XName.Get("CapabilitiesBaseType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.CapabilitiesBaseType));
            typeDictionary.Add(XName.Get("GetCapabilitiesType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.GetCapabilitiesType));
            typeDictionary.Add(XName.Get("AcceptVersionsType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AcceptVersionsType));
            typeDictionary.Add(XName.Get("SectionsType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.SectionsType));
            typeDictionary.Add(XName.Get("AcceptFormatsType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AcceptFormatsType));
            typeDictionary.Add(XName.Get("ExceptionType", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ExceptionType));
            typeDictionary.Add(XName.Get("ExpressionType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.ExpressionType));
            typeDictionary.Add(XName.Get("BinaryOperatorType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryOperatorType));
            typeDictionary.Add(XName.Get("FunctionType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FunctionType));
            typeDictionary.Add(XName.Get("LiteralType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.LiteralType));
            typeDictionary.Add(XName.Get("PropertyNameType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyNameType));
            typeDictionary.Add(XName.Get("SortByType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SortByType));
            typeDictionary.Add(XName.Get("SortPropertyType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SortPropertyType));
            typeDictionary.Add(XName.Get("Spatial_CapabilitiesType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Spatial_CapabilitiesType));
            typeDictionary.Add(XName.Get("GeometryOperandsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.GeometryOperandsType));
            typeDictionary.Add(XName.Get("SpatialOperatorsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SpatialOperatorsType));
            typeDictionary.Add(XName.Get("SpatialOperatorType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SpatialOperatorType));
            typeDictionary.Add(XName.Get("Scalar_CapabilitiesType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Scalar_CapabilitiesType));
            typeDictionary.Add(XName.Get("ComparisonOperatorsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.ComparisonOperatorsType));
            typeDictionary.Add(XName.Get("ArithmeticOperatorsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.ArithmeticOperatorsType));
            typeDictionary.Add(XName.Get("FunctionsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FunctionsType));
            typeDictionary.Add(XName.Get("FunctionNamesType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FunctionNamesType));
            typeDictionary.Add(XName.Get("FunctionNameType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FunctionNameType));
            typeDictionary.Add(XName.Get("Id_CapabilitiesType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Id_CapabilitiesType));
            typeDictionary.Add(XName.Get("FilterType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FilterType));
            typeDictionary.Add(XName.Get("ComparisonOpsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.ComparisonOpsType));
            typeDictionary.Add(XName.Get("SpatialOpsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SpatialOpsType));
            typeDictionary.Add(XName.Get("LogicOpsType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.LogicOpsType));
            typeDictionary.Add(XName.Get("AbstractIdType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.AbstractIdType));
            typeDictionary.Add(XName.Get("FeatureIdType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FeatureIdType));
            typeDictionary.Add(XName.Get("GmlObjectIdType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.GmlObjectIdType));
            typeDictionary.Add(XName.Get("BinaryComparisonOpType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            typeDictionary.Add(XName.Get("PropertyIsLikeType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLikeType));
            typeDictionary.Add(XName.Get("PropertyIsNullType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNullType));
            typeDictionary.Add(XName.Get("PropertyIsBetweenType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetweenType));
            typeDictionary.Add(XName.Get("LowerBoundaryType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.LowerBoundaryType));
            typeDictionary.Add(XName.Get("UpperBoundaryType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.UpperBoundaryType));
            typeDictionary.Add(XName.Get("BinarySpatialOpType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            typeDictionary.Add(XName.Get("BBOXType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BBOXType));
            typeDictionary.Add(XName.Get("DistanceBufferType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.DistanceBufferType));
            typeDictionary.Add(XName.Get("DistanceType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.DistanceType));
            typeDictionary.Add(XName.Get("BinaryLogicOpType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryLogicOpType));
            typeDictionary.Add(XName.Get("UnaryLogicOpType", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.UnaryLogicOpType));
            typeDictionary.Add(XName.Get("CodeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CodeType));
            typeDictionary.Add(XName.Get("CodeListType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CodeListType));
            typeDictionary.Add(XName.Get("CodeOrNullListType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CodeOrNullListType));
            typeDictionary.Add(XName.Get("MeasureType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MeasureType));
            typeDictionary.Add(XName.Get("MeasureListType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MeasureListType));
            typeDictionary.Add(XName.Get("MeasureOrNullListType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MeasureOrNullListType));
            typeDictionary.Add(XName.Get("CoordinatesType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CoordinatesType));
            typeDictionary.Add(XName.Get("AbstractGMLType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGMLType));
            typeDictionary.Add(XName.Get("BagType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BagType));
            typeDictionary.Add(XName.Get("ArrayType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArrayType));
            typeDictionary.Add(XName.Get("AbstractMetaDataType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractMetaDataType));
            typeDictionary.Add(XName.Get("GenericMetaDataType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GenericMetaDataType));
            typeDictionary.Add(XName.Get("AssociationType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AssociationType));
            typeDictionary.Add(XName.Get("ReferenceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ReferenceType));
            typeDictionary.Add(XName.Get("ArrayAssociationType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArrayAssociationType));
            typeDictionary.Add(XName.Get("MetaDataPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MetaDataPropertyType));
            typeDictionary.Add(XName.Get("StringOrRefType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.StringOrRefType));
            typeDictionary.Add(XName.Get("DefinitionType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionType));
            typeDictionary.Add(XName.Get("DictionaryType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryType));
            typeDictionary.Add(XName.Get("DictionaryEntryType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryEntryType));
            typeDictionary.Add(XName.Get("IndirectEntryType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.IndirectEntryType));
            typeDictionary.Add(XName.Get("DefinitionProxyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionProxyType));
            typeDictionary.Add(XName.Get("UnitOfMeasureType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.UnitOfMeasureType));
            typeDictionary.Add(XName.Get("UnitDefinitionType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.UnitDefinitionType));
            typeDictionary.Add(XName.Get("BaseUnitType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BaseUnitType));
            typeDictionary.Add(XName.Get("DerivedUnitType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DerivedUnitType));
            typeDictionary.Add(XName.Get("ConventionalUnitType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ConventionalUnitType));
            typeDictionary.Add(XName.Get("DerivationUnitTermType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DerivationUnitTermType));
            typeDictionary.Add(XName.Get("ConversionToPreferredUnitType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ConversionToPreferredUnitType));
            typeDictionary.Add(XName.Get("FormulaType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.FormulaType));
            typeDictionary.Add(XName.Get("LengthType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LengthType));
            typeDictionary.Add(XName.Get("ScaleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ScaleType));
            typeDictionary.Add(XName.Get("TimeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TimeType));
            typeDictionary.Add(XName.Get("GridLengthType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GridLengthType));
            typeDictionary.Add(XName.Get("AreaType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AreaType));
            typeDictionary.Add(XName.Get("VolumeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.VolumeType));
            typeDictionary.Add(XName.Get("SpeedType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SpeedType));
            typeDictionary.Add(XName.Get("AngleChoiceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AngleChoiceType));
            typeDictionary.Add(XName.Get("AngleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AngleType));
            typeDictionary.Add(XName.Get("DMSAngleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DMSAngleType));
            typeDictionary.Add(XName.Get("DegreesType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DegreesType));
            typeDictionary.Add(XName.Get("GeometryPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeometryPropertyType));
            typeDictionary.Add(XName.Get("GeometryArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeometryArrayPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeometryType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometryType));
            typeDictionary.Add(XName.Get("AbstractGeometricPrimitiveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometricPrimitiveType));
            typeDictionary.Add(XName.Get("GeometricPrimitivePropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeometricPrimitivePropertyType));
            typeDictionary.Add(XName.Get("PointType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PointType));
            typeDictionary.Add(XName.Get("PointPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PointPropertyType));
            typeDictionary.Add(XName.Get("PointArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PointArrayPropertyType));
            typeDictionary.Add(XName.Get("AbstractCurveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractCurveType));
            typeDictionary.Add(XName.Get("CurvePropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CurvePropertyType));
            typeDictionary.Add(XName.Get("CurveArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveArrayPropertyType));
            typeDictionary.Add(XName.Get("LineStringType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringType));
            typeDictionary.Add(XName.Get("DirectPositionType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DirectPositionType));
            typeDictionary.Add(XName.Get("DirectPositionListType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DirectPositionListType));
            typeDictionary.Add(XName.Get("VectorType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.VectorType));
            typeDictionary.Add(XName.Get("EnvelopeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.EnvelopeType));
            typeDictionary.Add(XName.Get("CoordType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CoordType));
            typeDictionary.Add(XName.Get("LineStringPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringPropertyType));
            typeDictionary.Add(XName.Get("AbstractSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSurfaceType));
            typeDictionary.Add(XName.Get("SurfacePropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePropertyType));
            typeDictionary.Add(XName.Get("SurfaceArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfaceArrayPropertyType));
            typeDictionary.Add(XName.Get("PolygonType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonType));
            typeDictionary.Add(XName.Get("AbstractRingType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingType));
            typeDictionary.Add(XName.Get("AbstractRingPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingPropertyType));
            typeDictionary.Add(XName.Get("LinearRingType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LinearRingType));
            typeDictionary.Add(XName.Get("LinearRingPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LinearRingPropertyType));
            typeDictionary.Add(XName.Get("PolygonPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPropertyType));
            typeDictionary.Add(XName.Get("CurveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveType));
            typeDictionary.Add(XName.Get("OrientableCurveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableCurveType));
            typeDictionary.Add(XName.Get("AbstractCurveSegmentType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractCurveSegmentType));
            typeDictionary.Add(XName.Get("CurveSegmentArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveSegmentArrayPropertyType));
            typeDictionary.Add(XName.Get("LineStringSegmentType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringSegmentType));
            typeDictionary.Add(XName.Get("ArcStringType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcStringType));
            typeDictionary.Add(XName.Get("ArcType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcType));
            typeDictionary.Add(XName.Get("CircleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CircleType));
            typeDictionary.Add(XName.Get("ArcStringByBulgeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulgeType));
            typeDictionary.Add(XName.Get("ArcByBulgeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByBulgeType));
            typeDictionary.Add(XName.Get("ArcByCenterPointType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPointType));
            typeDictionary.Add(XName.Get("CircleByCenterPointType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPointType));
            typeDictionary.Add(XName.Get("OffsetCurveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OffsetCurveType));
            typeDictionary.Add(XName.Get("AffinePlacementType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AffinePlacementType));
            typeDictionary.Add(XName.Get("ClothoidType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ClothoidType));
            typeDictionary.Add(XName.Get("GeodesicStringType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeodesicStringType));
            typeDictionary.Add(XName.Get("GeodesicType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeodesicType));
            typeDictionary.Add(XName.Get("CubicSplineType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CubicSplineType));
            typeDictionary.Add(XName.Get("KnotType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.KnotType));
            typeDictionary.Add(XName.Get("KnotPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.KnotPropertyType));
            typeDictionary.Add(XName.Get("BSplineType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BSplineType));
            typeDictionary.Add(XName.Get("BezierType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BezierType));
            typeDictionary.Add(XName.Get("SurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfaceType));
            typeDictionary.Add(XName.Get("OrientableSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableSurfaceType));
            typeDictionary.Add(XName.Get("AbstractSurfacePatchType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSurfacePatchType));
            typeDictionary.Add(XName.Get("SurfacePatchArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePatchArrayPropertyType));
            typeDictionary.Add(XName.Get("PolygonPatchType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPatchType));
            typeDictionary.Add(XName.Get("TriangleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TriangleType));
            typeDictionary.Add(XName.Get("RectangleType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.RectangleType));
            typeDictionary.Add(XName.Get("RingType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.RingType));
            typeDictionary.Add(XName.Get("RingPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.RingPropertyType));
            typeDictionary.Add(XName.Get("AbstractParametricCurveSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractParametricCurveSurfaceType));
            typeDictionary.Add(XName.Get("AbstractGriddedSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGriddedSurfaceType));
            typeDictionary.Add(XName.Get("ConeType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ConeType));
            typeDictionary.Add(XName.Get("CylinderType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CylinderType));
            typeDictionary.Add(XName.Get("SphereType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SphereType));
            typeDictionary.Add(XName.Get("PolyhedralSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurfaceType));
            typeDictionary.Add(XName.Get("PolygonPatchArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPatchArrayPropertyType));
            typeDictionary.Add(XName.Get("TrianglePatchArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TrianglePatchArrayPropertyType));
            typeDictionary.Add(XName.Get("TriangulatedSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurfaceType));
            typeDictionary.Add(XName.Get("TinType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TinType));
            typeDictionary.Add(XName.Get("LineStringSegmentArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringSegmentArrayPropertyType));
            typeDictionary.Add(XName.Get("AbstractSolidType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSolidType));
            typeDictionary.Add(XName.Get("SolidPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidPropertyType));
            typeDictionary.Add(XName.Get("SolidArrayPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidArrayPropertyType));
            typeDictionary.Add(XName.Get("SolidType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidType));
            typeDictionary.Add(XName.Get("AbstractGeometricAggregateType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometricAggregateType));
            typeDictionary.Add(XName.Get("MultiGeometryType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiGeometryType));
            typeDictionary.Add(XName.Get("MultiGeometryPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiGeometryPropertyType));
            typeDictionary.Add(XName.Get("MultiPointType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointType));
            typeDictionary.Add(XName.Get("MultiPointPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointPropertyType));
            typeDictionary.Add(XName.Get("MultiCurveType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurveType));
            typeDictionary.Add(XName.Get("MultiCurvePropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurvePropertyType));
            typeDictionary.Add(XName.Get("MultiSurfaceType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfaceType));
            typeDictionary.Add(XName.Get("MultiSurfacePropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfacePropertyType));
            typeDictionary.Add(XName.Get("MultiSolidType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSolidType));
            typeDictionary.Add(XName.Get("MultiSolidPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSolidPropertyType));
            typeDictionary.Add(XName.Get("MultiLineStringType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiLineStringType));
            typeDictionary.Add(XName.Get("MultiLineStringPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiLineStringPropertyType));
            typeDictionary.Add(XName.Get("MultiPolygonType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPolygonType));
            typeDictionary.Add(XName.Get("MultiPolygonPropertyType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPolygonPropertyType));
        }

        private static void BuildElementDictionary()
        {
            elementDictionary.Add(XName.Get("AbstractMetaData", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AbstractMetaData));
            elementDictionary.Add(XName.Get("ServiceIdentification", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ServiceIdentification));
            elementDictionary.Add(XName.Get("ServiceProvider", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ServiceProvider));
            elementDictionary.Add(XName.Get("OperationsMetadata", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.OperationsMetadata));
            elementDictionary.Add(XName.Get("ExtendedCapabilities", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ExtendedCapabilities));
            elementDictionary.Add(XName.Get("Operation", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Operation));
            elementDictionary.Add(XName.Get("DCP", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.DCP));
            elementDictionary.Add(XName.Get("HTTP", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.HTTP));
            elementDictionary.Add(XName.Get("ExceptionReport", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ExceptionReport));
            elementDictionary.Add(XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Filter_Capabilities));
            elementDictionary.Add(XName.Get("LogicalOperators", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.LogicalOperators));
            elementDictionary.Add(XName.Get("SimpleArithmetic", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SimpleArithmetic));
            elementDictionary.Add(XName.Get("EID", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.EID));
            elementDictionary.Add(XName.Get("FID", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FID));
            elementDictionary.Add(XName.Get("_Object", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Object));
            elementDictionary.Add(XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecord));
            elementDictionary.Add(XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecord));
            elementDictionary.Add(XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecord));
            elementDictionary.Add(XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecord));
            elementDictionary.Add(XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Record));
            elementDictionary.Add(XName.Get("GetCapabilities", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilities));
            elementDictionary.Add(XName.Get("Capabilities", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Capabilities));
            elementDictionary.Add(XName.Get("DescribeRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecord));
            elementDictionary.Add(XName.Get("DescribeRecordResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponse));
            elementDictionary.Add(XName.Get("GetRecords", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecords));
            elementDictionary.Add(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQuery));
            elementDictionary.Add(XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Query));
            elementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Constraint));
            elementDictionary.Add(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetName));
            elementDictionary.Add(XName.Get("GetRecordsResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponse));
            elementDictionary.Add(XName.Get("GetRecordById", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordById));
            elementDictionary.Add(XName.Get("GetRecordByIdResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse));
            elementDictionary.Add(XName.Get("GetDomain", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomain));
            elementDictionary.Add(XName.Get("GetDomainResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponse));
            elementDictionary.Add(XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Acknowledgement));
            elementDictionary.Add(XName.Get("Transaction", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Transaction));
            elementDictionary.Add(XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordProperty));
            elementDictionary.Add(XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponse));
            elementDictionary.Add(XName.Get("Harvest", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Harvest));
            elementDictionary.Add(XName.Get("HarvestResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponse));
            elementDictionary.Add(XName.Get("abstract", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.@abstract));
            elementDictionary.Add(XName.Get("accessRights", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.accessRights));
            elementDictionary.Add(XName.Get("alternative", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.alternative));
            elementDictionary.Add(XName.Get("audience", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.audience));
            elementDictionary.Add(XName.Get("available", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.available));
            elementDictionary.Add(XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.bibliographicCitation));
            elementDictionary.Add(XName.Get("conformsTo", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.conformsTo));
            elementDictionary.Add(XName.Get("created", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.created));
            elementDictionary.Add(XName.Get("dateAccepted", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.dateAccepted));
            elementDictionary.Add(XName.Get("dateCopyrighted", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.dateCopyrighted));
            elementDictionary.Add(XName.Get("dateSubmitted", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.dateSubmitted));
            elementDictionary.Add(XName.Get("educationLevel", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.educationLevel));
            elementDictionary.Add(XName.Get("extent", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.extent));
            elementDictionary.Add(XName.Get("hasFormat", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.hasFormat));
            elementDictionary.Add(XName.Get("hasPart", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.hasPart));
            elementDictionary.Add(XName.Get("hasVersion", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.hasVersion));
            elementDictionary.Add(XName.Get("isFormatOf", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isFormatOf));
            elementDictionary.Add(XName.Get("isPartOf", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isPartOf));
            elementDictionary.Add(XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isReferencedBy));
            elementDictionary.Add(XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isReplacedBy));
            elementDictionary.Add(XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isRequiredBy));
            elementDictionary.Add(XName.Get("issued", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.issued));
            elementDictionary.Add(XName.Get("isVersionOf", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.isVersionOf));
            elementDictionary.Add(XName.Get("license", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.license));
            elementDictionary.Add(XName.Get("mediator", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.mediator));
            elementDictionary.Add(XName.Get("medium", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.medium));
            elementDictionary.Add(XName.Get("modified", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.modified));
            elementDictionary.Add(XName.Get("provenance", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.provenance));
            elementDictionary.Add(XName.Get("references", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.references));
            elementDictionary.Add(XName.Get("replaces", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.replaces));
            elementDictionary.Add(XName.Get("requires", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.requires));
            elementDictionary.Add(XName.Get("rightsHolder", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.rightsHolder));
            elementDictionary.Add(XName.Get("spatial", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.spatial));
            elementDictionary.Add(XName.Get("tableOfContents", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.tableOfContents));
            elementDictionary.Add(XName.Get("temporal", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.temporal));
            elementDictionary.Add(XName.Get("valid", "http://purl.org/dc/terms/"), typeof(global::OgcToolkit.DublinCore.Terms.valid));
            elementDictionary.Add(XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.DCelement));
            elementDictionary.Add(XName.Get("title", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.title));
            elementDictionary.Add(XName.Get("creator", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.creator));
            elementDictionary.Add(XName.Get("subject", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.subject));
            elementDictionary.Add(XName.Get("description", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.description));
            elementDictionary.Add(XName.Get("publisher", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.publisher));
            elementDictionary.Add(XName.Get("contributor", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.contributor));
            elementDictionary.Add(XName.Get("date", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.date));
            elementDictionary.Add(XName.Get("type", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.type));
            elementDictionary.Add(XName.Get("format", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.format));
            elementDictionary.Add(XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.identifier));
            elementDictionary.Add(XName.Get("source", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.source));
            elementDictionary.Add(XName.Get("language", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.language));
            elementDictionary.Add(XName.Get("relation", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.relation));
            elementDictionary.Add(XName.Get("coverage", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.coverage));
            elementDictionary.Add(XName.Get("rights", "http://purl.org/dc/elements/1.1/"), typeof(global::OgcToolkit.DublinCore.Elements.V11.rights));
            elementDictionary.Add(XName.Get("Metadata", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Metadata));
            elementDictionary.Add(XName.Get("BoundingBox", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.BoundingBox));
            elementDictionary.Add(XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBox));
            elementDictionary.Add(XName.Get("Title", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Title));
            elementDictionary.Add(XName.Get("Abstract", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.@Abstract));
            elementDictionary.Add(XName.Get("Keywords", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Keywords));
            elementDictionary.Add(XName.Get("PointOfContact", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.PointOfContact));
            elementDictionary.Add(XName.Get("IndividualName", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.IndividualName));
            elementDictionary.Add(XName.Get("OrganisationName", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.OrganisationName));
            elementDictionary.Add(XName.Get("PositionName", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.PositionName));
            elementDictionary.Add(XName.Get("Role", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Role));
            elementDictionary.Add(XName.Get("ContactInfo", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.ContactInfo));
            elementDictionary.Add(XName.Get("Identifier", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Identifier));
            elementDictionary.Add(XName.Get("OutputFormat", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.OutputFormat));
            elementDictionary.Add(XName.Get("AvailableCRS", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AvailableCRS));
            elementDictionary.Add(XName.Get("SupportedCRS", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.SupportedCRS));
            elementDictionary.Add(XName.Get("AccessConstraints", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.AccessConstraints));
            elementDictionary.Add(XName.Get("Fees", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Fees));
            elementDictionary.Add(XName.Get("Language", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Language));
            elementDictionary.Add(XName.Get("GetCapabilities", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.GetCapabilities));
            elementDictionary.Add(XName.Get("Exception", "http://www.opengis.net/ows"), typeof(global::OgcToolkit.Ogc.Ows.V100.Exception));
            elementDictionary.Add(XName.Get("Add", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Add));
            elementDictionary.Add(XName.Get("Sub", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Sub));
            elementDictionary.Add(XName.Get("Mul", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Mul));
            elementDictionary.Add(XName.Get("Div", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Div));
            elementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyName));
            elementDictionary.Add(XName.Get("Function", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Function));
            elementDictionary.Add(XName.Get("Literal", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Literal));
            elementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.expression));
            elementDictionary.Add(XName.Get("SortBy", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.SortBy));
            elementDictionary.Add(XName.Get("_Id", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110._Id));
            elementDictionary.Add(XName.Get("FeatureId", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.FeatureId));
            elementDictionary.Add(XName.Get("GmlObjectId", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.GmlObjectId));
            elementDictionary.Add(XName.Get("Filter", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Filter));
            elementDictionary.Add(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.comparisonOps));
            elementDictionary.Add(XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsEqualTo));
            elementDictionary.Add(XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNotEqualTo));
            elementDictionary.Add(XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThan));
            elementDictionary.Add(XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThan));
            elementDictionary.Add(XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThanOrEqualTo));
            elementDictionary.Add(XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThanOrEqualTo));
            elementDictionary.Add(XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLike));
            elementDictionary.Add(XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNull));
            elementDictionary.Add(XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetween));
            elementDictionary.Add(XName.Get("spatialOps", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.spatialOps));
            elementDictionary.Add(XName.Get("Equals", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Equals));
            elementDictionary.Add(XName.Get("Disjoint", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Disjoint));
            elementDictionary.Add(XName.Get("Touches", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Touches));
            elementDictionary.Add(XName.Get("Within", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Within));
            elementDictionary.Add(XName.Get("Overlaps", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Overlaps));
            elementDictionary.Add(XName.Get("Crosses", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Crosses));
            elementDictionary.Add(XName.Get("Intersects", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Intersects));
            elementDictionary.Add(XName.Get("Contains", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Contains));
            elementDictionary.Add(XName.Get("DWithin", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.DWithin));
            elementDictionary.Add(XName.Get("Beyond", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Beyond));
            elementDictionary.Add(XName.Get("BBOX", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.BBOX));
            elementDictionary.Add(XName.Get("logicOps", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.logicOps));
            elementDictionary.Add(XName.Get("And", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.And));
            elementDictionary.Add(XName.Get("Or", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Or));
            elementDictionary.Add(XName.Get("Not", "http://www.opengis.net/ogc"), typeof(global::OgcToolkit.Ogc.Filter.V110.Not));
            elementDictionary.Add(XName.Get("Null", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.@Null));
            elementDictionary.Add(XName.Get("_GML", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._GML));
            elementDictionary.Add(XName.Get("Bag", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Bag));
            elementDictionary.Add(XName.Get("Array", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Array));
            elementDictionary.Add(XName.Get("_MetaData", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._MetaData));
            elementDictionary.Add(XName.Get("GenericMetaData", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GenericMetaData));
            elementDictionary.Add(XName.Get("_association", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._association));
            elementDictionary.Add(XName.Get("_strictAssociation", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._strictAssociation));
            elementDictionary.Add(XName.Get("member", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.member));
            elementDictionary.Add(XName.Get("_reference", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._reference));
            elementDictionary.Add(XName.Get("members", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.members));
            elementDictionary.Add(XName.Get("metaDataProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.metaDataProperty));
            elementDictionary.Add(XName.Get("name", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.name));
            elementDictionary.Add(XName.Get("description", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.description));
            elementDictionary.Add(XName.Get("Definition", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Definition));
            elementDictionary.Add(XName.Get("Dictionary", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Dictionary));
            elementDictionary.Add(XName.Get("DefinitionCollection", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionCollection));
            elementDictionary.Add(XName.Get("dictionaryEntry", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.dictionaryEntry));
            elementDictionary.Add(XName.Get("definitionMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.definitionMember));
            elementDictionary.Add(XName.Get("indirectEntry", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.indirectEntry));
            elementDictionary.Add(XName.Get("DefinitionProxy", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionProxy));
            elementDictionary.Add(XName.Get("definitionRef", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.definitionRef));
            elementDictionary.Add(XName.Get("unitOfMeasure", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.unitOfMeasure));
            elementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.UnitDefinition));
            elementDictionary.Add(XName.Get("BaseUnit", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BaseUnit));
            elementDictionary.Add(XName.Get("DerivedUnit", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.DerivedUnit));
            elementDictionary.Add(XName.Get("ConventionalUnit", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ConventionalUnit));
            elementDictionary.Add(XName.Get("quantityType", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.quantityType));
            elementDictionary.Add(XName.Get("catalogSymbol", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.catalogSymbol));
            elementDictionary.Add(XName.Get("derivationUnitTerm", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.derivationUnitTerm));
            elementDictionary.Add(XName.Get("conversionToPreferredUnit", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.conversionToPreferredUnit));
            elementDictionary.Add(XName.Get("roughConversionToPreferredUnit", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.roughConversionToPreferredUnit));
            elementDictionary.Add(XName.Get("measure", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.measure));
            elementDictionary.Add(XName.Get("angle", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.angle));
            elementDictionary.Add(XName.Get("dmsAngle", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.dmsAngle));
            elementDictionary.Add(XName.Get("degrees", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.degrees));
            elementDictionary.Add(XName.Get("decimalMinutes", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.decimalMinutes));
            elementDictionary.Add(XName.Get("minutes", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.minutes));
            elementDictionary.Add(XName.Get("seconds", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.seconds));
            elementDictionary.Add(XName.Get("_Geometry", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Geometry));
            elementDictionary.Add(XName.Get("_GeometricPrimitive", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._GeometricPrimitive));
            elementDictionary.Add(XName.Get("Point", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Point));
            elementDictionary.Add(XName.Get("pointProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pointProperty));
            elementDictionary.Add(XName.Get("pointRep", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pointRep));
            elementDictionary.Add(XName.Get("pointArrayProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pointArrayProperty));
            elementDictionary.Add(XName.Get("_Curve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Curve));
            elementDictionary.Add(XName.Get("curveProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.curveProperty));
            elementDictionary.Add(XName.Get("curveArrayProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.curveArrayProperty));
            elementDictionary.Add(XName.Get("LineString", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineString));
            elementDictionary.Add(XName.Get("pos", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pos));
            elementDictionary.Add(XName.Get("posList", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.posList));
            elementDictionary.Add(XName.Get("vector", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.vector));
            elementDictionary.Add(XName.Get("coordinates", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.coordinates));
            elementDictionary.Add(XName.Get("Envelope", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Envelope));
            elementDictionary.Add(XName.Get("coord", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.coord));
            elementDictionary.Add(XName.Get("lineStringProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.lineStringProperty));
            elementDictionary.Add(XName.Get("_Surface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Surface));
            elementDictionary.Add(XName.Get("surfaceProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.surfaceProperty));
            elementDictionary.Add(XName.Get("surfaceArrayProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.surfaceArrayProperty));
            elementDictionary.Add(XName.Get("Polygon", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Polygon));
            elementDictionary.Add(XName.Get("_Ring", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Ring));
            elementDictionary.Add(XName.Get("exterior", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.exterior));
            elementDictionary.Add(XName.Get("interior", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.interior));
            elementDictionary.Add(XName.Get("outerBoundaryIs", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.outerBoundaryIs));
            elementDictionary.Add(XName.Get("innerBoundaryIs", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.innerBoundaryIs));
            elementDictionary.Add(XName.Get("LinearRing", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LinearRing));
            elementDictionary.Add(XName.Get("polygonProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.polygonProperty));
            elementDictionary.Add(XName.Get("Curve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Curve));
            elementDictionary.Add(XName.Get("baseCurve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.baseCurve));
            elementDictionary.Add(XName.Get("OrientableCurve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableCurve));
            elementDictionary.Add(XName.Get("_CurveSegment", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._CurveSegment));
            elementDictionary.Add(XName.Get("segments", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.segments));
            elementDictionary.Add(XName.Get("LineStringSegment", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringSegment));
            elementDictionary.Add(XName.Get("ArcString", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcString));
            elementDictionary.Add(XName.Get("Arc", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Arc));
            elementDictionary.Add(XName.Get("Circle", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Circle));
            elementDictionary.Add(XName.Get("ArcStringByBulge", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulge));
            elementDictionary.Add(XName.Get("ArcByBulge", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByBulge));
            elementDictionary.Add(XName.Get("ArcByCenterPoint", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPoint));
            elementDictionary.Add(XName.Get("CircleByCenterPoint", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPoint));
            elementDictionary.Add(XName.Get("OffsetCurve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OffsetCurve));
            elementDictionary.Add(XName.Get("AffinePlacement", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.AffinePlacement));
            elementDictionary.Add(XName.Get("Clothoid", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Clothoid));
            elementDictionary.Add(XName.Get("GeodesicString", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.GeodesicString));
            elementDictionary.Add(XName.Get("Geodesic", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Geodesic));
            elementDictionary.Add(XName.Get("CubicSpline", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.CubicSpline));
            elementDictionary.Add(XName.Get("BSpline", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.BSpline));
            elementDictionary.Add(XName.Get("Bezier", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Bezier));
            elementDictionary.Add(XName.Get("Surface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Surface));
            elementDictionary.Add(XName.Get("baseSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.baseSurface));
            elementDictionary.Add(XName.Get("OrientableSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableSurface));
            elementDictionary.Add(XName.Get("_SurfacePatch", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._SurfacePatch));
            elementDictionary.Add(XName.Get("patches", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.patches));
            elementDictionary.Add(XName.Get("PolygonPatch", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPatch));
            elementDictionary.Add(XName.Get("Triangle", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Triangle));
            elementDictionary.Add(XName.Get("Rectangle", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Rectangle));
            elementDictionary.Add(XName.Get("curveMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.curveMember));
            elementDictionary.Add(XName.Get("Ring", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Ring));
            elementDictionary.Add(XName.Get("_ParametricCurveSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._ParametricCurveSurface));
            elementDictionary.Add(XName.Get("_GriddedSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._GriddedSurface));
            elementDictionary.Add(XName.Get("Cone", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Cone));
            elementDictionary.Add(XName.Get("Cylinder", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Cylinder));
            elementDictionary.Add(XName.Get("Sphere", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Sphere));
            elementDictionary.Add(XName.Get("PolyhedralSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurface));
            elementDictionary.Add(XName.Get("polygonPatches", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.polygonPatches));
            elementDictionary.Add(XName.Get("trianglePatches", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.trianglePatches));
            elementDictionary.Add(XName.Get("TriangulatedSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurface));
            elementDictionary.Add(XName.Get("Tin", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Tin));
            elementDictionary.Add(XName.Get("_Solid", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._Solid));
            elementDictionary.Add(XName.Get("solidProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.solidProperty));
            elementDictionary.Add(XName.Get("solidArrayProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.solidArrayProperty));
            elementDictionary.Add(XName.Get("Solid", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.Solid));
            elementDictionary.Add(XName.Get("_GeometricAggregate", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311._GeometricAggregate));
            elementDictionary.Add(XName.Get("MultiGeometry", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiGeometry));
            elementDictionary.Add(XName.Get("multiGeometryProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiGeometryProperty));
            elementDictionary.Add(XName.Get("MultiPoint", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPoint));
            elementDictionary.Add(XName.Get("multiPointProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiPointProperty));
            elementDictionary.Add(XName.Get("MultiCurve", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurve));
            elementDictionary.Add(XName.Get("multiCurveProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiCurveProperty));
            elementDictionary.Add(XName.Get("MultiSurface", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurface));
            elementDictionary.Add(XName.Get("multiSurfaceProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiSurfaceProperty));
            elementDictionary.Add(XName.Get("MultiSolid", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSolid));
            elementDictionary.Add(XName.Get("multiSolidProperty", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiSolidProperty));
            elementDictionary.Add(XName.Get("MultiPolygon", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPolygon));
            elementDictionary.Add(XName.Get("MultiLineString", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiLineString));
            elementDictionary.Add(XName.Get("geometryMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.geometryMember));
            elementDictionary.Add(XName.Get("geometryMembers", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.geometryMembers));
            elementDictionary.Add(XName.Get("pointMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pointMember));
            elementDictionary.Add(XName.Get("pointMembers", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.pointMembers));
            elementDictionary.Add(XName.Get("curveMembers", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.curveMembers));
            elementDictionary.Add(XName.Get("surfaceMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.surfaceMember));
            elementDictionary.Add(XName.Get("surfaceMembers", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.surfaceMembers));
            elementDictionary.Add(XName.Get("solidMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.solidMember));
            elementDictionary.Add(XName.Get("solidMembers", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.solidMembers));
            elementDictionary.Add(XName.Get("multiCenterOf", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiCenterOf));
            elementDictionary.Add(XName.Get("multiPosition", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiPosition));
            elementDictionary.Add(XName.Get("multiCenterLineOf", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiCenterLineOf));
            elementDictionary.Add(XName.Get("multiEdgeOf", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiEdgeOf));
            elementDictionary.Add(XName.Get("multiCoverage", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiCoverage));
            elementDictionary.Add(XName.Get("multiExtentOf", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiExtentOf));
            elementDictionary.Add(XName.Get("multiLocation", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.multiLocation));
            elementDictionary.Add(XName.Get("lineStringMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.lineStringMember));
            elementDictionary.Add(XName.Get("polygonMember", "http://www.opengis.net/gml"), typeof(global::OgcToolkit.Ogc.Gml.V311.polygonMember));
        }

        private static void BuildWrapperDictionary()
        {
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecord), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecord), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecord), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecord), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Record), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilities), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilitiesType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Capabilities), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.CapabilitiesType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecord), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecords), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQuery), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQueryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Query), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.QueryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Constraint), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.QueryConstraintType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetName), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetNameType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordById), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomain), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Acknowledgement), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AcknowledgementType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Transaction), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordProperty), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.Harvest), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponse), typeof(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponseType));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.@abstract), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.accessRights), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.alternative), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.audience), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.available), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.bibliographicCitation), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.conformsTo), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.created), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.dateAccepted), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.dateCopyrighted), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.dateSubmitted), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.educationLevel), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.extent), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.hasFormat), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.hasPart), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.hasVersion), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isFormatOf), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isPartOf), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isReferencedBy), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isReplacedBy), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isRequiredBy), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.issued), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.isVersionOf), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.license), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.mediator), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.medium), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.modified), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.provenance), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.references), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.replaces), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.requires), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.rightsHolder), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.spatial), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.tableOfContents), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.temporal), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Terms.valid), typeof(void));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.DCelement), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.title), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.creator), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.subject), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.description), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.publisher), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.contributor), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.date), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.type), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.format), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.identifier), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.source), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.language), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.relation), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.coverage), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.DublinCore.Elements.V11.rights), typeof(global::OgcToolkit.DublinCore.Elements.V11.SimpleLiteral));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.Metadata), typeof(global::OgcToolkit.Ogc.Ows.V100.MetadataType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.BoundingBox), typeof(global::OgcToolkit.Ogc.Ows.V100.BoundingBoxType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.WGS84BoundingBox), typeof(global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBoxType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.Keywords), typeof(global::OgcToolkit.Ogc.Ows.V100.KeywordsType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.PointOfContact), typeof(global::OgcToolkit.Ogc.Ows.V100.ResponsiblePartyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.Role), typeof(global::OgcToolkit.Ogc.Ows.V100.CodeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.ContactInfo), typeof(global::OgcToolkit.Ogc.Ows.V100.ContactType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.Identifier), typeof(global::OgcToolkit.Ogc.Ows.V100.CodeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.GetCapabilities), typeof(global::OgcToolkit.Ogc.Ows.V100.GetCapabilitiesType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Ows.V100.Exception), typeof(global::OgcToolkit.Ogc.Ows.V100.ExceptionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Add), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryOperatorType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Sub), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryOperatorType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Mul), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryOperatorType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Div), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryOperatorType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyName), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyNameType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Function), typeof(global::OgcToolkit.Ogc.Filter.V110.FunctionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Literal), typeof(global::OgcToolkit.Ogc.Filter.V110.LiteralType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.expression), typeof(global::OgcToolkit.Ogc.Filter.V110.ExpressionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.SortBy), typeof(global::OgcToolkit.Ogc.Filter.V110.SortByType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110._Id), typeof(global::OgcToolkit.Ogc.Filter.V110.AbstractIdType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.FeatureId), typeof(global::OgcToolkit.Ogc.Filter.V110.FeatureIdType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.GmlObjectId), typeof(global::OgcToolkit.Ogc.Filter.V110.GmlObjectIdType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Filter), typeof(global::OgcToolkit.Ogc.Filter.V110.FilterType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.comparisonOps), typeof(global::OgcToolkit.Ogc.Filter.V110.ComparisonOpsType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsEqualTo), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsNotEqualTo), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsLessThan), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThan), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsLessThanOrEqualTo), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThanOrEqualTo), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryComparisonOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsLike), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLikeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsNull), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNullType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.PropertyIsBetween), typeof(global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetweenType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.spatialOps), typeof(global::OgcToolkit.Ogc.Filter.V110.SpatialOpsType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Equals), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Disjoint), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Touches), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Within), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Overlaps), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Crosses), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Intersects), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Contains), typeof(global::OgcToolkit.Ogc.Filter.V110.BinarySpatialOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.DWithin), typeof(global::OgcToolkit.Ogc.Filter.V110.DistanceBufferType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Beyond), typeof(global::OgcToolkit.Ogc.Filter.V110.DistanceBufferType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.BBOX), typeof(global::OgcToolkit.Ogc.Filter.V110.BBOXType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.logicOps), typeof(global::OgcToolkit.Ogc.Filter.V110.LogicOpsType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.And), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryLogicOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Or), typeof(global::OgcToolkit.Ogc.Filter.V110.BinaryLogicOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Filter.V110.Not), typeof(global::OgcToolkit.Ogc.Filter.V110.UnaryLogicOpType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._GML), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGMLType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Bag), typeof(global::OgcToolkit.Ogc.Gml.V311.BagType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Array), typeof(global::OgcToolkit.Ogc.Gml.V311.ArrayType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._MetaData), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractMetaDataType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.GenericMetaData), typeof(global::OgcToolkit.Ogc.Gml.V311.GenericMetaDataType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._association), typeof(global::OgcToolkit.Ogc.Gml.V311.AssociationType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._strictAssociation), typeof(global::OgcToolkit.Ogc.Gml.V311.AssociationType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.member), typeof(global::OgcToolkit.Ogc.Gml.V311.AssociationType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._reference), typeof(global::OgcToolkit.Ogc.Gml.V311.ReferenceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.members), typeof(global::OgcToolkit.Ogc.Gml.V311.ArrayAssociationType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.metaDataProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MetaDataPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.name), typeof(global::OgcToolkit.Ogc.Gml.V311.CodeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.description), typeof(global::OgcToolkit.Ogc.Gml.V311.StringOrRefType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Definition), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Dictionary), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.DefinitionCollection), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.dictionaryEntry), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryEntryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.definitionMember), typeof(global::OgcToolkit.Ogc.Gml.V311.DictionaryEntryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.indirectEntry), typeof(global::OgcToolkit.Ogc.Gml.V311.IndirectEntryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.DefinitionProxy), typeof(global::OgcToolkit.Ogc.Gml.V311.DefinitionProxyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.definitionRef), typeof(global::OgcToolkit.Ogc.Gml.V311.ReferenceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.unitOfMeasure), typeof(global::OgcToolkit.Ogc.Gml.V311.UnitOfMeasureType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.UnitDefinition), typeof(global::OgcToolkit.Ogc.Gml.V311.UnitDefinitionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.BaseUnit), typeof(global::OgcToolkit.Ogc.Gml.V311.BaseUnitType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.DerivedUnit), typeof(global::OgcToolkit.Ogc.Gml.V311.DerivedUnitType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.ConventionalUnit), typeof(global::OgcToolkit.Ogc.Gml.V311.ConventionalUnitType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.quantityType), typeof(global::OgcToolkit.Ogc.Gml.V311.StringOrRefType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.catalogSymbol), typeof(global::OgcToolkit.Ogc.Gml.V311.CodeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.derivationUnitTerm), typeof(global::OgcToolkit.Ogc.Gml.V311.DerivationUnitTermType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.conversionToPreferredUnit), typeof(global::OgcToolkit.Ogc.Gml.V311.ConversionToPreferredUnitType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.roughConversionToPreferredUnit), typeof(global::OgcToolkit.Ogc.Gml.V311.ConversionToPreferredUnitType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.measure), typeof(global::OgcToolkit.Ogc.Gml.V311.MeasureType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.angle), typeof(global::OgcToolkit.Ogc.Gml.V311.MeasureType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.dmsAngle), typeof(global::OgcToolkit.Ogc.Gml.V311.DMSAngleType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.degrees), typeof(global::OgcToolkit.Ogc.Gml.V311.DegreesType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._Geometry), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._GeometricPrimitive), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometricPrimitiveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Point), typeof(global::OgcToolkit.Ogc.Gml.V311.PointType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pointProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.PointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pointRep), typeof(global::OgcToolkit.Ogc.Gml.V311.PointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pointArrayProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.PointArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._Curve), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractCurveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.curveProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.CurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.curveArrayProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.LineString), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pos), typeof(global::OgcToolkit.Ogc.Gml.V311.DirectPositionType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.posList), typeof(global::OgcToolkit.Ogc.Gml.V311.DirectPositionListType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.vector), typeof(global::OgcToolkit.Ogc.Gml.V311.VectorType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.coordinates), typeof(global::OgcToolkit.Ogc.Gml.V311.CoordinatesType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Envelope), typeof(global::OgcToolkit.Ogc.Gml.V311.EnvelopeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.coord), typeof(global::OgcToolkit.Ogc.Gml.V311.CoordType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.lineStringProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._Surface), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.surfaceProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.surfaceArrayProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfaceArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Polygon), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._Ring), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.exterior), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.interior), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.outerBoundaryIs), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.innerBoundaryIs), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.LinearRing), typeof(global::OgcToolkit.Ogc.Gml.V311.LinearRingType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.polygonProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Curve), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.baseCurve), typeof(global::OgcToolkit.Ogc.Gml.V311.CurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.OrientableCurve), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableCurveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._CurveSegment), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractCurveSegmentType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.segments), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveSegmentArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.LineStringSegment), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringSegmentType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.ArcString), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcStringType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Arc), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Circle), typeof(global::OgcToolkit.Ogc.Gml.V311.CircleType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.ArcStringByBulge), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulgeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.ArcByBulge), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByBulgeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.ArcByCenterPoint), typeof(global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPointType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.CircleByCenterPoint), typeof(global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPointType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.OffsetCurve), typeof(global::OgcToolkit.Ogc.Gml.V311.OffsetCurveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.AffinePlacement), typeof(global::OgcToolkit.Ogc.Gml.V311.AffinePlacementType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Clothoid), typeof(global::OgcToolkit.Ogc.Gml.V311.ClothoidType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.GeodesicString), typeof(global::OgcToolkit.Ogc.Gml.V311.GeodesicStringType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Geodesic), typeof(global::OgcToolkit.Ogc.Gml.V311.GeodesicType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.CubicSpline), typeof(global::OgcToolkit.Ogc.Gml.V311.CubicSplineType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.BSpline), typeof(global::OgcToolkit.Ogc.Gml.V311.BSplineType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Bezier), typeof(global::OgcToolkit.Ogc.Gml.V311.BezierType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Surface), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.baseSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.OrientableSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.OrientableSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._SurfacePatch), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSurfacePatchType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.patches), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePatchArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.PolygonPatch), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPatchType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Triangle), typeof(global::OgcToolkit.Ogc.Gml.V311.TriangleType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Rectangle), typeof(global::OgcToolkit.Ogc.Gml.V311.RectangleType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.curveMember), typeof(global::OgcToolkit.Ogc.Gml.V311.CurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Ring), typeof(global::OgcToolkit.Ogc.Gml.V311.RingType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._ParametricCurveSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractParametricCurveSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._GriddedSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGriddedSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Cone), typeof(global::OgcToolkit.Ogc.Gml.V311.ConeType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Cylinder), typeof(global::OgcToolkit.Ogc.Gml.V311.CylinderType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Sphere), typeof(global::OgcToolkit.Ogc.Gml.V311.SphereType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.PolyhedralSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.polygonPatches), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPatchArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.trianglePatches), typeof(global::OgcToolkit.Ogc.Gml.V311.TrianglePatchArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.TriangulatedSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Tin), typeof(global::OgcToolkit.Ogc.Gml.V311.TinType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._Solid), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractSolidType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.solidProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.solidArrayProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.Solid), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311._GeometricAggregate), typeof(global::OgcToolkit.Ogc.Gml.V311.AbstractGeometricAggregateType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiGeometry), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiGeometryType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiGeometryProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiGeometryPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiPoint), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiPointProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiCurve), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurveType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiCurveProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiSurface), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfaceType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiSurfaceProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiSolid), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSolidType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiSolidProperty), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSolidPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiPolygon), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPolygonType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.MultiLineString), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiLineStringType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.geometryMember), typeof(global::OgcToolkit.Ogc.Gml.V311.GeometryPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.geometryMembers), typeof(global::OgcToolkit.Ogc.Gml.V311.GeometryArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pointMember), typeof(global::OgcToolkit.Ogc.Gml.V311.PointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.pointMembers), typeof(global::OgcToolkit.Ogc.Gml.V311.PointArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.curveMembers), typeof(global::OgcToolkit.Ogc.Gml.V311.CurveArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.surfaceMember), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.surfaceMembers), typeof(global::OgcToolkit.Ogc.Gml.V311.SurfaceArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.solidMember), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.solidMembers), typeof(global::OgcToolkit.Ogc.Gml.V311.SolidArrayPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiCenterOf), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiPosition), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiCenterLineOf), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiEdgeOf), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiCoverage), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiExtentOf), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.multiLocation), typeof(global::OgcToolkit.Ogc.Gml.V311.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.lineStringMember), typeof(global::OgcToolkit.Ogc.Gml.V311.LineStringPropertyType));
            wrapperDictionary.Add(typeof(OgcToolkit.Ogc.Gml.V311.polygonMember), typeof(global::OgcToolkit.Ogc.Gml.V311.PolygonPropertyType));
        }

        protected internal static void AddSchemas(XmlSchemaSet schemas)
        {
            //HACK: Manual change
            //schemas.Add(schemaSet);
            schemas.Add(((ILinqToXsdTypeManager)LinqToXsdTypeManager.Instance).Schemas);
        }

        public static System.Type GetRootType()
        {
            return elementDictionary[XName.Get("AbstractMetaData", "http://www.opengis.net/ows")];
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class XRootNamespace
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;


        public AbstractMetaData AbstractMetaData { get { return rootObject as AbstractMetaData; } }

        public ServiceIdentification ServiceIdentification { get { return rootObject as ServiceIdentification; } }

        public ServiceProvider ServiceProvider { get { return rootObject as ServiceProvider; } }

        public OperationsMetadata OperationsMetadata { get { return rootObject as OperationsMetadata; } }

        public ExtendedCapabilities ExtendedCapabilities { get { return rootObject as ExtendedCapabilities; } }

        public Operation Operation { get { return rootObject as Operation; } }

        public DCP DCP { get { return rootObject as DCP; } }

        public HTTP HTTP { get { return rootObject as HTTP; } }

        public ExceptionReport ExceptionReport { get { return rootObject as ExceptionReport; } }

        public Metadata Metadata { get { return rootObject as Metadata; } }

        public BoundingBox BoundingBox { get { return rootObject as BoundingBox; } }

        public WGS84BoundingBox WGS84BoundingBox { get { return rootObject as WGS84BoundingBox; } }

        public Title Title { get { return rootObject as Title; } }

        public @Abstract @Abstract { get { return rootObject as @Abstract; } }

        public Keywords Keywords { get { return rootObject as Keywords; } }

        public PointOfContact PointOfContact { get { return rootObject as PointOfContact; } }

        public IndividualName IndividualName { get { return rootObject as IndividualName; } }

        public OrganisationName OrganisationName { get { return rootObject as OrganisationName; } }

        public PositionName PositionName { get { return rootObject as PositionName; } }

        public Role Role { get { return rootObject as Role; } }

        public ContactInfo ContactInfo { get { return rootObject as ContactInfo; } }

        public Identifier Identifier { get { return rootObject as Identifier; } }

        public OutputFormat OutputFormat { get { return rootObject as OutputFormat; } }

        public AvailableCRS AvailableCRS { get { return rootObject as AvailableCRS; } }

        public SupportedCRS SupportedCRS { get { return rootObject as SupportedCRS; } }

        public AccessConstraints AccessConstraints { get { return rootObject as AccessConstraints; } }

        public Fees Fees { get { return rootObject as Fees; } }

        public Language Language { get { return rootObject as Language; } }

        public GetCapabilities GetCapabilities { get { return rootObject as GetCapabilities; } }

        public Exception Exception { get { return rootObject as Exception; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(AbstractMetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ServiceIdentification root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ServiceProvider root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(OperationsMetadata root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ExtendedCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Operation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DCP root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(HTTP root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ExceptionReport root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Metadata root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(BoundingBox root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(WGS84BoundingBox root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Title root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(@Abstract root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Keywords root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PointOfContact root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(IndividualName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(OrganisationName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PositionName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Role root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ContactInfo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(OutputFormat root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(AvailableCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(SupportedCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(AccessConstraints root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Fees root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Language root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Exception root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XDocument XDocument
        {
            get
            {
                return doc;
            }
        }

        public static XRootNamespace Load(string xmlFile)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Load(xmlFile);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Load(string xmlFile, LoadOptions options)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Load(xmlFile, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Load(TextReader textReader)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Load(textReader);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Load(TextReader textReader, LoadOptions options)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Load(textReader, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Load(XmlReader xmlReader)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Load(xmlReader);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Parse(string text)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Parse(text);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRootNamespace Parse(string text, LoadOptions options)
        {
            XRootNamespace root=new XRootNamespace();
            root.doc=XDocument.Parse(text, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public virtual void Save(string fileName)
        {
            doc.Save(fileName);
        }

        public virtual void Save(TextWriter textWriter)
        {
            doc.Save(textWriter);
        }

        public virtual void Save(XmlWriter writer)
        {
            doc.Save(writer);
        }

        public virtual void Save(TextWriter textWriter, SaveOptions options)
        {
            doc.Save(textWriter, options);
        }

        public virtual void Save(string fileName, SaveOptions options)
        {
            doc.Save(fileName, options);
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class XRoot
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;


        public global::OgcToolkit.Ogc.Ows.V100.AbstractMetaData AbstractMetaData { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.AbstractMetaData; } }

        public global::OgcToolkit.Ogc.Ows.V100.ServiceIdentification ServiceIdentification { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.ServiceIdentification; } }

        public global::OgcToolkit.Ogc.Ows.V100.ServiceProvider ServiceProvider { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.ServiceProvider; } }

        public global::OgcToolkit.Ogc.Ows.V100.OperationsMetadata OperationsMetadata { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.OperationsMetadata; } }

        public global::OgcToolkit.Ogc.Ows.V100.ExtendedCapabilities ExtendedCapabilities { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.ExtendedCapabilities; } }

        public global::OgcToolkit.Ogc.Ows.V100.Operation Operation { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Operation; } }

        public global::OgcToolkit.Ogc.Ows.V100.DCP DCP { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.DCP; } }

        public global::OgcToolkit.Ogc.Ows.V100.HTTP HTTP { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.HTTP; } }

        public global::OgcToolkit.Ogc.Ows.V100.ExceptionReport ExceptionReport { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.ExceptionReport; } }

        public global::OgcToolkit.Ogc.Ows.V100.Metadata Metadata { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Metadata; } }

        public global::OgcToolkit.Ogc.Ows.V100.BoundingBox BoundingBox { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.BoundingBox; } }

        public global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBox WGS84BoundingBox { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBox; } }

        public global::OgcToolkit.Ogc.Ows.V100.Title Title { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Title; } }

        public global::OgcToolkit.Ogc.Ows.V100.@Abstract @Abstract { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.@Abstract; } }

        public global::OgcToolkit.Ogc.Ows.V100.Keywords Keywords { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Keywords; } }

        public global::OgcToolkit.Ogc.Ows.V100.PointOfContact PointOfContact { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.PointOfContact; } }

        public global::OgcToolkit.Ogc.Ows.V100.IndividualName IndividualName { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.IndividualName; } }

        public global::OgcToolkit.Ogc.Ows.V100.OrganisationName OrganisationName { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.OrganisationName; } }

        public global::OgcToolkit.Ogc.Ows.V100.PositionName PositionName { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.PositionName; } }

        public global::OgcToolkit.Ogc.Ows.V100.Role Role { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Role; } }

        public global::OgcToolkit.Ogc.Ows.V100.ContactInfo ContactInfo { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.ContactInfo; } }

        public global::OgcToolkit.Ogc.Ows.V100.Identifier Identifier { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Identifier; } }

        public global::OgcToolkit.Ogc.Ows.V100.OutputFormat OutputFormat { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.OutputFormat; } }

        public global::OgcToolkit.Ogc.Ows.V100.AvailableCRS AvailableCRS { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.AvailableCRS; } }

        public global::OgcToolkit.Ogc.Ows.V100.SupportedCRS SupportedCRS { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.SupportedCRS; } }

        public global::OgcToolkit.Ogc.Ows.V100.AccessConstraints AccessConstraints { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.AccessConstraints; } }

        public global::OgcToolkit.Ogc.Ows.V100.Fees Fees { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Fees; } }

        public global::OgcToolkit.Ogc.Ows.V100.Language Language { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Language; } }

        public global::OgcToolkit.Ogc.Ows.V100.GetCapabilities GetCapabilities { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.GetCapabilities; } }

        public global::OgcToolkit.Ogc.Ows.V100.Exception Exception { get { return rootObject as global::OgcToolkit.Ogc.Ows.V100.Exception; } }

        public global::OgcToolkit.Ogc.Filter.V110.Filter_Capabilities Filter_Capabilities { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Filter_Capabilities; } }

        public global::OgcToolkit.Ogc.Filter.V110.LogicalOperators LogicalOperators { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.LogicalOperators; } }

        public global::OgcToolkit.Ogc.Filter.V110.SimpleArithmetic SimpleArithmetic { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.SimpleArithmetic; } }

        public global::OgcToolkit.Ogc.Filter.V110.EID EID { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.EID; } }

        public global::OgcToolkit.Ogc.Filter.V110.FID FID { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.FID; } }

        public global::OgcToolkit.Ogc.Filter.V110.Add Add { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Add; } }

        public global::OgcToolkit.Ogc.Filter.V110.Sub Sub { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Sub; } }

        public global::OgcToolkit.Ogc.Filter.V110.Mul Mul { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Mul; } }

        public global::OgcToolkit.Ogc.Filter.V110.Div Div { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Div; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyName PropertyName { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyName; } }

        public global::OgcToolkit.Ogc.Filter.V110.Function Function { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Function; } }

        public global::OgcToolkit.Ogc.Filter.V110.Literal Literal { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Literal; } }

        public global::OgcToolkit.Ogc.Filter.V110.expression expression { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.expression; } }

        public global::OgcToolkit.Ogc.Filter.V110.SortBy SortBy { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.SortBy; } }

        public global::OgcToolkit.Ogc.Filter.V110._Id _Id { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110._Id; } }

        public global::OgcToolkit.Ogc.Filter.V110.FeatureId FeatureId { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.FeatureId; } }

        public global::OgcToolkit.Ogc.Filter.V110.GmlObjectId GmlObjectId { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.GmlObjectId; } }

        public global::OgcToolkit.Ogc.Filter.V110.Filter Filter { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Filter; } }

        public global::OgcToolkit.Ogc.Filter.V110.comparisonOps comparisonOps { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.comparisonOps; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsEqualTo PropertyIsEqualTo { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsEqualTo; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsNotEqualTo PropertyIsNotEqualTo { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsNotEqualTo; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThan PropertyIsLessThan { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThan; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThan PropertyIsGreaterThan { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThan; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThanOrEqualTo PropertyIsLessThanOrEqualTo { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThanOrEqualTo; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThanOrEqualTo PropertyIsGreaterThanOrEqualTo { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThanOrEqualTo; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsLike PropertyIsLike { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsLike; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsNull PropertyIsNull { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsNull; } }

        public global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetween PropertyIsBetween { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetween; } }

        public global::OgcToolkit.Ogc.Filter.V110.spatialOps spatialOps { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.spatialOps; } }

        public global::OgcToolkit.Ogc.Filter.V110.Equals Equals { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Equals; } }

        public global::OgcToolkit.Ogc.Filter.V110.Disjoint Disjoint { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Disjoint; } }

        public global::OgcToolkit.Ogc.Filter.V110.Touches Touches { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Touches; } }

        public global::OgcToolkit.Ogc.Filter.V110.Within Within { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Within; } }

        public global::OgcToolkit.Ogc.Filter.V110.Overlaps Overlaps { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Overlaps; } }

        public global::OgcToolkit.Ogc.Filter.V110.Crosses Crosses { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Crosses; } }

        public global::OgcToolkit.Ogc.Filter.V110.Intersects Intersects { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Intersects; } }

        public global::OgcToolkit.Ogc.Filter.V110.Contains Contains { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Contains; } }

        public global::OgcToolkit.Ogc.Filter.V110.DWithin DWithin { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.DWithin; } }

        public global::OgcToolkit.Ogc.Filter.V110.Beyond Beyond { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Beyond; } }

        public global::OgcToolkit.Ogc.Filter.V110.BBOX BBOX { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.BBOX; } }

        public global::OgcToolkit.Ogc.Filter.V110.logicOps logicOps { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.logicOps; } }

        public global::OgcToolkit.Ogc.Filter.V110.And And { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.And; } }

        public global::OgcToolkit.Ogc.Filter.V110.Or Or { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Or; } }

        public global::OgcToolkit.Ogc.Filter.V110.Not Not { get { return rootObject as global::OgcToolkit.Ogc.Filter.V110.Not; } }

        public global::OgcToolkit.Ogc.Gml.V311._Object _Object { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Object; } }

        public global::OgcToolkit.Ogc.Gml.V311.@Null @Null { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.@Null; } }

        public global::OgcToolkit.Ogc.Gml.V311._GML _GML { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._GML; } }

        public global::OgcToolkit.Ogc.Gml.V311.Bag Bag { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Bag; } }

        public global::OgcToolkit.Ogc.Gml.V311.Array Array { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Array; } }

        public global::OgcToolkit.Ogc.Gml.V311._MetaData _MetaData { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._MetaData; } }

        public global::OgcToolkit.Ogc.Gml.V311.GenericMetaData GenericMetaData { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.GenericMetaData; } }

        public global::OgcToolkit.Ogc.Gml.V311._association _association { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._association; } }

        public global::OgcToolkit.Ogc.Gml.V311._strictAssociation _strictAssociation { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._strictAssociation; } }

        public global::OgcToolkit.Ogc.Gml.V311.member member { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.member; } }

        public global::OgcToolkit.Ogc.Gml.V311._reference _reference { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._reference; } }

        public global::OgcToolkit.Ogc.Gml.V311.members members { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.members; } }

        public global::OgcToolkit.Ogc.Gml.V311.metaDataProperty metaDataProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.metaDataProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.name name { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.name; } }

        public global::OgcToolkit.Ogc.Gml.V311.description description { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.description; } }

        public global::OgcToolkit.Ogc.Gml.V311.Definition Definition { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Definition; } }

        public global::OgcToolkit.Ogc.Gml.V311.Dictionary Dictionary { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Dictionary; } }

        public global::OgcToolkit.Ogc.Gml.V311.DefinitionCollection DefinitionCollection { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.DefinitionCollection; } }

        public global::OgcToolkit.Ogc.Gml.V311.dictionaryEntry dictionaryEntry { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.dictionaryEntry; } }

        public global::OgcToolkit.Ogc.Gml.V311.definitionMember definitionMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.definitionMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.indirectEntry indirectEntry { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.indirectEntry; } }

        public global::OgcToolkit.Ogc.Gml.V311.DefinitionProxy DefinitionProxy { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.DefinitionProxy; } }

        public global::OgcToolkit.Ogc.Gml.V311.definitionRef definitionRef { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.definitionRef; } }

        public global::OgcToolkit.Ogc.Gml.V311.unitOfMeasure unitOfMeasure { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.unitOfMeasure; } }

        public global::OgcToolkit.Ogc.Gml.V311.UnitDefinition UnitDefinition { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.UnitDefinition; } }

        public global::OgcToolkit.Ogc.Gml.V311.BaseUnit BaseUnit { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.BaseUnit; } }

        public global::OgcToolkit.Ogc.Gml.V311.DerivedUnit DerivedUnit { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.DerivedUnit; } }

        public global::OgcToolkit.Ogc.Gml.V311.ConventionalUnit ConventionalUnit { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.ConventionalUnit; } }

        public global::OgcToolkit.Ogc.Gml.V311.quantityType quantityType { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.quantityType; } }

        public global::OgcToolkit.Ogc.Gml.V311.catalogSymbol catalogSymbol { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.catalogSymbol; } }

        public global::OgcToolkit.Ogc.Gml.V311.derivationUnitTerm derivationUnitTerm { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.derivationUnitTerm; } }

        public global::OgcToolkit.Ogc.Gml.V311.conversionToPreferredUnit conversionToPreferredUnit { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.conversionToPreferredUnit; } }

        public global::OgcToolkit.Ogc.Gml.V311.roughConversionToPreferredUnit roughConversionToPreferredUnit { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.roughConversionToPreferredUnit; } }

        public global::OgcToolkit.Ogc.Gml.V311.measure measure { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.measure; } }

        public global::OgcToolkit.Ogc.Gml.V311.angle angle { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.angle; } }

        public global::OgcToolkit.Ogc.Gml.V311.dmsAngle dmsAngle { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.dmsAngle; } }

        public global::OgcToolkit.Ogc.Gml.V311.degrees degrees { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.degrees; } }

        public global::OgcToolkit.Ogc.Gml.V311.decimalMinutes decimalMinutes { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.decimalMinutes; } }

        public global::OgcToolkit.Ogc.Gml.V311.minutes minutes { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.minutes; } }

        public global::OgcToolkit.Ogc.Gml.V311.seconds seconds { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.seconds; } }

        public global::OgcToolkit.Ogc.Gml.V311._Geometry _Geometry { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Geometry; } }

        public global::OgcToolkit.Ogc.Gml.V311._GeometricPrimitive _GeometricPrimitive { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._GeometricPrimitive; } }

        public global::OgcToolkit.Ogc.Gml.V311.Point Point { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Point; } }

        public global::OgcToolkit.Ogc.Gml.V311.pointProperty pointProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pointProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.pointRep pointRep { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pointRep; } }

        public global::OgcToolkit.Ogc.Gml.V311.pointArrayProperty pointArrayProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pointArrayProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311._Curve _Curve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Curve; } }

        public global::OgcToolkit.Ogc.Gml.V311.curveProperty curveProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.curveProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.curveArrayProperty curveArrayProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.curveArrayProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.LineString LineString { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.LineString; } }

        public global::OgcToolkit.Ogc.Gml.V311.pos pos { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pos; } }

        public global::OgcToolkit.Ogc.Gml.V311.posList posList { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.posList; } }

        public global::OgcToolkit.Ogc.Gml.V311.vector vector { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.vector; } }

        public global::OgcToolkit.Ogc.Gml.V311.coordinates coordinates { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.coordinates; } }

        public global::OgcToolkit.Ogc.Gml.V311.Envelope Envelope { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Envelope; } }

        public global::OgcToolkit.Ogc.Gml.V311.coord coord { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.coord; } }

        public global::OgcToolkit.Ogc.Gml.V311.lineStringProperty lineStringProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.lineStringProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311._Surface _Surface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Surface; } }

        public global::OgcToolkit.Ogc.Gml.V311.surfaceProperty surfaceProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.surfaceProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.surfaceArrayProperty surfaceArrayProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.surfaceArrayProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.Polygon Polygon { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Polygon; } }

        public global::OgcToolkit.Ogc.Gml.V311._Ring _Ring { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Ring; } }

        public global::OgcToolkit.Ogc.Gml.V311.exterior exterior { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.exterior; } }

        public global::OgcToolkit.Ogc.Gml.V311.interior interior { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.interior; } }

        public global::OgcToolkit.Ogc.Gml.V311.outerBoundaryIs outerBoundaryIs { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.outerBoundaryIs; } }

        public global::OgcToolkit.Ogc.Gml.V311.innerBoundaryIs innerBoundaryIs { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.innerBoundaryIs; } }

        public global::OgcToolkit.Ogc.Gml.V311.LinearRing LinearRing { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.LinearRing; } }

        public global::OgcToolkit.Ogc.Gml.V311.polygonProperty polygonProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.polygonProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.Curve Curve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Curve; } }

        public global::OgcToolkit.Ogc.Gml.V311.baseCurve baseCurve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.baseCurve; } }

        public global::OgcToolkit.Ogc.Gml.V311.OrientableCurve OrientableCurve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.OrientableCurve; } }

        public global::OgcToolkit.Ogc.Gml.V311._CurveSegment _CurveSegment { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._CurveSegment; } }

        public global::OgcToolkit.Ogc.Gml.V311.segments segments { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.segments; } }

        public global::OgcToolkit.Ogc.Gml.V311.LineStringSegment LineStringSegment { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.LineStringSegment; } }

        public global::OgcToolkit.Ogc.Gml.V311.ArcString ArcString { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.ArcString; } }

        public global::OgcToolkit.Ogc.Gml.V311.Arc Arc { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Arc; } }

        public global::OgcToolkit.Ogc.Gml.V311.Circle Circle { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Circle; } }

        public global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulge ArcStringByBulge { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulge; } }

        public global::OgcToolkit.Ogc.Gml.V311.ArcByBulge ArcByBulge { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.ArcByBulge; } }

        public global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPoint ArcByCenterPoint { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPoint; } }

        public global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPoint CircleByCenterPoint { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPoint; } }

        public global::OgcToolkit.Ogc.Gml.V311.OffsetCurve OffsetCurve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.OffsetCurve; } }

        public global::OgcToolkit.Ogc.Gml.V311.AffinePlacement AffinePlacement { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.AffinePlacement; } }

        public global::OgcToolkit.Ogc.Gml.V311.Clothoid Clothoid { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Clothoid; } }

        public global::OgcToolkit.Ogc.Gml.V311.GeodesicString GeodesicString { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.GeodesicString; } }

        public global::OgcToolkit.Ogc.Gml.V311.Geodesic Geodesic { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Geodesic; } }

        public global::OgcToolkit.Ogc.Gml.V311.CubicSpline CubicSpline { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.CubicSpline; } }

        public global::OgcToolkit.Ogc.Gml.V311.BSpline BSpline { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.BSpline; } }

        public global::OgcToolkit.Ogc.Gml.V311.Bezier Bezier { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Bezier; } }

        public global::OgcToolkit.Ogc.Gml.V311.Surface Surface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Surface; } }

        public global::OgcToolkit.Ogc.Gml.V311.baseSurface baseSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.baseSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311.OrientableSurface OrientableSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.OrientableSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311._SurfacePatch _SurfacePatch { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._SurfacePatch; } }

        public global::OgcToolkit.Ogc.Gml.V311.patches patches { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.patches; } }

        public global::OgcToolkit.Ogc.Gml.V311.PolygonPatch PolygonPatch { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.PolygonPatch; } }

        public global::OgcToolkit.Ogc.Gml.V311.Triangle Triangle { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Triangle; } }

        public global::OgcToolkit.Ogc.Gml.V311.Rectangle Rectangle { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Rectangle; } }

        public global::OgcToolkit.Ogc.Gml.V311.curveMember curveMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.curveMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.Ring Ring { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Ring; } }

        public global::OgcToolkit.Ogc.Gml.V311._ParametricCurveSurface _ParametricCurveSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._ParametricCurveSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311._GriddedSurface _GriddedSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._GriddedSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311.Cone Cone { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Cone; } }

        public global::OgcToolkit.Ogc.Gml.V311.Cylinder Cylinder { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Cylinder; } }

        public global::OgcToolkit.Ogc.Gml.V311.Sphere Sphere { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Sphere; } }

        public global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurface PolyhedralSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311.polygonPatches polygonPatches { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.polygonPatches; } }

        public global::OgcToolkit.Ogc.Gml.V311.trianglePatches trianglePatches { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.trianglePatches; } }

        public global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurface TriangulatedSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311.Tin Tin { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Tin; } }

        public global::OgcToolkit.Ogc.Gml.V311._Solid _Solid { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._Solid; } }

        public global::OgcToolkit.Ogc.Gml.V311.solidProperty solidProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.solidProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.solidArrayProperty solidArrayProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.solidArrayProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.Solid Solid { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.Solid; } }

        public global::OgcToolkit.Ogc.Gml.V311._GeometricAggregate _GeometricAggregate { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311._GeometricAggregate; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiGeometry MultiGeometry { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiGeometry; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiGeometryProperty multiGeometryProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiGeometryProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiPoint MultiPoint { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiPoint; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiPointProperty multiPointProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiPointProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiCurve MultiCurve { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiCurve; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiCurveProperty multiCurveProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiCurveProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiSurface MultiSurface { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiSurface; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiSurfaceProperty multiSurfaceProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiSurfaceProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiSolid MultiSolid { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiSolid; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiSolidProperty multiSolidProperty { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiSolidProperty; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiPolygon MultiPolygon { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiPolygon; } }

        public global::OgcToolkit.Ogc.Gml.V311.MultiLineString MultiLineString { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.MultiLineString; } }

        public global::OgcToolkit.Ogc.Gml.V311.geometryMember geometryMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.geometryMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.geometryMembers geometryMembers { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.geometryMembers; } }

        public global::OgcToolkit.Ogc.Gml.V311.pointMember pointMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pointMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.pointMembers pointMembers { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.pointMembers; } }

        public global::OgcToolkit.Ogc.Gml.V311.curveMembers curveMembers { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.curveMembers; } }

        public global::OgcToolkit.Ogc.Gml.V311.surfaceMember surfaceMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.surfaceMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.surfaceMembers surfaceMembers { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.surfaceMembers; } }

        public global::OgcToolkit.Ogc.Gml.V311.solidMember solidMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.solidMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.solidMembers solidMembers { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.solidMembers; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiCenterOf multiCenterOf { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiCenterOf; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiPosition multiPosition { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiPosition; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiCenterLineOf multiCenterLineOf { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiCenterLineOf; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiEdgeOf multiEdgeOf { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiEdgeOf; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiCoverage multiCoverage { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiCoverage; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiExtentOf multiExtentOf { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiExtentOf; } }

        public global::OgcToolkit.Ogc.Gml.V311.multiLocation multiLocation { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.multiLocation; } }

        public global::OgcToolkit.Ogc.Gml.V311.lineStringMember lineStringMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.lineStringMember; } }

        public global::OgcToolkit.Ogc.Gml.V311.polygonMember polygonMember { get { return rootObject as global::OgcToolkit.Ogc.Gml.V311.polygonMember; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecord AbstractRecord { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecord; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecord DCMIRecord { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecord; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecord BriefRecord { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecord; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecord SummaryRecord { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecord; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Record Record { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Record; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilities GetCapabilities1 { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilities; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Capabilities Capabilities { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Capabilities; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecord DescribeRecord { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecord; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponse DescribeRecordResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponse; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecords GetRecords { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecords; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQuery AbstractQuery { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQuery; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Query Query { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Query; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Constraint Constraint { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Constraint; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetName ElementSetName { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetName; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponse GetRecordsResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponse; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordById GetRecordById { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordById; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse GetRecordByIdResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomain GetDomain { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomain; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponse GetDomainResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponse; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Acknowledgement Acknowledgement { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Acknowledgement; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Transaction Transaction { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Transaction; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordProperty RecordProperty { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordProperty; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponse TransactionResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponse; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Harvest Harvest { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Harvest; } }

        public global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponse HarvestResponse { get { return rootObject as global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponse; } }

        public global::OgcToolkit.DublinCore.Terms.@abstract @abstract1 { get { return rootObject as global::OgcToolkit.DublinCore.Terms.@abstract; } }

        public global::OgcToolkit.DublinCore.Terms.accessRights accessRights { get { return rootObject as global::OgcToolkit.DublinCore.Terms.accessRights; } }

        public global::OgcToolkit.DublinCore.Terms.alternative alternative { get { return rootObject as global::OgcToolkit.DublinCore.Terms.alternative; } }

        public global::OgcToolkit.DublinCore.Terms.audience audience { get { return rootObject as global::OgcToolkit.DublinCore.Terms.audience; } }

        public global::OgcToolkit.DublinCore.Terms.available available { get { return rootObject as global::OgcToolkit.DublinCore.Terms.available; } }

        public global::OgcToolkit.DublinCore.Terms.bibliographicCitation bibliographicCitation { get { return rootObject as global::OgcToolkit.DublinCore.Terms.bibliographicCitation; } }

        public global::OgcToolkit.DublinCore.Terms.conformsTo conformsTo { get { return rootObject as global::OgcToolkit.DublinCore.Terms.conformsTo; } }

        public global::OgcToolkit.DublinCore.Terms.created created { get { return rootObject as global::OgcToolkit.DublinCore.Terms.created; } }

        public global::OgcToolkit.DublinCore.Terms.dateAccepted dateAccepted { get { return rootObject as global::OgcToolkit.DublinCore.Terms.dateAccepted; } }

        public global::OgcToolkit.DublinCore.Terms.dateCopyrighted dateCopyrighted { get { return rootObject as global::OgcToolkit.DublinCore.Terms.dateCopyrighted; } }

        public global::OgcToolkit.DublinCore.Terms.dateSubmitted dateSubmitted { get { return rootObject as global::OgcToolkit.DublinCore.Terms.dateSubmitted; } }

        public global::OgcToolkit.DublinCore.Terms.educationLevel educationLevel { get { return rootObject as global::OgcToolkit.DublinCore.Terms.educationLevel; } }

        public global::OgcToolkit.DublinCore.Terms.extent extent { get { return rootObject as global::OgcToolkit.DublinCore.Terms.extent; } }

        public global::OgcToolkit.DublinCore.Terms.hasFormat hasFormat { get { return rootObject as global::OgcToolkit.DublinCore.Terms.hasFormat; } }

        public global::OgcToolkit.DublinCore.Terms.hasPart hasPart { get { return rootObject as global::OgcToolkit.DublinCore.Terms.hasPart; } }

        public global::OgcToolkit.DublinCore.Terms.hasVersion hasVersion { get { return rootObject as global::OgcToolkit.DublinCore.Terms.hasVersion; } }

        public global::OgcToolkit.DublinCore.Terms.isFormatOf isFormatOf { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isFormatOf; } }

        public global::OgcToolkit.DublinCore.Terms.isPartOf isPartOf { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isPartOf; } }

        public global::OgcToolkit.DublinCore.Terms.isReferencedBy isReferencedBy { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isReferencedBy; } }

        public global::OgcToolkit.DublinCore.Terms.isReplacedBy isReplacedBy { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isReplacedBy; } }

        public global::OgcToolkit.DublinCore.Terms.isRequiredBy isRequiredBy { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isRequiredBy; } }

        public global::OgcToolkit.DublinCore.Terms.issued issued { get { return rootObject as global::OgcToolkit.DublinCore.Terms.issued; } }

        public global::OgcToolkit.DublinCore.Terms.isVersionOf isVersionOf { get { return rootObject as global::OgcToolkit.DublinCore.Terms.isVersionOf; } }

        public global::OgcToolkit.DublinCore.Terms.license license { get { return rootObject as global::OgcToolkit.DublinCore.Terms.license; } }

        public global::OgcToolkit.DublinCore.Terms.mediator mediator { get { return rootObject as global::OgcToolkit.DublinCore.Terms.mediator; } }

        public global::OgcToolkit.DublinCore.Terms.medium medium { get { return rootObject as global::OgcToolkit.DublinCore.Terms.medium; } }

        public global::OgcToolkit.DublinCore.Terms.modified modified { get { return rootObject as global::OgcToolkit.DublinCore.Terms.modified; } }

        public global::OgcToolkit.DublinCore.Terms.provenance provenance { get { return rootObject as global::OgcToolkit.DublinCore.Terms.provenance; } }

        public global::OgcToolkit.DublinCore.Terms.references references { get { return rootObject as global::OgcToolkit.DublinCore.Terms.references; } }

        public global::OgcToolkit.DublinCore.Terms.replaces replaces { get { return rootObject as global::OgcToolkit.DublinCore.Terms.replaces; } }

        public global::OgcToolkit.DublinCore.Terms.requires requires { get { return rootObject as global::OgcToolkit.DublinCore.Terms.requires; } }

        public global::OgcToolkit.DublinCore.Terms.rightsHolder rightsHolder { get { return rootObject as global::OgcToolkit.DublinCore.Terms.rightsHolder; } }

        public global::OgcToolkit.DublinCore.Terms.spatial spatial { get { return rootObject as global::OgcToolkit.DublinCore.Terms.spatial; } }

        public global::OgcToolkit.DublinCore.Terms.tableOfContents tableOfContents { get { return rootObject as global::OgcToolkit.DublinCore.Terms.tableOfContents; } }

        public global::OgcToolkit.DublinCore.Terms.temporal temporal { get { return rootObject as global::OgcToolkit.DublinCore.Terms.temporal; } }

        public global::OgcToolkit.DublinCore.Terms.valid valid { get { return rootObject as global::OgcToolkit.DublinCore.Terms.valid; } }

        public global::OgcToolkit.DublinCore.Elements.V11.DCelement DCelement { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.DCelement; } }

        public global::OgcToolkit.DublinCore.Elements.V11.title title1 { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.title; } }

        public global::OgcToolkit.DublinCore.Elements.V11.creator creator { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.creator; } }

        public global::OgcToolkit.DublinCore.Elements.V11.subject subject { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.subject; } }

        public global::OgcToolkit.DublinCore.Elements.V11.description description1 { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.description; } }

        public global::OgcToolkit.DublinCore.Elements.V11.publisher publisher { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.publisher; } }

        public global::OgcToolkit.DublinCore.Elements.V11.contributor contributor { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.contributor; } }

        public global::OgcToolkit.DublinCore.Elements.V11.date date { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.date; } }

        public global::OgcToolkit.DublinCore.Elements.V11.type type { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.type; } }

        public global::OgcToolkit.DublinCore.Elements.V11.format format { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.format; } }

        public global::OgcToolkit.DublinCore.Elements.V11.identifier identifier1 { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.identifier; } }

        public global::OgcToolkit.DublinCore.Elements.V11.source source { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.source; } }

        public global::OgcToolkit.DublinCore.Elements.V11.language language1 { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.language; } }

        public global::OgcToolkit.DublinCore.Elements.V11.relation relation { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.relation; } }

        public global::OgcToolkit.DublinCore.Elements.V11.coverage coverage { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.coverage; } }

        public global::OgcToolkit.DublinCore.Elements.V11.rights rights { get { return rootObject as global::OgcToolkit.DublinCore.Elements.V11.rights; } }

        private XRoot()
        {
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.AbstractMetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.ServiceIdentification root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.ServiceProvider root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.OperationsMetadata root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.ExtendedCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Operation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.DCP root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.HTTP root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.ExceptionReport root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Metadata root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.BoundingBox root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.WGS84BoundingBox root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Title root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.@Abstract root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Keywords root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.PointOfContact root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.IndividualName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.OrganisationName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.PositionName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Role root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.ContactInfo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.OutputFormat root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.AvailableCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.SupportedCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.AccessConstraints root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Fees root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Language root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.GetCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Ows.V100.Exception root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Filter_Capabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.LogicalOperators root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.SimpleArithmetic root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.EID root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.FID root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Add root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Sub root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Mul root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Div root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Function root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Literal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.expression root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.SortBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110._Id root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.FeatureId root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.GmlObjectId root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Filter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.comparisonOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNotEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThan root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThan root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLessThanOrEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsGreaterThanOrEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsLike root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsNull root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.PropertyIsBetween root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.spatialOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Equals root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Disjoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Touches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Within root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Overlaps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Crosses root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Intersects root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Contains root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.DWithin root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Beyond root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.BBOX root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.logicOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.And root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Or root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Filter.V110.Not root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Object root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.@Null root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._GML root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Bag root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Array root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._MetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.GenericMetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._association root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._strictAssociation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.member root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._reference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.members root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.metaDataProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.name root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.description root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Definition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Dictionary root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.DefinitionCollection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.dictionaryEntry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.definitionMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.indirectEntry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.DefinitionProxy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.definitionRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.unitOfMeasure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.UnitDefinition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.BaseUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.DerivedUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.ConventionalUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.quantityType root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.catalogSymbol root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.derivationUnitTerm root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.conversionToPreferredUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.roughConversionToPreferredUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.measure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.angle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.dmsAngle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.degrees root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.decimalMinutes root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.minutes root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.seconds root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Geometry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._GeometricPrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Point root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pointProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pointRep root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pointArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Curve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.curveProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.curveArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.LineString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pos root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.posList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.vector root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.coordinates root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Envelope root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.coord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.lineStringProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Surface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.surfaceProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.surfaceArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Polygon root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Ring root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.exterior root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.interior root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.outerBoundaryIs root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.innerBoundaryIs root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.LinearRing root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.polygonProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Curve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.baseCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.OrientableCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._CurveSegment root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.segments root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.LineStringSegment root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.ArcString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Arc root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Circle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.ArcStringByBulge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.ArcByBulge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.ArcByCenterPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.CircleByCenterPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.OffsetCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.AffinePlacement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Clothoid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.GeodesicString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Geodesic root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.CubicSpline root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.BSpline root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Bezier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Surface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.baseSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.OrientableSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._SurfacePatch root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.patches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.PolygonPatch root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Triangle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Rectangle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.curveMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Ring root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._ParametricCurveSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._GriddedSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Cone root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Cylinder root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Sphere root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.PolyhedralSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.polygonPatches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.trianglePatches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.TriangulatedSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Tin root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._Solid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.solidProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.solidArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.Solid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311._GeometricAggregate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiGeometry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiGeometryProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiPointProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiCurveProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiSurfaceProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiSolidProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiPolygon root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.MultiLineString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.geometryMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.geometryMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pointMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.pointMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.curveMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.surfaceMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.surfaceMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.solidMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.solidMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiCenterOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiPosition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiCenterLineOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiEdgeOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiExtentOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.multiLocation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.lineStringMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.Gml.V311.polygonMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DCMIRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.BriefRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.SummaryRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Record root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Capabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.DescribeRecordResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecords root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.AbstractQuery root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Query root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Constraint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.ElementSetName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordsResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordById root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.GetDomainResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Acknowledgement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Transaction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.RecordProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.TransactionResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.Harvest root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.Ogc.WebCatalog.Csw.V202.HarvestResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.@abstract root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.accessRights root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.alternative root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.audience root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.available root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.bibliographicCitation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.conformsTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.created root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.dateAccepted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.dateCopyrighted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.dateSubmitted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.educationLevel root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.extent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.hasFormat root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.hasPart root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.hasVersion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isFormatOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isPartOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isReferencedBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isReplacedBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isRequiredBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.issued root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.isVersionOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.license root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.mediator root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.medium root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.modified root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.provenance root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.references root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.replaces root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.requires root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.rightsHolder root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.spatial root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.tableOfContents root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.temporal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Terms.valid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.DCelement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.title root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.creator root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.subject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.description root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.publisher root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.contributor root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.date root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.type root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.format root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.source root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.language root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.relation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.coverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::OgcToolkit.DublinCore.Elements.V11.rights root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XDocument XDocument
        {
            get
            {
                return doc;
            }
        }

        public static XRoot Load(string xmlFile)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Load(xmlFile);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Load(string xmlFile, LoadOptions options)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Load(xmlFile, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Load(TextReader textReader)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Load(textReader);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Load(TextReader textReader, LoadOptions options)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Load(textReader, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Load(XmlReader xmlReader)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Load(xmlReader);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Parse(string text)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Parse(text);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public static XRoot Parse(string text, LoadOptions options)
        {
            XRoot root=new XRoot();
            root.doc=XDocument.Parse(text, options);
            XTypedElement typedRoot=XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot==null))
            {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject=typedRoot;
            return root;
        }

        public virtual void Save(string fileName)
        {
            doc.Save(fileName);
        }

        public virtual void Save(TextWriter textWriter)
        {
            doc.Save(textWriter);
        }

        public virtual void Save(XmlWriter writer)
        {
            doc.Save(writer);
        }

        public virtual void Save(TextWriter textWriter, SaveOptions options)
        {
            doc.Save(textWriter, options);
        }

        public virtual void Save(string fileName, SaveOptions options)
        {
            doc.Save(fileName, options);
        }
    }
}
#pragma warning restore 108, 114, 3002, 3003, 3008, 3009
