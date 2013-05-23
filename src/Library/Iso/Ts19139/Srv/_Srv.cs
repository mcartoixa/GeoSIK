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

#pragma warning disable 108, 1591, 3002, 3003, 3009
namespace GeoSik.Iso.Ts19139.Srv
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
    using GeoSik.Iso.Ts19139.Gco;
    
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, opModel, theSV_Interface+, typeSpec+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ServiceSpecification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceSpecification_Type: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_PlatformNeutralServiceSpecification_PropertyType> typeSpecField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ServiceSpecification_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ServiceSpecification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("opModel", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, typeSpec+)
        /// </para>
        /// </summary>
        public SV_ServiceSpecification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, typeSpec+)
        /// </para>
        /// </summary>
        public IList<SV_PlatformNeutralServiceSpecification_PropertyType> typeSpec {
            get {
                if ((this.typeSpecField == null)) {
                    this.typeSpecField = new XTypedList<SV_PlatformNeutralServiceSpecification_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"));
                }
                return this.typeSpecField;
            }
            set {
                if ((value == null)) {
                    this.typeSpecField = null;
                }
                else {
                    if ((this.typeSpecField == null)) {
                        this.typeSpecField = XTypedList<SV_PlatformNeutralServiceSpecification_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_PlatformNeutralServiceSpecification_PropertyType>(this.typeSpecField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ServiceSpecification_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("opModel", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationModel_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"), typeof(SV_Interface_PropertyType));
            localElementDictionary.Add(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformNeutralServiceSpecification_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ServiceSpecification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_ServiceSpecification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ServiceSpecification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceSpecification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ServiceSpecification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceSpecification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ServiceSpecification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_ServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_ServiceSpecification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_ServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_ServiceSpecification SV_ServiceSpecification {
            get {
                XElement x = this.GetElement(XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv"));
                return ((SV_ServiceSpecification)(x));
            }
            set {
                this.SetElement(XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ServiceSpecification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv"), typeof(SV_ServiceSpecification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ServiceSpecification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PlatformNeutralServiceSpecification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformNeutralServiceSpecification_Type: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType> implSpecField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PlatformNeutralServiceSpecification_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformNeutralServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PlatformNeutralServiceSpecification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("opModel", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("serviceType", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("implSpec", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
        /// </para>
        /// </summary>
        public SV_PlatformNeutralServiceSpecification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
        /// </para>
        /// </summary>
        public SV_ServiceType_PropertyType serviceType {
            get {
                XElement x = this.GetElement(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"));
                return ((SV_ServiceType_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
        /// </para>
        /// </summary>
        public IList<SV_PlatformSpecificServiceSpecification_PropertyType> implSpec {
            get {
                if ((this.implSpecField == null)) {
                    this.implSpecField = new XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("implSpec", "http://www.isotc211.org/2005/srv"));
                }
                return this.implSpecField;
            }
            set {
                if ((value == null)) {
                    this.implSpecField = null;
                }
                else {
                    if ((this.implSpecField == null)) {
                        this.implSpecField = XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("implSpec", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_PlatformSpecificServiceSpecification_PropertyType>(this.implSpecField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformNeutralServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PlatformNeutralServiceSpecification_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("opModel", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationModel_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"), typeof(SV_Interface_PropertyType));
            localElementDictionary.Add(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"), typeof(SV_ServiceType_PropertyType));
            localElementDictionary.Add(XName.Get("implSpec", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformSpecificServiceSpecification_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PlatformNeutralServiceSpecification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PlatformNeutralServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_PlatformNeutralServiceSpecification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PlatformNeutralServiceSpecification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformNeutralServiceSpecification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PlatformNeutralServiceSpecification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformNeutralServiceSpecification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PlatformNeutralServiceSpecification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_PlatformNeutralServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_PlatformNeutralServiceSpecification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_PlatformNeutralServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_PlatformNeutralServiceSpecification SV_PlatformNeutralServiceSpecification {
            get {
                XElement x = this.GetElement(XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv"));
                return ((SV_PlatformNeutralServiceSpecification)(x));
            }
            set {
                this.SetElement(XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformNeutralServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PlatformNeutralServiceSpecification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformNeutralServiceSpecification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PlatformNeutralServiceSpecification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PlatformNeutralServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PlatformSpecificServiceSpecification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformSpecificServiceSpecification_Type: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Service_PropertyType> implementationField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PlatformSpecificServiceSpecification_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformSpecificServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PlatformSpecificServiceSpecification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("opModel", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("DCP", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("implementation", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public SV_PlatformSpecificServiceSpecification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public DCPList_PropertyType DCP {
            get {
                XElement x = this.GetElement(XName.Get("DCP", "http://www.isotc211.org/2005/srv"));
                return ((DCPList_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("DCP", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public SV_PlatformNeutralServiceSpecification_PropertyType typeSpec {
            get {
                XElement x = this.GetElement(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"));
                return ((SV_PlatformNeutralServiceSpecification_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public IList<SV_Service_PropertyType> implementation {
            get {
                if ((this.implementationField == null)) {
                    this.implementationField = new XTypedList<SV_Service_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("implementation", "http://www.isotc211.org/2005/srv"));
                }
                return this.implementationField;
            }
            set {
                if ((value == null)) {
                    this.implementationField = null;
                }
                else {
                    if ((this.implementationField == null)) {
                        this.implementationField = XTypedList<SV_Service_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("implementation", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Service_PropertyType>(this.implementationField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformSpecificServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PlatformSpecificServiceSpecification_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("opModel", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationModel_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"), typeof(SV_Interface_PropertyType));
            localElementDictionary.Add(XName.Get("DCP", "http://www.isotc211.org/2005/srv"), typeof(DCPList_PropertyType));
            localElementDictionary.Add(XName.Get("typeSpec", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformNeutralServiceSpecification_PropertyType));
            localElementDictionary.Add(XName.Get("implementation", "http://www.isotc211.org/2005/srv"), typeof(SV_Service_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PlatformSpecificServiceSpecification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PlatformSpecificServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_PlatformSpecificServiceSpecification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PlatformSpecificServiceSpecification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformSpecificServiceSpecification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PlatformSpecificServiceSpecification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformSpecificServiceSpecification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PlatformSpecificServiceSpecification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_PlatformSpecificServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_PlatformSpecificServiceSpecification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_PlatformSpecificServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_PlatformSpecificServiceSpecification SV_PlatformSpecificServiceSpecification {
            get {
                XElement x = this.GetElement(XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv"));
                return ((SV_PlatformSpecificServiceSpecification)(x));
            }
            set {
                this.SetElement(XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformSpecificServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PlatformSpecificServiceSpecification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformSpecificServiceSpecification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PlatformSpecificServiceSpecification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PlatformSpecificServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    [XmlSchemaProviderAttribute("SV_Port_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Port_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
         public static explicit operator SV_Port_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_Port_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Port_Type() {
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Port_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Port_Type>(this);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlQualifiedName SV_Port_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Port_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_Port)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Port_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Port_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Port_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_Port_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Port_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_Port", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_Port)?
        /// </para>
        /// </summary>
        public SV_Port_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_Port)?
        /// </para>
        /// </summary>
        public SV_Port SV_Port {
            get {
                XElement x = this.GetElement(XName.Get("SV_Port", "http://www.isotc211.org/2005/srv"));
                return ((SV_Port)(x));
            }
            set {
                this.SetElement(XName.Get("SV_Port", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Port_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Port_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_Port", "http://www.isotc211.org/2005/srv"), typeof(SV_Port));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Port_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Port_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (specification+, theSV_Port*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Service_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Service_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType> specificationField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Port_PropertyType> theSV_PortField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Service_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_Service_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Service_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("specification", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (specification+, theSV_Port*)
        /// </para>
        /// </summary>
        public SV_Service_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (specification+, theSV_Port*)
        /// </para>
        /// </summary>
        public IList<SV_PlatformSpecificServiceSpecification_PropertyType> specification {
            get {
                if ((this.specificationField == null)) {
                    this.specificationField = new XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("specification", "http://www.isotc211.org/2005/srv"));
                }
                return this.specificationField;
            }
            set {
                if ((value == null)) {
                    this.specificationField = null;
                }
                else {
                    if ((this.specificationField == null)) {
                        this.specificationField = XTypedList<SV_PlatformSpecificServiceSpecification_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("specification", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_PlatformSpecificServiceSpecification_PropertyType>(this.specificationField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (specification+, theSV_Port*)
        /// </para>
        /// </summary>
        public IList<SV_Port_PropertyType> theSV_Port {
            get {
                if ((this.theSV_PortField == null)) {
                    this.theSV_PortField = new XTypedList<SV_Port_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"));
                }
                return this.theSV_PortField;
            }
            set {
                if ((value == null)) {
                    this.theSV_PortField = null;
                }
                else {
                    if ((this.theSV_PortField == null)) {
                        this.theSV_PortField = XTypedList<SV_Port_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Port_PropertyType>(this.theSV_PortField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Service_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Service_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("specification", "http://www.isotc211.org/2005/srv"), typeof(SV_PlatformSpecificServiceSpecification_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"), typeof(SV_Port_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Service_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Service_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_Service)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Service_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Service_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Service_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_Service_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Service_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_Service", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_Service)?
        /// </para>
        /// </summary>
        public SV_Service_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_Service)?
        /// </para>
        /// </summary>
        public SV_Service SV_Service {
            get {
                XElement x = this.GetElement(XName.Get("SV_Service", "http://www.isotc211.org/2005/srv"));
                return ((SV_Service)(x));
            }
            set {
                this.SetElement(XName.Get("SV_Service", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Service_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Service_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_Service", "http://www.isotc211.org/2005/srv"), typeof(SV_Service));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Service_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Service_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (typeName, operation, theSV_PortSpecification?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Interface_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Interface_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Interface_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_Interface_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Interface_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("typeName", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("operation", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_PortSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public SV_Interface_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType typeName {
            get {
                XElement x = this.GetElement(XName.Get("typeName", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("typeName", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public SV_Operation_PropertyType operation {
            get {
                XElement x = this.GetElement(XName.Get("operation", "http://www.isotc211.org/2005/srv"));
                return ((SV_Operation_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("operation", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public SV_PortSpecification_PropertyType theSV_PortSpecification {
            get {
                XElement x = this.GetElement(XName.Get("theSV_PortSpecification", "http://www.isotc211.org/2005/srv"));
                return ((SV_PortSpecification_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("theSV_PortSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Interface_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Interface_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("typeName", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType));
            localElementDictionary.Add(XName.Get("operation", "http://www.isotc211.org/2005/srv"), typeof(SV_Operation_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_PortSpecification", "http://www.isotc211.org/2005/srv"), typeof(SV_PortSpecification_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Interface_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Interface_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_Interface)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Interface_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Interface_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Interface_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_Interface_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Interface_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_Interface", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_Interface)?
        /// </para>
        /// </summary>
        public SV_Interface_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_Interface)?
        /// </para>
        /// </summary>
        public SV_Interface SV_Interface {
            get {
                XElement x = this.GetElement(XName.Get("SV_Interface", "http://www.isotc211.org/2005/srv"));
                return ((SV_Interface)(x));
            }
            set {
                this.SetElement(XName.Get("SV_Interface", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Interface_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Interface_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_Interface", "http://www.isotc211.org/2005/srv"), typeof(SV_Interface));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Interface_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Interface_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (operationName, dependsOn*, parameter)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Operation_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Operation_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Operation_PropertyType> dependsOnField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Operation_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_Operation_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Operation_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("operationName", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("dependsOn", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("parameter", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public SV_Operation_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.MemberName_PropertyType operationName {
            get {
                XElement x = this.GetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.MemberName_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public IList<SV_Operation_PropertyType> dependsOn {
            get {
                if ((this.dependsOnField == null)) {
                    this.dependsOnField = new XTypedList<SV_Operation_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"));
                }
                return this.dependsOnField;
            }
            set {
                if ((value == null)) {
                    this.dependsOnField = null;
                }
                else {
                    if ((this.dependsOnField == null)) {
                        this.dependsOnField = XTypedList<SV_Operation_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Operation_PropertyType>(this.dependsOnField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public SV_Parameter_PropertyType parameter {
            get {
                XElement x = this.GetElement(XName.Get("parameter", "http://www.isotc211.org/2005/srv"));
                return ((SV_Parameter_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("parameter", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Operation_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Operation_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.MemberName_PropertyType));
            localElementDictionary.Add(XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"), typeof(SV_Operation_PropertyType));
            localElementDictionary.Add(XName.Get("parameter", "http://www.isotc211.org/2005/srv"), typeof(SV_Parameter_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Operation_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Operation_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_Operation)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Operation_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Operation_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Operation_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_Operation_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Operation_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_Operation", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_Operation)?
        /// </para>
        /// </summary>
        public SV_Operation_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_Operation)?
        /// </para>
        /// </summary>
        public SV_Operation SV_Operation {
            get {
                XElement x = this.GetElement(XName.Get("SV_Operation", "http://www.isotc211.org/2005/srv"));
                return ((SV_Operation)(x));
            }
            set {
                this.SetElement(XName.Get("SV_Operation", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Operation_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Operation_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_Operation", "http://www.isotc211.org/2005/srv"), typeof(SV_Operation));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Operation_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Operation_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, opModel, theSV_Interface+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AbstractSV_AbstractServiceSpecification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractSV_AbstractServiceSpecification_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Interface_PropertyType> theSV_InterfaceField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator AbstractSV_AbstractServiceSpecification_Type(XElement xe) {  return (AbstractSV_AbstractServiceSpecification_Type)XTypedServices.ToXTypedElement(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static AbstractSV_AbstractServiceSpecification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("opModel", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public AbstractSV_AbstractServiceSpecification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                XElement x = this.GetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public SV_OperationModel_PropertyType opModel {
            get {
                XElement x = this.GetElement(XName.Get("opModel", "http://www.isotc211.org/2005/srv"));
                return ((SV_OperationModel_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("opModel", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public IList<SV_Interface_PropertyType> theSV_Interface {
            get {
                if ((this.theSV_InterfaceField == null)) {
                    this.theSV_InterfaceField = new XTypedList<SV_Interface_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"));
                }
                return this.theSV_InterfaceField;
            }
            set {
                if ((value == null)) {
                    this.theSV_InterfaceField = null;
                }
                else {
                    if ((this.theSV_InterfaceField == null)) {
                        this.theSV_InterfaceField = XTypedList<SV_Interface_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Interface_PropertyType>(this.theSV_InterfaceField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("AbstractSV_AbstractServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("opModel", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationModel_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Interface", "http://www.isotc211.org/2005/srv"), typeof(SV_Interface_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName AbstractSV_AbstractServiceSpecification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AbstractSV_AbstractServiceSpecification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (AbstractSV_AbstractServiceSpecification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_AbstractServiceSpecification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_AbstractServiceSpecification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_AbstractServiceSpecification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_AbstractServiceSpecification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_AbstractServiceSpecification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (AbstractSV_AbstractServiceSpecification)?
        /// </para>
        /// </summary>
        public SV_AbstractServiceSpecification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: AbstractSV_AbstractServiceSpecification, SV_ServiceSpecification, SV_PlatformNeutralServiceSpecification, SV_PlatformSpecificServiceSpecification
        /// </para>
        /// <para>
        /// Regular expression: (AbstractSV_AbstractServiceSpecification)?
        /// </para>
        /// </summary>
        public AbstractSV_AbstractServiceSpecification AbstractSV_AbstractServiceSpecification {
            get {
                XTypedElement x = XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv"), XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv"));
                return ((AbstractSV_AbstractServiceSpecification)(x));
            }
            set {
                this.SetElement(XName.Get("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_AbstractServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_AbstractServiceSpecification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv"), typeof(AbstractSV_AbstractServiceSpecification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_AbstractServiceSpecification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_AbstractServiceSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (binding, address, theSV_Port)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PortSpecification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PortSpecification_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PortSpecification_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_PortSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PortSpecification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("binding", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("address", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public SV_PortSpecification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public DCPList_PropertyType binding {
            get {
                XElement x = this.GetElement(XName.Get("binding", "http://www.isotc211.org/2005/srv"));
                return ((DCPList_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("binding", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gmd.URL_PropertyType address {
            get {
                XElement x = this.GetElement(XName.Get("address", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gmd.URL_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("address", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public SV_Port_PropertyType theSV_Port {
            get {
                XElement x = this.GetElement(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"));
                return ((SV_Port_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PortSpecification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PortSpecification_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("binding", "http://www.isotc211.org/2005/srv"), typeof(DCPList_PropertyType));
            localElementDictionary.Add(XName.Get("address", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.URL_PropertyType));
            localElementDictionary.Add(XName.Get("theSV_Port", "http://www.isotc211.org/2005/srv"), typeof(SV_Port_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PortSpecification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PortSpecification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_PortSpecification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_PortSpecification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PortSpecification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_PortSpecification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_PortSpecification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_PortSpecification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_PortSpecification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_PortSpecification)?
        /// </para>
        /// </summary>
        public SV_PortSpecification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_PortSpecification)?
        /// </para>
        /// </summary>
        public SV_PortSpecification SV_PortSpecification {
            get {
                XElement x = this.GetElement(XName.Get("SV_PortSpecification", "http://www.isotc211.org/2005/srv"));
                return ((SV_PortSpecification)(x));
            }
            set {
                this.SetElement(XName.Get("SV_PortSpecification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PortSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_PortSpecification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_PortSpecification", "http://www.isotc211.org/2005/srv"), typeof(SV_PortSpecification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_PortSpecification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_PortSpecification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    public sealed class SV_OperationModel_Type {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition = new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "object",
                        "message"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));
        
        private SV_OperationModel_Type() {
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_OperationModel)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationModel_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationModel_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationModel_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationModel_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationModel_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_OperationModel", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_OperationModel)?
        /// </para>
        /// </summary>
        public SV_OperationModel_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_OperationModel)?
        /// </para>
        /// </summary>
        public SV_OperationModel SV_OperationModel {
            get {
                XElement x = this.GetElement(XName.Get("SV_OperationModel", "http://www.isotc211.org/2005/srv"));
                return ((SV_OperationModel)(x));
            }
            set {
                this.SetElement(XName.Get("SV_OperationModel", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationModel_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationModel_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_OperationModel", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationModel));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationModel_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationModel_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_ServiceType)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ServiceType_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceType_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ServiceType_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceType_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ServiceType_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_ServiceType", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_ServiceType)?
        /// </para>
        /// </summary>
        public SV_ServiceType_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_ServiceType)?
        /// </para>
        /// </summary>
        public SV_ServiceType SV_ServiceType {
            get {
                XElement x = this.GetElement(XName.Get("SV_ServiceType", "http://www.isotc211.org/2005/srv"));
                return ((SV_ServiceType)(x));
            }
            set {
                this.SetElement(XName.Get("SV_ServiceType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceType_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ServiceType_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_ServiceType", "http://www.isotc211.org/2005/srv"), typeof(SV_ServiceType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ServiceType_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ServiceType_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Parameter_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Parameter_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Parameter_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_Parameter_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Parameter_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("direction", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("description", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("optionality", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("repeatability", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("valueType", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public SV_Parameter_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.MemberName_Type name {
            get {
                XElement x = this.GetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.MemberName_Type)(x));
            }
            set {
                this.SetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public SV_ParameterDirection_PropertyType direction {
            get {
                XElement x = this.GetElement(XName.Get("direction", "http://www.isotc211.org/2005/srv"));
                return ((SV_ParameterDirection_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("direction", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                XElement x = this.GetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType optionality {
            get {
                XElement x = this.GetElement(XName.Get("optionality", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("optionality", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.Boolean_PropertyType repeatability {
            get {
                XElement x = this.GetElement(XName.Get("repeatability", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.Boolean_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("repeatability", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType valueType {
            get {
                XElement x = this.GetElement(XName.Get("valueType", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("valueType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Parameter_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Parameter_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.MemberName_Type));
            localElementDictionary.Add(XName.Get("direction", "http://www.isotc211.org/2005/srv"), typeof(SV_ParameterDirection_PropertyType));
            localElementDictionary.Add(XName.Get("description", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("optionality", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("repeatability", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.Boolean_PropertyType));
            localElementDictionary.Add(XName.Get("valueType", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Parameter_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Parameter_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_Parameter)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_Parameter_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Parameter_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_Parameter_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_Parameter_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_Parameter_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_Parameter", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_Parameter)?
        /// </para>
        /// </summary>
        public SV_Parameter_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_Parameter)?
        /// </para>
        /// </summary>
        public SV_Parameter SV_Parameter {
            get {
                XElement x = this.GetElement(XName.Get("SV_Parameter", "http://www.isotc211.org/2005/srv"));
                return ((SV_Parameter)(x));
            }
            set {
                this.SetElement(XName.Get("SV_Parameter", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Parameter_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_Parameter_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_Parameter", "http://www.isotc211.org/2005/srv"), typeof(SV_Parameter));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_Parameter_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_Parameter_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationMetadata_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationMetadata_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DCPList_PropertyType> DCPField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Parameter_PropertyType> parametersField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType> connectPointField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_OperationMetadata_PropertyType> dependsOnField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationMetadata_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationMetadata_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationMetadata_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("operationName", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("DCP", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("operationDescription", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("invocationName", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("parameters", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("connectPoint", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("dependsOn", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public SV_OperationMetadata_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationName {
            get {
                XElement x = this.GetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<DCPList_PropertyType> DCP {
            get {
                if ((this.DCPField == null)) {
                    this.DCPField = new XTypedList<DCPList_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("DCP", "http://www.isotc211.org/2005/srv"));
                }
                return this.DCPField;
            }
            set {
                if ((value == null)) {
                    this.DCPField = null;
                }
                else {
                    if ((this.DCPField == null)) {
                        this.DCPField = XTypedList<DCPList_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("DCP", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<DCPList_PropertyType>(this.DCPField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationDescription {
            get {
                XElement x = this.GetElement(XName.Get("operationDescription", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("operationDescription", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType invocationName {
            get {
                XElement x = this.GetElement(XName.Get("invocationName", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("invocationName", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<SV_Parameter_PropertyType> parameters {
            get {
                if ((this.parametersField == null)) {
                    this.parametersField = new XTypedList<SV_Parameter_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("parameters", "http://www.isotc211.org/2005/srv"));
                }
                return this.parametersField;
            }
            set {
                if ((value == null)) {
                    this.parametersField = null;
                }
                else {
                    if ((this.parametersField == null)) {
                        this.parametersField = XTypedList<SV_Parameter_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("parameters", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Parameter_PropertyType>(this.parametersField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType> connectPoint {
            get {
                if ((this.connectPointField == null)) {
                    this.connectPointField = new XTypedList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("connectPoint", "http://www.isotc211.org/2005/srv"));
                }
                return this.connectPointField;
            }
            set {
                if ((value == null)) {
                    this.connectPointField = null;
                }
                else {
                    if ((this.connectPointField == null)) {
                        this.connectPointField = XTypedList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("connectPoint", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType>(this.connectPointField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> dependsOn {
            get {
                if ((this.dependsOnField == null)) {
                    this.dependsOnField = new XTypedList<SV_OperationMetadata_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"));
                }
                return this.dependsOnField;
            }
            set {
                if ((value == null)) {
                    this.dependsOnField = null;
                }
                else {
                    if ((this.dependsOnField == null)) {
                        this.dependsOnField = XTypedList<SV_OperationMetadata_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_OperationMetadata_PropertyType>(this.dependsOnField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationMetadata_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationMetadata_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("DCP", "http://www.isotc211.org/2005/srv"), typeof(DCPList_PropertyType));
            localElementDictionary.Add(XName.Get("operationDescription", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("invocationName", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("parameters", "http://www.isotc211.org/2005/srv"), typeof(SV_Parameter_PropertyType));
            localElementDictionary.Add(XName.Get("connectPoint", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType));
            localElementDictionary.Add(XName.Get("dependsOn", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationMetadata_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationMetadata_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationMetadata_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_OperationMetadata)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationMetadata_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationMetadata_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationMetadata_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationMetadata_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationMetadata_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_OperationMetadata", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_OperationMetadata)?
        /// </para>
        /// </summary>
        public SV_OperationMetadata_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_OperationMetadata)?
        /// </para>
        /// </summary>
        public SV_OperationMetadata SV_OperationMetadata {
            get {
                XElement x = this.GetElement(XName.Get("SV_OperationMetadata", "http://www.isotc211.org/2005/srv"));
                return ((SV_OperationMetadata)(x));
            }
            set {
                this.SetElement(XName.Get("SV_OperationMetadata", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationMetadata_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationMetadata_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_OperationMetadata", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationMetadata));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationMetadata_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationMetadata_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ServiceIdentification_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceIdentification_Type: global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType> serviceTypeVersionField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType> restrictionsField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType> keywordsField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType> extentField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_CoupledResource_PropertyType> coupledResourceField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_OperationMetadata_PropertyType> containsOperationsField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType> operatesOnField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ServiceIdentification_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceIdentification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ServiceIdentification_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("citation", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("abstract", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("purpose", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("credit", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("status", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("pointOfContact", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("resourceMaintenance", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("graphicOverview", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("resourceFormat", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("descriptiveKeywords", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("resourceSpecificUsage", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("resourceConstraints", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("aggregationInfo", "http://www.isotc211.org/2005/gmd")), new NamedContentModelEntity(XName.Get("serviceType", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("serviceTypeVersion", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("accessProperties", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("restrictions", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("keywords", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("extent", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("coupledResource", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("couplingType", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("containsOperations", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("operatesOn", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public SV_ServiceIdentification_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.GenericName_PropertyType serviceType {
            get {
                XElement x = this.GetElement(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.GenericName_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType> serviceTypeVersion {
            get {
                if ((this.serviceTypeVersionField == null)) {
                    this.serviceTypeVersionField = new XTypedList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("serviceTypeVersion", "http://www.isotc211.org/2005/srv"));
                }
                return this.serviceTypeVersionField;
            }
            set {
                if ((value == null)) {
                    this.serviceTypeVersionField = null;
                }
                else {
                    if ((this.serviceTypeVersionField == null)) {
                        this.serviceTypeVersionField = XTypedList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("serviceTypeVersion", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType>(this.serviceTypeVersionField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_PropertyType accessProperties {
            get {
                XElement x = this.GetElement(XName.Get("accessProperties", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("accessProperties", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType> restrictions {
            get {
                if ((this.restrictionsField == null)) {
                    this.restrictionsField = new XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("restrictions", "http://www.isotc211.org/2005/srv"));
                }
                return this.restrictionsField;
            }
            set {
                if ((value == null)) {
                    this.restrictionsField = null;
                }
                else {
                    if ((this.restrictionsField == null)) {
                        this.restrictionsField = XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("restrictions", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType>(this.restrictionsField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType> keywords {
            get {
                if ((this.keywordsField == null)) {
                    this.keywordsField = new XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("keywords", "http://www.isotc211.org/2005/srv"));
                }
                return this.keywordsField;
            }
            set {
                if ((value == null)) {
                    this.keywordsField = null;
                }
                else {
                    if ((this.keywordsField == null)) {
                        this.keywordsField = XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("keywords", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType>(this.keywordsField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType> extent {
            get {
                if ((this.extentField == null)) {
                    this.extentField = new XTypedList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("extent", "http://www.isotc211.org/2005/srv"));
                }
                return this.extentField;
            }
            set {
                if ((value == null)) {
                    this.extentField = null;
                }
                else {
                    if ((this.extentField == null)) {
                        this.extentField = XTypedList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("extent", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType>(this.extentField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<SV_CoupledResource_PropertyType> coupledResource {
            get {
                if ((this.coupledResourceField == null)) {
                    this.coupledResourceField = new XTypedList<SV_CoupledResource_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("coupledResource", "http://www.isotc211.org/2005/srv"));
                }
                return this.coupledResourceField;
            }
            set {
                if ((value == null)) {
                    this.coupledResourceField = null;
                }
                else {
                    if ((this.coupledResourceField == null)) {
                        this.coupledResourceField = XTypedList<SV_CoupledResource_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("coupledResource", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_CoupledResource_PropertyType>(this.coupledResourceField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public SV_CouplingType_PropertyType couplingType {
            get {
                XElement x = this.GetElement(XName.Get("couplingType", "http://www.isotc211.org/2005/srv"));
                return ((SV_CouplingType_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("couplingType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> containsOperations {
            get {
                if ((this.containsOperationsField == null)) {
                    this.containsOperationsField = new XTypedList<SV_OperationMetadata_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("containsOperations", "http://www.isotc211.org/2005/srv"));
                }
                return this.containsOperationsField;
            }
            set {
                if ((value == null)) {
                    this.containsOperationsField = null;
                }
                else {
                    if ((this.containsOperationsField == null)) {
                        this.containsOperationsField = XTypedList<SV_OperationMetadata_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("containsOperations", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_OperationMetadata_PropertyType>(this.containsOperationsField, value);
                    }
                }
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType> operatesOn {
            get {
                if ((this.operatesOnField == null)) {
                    this.operatesOnField = new XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("operatesOn", "http://www.isotc211.org/2005/srv"));
                }
                return this.operatesOnField;
            }
            set {
                if ((value == null)) {
                    this.operatesOnField = null;
                }
                else {
                    if ((this.operatesOnField == null)) {
                        this.operatesOnField = XTypedList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("operatesOn", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType>(this.operatesOnField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceIdentification_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ServiceIdentification_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("citation", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.CI_Citation_PropertyType));
            localElementDictionary.Add(XName.Get("abstract", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("purpose", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("credit", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("status", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode_PropertyType));
            localElementDictionary.Add(XName.Get("pointOfContact", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty_PropertyType));
            localElementDictionary.Add(XName.Get("resourceMaintenance", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation_PropertyType));
            localElementDictionary.Add(XName.Get("graphicOverview", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic_PropertyType));
            localElementDictionary.Add(XName.Get("resourceFormat", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Format_PropertyType));
            localElementDictionary.Add(XName.Get("descriptiveKeywords", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType));
            localElementDictionary.Add(XName.Get("resourceSpecificUsage", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Usage_PropertyType));
            localElementDictionary.Add(XName.Get("resourceConstraints", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType));
            localElementDictionary.Add(XName.Get("aggregationInfo", "http://www.isotc211.org/2005/gmd"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation_PropertyType));
            localElementDictionary.Add(XName.Get("serviceType", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.GenericName_PropertyType));
            localElementDictionary.Add(XName.Get("serviceTypeVersion", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("accessProperties", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_PropertyType));
            localElementDictionary.Add(XName.Get("restrictions", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType));
            localElementDictionary.Add(XName.Get("keywords", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType));
            localElementDictionary.Add(XName.Get("extent", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType));
            localElementDictionary.Add(XName.Get("coupledResource", "http://www.isotc211.org/2005/srv"), typeof(SV_CoupledResource_PropertyType));
            localElementDictionary.Add(XName.Get("couplingType", "http://www.isotc211.org/2005/srv"), typeof(SV_CouplingType_PropertyType));
            localElementDictionary.Add(XName.Get("containsOperations", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationMetadata_PropertyType));
            localElementDictionary.Add(XName.Get("operatesOn", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ServiceIdentification_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ServiceIdentification_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_ServiceIdentification)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ServiceIdentification_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceIdentification_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ServiceIdentification_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceIdentification_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ServiceIdentification_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_ServiceIdentification)?
        /// </para>
        /// </summary>
        public SV_ServiceIdentification_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_ServiceIdentification)?
        /// </para>
        /// </summary>
        public SV_ServiceIdentification SV_ServiceIdentification {
            get {
                XElement x = this.GetElement(XName.Get("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv"));
                return ((SV_ServiceIdentification)(x));
            }
            set {
                this.SetElement(XName.Get("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceIdentification_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ServiceIdentification_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv"), typeof(SV_ServiceIdentification));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ServiceIdentification_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ServiceIdentification_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, description?, operation+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationChain_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChain_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_Operation_PropertyType> operationField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationChain_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChain_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationChain_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("description", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("operation", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public SV_OperationChain_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                XElement x = this.GetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                XElement x = this.GetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public IList<SV_Operation_PropertyType> operation {
            get {
                if ((this.operationField == null)) {
                    this.operationField = new XTypedList<SV_Operation_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("operation", "http://www.isotc211.org/2005/srv"));
                }
                return this.operationField;
            }
            set {
                if ((value == null)) {
                    this.operationField = null;
                }
                else {
                    if ((this.operationField == null)) {
                        this.operationField = XTypedList<SV_Operation_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("operation", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_Operation_PropertyType>(this.operationField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChain_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationChain_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("description", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("operation", "http://www.isotc211.org/2005/srv"), typeof(SV_Operation_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationChain_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationChain_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_OperationChain)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationChain_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChain_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationChain_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChain_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationChain_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_OperationChain", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_OperationChain)?
        /// </para>
        /// </summary>
        public SV_OperationChain_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_OperationChain)?
        /// </para>
        /// </summary>
        public SV_OperationChain SV_OperationChain {
            get {
                XElement x = this.GetElement(XName.Get("SV_OperationChain", "http://www.isotc211.org/2005/srv"));
                return ((SV_OperationChain)(x));
            }
            set {
                this.SetElement(XName.Get("SV_OperationChain", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChain_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationChain_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_OperationChain", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationChain));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationChain_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationChain_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (name, description?, operation+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationChainMetadata_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChainMetadata_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SV_OperationMetadata_PropertyType> operationField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationChainMetadata_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChainMetadata_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationChainMetadata_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("name", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("description", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("operation", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public SV_OperationChainMetadata_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                XElement x = this.GetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("name", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                XElement x = this.GetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("description", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> operation {
            get {
                if ((this.operationField == null)) {
                    this.operationField = new XTypedList<SV_OperationMetadata_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("operation", "http://www.isotc211.org/2005/srv"));
                }
                return this.operationField;
            }
            set {
                if ((value == null)) {
                    this.operationField = null;
                }
                else {
                    if ((this.operationField == null)) {
                        this.operationField = XTypedList<SV_OperationMetadata_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("operation", "http://www.isotc211.org/2005/srv"));
                    }
                    else {
                        XTypedServices.SetList<SV_OperationMetadata_PropertyType>(this.operationField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChainMetadata_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationChainMetadata_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("name", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("description", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("operation", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationMetadata_PropertyType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationChainMetadata_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationChainMetadata_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_OperationChainMetadata)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_OperationChainMetadata_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChainMetadata_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_OperationChainMetadata_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChainMetadata_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_OperationChainMetadata_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_OperationChainMetadata)?
        /// </para>
        /// </summary>
        public SV_OperationChainMetadata_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_OperationChainMetadata)?
        /// </para>
        /// </summary>
        public SV_OperationChainMetadata SV_OperationChainMetadata {
            get {
                XElement x = this.GetElement(XName.Get("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv"));
                return ((SV_OperationChainMetadata)(x));
            }
            set {
                this.SetElement(XName.Get("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChainMetadata_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationChainMetadata_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv"), typeof(SV_OperationChainMetadata));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_OperationChainMetadata_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_OperationChainMetadata_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (operationName, identifier, ScopedName?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_CoupledResource_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_CoupledResource_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_CoupledResource_Type(XElement xe) { return XTypedServices.ToXTypedElement<SV_CoupledResource_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_CoupledResource_Type() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("operationName", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("identifier", "http://www.isotc211.org/2005/srv")), new NamedContentModelEntity(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public SV_CoupledResource_Type() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationName {
            get {
                XElement x = this.GetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType identifier {
            get {
                XElement x = this.GetElement(XName.Get("identifier", "http://www.isotc211.org/2005/srv"));
                return ((GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType)(x));
            }
            set {
                this.SetElement(XName.Get("identifier", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.ScopedName ScopedName {
            get {
                XElement x = this.GetElement(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"));
                return ((GeoSik.Iso.Ts19139.Gco.ScopedName)(x));
            }
            set {
                this.SetElement(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"), value);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_CoupledResource_Type", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_CoupledResource_Type>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("operationName", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("identifier", "http://www.isotc211.org/2005/srv"), typeof(GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"), typeof(GeoSik.Iso.Ts19139.Gco.ScopedName));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_CoupledResource_TypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_CoupledResource_Type", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_CoupledResource)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_CoupledResource_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_CoupledResource_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue = "simple";
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_CoupledResource_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_CoupledResource_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_CoupledResource_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_CoupledResource", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_CoupledResource)?
        /// </para>
        /// </summary>
        public SV_CoupledResource_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_CoupledResource)?
        /// </para>
        /// </summary>
        public SV_CoupledResource SV_CoupledResource {
            get {
                XElement x = this.GetElement(XName.Get("SV_CoupledResource", "http://www.isotc211.org/2005/srv"));
                return ((SV_CoupledResource)(x));
            }
            set {
                this.SetElement(XName.Get("SV_CoupledResource", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string type {
            get {
                return typeFixedValue;
            }
            set {
                if (value.Equals(typeFixedValue)) {
                }
                else {
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
        public System.Uri href {
            get {
                XAttribute x = this.Attribute(XName.Get("href", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("href", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri role {
            get {
                XAttribute x = this.Attribute(XName.Get("role", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("role", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri arcrole {
            get {
                XAttribute x = this.Attribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("arcrole", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string title {
            get {
                XAttribute x = this.Attribute(XName.Get("title", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("title", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string show {
            get {
                XAttribute x = this.Attribute(XName.Get("show", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("show", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string actuate {
            get {
                XAttribute x = this.Attribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("actuate", "http://www.w3.org/1999/xlink"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref {
            get {
                XAttribute x = this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_CoupledResource_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_CoupledResource_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_CoupledResource", "http://www.isotc211.org/2005/srv"), typeof(SV_CoupledResource));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_CoupledResource_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_CoupledResource_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    public sealed class SV_ParameterDirection_Type {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition = new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "in",
                        "out",
                        "in/out"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));
        
        private SV_ParameterDirection_Type() {
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_ParameterDirection)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_ParameterDirection_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ParameterDirection_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_ParameterDirection_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_ParameterDirection_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_ParameterDirection_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_ParameterDirection", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_ParameterDirection)?
        /// </para>
        /// </summary>
        public SV_ParameterDirection_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_ParameterDirection)?
        /// </para>
        /// </summary>
        public SV_ParameterDirection SV_ParameterDirection {
            get {
                XElement x = this.GetElement(XName.Get("SV_ParameterDirection", "http://www.isotc211.org/2005/srv"));
                return ((SV_ParameterDirection)(x));
            }
            set {
                this.SetElement(XName.Get("SV_ParameterDirection", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ParameterDirection_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ParameterDirection_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_ParameterDirection", "http://www.isotc211.org/2005/srv"), typeof(SV_ParameterDirection));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_ParameterDirection_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_ParameterDirection_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (DCPList)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DCPList_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DCPList_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator DCPList_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<DCPList_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static DCPList_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DCPList", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (DCPList)?
        /// </para>
        /// </summary>
        public DCPList_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (DCPList)?
        /// </para>
        /// </summary>
        public DCPList DCPList {
            get {
                XElement x = this.GetElement(XName.Get("DCPList", "http://www.isotc211.org/2005/srv"));
                return ((DCPList)(x));
            }
            set {
                this.SetElement(XName.Get("DCPList", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("DCPList_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<DCPList_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("DCPList", "http://www.isotc211.org/2005/srv"), typeof(DCPList));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName DCPList_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DCPList_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (SV_CouplingType)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SV_CouplingType_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_CouplingType_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator SV_CouplingType_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SV_CouplingType_PropertyType>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static SV_CouplingType_PropertyType() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SV_CouplingType", "http://www.isotc211.org/2005/srv")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (SV_CouplingType)?
        /// </para>
        /// </summary>
        public SV_CouplingType_PropertyType() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (SV_CouplingType)?
        /// </para>
        /// </summary>
        public SV_CouplingType SV_CouplingType {
            get {
                XElement x = this.GetElement(XName.Get("SV_CouplingType", "http://www.isotc211.org/2005/srv"));
                return ((SV_CouplingType)(x));
            }
            set {
                this.SetElement(XName.Get("SV_CouplingType", "http://www.isotc211.org/2005/srv"), value);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason {
            get {
                XAttribute x = this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_CouplingType_PropertyType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_CouplingType_PropertyType>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("SV_CouplingType", "http://www.isotc211.org/2005/srv"), typeof(SV_CouplingType));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        public static XmlQualifiedName SV_CouplingType_PropertyTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SV_CouplingType_PropertyType", "http://www.isotc211.org/2005/srv");
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ServiceSpecificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceSpecification: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_ServiceSpecification_Type ContentField;
        
         public static explicit operator SV_ServiceSpecification(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceSpecification, SV_ServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_ServiceSpecification() : 
                base(true) {
            SetInnerType(new SV_ServiceSpecification_Type());
        }
        
        public SV_ServiceSpecification(SV_ServiceSpecification_Type content) : 
                base(true) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public new SV_ServiceSpecification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, typeSpec+)
        /// </para>
        /// </summary>
        public IList<SV_PlatformNeutralServiceSpecification_PropertyType> typeSpec {
            get {
                return this.ContentField.typeSpec;
            }
            set {
                this.ContentField.typeSpec = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_ServiceSpecification Load(string xmlFile) {
            return XTypedServices.Load<SV_ServiceSpecification, SV_ServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_ServiceSpecification Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_ServiceSpecification, SV_ServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_ServiceSpecification Parse(string xml) {
            return XTypedServices.Parse<SV_ServiceSpecification, SV_ServiceSpecification_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_ServiceSpecification(((SV_ServiceSpecification_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_ServiceSpecification_Type ContentField) {
            this.ContentField = ((SV_ServiceSpecification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ServiceSpecificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_ServiceSpecification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_PlatformNeutralServiceSpecificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformNeutralServiceSpecification: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_PlatformNeutralServiceSpecification_Type ContentField;
        
         public static explicit operator SV_PlatformNeutralServiceSpecification(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformNeutralServiceSpecification, SV_PlatformNeutralServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_PlatformNeutralServiceSpecification() : 
                base(true) {
            SetInnerType(new SV_PlatformNeutralServiceSpecification_Type());
        }
        
        public SV_PlatformNeutralServiceSpecification(SV_PlatformNeutralServiceSpecification_Type content) : 
                base(true) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public new SV_PlatformNeutralServiceSpecification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
        /// </para>
        /// </summary>
        public SV_ServiceType_PropertyType serviceType {
            get {
                return this.ContentField.serviceType;
            }
            set {
                this.ContentField.serviceType = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, serviceType, implSpec+)
        /// </para>
        /// </summary>
        public IList<SV_PlatformSpecificServiceSpecification_PropertyType> implSpec {
            get {
                return this.ContentField.implSpec;
            }
            set {
                this.ContentField.implSpec = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_PlatformNeutralServiceSpecification Load(string xmlFile) {
            return XTypedServices.Load<SV_PlatformNeutralServiceSpecification, SV_PlatformNeutralServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_PlatformNeutralServiceSpecification Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_PlatformNeutralServiceSpecification, SV_PlatformNeutralServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_PlatformNeutralServiceSpecification Parse(string xml) {
            return XTypedServices.Parse<SV_PlatformNeutralServiceSpecification, SV_PlatformNeutralServiceSpecification_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_PlatformNeutralServiceSpecification(((SV_PlatformNeutralServiceSpecification_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_PlatformNeutralServiceSpecification_Type ContentField) {
            this.ContentField = ((SV_PlatformNeutralServiceSpecification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_PlatformNeutralServiceSpecificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_PlatformNeutralServiceSpecification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_PlatformSpecificServiceSpecificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PlatformSpecificServiceSpecification: global::GeoSik.Iso.Ts19139.Srv.AbstractSV_AbstractServiceSpecification, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_PlatformSpecificServiceSpecification_Type ContentField;
        
         public static explicit operator SV_PlatformSpecificServiceSpecification(XElement xe) { return XTypedServices.ToXTypedElement<SV_PlatformSpecificServiceSpecification, SV_PlatformSpecificServiceSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_PlatformSpecificServiceSpecification() : 
                base(true) {
            SetInnerType(new SV_PlatformSpecificServiceSpecification_Type());
        }
        
        public SV_PlatformSpecificServiceSpecification(SV_PlatformSpecificServiceSpecification_Type content) : 
                base(true) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public new SV_PlatformSpecificServiceSpecification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public DCPList_PropertyType DCP {
            get {
                return this.ContentField.DCP;
            }
            set {
                this.ContentField.DCP = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public SV_PlatformNeutralServiceSpecification_PropertyType typeSpec {
            get {
                return this.ContentField.typeSpec;
            }
            set {
                this.ContentField.typeSpec = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+, DCP, typeSpec, implementation+)
        /// </para>
        /// </summary>
        public IList<SV_Service_PropertyType> implementation {
            get {
                return this.ContentField.implementation;
            }
            set {
                this.ContentField.implementation = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_PlatformSpecificServiceSpecification Load(string xmlFile) {
            return XTypedServices.Load<SV_PlatformSpecificServiceSpecification, SV_PlatformSpecificServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_PlatformSpecificServiceSpecification Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_PlatformSpecificServiceSpecification, SV_PlatformSpecificServiceSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_PlatformSpecificServiceSpecification Parse(string xml) {
            return XTypedServices.Parse<SV_PlatformSpecificServiceSpecification, SV_PlatformSpecificServiceSpecification_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_PlatformSpecificServiceSpecification(((SV_PlatformSpecificServiceSpecification_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_PlatformSpecificServiceSpecification_Type ContentField) {
            this.ContentField = ((SV_PlatformSpecificServiceSpecification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_PlatformSpecificServiceSpecificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_PlatformSpecificServiceSpecification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_PortSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Port: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_Port_Type ContentField;
        
         public static explicit operator SV_Port(XElement xe) { return XTypedServices.ToXTypedElement<SV_Port, SV_Port_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Port() {
            SetInnerType(new SV_Port_Type());
        }
        
        public SV_Port(SV_Port_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_Port_Type Content {
            get {
                return ContentField;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Port", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_Port Load(string xmlFile) {
            return XTypedServices.Load<SV_Port, SV_Port_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Port Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_Port, SV_Port_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Port Parse(string xml) {
            return XTypedServices.Parse<SV_Port, SV_Port_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_Port(((SV_Port_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_Port_Type ContentField) {
            this.ContentField = ((SV_Port_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_PortSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_Port", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ServiceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Service: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_Service_Type ContentField;
        
         public static explicit operator SV_Service(XElement xe) { return XTypedServices.ToXTypedElement<SV_Service, SV_Service_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Service() {
            SetInnerType(new SV_Service_Type());
        }
        
        public SV_Service(SV_Service_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_Service_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (specification+, theSV_Port*)
        /// </para>
        /// </summary>
        public IList<SV_PlatformSpecificServiceSpecification_PropertyType> specification {
            get {
                return this.ContentField.specification;
            }
            set {
                this.ContentField.specification = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (specification+, theSV_Port*)
        /// </para>
        /// </summary>
        public IList<SV_Port_PropertyType> theSV_Port {
            get {
                return this.ContentField.theSV_Port;
            }
            set {
                this.ContentField.theSV_Port = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Service", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_Service Load(string xmlFile) {
            return XTypedServices.Load<SV_Service, SV_Service_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Service Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_Service, SV_Service_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Service Parse(string xml) {
            return XTypedServices.Parse<SV_Service, SV_Service_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_Service(((SV_Service_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_Service_Type ContentField) {
            this.ContentField = ((SV_Service_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ServiceSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_Service", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_InterfaceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Interface: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_Interface_Type ContentField;
        
         public static explicit operator SV_Interface(XElement xe) { return XTypedServices.ToXTypedElement<SV_Interface, SV_Interface_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Interface() {
            SetInnerType(new SV_Interface_Type());
        }
        
        public SV_Interface(SV_Interface_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_Interface_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType typeName {
            get {
                return this.ContentField.typeName;
            }
            set {
                this.ContentField.typeName = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public SV_Operation_PropertyType operation {
            get {
                return this.ContentField.operation;
            }
            set {
                this.ContentField.operation = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (typeName, operation, theSV_PortSpecification?)
        /// </para>
        /// </summary>
        public SV_PortSpecification_PropertyType theSV_PortSpecification {
            get {
                return this.ContentField.theSV_PortSpecification;
            }
            set {
                this.ContentField.theSV_PortSpecification = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Interface", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_Interface Load(string xmlFile) {
            return XTypedServices.Load<SV_Interface, SV_Interface_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Interface Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_Interface, SV_Interface_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Interface Parse(string xml) {
            return XTypedServices.Parse<SV_Interface, SV_Interface_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_Interface(((SV_Interface_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_Interface_Type ContentField) {
            this.ContentField = ((SV_Interface_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_InterfaceSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_Interface", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_OperationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Operation: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_Operation_Type ContentField;
        
         public static explicit operator SV_Operation(XElement xe) { return XTypedServices.ToXTypedElement<SV_Operation, SV_Operation_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Operation() {
            SetInnerType(new SV_Operation_Type());
        }
        
        public SV_Operation(SV_Operation_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_Operation_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.MemberName_PropertyType operationName {
            get {
                return this.ContentField.operationName;
            }
            set {
                this.ContentField.operationName = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public IList<SV_Operation_PropertyType> dependsOn {
            get {
                return this.ContentField.dependsOn;
            }
            set {
                this.ContentField.dependsOn = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, dependsOn*, parameter)
        /// </para>
        /// </summary>
        public SV_Parameter_PropertyType parameter {
            get {
                return this.ContentField.parameter;
            }
            set {
                this.ContentField.parameter = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Operation", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_Operation Load(string xmlFile) {
            return XTypedServices.Load<SV_Operation, SV_Operation_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Operation Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_Operation, SV_Operation_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Operation Parse(string xml) {
            return XTypedServices.Parse<SV_Operation, SV_Operation_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_Operation(((SV_Operation_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_Operation_Type ContentField) {
            this.ContentField = ((SV_Operation_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_OperationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_Operation", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("AbstractSV_AbstractServiceSpecificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractSV_AbstractServiceSpecification: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AbstractSV_AbstractServiceSpecification_Type ContentField;
        
         public static explicit operator AbstractSV_AbstractServiceSpecification(XElement xe) {  return (AbstractSV_AbstractServiceSpecification)XTypedServices.ToXTypedElement(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        protected AbstractSV_AbstractServiceSpecification(bool setNull) {
        }
        
        public AbstractSV_AbstractServiceSpecification() {
            throw new InvalidOperationException();
        }
        
        public AbstractSV_AbstractServiceSpecification(AbstractSV_AbstractServiceSpecification_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                if ((this.ContentField != null)) {
                    this.ContentField.Untyped = value;
                }
            }
        }
        
        public AbstractSV_AbstractServiceSpecification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                return this.ContentField.name;
            }
            set {
                this.ContentField.name = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public SV_OperationModel_PropertyType opModel {
            get {
                return this.ContentField.opModel;
            }
            set {
                this.ContentField.opModel = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, opModel, theSV_Interface+)
        /// </para>
        /// </summary>
        public IList<SV_Interface_PropertyType> theSV_Interface {
            get {
                return this.ContentField.theSV_Interface;
            }
            set {
                this.ContentField.theSV_Interface = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static AbstractSV_AbstractServiceSpecification Load(string xmlFile) {
            return ((AbstractSV_AbstractServiceSpecification)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }
        
        public static AbstractSV_AbstractServiceSpecification Load(System.IO.TextReader xmlFile) {
            return ((AbstractSV_AbstractServiceSpecification)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }
        
        public static AbstractSV_AbstractServiceSpecification Parse(string xml) {
            return ((AbstractSV_AbstractServiceSpecification)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }
        
        private void SetInnerType(AbstractSV_AbstractServiceSpecification_Type ContentField) {
            this.ContentField = ((AbstractSV_AbstractServiceSpecification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        protected virtual void SetSubstitutionMember(AbstractSV_AbstractServiceSpecification_Type ContentField) {
            this.ContentField = ContentField;
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType AbstractSV_AbstractServiceSpecificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractSV_AbstractServiceSpecification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_PortSpecificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_PortSpecification: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_PortSpecification_Type ContentField;
        
         public static explicit operator SV_PortSpecification(XElement xe) { return XTypedServices.ToXTypedElement<SV_PortSpecification, SV_PortSpecification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_PortSpecification() {
            SetInnerType(new SV_PortSpecification_Type());
        }
        
        public SV_PortSpecification(SV_PortSpecification_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_PortSpecification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public DCPList_PropertyType binding {
            get {
                return this.ContentField.binding;
            }
            set {
                this.ContentField.binding = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gmd.URL_PropertyType address {
            get {
                return this.ContentField.address;
            }
            set {
                this.ContentField.address = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (binding, address, theSV_Port)
        /// </para>
        /// </summary>
        public SV_Port_PropertyType theSV_Port {
            get {
                return this.ContentField.theSV_Port;
            }
            set {
                this.ContentField.theSV_Port = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_PortSpecification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_PortSpecification Load(string xmlFile) {
            return XTypedServices.Load<SV_PortSpecification, SV_PortSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_PortSpecification Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_PortSpecification, SV_PortSpecification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_PortSpecification Parse(string xml) {
            return XTypedServices.Parse<SV_PortSpecification, SV_PortSpecification_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_PortSpecification(((SV_PortSpecification_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_PortSpecification_Type ContentField) {
            this.ContentField = ((SV_PortSpecification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_PortSpecificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_PortSpecification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_OperationModelSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationModel: global::GeoSik.Iso.Ts19139.Gco.CharacterString, IXMetaData, IXmlSerializable
    {
        
         public static explicit operator SV_OperationModel(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationModel>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_OperationModel() {
        }
        
        public SV_OperationModel(string content) {
            this.TypedValue = content;
        }
        
        public new string TypedValue {
            get {
                XElement x = this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetValueWithValidation(value, "TypedValue", global::GeoSik.Iso.Ts19139.Srv.SV_OperationModel_Type.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationModel", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_OperationModel Load(string xmlFile) {
            return XTypedServices.Load<SV_OperationModel>(xmlFile);
        }
        
        public static SV_OperationModel Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_OperationModel>(xmlFile);
        }
        
        public new static SV_OperationModel Parse(string xml) {
            return XTypedServices.Parse<SV_OperationModel>(xml);
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_OperationModel>(this);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_OperationModelSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_OperationModel", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ServiceTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceType: global::GeoSik.Iso.Ts19139.Gco.CharacterString, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField;
        
         public static explicit operator SV_ServiceType(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_ServiceType() : 
                base() {
            SetInnerType(new GeoSik.Iso.Ts19139.Gco.CodeListValue_Type());
        }
        
        public SV_ServiceType(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type content) : 
                base() {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public GeoSik.Iso.Ts19139.Gco.CodeListValue_Type Content {
            get {
                return ContentField;
            }
        }
        
        public string TypedValue {
            get {
                return this.ContentField.TypedValue;
            }
            set {
                this.ContentField.TypedValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeList {
            get {
                return this.ContentField.codeList;
            }
            set {
                this.ContentField.codeList = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeListValue {
            get {
                return this.ContentField.codeListValue;
            }
            set {
                this.ContentField.codeListValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace {
            get {
                return this.ContentField.codeSpace;
            }
            set {
                this.ContentField.codeSpace = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_ServiceType Load(string xmlFile) {
            return XTypedServices.Load<SV_ServiceType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_ServiceType Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_ServiceType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_ServiceType Parse(string xml) {
            return XTypedServices.Parse<SV_ServiceType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_ServiceType(((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField) {
            this.ContentField = ((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ServiceTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_ServiceType", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ParameterSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_Parameter: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_Parameter_Type ContentField;
        
         public static explicit operator SV_Parameter(XElement xe) { return XTypedServices.ToXTypedElement<SV_Parameter, SV_Parameter_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_Parameter() {
            SetInnerType(new SV_Parameter_Type());
        }
        
        public SV_Parameter(SV_Parameter_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_Parameter_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.MemberName_Type name {
            get {
                return this.ContentField.name;
            }
            set {
                this.ContentField.name = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public SV_ParameterDirection_PropertyType direction {
            get {
                return this.ContentField.direction;
            }
            set {
                this.ContentField.direction = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                return this.ContentField.description;
            }
            set {
                this.ContentField.description = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType optionality {
            get {
                return this.ContentField.optionality;
            }
            set {
                this.ContentField.optionality = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.Boolean_PropertyType repeatability {
            get {
                return this.ContentField.repeatability;
            }
            set {
                this.ContentField.repeatability = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, direction?, description?, optionality, repeatability, valueType)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType valueType {
            get {
                return this.ContentField.valueType;
            }
            set {
                this.ContentField.valueType = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_Parameter", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_Parameter Load(string xmlFile) {
            return XTypedServices.Load<SV_Parameter, SV_Parameter_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Parameter Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_Parameter, SV_Parameter_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_Parameter Parse(string xml) {
            return XTypedServices.Parse<SV_Parameter, SV_Parameter_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_Parameter(((SV_Parameter_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_Parameter_Type ContentField) {
            this.ContentField = ((SV_Parameter_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ParameterSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_Parameter", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_OperationMetadataSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationMetadata: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_OperationMetadata_Type ContentField;
        
         public static explicit operator SV_OperationMetadata(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationMetadata, SV_OperationMetadata_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_OperationMetadata() {
            SetInnerType(new SV_OperationMetadata_Type());
        }
        
        public SV_OperationMetadata(SV_OperationMetadata_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_OperationMetadata_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationName {
            get {
                return this.ContentField.operationName;
            }
            set {
                this.ContentField.operationName = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<DCPList_PropertyType> DCP {
            get {
                return this.ContentField.DCP;
            }
            set {
                this.ContentField.DCP = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationDescription {
            get {
                return this.ContentField.operationDescription;
            }
            set {
                this.ContentField.operationDescription = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType invocationName {
            get {
                return this.ContentField.invocationName;
            }
            set {
                this.ContentField.invocationName = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<SV_Parameter_PropertyType> parameters {
            get {
                return this.ContentField.parameters;
            }
            set {
                this.ContentField.parameters = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType> connectPoint {
            get {
                return this.ContentField.connectPoint;
            }
            set {
                this.ContentField.connectPoint = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (operationName, DCP+, operationDescription?, invocationName?, parameters*, connectPoint+, dependsOn*)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> dependsOn {
            get {
                return this.ContentField.dependsOn;
            }
            set {
                this.ContentField.dependsOn = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationMetadata", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_OperationMetadata Load(string xmlFile) {
            return XTypedServices.Load<SV_OperationMetadata, SV_OperationMetadata_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationMetadata Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_OperationMetadata, SV_OperationMetadata_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationMetadata Parse(string xml) {
            return XTypedServices.Parse<SV_OperationMetadata, SV_OperationMetadata_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_OperationMetadata(((SV_OperationMetadata_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_OperationMetadata_Type ContentField) {
            this.ContentField = ((SV_OperationMetadata_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_OperationMetadataSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_OperationMetadata", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ServiceIdentificationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ServiceIdentification: global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_ServiceIdentification_Type ContentField;
        
         public static explicit operator SV_ServiceIdentification(XElement xe) { return XTypedServices.ToXTypedElement<SV_ServiceIdentification, SV_ServiceIdentification_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_ServiceIdentification() : 
                base(true) {
            SetInnerType(new SV_ServiceIdentification_Type());
        }
        
        public SV_ServiceIdentification(SV_ServiceIdentification_Type content) : 
                base(true) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public new SV_ServiceIdentification_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.GenericName_PropertyType serviceType {
            get {
                return this.ContentField.serviceType;
            }
            set {
                this.ContentField.serviceType = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType> serviceTypeVersion {
            get {
                return this.ContentField.serviceTypeVersion;
            }
            set {
                this.ContentField.serviceTypeVersion = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_PropertyType accessProperties {
            get {
                return this.ContentField.accessProperties;
            }
            set {
                this.ContentField.accessProperties = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType> restrictions {
            get {
                return this.ContentField.restrictions;
            }
            set {
                this.ContentField.restrictions = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType> keywords {
            get {
                return this.ContentField.keywords;
            }
            set {
                this.ContentField.keywords = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType> extent {
            get {
                return this.ContentField.extent;
            }
            set {
                this.ContentField.extent = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<SV_CoupledResource_PropertyType> coupledResource {
            get {
                return this.ContentField.coupledResource;
            }
            set {
                this.ContentField.coupledResource = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public SV_CouplingType_PropertyType couplingType {
            get {
                return this.ContentField.couplingType;
            }
            set {
                this.ContentField.couplingType = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> containsOperations {
            get {
                return this.ContentField.containsOperations;
            }
            set {
                this.ContentField.containsOperations = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (citation, @abstract, purpose?, credit*, status*, pointOfContact*, resourceMaintenance*, graphicOverview*, resourceFormat*, descriptiveKeywords*, resourceSpecificUsage*, resourceConstraints*, aggregationInfo*, serviceType, serviceTypeVersion*, accessProperties?, restrictions*, keywords*, extent*, coupledResource*, couplingType, containsOperations+, operatesOn*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType> operatesOn {
            get {
                return this.ContentField.operatesOn;
            }
            set {
                this.ContentField.operatesOn = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_ServiceIdentification Load(string xmlFile) {
            return XTypedServices.Load<SV_ServiceIdentification, SV_ServiceIdentification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_ServiceIdentification Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_ServiceIdentification, SV_ServiceIdentification_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_ServiceIdentification Parse(string xml) {
            return XTypedServices.Parse<SV_ServiceIdentification, SV_ServiceIdentification_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_ServiceIdentification(((SV_ServiceIdentification_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_ServiceIdentification_Type ContentField) {
            this.ContentField = ((SV_ServiceIdentification_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ServiceIdentificationSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_ServiceIdentification", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_OperationChainSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChain: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_OperationChain_Type ContentField;
        
         public static explicit operator SV_OperationChain(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChain, SV_OperationChain_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_OperationChain() {
            SetInnerType(new SV_OperationChain_Type());
        }
        
        public SV_OperationChain(SV_OperationChain_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_OperationChain_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                return this.ContentField.name;
            }
            set {
                this.ContentField.name = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                return this.ContentField.description;
            }
            set {
                this.ContentField.description = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public IList<SV_Operation_PropertyType> operation {
            get {
                return this.ContentField.operation;
            }
            set {
                this.ContentField.operation = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChain", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_OperationChain Load(string xmlFile) {
            return XTypedServices.Load<SV_OperationChain, SV_OperationChain_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationChain Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_OperationChain, SV_OperationChain_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationChain Parse(string xml) {
            return XTypedServices.Parse<SV_OperationChain, SV_OperationChain_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_OperationChain(((SV_OperationChain_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_OperationChain_Type ContentField) {
            this.ContentField = ((SV_OperationChain_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_OperationChainSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_OperationChain", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_OperationChainMetadataSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_OperationChainMetadata: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_OperationChainMetadata_Type ContentField;
        
         public static explicit operator SV_OperationChainMetadata(XElement xe) { return XTypedServices.ToXTypedElement<SV_OperationChainMetadata, SV_OperationChainMetadata_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_OperationChainMetadata() {
            SetInnerType(new SV_OperationChainMetadata_Type());
        }
        
        public SV_OperationChainMetadata(SV_OperationChainMetadata_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_OperationChainMetadata_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType name {
            get {
                return this.ContentField.name;
            }
            set {
                this.ContentField.name = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType description {
            get {
                return this.ContentField.description;
            }
            set {
                this.ContentField.description = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (name, description?, operation+)
        /// </para>
        /// </summary>
        public IList<SV_OperationMetadata_PropertyType> operation {
            get {
                return this.ContentField.operation;
            }
            set {
                this.ContentField.operation = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_OperationChainMetadata Load(string xmlFile) {
            return XTypedServices.Load<SV_OperationChainMetadata, SV_OperationChainMetadata_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationChainMetadata Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_OperationChainMetadata, SV_OperationChainMetadata_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_OperationChainMetadata Parse(string xml) {
            return XTypedServices.Parse<SV_OperationChainMetadata, SV_OperationChainMetadata_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_OperationChainMetadata(((SV_OperationChainMetadata_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_OperationChainMetadata_Type ContentField) {
            this.ContentField = ((SV_OperationChainMetadata_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_OperationChainMetadataSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_OperationChainMetadata", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_CoupledResourceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_CoupledResource: XTypedElement, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SV_CoupledResource_Type ContentField;
        
         public static explicit operator SV_CoupledResource(XElement xe) { return XTypedServices.ToXTypedElement<SV_CoupledResource, SV_CoupledResource_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_CoupledResource() {
            SetInnerType(new SV_CoupledResource_Type());
        }
        
        public SV_CoupledResource(SV_CoupledResource_Type content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public SV_CoupledResource_Type Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType operationName {
            get {
                return this.ContentField.operationName;
            }
            set {
                this.ContentField.operationName = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType identifier {
            get {
                return this.ContentField.identifier;
            }
            set {
                this.ContentField.identifier = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (operationName, identifier, ScopedName?)
        /// </para>
        /// </summary>
        public GeoSik.Iso.Ts19139.Gco.ScopedName ScopedName {
            get {
                return this.ContentField.ScopedName;
            }
            set {
                this.ContentField.ScopedName = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_CoupledResource", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static SV_CoupledResource Load(string xmlFile) {
            return XTypedServices.Load<SV_CoupledResource, SV_CoupledResource_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_CoupledResource Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_CoupledResource, SV_CoupledResource_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_CoupledResource Parse(string xml) {
            return XTypedServices.Parse<SV_CoupledResource, SV_CoupledResource_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_CoupledResource(((SV_CoupledResource_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(SV_CoupledResource_Type ContentField) {
            this.ContentField = ((SV_CoupledResource_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_CoupledResourceSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_CoupledResource", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_ParameterDirectionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_ParameterDirection: global::GeoSik.Iso.Ts19139.Gco.CharacterString, IXMetaData, IXmlSerializable
    {
        
         public static explicit operator SV_ParameterDirection(XElement xe) { return XTypedServices.ToXTypedElement<SV_ParameterDirection>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_ParameterDirection() {
        }
        
        public SV_ParameterDirection(string content) {
            this.TypedValue = content;
        }
        
        public new string TypedValue {
            get {
                XElement x = this.Untyped;
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetValueWithValidation(value, "TypedValue", global::GeoSik.Iso.Ts19139.Srv.SV_ParameterDirection_Type.TypeDefinition);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_ParameterDirection", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_ParameterDirection Load(string xmlFile) {
            return XTypedServices.Load<SV_ParameterDirection>(xmlFile);
        }
        
        public static SV_ParameterDirection Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_ParameterDirection>(xmlFile);
        }
        
        public new static SV_ParameterDirection Parse(string xml) {
            return XTypedServices.Parse<SV_ParameterDirection>(xml);
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<SV_ParameterDirection>(this);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_ParameterDirectionSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_ParameterDirection", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("DCPListSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DCPList: global::GeoSik.Iso.Ts19139.Gco.CharacterString, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField;
        
         public static explicit operator DCPList(XElement xe) { return XTypedServices.ToXTypedElement<DCPList, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public DCPList() : 
                base() {
            SetInnerType(new GeoSik.Iso.Ts19139.Gco.CodeListValue_Type());
        }
        
        public DCPList(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type content) : 
                base() {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public GeoSik.Iso.Ts19139.Gco.CodeListValue_Type Content {
            get {
                return ContentField;
            }
        }
        
        public string TypedValue {
            get {
                return this.ContentField.TypedValue;
            }
            set {
                this.ContentField.TypedValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeList {
            get {
                return this.ContentField.codeList;
            }
            set {
                this.ContentField.codeList = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeListValue {
            get {
                return this.ContentField.codeListValue;
            }
            set {
                this.ContentField.codeListValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace {
            get {
                return this.ContentField.codeSpace;
            }
            set {
                this.ContentField.codeSpace = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("DCPList", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static DCPList Load(string xmlFile) {
            return XTypedServices.Load<DCPList, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static DCPList Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<DCPList, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static DCPList Parse(string xml) {
            return XTypedServices.Parse<DCPList, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new DCPList(((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField) {
            this.ContentField = ((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType DCPListSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DCPList", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }
    
    [XmlSchemaProviderAttribute("SV_CouplingTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SV_CouplingType: global::GeoSik.Iso.Ts19139.Gco.CharacterString, IXMetaData, IXmlSerializable
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField;
        
         public static explicit operator SV_CouplingType(XElement xe) { return XTypedServices.ToXTypedElement<SV_CouplingType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public SV_CouplingType() : 
                base() {
            SetInnerType(new GeoSik.Iso.Ts19139.Gco.CodeListValue_Type());
        }
        
        public SV_CouplingType(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type content) : 
                base() {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public GeoSik.Iso.Ts19139.Gco.CodeListValue_Type Content {
            get {
                return ContentField;
            }
        }
        
        public string TypedValue {
            get {
                return this.ContentField.TypedValue;
            }
            set {
                this.ContentField.TypedValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeList {
            get {
                return this.ContentField.codeList;
            }
            set {
                this.ContentField.codeList = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeListValue {
            get {
                return this.ContentField.codeListValue;
            }
            set {
                this.ContentField.codeListValue = value;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri codeSpace {
            get {
                return this.ContentField.codeSpace;
            }
            set {
                this.ContentField.codeSpace = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("SV_CouplingType", "http://www.isotc211.org/2005/srv");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public new static SV_CouplingType Load(string xmlFile) {
            return XTypedServices.Load<SV_CouplingType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static SV_CouplingType Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<SV_CouplingType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public new static SV_CouplingType Parse(string xml) {
            return XTypedServices.Parse<SV_CouplingType, GeoSik.Iso.Ts19139.Gco.CodeListValue_Type>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new SV_CouplingType(((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(this.Content.Clone())));
        }
        
        private void SetInnerType(GeoSik.Iso.Ts19139.Gco.CodeListValue_Type ContentField) {
            this.ContentField = ((GeoSik.Iso.Ts19139.Gco.CodeListValue_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
        
        public static XmlSchemaType SV_CouplingTypeSchemaProvider(XmlSchemaSet schemas) {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element = ((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SV_CouplingType", "http://www.isotc211.org/2005/srv")]));
            if ((element != null)) {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class XRootNamespace
    {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;
        

    public SV_ServiceSpecification SV_ServiceSpecification {  get {return rootObject as SV_ServiceSpecification; } }

    public SV_PlatformNeutralServiceSpecification SV_PlatformNeutralServiceSpecification {  get {return rootObject as SV_PlatformNeutralServiceSpecification; } }

    public SV_PlatformSpecificServiceSpecification SV_PlatformSpecificServiceSpecification {  get {return rootObject as SV_PlatformSpecificServiceSpecification; } }

    public SV_Port SV_Port {  get {return rootObject as SV_Port; } }

    public SV_Service SV_Service {  get {return rootObject as SV_Service; } }

    public SV_Interface SV_Interface {  get {return rootObject as SV_Interface; } }

    public SV_Operation SV_Operation {  get {return rootObject as SV_Operation; } }

    public AbstractSV_AbstractServiceSpecification AbstractSV_AbstractServiceSpecification {  get {return rootObject as AbstractSV_AbstractServiceSpecification; } }

    public SV_PortSpecification SV_PortSpecification {  get {return rootObject as SV_PortSpecification; } }

    public SV_OperationModel SV_OperationModel {  get {return rootObject as SV_OperationModel; } }

    public SV_ServiceType SV_ServiceType {  get {return rootObject as SV_ServiceType; } }

    public SV_Parameter SV_Parameter {  get {return rootObject as SV_Parameter; } }

    public SV_OperationMetadata SV_OperationMetadata {  get {return rootObject as SV_OperationMetadata; } }

    public SV_ServiceIdentification SV_ServiceIdentification {  get {return rootObject as SV_ServiceIdentification; } }

    public SV_OperationChain SV_OperationChain {  get {return rootObject as SV_OperationChain; } }

    public SV_OperationChainMetadata SV_OperationChainMetadata {  get {return rootObject as SV_OperationChainMetadata; } }

    public SV_CoupledResource SV_CoupledResource {  get {return rootObject as SV_CoupledResource; } }

    public SV_ParameterDirection SV_ParameterDirection {  get {return rootObject as SV_ParameterDirection; } }

    public DCPList DCPList {  get {return rootObject as DCPList; } }

    public SV_CouplingType SV_CouplingType {  get {return rootObject as SV_CouplingType; } }
        
        private XRootNamespace() {
        }
        
        public XRootNamespace(SV_ServiceSpecification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_PlatformNeutralServiceSpecification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_PlatformSpecificServiceSpecification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_Port root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_Service root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_Interface root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_Operation root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(AbstractSV_AbstractServiceSpecification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_PortSpecification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_OperationModel root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_ServiceType root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_Parameter root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_OperationMetadata root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_ServiceIdentification root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_OperationChain root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_OperationChainMetadata root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_CoupledResource root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_ParameterDirection root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(DCPList root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XRootNamespace(SV_CouplingType root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XDocument XDocument {
            get {
                return doc;
            }
        }
        
        public static XRootNamespace Load(string xmlFile) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(string xmlFile, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(XmlReader xmlReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public virtual void Save(string fileName) {
            doc.Save(fileName);
        }
        
        public virtual void Save(TextWriter textWriter) {
            doc.Save(textWriter);
        }
        
        public virtual void Save(XmlWriter writer) {
            doc.Save(writer);
        }
        
        public virtual void Save(TextWriter textWriter, SaveOptions options) {
            doc.Save(textWriter, options);
        }
        
        public virtual void Save(string fileName, SaveOptions options) {
            doc.Save(fileName, options);
        }
    }
}
#pragma warning restore 108, 1591, 3002, 3003, 3009
