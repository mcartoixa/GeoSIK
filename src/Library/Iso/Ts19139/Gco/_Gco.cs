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
namespace GeoSik.Iso.Ts19139.Gco
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
    using GeoSik.Ogc.Gml.V321;
    using GeoSik.Iso.Ts19139.Gmd;
    using GeoSik.Iso.Ts19139.Gss;
    using GeoSik.Iso.Ts19139.Gts;
    using GeoSik.Iso.Ts19139.Gsr;


    [XmlSchemaProviderAttribute("RecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Record: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Record(XElement xe) { return XTypedServices.ToXTypedElement<Record>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Record()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Record", "http://www.isotc211.org/2005/gco");
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

        public static Record Load(string xmlFile)
        {
            return XTypedServices.Load<Record>(xmlFile);
        }

        public static Record Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Record>(xmlFile);
        }

        public static Record Parse(string xml)
        {
            return XTypedServices.Parse<Record>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Record>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Record", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AbstractObject_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractObject_Type: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AbstractObject_Type(XElement xe) { return (AbstractObject_Type)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractObject_Type()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string id
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("id", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("id", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuid
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuid", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuid", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AbstractObject_Type", "http://www.isotc211.org/2005/gco");
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

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName AbstractObject_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AbstractObject_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("ObjectReference_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ObjectReference_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        public static explicit operator ObjectReference_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<ObjectReference_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ObjectReference_PropertyType()
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

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ObjectReference_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<ObjectReference_PropertyType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName ObjectReference_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ObjectReference_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("CodeListValue_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CodeListValue_Type: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator CodeListValue_Type(XElement xe) { return XTypedServices.ToXTypedElement<CodeListValue_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public CodeListValue_Type()
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
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeList
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("codeList", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("codeList", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri codeListValue
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("codeListValue", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("codeListValue", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("CodeListValue_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<CodeListValue_Type>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName CodeListValue_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("CodeListValue_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// A TypeName is a LocalName that references either a recordType or object type in some form of schema. The stored value "aName" is the returned value for the "aName()" operation. This is the types name.  - For parsing from types (or objects) the parsible name normally uses a "." navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
    /// </para>
    /// <para>
    /// Regular expression: (aName)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TypeName_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TypeName_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TypeName_Type(XElement xe) { return XTypedServices.ToXTypedElement<TypeName_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TypeName_Type()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("aName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// A TypeName is a LocalName that references either a recordType or object type in some form of schema. The stored value "aName" is the returned value for the "aName()" operation. This is the types name.  - For parsing from types (or objects) the parsible name normally uses a "." navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
        /// </para>
        /// <para>
        /// Regular expression: (aName)
        /// </para>
        /// </summary>
        public TypeName_Type()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName)
        /// </para>
        /// </summary>
        public CharacterString_PropertyType aName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("aName", "http://www.isotc211.org/2005/gco"));
                return ((CharacterString_PropertyType)(x));
            }
            set
            {
                this.SetElement(XName.Get("aName", "http://www.isotc211.org/2005/gco"), value);
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
                return XName.Get("TypeName_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<TypeName_Type>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("aName", "http://www.isotc211.org/2005/gco"), typeof(CharacterString_PropertyType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TypeName_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TypeName_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (TypeName)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TypeName_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TypeName_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TypeName_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<TypeName_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TypeName_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("TypeName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (TypeName)?
        /// </para>
        /// </summary>
        public TypeName_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (TypeName)?
        /// </para>
        /// </summary>
        public TypeName TypeName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("TypeName", "http://www.isotc211.org/2005/gco"));
                return ((TypeName)(x));
            }
            set
            {
                this.SetElement(XName.Get("TypeName", "http://www.isotc211.org/2005/gco"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("TypeName_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<TypeName_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("TypeName", "http://www.isotc211.org/2005/gco"), typeof(TypeName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TypeName_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TypeName_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// A MemberName is a LocalName that references either an attribute slot in a record or  recordType or an attribute, operation, or association role in an object instance or  type description in some form of schema. The stored value "aName" is the returned value for the "aName()" operation.
    /// </para>
    /// <para>
    /// Regular expression: (aName, attributeType)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MemberName_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MemberName_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator MemberName_Type(XElement xe) { return XTypedServices.ToXTypedElement<MemberName_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static MemberName_Type()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("aName", "http://www.isotc211.org/2005/gco")), new NamedContentModelEntity(XName.Get("attributeType", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// A MemberName is a LocalName that references either an attribute slot in a record or  recordType or an attribute, operation, or association role in an object instance or  type description in some form of schema. The stored value "aName" is the returned value for the "aName()" operation.
        /// </para>
        /// <para>
        /// Regular expression: (aName, attributeType)
        /// </para>
        /// </summary>
        public MemberName_Type()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName, attributeType)
        /// </para>
        /// </summary>
        public CharacterString_PropertyType aName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("aName", "http://www.isotc211.org/2005/gco"));
                return ((CharacterString_PropertyType)(x));
            }
            set
            {
                this.SetElement(XName.Get("aName", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName, attributeType)
        /// </para>
        /// </summary>
        public TypeName_PropertyType attributeType
        {
            get
            {
                XElement x=this.GetElement(XName.Get("attributeType", "http://www.isotc211.org/2005/gco"));
                return ((TypeName_PropertyType)(x));
            }
            set
            {
                this.SetElement(XName.Get("attributeType", "http://www.isotc211.org/2005/gco"), value);
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
                return XName.Get("MemberName_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<MemberName_Type>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("aName", "http://www.isotc211.org/2005/gco"), typeof(CharacterString_PropertyType));
            localElementDictionary.Add(XName.Get("attributeType", "http://www.isotc211.org/2005/gco"), typeof(TypeName_PropertyType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName MemberName_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("MemberName_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (MemberName)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MemberName_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MemberName_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator MemberName_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<MemberName_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static MemberName_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("MemberName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (MemberName)?
        /// </para>
        /// </summary>
        public MemberName_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (MemberName)?
        /// </para>
        /// </summary>
        public MemberName MemberName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("MemberName", "http://www.isotc211.org/2005/gco"));
                return ((MemberName)(x));
            }
            set
            {
                this.SetElement(XName.Get("MemberName", "http://www.isotc211.org/2005/gco"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("MemberName_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<MemberName_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("MemberName", "http://www.isotc211.org/2005/gco"), typeof(MemberName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName MemberName_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("MemberName_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Use to represent the possible cardinality of a relation. Represented by a set of simple multiplicity ranges.
    /// </para>
    /// <para>
    /// Regular expression: (range+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Multiplicity_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Multiplicity_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<MultiplicityRange_PropertyType> rangeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Multiplicity_Type(XElement xe) { return XTypedServices.ToXTypedElement<Multiplicity_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Multiplicity_Type()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("range", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Use to represent the possible cardinality of a relation. Represented by a set of simple multiplicity ranges.
        /// </para>
        /// <para>
        /// Regular expression: (range+)
        /// </para>
        /// </summary>
        public Multiplicity_Type()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (range+)
        /// </para>
        /// </summary>
        public IList<MultiplicityRange_PropertyType> range
        {
            get
            {
                if ((this.rangeField==null))
                {
                    this.rangeField=new XTypedList<MultiplicityRange_PropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("range", "http://www.isotc211.org/2005/gco"));
                }
                return this.rangeField;
            }
            set
            {
                if ((value==null))
                {
                    this.rangeField=null;
                } else
                {
                    if ((this.rangeField==null))
                    {
                        this.rangeField=XTypedList<MultiplicityRange_PropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("range", "http://www.isotc211.org/2005/gco"));
                    } else
                    {
                        XTypedServices.SetList<MultiplicityRange_PropertyType>(this.rangeField, value);
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
                return XName.Get("Multiplicity_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Multiplicity_Type>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("range", "http://www.isotc211.org/2005/gco"), typeof(MultiplicityRange_PropertyType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Multiplicity_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Multiplicity_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Multiplicity)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Multiplicity_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Multiplicity_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Multiplicity_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Multiplicity_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Multiplicity_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Multiplicity)?
        /// </para>
        /// </summary>
        public Multiplicity_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Multiplicity)?
        /// </para>
        /// </summary>
        public Multiplicity Multiplicity
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco"));
                return ((Multiplicity)(x));
            }
            set
            {
                this.SetElement(XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Multiplicity_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Multiplicity_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco"), typeof(Multiplicity));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Multiplicity_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Multiplicity_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// A component of a multiplicity, consisting of an non-negative lower bound, and a potentially infinite upper bound.
    /// </para>
    /// <para>
    /// Regular expression: (lower, upper)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MultiplicityRange_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MultiplicityRange_Type: global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator MultiplicityRange_Type(XElement xe) { return XTypedServices.ToXTypedElement<MultiplicityRange_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static MultiplicityRange_Type()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("lower", "http://www.isotc211.org/2005/gco")), new NamedContentModelEntity(XName.Get("upper", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// A component of a multiplicity, consisting of an non-negative lower bound, and a potentially infinite upper bound.
        /// </para>
        /// <para>
        /// Regular expression: (lower, upper)
        /// </para>
        /// </summary>
        public MultiplicityRange_Type()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (lower, upper)
        /// </para>
        /// </summary>
        public Integer_PropertyType lower
        {
            get
            {
                XElement x=this.GetElement(XName.Get("lower", "http://www.isotc211.org/2005/gco"));
                return ((Integer_PropertyType)(x));
            }
            set
            {
                this.SetElement(XName.Get("lower", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (lower, upper)
        /// </para>
        /// </summary>
        public UnlimitedInteger_PropertyType upper
        {
            get
            {
                XElement x=this.GetElement(XName.Get("upper", "http://www.isotc211.org/2005/gco"));
                return ((UnlimitedInteger_PropertyType)(x));
            }
            set
            {
                this.SetElement(XName.Get("upper", "http://www.isotc211.org/2005/gco"), value);
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
                return XName.Get("MultiplicityRange_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<MultiplicityRange_Type>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("lower", "http://www.isotc211.org/2005/gco"), typeof(Integer_PropertyType));
            localElementDictionary.Add(XName.Get("upper", "http://www.isotc211.org/2005/gco"), typeof(UnlimitedInteger_PropertyType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName MultiplicityRange_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("MultiplicityRange_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (MultiplicityRange)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MultiplicityRange_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MultiplicityRange_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator MultiplicityRange_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<MultiplicityRange_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static MultiplicityRange_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (MultiplicityRange)?
        /// </para>
        /// </summary>
        public MultiplicityRange_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (MultiplicityRange)?
        /// </para>
        /// </summary>
        public MultiplicityRange MultiplicityRange
        {
            get
            {
                XElement x=this.GetElement(XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco"));
                return ((MultiplicityRange)(x));
            }
            set
            {
                this.SetElement(XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("MultiplicityRange_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<MultiplicityRange_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco"), typeof(MultiplicityRange));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName MultiplicityRange_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("MultiplicityRange_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Measure)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Measure_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Measure_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Measure_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Measure_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Measure_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("Measure", "http://www.isotc211.org/2005/gco"), XName.Get("Length", "http://www.isotc211.org/2005/gco"), XName.Get("Angle", "http://www.isotc211.org/2005/gco"), XName.Get("Scale", "http://www.isotc211.org/2005/gco"), XName.Get("Distance", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Measure)?
        /// </para>
        /// </summary>
        public Measure_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: Measure, Length, Angle, Scale, Distance
        /// </para>
        /// <para>
        /// Regular expression: (Measure)?
        /// </para>
        /// </summary>
        public Measure Measure
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("Measure", "http://www.isotc211.org/2005/gco"), XName.Get("Length", "http://www.isotc211.org/2005/gco"), XName.Get("Angle", "http://www.isotc211.org/2005/gco"), XName.Get("Scale", "http://www.isotc211.org/2005/gco"), XName.Get("Distance", "http://www.isotc211.org/2005/gco"));
                return ((Measure)(x));
            }
            set
            {
                this.SetElement(XName.Get("Measure", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Measure_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Measure_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Measure", "http://www.isotc211.org/2005/gco"), typeof(Measure));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Measure_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Measure_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Length)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Length_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Length_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Length_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Length_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Length_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("Length", "http://www.isotc211.org/2005/gco"), XName.Get("Distance", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Length)?
        /// </para>
        /// </summary>
        public Length_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: Length, Distance
        /// </para>
        /// <para>
        /// Regular expression: (Length)?
        /// </para>
        /// </summary>
        public Length Length
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("Length", "http://www.isotc211.org/2005/gco"), XName.Get("Distance", "http://www.isotc211.org/2005/gco"));
                return ((Length)(x));
            }
            set
            {
                this.SetElement(XName.Get("Length", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Length_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Length_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Length", "http://www.isotc211.org/2005/gco"), typeof(Length));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Length_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Length_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Angle)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Angle_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Angle_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Angle_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Angle_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Angle_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Angle", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Angle)?
        /// </para>
        /// </summary>
        public Angle_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Angle)?
        /// </para>
        /// </summary>
        public Angle Angle
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Angle", "http://www.isotc211.org/2005/gco"));
                return ((Angle)(x));
            }
            set
            {
                this.SetElement(XName.Get("Angle", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Angle_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Angle_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Angle", "http://www.isotc211.org/2005/gco"), typeof(Angle));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Angle_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Angle_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Scale)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Scale_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Scale_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Scale_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Scale_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Scale_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Scale", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Scale)?
        /// </para>
        /// </summary>
        public Scale_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Scale)?
        /// </para>
        /// </summary>
        public Scale Scale
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Scale", "http://www.isotc211.org/2005/gco"));
                return ((Scale)(x));
            }
            set
            {
                this.SetElement(XName.Get("Scale", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Scale_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Scale_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Scale", "http://www.isotc211.org/2005/gco"), typeof(Scale));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Scale_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Scale_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Distance)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Distance_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Distance_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Distance_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Distance_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Distance_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Distance", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Distance)?
        /// </para>
        /// </summary>
        public Distance_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Distance)?
        /// </para>
        /// </summary>
        public Distance Distance
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Distance", "http://www.isotc211.org/2005/gco"));
                return ((Distance)(x));
            }
            set
            {
                this.SetElement(XName.Get("Distance", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Distance_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Distance_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Distance", "http://www.isotc211.org/2005/gco"), typeof(Distance));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Distance_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Distance_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (CharacterString)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("CharacterString_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CharacterString_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator CharacterString_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<CharacterString_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static CharacterString_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("CharacterString", "http://www.isotc211.org/2005/gco"), XName.Get("CI_RoleCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_PresentationFormCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_OnLineFunctionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_DateTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_PixelOrientationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_TopologyLevelCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_GeometricObjectTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CellGeometryCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DimensionNameTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ObligationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DatatypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CoverageContentTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ImagingConditionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DQ_EvaluationMethodTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ClassificationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_RestrictionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DistributionUnits", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MediumFormatCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MediumNameCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MaintenanceFrequencyCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ScopeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_TopicCategoryCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CharacterSetCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_SpatialRepresentationTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ProgressCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_KeywordTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DS_AssociationTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DS_InitiativeTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("LocalisedCharacterString", "http://www.isotc211.org/2005/gmd"), XName.Get("LanguageCode", "http://www.isotc211.org/2005/gmd"), XName.Get("Country", "http://www.isotc211.org/2005/gmd")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (CharacterString)?
        /// </para>
        /// </summary>
        public CharacterString_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: CharacterString, CI_RoleCode, CI_PresentationFormCode, CI_OnLineFunctionCode, CI_DateTypeCode, MD_PixelOrientationCode, MD_TopologyLevelCode, MD_GeometricObjectTypeCode, MD_CellGeometryCode, MD_DimensionNameTypeCode, MD_ObligationCode, MD_DatatypeCode, MD_CoverageContentTypeCode, MD_ImagingConditionCode, DQ_EvaluationMethodTypeCode, MD_ClassificationCode, MD_RestrictionCode, MD_DistributionUnits, MD_MediumFormatCode, MD_MediumNameCode, MD_MaintenanceFrequencyCode, MD_ScopeCode, MD_TopicCategoryCode, MD_CharacterSetCode, MD_SpatialRepresentationTypeCode, MD_ProgressCode, MD_KeywordTypeCode, DS_AssociationTypeCode, DS_InitiativeTypeCode, LocalisedCharacterString, LanguageCode, Country
        /// </para>
        /// <para>
        /// Regular expression: (CharacterString)?
        /// </para>
        /// </summary>
        public CharacterString CharacterString
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("CharacterString", "http://www.isotc211.org/2005/gco"), XName.Get("CI_RoleCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_PresentationFormCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_OnLineFunctionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("CI_DateTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_PixelOrientationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_TopologyLevelCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_GeometricObjectTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CellGeometryCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DimensionNameTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ObligationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DatatypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CoverageContentTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ImagingConditionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DQ_EvaluationMethodTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ClassificationCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_RestrictionCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_DistributionUnits", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MediumFormatCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MediumNameCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_MaintenanceFrequencyCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ScopeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_TopicCategoryCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_CharacterSetCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_SpatialRepresentationTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_ProgressCode", "http://www.isotc211.org/2005/gmd"), XName.Get("MD_KeywordTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DS_AssociationTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("DS_InitiativeTypeCode", "http://www.isotc211.org/2005/gmd"), XName.Get("LocalisedCharacterString", "http://www.isotc211.org/2005/gmd"), XName.Get("LanguageCode", "http://www.isotc211.org/2005/gmd"), XName.Get("Country", "http://www.isotc211.org/2005/gmd"));
                return ((CharacterString)(x));
            }
            set
            {
                this.SetElement(XName.Get("CharacterString", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("CharacterString_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<CharacterString_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("CharacterString", "http://www.isotc211.org/2005/gco"), typeof(CharacterString));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName CharacterString_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("CharacterString_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Boolean)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Boolean_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Boolean_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Boolean_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Boolean_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Boolean_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Boolean", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Boolean)?
        /// </para>
        /// </summary>
        public Boolean_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Boolean)?
        /// </para>
        /// </summary>
        public Boolean Boolean
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Boolean", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((Boolean)(x));
            }
            set
            {
                this.SetElement(XName.Get("Boolean", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Boolean_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Boolean_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Boolean", "http://www.isotc211.org/2005/gco"), typeof(Boolean));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Boolean_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Boolean_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (AbstractGenericName)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GenericName_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GenericName_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GenericName_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<GenericName_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GenericName_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco"), XName.Get("LocalName", "http://www.isotc211.org/2005/gco"), XName.Get("ScopedName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (AbstractGenericName)?
        /// </para>
        /// </summary>
        public GenericName_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: AbstractGenericName, LocalName, ScopedName
        /// </para>
        /// <para>
        /// Regular expression: (AbstractGenericName)?
        /// </para>
        /// </summary>
        public AbstractGenericName AbstractGenericName
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco"), XName.Get("LocalName", "http://www.isotc211.org/2005/gco"), XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"));
                return ((AbstractGenericName)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("GenericName_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<GenericName_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco"), typeof(AbstractGenericName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GenericName_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GenericName_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (LocalName)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("LocalName_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class LocalName_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator LocalName_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<LocalName_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static LocalName_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("LocalName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (LocalName)?
        /// </para>
        /// </summary>
        public LocalName_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (LocalName)?
        /// </para>
        /// </summary>
        public LocalName LocalName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("LocalName", "http://www.isotc211.org/2005/gco"));
                return ((LocalName)(x));
            }
            set
            {
                this.SetElement(XName.Get("LocalName", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("LocalName_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<LocalName_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("LocalName", "http://www.isotc211.org/2005/gco"), typeof(LocalName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName LocalName_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("LocalName_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (ScopedName)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ScopedName_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ScopedName_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ScopedName_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<ScopedName_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ScopedName_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (ScopedName)?
        /// </para>
        /// </summary>
        public ScopedName_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (ScopedName)?
        /// </para>
        /// </summary>
        public ScopedName ScopedName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"));
                return ((ScopedName)(x));
            }
            set
            {
                this.SetElement(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("ScopedName_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<ScopedName_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"), typeof(ScopedName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ScopedName_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ScopedName_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomAngle_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomAngle_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomAngle_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomAngle_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomAngle_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomAngle_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomAngle_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomAngle_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomAngle_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomAngle_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomLength_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomLength_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomLength_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomLength_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomLength_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomLength_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomLength_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomLength_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomLength_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomLength_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomScale_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomScale_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomScale_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomScale_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomScale_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomScale_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomScale_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomScale_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomScale_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomScale_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UnitOfMeasure_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UnitOfMeasure_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UnitOfMeasure_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UnitOfMeasure_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UnitOfMeasure_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UnitOfMeasure_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UnitOfMeasure_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UnitOfMeasure_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UnitOfMeasure_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UnitOfMeasure_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomArea_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomArea_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomArea_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomArea_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomArea_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomArea_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomArea_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomArea_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomArea_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomArea_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomVelocity_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomVelocity_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomVelocity_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomVelocity_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomVelocity_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomVelocity_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomVelocity_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomVelocity_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomVelocity_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomVelocity_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomTime_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomTime_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomTime_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomTime_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomTime_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomTime_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomTime_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomTime_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomTime_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomTime_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnitDefinition)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UomVolume_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UomVolume_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UomVolume_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UomVolume_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UomVolume_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public UomVolume_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: UnitDefinition, BaseUnit, DerivedUnit, ConventionalUnit
        /// </para>
        /// <para>
        /// Regular expression: (UnitDefinition)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.UnitDefinition)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UomVolume_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UomVolume_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.UnitDefinition));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UomVolume_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UomVolume_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (DateTime)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DateTime_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DateTime_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DateTime_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<DateTime_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DateTime_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DateTime", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (DateTime)?
        /// </para>
        /// </summary>
        public DateTime_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (DateTime)?
        /// </para>
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                XElement x=this.GetElement(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((DateTime)(x));
            }
            set
            {
                this.SetElement(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("DateTime_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<DateTime_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"), typeof(DateTime));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DateTime_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DateTime_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class Date_Type
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.UnionSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyAtomicType), null, new Xml.Schema.Linq.SimpleTypeValidator[] {
                    new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Date), null),
                    new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.GYearMonth), null),
                    new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.GYear), null)});

        private Date_Type()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Date | DateTime)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Date_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Date_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Date_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Date_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Date_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new NamedContentModelEntity(XName.Get("Date", "http://www.isotc211.org/2005/gco")), new NamedContentModelEntity(XName.Get("DateTime", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Date | DateTime)?
        /// </para>
        /// </summary>
        public Date_PropertyType()
        {
        }

        public Date_PropertyType(Date Date)
        {
            this.Date=Date;
        }

        public Date_PropertyType(DateTime DateTime)
        {
            this.DateTime=DateTime;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Date | DateTime)?
        /// </para>
        /// </summary>
        public Date Date
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Date", "http://www.isotc211.org/2005/gco"));
                return ((Date)(x));
            }
            set
            {
                this.SetElement(XName.Get("Date", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Date | DateTime)?
        /// </para>
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                XElement x=this.GetElement(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((DateTime)(x));
            }
            set
            {
                this.SetElement(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Date_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Date_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Date", "http://www.isotc211.org/2005/gco"), typeof(Date));
            localElementDictionary.Add(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"), typeof(DateTime));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Date_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Date_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Real | @Decimal | Integer)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Number_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Number_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Number_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Number_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Number_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new NamedContentModelEntity(XName.Get("Real", "http://www.isotc211.org/2005/gco")), new NamedContentModelEntity(XName.Get("Decimal", "http://www.isotc211.org/2005/gco")), new NamedContentModelEntity(XName.Get("Integer", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Real | @Decimal | Integer)?
        /// </para>
        /// </summary>
        public Number_PropertyType()
        {
        }

        public Number_PropertyType(Real Real)
        {
            this.Real=Real;
        }

        public Number_PropertyType(@Decimal @Decimal)
        {
            this.@Decimal=@Decimal;
        }

        public Number_PropertyType(Integer Integer)
        {
            this.Integer=Integer;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Real | @Decimal | Integer)?
        /// </para>
        /// </summary>
        public Real Real
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Real", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((Real)(x));
            }
            set
            {
                this.SetElement(XName.Get("Real", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Real | @Decimal | Integer)?
        /// </para>
        /// </summary>
        public @Decimal @Decimal
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((@Decimal)(x));
            }
            set
            {
                this.SetElement(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Real | @Decimal | Integer)?
        /// </para>
        /// </summary>
        public Integer Integer
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Integer", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((Integer)(x));
            }
            set
            {
                this.SetElement(XName.Get("Integer", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Number_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Number_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Real", "http://www.isotc211.org/2005/gco"), typeof(Real));
            localElementDictionary.Add(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"), typeof(@Decimal));
            localElementDictionary.Add(XName.Get("Integer", "http://www.isotc211.org/2005/gco"), typeof(Integer));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Number_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Number_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (@Decimal)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Decimal_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Decimal_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Decimal_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Decimal_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Decimal_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Decimal", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (@Decimal)?
        /// </para>
        /// </summary>
        public Decimal_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (@Decimal)?
        /// </para>
        /// </summary>
        public @Decimal @Decimal
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((@Decimal)(x));
            }
            set
            {
                this.SetElement(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Decimal_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Decimal_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"), typeof(@Decimal));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Decimal_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Decimal_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Real)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Real_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Real_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Real_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Real_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Real_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Real", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Real)?
        /// </para>
        /// </summary>
        public Real_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Real)?
        /// </para>
        /// </summary>
        public Real Real
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Real", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((Real)(x));
            }
            set
            {
                this.SetElement(XName.Get("Real", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Real_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Real_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Real", "http://www.isotc211.org/2005/gco"), typeof(Real));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Real_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Real_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Integer)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Integer_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Integer_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Integer_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Integer_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Integer_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Integer", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Integer)?
        /// </para>
        /// </summary>
        public Integer_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Integer)?
        /// </para>
        /// </summary>
        public Integer Integer
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Integer", "http://www.isotc211.org/2005/gco"));
                if ((x==null))
                {
                    return null;
                }
                return ((Integer)(x));
            }
            set
            {
                this.SetElement(XName.Get("Integer", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Integer_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Integer_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Integer", "http://www.isotc211.org/2005/gco"), typeof(Integer));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Integer_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Integer_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("UnlimitedInteger_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UnlimitedInteger_Type: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator UnlimitedInteger_Type(XElement xe) { return XTypedServices.ToXTypedElement<UnlimitedInteger_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public UnlimitedInteger_Type()
        {
        }

        public decimal TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<bool> isInfinite
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("isInfinite", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("isInfinite", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("UnlimitedInteger_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UnlimitedInteger_Type>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName UnlimitedInteger_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UnlimitedInteger_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (UnlimitedInteger)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UnlimitedInteger_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UnlimitedInteger_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UnlimitedInteger_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<UnlimitedInteger_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UnlimitedInteger_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (UnlimitedInteger)?
        /// </para>
        /// </summary>
        public UnlimitedInteger_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (UnlimitedInteger)?
        /// </para>
        /// </summary>
        public UnlimitedInteger UnlimitedInteger
        {
            get
            {
                XElement x=this.GetElement(XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco"));
                return ((UnlimitedInteger)(x));
            }
            set
            {
                this.SetElement(XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("UnlimitedInteger_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<UnlimitedInteger_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco"), typeof(UnlimitedInteger));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UnlimitedInteger_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UnlimitedInteger_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Record)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Record_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Record_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Record_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Record_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Record_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Record", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Record)?
        /// </para>
        /// </summary>
        public Record_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Record)?
        /// </para>
        /// </summary>
        public Record Record
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Record", "http://www.isotc211.org/2005/gco"));
                return ((Record)(x));
            }
            set
            {
                this.SetElement(XName.Get("Record", "http://www.isotc211.org/2005/gco"), value);
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuidref
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uuidref", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uuidref", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Record_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Record_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Record", "http://www.isotc211.org/2005/gco"), typeof(Record));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Record_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Record_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("RecordType_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RecordType_Type: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        public static explicit operator RecordType_Type(XElement xe) { return XTypedServices.ToXTypedElement<RecordType_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public RecordType_Type()
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
                return XName.Get("RecordType_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<RecordType_Type>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName RecordType_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RecordType_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (RecordType)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RecordType_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RecordType_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator RecordType_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<RecordType_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static RecordType_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("RecordType", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (RecordType)?
        /// </para>
        /// </summary>
        public RecordType_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (RecordType)?
        /// </para>
        /// </summary>
        public RecordType RecordType
        {
            get
            {
                XElement x=this.GetElement(XName.Get("RecordType", "http://www.isotc211.org/2005/gco"));
                return ((RecordType)(x));
            }
            set
            {
                this.SetElement(XName.Get("RecordType", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("RecordType_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<RecordType_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("RecordType", "http://www.isotc211.org/2005/gco"), typeof(RecordType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName RecordType_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RecordType_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("Binary_TypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Binary_Type: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Binary_Type(XElement xe) { return XTypedServices.ToXTypedElement<Binary_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Binary_Type()
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
        public System.Uri src
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("src", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("src", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Binary_Type", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Binary_Type>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName Binary_TypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Binary_Type", "http://www.isotc211.org/2005/gco");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Binary)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Binary_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Binary_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Binary_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<Binary_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Binary_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Binary", "http://www.isotc211.org/2005/gco")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Binary)?
        /// </para>
        /// </summary>
        public Binary_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Binary)?
        /// </para>
        /// </summary>
        public Binary Binary
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Binary", "http://www.isotc211.org/2005/gco"));
                return ((Binary)(x));
            }
            set
            {
                this.SetElement(XName.Get("Binary", "http://www.isotc211.org/2005/gco"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public object nilReason
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nilReason", "http://www.isotc211.org/2005/gco"));
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::GeoSik.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("Binary_PropertyType", "http://www.isotc211.org/2005/gco");
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
            return XTypedServices.CloneXTypedElement<Binary_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Binary", "http://www.isotc211.org/2005/gco"), typeof(Binary));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Binary_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Binary_PropertyType", "http://www.isotc211.org/2005/gco");
        }
    }

    [XmlSchemaProviderAttribute("AbstractObjectSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractObject: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AbstractObject_Type ContentField;

        public static explicit operator AbstractObject(XElement xe) { return (AbstractObject)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractObject()
        {
            throw new InvalidOperationException();
        }

        public AbstractObject(AbstractObject_Type content)
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

        public AbstractObject_Type Content
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
        /// </summary>
        public string id
        {
            get
            {
                return this.ContentField.id;
            }
            set
            {
                this.ContentField.id=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string uuid
        {
            get
            {
                return this.ContentField.uuid;
            }
            set
            {
                this.ContentField.uuid=value;
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
                return XName.Get("AbstractObject", "http://www.isotc211.org/2005/gco");
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

        public static AbstractObject Load(string xmlFile)
        {
            return ((AbstractObject)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractObject Load(System.IO.TextReader xmlFile)
        {
            return ((AbstractObject)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractObject Parse(string xml)
        {
            return ((AbstractObject)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(AbstractObject_Type ContentField)
        {
            this.ContentField=((AbstractObject_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AbstractObjectSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractObject", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// A TypeName is a LocalName that references either a recordType or object type in some form of schema. The stored value "aName" is the returned value for the "aName()" operation. This is the types name.  - For parsing from types (or objects) the parsible name normally uses a "." navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TypeNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TypeName: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TypeName_Type ContentField;

        public static explicit operator TypeName(XElement xe) { return XTypedServices.ToXTypedElement<TypeName, TypeName_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// A TypeName is a LocalName that references either a recordType or object type in some form of schema. The stored value "aName" is the returned value for the "aName()" operation. This is the types name.  - For parsing from types (or objects) the parsible name normally uses a "." navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
        /// </para>
        /// </summary>
        public TypeName()
        {
            SetInnerType(new TypeName_Type());
        }

        /// <summary>
        /// <para>
        /// A TypeName is a LocalName that references either a recordType or object type in some form of schema. The stored value "aName" is the returned value for the "aName()" operation. This is the types name.  - For parsing from types (or objects) the parsible name normally uses a "." navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
        /// </para>
        /// </summary>
        public TypeName(TypeName_Type content)
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

        public TypeName_Type Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName)
        /// </para>
        /// </summary>
        public CharacterString_PropertyType aName
        {
            get
            {
                return this.ContentField.aName;
            }
            set
            {
                this.ContentField.aName=value;
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
                return XName.Get("TypeName", "http://www.isotc211.org/2005/gco");
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

        public static TypeName Load(string xmlFile)
        {
            return XTypedServices.Load<TypeName, TypeName_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static TypeName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<TypeName, TypeName_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static TypeName Parse(string xml)
        {
            return XTypedServices.Parse<TypeName, TypeName_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new TypeName(((TypeName_Type)(this.Content.Clone())));
        }

        private void SetInnerType(TypeName_Type ContentField)
        {
            this.ContentField=((TypeName_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TypeNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("TypeName", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// A MemberName is a LocalName that references either an attribute slot in a record or  recordType or an attribute, operation, or association role in an object instance or  type description in some form of schema. The stored value "aName" is the returned value for the "aName()" operation.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MemberNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MemberName: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MemberName_Type ContentField;

        public static explicit operator MemberName(XElement xe) { return XTypedServices.ToXTypedElement<MemberName, MemberName_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// A MemberName is a LocalName that references either an attribute slot in a record or  recordType or an attribute, operation, or association role in an object instance or  type description in some form of schema. The stored value "aName" is the returned value for the "aName()" operation.
        /// </para>
        /// </summary>
        public MemberName()
        {
            SetInnerType(new MemberName_Type());
        }

        /// <summary>
        /// <para>
        /// A MemberName is a LocalName that references either an attribute slot in a record or  recordType or an attribute, operation, or association role in an object instance or  type description in some form of schema. The stored value "aName" is the returned value for the "aName()" operation.
        /// </para>
        /// </summary>
        public MemberName(MemberName_Type content)
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

        public MemberName_Type Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName, attributeType)
        /// </para>
        /// </summary>
        public CharacterString_PropertyType aName
        {
            get
            {
                return this.ContentField.aName;
            }
            set
            {
                this.ContentField.aName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (aName, attributeType)
        /// </para>
        /// </summary>
        public TypeName_PropertyType attributeType
        {
            get
            {
                return this.ContentField.attributeType;
            }
            set
            {
                this.ContentField.attributeType=value;
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
                return XName.Get("MemberName", "http://www.isotc211.org/2005/gco");
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

        public static MemberName Load(string xmlFile)
        {
            return XTypedServices.Load<MemberName, MemberName_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static MemberName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<MemberName, MemberName_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static MemberName Parse(string xml)
        {
            return XTypedServices.Parse<MemberName, MemberName_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new MemberName(((MemberName_Type)(this.Content.Clone())));
        }

        private void SetInnerType(MemberName_Type ContentField)
        {
            this.ContentField=((MemberName_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MemberNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("MemberName", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Use to represent the possible cardinality of a relation. Represented by a set of simple multiplicity ranges.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MultiplicitySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Multiplicity: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Multiplicity_Type ContentField;

        public static explicit operator Multiplicity(XElement xe) { return XTypedServices.ToXTypedElement<Multiplicity, Multiplicity_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Use to represent the possible cardinality of a relation. Represented by a set of simple multiplicity ranges.
        /// </para>
        /// </summary>
        public Multiplicity()
        {
            SetInnerType(new Multiplicity_Type());
        }

        /// <summary>
        /// <para>
        /// Use to represent the possible cardinality of a relation. Represented by a set of simple multiplicity ranges.
        /// </para>
        /// </summary>
        public Multiplicity(Multiplicity_Type content)
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

        public Multiplicity_Type Content
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
        /// Regular expression: (range+)
        /// </para>
        /// </summary>
        public IList<MultiplicityRange_PropertyType> range
        {
            get
            {
                return this.ContentField.range;
            }
            set
            {
                this.ContentField.range=value;
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
                return XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco");
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

        public static Multiplicity Load(string xmlFile)
        {
            return XTypedServices.Load<Multiplicity, Multiplicity_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Multiplicity Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Multiplicity, Multiplicity_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Multiplicity Parse(string xml)
        {
            return XTypedServices.Parse<Multiplicity, Multiplicity_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Multiplicity(((Multiplicity_Type)(this.Content.Clone())));
        }

        private void SetInnerType(Multiplicity_Type ContentField)
        {
            this.ContentField=((Multiplicity_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MultiplicitySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Multiplicity", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// A component of a multiplicity, consisting of an non-negative lower bound, and a potentially infinite upper bound.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MultiplicityRangeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class MultiplicityRange: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MultiplicityRange_Type ContentField;

        public static explicit operator MultiplicityRange(XElement xe) { return XTypedServices.ToXTypedElement<MultiplicityRange, MultiplicityRange_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// A component of a multiplicity, consisting of an non-negative lower bound, and a potentially infinite upper bound.
        /// </para>
        /// </summary>
        public MultiplicityRange()
        {
            SetInnerType(new MultiplicityRange_Type());
        }

        /// <summary>
        /// <para>
        /// A component of a multiplicity, consisting of an non-negative lower bound, and a potentially infinite upper bound.
        /// </para>
        /// </summary>
        public MultiplicityRange(MultiplicityRange_Type content)
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

        public MultiplicityRange_Type Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (lower, upper)
        /// </para>
        /// </summary>
        public Integer_PropertyType lower
        {
            get
            {
                return this.ContentField.lower;
            }
            set
            {
                this.ContentField.lower=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (lower, upper)
        /// </para>
        /// </summary>
        public UnlimitedInteger_PropertyType upper
        {
            get
            {
                return this.ContentField.upper;
            }
            set
            {
                this.ContentField.upper=value;
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
                return XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco");
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

        public static MultiplicityRange Load(string xmlFile)
        {
            return XTypedServices.Load<MultiplicityRange, MultiplicityRange_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static MultiplicityRange Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<MultiplicityRange, MultiplicityRange_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static MultiplicityRange Parse(string xml)
        {
            return XTypedServices.Parse<MultiplicityRange, MultiplicityRange_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new MultiplicityRange(((MultiplicityRange_Type)(this.Content.Clone())));
        }

        private void SetInnerType(MultiplicityRange_Type ContentField)
        {
            this.ContentField=((MultiplicityRange_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MultiplicityRangeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("MultiplicityRange", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for "units Of measure". The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("MeasureSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Measure: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.MeasureType ContentField;

        public static explicit operator Measure(XElement xe) { return (Measure)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected Measure(bool setNull)
        {
        }

        /// <summary>
        /// <para>
        /// gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for "units Of measure". The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.
        /// </para>
        /// </summary>
        public Measure()
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.MeasureType());
        }

        /// <summary>
        /// <para>
        /// gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for "units Of measure". The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.
        /// </para>
        /// </summary>
        public Measure(GeoSik.Ogc.Gml.V321.MeasureType content)
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

        public GeoSik.Ogc.Gml.V321.MeasureType Content
        {
            get
            {
                return ContentField;
            }
        }

        public double TypedValue
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
        /// Occurrence: required
        /// </para>
        /// </summary>
        public object uom
        {
            get
            {
                return this.ContentField.uom;
            }
            set
            {
                this.ContentField.uom=value;
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
                return XName.Get("Measure", "http://www.isotc211.org/2005/gco");
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

        public static Measure Load(string xmlFile)
        {
            return ((Measure)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static Measure Load(System.IO.TextReader xmlFile)
        {
            return ((Measure)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static Measure Parse(string xml)
        {
            return ((Measure)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new Measure(((GeoSik.Ogc.Gml.V321.MeasureType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.MeasureType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.MeasureType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(GeoSik.Ogc.Gml.V321.MeasureType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MeasureSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Measure", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("LengthSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Length: global::GeoSik.Iso.Ts19139.Gco.Measure, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.LengthType ContentField;

        public static explicit operator Length(XElement xe) { return (Length)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected Length(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
        /// </para>
        /// </summary>
        public Length() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.LengthType());
        }

        /// <summary>
        /// <para>
        /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
        /// </para>
        /// </summary>
        public Length(GeoSik.Ogc.Gml.V321.LengthType content) :
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
                if ((this.ContentField!=null))
                {
                    this.ContentField.Untyped=value;
                }
            }
        }

        public new GeoSik.Ogc.Gml.V321.LengthType Content
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
                return XName.Get("Length", "http://www.isotc211.org/2005/gco");
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

        public new static Length Load(string xmlFile)
        {
            return ((Length)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static Length Load(System.IO.TextReader xmlFile)
        {
            return ((Length)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static Length Parse(string xml)
        {
            return ((Length)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new Length(((GeoSik.Ogc.Gml.V321.LengthType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.LengthType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.LengthType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(GeoSik.Ogc.Gml.V321.LengthType ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType LengthSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Length", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AngleSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Angle: global::GeoSik.Iso.Ts19139.Gco.Measure, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.AngleType ContentField;

        public static explicit operator Angle(XElement xe) { return XTypedServices.ToXTypedElement<Angle, GeoSik.Ogc.Gml.V321.AngleType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Angle() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.AngleType());
        }

        public Angle(GeoSik.Ogc.Gml.V321.AngleType content) :
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

        public new GeoSik.Ogc.Gml.V321.AngleType Content
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
                return XName.Get("Angle", "http://www.isotc211.org/2005/gco");
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

        public new static Angle Load(string xmlFile)
        {
            return XTypedServices.Load<Angle, GeoSik.Ogc.Gml.V321.AngleType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Angle Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Angle, GeoSik.Ogc.Gml.V321.AngleType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Angle Parse(string xml)
        {
            return XTypedServices.Parse<Angle, GeoSik.Ogc.Gml.V321.AngleType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Angle(((GeoSik.Ogc.Gml.V321.AngleType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.AngleType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.AngleType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AngleSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Angle", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("ScaleSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Scale: global::GeoSik.Iso.Ts19139.Gco.Measure, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.ScaleType ContentField;

        public static explicit operator Scale(XElement xe) { return XTypedServices.ToXTypedElement<Scale, GeoSik.Ogc.Gml.V321.ScaleType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Scale() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.ScaleType());
        }

        public Scale(GeoSik.Ogc.Gml.V321.ScaleType content) :
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

        public new GeoSik.Ogc.Gml.V321.ScaleType Content
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
                return XName.Get("Scale", "http://www.isotc211.org/2005/gco");
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

        public new static Scale Load(string xmlFile)
        {
            return XTypedServices.Load<Scale, GeoSik.Ogc.Gml.V321.ScaleType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Scale Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Scale, GeoSik.Ogc.Gml.V321.ScaleType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Scale Parse(string xml)
        {
            return XTypedServices.Parse<Scale, GeoSik.Ogc.Gml.V321.ScaleType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Scale(((GeoSik.Ogc.Gml.V321.ScaleType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.ScaleType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.ScaleType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ScaleSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Scale", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DistanceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Distance: global::GeoSik.Iso.Ts19139.Gco.Length, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.LengthType ContentField;

        public static explicit operator Distance(XElement xe) { return XTypedServices.ToXTypedElement<Distance, GeoSik.Ogc.Gml.V321.LengthType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
        /// </para>
        /// </summary>
        public Distance() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.LengthType());
        }

        /// <summary>
        /// <para>
        /// This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
        /// </para>
        /// </summary>
        public Distance(GeoSik.Ogc.Gml.V321.LengthType content) :
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

        public new GeoSik.Ogc.Gml.V321.LengthType Content
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
                return XName.Get("Distance", "http://www.isotc211.org/2005/gco");
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

        public new static Distance Load(string xmlFile)
        {
            return XTypedServices.Load<Distance, GeoSik.Ogc.Gml.V321.LengthType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Distance Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Distance, GeoSik.Ogc.Gml.V321.LengthType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Distance Parse(string xml)
        {
            return XTypedServices.Parse<Distance, GeoSik.Ogc.Gml.V321.LengthType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Distance(((GeoSik.Ogc.Gml.V321.LengthType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.LengthType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.LengthType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DistanceSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Distance", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("CharacterStringSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CharacterString: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator CharacterString(XElement xe) { return (CharacterString)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public CharacterString()
        {
        }

        public CharacterString(string content)
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
                return XName.Get("CharacterString", "http://www.isotc211.org/2005/gco");
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

        public static CharacterString Load(string xmlFile)
        {
            return ((CharacterString)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static CharacterString Load(System.IO.TextReader xmlFile)
        {
            return ((CharacterString)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static CharacterString Parse(string xml)
        {
            return ((CharacterString)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<CharacterString>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType CharacterStringSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("CharacterString", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("BooleanSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Boolean: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Boolean(XElement xe) { return XTypedServices.ToXTypedElement<Boolean>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Boolean()
        {
        }

        public Boolean(bool content)
        {
            this.TypedValue=content;
        }

        public bool TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Boolean", "http://www.isotc211.org/2005/gco");
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

        public static Boolean Load(string xmlFile)
        {
            return XTypedServices.Load<Boolean>(xmlFile);
        }

        public static Boolean Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Boolean>(xmlFile);
        }

        public static Boolean Parse(string xml)
        {
            return XTypedServices.Parse<Boolean>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Boolean>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BooleanSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Boolean", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// gml:CodeType is a generalized type to be used for a term, keyword or name.
    ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AbstractGenericNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractGenericName: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.CodeType ContentField;

        public static explicit operator AbstractGenericName(XElement xe) { return (AbstractGenericName)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected AbstractGenericName(bool setNull)
        {
        }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public AbstractGenericName()
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.CodeType());
        }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public AbstractGenericName(GeoSik.Ogc.Gml.V321.CodeType content)
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

        public GeoSik.Ogc.Gml.V321.CodeType Content
        {
            get
            {
                return ContentField;
            }
        }

        public virtual string TypedValue
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
                return XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco");
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

        public static AbstractGenericName Load(string xmlFile)
        {
            return ((AbstractGenericName)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractGenericName Load(System.IO.TextReader xmlFile)
        {
            return ((AbstractGenericName)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractGenericName Parse(string xml)
        {
            return ((AbstractGenericName)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.CodeType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.CodeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(GeoSik.Ogc.Gml.V321.CodeType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AbstractGenericNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractGenericName", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// gml:CodeType is a generalized type to be used for a term, keyword or name.
    ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("LocalNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class LocalName: global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.CodeType ContentField;

        public static explicit operator LocalName(XElement xe) { return XTypedServices.ToXTypedElement<LocalName, GeoSik.Ogc.Gml.V321.CodeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public LocalName() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.CodeType());
        }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public LocalName(GeoSik.Ogc.Gml.V321.CodeType content) :
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

        public new GeoSik.Ogc.Gml.V321.CodeType Content
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
                return XName.Get("LocalName", "http://www.isotc211.org/2005/gco");
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

        public new static LocalName Load(string xmlFile)
        {
            return XTypedServices.Load<LocalName, GeoSik.Ogc.Gml.V321.CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static LocalName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<LocalName, GeoSik.Ogc.Gml.V321.CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static LocalName Parse(string xml)
        {
            return XTypedServices.Parse<LocalName, GeoSik.Ogc.Gml.V321.CodeType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new LocalName(((GeoSik.Ogc.Gml.V321.CodeType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.CodeType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.CodeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType LocalNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("LocalName", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// gml:CodeType is a generalized type to be used for a term, keyword or name.
    ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ScopedNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ScopedName: global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.Ogc.Gml.V321.CodeType ContentField;

        public static explicit operator ScopedName(XElement xe) { return XTypedServices.ToXTypedElement<ScopedName, GeoSik.Ogc.Gml.V321.CodeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public ScopedName() :
            base(true)
        {
            SetInnerType(new GeoSik.Ogc.Gml.V321.CodeType());
        }

        /// <summary>
        /// <para>
        /// gml:CodeType is a generalized type to be used for a term, keyword or name.
        ///It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
        /// </para>
        /// </summary>
        public ScopedName(GeoSik.Ogc.Gml.V321.CodeType content) :
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

        public new GeoSik.Ogc.Gml.V321.CodeType Content
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
                return XName.Get("ScopedName", "http://www.isotc211.org/2005/gco");
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

        public new static ScopedName Load(string xmlFile)
        {
            return XTypedServices.Load<ScopedName, GeoSik.Ogc.Gml.V321.CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static ScopedName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ScopedName, GeoSik.Ogc.Gml.V321.CodeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static ScopedName Parse(string xml)
        {
            return XTypedServices.Parse<ScopedName, GeoSik.Ogc.Gml.V321.CodeType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new ScopedName(((GeoSik.Ogc.Gml.V321.CodeType)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.Ogc.Gml.V321.CodeType ContentField)
        {
            this.ContentField=((GeoSik.Ogc.Gml.V321.CodeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ScopedNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ScopedName", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("DateTimeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DateTime: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator DateTime(XElement xe) { return XTypedServices.ToXTypedElement<DateTime>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public DateTime()
        {
        }

        public DateTime(System.DateTime content)
        {
            this.TypedValue=content;
        }

        public System.DateTime TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<System.DateTime>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DateTime", "http://www.isotc211.org/2005/gco");
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

        public static DateTime Load(string xmlFile)
        {
            return XTypedServices.Load<DateTime>(xmlFile);
        }

        public static DateTime Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DateTime>(xmlFile);
        }

        public static DateTime Parse(string xml)
        {
            return XTypedServices.Parse<DateTime>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<DateTime>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DateTimeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DateTime", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("DateSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Date: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Date(XElement xe) { return XTypedServices.ToXTypedElement<Date>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Date()
        {
        }

        public Date(object content)
        {
            this.TypedValue=content;
        }

        public object TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseUnionValue(x, global::GeoSik.Iso.Ts19139.Gco.Date_Type.TypeDefinition);
            }
            set
            {
                this.SetUnionValue(value, "TypedValue", this, global::GeoSik.Iso.Ts19139.Gco.Date_Type.TypeDefinition);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Date", "http://www.isotc211.org/2005/gco");
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

        public static Date Load(string xmlFile)
        {
            return XTypedServices.Load<Date>(xmlFile);
        }

        public static Date Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Date>(xmlFile);
        }

        public static Date Parse(string xml)
        {
            return XTypedServices.Parse<Date>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Date>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DateSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Date", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("@DecimalSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class @Decimal: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator @Decimal(XElement xe) { return XTypedServices.ToXTypedElement<@Decimal>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public @Decimal()
        {
        }

        public @Decimal(decimal content)
        {
            this.TypedValue=content;
        }

        public decimal TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Decimal", "http://www.isotc211.org/2005/gco");
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

        public static @Decimal Load(string xmlFile)
        {
            return XTypedServices.Load<@Decimal>(xmlFile);
        }

        public static @Decimal Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<@Decimal>(xmlFile);
        }

        public static @Decimal Parse(string xml)
        {
            return XTypedServices.Parse<@Decimal>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<@Decimal>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType @DecimalSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Decimal", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("RealSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Real: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Real(XElement xe) { return XTypedServices.ToXTypedElement<Real>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Real()
        {
        }

        public Real(double content)
        {
            this.TypedValue=content;
        }

        public double TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<double>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Real", "http://www.isotc211.org/2005/gco");
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

        public static Real Load(string xmlFile)
        {
            return XTypedServices.Load<Real>(xmlFile);
        }

        public static Real Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Real>(xmlFile);
        }

        public static Real Parse(string xml)
        {
            return XTypedServices.Parse<Real>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Real>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RealSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Real", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("IntegerSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Integer: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator Integer(XElement xe) { return XTypedServices.ToXTypedElement<Integer>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Integer()
        {
        }

        public Integer(decimal content)
        {
            this.TypedValue=content;
        }

        public decimal TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Integer).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Integer).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("Integer", "http://www.isotc211.org/2005/gco");
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

        public static Integer Load(string xmlFile)
        {
            return XTypedServices.Load<Integer>(xmlFile);
        }

        public static Integer Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Integer>(xmlFile);
        }

        public static Integer Parse(string xml)
        {
            return XTypedServices.Parse<Integer>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Integer>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType IntegerSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Integer", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("UnlimitedIntegerSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UnlimitedInteger: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private UnlimitedInteger_Type ContentField;

        public static explicit operator UnlimitedInteger(XElement xe) { return XTypedServices.ToXTypedElement<UnlimitedInteger, UnlimitedInteger_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public UnlimitedInteger()
        {
            SetInnerType(new UnlimitedInteger_Type());
        }

        public UnlimitedInteger(UnlimitedInteger_Type content)
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

        public UnlimitedInteger_Type Content
        {
            get
            {
                return ContentField;
            }
        }

        public decimal TypedValue
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
        public System.Nullable<bool> isInfinite
        {
            get
            {
                return this.ContentField.isInfinite;
            }
            set
            {
                this.ContentField.isInfinite=value;
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
                return XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco");
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

        public static UnlimitedInteger Load(string xmlFile)
        {
            return XTypedServices.Load<UnlimitedInteger, UnlimitedInteger_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static UnlimitedInteger Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<UnlimitedInteger, UnlimitedInteger_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static UnlimitedInteger Parse(string xml)
        {
            return XTypedServices.Parse<UnlimitedInteger, UnlimitedInteger_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new UnlimitedInteger(((UnlimitedInteger_Type)(this.Content.Clone())));
        }

        private void SetInnerType(UnlimitedInteger_Type ContentField)
        {
            this.ContentField=((UnlimitedInteger_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType UnlimitedIntegerSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("UnlimitedInteger", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("RecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RecordType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RecordType_Type ContentField;

        public static explicit operator RecordType(XElement xe) { return XTypedServices.ToXTypedElement<RecordType, RecordType_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public RecordType()
        {
            SetInnerType(new RecordType_Type());
        }

        public RecordType(RecordType_Type content)
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

        public RecordType_Type Content
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
                return XName.Get("RecordType", "http://www.isotc211.org/2005/gco");
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

        public static RecordType Load(string xmlFile)
        {
            return XTypedServices.Load<RecordType, RecordType_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static RecordType Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<RecordType, RecordType_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static RecordType Parse(string xml)
        {
            return XTypedServices.Parse<RecordType, RecordType_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new RecordType(((RecordType_Type)(this.Content.Clone())));
        }

        private void SetInnerType(RecordType_Type ContentField)
        {
            this.ContentField=((RecordType_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("RecordType", "http://www.isotc211.org/2005/gco")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("BinarySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Binary: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Binary_Type ContentField;

        public static explicit operator Binary(XElement xe) { return XTypedServices.ToXTypedElement<Binary, Binary_Type>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Binary()
        {
            SetInnerType(new Binary_Type());
        }

        public Binary(Binary_Type content)
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

        public Binary_Type Content
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
        public System.Uri src
        {
            get
            {
                return this.ContentField.src;
            }
            set
            {
                this.ContentField.src=value;
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
                return XName.Get("Binary", "http://www.isotc211.org/2005/gco");
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

        public static Binary Load(string xmlFile)
        {
            return XTypedServices.Load<Binary, Binary_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Binary Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Binary, Binary_Type>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Binary Parse(string xml)
        {
            return XTypedServices.Parse<Binary, Binary_Type>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Binary(((Binary_Type)(this.Content.Clone())));
        }

        private void SetInnerType(Binary_Type ContentField)
        {
            this.ContentField=((Binary_Type)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BinarySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Binary", "http://www.isotc211.org/2005/gco")]));
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
            typeDictionary.Add(XName.Get("EX_TemporalExtent_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent_Type));
            typeDictionary.Add(XName.Get("EX_TemporalExtent_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent_PropertyType));
            typeDictionary.Add(XName.Get("EX_VerticalExtent_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent_Type));
            typeDictionary.Add(XName.Get("EX_VerticalExtent_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent_PropertyType));
            typeDictionary.Add(XName.Get("EX_BoundingPolygon_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon_Type));
            typeDictionary.Add(XName.Get("EX_BoundingPolygon_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon_PropertyType));
            typeDictionary.Add(XName.Get("EX_Extent_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_Extent_Type));
            typeDictionary.Add(XName.Get("EX_Extent_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_Extent_PropertyType));
            typeDictionary.Add(XName.Get("AbstractEX_GeographicExtent_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent_Type));
            typeDictionary.Add(XName.Get("EX_GeographicExtent_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicExtent_PropertyType));
            typeDictionary.Add(XName.Get("EX_GeographicBoundingBox_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox_Type));
            typeDictionary.Add(XName.Get("EX_GeographicBoundingBox_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox_PropertyType));
            typeDictionary.Add(XName.Get("EX_SpatialTemporalExtent_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent_Type));
            typeDictionary.Add(XName.Get("EX_SpatialTemporalExtent_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent_PropertyType));
            typeDictionary.Add(XName.Get("EX_GeographicDescription_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription_Type));
            typeDictionary.Add(XName.Get("EX_GeographicDescription_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription_PropertyType));
            typeDictionary.Add(XName.Get("RS_Identifier_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier_Type));
            typeDictionary.Add(XName.Get("RS_Identifier_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier_PropertyType));
            typeDictionary.Add(XName.Get("MD_ReferenceSystem_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem_Type));
            typeDictionary.Add(XName.Get("MD_ReferenceSystem_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem_PropertyType));
            typeDictionary.Add(XName.Get("MD_Identifier_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier_Type));
            typeDictionary.Add(XName.Get("MD_Identifier_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier_PropertyType));
            typeDictionary.Add(XName.Get("AbstractRS_ReferenceSystem_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem_Type));
            typeDictionary.Add(XName.Get("RS_ReferenceSystem_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.RS_ReferenceSystem_PropertyType));
            typeDictionary.Add(XName.Get("CI_ResponsibleParty_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty_Type));
            typeDictionary.Add(XName.Get("CI_ResponsibleParty_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty_PropertyType));
            typeDictionary.Add(XName.Get("CI_Citation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Citation_Type));
            typeDictionary.Add(XName.Get("CI_Citation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Citation_PropertyType));
            typeDictionary.Add(XName.Get("CI_Address_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Address_Type));
            typeDictionary.Add(XName.Get("CI_Address_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Address_PropertyType));
            typeDictionary.Add(XName.Get("CI_OnlineResource_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_Type));
            typeDictionary.Add(XName.Get("CI_OnlineResource_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_PropertyType));
            typeDictionary.Add(XName.Get("CI_Contact_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Contact_Type));
            typeDictionary.Add(XName.Get("CI_Contact_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Contact_PropertyType));
            typeDictionary.Add(XName.Get("CI_Telephone_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone_Type));
            typeDictionary.Add(XName.Get("CI_Telephone_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone_PropertyType));
            typeDictionary.Add(XName.Get("CI_Date_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Date_Type));
            typeDictionary.Add(XName.Get("CI_Date_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Date_PropertyType));
            typeDictionary.Add(XName.Get("CI_Series_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Series_Type));
            typeDictionary.Add(XName.Get("CI_Series_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Series_PropertyType));
            typeDictionary.Add(XName.Get("URL_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.URL_PropertyType));
            typeDictionary.Add(XName.Get("CI_RoleCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_RoleCode_PropertyType));
            typeDictionary.Add(XName.Get("CI_PresentationFormCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode_PropertyType));
            typeDictionary.Add(XName.Get("CI_OnLineFunctionCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode_PropertyType));
            typeDictionary.Add(XName.Get("CI_DateTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_GridSpatialRepresentation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation_Type));
            typeDictionary.Add(XName.Get("MD_GridSpatialRepresentation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation_PropertyType));
            typeDictionary.Add(XName.Get("MD_VectorSpatialRepresentation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation_Type));
            typeDictionary.Add(XName.Get("MD_VectorSpatialRepresentation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation_PropertyType));
            typeDictionary.Add(XName.Get("AbstractMD_SpatialRepresentation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation_Type));
            typeDictionary.Add(XName.Get("MD_SpatialRepresentation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentation_PropertyType));
            typeDictionary.Add(XName.Get("MD_Georeferenceable_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable_Type));
            typeDictionary.Add(XName.Get("MD_Georeferenceable_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable_PropertyType));
            typeDictionary.Add(XName.Get("MD_Dimension_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension_Type));
            typeDictionary.Add(XName.Get("MD_Dimension_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension_PropertyType));
            typeDictionary.Add(XName.Get("MD_Georectified_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified_Type));
            typeDictionary.Add(XName.Get("MD_Georectified_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified_PropertyType));
            typeDictionary.Add(XName.Get("MD_GeometricObjects_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects_Type));
            typeDictionary.Add(XName.Get("MD_GeometricObjects_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects_PropertyType));
            typeDictionary.Add(XName.Get("MD_PixelOrientationCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PixelOrientationCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_TopologyLevelCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_GeometricObjectTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_CellGeometryCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_DimensionNameTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_ExtendedElementInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation_Type));
            typeDictionary.Add(XName.Get("MD_ExtendedElementInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_MetadataExtensionInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation_Type));
            typeDictionary.Add(XName.Get("MD_MetadataExtensionInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_ObligationCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ObligationCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_DatatypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_FeatureCatalogueDescription_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription_Type));
            typeDictionary.Add(XName.Get("MD_FeatureCatalogueDescription_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription_PropertyType));
            typeDictionary.Add(XName.Get("MD_CoverageDescription_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription_Type));
            typeDictionary.Add(XName.Get("MD_CoverageDescription_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription_PropertyType));
            typeDictionary.Add(XName.Get("MD_ImageDescription_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription_Type));
            typeDictionary.Add(XName.Get("MD_ImageDescription_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription_PropertyType));
            typeDictionary.Add(XName.Get("AbstractMD_ContentInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation_Type));
            typeDictionary.Add(XName.Get("MD_ContentInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ContentInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_RangeDimension_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension_Type));
            typeDictionary.Add(XName.Get("MD_RangeDimension_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension_PropertyType));
            typeDictionary.Add(XName.Get("MD_Band_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Band_Type));
            typeDictionary.Add(XName.Get("MD_Band_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Band_PropertyType));
            typeDictionary.Add(XName.Get("MD_CoverageContentTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_ImagingConditionCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_ApplicationSchemaInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation_Type));
            typeDictionary.Add(XName.Get("MD_ApplicationSchemaInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_PortrayalCatalogueReference_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference_Type));
            typeDictionary.Add(XName.Get("MD_PortrayalCatalogueReference_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference_PropertyType));
            typeDictionary.Add(XName.Get("LI_ProcessStep_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep_Type));
            typeDictionary.Add(XName.Get("LI_ProcessStep_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep_PropertyType));
            typeDictionary.Add(XName.Get("LI_Source_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Source_Type));
            typeDictionary.Add(XName.Get("LI_Source_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Source_PropertyType));
            typeDictionary.Add(XName.Get("LI_Lineage_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage_Type));
            typeDictionary.Add(XName.Get("LI_Lineage_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage_PropertyType));
            typeDictionary.Add(XName.Get("DQ_ConformanceResult_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult_Type));
            typeDictionary.Add(XName.Get("DQ_ConformanceResult_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult_PropertyType));
            typeDictionary.Add(XName.Get("DQ_QuantitativeResult_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult_Type));
            typeDictionary.Add(XName.Get("DQ_QuantitativeResult_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_Result_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result_Type));
            typeDictionary.Add(XName.Get("DQ_Result_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Result_PropertyType));
            typeDictionary.Add(XName.Get("DQ_TemporalValidity_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity_Type));
            typeDictionary.Add(XName.Get("DQ_TemporalValidity_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity_PropertyType));
            typeDictionary.Add(XName.Get("DQ_TemporalConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_TemporalConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency_PropertyType));
            typeDictionary.Add(XName.Get("DQ_AccuracyOfATimeMeasurement_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement_Type));
            typeDictionary.Add(XName.Get("DQ_AccuracyOfATimeMeasurement_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement_PropertyType));
            typeDictionary.Add(XName.Get("DQ_QuantitativeAttributeAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_QuantitativeAttributeAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("DQ_NonQuantitativeAttributeAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_NonQuantitativeAttributeAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("DQ_ThematicClassificationCorrectness_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness_Type));
            typeDictionary.Add(XName.Get("DQ_ThematicClassificationCorrectness_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness_PropertyType));
            typeDictionary.Add(XName.Get("DQ_RelativeInternalPositionalAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_RelativeInternalPositionalAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("DQ_GriddedDataPositionalAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_GriddedDataPositionalAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("DQ_AbsoluteExternalPositionalAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_AbsoluteExternalPositionalAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("DQ_TopologicalConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_TopologicalConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency_PropertyType));
            typeDictionary.Add(XName.Get("DQ_FormatConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_FormatConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency_PropertyType));
            typeDictionary.Add(XName.Get("DQ_DomainConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_DomainConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency_PropertyType));
            typeDictionary.Add(XName.Get("DQ_ConceptualConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_ConceptualConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency_PropertyType));
            typeDictionary.Add(XName.Get("DQ_CompletenessOmission_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission_Type));
            typeDictionary.Add(XName.Get("DQ_CompletenessOmission_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission_PropertyType));
            typeDictionary.Add(XName.Get("DQ_CompletenessCommission_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission_Type));
            typeDictionary.Add(XName.Get("DQ_CompletenessCommission_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_TemporalAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_TemporalAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_ThematicAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_ThematicAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_PositionalAccuracy_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy_Type));
            typeDictionary.Add(XName.Get("DQ_PositionalAccuracy_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_PositionalAccuracy_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_LogicalConsistency_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency_Type));
            typeDictionary.Add(XName.Get("DQ_LogicalConsistency_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_LogicalConsistency_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_Completeness_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness_Type));
            typeDictionary.Add(XName.Get("DQ_Completeness_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Completeness_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDQ_Element_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element_Type));
            typeDictionary.Add(XName.Get("DQ_Element_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Element_PropertyType));
            typeDictionary.Add(XName.Get("DQ_DataQuality_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality_Type));
            typeDictionary.Add(XName.Get("DQ_DataQuality_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality_PropertyType));
            typeDictionary.Add(XName.Get("DQ_Scope_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope_Type));
            typeDictionary.Add(XName.Get("DQ_Scope_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope_PropertyType));
            typeDictionary.Add(XName.Get("DQ_EvaluationMethodTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_Constraints_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints_Type));
            typeDictionary.Add(XName.Get("MD_Constraints_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints_PropertyType));
            typeDictionary.Add(XName.Get("MD_LegalConstraints_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints_Type));
            typeDictionary.Add(XName.Get("MD_LegalConstraints_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints_PropertyType));
            typeDictionary.Add(XName.Get("MD_SecurityConstraints_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints_Type));
            typeDictionary.Add(XName.Get("MD_SecurityConstraints_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints_PropertyType));
            typeDictionary.Add(XName.Get("MD_ClassificationCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_RestrictionCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_Medium_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Medium_Type));
            typeDictionary.Add(XName.Get("MD_Medium_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Medium_PropertyType));
            typeDictionary.Add(XName.Get("MD_DigitalTransferOptions_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions_Type));
            typeDictionary.Add(XName.Get("MD_DigitalTransferOptions_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions_PropertyType));
            typeDictionary.Add(XName.Get("MD_StandardOrderProcess_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_Type));
            typeDictionary.Add(XName.Get("MD_StandardOrderProcess_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_PropertyType));
            typeDictionary.Add(XName.Get("MD_Distributor_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor_Type));
            typeDictionary.Add(XName.Get("MD_Distributor_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor_PropertyType));
            typeDictionary.Add(XName.Get("MD_Distribution_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution_Type));
            typeDictionary.Add(XName.Get("MD_Distribution_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution_PropertyType));
            typeDictionary.Add(XName.Get("MD_Format_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Format_Type));
            typeDictionary.Add(XName.Get("MD_Format_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Format_PropertyType));
            typeDictionary.Add(XName.Get("MD_DistributionUnits_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits_PropertyType));
            typeDictionary.Add(XName.Get("MD_MediumFormatCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_MediumNameCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_MaintenanceInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation_Type));
            typeDictionary.Add(XName.Get("MD_MaintenanceInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_ScopeDescription_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription_Type));
            typeDictionary.Add(XName.Get("MD_ScopeDescription_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription_PropertyType));
            typeDictionary.Add(XName.Get("MD_MaintenanceFrequencyCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_ScopeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode_PropertyType));
            typeDictionary.Add(XName.Get("AbstractMD_Identification_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification_Type));
            typeDictionary.Add(XName.Get("MD_Identification_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Identification_PropertyType));
            typeDictionary.Add(XName.Get("MD_BrowseGraphic_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic_Type));
            typeDictionary.Add(XName.Get("MD_BrowseGraphic_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic_PropertyType));
            typeDictionary.Add(XName.Get("MD_DataIdentification_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_Type));
            typeDictionary.Add(XName.Get("MD_DataIdentification_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_PropertyType));
            typeDictionary.Add(XName.Get("MD_ServiceIdentification_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification_Type));
            typeDictionary.Add(XName.Get("MD_ServiceIdentification_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification_PropertyType));
            typeDictionary.Add(XName.Get("MD_RepresentativeFraction_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction_Type));
            typeDictionary.Add(XName.Get("MD_RepresentativeFraction_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction_PropertyType));
            typeDictionary.Add(XName.Get("MD_Usage_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Usage_Type));
            typeDictionary.Add(XName.Get("MD_Usage_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Usage_PropertyType));
            typeDictionary.Add(XName.Get("MD_Keywords_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords_Type));
            typeDictionary.Add(XName.Get("MD_Keywords_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords_PropertyType));
            typeDictionary.Add(XName.Get("DS_Association_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Association_Type));
            typeDictionary.Add(XName.Get("DS_Association_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Association_PropertyType));
            typeDictionary.Add(XName.Get("MD_AggregateInformation_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation_Type));
            typeDictionary.Add(XName.Get("MD_AggregateInformation_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation_PropertyType));
            typeDictionary.Add(XName.Get("MD_Resolution_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution_Type));
            typeDictionary.Add(XName.Get("MD_Resolution_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution_PropertyType));
            typeDictionary.Add(XName.Get("MD_TopicCategoryCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_TopicCategoryCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_CharacterSetCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_SpatialRepresentationTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_ProgressCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode_PropertyType));
            typeDictionary.Add(XName.Get("MD_KeywordTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("DS_AssociationTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("DS_InitiativeTypeCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode_PropertyType));
            typeDictionary.Add(XName.Get("PT_FreeText_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText_Type));
            typeDictionary.Add(XName.Get("PT_FreeText_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText_PropertyType));
            typeDictionary.Add(XName.Get("PT_Locale_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_Locale_Type));
            typeDictionary.Add(XName.Get("PT_Locale_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_Locale_PropertyType));
            typeDictionary.Add(XName.Get("LocalisedCharacterString_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString_Type));
            typeDictionary.Add(XName.Get("LocalisedCharacterString_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString_PropertyType));
            typeDictionary.Add(XName.Get("PT_LocaleContainer_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer_Type));
            typeDictionary.Add(XName.Get("PT_LocaleContainer_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer_PropertyType));
            typeDictionary.Add(XName.Get("LanguageCode_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LanguageCode_PropertyType));
            typeDictionary.Add(XName.Get("Country_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.Country_PropertyType));
            typeDictionary.Add(XName.Get("MD_Metadata_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata_Type));
            typeDictionary.Add(XName.Get("MD_Metadata_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata_PropertyType));
            typeDictionary.Add(XName.Get("AbstractDS_Aggregate_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate_Type));
            typeDictionary.Add(XName.Get("DS_Aggregate_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Aggregate_PropertyType));
            typeDictionary.Add(XName.Get("DS_DataSet_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet_Type));
            typeDictionary.Add(XName.Get("DS_DataSet_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet_PropertyType));
            typeDictionary.Add(XName.Get("DS_OtherAggregate_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate_Type));
            typeDictionary.Add(XName.Get("DS_OtherAggregate_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate_PropertyType));
            typeDictionary.Add(XName.Get("DS_Series_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Series_Type));
            typeDictionary.Add(XName.Get("DS_Series_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Series_PropertyType));
            typeDictionary.Add(XName.Get("DS_Initiative_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative_Type));
            typeDictionary.Add(XName.Get("DS_Initiative_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative_PropertyType));
            typeDictionary.Add(XName.Get("DS_Platform_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Platform_Type));
            typeDictionary.Add(XName.Get("DS_Platform_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Platform_PropertyType));
            typeDictionary.Add(XName.Get("DS_Sensor_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor_Type));
            typeDictionary.Add(XName.Get("DS_Sensor_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor_PropertyType));
            typeDictionary.Add(XName.Get("DS_ProductionSeries_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries_Type));
            typeDictionary.Add(XName.Get("DS_ProductionSeries_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries_PropertyType));
            typeDictionary.Add(XName.Get("DS_StereoMate_Type", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate_Type));
            typeDictionary.Add(XName.Get("DS_StereoMate_PropertyType", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate_PropertyType));
            typeDictionary.Add(XName.Get("AbstractObject_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type));
            typeDictionary.Add(XName.Get("ObjectReference_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.ObjectReference_PropertyType));
            typeDictionary.Add(XName.Get("CodeListValue_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.CodeListValue_Type));
            typeDictionary.Add(XName.Get("TypeName_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.TypeName_Type));
            typeDictionary.Add(XName.Get("TypeName_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.TypeName_PropertyType));
            typeDictionary.Add(XName.Get("MemberName_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MemberName_Type));
            typeDictionary.Add(XName.Get("MemberName_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MemberName_PropertyType));
            typeDictionary.Add(XName.Get("Multiplicity_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Multiplicity_Type));
            typeDictionary.Add(XName.Get("Multiplicity_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Multiplicity_PropertyType));
            typeDictionary.Add(XName.Get("MultiplicityRange_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange_Type));
            typeDictionary.Add(XName.Get("MultiplicityRange_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange_PropertyType));
            typeDictionary.Add(XName.Get("Measure_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Measure_PropertyType));
            typeDictionary.Add(XName.Get("Length_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Length_PropertyType));
            typeDictionary.Add(XName.Get("Angle_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Angle_PropertyType));
            typeDictionary.Add(XName.Get("Scale_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Scale_PropertyType));
            typeDictionary.Add(XName.Get("Distance_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Distance_PropertyType));
            typeDictionary.Add(XName.Get("CharacterString_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.CharacterString_PropertyType));
            typeDictionary.Add(XName.Get("Boolean_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Boolean_PropertyType));
            typeDictionary.Add(XName.Get("GenericName_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.GenericName_PropertyType));
            typeDictionary.Add(XName.Get("LocalName_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.LocalName_PropertyType));
            typeDictionary.Add(XName.Get("ScopedName_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.ScopedName_PropertyType));
            typeDictionary.Add(XName.Get("UomAngle_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomAngle_PropertyType));
            typeDictionary.Add(XName.Get("UomLength_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomLength_PropertyType));
            typeDictionary.Add(XName.Get("UomScale_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomScale_PropertyType));
            typeDictionary.Add(XName.Get("UnitOfMeasure_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UnitOfMeasure_PropertyType));
            typeDictionary.Add(XName.Get("UomArea_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomArea_PropertyType));
            typeDictionary.Add(XName.Get("UomVelocity_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomVelocity_PropertyType));
            typeDictionary.Add(XName.Get("UomTime_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomTime_PropertyType));
            typeDictionary.Add(XName.Get("UomVolume_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UomVolume_PropertyType));
            typeDictionary.Add(XName.Get("DateTime_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.DateTime_PropertyType));
            typeDictionary.Add(XName.Get("Date_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Date_PropertyType));
            typeDictionary.Add(XName.Get("Number_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Number_PropertyType));
            typeDictionary.Add(XName.Get("Decimal_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Decimal_PropertyType));
            typeDictionary.Add(XName.Get("Real_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Real_PropertyType));
            typeDictionary.Add(XName.Get("Integer_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Integer_PropertyType));
            typeDictionary.Add(XName.Get("UnlimitedInteger_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger_Type));
            typeDictionary.Add(XName.Get("UnlimitedInteger_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger_PropertyType));
            typeDictionary.Add(XName.Get("Record_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Record_PropertyType));
            typeDictionary.Add(XName.Get("RecordType_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.RecordType_Type));
            typeDictionary.Add(XName.Get("RecordType_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.RecordType_PropertyType));
            typeDictionary.Add(XName.Get("Binary_Type", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Binary_Type));
            typeDictionary.Add(XName.Get("Binary_PropertyType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Binary_PropertyType));
            typeDictionary.Add(XName.Get("CodeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            typeDictionary.Add(XName.Get("CodeWithAuthorityType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            typeDictionary.Add(XName.Get("MeasureType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MeasureType));
            typeDictionary.Add(XName.Get("CoordinatesType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinatesType));
            typeDictionary.Add(XName.Get("CodeListType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CodeListType));
            typeDictionary.Add(XName.Get("CodeOrNilReasonListType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CodeOrNilReasonListType));
            typeDictionary.Add(XName.Get("MeasureListType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MeasureListType));
            typeDictionary.Add(XName.Get("MeasureOrNilReasonListType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MeasureOrNilReasonListType));
            typeDictionary.Add(XName.Get("AbstractGMLType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGMLType));
            typeDictionary.Add(XName.Get("AssociationRoleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AssociationRoleType));
            typeDictionary.Add(XName.Get("ReferenceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            typeDictionary.Add(XName.Get("InlinePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.InlinePropertyType));
            typeDictionary.Add(XName.Get("AbstractMemberType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractMemberType));
            typeDictionary.Add(XName.Get("AbstractMetadataPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractMetadataPropertyType));
            typeDictionary.Add(XName.Get("DefinitionBaseType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionBaseType));
            typeDictionary.Add(XName.Get("DefinitionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionType));
            typeDictionary.Add(XName.Get("DictionaryType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryType));
            typeDictionary.Add(XName.Get("DictionaryEntryType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryEntryType));
            typeDictionary.Add(XName.Get("UnitOfMeasureType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UnitOfMeasureType));
            typeDictionary.Add(XName.Get("UnitDefinitionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UnitDefinitionType));
            typeDictionary.Add(XName.Get("BaseUnitType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BaseUnitType));
            typeDictionary.Add(XName.Get("DerivedUnitType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivedUnitType));
            typeDictionary.Add(XName.Get("DerivationUnitTermType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivationUnitTermType));
            typeDictionary.Add(XName.Get("ConventionalUnitType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConventionalUnitType));
            typeDictionary.Add(XName.Get("ConversionToPreferredUnitType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConversionToPreferredUnitType));
            typeDictionary.Add(XName.Get("FormulaType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FormulaType));
            typeDictionary.Add(XName.Get("LengthType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LengthType));
            typeDictionary.Add(XName.Get("ScaleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ScaleType));
            typeDictionary.Add(XName.Get("TimeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeType));
            typeDictionary.Add(XName.Get("GridLengthType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridLengthType));
            typeDictionary.Add(XName.Get("AreaType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AreaType));
            typeDictionary.Add(XName.Get("VolumeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VolumeType));
            typeDictionary.Add(XName.Get("SpeedType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SpeedType));
            typeDictionary.Add(XName.Get("AngleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AngleType));
            typeDictionary.Add(XName.Get("AbstractGeometryType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometryType));
            typeDictionary.Add(XName.Get("GeometryPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometryPropertyType));
            typeDictionary.Add(XName.Get("GeometryArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometryArrayPropertyType));
            typeDictionary.Add(XName.Get("DirectPositionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectPositionType));
            typeDictionary.Add(XName.Get("DirectPositionListType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectPositionListType));
            typeDictionary.Add(XName.Get("VectorType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VectorType));
            typeDictionary.Add(XName.Get("EnvelopeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EnvelopeType));
            typeDictionary.Add(XName.Get("AbstractGeometricPrimitiveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitiveType));
            typeDictionary.Add(XName.Get("GeometricPrimitivePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometricPrimitivePropertyType));
            typeDictionary.Add(XName.Get("PointType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PointType));
            typeDictionary.Add(XName.Get("PointPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            typeDictionary.Add(XName.Get("PointArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PointArrayPropertyType));
            typeDictionary.Add(XName.Get("AbstractCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurveType));
            typeDictionary.Add(XName.Get("CurvePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            typeDictionary.Add(XName.Get("CurveArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CurveArrayPropertyType));
            typeDictionary.Add(XName.Get("LineStringType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LineStringType));
            typeDictionary.Add(XName.Get("AbstractSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurfaceType));
            typeDictionary.Add(XName.Get("SurfacePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePropertyType));
            typeDictionary.Add(XName.Get("SurfaceArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceArrayPropertyType));
            typeDictionary.Add(XName.Get("PolygonType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolygonType));
            typeDictionary.Add(XName.Get("AbstractRingType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRingType));
            typeDictionary.Add(XName.Get("AbstractRingPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRingPropertyType));
            typeDictionary.Add(XName.Get("LinearRingType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearRingType));
            typeDictionary.Add(XName.Get("LinearRingPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearRingPropertyType));
            typeDictionary.Add(XName.Get("CurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CurveType));
            typeDictionary.Add(XName.Get("OrientableCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OrientableCurveType));
            typeDictionary.Add(XName.Get("AbstractCurveSegmentType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurveSegmentType));
            typeDictionary.Add(XName.Get("CurveSegmentArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CurveSegmentArrayPropertyType));
            typeDictionary.Add(XName.Get("LineStringSegmentType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LineStringSegmentType));
            typeDictionary.Add(XName.Get("ArcStringType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcStringType));
            typeDictionary.Add(XName.Get("ArcType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcType));
            typeDictionary.Add(XName.Get("CircleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CircleType));
            typeDictionary.Add(XName.Get("ArcStringByBulgeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcStringByBulgeType));
            typeDictionary.Add(XName.Get("ArcByBulgeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcByBulgeType));
            typeDictionary.Add(XName.Get("ArcByCenterPointType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcByCenterPointType));
            typeDictionary.Add(XName.Get("CircleByCenterPointType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CircleByCenterPointType));
            typeDictionary.Add(XName.Get("CubicSplineType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CubicSplineType));
            typeDictionary.Add(XName.Get("BSplineType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BSplineType));
            typeDictionary.Add(XName.Get("KnotType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.KnotType));
            typeDictionary.Add(XName.Get("KnotPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.KnotPropertyType));
            typeDictionary.Add(XName.Get("BezierType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BezierType));
            typeDictionary.Add(XName.Get("OffsetCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OffsetCurveType));
            typeDictionary.Add(XName.Get("AffinePlacementType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AffinePlacementType));
            typeDictionary.Add(XName.Get("ClothoidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ClothoidType));
            typeDictionary.Add(XName.Get("GeodesicStringType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodesicStringType));
            typeDictionary.Add(XName.Get("GeodesicType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodesicType));
            typeDictionary.Add(XName.Get("SurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceType));
            typeDictionary.Add(XName.Get("OrientableSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OrientableSurfaceType));
            typeDictionary.Add(XName.Get("AbstractSurfacePatchType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatchType));
            typeDictionary.Add(XName.Get("SurfacePatchArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePatchArrayPropertyType));
            typeDictionary.Add(XName.Get("PolygonPatchType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolygonPatchType));
            typeDictionary.Add(XName.Get("TriangleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TriangleType));
            typeDictionary.Add(XName.Get("RectangleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RectangleType));
            typeDictionary.Add(XName.Get("RingType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RingType));
            typeDictionary.Add(XName.Get("RingPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RingPropertyType));
            typeDictionary.Add(XName.Get("AbstractParametricCurveSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurfaceType));
            typeDictionary.Add(XName.Get("AbstractGriddedSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurfaceType));
            typeDictionary.Add(XName.Get("ConeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConeType));
            typeDictionary.Add(XName.Get("CylinderType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CylinderType));
            typeDictionary.Add(XName.Get("SphereType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SphereType));
            typeDictionary.Add(XName.Get("TinType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TinType));
            typeDictionary.Add(XName.Get("LineStringSegmentArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LineStringSegmentArrayPropertyType));
            typeDictionary.Add(XName.Get("AbstractSolidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSolidType));
            typeDictionary.Add(XName.Get("SolidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SolidPropertyType));
            typeDictionary.Add(XName.Get("SolidArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SolidArrayPropertyType));
            typeDictionary.Add(XName.Get("SolidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SolidType));
            typeDictionary.Add(XName.Get("ShellType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ShellType));
            typeDictionary.Add(XName.Get("ShellPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ShellPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeometricAggregateType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregateType));
            typeDictionary.Add(XName.Get("MultiGeometryType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiGeometryType));
            typeDictionary.Add(XName.Get("MultiGeometryPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiGeometryPropertyType));
            typeDictionary.Add(XName.Get("MultiPointType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointType));
            typeDictionary.Add(XName.Get("MultiPointPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointPropertyType));
            typeDictionary.Add(XName.Get("MultiCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurveType));
            typeDictionary.Add(XName.Get("MultiCurvePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurvePropertyType));
            typeDictionary.Add(XName.Get("MultiSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfaceType));
            typeDictionary.Add(XName.Get("MultiSurfacePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfacePropertyType));
            typeDictionary.Add(XName.Get("MultiSolidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolidType));
            typeDictionary.Add(XName.Get("MultiSolidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolidPropertyType));
            typeDictionary.Add(XName.Get("AbstractTimeObjectType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeObjectType));
            typeDictionary.Add(XName.Get("AbstractTimePrimitiveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitiveType));
            typeDictionary.Add(XName.Get("TimePrimitivePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimePrimitivePropertyType));
            typeDictionary.Add(XName.Get("RelatedTimeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RelatedTimeType));
            typeDictionary.Add(XName.Get("AbstractTimeComplexType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeComplexType));
            typeDictionary.Add(XName.Get("AbstractTimeGeometricPrimitiveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitiveType));
            typeDictionary.Add(XName.Get("TimeInstantType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeInstantType));
            typeDictionary.Add(XName.Get("TimeInstantPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeInstantPropertyType));
            typeDictionary.Add(XName.Get("TimePeriodType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimePeriodType));
            typeDictionary.Add(XName.Get("TimePeriodPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimePeriodPropertyType));
            typeDictionary.Add(XName.Get("TimePositionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimePositionType));
            typeDictionary.Add(XName.Get("TimeIntervalLengthType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeIntervalLengthType));
            typeDictionary.Add(XName.Get("AbstractFeatureType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureType));
            typeDictionary.Add(XName.Get("FeaturePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FeaturePropertyType));
            typeDictionary.Add(XName.Get("BoundingShapeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BoundingShapeType));
            typeDictionary.Add(XName.Get("EnvelopeWithTimePeriodType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriodType));
            typeDictionary.Add(XName.Get("AbstractFeatureMemberType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureMemberType));
            typeDictionary.Add(XName.Get("DirectionPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectionPropertyType));
            typeDictionary.Add(XName.Get("DirectionVectorType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectionVectorType));
            typeDictionary.Add(XName.Get("DirectionDescriptionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectionDescriptionType));
            typeDictionary.Add(XName.Get("DynamicFeatureType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureType));
            typeDictionary.Add(XName.Get("DynamicFeatureCollectionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollectionType));
            typeDictionary.Add(XName.Get("DynamicFeatureMemberType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureMemberType));
            typeDictionary.Add(XName.Get("AbstractTimeSliceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeSliceType));
            typeDictionary.Add(XName.Get("HistoryPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.HistoryPropertyType));
            typeDictionary.Add(XName.Get("GeometricComplexType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometricComplexType));
            typeDictionary.Add(XName.Get("GeometricComplexPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometricComplexPropertyType));
            typeDictionary.Add(XName.Get("CompositeCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeCurveType));
            typeDictionary.Add(XName.Get("CompositeSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSurfaceType));
            typeDictionary.Add(XName.Get("CompositeSolidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSolidType));
            typeDictionary.Add(XName.Get("AbstractTopologyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopologyType));
            typeDictionary.Add(XName.Get("AbstractTopoPrimitiveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitiveType));
            typeDictionary.Add(XName.Get("NodeOrEdgePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.NodeOrEdgePropertyType));
            typeDictionary.Add(XName.Get("NodePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.NodePropertyType));
            typeDictionary.Add(XName.Get("FaceOrTopoSolidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FaceOrTopoSolidPropertyType));
            typeDictionary.Add(XName.Get("TopoSolidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSolidPropertyType));
            typeDictionary.Add(XName.Get("NodeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.NodeType));
            typeDictionary.Add(XName.Get("DirectedNodePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedNodePropertyType));
            typeDictionary.Add(XName.Get("EdgeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EdgeType));
            typeDictionary.Add(XName.Get("DirectedEdgePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedEdgePropertyType));
            typeDictionary.Add(XName.Get("FaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FaceType));
            typeDictionary.Add(XName.Get("DirectedFacePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedFacePropertyType));
            typeDictionary.Add(XName.Get("TopoSolidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSolidType));
            typeDictionary.Add(XName.Get("DirectedTopoSolidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedTopoSolidPropertyType));
            typeDictionary.Add(XName.Get("TopoPointType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoPointType));
            typeDictionary.Add(XName.Get("TopoPointPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoPointPropertyType));
            typeDictionary.Add(XName.Get("TopoCurveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoCurveType));
            typeDictionary.Add(XName.Get("TopoCurvePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoCurvePropertyType));
            typeDictionary.Add(XName.Get("TopoSurfaceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSurfaceType));
            typeDictionary.Add(XName.Get("TopoSurfacePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSurfacePropertyType));
            typeDictionary.Add(XName.Get("TopoVolumeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoVolumeType));
            typeDictionary.Add(XName.Get("TopoVolumePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoVolumePropertyType));
            typeDictionary.Add(XName.Get("TopoComplexType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexType));
            typeDictionary.Add(XName.Get("TopoPrimitiveMemberType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoPrimitiveMemberType));
            typeDictionary.Add(XName.Get("TopoPrimitiveArrayAssociationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoPrimitiveArrayAssociationType));
            typeDictionary.Add(XName.Get("TopoComplexPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexPropertyType));
            typeDictionary.Add(XName.Get("ValuePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ValuePropertyType));
            typeDictionary.Add(XName.Get("ValueArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ValueArrayPropertyType));
            typeDictionary.Add(XName.Get("CompositeValueType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeValueType));
            typeDictionary.Add(XName.Get("ValueArrayType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ValueArrayType));
            typeDictionary.Add(XName.Get("CategoryExtentType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CategoryExtentType));
            typeDictionary.Add(XName.Get("QuantityExtentType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.QuantityExtentType));
            typeDictionary.Add(XName.Get("BooleanPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BooleanPropertyType));
            typeDictionary.Add(XName.Get("CategoryPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CategoryPropertyType));
            typeDictionary.Add(XName.Get("QuantityPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.QuantityPropertyType));
            typeDictionary.Add(XName.Get("CountPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CountPropertyType));
            typeDictionary.Add(XName.Get("GridType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridType));
            typeDictionary.Add(XName.Get("GridLimitsType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridLimitsType));
            typeDictionary.Add(XName.Get("GridEnvelopeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridEnvelopeType));
            typeDictionary.Add(XName.Get("RectifiedGridType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RectifiedGridType));
            typeDictionary.Add(XName.Get("AbstractCoverageType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoverageType));
            typeDictionary.Add(XName.Get("DiscreteCoverageType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            typeDictionary.Add(XName.Get("AbstractContinuousCoverageType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverageType));
            typeDictionary.Add(XName.Get("DomainSetType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            typeDictionary.Add(XName.Get("RangeSetType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RangeSetType));
            typeDictionary.Add(XName.Get("DataBlockType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DataBlockType));
            typeDictionary.Add(XName.Get("FileType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FileType));
            typeDictionary.Add(XName.Get("CoverageFunctionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoverageFunctionType));
            typeDictionary.Add(XName.Get("MappingRuleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MappingRuleType));
            typeDictionary.Add(XName.Get("GridFunctionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridFunctionType));
            typeDictionary.Add(XName.Get("SequenceRuleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SequenceRuleType));
            typeDictionary.Add(XName.Get("IdentifiedObjectType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.IdentifiedObjectType));
            typeDictionary.Add(XName.Get("AbstractCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCRSType));
            typeDictionary.Add(XName.Get("CRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CRSPropertyType));
            typeDictionary.Add(XName.Get("CoordinateSystemAxisType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisType));
            typeDictionary.Add(XName.Get("CoordinateSystemAxisPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisPropertyType));
            typeDictionary.Add(XName.Get("AbstractCoordinateSystemType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystemType));
            typeDictionary.Add(XName.Get("CoordinateSystemPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemPropertyType));
            typeDictionary.Add(XName.Get("EllipsoidalCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSType));
            typeDictionary.Add(XName.Get("EllipsoidalCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSPropertyType));
            typeDictionary.Add(XName.Get("CartesianCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSType));
            typeDictionary.Add(XName.Get("CartesianCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSPropertyType));
            typeDictionary.Add(XName.Get("VerticalCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSType));
            typeDictionary.Add(XName.Get("VerticalCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSPropertyType));
            typeDictionary.Add(XName.Get("TimeCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCSType));
            typeDictionary.Add(XName.Get("TimeCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCSPropertyType));
            typeDictionary.Add(XName.Get("LinearCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearCSType));
            typeDictionary.Add(XName.Get("LinearCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearCSPropertyType));
            typeDictionary.Add(XName.Get("UserDefinedCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCSType));
            typeDictionary.Add(XName.Get("UserDefinedCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCSPropertyType));
            typeDictionary.Add(XName.Get("SphericalCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSType));
            typeDictionary.Add(XName.Get("SphericalCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSPropertyType));
            typeDictionary.Add(XName.Get("PolarCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolarCSType));
            typeDictionary.Add(XName.Get("PolarCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolarCSPropertyType));
            typeDictionary.Add(XName.Get("CylindricalCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCSType));
            typeDictionary.Add(XName.Get("CylindricalCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCSPropertyType));
            typeDictionary.Add(XName.Get("AffineCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AffineCSType));
            typeDictionary.Add(XName.Get("AffineCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AffineCSPropertyType));
            typeDictionary.Add(XName.Get("AbstractDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractDatumType));
            typeDictionary.Add(XName.Get("DatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DatumPropertyType));
            typeDictionary.Add(XName.Get("GeodeticDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumType));
            typeDictionary.Add(XName.Get("GeodeticDatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumPropertyType));
            typeDictionary.Add(XName.Get("EllipsoidType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidType));
            typeDictionary.Add(XName.Get("EllipsoidPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidPropertyType));
            typeDictionary.Add(XName.Get("PrimeMeridianType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianType));
            typeDictionary.Add(XName.Get("PrimeMeridianPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianPropertyType));
            typeDictionary.Add(XName.Get("EngineeringDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumType));
            typeDictionary.Add(XName.Get("EngineeringDatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumPropertyType));
            typeDictionary.Add(XName.Get("ImageDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumType));
            typeDictionary.Add(XName.Get("ImageDatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumPropertyType));
            typeDictionary.Add(XName.Get("VerticalDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumType));
            typeDictionary.Add(XName.Get("VerticalDatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumPropertyType));
            typeDictionary.Add(XName.Get("TemporalDatumType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumType));
            typeDictionary.Add(XName.Get("TemporalDatumBaseType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumBaseType));
            typeDictionary.Add(XName.Get("TemporalDatumPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumPropertyType));
            typeDictionary.Add(XName.Get("AbstractCoordinateOperationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperationType));
            typeDictionary.Add(XName.Get("CoordinateOperationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateOperationPropertyType));
            typeDictionary.Add(XName.Get("SingleOperationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SingleOperationPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeneralConversionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversionType));
            typeDictionary.Add(XName.Get("GeneralConversionPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeneralConversionPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeneralTransformationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformationType));
            typeDictionary.Add(XName.Get("GeneralTransformationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeneralTransformationPropertyType));
            typeDictionary.Add(XName.Get("ConcatenatedOperationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperationType));
            typeDictionary.Add(XName.Get("ConcatenatedOperationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperationPropertyType));
            typeDictionary.Add(XName.Get("PassThroughOperationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PassThroughOperationType));
            typeDictionary.Add(XName.Get("PassThroughOperationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PassThroughOperationPropertyType));
            typeDictionary.Add(XName.Get("ConversionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConversionType));
            typeDictionary.Add(XName.Get("ConversionPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConversionPropertyType));
            typeDictionary.Add(XName.Get("TransformationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TransformationType));
            typeDictionary.Add(XName.Get("TransformationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TransformationPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeneralParameterValueType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValueType));
            typeDictionary.Add(XName.Get("AbstractGeneralParameterValuePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValuePropertyType));
            typeDictionary.Add(XName.Get("ParameterValueType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValueType));
            typeDictionary.Add(XName.Get("ParameterValueGroupType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValueGroupType));
            typeDictionary.Add(XName.Get("OperationMethodType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodType));
            typeDictionary.Add(XName.Get("OperationMethodPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeneralOperationParameterType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterType));
            typeDictionary.Add(XName.Get("AbstractGeneralOperationParameterPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            typeDictionary.Add(XName.Get("OperationParameterType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterType));
            typeDictionary.Add(XName.Get("OperationParameterPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterPropertyType));
            typeDictionary.Add(XName.Get("OperationParameterGroupType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroupType));
            typeDictionary.Add(XName.Get("OperationParameterGroupPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroupPropertyType));
            typeDictionary.Add(XName.Get("SingleCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SingleCRSPropertyType));
            typeDictionary.Add(XName.Get("AbstractGeneralDerivedCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRSType));
            typeDictionary.Add(XName.Get("CompoundCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompoundCRSType));
            typeDictionary.Add(XName.Get("CompoundCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompoundCRSPropertyType));
            typeDictionary.Add(XName.Get("GeodeticCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticCRSType));
            typeDictionary.Add(XName.Get("GeodeticCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticCRSPropertyType));
            typeDictionary.Add(XName.Get("VerticalCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCRSType));
            typeDictionary.Add(XName.Get("VerticalCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCRSPropertyType));
            typeDictionary.Add(XName.Get("ProjectedCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ProjectedCRSType));
            typeDictionary.Add(XName.Get("ProjectedCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ProjectedCRSPropertyType));
            typeDictionary.Add(XName.Get("DerivedCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivedCRSTypeType));
            typeDictionary.Add(XName.Get("DerivedCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivedCRSPropertyType));
            typeDictionary.Add(XName.Get("EngineeringCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringCRSType));
            typeDictionary.Add(XName.Get("EngineeringCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringCRSPropertyType));
            typeDictionary.Add(XName.Get("ImageCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageCRSType));
            typeDictionary.Add(XName.Get("ImageCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageCRSPropertyType));
            typeDictionary.Add(XName.Get("TemporalCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCRSType));
            typeDictionary.Add(XName.Get("TemporalCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCRSPropertyType));
            typeDictionary.Add(XName.Get("ObservationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ObservationType));
            typeDictionary.Add(XName.Get("ProcedurePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ProcedurePropertyType));
            typeDictionary.Add(XName.Get("TargetPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TargetPropertyType));
            typeDictionary.Add(XName.Get("ResultType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ResultType));
            typeDictionary.Add(XName.Get("DirectedObservationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservationType));
            typeDictionary.Add(XName.Get("DirectedObservationAtDistanceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistanceType));
            typeDictionary.Add(XName.Get("AbstractTimeTopologyPrimitiveType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitiveType));
            typeDictionary.Add(XName.Get("TimeTopologyPrimitivePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeTopologyPrimitivePropertyType));
            typeDictionary.Add(XName.Get("TimeTopologyComplexType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeTopologyComplexType));
            typeDictionary.Add(XName.Get("TimeTopologyComplexPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeTopologyComplexPropertyType));
            typeDictionary.Add(XName.Get("TimeNodeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeNodeType));
            typeDictionary.Add(XName.Get("TimeNodePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeNodePropertyType));
            typeDictionary.Add(XName.Get("TimeEdgeType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeEdgeType));
            typeDictionary.Add(XName.Get("TimeEdgePropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeEdgePropertyType));
            typeDictionary.Add(XName.Get("TimeReferenceSystemType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeReferenceSystemType));
            typeDictionary.Add(XName.Get("TimeCoordinateSystemType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystemType));
            typeDictionary.Add(XName.Get("TimeCalendarType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarType));
            typeDictionary.Add(XName.Get("TimeCalendarEraType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarEraType));
            typeDictionary.Add(XName.Get("TimeCalendarPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarPropertyType));
            typeDictionary.Add(XName.Get("TimeCalendarEraPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarEraPropertyType));
            typeDictionary.Add(XName.Get("TimeClockType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeClockType));
            typeDictionary.Add(XName.Get("TimeClockPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeClockPropertyType));
            typeDictionary.Add(XName.Get("TimeOrdinalReferenceSystemType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystemType));
            typeDictionary.Add(XName.Get("TimeOrdinalEraType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalEraType));
            typeDictionary.Add(XName.Get("TimeOrdinalEraPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalEraPropertyType));
            typeDictionary.Add(XName.Get("OperationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationPropertyType));
            typeDictionary.Add(XName.Get("TemporalCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCSType));
            typeDictionary.Add(XName.Get("TemporalCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCSPropertyType));
            typeDictionary.Add(XName.Get("ObliqueCartesianCSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCSType));
            typeDictionary.Add(XName.Get("ObliqueCartesianCSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCSPropertyType));
            typeDictionary.Add(XName.Get("GeographicCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRSType));
            typeDictionary.Add(XName.Get("GeographicCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRSPropertyType));
            typeDictionary.Add(XName.Get("GeocentricCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeocentricCRSType));
            typeDictionary.Add(XName.Get("GeocentricCRSPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeocentricCRSPropertyType));
            typeDictionary.Add(XName.Get("DMSAngleType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DMSAngleType));
            typeDictionary.Add(XName.Get("DegreesType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DegreesType));
            typeDictionary.Add(XName.Get("AngleChoiceType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AngleChoiceType));
            typeDictionary.Add(XName.Get("ArrayAssociationType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArrayAssociationType));
            typeDictionary.Add(XName.Get("StringOrRefType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            typeDictionary.Add(XName.Get("BagType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BagType));
            typeDictionary.Add(XName.Get("ArrayType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArrayType));
            typeDictionary.Add(XName.Get("MetaDataPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MetaDataPropertyType));
            typeDictionary.Add(XName.Get("AbstractMetaDataType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractMetaDataType));
            typeDictionary.Add(XName.Get("GenericMetaDataType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GenericMetaDataType));
            typeDictionary.Add(XName.Get("LocationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LocationPropertyType));
            typeDictionary.Add(XName.Get("PriorityLocationPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PriorityLocationPropertyType));
            typeDictionary.Add(XName.Get("FeatureArrayPropertyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FeatureArrayPropertyType));
            typeDictionary.Add(XName.Get("BoundedFeatureType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BoundedFeatureType));
            typeDictionary.Add(XName.Get("AbstractFeatureCollectionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollectionType));
            typeDictionary.Add(XName.Get("FeatureCollectionType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FeatureCollectionType));
            typeDictionary.Add(XName.Get("IndirectEntryType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.IndirectEntryType));
            typeDictionary.Add(XName.Get("DefinitionProxyType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionProxyType));
            typeDictionary.Add(XName.Get("MovingObjectStatusType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MovingObjectStatusType));
            typeDictionary.Add(XName.Get("GM_Point_PropertyType", "http://www.isotc211.org/2005/gss"), typeof(global::GeoSik.Iso.Ts19139.Gss.GM_Point_PropertyType));
            typeDictionary.Add(XName.Get("GM_Object_PropertyType", "http://www.isotc211.org/2005/gss"), typeof(global::GeoSik.Iso.Ts19139.Gss.GM_Object_PropertyType));
            typeDictionary.Add(XName.Get("TM_Primitive_PropertyType", "http://www.isotc211.org/2005/gts"), typeof(global::GeoSik.Iso.Ts19139.Gts.TM_Primitive_PropertyType));
            typeDictionary.Add(XName.Get("TM_PeriodDuration_PropertyType", "http://www.isotc211.org/2005/gts"), typeof(global::GeoSik.Iso.Ts19139.Gts.TM_PeriodDuration_PropertyType));
            typeDictionary.Add(XName.Get("SC_CRS_PropertyType", "http://www.isotc211.org/2005/gsr"), typeof(global::GeoSik.Iso.Ts19139.Gsr.SC_CRS_PropertyType));
        }

        private static void BuildElementDictionary()
        {
            elementDictionary.Add(XName.Get("Record", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Record));
            elementDictionary.Add(XName.Get("AbstractObject", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractObject));
            elementDictionary.Add(XName.Get("Boolean", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Boolean));
            elementDictionary.Add(XName.Get("Category", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Category));
            elementDictionary.Add(XName.Get("Count", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Count));
            elementDictionary.Add(XName.Get("Quantity", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Quantity));
            elementDictionary.Add(XName.Get("AbstractValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractValue));
            elementDictionary.Add(XName.Get("AbstractScalarValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractScalarValue));
            elementDictionary.Add(XName.Get("AbstractScalarValueList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractScalarValueList));
            elementDictionary.Add(XName.Get("domainOfValidity", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.domainOfValidity));
            elementDictionary.Add(XName.Get("secondDefiningParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.secondDefiningParameter));
            elementDictionary.Add(XName.Get("SecondDefiningParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SecondDefiningParameter1));
            elementDictionary.Add(XName.Get("coordinateOperationAccuracy", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinateOperationAccuracy));
            elementDictionary.Add(XName.Get("formulaCitation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.formulaCitation));
            elementDictionary.Add(XName.Get("EX_TemporalExtent", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent));
            elementDictionary.Add(XName.Get("EX_VerticalExtent", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent));
            elementDictionary.Add(XName.Get("EX_BoundingPolygon", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon));
            elementDictionary.Add(XName.Get("EX_Extent", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_Extent));
            elementDictionary.Add(XName.Get("AbstractEX_GeographicExtent", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent));
            elementDictionary.Add(XName.Get("EX_GeographicBoundingBox", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox));
            elementDictionary.Add(XName.Get("EX_SpatialTemporalExtent", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent));
            elementDictionary.Add(XName.Get("EX_GeographicDescription", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription));
            elementDictionary.Add(XName.Get("RS_Identifier", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier));
            elementDictionary.Add(XName.Get("MD_ReferenceSystem", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem));
            elementDictionary.Add(XName.Get("MD_Identifier", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier));
            elementDictionary.Add(XName.Get("AbstractRS_ReferenceSystem", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem));
            elementDictionary.Add(XName.Get("CI_ResponsibleParty", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty));
            elementDictionary.Add(XName.Get("CI_Citation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Citation));
            elementDictionary.Add(XName.Get("CI_Address", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Address));
            elementDictionary.Add(XName.Get("CI_OnlineResource", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource));
            elementDictionary.Add(XName.Get("CI_Contact", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Contact));
            elementDictionary.Add(XName.Get("CI_Telephone", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone));
            elementDictionary.Add(XName.Get("CI_Date", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Date));
            elementDictionary.Add(XName.Get("CI_Series", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Series));
            elementDictionary.Add(XName.Get("URL", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.URL));
            elementDictionary.Add(XName.Get("CI_RoleCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_RoleCode));
            elementDictionary.Add(XName.Get("CI_PresentationFormCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode));
            elementDictionary.Add(XName.Get("CI_OnLineFunctionCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode));
            elementDictionary.Add(XName.Get("CI_DateTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode));
            elementDictionary.Add(XName.Get("MD_GridSpatialRepresentation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation));
            elementDictionary.Add(XName.Get("MD_VectorSpatialRepresentation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation));
            elementDictionary.Add(XName.Get("AbstractMD_SpatialRepresentation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation));
            elementDictionary.Add(XName.Get("MD_Georeferenceable", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable));
            elementDictionary.Add(XName.Get("MD_Dimension", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension));
            elementDictionary.Add(XName.Get("MD_Georectified", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified));
            elementDictionary.Add(XName.Get("MD_GeometricObjects", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects));
            elementDictionary.Add(XName.Get("MD_PixelOrientationCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PixelOrientationCode));
            elementDictionary.Add(XName.Get("MD_TopologyLevelCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode));
            elementDictionary.Add(XName.Get("MD_GeometricObjectTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode));
            elementDictionary.Add(XName.Get("MD_CellGeometryCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode));
            elementDictionary.Add(XName.Get("MD_DimensionNameTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode));
            elementDictionary.Add(XName.Get("MD_ExtendedElementInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation));
            elementDictionary.Add(XName.Get("MD_MetadataExtensionInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation));
            elementDictionary.Add(XName.Get("MD_ObligationCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ObligationCode));
            elementDictionary.Add(XName.Get("MD_DatatypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode));
            elementDictionary.Add(XName.Get("MD_FeatureCatalogueDescription", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription));
            elementDictionary.Add(XName.Get("MD_CoverageDescription", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription));
            elementDictionary.Add(XName.Get("MD_ImageDescription", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription));
            elementDictionary.Add(XName.Get("AbstractMD_ContentInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation));
            elementDictionary.Add(XName.Get("MD_RangeDimension", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension));
            elementDictionary.Add(XName.Get("MD_Band", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Band));
            elementDictionary.Add(XName.Get("MD_CoverageContentTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode));
            elementDictionary.Add(XName.Get("MD_ImagingConditionCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode));
            elementDictionary.Add(XName.Get("MD_ApplicationSchemaInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation));
            elementDictionary.Add(XName.Get("MD_PortrayalCatalogueReference", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference));
            elementDictionary.Add(XName.Get("LI_ProcessStep", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep));
            elementDictionary.Add(XName.Get("LI_Source", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Source));
            elementDictionary.Add(XName.Get("LI_Lineage", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage));
            elementDictionary.Add(XName.Get("DQ_ConformanceResult", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult));
            elementDictionary.Add(XName.Get("DQ_QuantitativeResult", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult));
            elementDictionary.Add(XName.Get("AbstractDQ_Result", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result));
            elementDictionary.Add(XName.Get("DQ_TemporalValidity", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity));
            elementDictionary.Add(XName.Get("DQ_TemporalConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency));
            elementDictionary.Add(XName.Get("DQ_AccuracyOfATimeMeasurement", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement));
            elementDictionary.Add(XName.Get("DQ_QuantitativeAttributeAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy));
            elementDictionary.Add(XName.Get("DQ_NonQuantitativeAttributeAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy));
            elementDictionary.Add(XName.Get("DQ_ThematicClassificationCorrectness", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness));
            elementDictionary.Add(XName.Get("DQ_RelativeInternalPositionalAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy));
            elementDictionary.Add(XName.Get("DQ_GriddedDataPositionalAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy));
            elementDictionary.Add(XName.Get("DQ_AbsoluteExternalPositionalAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy));
            elementDictionary.Add(XName.Get("DQ_TopologicalConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency));
            elementDictionary.Add(XName.Get("DQ_FormatConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency));
            elementDictionary.Add(XName.Get("DQ_DomainConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency));
            elementDictionary.Add(XName.Get("DQ_ConceptualConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency));
            elementDictionary.Add(XName.Get("DQ_CompletenessOmission", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission));
            elementDictionary.Add(XName.Get("DQ_CompletenessCommission", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission));
            elementDictionary.Add(XName.Get("AbstractDQ_TemporalAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy));
            elementDictionary.Add(XName.Get("AbstractDQ_ThematicAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy));
            elementDictionary.Add(XName.Get("AbstractDQ_PositionalAccuracy", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy));
            elementDictionary.Add(XName.Get("AbstractDQ_LogicalConsistency", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency));
            elementDictionary.Add(XName.Get("AbstractDQ_Completeness", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness));
            elementDictionary.Add(XName.Get("AbstractDQ_Element", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element));
            elementDictionary.Add(XName.Get("DQ_DataQuality", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality));
            elementDictionary.Add(XName.Get("DQ_Scope", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope));
            elementDictionary.Add(XName.Get("DQ_EvaluationMethodTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode));
            elementDictionary.Add(XName.Get("MD_Constraints", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints));
            elementDictionary.Add(XName.Get("MD_LegalConstraints", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints));
            elementDictionary.Add(XName.Get("MD_SecurityConstraints", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints));
            elementDictionary.Add(XName.Get("MD_ClassificationCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode));
            elementDictionary.Add(XName.Get("MD_RestrictionCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode));
            elementDictionary.Add(XName.Get("MD_Medium", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Medium));
            elementDictionary.Add(XName.Get("MD_DigitalTransferOptions", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions));
            elementDictionary.Add(XName.Get("MD_StandardOrderProcess", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess));
            elementDictionary.Add(XName.Get("MD_Distributor", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor));
            elementDictionary.Add(XName.Get("MD_Distribution", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution));
            elementDictionary.Add(XName.Get("MD_Format", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Format));
            elementDictionary.Add(XName.Get("MD_DistributionUnits", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits));
            elementDictionary.Add(XName.Get("MD_MediumFormatCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode));
            elementDictionary.Add(XName.Get("MD_MediumNameCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode));
            elementDictionary.Add(XName.Get("MD_MaintenanceInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation));
            elementDictionary.Add(XName.Get("MD_ScopeDescription", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription));
            elementDictionary.Add(XName.Get("MD_MaintenanceFrequencyCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode));
            elementDictionary.Add(XName.Get("MD_ScopeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode));
            elementDictionary.Add(XName.Get("AbstractMD_Identification", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification));
            elementDictionary.Add(XName.Get("MD_BrowseGraphic", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic));
            elementDictionary.Add(XName.Get("MD_DataIdentification", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification));
            elementDictionary.Add(XName.Get("MD_ServiceIdentification", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification));
            elementDictionary.Add(XName.Get("MD_RepresentativeFraction", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction));
            elementDictionary.Add(XName.Get("MD_Usage", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Usage));
            elementDictionary.Add(XName.Get("MD_Keywords", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords));
            elementDictionary.Add(XName.Get("DS_Association", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Association));
            elementDictionary.Add(XName.Get("MD_AggregateInformation", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation));
            elementDictionary.Add(XName.Get("MD_Resolution", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution));
            elementDictionary.Add(XName.Get("MD_TopicCategoryCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_TopicCategoryCode));
            elementDictionary.Add(XName.Get("MD_CharacterSetCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode));
            elementDictionary.Add(XName.Get("MD_SpatialRepresentationTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode));
            elementDictionary.Add(XName.Get("MD_ProgressCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode));
            elementDictionary.Add(XName.Get("MD_KeywordTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode));
            elementDictionary.Add(XName.Get("DS_AssociationTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode));
            elementDictionary.Add(XName.Get("DS_InitiativeTypeCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode));
            elementDictionary.Add(XName.Get("PT_FreeText", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText));
            elementDictionary.Add(XName.Get("PT_Locale", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_Locale));
            elementDictionary.Add(XName.Get("LocalisedCharacterString", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString));
            elementDictionary.Add(XName.Get("PT_LocaleContainer", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer));
            elementDictionary.Add(XName.Get("LanguageCode", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.LanguageCode));
            elementDictionary.Add(XName.Get("Country", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.Country));
            elementDictionary.Add(XName.Get("MD_Metadata", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata));
            elementDictionary.Add(XName.Get("AbstractDS_Aggregate", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate));
            elementDictionary.Add(XName.Get("DS_DataSet", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet));
            elementDictionary.Add(XName.Get("DS_OtherAggregate", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate));
            elementDictionary.Add(XName.Get("DS_Series", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Series));
            elementDictionary.Add(XName.Get("DS_Initiative", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative));
            elementDictionary.Add(XName.Get("DS_Platform", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Platform));
            elementDictionary.Add(XName.Get("DS_Sensor", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor));
            elementDictionary.Add(XName.Get("DS_ProductionSeries", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries));
            elementDictionary.Add(XName.Get("DS_StereoMate", "http://www.isotc211.org/2005/gmd"), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate));
            elementDictionary.Add(XName.Get("AbstractObject", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.AbstractObject));
            elementDictionary.Add(XName.Get("TypeName", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.TypeName));
            elementDictionary.Add(XName.Get("MemberName", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MemberName));
            elementDictionary.Add(XName.Get("Multiplicity", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Multiplicity));
            elementDictionary.Add(XName.Get("MultiplicityRange", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange));
            elementDictionary.Add(XName.Get("Measure", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Measure));
            elementDictionary.Add(XName.Get("Length", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Length));
            elementDictionary.Add(XName.Get("Angle", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Angle));
            elementDictionary.Add(XName.Get("Scale", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Scale));
            elementDictionary.Add(XName.Get("Distance", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Distance));
            elementDictionary.Add(XName.Get("CharacterString", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.CharacterString));
            elementDictionary.Add(XName.Get("Boolean", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Boolean));
            elementDictionary.Add(XName.Get("AbstractGenericName", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName));
            elementDictionary.Add(XName.Get("LocalName", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.LocalName));
            elementDictionary.Add(XName.Get("ScopedName", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.ScopedName));
            elementDictionary.Add(XName.Get("DateTime", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.DateTime));
            elementDictionary.Add(XName.Get("Date", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Date));
            elementDictionary.Add(XName.Get("Decimal", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.@Decimal));
            elementDictionary.Add(XName.Get("Real", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Real));
            elementDictionary.Add(XName.Get("Integer", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Integer));
            elementDictionary.Add(XName.Get("UnlimitedInteger", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger));
            elementDictionary.Add(XName.Get("RecordType", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.RecordType));
            elementDictionary.Add(XName.Get("Binary", "http://www.isotc211.org/2005/gco"), typeof(global::GeoSik.Iso.Ts19139.Gco.Binary));
            elementDictionary.Add(XName.Get("AbstractGML", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGML));
            elementDictionary.Add(XName.Get("abstractAssociationRole", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.abstractAssociationRole));
            elementDictionary.Add(XName.Get("abstractStrictAssociationRole", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.abstractStrictAssociationRole));
            elementDictionary.Add(XName.Get("abstractReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.abstractReference));
            elementDictionary.Add(XName.Get("abstractInlineProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.abstractInlineProperty));
            elementDictionary.Add(XName.Get("reversePropertyName", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.reversePropertyName));
            elementDictionary.Add(XName.Get("description", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.description));
            elementDictionary.Add(XName.Get("descriptionReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.descriptionReference));
            elementDictionary.Add(XName.Get("name", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.name));
            elementDictionary.Add(XName.Get("identifier", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.identifier));
            elementDictionary.Add(XName.Get("targetElement", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.targetElement));
            elementDictionary.Add(XName.Get("associationName", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.associationName));
            elementDictionary.Add(XName.Get("defaultCodeSpace", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.defaultCodeSpace));
            elementDictionary.Add(XName.Get("gmlProfileSchema", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.gmlProfileSchema));
            elementDictionary.Add(XName.Get("Definition", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Definition));
            elementDictionary.Add(XName.Get("remarks", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.remarks));
            elementDictionary.Add(XName.Get("Dictionary", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Dictionary));
            elementDictionary.Add(XName.Get("dictionaryEntry", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dictionaryEntry));
            elementDictionary.Add(XName.Get("unitOfMeasure", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.unitOfMeasure));
            elementDictionary.Add(XName.Get("UnitDefinition", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UnitDefinition));
            elementDictionary.Add(XName.Get("quantityType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.quantityType));
            elementDictionary.Add(XName.Get("quantityTypeReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.quantityTypeReference));
            elementDictionary.Add(XName.Get("catalogSymbol", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.catalogSymbol));
            elementDictionary.Add(XName.Get("BaseUnit", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BaseUnit));
            elementDictionary.Add(XName.Get("DerivedUnit", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivedUnit));
            elementDictionary.Add(XName.Get("derivationUnitTerm", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.derivationUnitTerm));
            elementDictionary.Add(XName.Get("ConventionalUnit", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConventionalUnit));
            elementDictionary.Add(XName.Get("conversionToPreferredUnit", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.conversionToPreferredUnit));
            elementDictionary.Add(XName.Get("roughConversionToPreferredUnit", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.roughConversionToPreferredUnit));
            elementDictionary.Add(XName.Get("measure", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.measure));
            elementDictionary.Add(XName.Get("angle", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.angle));
            elementDictionary.Add(XName.Get("AbstractGeometry", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometry));
            elementDictionary.Add(XName.Get("pos", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pos));
            elementDictionary.Add(XName.Get("posList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.posList));
            elementDictionary.Add(XName.Get("vector", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.vector));
            elementDictionary.Add(XName.Get("Envelope", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Envelope));
            elementDictionary.Add(XName.Get("AbstractGeometricPrimitive", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitive));
            elementDictionary.Add(XName.Get("Point", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Point));
            elementDictionary.Add(XName.Get("pointProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pointProperty));
            elementDictionary.Add(XName.Get("AbstractCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurve));
            elementDictionary.Add(XName.Get("curveProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.curveProperty));
            elementDictionary.Add(XName.Get("LineString", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LineString));
            elementDictionary.Add(XName.Get("AbstractSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurface));
            elementDictionary.Add(XName.Get("surfaceProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.surfaceProperty));
            elementDictionary.Add(XName.Get("Polygon", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Polygon));
            elementDictionary.Add(XName.Get("exterior", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.exterior));
            elementDictionary.Add(XName.Get("interior", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.interior));
            elementDictionary.Add(XName.Get("AbstractRing", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRing));
            elementDictionary.Add(XName.Get("LinearRing", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearRing));
            elementDictionary.Add(XName.Get("Curve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Curve));
            elementDictionary.Add(XName.Get("baseCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.baseCurve));
            elementDictionary.Add(XName.Get("OrientableCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OrientableCurve));
            elementDictionary.Add(XName.Get("AbstractCurveSegment", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurveSegment));
            elementDictionary.Add(XName.Get("segments", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.segments));
            elementDictionary.Add(XName.Get("LineStringSegment", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LineStringSegment));
            elementDictionary.Add(XName.Get("ArcString", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcString));
            elementDictionary.Add(XName.Get("Arc", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Arc));
            elementDictionary.Add(XName.Get("Circle", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Circle));
            elementDictionary.Add(XName.Get("ArcStringByBulge", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcStringByBulge));
            elementDictionary.Add(XName.Get("ArcByBulge", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcByBulge));
            elementDictionary.Add(XName.Get("ArcByCenterPoint", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ArcByCenterPoint));
            elementDictionary.Add(XName.Get("CircleByCenterPoint", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CircleByCenterPoint));
            elementDictionary.Add(XName.Get("CubicSpline", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CubicSpline));
            elementDictionary.Add(XName.Get("BSpline", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BSpline));
            elementDictionary.Add(XName.Get("Bezier", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Bezier));
            elementDictionary.Add(XName.Get("OffsetCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OffsetCurve));
            elementDictionary.Add(XName.Get("AffinePlacement", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AffinePlacement));
            elementDictionary.Add(XName.Get("Clothoid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Clothoid));
            elementDictionary.Add(XName.Get("GeodesicString", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodesicString));
            elementDictionary.Add(XName.Get("Geodesic", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Geodesic));
            elementDictionary.Add(XName.Get("Surface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Surface));
            elementDictionary.Add(XName.Get("baseSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.baseSurface));
            elementDictionary.Add(XName.Get("OrientableSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OrientableSurface));
            elementDictionary.Add(XName.Get("AbstractSurfacePatch", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatch));
            elementDictionary.Add(XName.Get("patches", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.patches));
            elementDictionary.Add(XName.Get("PolygonPatch", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolygonPatch));
            elementDictionary.Add(XName.Get("Triangle", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Triangle));
            elementDictionary.Add(XName.Get("Rectangle", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Rectangle));
            elementDictionary.Add(XName.Get("Ring", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Ring));
            elementDictionary.Add(XName.Get("curveMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.curveMember));
            elementDictionary.Add(XName.Get("AbstractParametricCurveSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurface));
            elementDictionary.Add(XName.Get("AbstractGriddedSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurface));
            elementDictionary.Add(XName.Get("Cone", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Cone));
            elementDictionary.Add(XName.Get("Cylinder", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Cylinder));
            elementDictionary.Add(XName.Get("Sphere", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Sphere));
            elementDictionary.Add(XName.Get("PolyhedralSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolyhedralSurface));
            elementDictionary.Add(XName.Get("TriangulatedSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TriangulatedSurface));
            elementDictionary.Add(XName.Get("Tin", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Tin));
            elementDictionary.Add(XName.Get("AbstractSolid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSolid));
            elementDictionary.Add(XName.Get("solidProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.solidProperty));
            elementDictionary.Add(XName.Get("Solid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Solid));
            elementDictionary.Add(XName.Get("Shell", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Shell));
            elementDictionary.Add(XName.Get("surfaceMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.surfaceMember));
            elementDictionary.Add(XName.Get("AbstractGeometricAggregate", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregate));
            elementDictionary.Add(XName.Get("MultiGeometry", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiGeometry));
            elementDictionary.Add(XName.Get("geometryMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geometryMember));
            elementDictionary.Add(XName.Get("geometryMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geometryMembers));
            elementDictionary.Add(XName.Get("MultiPoint", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiPoint));
            elementDictionary.Add(XName.Get("pointMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pointMember));
            elementDictionary.Add(XName.Get("pointMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pointMembers));
            elementDictionary.Add(XName.Get("MultiCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurve));
            elementDictionary.Add(XName.Get("curveMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.curveMembers));
            elementDictionary.Add(XName.Get("MultiSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurface));
            elementDictionary.Add(XName.Get("surfaceMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.surfaceMembers));
            elementDictionary.Add(XName.Get("MultiSolid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolid));
            elementDictionary.Add(XName.Get("solidMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.solidMember));
            elementDictionary.Add(XName.Get("solidMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.solidMembers));
            elementDictionary.Add(XName.Get("AbstractTimeObject", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeObject));
            elementDictionary.Add(XName.Get("AbstractTimePrimitive", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitive));
            elementDictionary.Add(XName.Get("validTime", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.validTime));
            elementDictionary.Add(XName.Get("AbstractTimeComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeComplex));
            elementDictionary.Add(XName.Get("AbstractTimeGeometricPrimitive", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitive));
            elementDictionary.Add(XName.Get("TimeInstant", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeInstant));
            elementDictionary.Add(XName.Get("TimePeriod", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimePeriod));
            elementDictionary.Add(XName.Get("timePosition", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.timePosition));
            elementDictionary.Add(XName.Get("duration", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.duration));
            elementDictionary.Add(XName.Get("timeInterval", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.timeInterval));
            elementDictionary.Add(XName.Get("AbstractFeature", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeature));
            elementDictionary.Add(XName.Get("boundedBy", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.boundedBy));
            elementDictionary.Add(XName.Get("EnvelopeWithTimePeriod", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriod));
            elementDictionary.Add(XName.Get("locationName", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.locationName));
            elementDictionary.Add(XName.Get("locationReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.locationReference));
            elementDictionary.Add(XName.Get("direction", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.direction));
            elementDictionary.Add(XName.Get("dataSource", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dataSource));
            elementDictionary.Add(XName.Get("dataSourceReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dataSourceReference));
            elementDictionary.Add(XName.Get("DynamicFeature", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeature));
            elementDictionary.Add(XName.Get("DynamicFeatureCollection", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollection));
            elementDictionary.Add(XName.Get("dynamicMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dynamicMembers));
            elementDictionary.Add(XName.Get("AbstractTimeSlice", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeSlice));
            elementDictionary.Add(XName.Get("history", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.history));
            elementDictionary.Add(XName.Get("GeometricComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeometricComplex));
            elementDictionary.Add(XName.Get("CompositeCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeCurve));
            elementDictionary.Add(XName.Get("CompositeSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSurface));
            elementDictionary.Add(XName.Get("CompositeSolid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSolid));
            elementDictionary.Add(XName.Get("AbstractTopology", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopology));
            elementDictionary.Add(XName.Get("AbstractTopoPrimitive", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitive));
            elementDictionary.Add(XName.Get("Node", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Node));
            elementDictionary.Add(XName.Get("directedNode", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.directedNode));
            elementDictionary.Add(XName.Get("Edge", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Edge));
            elementDictionary.Add(XName.Get("directedEdge", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.directedEdge));
            elementDictionary.Add(XName.Get("Face", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Face));
            elementDictionary.Add(XName.Get("directedFace", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.directedFace));
            elementDictionary.Add(XName.Get("TopoSolid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSolid));
            elementDictionary.Add(XName.Get("directedTopoSolid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.directedTopoSolid));
            elementDictionary.Add(XName.Get("TopoPoint", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoPoint));
            elementDictionary.Add(XName.Get("topoPointProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoPointProperty));
            elementDictionary.Add(XName.Get("TopoCurve", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoCurve));
            elementDictionary.Add(XName.Get("topoCurveProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoCurveProperty));
            elementDictionary.Add(XName.Get("TopoSurface", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoSurface));
            elementDictionary.Add(XName.Get("topoSurfaceProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoSurfaceProperty));
            elementDictionary.Add(XName.Get("TopoVolume", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoVolume));
            elementDictionary.Add(XName.Get("topoVolumeProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoVolumeProperty));
            elementDictionary.Add(XName.Get("TopoComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplex));
            elementDictionary.Add(XName.Get("subComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.subComplex));
            elementDictionary.Add(XName.Get("superComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.superComplex));
            elementDictionary.Add(XName.Get("maximalComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.maximalComplex));
            elementDictionary.Add(XName.Get("topoPrimitiveMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoPrimitiveMember));
            elementDictionary.Add(XName.Get("topoPrimitiveMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoPrimitiveMembers));
            elementDictionary.Add(XName.Get("BooleanList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.BooleanList));
            elementDictionary.Add(XName.Get("CategoryList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CategoryList));
            elementDictionary.Add(XName.Get("CountList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CountList));
            elementDictionary.Add(XName.Get("QuantityList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.QuantityList));
            elementDictionary.Add(XName.Get("valueProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueProperty));
            elementDictionary.Add(XName.Get("valueComponent", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueComponent));
            elementDictionary.Add(XName.Get("valueComponents", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueComponents));
            elementDictionary.Add(XName.Get("CompositeValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompositeValue));
            elementDictionary.Add(XName.Get("ValueArray", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ValueArray));
            elementDictionary.Add(XName.Get("CategoryExtent", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CategoryExtent));
            elementDictionary.Add(XName.Get("CountExtent", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CountExtent));
            elementDictionary.Add(XName.Get("QuantityExtent", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.QuantityExtent));
            elementDictionary.Add(XName.Get("Grid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Grid));
            elementDictionary.Add(XName.Get("AbstractImplicitGeometry", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractImplicitGeometry));
            elementDictionary.Add(XName.Get("RectifiedGrid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RectifiedGrid));
            elementDictionary.Add(XName.Get("AbstractCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoverage));
            elementDictionary.Add(XName.Get("AbstractDiscreteCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractDiscreteCoverage));
            elementDictionary.Add(XName.Get("AbstractContinuousCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverage));
            elementDictionary.Add(XName.Get("domainSet", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.domainSet));
            elementDictionary.Add(XName.Get("rangeSet", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.rangeSet));
            elementDictionary.Add(XName.Get("DataBlock", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DataBlock));
            elementDictionary.Add(XName.Get("rangeParameters", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.rangeParameters));
            elementDictionary.Add(XName.Get("tupleList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.tupleList));
            elementDictionary.Add(XName.Get("doubleOrNilReasonTupleList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.doubleOrNilReasonTupleList));
            elementDictionary.Add(XName.Get("File", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.File));
            elementDictionary.Add(XName.Get("coverageFunction", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coverageFunction));
            elementDictionary.Add(XName.Get("CoverageMappingRule", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoverageMappingRule));
            elementDictionary.Add(XName.Get("GridFunction", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridFunction));
            elementDictionary.Add(XName.Get("MultiPointCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointCoverage));
            elementDictionary.Add(XName.Get("MultiCurveCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurveCoverage));
            elementDictionary.Add(XName.Get("MultiSurfaceCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfaceCoverage));
            elementDictionary.Add(XName.Get("MultiSolidCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolidCoverage));
            elementDictionary.Add(XName.Get("GridCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GridCoverage));
            elementDictionary.Add(XName.Get("RectifiedGridCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.RectifiedGridCoverage));
            elementDictionary.Add(XName.Get("AbstractCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCRS));
            elementDictionary.Add(XName.Get("scope", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.scope));
            elementDictionary.Add(XName.Get("CoordinateSystemAxis", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxis));
            elementDictionary.Add(XName.Get("axisAbbrev", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.axisAbbrev));
            elementDictionary.Add(XName.Get("axisDirection", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.axisDirection));
            elementDictionary.Add(XName.Get("minimumValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.minimumValue));
            elementDictionary.Add(XName.Get("maximumValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.maximumValue));
            elementDictionary.Add(XName.Get("rangeMeaning", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.rangeMeaning));
            elementDictionary.Add(XName.Get("AbstractCoordinateSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystem));
            elementDictionary.Add(XName.Get("axis", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.axis));
            elementDictionary.Add(XName.Get("EllipsoidalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCS));
            elementDictionary.Add(XName.Get("CartesianCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCS));
            elementDictionary.Add(XName.Get("VerticalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCS));
            elementDictionary.Add(XName.Get("TimeCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCS));
            elementDictionary.Add(XName.Get("LinearCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LinearCS));
            elementDictionary.Add(XName.Get("UserDefinedCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCS));
            elementDictionary.Add(XName.Get("SphericalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCS));
            elementDictionary.Add(XName.Get("PolarCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PolarCS));
            elementDictionary.Add(XName.Get("CylindricalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCS));
            elementDictionary.Add(XName.Get("AffineCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AffineCS));
            elementDictionary.Add(XName.Get("AbstractDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractDatum));
            elementDictionary.Add(XName.Get("anchorDefinition", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.anchorDefinition));
            elementDictionary.Add(XName.Get("realizationEpoch", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.realizationEpoch));
            elementDictionary.Add(XName.Get("GeodeticDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatum));
            elementDictionary.Add(XName.Get("primeMeridian", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.primeMeridian));
            elementDictionary.Add(XName.Get("ellipsoid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ellipsoid));
            elementDictionary.Add(XName.Get("Ellipsoid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Ellipsoid1));
            elementDictionary.Add(XName.Get("semiMajorAxis", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.semiMajorAxis));
            elementDictionary.Add(XName.Get("PrimeMeridian", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridian1));
            elementDictionary.Add(XName.Get("greenwichLongitude", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.greenwichLongitude));
            elementDictionary.Add(XName.Get("EngineeringDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatum));
            elementDictionary.Add(XName.Get("ImageDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatum));
            elementDictionary.Add(XName.Get("pixelInCell", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pixelInCell));
            elementDictionary.Add(XName.Get("VerticalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatum));
            elementDictionary.Add(XName.Get("TemporalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatum));
            elementDictionary.Add(XName.Get("origin", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.origin));
            elementDictionary.Add(XName.Get("AbstractCoordinateOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperation));
            elementDictionary.Add(XName.Get("operationVersion", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationVersion));
            elementDictionary.Add(XName.Get("sourceCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.sourceCRS));
            elementDictionary.Add(XName.Get("targetCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.targetCRS));
            elementDictionary.Add(XName.Get("AbstractSingleOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSingleOperation));
            elementDictionary.Add(XName.Get("AbstractGeneralConversion", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversion));
            elementDictionary.Add(XName.Get("AbstractGeneralTransformation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformation));
            elementDictionary.Add(XName.Get("ConcatenatedOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperation));
            elementDictionary.Add(XName.Get("coordOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordOperation));
            elementDictionary.Add(XName.Get("PassThroughOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.PassThroughOperation));
            elementDictionary.Add(XName.Get("modifiedCoordinate", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.modifiedCoordinate));
            elementDictionary.Add(XName.Get("Conversion", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Conversion));
            elementDictionary.Add(XName.Get("method", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.method));
            elementDictionary.Add(XName.Get("parameterValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.parameterValue));
            elementDictionary.Add(XName.Get("Transformation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Transformation));
            elementDictionary.Add(XName.Get("AbstractGeneralParameterValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValue));
            elementDictionary.Add(XName.Get("ParameterValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValue1));
            elementDictionary.Add(XName.Get("value", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.value));
            elementDictionary.Add(XName.Get("stringValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.stringValue));
            elementDictionary.Add(XName.Get("integerValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.integerValue));
            elementDictionary.Add(XName.Get("booleanValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.booleanValue));
            elementDictionary.Add(XName.Get("valueList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueList));
            elementDictionary.Add(XName.Get("integerValueList", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.integerValueList));
            elementDictionary.Add(XName.Get("valueFile", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueFile));
            elementDictionary.Add(XName.Get("operationParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationParameter));
            elementDictionary.Add(XName.Get("ParameterValueGroup", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValueGroup));
            elementDictionary.Add(XName.Get("group", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.group));
            elementDictionary.Add(XName.Get("OperationMethod", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethod));
            elementDictionary.Add(XName.Get("formula", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.formula));
            elementDictionary.Add(XName.Get("sourceDimensions", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.sourceDimensions));
            elementDictionary.Add(XName.Get("targetDimensions", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.targetDimensions));
            elementDictionary.Add(XName.Get("parameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.parameter));
            elementDictionary.Add(XName.Get("AbstractGeneralOperationParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameter));
            elementDictionary.Add(XName.Get("minimumOccurs", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.minimumOccurs));
            elementDictionary.Add(XName.Get("OperationParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameter1));
            elementDictionary.Add(XName.Get("OperationParameterGroup", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroup));
            elementDictionary.Add(XName.Get("maximumOccurs", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.maximumOccurs));
            elementDictionary.Add(XName.Get("AbstractSingleCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSingleCRS));
            elementDictionary.Add(XName.Get("AbstractGeneralDerivedCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRS));
            elementDictionary.Add(XName.Get("conversion", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.conversion1));
            elementDictionary.Add(XName.Get("CompoundCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.CompoundCRS));
            elementDictionary.Add(XName.Get("componentReferenceSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.componentReferenceSystem));
            elementDictionary.Add(XName.Get("GeodeticCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticCRS));
            elementDictionary.Add(XName.Get("ellipsoidalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ellipsoidalCS1));
            elementDictionary.Add(XName.Get("cartesianCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.cartesianCS1));
            elementDictionary.Add(XName.Get("sphericalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.sphericalCS1));
            elementDictionary.Add(XName.Get("geodeticDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geodeticDatum1));
            elementDictionary.Add(XName.Get("VerticalCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCRS));
            elementDictionary.Add(XName.Get("verticalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.verticalCS1));
            elementDictionary.Add(XName.Get("verticalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.verticalDatum1));
            elementDictionary.Add(XName.Get("ProjectedCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ProjectedCRS));
            elementDictionary.Add(XName.Get("baseGeodeticCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.baseGeodeticCRS));
            elementDictionary.Add(XName.Get("DerivedCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DerivedCRS));
            elementDictionary.Add(XName.Get("baseCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.baseCRS));
            elementDictionary.Add(XName.Get("derivedCRSType", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.derivedCRSType));
            elementDictionary.Add(XName.Get("coordinateSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinateSystem));
            elementDictionary.Add(XName.Get("EngineeringCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringCRS));
            elementDictionary.Add(XName.Get("cylindricalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.cylindricalCS1));
            elementDictionary.Add(XName.Get("linearCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.linearCS1));
            elementDictionary.Add(XName.Get("polarCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.polarCS1));
            elementDictionary.Add(XName.Get("userDefinedCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.userDefinedCS1));
            elementDictionary.Add(XName.Get("engineeringDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.engineeringDatum1));
            elementDictionary.Add(XName.Get("ImageCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ImageCRS));
            elementDictionary.Add(XName.Get("affineCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.affineCS1));
            elementDictionary.Add(XName.Get("imageDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.imageDatum1));
            elementDictionary.Add(XName.Get("TemporalCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCRS));
            elementDictionary.Add(XName.Get("timeCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.timeCS1));
            elementDictionary.Add(XName.Get("temporalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.temporalDatum1));
            elementDictionary.Add(XName.Get("Observation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Observation));
            elementDictionary.Add(XName.Get("using", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.@using));
            elementDictionary.Add(XName.Get("target", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.target));
            elementDictionary.Add(XName.Get("subject", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.subject));
            elementDictionary.Add(XName.Get("resultOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.resultOf));
            elementDictionary.Add(XName.Get("DirectedObservation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservation));
            elementDictionary.Add(XName.Get("DirectedObservationAtDistance", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistance));
            elementDictionary.Add(XName.Get("AbstractTimeTopologyPrimitive", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitive));
            elementDictionary.Add(XName.Get("TimeTopologyComplex", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeTopologyComplex));
            elementDictionary.Add(XName.Get("TimeNode", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeNode));
            elementDictionary.Add(XName.Get("TimeEdge", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeEdge));
            elementDictionary.Add(XName.Get("TimeReferenceSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeReferenceSystem));
            elementDictionary.Add(XName.Get("TimeCoordinateSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystem));
            elementDictionary.Add(XName.Get("TimeCalendar", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendar));
            elementDictionary.Add(XName.Get("TimeCalendarEra", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarEra));
            elementDictionary.Add(XName.Get("TimeClock", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeClock));
            elementDictionary.Add(XName.Get("TimeOrdinalReferenceSystem", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystem));
            elementDictionary.Add(XName.Get("TimeOrdinalEra", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalEra));
            elementDictionary.Add(XName.Get("Null", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.@Null));
            elementDictionary.Add(XName.Get("anchorPoint", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.anchorPoint));
            elementDictionary.Add(XName.Get("datumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.datumRef));
            elementDictionary.Add(XName.Get("usesPrimeMeridian", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesPrimeMeridian));
            elementDictionary.Add(XName.Get("usesEllipsoid", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesEllipsoid));
            elementDictionary.Add(XName.Get("geodeticDatumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geodeticDatumRef));
            elementDictionary.Add(XName.Get("ellipsoidRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ellipsoidRef));
            elementDictionary.Add(XName.Get("primeMeridianRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.primeMeridianRef));
            elementDictionary.Add(XName.Get("engineeringDatumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.engineeringDatumRef));
            elementDictionary.Add(XName.Get("imageDatumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.imageDatumRef));
            elementDictionary.Add(XName.Get("verticalDatumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.verticalDatumRef));
            elementDictionary.Add(XName.Get("temporalDatumRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.temporalDatumRef));
            elementDictionary.Add(XName.Get("coordinateOperationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinateOperationRef));
            elementDictionary.Add(XName.Get("singleOperationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.singleOperationRef));
            elementDictionary.Add(XName.Get("AbstractOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractOperation));
            elementDictionary.Add(XName.Get("operationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationRef));
            elementDictionary.Add(XName.Get("generalConversionRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.generalConversionRef));
            elementDictionary.Add(XName.Get("generalTransformationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.generalTransformationRef));
            elementDictionary.Add(XName.Get("usesSingleOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesSingleOperation));
            elementDictionary.Add(XName.Get("concatenatedOperationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.concatenatedOperationRef));
            elementDictionary.Add(XName.Get("usesOperation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesOperation));
            elementDictionary.Add(XName.Get("passThroughOperationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.passThroughOperationRef));
            elementDictionary.Add(XName.Get("usesMethod", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesMethod));
            elementDictionary.Add(XName.Get("usesValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesValue));
            elementDictionary.Add(XName.Get("conversionRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.conversionRef));
            elementDictionary.Add(XName.Get("transformationRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.transformationRef));
            elementDictionary.Add(XName.Get("dmsAngleValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dmsAngleValue));
            elementDictionary.Add(XName.Get("valueOfParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valueOfParameter));
            elementDictionary.Add(XName.Get("includesValue", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.includesValue));
            elementDictionary.Add(XName.Get("valuesOfGroup", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.valuesOfGroup));
            elementDictionary.Add(XName.Get("methodFormula", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.methodFormula));
            elementDictionary.Add(XName.Get("usesParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesParameter));
            elementDictionary.Add(XName.Get("operationMethodRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationMethodRef));
            elementDictionary.Add(XName.Get("abstractGeneralOperationParameterRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.abstractGeneralOperationParameterRef));
            elementDictionary.Add(XName.Get("operationParameterRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationParameterRef));
            elementDictionary.Add(XName.Get("includesParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.includesParameter));
            elementDictionary.Add(XName.Get("operationParameterGroupRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.operationParameterGroupRef));
            elementDictionary.Add(XName.Get("referenceSystemRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.referenceSystemRef));
            elementDictionary.Add(XName.Get("crsRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.crsRef));
            elementDictionary.Add(XName.Get("coordinateSystemAxisRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinateSystemAxisRef));
            elementDictionary.Add(XName.Get("usesAxis", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesAxis));
            elementDictionary.Add(XName.Get("coordinateSystemRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinateSystemRef));
            elementDictionary.Add(XName.Get("ellipsoidalCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ellipsoidalCSRef));
            elementDictionary.Add(XName.Get("cartesianCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.cartesianCSRef));
            elementDictionary.Add(XName.Get("verticalCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.verticalCSRef));
            elementDictionary.Add(XName.Get("TemporalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCS));
            elementDictionary.Add(XName.Get("temporalCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.temporalCSRef));
            elementDictionary.Add(XName.Get("linearCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.linearCSRef));
            elementDictionary.Add(XName.Get("userDefinedCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.userDefinedCSRef));
            elementDictionary.Add(XName.Get("sphericalCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.sphericalCSRef));
            elementDictionary.Add(XName.Get("polarCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.polarCSRef));
            elementDictionary.Add(XName.Get("cylindricalCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.cylindricalCSRef));
            elementDictionary.Add(XName.Get("ObliqueCartesianCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCS));
            elementDictionary.Add(XName.Get("obliqueCartesianCSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.obliqueCartesianCSRef));
            elementDictionary.Add(XName.Get("singleCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.singleCRSRef));
            elementDictionary.Add(XName.Get("definedByConversion", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.definedByConversion));
            elementDictionary.Add(XName.Get("includesSingleCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.includesSingleCRS));
            elementDictionary.Add(XName.Get("compoundCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.compoundCRSRef));
            elementDictionary.Add(XName.Get("usesEllipsoidalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesEllipsoidalCS));
            elementDictionary.Add(XName.Get("usesCartesianCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesCartesianCS));
            elementDictionary.Add(XName.Get("usesSphericalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesSphericalCS));
            elementDictionary.Add(XName.Get("usesGeodeticDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesGeodeticDatum));
            elementDictionary.Add(XName.Get("usesVerticalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesVerticalCS));
            elementDictionary.Add(XName.Get("usesVerticalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesVerticalDatum));
            elementDictionary.Add(XName.Get("verticalCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.verticalCRSRef));
            elementDictionary.Add(XName.Get("baseGeographicCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.baseGeographicCRS));
            elementDictionary.Add(XName.Get("projectedCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.projectedCRSRef));
            elementDictionary.Add(XName.Get("usesCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesCS));
            elementDictionary.Add(XName.Get("derivedCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.derivedCRSRef));
            elementDictionary.Add(XName.Get("usesEngineeringDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesEngineeringDatum));
            elementDictionary.Add(XName.Get("engineeringCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.engineeringCRSRef));
            elementDictionary.Add(XName.Get("usesAffineCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesAffineCS));
            elementDictionary.Add(XName.Get("usesImageDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesImageDatum));
            elementDictionary.Add(XName.Get("usesObliqueCartesianCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesObliqueCartesianCS));
            elementDictionary.Add(XName.Get("imageCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.imageCRSRef));
            elementDictionary.Add(XName.Get("usesTimeCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesTimeCS));
            elementDictionary.Add(XName.Get("usesTemporalCS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesTemporalCS));
            elementDictionary.Add(XName.Get("usesTemporalDatum", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.usesTemporalDatum));
            elementDictionary.Add(XName.Get("temporalCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.temporalCRSRef));
            elementDictionary.Add(XName.Get("GeographicCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRS));
            elementDictionary.Add(XName.Get("geographicCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geographicCRSRef));
            elementDictionary.Add(XName.Get("GeocentricCRS", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GeocentricCRS));
            elementDictionary.Add(XName.Get("geocentricCRSRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.geocentricCRSRef));
            elementDictionary.Add(XName.Get("dmsAngle", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.dmsAngle));
            elementDictionary.Add(XName.Get("degrees", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.degrees));
            elementDictionary.Add(XName.Get("decimalMinutes", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.decimalMinutes));
            elementDictionary.Add(XName.Get("minutes", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.minutes));
            elementDictionary.Add(XName.Get("seconds", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.seconds));
            elementDictionary.Add(XName.Get("member", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.member));
            elementDictionary.Add(XName.Get("members", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.members));
            elementDictionary.Add(XName.Get("metaDataProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.metaDataProperty));
            elementDictionary.Add(XName.Get("Bag", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Bag));
            elementDictionary.Add(XName.Get("Array", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.Array));
            elementDictionary.Add(XName.Get("AbstractMetaData", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractMetaData));
            elementDictionary.Add(XName.Get("GenericMetaData", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.GenericMetaData));
            elementDictionary.Add(XName.Get("coordinates", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.coordinates));
            elementDictionary.Add(XName.Get("pointRep", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pointRep));
            elementDictionary.Add(XName.Get("location", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.location));
            elementDictionary.Add(XName.Get("LocationString", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LocationString));
            elementDictionary.Add(XName.Get("LocationKeyWord", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.LocationKeyWord));
            elementDictionary.Add(XName.Get("priorityLocation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.priorityLocation));
            elementDictionary.Add(XName.Get("featureMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.featureMember));
            elementDictionary.Add(XName.Get("featureProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.featureProperty));
            elementDictionary.Add(XName.Get("featureMembers", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.featureMembers));
            elementDictionary.Add(XName.Get("AbstractFeatureCollection", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollection));
            elementDictionary.Add(XName.Get("FeatureCollection", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.FeatureCollection));
            elementDictionary.Add(XName.Get("track", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.track));
            elementDictionary.Add(XName.Get("DefinitionCollection", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionCollection));
            elementDictionary.Add(XName.Get("definitionMember", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.definitionMember));
            elementDictionary.Add(XName.Get("indirectEntry", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.indirectEntry));
            elementDictionary.Add(XName.Get("DefinitionProxy", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionProxy));
            elementDictionary.Add(XName.Get("definitionRef", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.definitionRef));
            elementDictionary.Add(XName.Get("MappingRule", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MappingRule));
            elementDictionary.Add(XName.Get("centerOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.centerOf));
            elementDictionary.Add(XName.Get("position", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.position));
            elementDictionary.Add(XName.Get("extentOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.extentOf));
            elementDictionary.Add(XName.Get("edgeOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.edgeOf));
            elementDictionary.Add(XName.Get("centerLineOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.centerLineOf));
            elementDictionary.Add(XName.Get("multiLocation", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiLocation));
            elementDictionary.Add(XName.Get("multiCenterOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiCenterOf));
            elementDictionary.Add(XName.Get("multiPosition", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiPosition));
            elementDictionary.Add(XName.Get("multiCenterLineOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiCenterLineOf));
            elementDictionary.Add(XName.Get("multiEdgeOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiEdgeOf));
            elementDictionary.Add(XName.Get("multiCoverage", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiCoverage));
            elementDictionary.Add(XName.Get("multiExtentOf", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiExtentOf));
            elementDictionary.Add(XName.Get("polygonPatches", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.polygonPatches));
            elementDictionary.Add(XName.Get("trianglePatches", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.trianglePatches));
            elementDictionary.Add(XName.Get("multiPointDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiPointDomain));
            elementDictionary.Add(XName.Get("multiCurveDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiCurveDomain));
            elementDictionary.Add(XName.Get("multiSurfaceDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiSurfaceDomain));
            elementDictionary.Add(XName.Get("multiSolidDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiSolidDomain));
            elementDictionary.Add(XName.Get("gridDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.gridDomain));
            elementDictionary.Add(XName.Get("rectifiedGridDomain", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.rectifiedGridDomain));
            elementDictionary.Add(XName.Get("generalOperationParameter", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.generalOperationParameter));
            elementDictionary.Add(XName.Get("MovingObjectStatus", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.MovingObjectStatus));
            elementDictionary.Add(XName.Get("status", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.status));
            elementDictionary.Add(XName.Get("statusReference", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.statusReference));
            elementDictionary.Add(XName.Get("topoComplexProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.topoComplexProperty));
            elementDictionary.Add(XName.Get("multiPointProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiPointProperty));
            elementDictionary.Add(XName.Get("multiCurveProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiCurveProperty));
            elementDictionary.Add(XName.Get("multiSurfaceProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiSurfaceProperty));
            elementDictionary.Add(XName.Get("multiSolidProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiSolidProperty));
            elementDictionary.Add(XName.Get("multiGeometryProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.multiGeometryProperty));
            elementDictionary.Add(XName.Get("pointArrayProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.pointArrayProperty));
            elementDictionary.Add(XName.Get("curveArrayProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.curveArrayProperty));
            elementDictionary.Add(XName.Get("surfaceArrayProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.surfaceArrayProperty));
            elementDictionary.Add(XName.Get("solidArrayProperty", "http://www.opengis.net/gml/3.2"), typeof(global::GeoSik.Ogc.Gml.V321.solidArrayProperty));
            elementDictionary.Add(XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts"), typeof(global::GeoSik.Iso.Ts19139.Gts.TM_PeriodDuration));
        }

        private static void BuildWrapperDictionary()
        {
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_Extent), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_Extent_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription), typeof(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.RS_Identifier), typeof(global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Identifier), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Citation), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Citation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Address), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Address_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Contact), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Contact_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Telephone), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Date), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Date_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_Series), typeof(global::GeoSik.Iso.Ts19139.Gmd.CI_Series_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_RoleCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Dimension), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Georectified), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Band), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Band_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.LI_Source), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Source_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.LI_Lineage), typeof(global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_Scope), typeof(global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Constraints), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Medium), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Medium_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Distributor), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Distribution), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Format), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Format_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Usage), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Usage_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Keywords), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_Association), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Association_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Resolution), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.PT_FreeText), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.PT_Locale), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_Locale_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString), typeof(global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer), typeof(global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.LanguageCode), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.Country), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.MD_Metadata), typeof(global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate), typeof(global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_DataSet), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_Series), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Series_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_Initiative), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_Platform), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Platform_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_Sensor), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gmd.DS_StereoMate), typeof(global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.AbstractObject), typeof(global::GeoSik.Iso.Ts19139.Gco.AbstractObject_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.TypeName), typeof(global::GeoSik.Iso.Ts19139.Gco.TypeName_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.MemberName), typeof(global::GeoSik.Iso.Ts19139.Gco.MemberName_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Multiplicity), typeof(global::GeoSik.Iso.Ts19139.Gco.Multiplicity_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.MultiplicityRange), typeof(global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Measure), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Length), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Angle), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Scale), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Distance), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.AbstractGenericName), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.LocalName), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.ScopedName), typeof(void));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.UnlimitedInteger), typeof(global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.RecordType), typeof(global::GeoSik.Iso.Ts19139.Gco.RecordType_Type));
            wrapperDictionary.Add(typeof(GeoSik.Iso.Ts19139.Gco.Binary), typeof(global::GeoSik.Iso.Ts19139.Gco.Binary_Type));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGML), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGMLType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.abstractAssociationRole), typeof(global::GeoSik.Ogc.Gml.V321.AssociationRoleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.abstractStrictAssociationRole), typeof(global::GeoSik.Ogc.Gml.V321.AssociationRoleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.abstractReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.abstractInlineProperty), typeof(global::GeoSik.Ogc.Gml.V321.InlinePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.description), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.descriptionReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.name), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.identifier), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Definition), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Dictionary), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dictionaryEntry), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryEntryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.unitOfMeasure), typeof(global::GeoSik.Ogc.Gml.V321.UnitOfMeasureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.UnitDefinition), typeof(global::GeoSik.Ogc.Gml.V321.UnitDefinitionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.quantityType), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.quantityTypeReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.catalogSymbol), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.BaseUnit), typeof(global::GeoSik.Ogc.Gml.V321.BaseUnitType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DerivedUnit), typeof(global::GeoSik.Ogc.Gml.V321.DerivedUnitType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.derivationUnitTerm), typeof(global::GeoSik.Ogc.Gml.V321.DerivationUnitTermType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ConventionalUnit), typeof(global::GeoSik.Ogc.Gml.V321.ConventionalUnitType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.conversionToPreferredUnit), typeof(global::GeoSik.Ogc.Gml.V321.ConversionToPreferredUnitType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.roughConversionToPreferredUnit), typeof(global::GeoSik.Ogc.Gml.V321.ConversionToPreferredUnitType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.measure), typeof(global::GeoSik.Ogc.Gml.V321.MeasureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.angle), typeof(global::GeoSik.Ogc.Gml.V321.AngleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeometry), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pos), typeof(global::GeoSik.Ogc.Gml.V321.DirectPositionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.posList), typeof(global::GeoSik.Ogc.Gml.V321.DirectPositionListType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.vector), typeof(global::GeoSik.Ogc.Gml.V321.VectorType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Envelope), typeof(global::GeoSik.Ogc.Gml.V321.EnvelopeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitive), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitiveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Point), typeof(global::GeoSik.Ogc.Gml.V321.PointType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pointProperty), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCurve), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.curveProperty), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LineString), typeof(global::GeoSik.Ogc.Gml.V321.LineStringType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractSurface), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.surfaceProperty), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Polygon), typeof(global::GeoSik.Ogc.Gml.V321.PolygonType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.exterior), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.interior), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRingPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractRing), typeof(global::GeoSik.Ogc.Gml.V321.AbstractRingType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LinearRing), typeof(global::GeoSik.Ogc.Gml.V321.LinearRingType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Curve), typeof(global::GeoSik.Ogc.Gml.V321.CurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.baseCurve), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OrientableCurve), typeof(global::GeoSik.Ogc.Gml.V321.OrientableCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCurveSegment), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCurveSegmentType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.segments), typeof(global::GeoSik.Ogc.Gml.V321.CurveSegmentArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LineStringSegment), typeof(global::GeoSik.Ogc.Gml.V321.LineStringSegmentType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ArcString), typeof(global::GeoSik.Ogc.Gml.V321.ArcStringType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Arc), typeof(global::GeoSik.Ogc.Gml.V321.ArcType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Circle), typeof(global::GeoSik.Ogc.Gml.V321.CircleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ArcStringByBulge), typeof(global::GeoSik.Ogc.Gml.V321.ArcStringByBulgeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ArcByBulge), typeof(global::GeoSik.Ogc.Gml.V321.ArcByBulgeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ArcByCenterPoint), typeof(global::GeoSik.Ogc.Gml.V321.ArcByCenterPointType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CircleByCenterPoint), typeof(global::GeoSik.Ogc.Gml.V321.CircleByCenterPointType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CubicSpline), typeof(global::GeoSik.Ogc.Gml.V321.CubicSplineType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.BSpline), typeof(global::GeoSik.Ogc.Gml.V321.BSplineType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Bezier), typeof(global::GeoSik.Ogc.Gml.V321.BezierType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OffsetCurve), typeof(global::GeoSik.Ogc.Gml.V321.OffsetCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AffinePlacement), typeof(global::GeoSik.Ogc.Gml.V321.AffinePlacementType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Clothoid), typeof(global::GeoSik.Ogc.Gml.V321.ClothoidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeodesicString), typeof(global::GeoSik.Ogc.Gml.V321.GeodesicStringType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Geodesic), typeof(global::GeoSik.Ogc.Gml.V321.GeodesicType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Surface), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.baseSurface), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OrientableSurface), typeof(global::GeoSik.Ogc.Gml.V321.OrientableSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractSurfacePatch), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatchType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.patches), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePatchArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.PolygonPatch), typeof(global::GeoSik.Ogc.Gml.V321.PolygonPatchType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Triangle), typeof(global::GeoSik.Ogc.Gml.V321.TriangleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Rectangle), typeof(global::GeoSik.Ogc.Gml.V321.RectangleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Ring), typeof(global::GeoSik.Ogc.Gml.V321.RingType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.curveMember), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurface), typeof(global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGriddedSurface), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Cone), typeof(global::GeoSik.Ogc.Gml.V321.ConeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Cylinder), typeof(global::GeoSik.Ogc.Gml.V321.CylinderType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Sphere), typeof(global::GeoSik.Ogc.Gml.V321.SphereType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.PolyhedralSurface), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TriangulatedSurface), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Tin), typeof(global::GeoSik.Ogc.Gml.V321.TinType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractSolid), typeof(global::GeoSik.Ogc.Gml.V321.AbstractSolidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.solidProperty), typeof(global::GeoSik.Ogc.Gml.V321.SolidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Solid), typeof(global::GeoSik.Ogc.Gml.V321.SolidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Shell), typeof(global::GeoSik.Ogc.Gml.V321.ShellType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.surfaceMember), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeometricAggregate), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregateType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiGeometry), typeof(global::GeoSik.Ogc.Gml.V321.MultiGeometryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geometryMember), typeof(global::GeoSik.Ogc.Gml.V321.GeometryPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geometryMembers), typeof(global::GeoSik.Ogc.Gml.V321.GeometryArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiPoint), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pointMember), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pointMembers), typeof(global::GeoSik.Ogc.Gml.V321.PointArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiCurve), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.curveMembers), typeof(global::GeoSik.Ogc.Gml.V321.CurveArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiSurface), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.surfaceMembers), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiSolid), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.solidMember), typeof(global::GeoSik.Ogc.Gml.V321.SolidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.solidMembers), typeof(global::GeoSik.Ogc.Gml.V321.SolidArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimeObject), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeObjectType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimePrimitive), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitiveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.validTime), typeof(global::GeoSik.Ogc.Gml.V321.TimePrimitivePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimeComplex), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeComplexType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitive), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitiveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeInstant), typeof(global::GeoSik.Ogc.Gml.V321.TimeInstantType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimePeriod), typeof(global::GeoSik.Ogc.Gml.V321.TimePeriodType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.timePosition), typeof(global::GeoSik.Ogc.Gml.V321.TimePositionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.timeInterval), typeof(global::GeoSik.Ogc.Gml.V321.TimeIntervalLengthType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractFeature), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.boundedBy), typeof(global::GeoSik.Ogc.Gml.V321.BoundingShapeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriod), typeof(global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriodType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.locationName), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.locationReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.direction), typeof(global::GeoSik.Ogc.Gml.V321.DirectionPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dataSource), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dataSourceReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DynamicFeature), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DynamicFeatureCollection), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollectionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dynamicMembers), typeof(global::GeoSik.Ogc.Gml.V321.DynamicFeatureMemberType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimeSlice), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeSliceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.history), typeof(global::GeoSik.Ogc.Gml.V321.HistoryPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeometricComplex), typeof(global::GeoSik.Ogc.Gml.V321.GeometricComplexType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CompositeCurve), typeof(global::GeoSik.Ogc.Gml.V321.CompositeCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CompositeSurface), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CompositeSolid), typeof(global::GeoSik.Ogc.Gml.V321.CompositeSolidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTopology), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopologyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTopoPrimitive), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitiveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Node), typeof(global::GeoSik.Ogc.Gml.V321.NodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.directedNode), typeof(global::GeoSik.Ogc.Gml.V321.DirectedNodePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Edge), typeof(global::GeoSik.Ogc.Gml.V321.EdgeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.directedEdge), typeof(global::GeoSik.Ogc.Gml.V321.DirectedEdgePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Face), typeof(global::GeoSik.Ogc.Gml.V321.FaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.directedFace), typeof(global::GeoSik.Ogc.Gml.V321.DirectedFacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoSolid), typeof(global::GeoSik.Ogc.Gml.V321.TopoSolidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.directedTopoSolid), typeof(global::GeoSik.Ogc.Gml.V321.DirectedTopoSolidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoPoint), typeof(global::GeoSik.Ogc.Gml.V321.TopoPointType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoPointProperty), typeof(global::GeoSik.Ogc.Gml.V321.TopoPointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoCurve), typeof(global::GeoSik.Ogc.Gml.V321.TopoCurveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoCurveProperty), typeof(global::GeoSik.Ogc.Gml.V321.TopoCurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoSurface), typeof(global::GeoSik.Ogc.Gml.V321.TopoSurfaceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoSurfaceProperty), typeof(global::GeoSik.Ogc.Gml.V321.TopoSurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoVolume), typeof(global::GeoSik.Ogc.Gml.V321.TopoVolumeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoVolumeProperty), typeof(global::GeoSik.Ogc.Gml.V321.TopoVolumePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TopoComplex), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.subComplex), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.superComplex), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.maximalComplex), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoPrimitiveMember), typeof(global::GeoSik.Ogc.Gml.V321.TopoPrimitiveMemberType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoPrimitiveMembers), typeof(global::GeoSik.Ogc.Gml.V321.TopoPrimitiveArrayAssociationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CategoryList), typeof(global::GeoSik.Ogc.Gml.V321.CodeOrNilReasonListType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.QuantityList), typeof(global::GeoSik.Ogc.Gml.V321.MeasureOrNilReasonListType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valueProperty), typeof(global::GeoSik.Ogc.Gml.V321.ValuePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valueComponent), typeof(global::GeoSik.Ogc.Gml.V321.ValuePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valueComponents), typeof(global::GeoSik.Ogc.Gml.V321.ValueArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CompositeValue), typeof(global::GeoSik.Ogc.Gml.V321.CompositeValueType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ValueArray), typeof(global::GeoSik.Ogc.Gml.V321.ValueArrayType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CategoryExtent), typeof(global::GeoSik.Ogc.Gml.V321.CategoryExtentType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.QuantityExtent), typeof(global::GeoSik.Ogc.Gml.V321.QuantityExtentType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Grid), typeof(global::GeoSik.Ogc.Gml.V321.GridType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractImplicitGeometry), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeometryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.RectifiedGrid), typeof(global::GeoSik.Ogc.Gml.V321.RectifiedGridType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCoverage), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractDiscreteCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractContinuousCoverage), typeof(global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.domainSet), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.rangeSet), typeof(global::GeoSik.Ogc.Gml.V321.RangeSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DataBlock), typeof(global::GeoSik.Ogc.Gml.V321.DataBlockType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.rangeParameters), typeof(global::GeoSik.Ogc.Gml.V321.AssociationRoleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.tupleList), typeof(global::GeoSik.Ogc.Gml.V321.CoordinatesType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.File), typeof(global::GeoSik.Ogc.Gml.V321.FileType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coverageFunction), typeof(global::GeoSik.Ogc.Gml.V321.CoverageFunctionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CoverageMappingRule), typeof(global::GeoSik.Ogc.Gml.V321.MappingRuleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GridFunction), typeof(global::GeoSik.Ogc.Gml.V321.GridFunctionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiPointCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiCurveCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiSurfaceCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MultiSolidCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GridCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.RectifiedGridCoverage), typeof(global::GeoSik.Ogc.Gml.V321.DiscreteCoverageType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCRS), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CoordinateSystemAxis), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.axisAbbrev), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.axisDirection), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.rangeMeaning), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCoordinateSystem), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystemType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.axis), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.EllipsoidalCS), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CartesianCS), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.VerticalCS), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeCS), typeof(global::GeoSik.Ogc.Gml.V321.TimeCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LinearCS), typeof(global::GeoSik.Ogc.Gml.V321.LinearCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.UserDefinedCS), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.SphericalCS), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.PolarCS), typeof(global::GeoSik.Ogc.Gml.V321.PolarCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CylindricalCS), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AffineCS), typeof(global::GeoSik.Ogc.Gml.V321.AffineCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractDatum), typeof(global::GeoSik.Ogc.Gml.V321.AbstractDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.anchorDefinition), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeodeticDatum), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.primeMeridian), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ellipsoid), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Ellipsoid1), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.semiMajorAxis), typeof(global::GeoSik.Ogc.Gml.V321.MeasureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.PrimeMeridian1), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.greenwichLongitude), typeof(global::GeoSik.Ogc.Gml.V321.AngleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.EngineeringDatum), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ImageDatum), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pixelInCell), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.VerticalDatum), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TemporalDatum), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractCoordinateOperation), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.sourceCRS), typeof(global::GeoSik.Ogc.Gml.V321.CRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.targetCRS), typeof(global::GeoSik.Ogc.Gml.V321.CRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractSingleOperation), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeneralConversion), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeneralTransformation), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ConcatenatedOperation), typeof(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordOperation), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.PassThroughOperation), typeof(global::GeoSik.Ogc.Gml.V321.PassThroughOperationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Conversion), typeof(global::GeoSik.Ogc.Gml.V321.ConversionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.method), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.parameterValue), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValuePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Transformation), typeof(global::GeoSik.Ogc.Gml.V321.TransformationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValue), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValueType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ParameterValue1), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValueType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.value), typeof(global::GeoSik.Ogc.Gml.V321.MeasureType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valueList), typeof(global::GeoSik.Ogc.Gml.V321.MeasureListType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.operationParameter), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ParameterValueGroup), typeof(global::GeoSik.Ogc.Gml.V321.ParameterValueGroupType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.group), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroupPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OperationMethod), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.formula), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.parameter), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameter), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OperationParameter1), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.OperationParameterGroup), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroupType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractSingleCRS), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRS), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.conversion1), typeof(global::GeoSik.Ogc.Gml.V321.GeneralConversionPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.CompoundCRS), typeof(global::GeoSik.Ogc.Gml.V321.CompoundCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.componentReferenceSystem), typeof(global::GeoSik.Ogc.Gml.V321.SingleCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeodeticCRS), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ellipsoidalCS1), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.cartesianCS1), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.sphericalCS1), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geodeticDatum1), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.VerticalCRS), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.verticalCS1), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.verticalDatum1), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ProjectedCRS), typeof(global::GeoSik.Ogc.Gml.V321.ProjectedCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.baseGeodeticCRS), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DerivedCRS), typeof(global::GeoSik.Ogc.Gml.V321.DerivedCRSTypeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.baseCRS), typeof(global::GeoSik.Ogc.Gml.V321.SingleCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.derivedCRSType), typeof(global::GeoSik.Ogc.Gml.V321.CodeWithAuthorityType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordinateSystem), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.EngineeringCRS), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.cylindricalCS1), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.linearCS1), typeof(global::GeoSik.Ogc.Gml.V321.LinearCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.polarCS1), typeof(global::GeoSik.Ogc.Gml.V321.PolarCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.userDefinedCS1), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.engineeringDatum1), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ImageCRS), typeof(global::GeoSik.Ogc.Gml.V321.ImageCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.affineCS1), typeof(global::GeoSik.Ogc.Gml.V321.AffineCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.imageDatum1), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TemporalCRS), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.timeCS1), typeof(global::GeoSik.Ogc.Gml.V321.TimeCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.temporalDatum1), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Observation), typeof(global::GeoSik.Ogc.Gml.V321.ObservationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.@using), typeof(global::GeoSik.Ogc.Gml.V321.ProcedurePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.target), typeof(global::GeoSik.Ogc.Gml.V321.TargetPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.subject), typeof(global::GeoSik.Ogc.Gml.V321.TargetPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.resultOf), typeof(global::GeoSik.Ogc.Gml.V321.ResultType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DirectedObservation), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DirectedObservationAtDistance), typeof(global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistanceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitive), typeof(global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitiveType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeTopologyComplex), typeof(global::GeoSik.Ogc.Gml.V321.TimeTopologyComplexType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeNode), typeof(global::GeoSik.Ogc.Gml.V321.TimeNodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeEdge), typeof(global::GeoSik.Ogc.Gml.V321.TimeEdgeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeReferenceSystem), typeof(global::GeoSik.Ogc.Gml.V321.TimeReferenceSystemType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeCoordinateSystem), typeof(global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystemType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeCalendar), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeCalendarEra), typeof(global::GeoSik.Ogc.Gml.V321.TimeCalendarEraType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeClock), typeof(global::GeoSik.Ogc.Gml.V321.TimeClockType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystem), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystemType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TimeOrdinalEra), typeof(global::GeoSik.Ogc.Gml.V321.TimeOrdinalEraType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.anchorPoint), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.datumRef), typeof(global::GeoSik.Ogc.Gml.V321.DatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesPrimeMeridian), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesEllipsoid), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geodeticDatumRef), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ellipsoidRef), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.primeMeridianRef), typeof(global::GeoSik.Ogc.Gml.V321.PrimeMeridianPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.engineeringDatumRef), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.imageDatumRef), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.verticalDatumRef), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.temporalDatumRef), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordinateOperationRef), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.singleOperationRef), typeof(global::GeoSik.Ogc.Gml.V321.SingleOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractOperation), typeof(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.operationRef), typeof(global::GeoSik.Ogc.Gml.V321.OperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.generalConversionRef), typeof(global::GeoSik.Ogc.Gml.V321.GeneralConversionPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.generalTransformationRef), typeof(global::GeoSik.Ogc.Gml.V321.GeneralTransformationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesSingleOperation), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.concatenatedOperationRef), typeof(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesOperation), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.passThroughOperationRef), typeof(global::GeoSik.Ogc.Gml.V321.PassThroughOperationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesMethod), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesValue), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValuePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.conversionRef), typeof(global::GeoSik.Ogc.Gml.V321.ConversionPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.transformationRef), typeof(global::GeoSik.Ogc.Gml.V321.TransformationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dmsAngleValue), typeof(global::GeoSik.Ogc.Gml.V321.DMSAngleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valueOfParameter), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.includesValue), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValuePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.valuesOfGroup), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterGroupPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.methodFormula), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesParameter), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.operationMethodRef), typeof(global::GeoSik.Ogc.Gml.V321.OperationMethodPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.abstractGeneralOperationParameterRef), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.operationParameterRef), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.includesParameter), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.operationParameterGroupRef), typeof(global::GeoSik.Ogc.Gml.V321.OperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.referenceSystemRef), typeof(global::GeoSik.Ogc.Gml.V321.CRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.crsRef), typeof(global::GeoSik.Ogc.Gml.V321.CRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordinateSystemAxisRef), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesAxis), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxisPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordinateSystemRef), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ellipsoidalCSRef), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.cartesianCSRef), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.verticalCSRef), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.TemporalCS), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.temporalCSRef), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.linearCSRef), typeof(global::GeoSik.Ogc.Gml.V321.LinearCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.userDefinedCSRef), typeof(global::GeoSik.Ogc.Gml.V321.UserDefinedCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.sphericalCSRef), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.polarCSRef), typeof(global::GeoSik.Ogc.Gml.V321.PolarCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.cylindricalCSRef), typeof(global::GeoSik.Ogc.Gml.V321.CylindricalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.ObliqueCartesianCS), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.obliqueCartesianCSRef), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.singleCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.SingleCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.definedByConversion), typeof(global::GeoSik.Ogc.Gml.V321.GeneralConversionPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.includesSingleCRS), typeof(global::GeoSik.Ogc.Gml.V321.SingleCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.compoundCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.CompoundCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesEllipsoidalCS), typeof(global::GeoSik.Ogc.Gml.V321.EllipsoidalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesCartesianCS), typeof(global::GeoSik.Ogc.Gml.V321.CartesianCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesSphericalCS), typeof(global::GeoSik.Ogc.Gml.V321.SphericalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesGeodeticDatum), typeof(global::GeoSik.Ogc.Gml.V321.GeodeticDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesVerticalCS), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesVerticalDatum), typeof(global::GeoSik.Ogc.Gml.V321.VerticalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.verticalCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.VerticalCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.baseGeographicCRS), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.projectedCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.ProjectedCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesCS), typeof(global::GeoSik.Ogc.Gml.V321.CoordinateSystemPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.derivedCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.DerivedCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesEngineeringDatum), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.engineeringCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.EngineeringCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesAffineCS), typeof(global::GeoSik.Ogc.Gml.V321.AffineCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesImageDatum), typeof(global::GeoSik.Ogc.Gml.V321.ImageDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesObliqueCartesianCS), typeof(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.imageCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.ImageCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesTimeCS), typeof(global::GeoSik.Ogc.Gml.V321.TimeCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesTemporalCS), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.usesTemporalDatum), typeof(global::GeoSik.Ogc.Gml.V321.TemporalDatumPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.temporalCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.TemporalCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeographicCRS), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geographicCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.GeographicCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GeocentricCRS), typeof(global::GeoSik.Ogc.Gml.V321.GeocentricCRSType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.geocentricCRSRef), typeof(global::GeoSik.Ogc.Gml.V321.GeocentricCRSPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.dmsAngle), typeof(global::GeoSik.Ogc.Gml.V321.DMSAngleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.degrees), typeof(global::GeoSik.Ogc.Gml.V321.DegreesType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.member), typeof(global::GeoSik.Ogc.Gml.V321.AssociationRoleType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.members), typeof(global::GeoSik.Ogc.Gml.V321.ArrayAssociationType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.metaDataProperty), typeof(global::GeoSik.Ogc.Gml.V321.MetaDataPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Bag), typeof(global::GeoSik.Ogc.Gml.V321.BagType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.Array), typeof(global::GeoSik.Ogc.Gml.V321.ArrayType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractMetaData), typeof(global::GeoSik.Ogc.Gml.V321.AbstractMetaDataType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.GenericMetaData), typeof(global::GeoSik.Ogc.Gml.V321.GenericMetaDataType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.coordinates), typeof(global::GeoSik.Ogc.Gml.V321.CoordinatesType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pointRep), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.location), typeof(global::GeoSik.Ogc.Gml.V321.LocationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LocationString), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.LocationKeyWord), typeof(global::GeoSik.Ogc.Gml.V321.CodeType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.priorityLocation), typeof(global::GeoSik.Ogc.Gml.V321.PriorityLocationPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.featureMember), typeof(global::GeoSik.Ogc.Gml.V321.FeaturePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.featureProperty), typeof(global::GeoSik.Ogc.Gml.V321.FeaturePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.featureMembers), typeof(global::GeoSik.Ogc.Gml.V321.FeatureArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.AbstractFeatureCollection), typeof(global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollectionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.FeatureCollection), typeof(global::GeoSik.Ogc.Gml.V321.FeatureCollectionType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.track), typeof(global::GeoSik.Ogc.Gml.V321.HistoryPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DefinitionCollection), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.definitionMember), typeof(global::GeoSik.Ogc.Gml.V321.DictionaryEntryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.indirectEntry), typeof(global::GeoSik.Ogc.Gml.V321.IndirectEntryType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.DefinitionProxy), typeof(global::GeoSik.Ogc.Gml.V321.DefinitionProxyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.definitionRef), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MappingRule), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.centerOf), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.position), typeof(global::GeoSik.Ogc.Gml.V321.PointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.extentOf), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.edgeOf), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.centerLineOf), typeof(global::GeoSik.Ogc.Gml.V321.CurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiLocation), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiCenterOf), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiPosition), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiCenterLineOf), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiEdgeOf), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiCoverage), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiExtentOf), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.polygonPatches), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePatchArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.trianglePatches), typeof(global::GeoSik.Ogc.Gml.V321.SurfacePatchArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiPointDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiCurveDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiSurfaceDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiSolidDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.gridDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.rectifiedGridDomain), typeof(global::GeoSik.Ogc.Gml.V321.DomainSetType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.generalOperationParameter), typeof(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameterPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.MovingObjectStatus), typeof(global::GeoSik.Ogc.Gml.V321.MovingObjectStatusType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.status), typeof(global::GeoSik.Ogc.Gml.V321.StringOrRefType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.statusReference), typeof(global::GeoSik.Ogc.Gml.V321.ReferenceType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.topoComplexProperty), typeof(global::GeoSik.Ogc.Gml.V321.TopoComplexPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiPointProperty), typeof(global::GeoSik.Ogc.Gml.V321.MultiPointPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiCurveProperty), typeof(global::GeoSik.Ogc.Gml.V321.MultiCurvePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiSurfaceProperty), typeof(global::GeoSik.Ogc.Gml.V321.MultiSurfacePropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiSolidProperty), typeof(global::GeoSik.Ogc.Gml.V321.MultiSolidPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.multiGeometryProperty), typeof(global::GeoSik.Ogc.Gml.V321.MultiGeometryPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.pointArrayProperty), typeof(global::GeoSik.Ogc.Gml.V321.PointArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.curveArrayProperty), typeof(global::GeoSik.Ogc.Gml.V321.CurveArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.surfaceArrayProperty), typeof(global::GeoSik.Ogc.Gml.V321.SurfaceArrayPropertyType));
            wrapperDictionary.Add(typeof(GeoSik.Ogc.Gml.V321.solidArrayProperty), typeof(global::GeoSik.Ogc.Gml.V321.SolidArrayPropertyType));
        }

        protected internal static void AddSchemas(XmlSchemaSet schemas)
        {
            schemas.Add(schemaSet);
        }

        public static System.Type GetRootType()
        {
            return elementDictionary[XName.Get("Record", "http://www.isotc211.org/2005/gco")];
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class XRootNamespace
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;


        public Record Record { get { return rootObject as Record; } }

        public AbstractObject AbstractObject { get { return rootObject as AbstractObject; } }

        public TypeName TypeName { get { return rootObject as TypeName; } }

        public MemberName MemberName { get { return rootObject as MemberName; } }

        public Multiplicity Multiplicity { get { return rootObject as Multiplicity; } }

        public MultiplicityRange MultiplicityRange { get { return rootObject as MultiplicityRange; } }

        public Measure Measure { get { return rootObject as Measure; } }

        public Length Length { get { return rootObject as Length; } }

        public Angle Angle { get { return rootObject as Angle; } }

        public Scale Scale { get { return rootObject as Scale; } }

        public Distance Distance { get { return rootObject as Distance; } }

        public CharacterString CharacterString { get { return rootObject as CharacterString; } }

        public Boolean Boolean { get { return rootObject as Boolean; } }

        public AbstractGenericName AbstractGenericName { get { return rootObject as AbstractGenericName; } }

        public LocalName LocalName { get { return rootObject as LocalName; } }

        public ScopedName ScopedName { get { return rootObject as ScopedName; } }

        public DateTime DateTime { get { return rootObject as DateTime; } }

        public Date Date { get { return rootObject as Date; } }

        public @Decimal @Decimal { get { return rootObject as @Decimal; } }

        public Real Real { get { return rootObject as Real; } }

        public Integer Integer { get { return rootObject as Integer; } }

        public UnlimitedInteger UnlimitedInteger { get { return rootObject as UnlimitedInteger; } }

        public RecordType RecordType { get { return rootObject as RecordType; } }

        public Binary Binary { get { return rootObject as Binary; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(Record root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(AbstractObject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(TypeName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(MemberName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Multiplicity root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(MultiplicityRange root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Measure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Length root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Angle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Scale root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Distance root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(CharacterString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Boolean root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(AbstractGenericName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(LocalName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ScopedName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DateTime root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Date root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(@Decimal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Real root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Integer root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(UnlimitedInteger root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(RecordType root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Binary root)
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


        public global::GeoSik.Iso.Ts19139.Gco.Record Record { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Record; } }

        public global::GeoSik.Iso.Ts19139.Gco.AbstractObject AbstractObject { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.AbstractObject; } }

        public global::GeoSik.Iso.Ts19139.Gco.TypeName TypeName { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.TypeName; } }

        public global::GeoSik.Iso.Ts19139.Gco.MemberName MemberName { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.MemberName; } }

        public global::GeoSik.Iso.Ts19139.Gco.Multiplicity Multiplicity { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Multiplicity; } }

        public global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange MultiplicityRange { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange; } }

        public global::GeoSik.Iso.Ts19139.Gco.Measure Measure { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Measure; } }

        public global::GeoSik.Iso.Ts19139.Gco.Length Length { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Length; } }

        public global::GeoSik.Iso.Ts19139.Gco.Angle Angle { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Angle; } }

        public global::GeoSik.Iso.Ts19139.Gco.Scale Scale { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Scale; } }

        public global::GeoSik.Iso.Ts19139.Gco.Distance Distance { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Distance; } }

        public global::GeoSik.Iso.Ts19139.Gco.CharacterString CharacterString { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.CharacterString; } }

        public global::GeoSik.Iso.Ts19139.Gco.Boolean Boolean { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Boolean; } }

        public global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName AbstractGenericName { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName; } }

        public global::GeoSik.Iso.Ts19139.Gco.LocalName LocalName { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.LocalName; } }

        public global::GeoSik.Iso.Ts19139.Gco.ScopedName ScopedName { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.ScopedName; } }

        public global::GeoSik.Iso.Ts19139.Gco.DateTime DateTime { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.DateTime; } }

        public global::GeoSik.Iso.Ts19139.Gco.Date Date { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Date; } }

        public global::GeoSik.Iso.Ts19139.Gco.@Decimal @Decimal { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.@Decimal; } }

        public global::GeoSik.Iso.Ts19139.Gco.Real Real { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Real; } }

        public global::GeoSik.Iso.Ts19139.Gco.Integer Integer { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Integer; } }

        public global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger UnlimitedInteger { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger; } }

        public global::GeoSik.Iso.Ts19139.Gco.RecordType RecordType { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.RecordType; } }

        public global::GeoSik.Iso.Ts19139.Gco.Binary Binary { get { return rootObject as global::GeoSik.Iso.Ts19139.Gco.Binary; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractObject AbstractObject1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractObject; } }

        public global::GeoSik.Ogc.Gml.V321.Boolean Boolean1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Boolean; } }

        public global::GeoSik.Ogc.Gml.V321.Category Category { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Category; } }

        public global::GeoSik.Ogc.Gml.V321.Count Count { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Count; } }

        public global::GeoSik.Ogc.Gml.V321.Quantity Quantity { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Quantity; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractValue AbstractValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractValue; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractScalarValue AbstractScalarValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractScalarValue; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractScalarValueList AbstractScalarValueList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractScalarValueList; } }

        public global::GeoSik.Ogc.Gml.V321.domainOfValidity domainOfValidity { get { return rootObject as global::GeoSik.Ogc.Gml.V321.domainOfValidity; } }

        public global::GeoSik.Ogc.Gml.V321.secondDefiningParameter secondDefiningParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.secondDefiningParameter; } }

        public global::GeoSik.Ogc.Gml.V321.SecondDefiningParameter1 SecondDefiningParameter1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.SecondDefiningParameter1; } }

        public global::GeoSik.Ogc.Gml.V321.coordinateOperationAccuracy coordinateOperationAccuracy { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinateOperationAccuracy; } }

        public global::GeoSik.Ogc.Gml.V321.formulaCitation formulaCitation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.formulaCitation; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGML AbstractGML { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGML; } }

        public global::GeoSik.Ogc.Gml.V321.abstractAssociationRole abstractAssociationRole { get { return rootObject as global::GeoSik.Ogc.Gml.V321.abstractAssociationRole; } }

        public global::GeoSik.Ogc.Gml.V321.abstractStrictAssociationRole abstractStrictAssociationRole { get { return rootObject as global::GeoSik.Ogc.Gml.V321.abstractStrictAssociationRole; } }

        public global::GeoSik.Ogc.Gml.V321.abstractReference abstractReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.abstractReference; } }

        public global::GeoSik.Ogc.Gml.V321.abstractInlineProperty abstractInlineProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.abstractInlineProperty; } }

        public global::GeoSik.Ogc.Gml.V321.reversePropertyName reversePropertyName { get { return rootObject as global::GeoSik.Ogc.Gml.V321.reversePropertyName; } }

        public global::GeoSik.Ogc.Gml.V321.description description { get { return rootObject as global::GeoSik.Ogc.Gml.V321.description; } }

        public global::GeoSik.Ogc.Gml.V321.descriptionReference descriptionReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.descriptionReference; } }

        public global::GeoSik.Ogc.Gml.V321.name name { get { return rootObject as global::GeoSik.Ogc.Gml.V321.name; } }

        public global::GeoSik.Ogc.Gml.V321.identifier identifier { get { return rootObject as global::GeoSik.Ogc.Gml.V321.identifier; } }

        public global::GeoSik.Ogc.Gml.V321.targetElement targetElement { get { return rootObject as global::GeoSik.Ogc.Gml.V321.targetElement; } }

        public global::GeoSik.Ogc.Gml.V321.associationName associationName { get { return rootObject as global::GeoSik.Ogc.Gml.V321.associationName; } }

        public global::GeoSik.Ogc.Gml.V321.defaultCodeSpace defaultCodeSpace { get { return rootObject as global::GeoSik.Ogc.Gml.V321.defaultCodeSpace; } }

        public global::GeoSik.Ogc.Gml.V321.gmlProfileSchema gmlProfileSchema { get { return rootObject as global::GeoSik.Ogc.Gml.V321.gmlProfileSchema; } }

        public global::GeoSik.Ogc.Gml.V321.Definition Definition { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Definition; } }

        public global::GeoSik.Ogc.Gml.V321.remarks remarks { get { return rootObject as global::GeoSik.Ogc.Gml.V321.remarks; } }

        public global::GeoSik.Ogc.Gml.V321.Dictionary Dictionary { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Dictionary; } }

        public global::GeoSik.Ogc.Gml.V321.dictionaryEntry dictionaryEntry { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dictionaryEntry; } }

        public global::GeoSik.Ogc.Gml.V321.unitOfMeasure unitOfMeasure { get { return rootObject as global::GeoSik.Ogc.Gml.V321.unitOfMeasure; } }

        public global::GeoSik.Ogc.Gml.V321.UnitDefinition UnitDefinition { get { return rootObject as global::GeoSik.Ogc.Gml.V321.UnitDefinition; } }

        public global::GeoSik.Ogc.Gml.V321.quantityType quantityType { get { return rootObject as global::GeoSik.Ogc.Gml.V321.quantityType; } }

        public global::GeoSik.Ogc.Gml.V321.quantityTypeReference quantityTypeReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.quantityTypeReference; } }

        public global::GeoSik.Ogc.Gml.V321.catalogSymbol catalogSymbol { get { return rootObject as global::GeoSik.Ogc.Gml.V321.catalogSymbol; } }

        public global::GeoSik.Ogc.Gml.V321.BaseUnit BaseUnit { get { return rootObject as global::GeoSik.Ogc.Gml.V321.BaseUnit; } }

        public global::GeoSik.Ogc.Gml.V321.DerivedUnit DerivedUnit { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DerivedUnit; } }

        public global::GeoSik.Ogc.Gml.V321.derivationUnitTerm derivationUnitTerm { get { return rootObject as global::GeoSik.Ogc.Gml.V321.derivationUnitTerm; } }

        public global::GeoSik.Ogc.Gml.V321.ConventionalUnit ConventionalUnit { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ConventionalUnit; } }

        public global::GeoSik.Ogc.Gml.V321.conversionToPreferredUnit conversionToPreferredUnit { get { return rootObject as global::GeoSik.Ogc.Gml.V321.conversionToPreferredUnit; } }

        public global::GeoSik.Ogc.Gml.V321.roughConversionToPreferredUnit roughConversionToPreferredUnit { get { return rootObject as global::GeoSik.Ogc.Gml.V321.roughConversionToPreferredUnit; } }

        public global::GeoSik.Ogc.Gml.V321.measure measure1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.measure; } }

        public global::GeoSik.Ogc.Gml.V321.angle angle1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.angle; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeometry AbstractGeometry { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeometry; } }

        public global::GeoSik.Ogc.Gml.V321.pos pos { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pos; } }

        public global::GeoSik.Ogc.Gml.V321.posList posList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.posList; } }

        public global::GeoSik.Ogc.Gml.V321.vector vector { get { return rootObject as global::GeoSik.Ogc.Gml.V321.vector; } }

        public global::GeoSik.Ogc.Gml.V321.Envelope Envelope { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Envelope; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitive AbstractGeometricPrimitive { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitive; } }

        public global::GeoSik.Ogc.Gml.V321.Point Point { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Point; } }

        public global::GeoSik.Ogc.Gml.V321.pointProperty pointProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pointProperty; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCurve AbstractCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCurve; } }

        public global::GeoSik.Ogc.Gml.V321.curveProperty curveProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.curveProperty; } }

        public global::GeoSik.Ogc.Gml.V321.LineString LineString { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LineString; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractSurface AbstractSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractSurface; } }

        public global::GeoSik.Ogc.Gml.V321.surfaceProperty surfaceProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.surfaceProperty; } }

        public global::GeoSik.Ogc.Gml.V321.Polygon Polygon { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Polygon; } }

        public global::GeoSik.Ogc.Gml.V321.exterior exterior { get { return rootObject as global::GeoSik.Ogc.Gml.V321.exterior; } }

        public global::GeoSik.Ogc.Gml.V321.interior interior { get { return rootObject as global::GeoSik.Ogc.Gml.V321.interior; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractRing AbstractRing { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractRing; } }

        public global::GeoSik.Ogc.Gml.V321.LinearRing LinearRing { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LinearRing; } }

        public global::GeoSik.Ogc.Gml.V321.Curve Curve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Curve; } }

        public global::GeoSik.Ogc.Gml.V321.baseCurve baseCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.baseCurve; } }

        public global::GeoSik.Ogc.Gml.V321.OrientableCurve OrientableCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OrientableCurve; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCurveSegment AbstractCurveSegment { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCurveSegment; } }

        public global::GeoSik.Ogc.Gml.V321.segments segments { get { return rootObject as global::GeoSik.Ogc.Gml.V321.segments; } }

        public global::GeoSik.Ogc.Gml.V321.LineStringSegment LineStringSegment { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LineStringSegment; } }

        public global::GeoSik.Ogc.Gml.V321.ArcString ArcString { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ArcString; } }

        public global::GeoSik.Ogc.Gml.V321.Arc Arc { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Arc; } }

        public global::GeoSik.Ogc.Gml.V321.Circle Circle { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Circle; } }

        public global::GeoSik.Ogc.Gml.V321.ArcStringByBulge ArcStringByBulge { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ArcStringByBulge; } }

        public global::GeoSik.Ogc.Gml.V321.ArcByBulge ArcByBulge { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ArcByBulge; } }

        public global::GeoSik.Ogc.Gml.V321.ArcByCenterPoint ArcByCenterPoint { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ArcByCenterPoint; } }

        public global::GeoSik.Ogc.Gml.V321.CircleByCenterPoint CircleByCenterPoint { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CircleByCenterPoint; } }

        public global::GeoSik.Ogc.Gml.V321.CubicSpline CubicSpline { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CubicSpline; } }

        public global::GeoSik.Ogc.Gml.V321.BSpline BSpline { get { return rootObject as global::GeoSik.Ogc.Gml.V321.BSpline; } }

        public global::GeoSik.Ogc.Gml.V321.Bezier Bezier { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Bezier; } }

        public global::GeoSik.Ogc.Gml.V321.OffsetCurve OffsetCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OffsetCurve; } }

        public global::GeoSik.Ogc.Gml.V321.AffinePlacement AffinePlacement { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AffinePlacement; } }

        public global::GeoSik.Ogc.Gml.V321.Clothoid Clothoid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Clothoid; } }

        public global::GeoSik.Ogc.Gml.V321.GeodesicString GeodesicString { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeodesicString; } }

        public global::GeoSik.Ogc.Gml.V321.Geodesic Geodesic { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Geodesic; } }

        public global::GeoSik.Ogc.Gml.V321.Surface Surface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Surface; } }

        public global::GeoSik.Ogc.Gml.V321.baseSurface baseSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.baseSurface; } }

        public global::GeoSik.Ogc.Gml.V321.OrientableSurface OrientableSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OrientableSurface; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatch AbstractSurfacePatch { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatch; } }

        public global::GeoSik.Ogc.Gml.V321.patches patches { get { return rootObject as global::GeoSik.Ogc.Gml.V321.patches; } }

        public global::GeoSik.Ogc.Gml.V321.PolygonPatch PolygonPatch { get { return rootObject as global::GeoSik.Ogc.Gml.V321.PolygonPatch; } }

        public global::GeoSik.Ogc.Gml.V321.Triangle Triangle { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Triangle; } }

        public global::GeoSik.Ogc.Gml.V321.Rectangle Rectangle { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Rectangle; } }

        public global::GeoSik.Ogc.Gml.V321.Ring Ring { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Ring; } }

        public global::GeoSik.Ogc.Gml.V321.curveMember curveMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.curveMember; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurface AbstractParametricCurveSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurface; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurface AbstractGriddedSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurface; } }

        public global::GeoSik.Ogc.Gml.V321.Cone Cone { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Cone; } }

        public global::GeoSik.Ogc.Gml.V321.Cylinder Cylinder { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Cylinder; } }

        public global::GeoSik.Ogc.Gml.V321.Sphere Sphere { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Sphere; } }

        public global::GeoSik.Ogc.Gml.V321.PolyhedralSurface PolyhedralSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.PolyhedralSurface; } }

        public global::GeoSik.Ogc.Gml.V321.TriangulatedSurface TriangulatedSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TriangulatedSurface; } }

        public global::GeoSik.Ogc.Gml.V321.Tin Tin { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Tin; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractSolid AbstractSolid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractSolid; } }

        public global::GeoSik.Ogc.Gml.V321.solidProperty solidProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.solidProperty; } }

        public global::GeoSik.Ogc.Gml.V321.Solid Solid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Solid; } }

        public global::GeoSik.Ogc.Gml.V321.Shell Shell { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Shell; } }

        public global::GeoSik.Ogc.Gml.V321.surfaceMember surfaceMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.surfaceMember; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregate AbstractGeometricAggregate { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregate; } }

        public global::GeoSik.Ogc.Gml.V321.MultiGeometry MultiGeometry { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiGeometry; } }

        public global::GeoSik.Ogc.Gml.V321.geometryMember geometryMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geometryMember; } }

        public global::GeoSik.Ogc.Gml.V321.geometryMembers geometryMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geometryMembers; } }

        public global::GeoSik.Ogc.Gml.V321.MultiPoint MultiPoint { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiPoint; } }

        public global::GeoSik.Ogc.Gml.V321.pointMember pointMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pointMember; } }

        public global::GeoSik.Ogc.Gml.V321.pointMembers pointMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pointMembers; } }

        public global::GeoSik.Ogc.Gml.V321.MultiCurve MultiCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiCurve; } }

        public global::GeoSik.Ogc.Gml.V321.curveMembers curveMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.curveMembers; } }

        public global::GeoSik.Ogc.Gml.V321.MultiSurface MultiSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiSurface; } }

        public global::GeoSik.Ogc.Gml.V321.surfaceMembers surfaceMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.surfaceMembers; } }

        public global::GeoSik.Ogc.Gml.V321.MultiSolid MultiSolid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiSolid; } }

        public global::GeoSik.Ogc.Gml.V321.solidMember solidMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.solidMember; } }

        public global::GeoSik.Ogc.Gml.V321.solidMembers solidMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.solidMembers; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimeObject AbstractTimeObject { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimeObject; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitive AbstractTimePrimitive { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitive; } }

        public global::GeoSik.Ogc.Gml.V321.validTime validTime { get { return rootObject as global::GeoSik.Ogc.Gml.V321.validTime; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimeComplex AbstractTimeComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimeComplex; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitive AbstractTimeGeometricPrimitive { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitive; } }

        public global::GeoSik.Ogc.Gml.V321.TimeInstant TimeInstant { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeInstant; } }

        public global::GeoSik.Ogc.Gml.V321.TimePeriod TimePeriod { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimePeriod; } }

        public global::GeoSik.Ogc.Gml.V321.timePosition timePosition { get { return rootObject as global::GeoSik.Ogc.Gml.V321.timePosition; } }

        public global::GeoSik.Ogc.Gml.V321.duration duration { get { return rootObject as global::GeoSik.Ogc.Gml.V321.duration; } }

        public global::GeoSik.Ogc.Gml.V321.timeInterval timeInterval { get { return rootObject as global::GeoSik.Ogc.Gml.V321.timeInterval; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractFeature AbstractFeature { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractFeature; } }

        public global::GeoSik.Ogc.Gml.V321.boundedBy boundedBy { get { return rootObject as global::GeoSik.Ogc.Gml.V321.boundedBy; } }

        public global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriod EnvelopeWithTimePeriod { get { return rootObject as global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriod; } }

        public global::GeoSik.Ogc.Gml.V321.locationName locationName { get { return rootObject as global::GeoSik.Ogc.Gml.V321.locationName; } }

        public global::GeoSik.Ogc.Gml.V321.locationReference locationReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.locationReference; } }

        public global::GeoSik.Ogc.Gml.V321.direction direction { get { return rootObject as global::GeoSik.Ogc.Gml.V321.direction; } }

        public global::GeoSik.Ogc.Gml.V321.dataSource dataSource { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dataSource; } }

        public global::GeoSik.Ogc.Gml.V321.dataSourceReference dataSourceReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dataSourceReference; } }

        public global::GeoSik.Ogc.Gml.V321.DynamicFeature DynamicFeature { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DynamicFeature; } }

        public global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollection DynamicFeatureCollection { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollection; } }

        public global::GeoSik.Ogc.Gml.V321.dynamicMembers dynamicMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dynamicMembers; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimeSlice AbstractTimeSlice { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimeSlice; } }

        public global::GeoSik.Ogc.Gml.V321.history history { get { return rootObject as global::GeoSik.Ogc.Gml.V321.history; } }

        public global::GeoSik.Ogc.Gml.V321.GeometricComplex GeometricComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeometricComplex; } }

        public global::GeoSik.Ogc.Gml.V321.CompositeCurve CompositeCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CompositeCurve; } }

        public global::GeoSik.Ogc.Gml.V321.CompositeSurface CompositeSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CompositeSurface; } }

        public global::GeoSik.Ogc.Gml.V321.CompositeSolid CompositeSolid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CompositeSolid; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTopology AbstractTopology { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTopology; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitive AbstractTopoPrimitive { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitive; } }

        public global::GeoSik.Ogc.Gml.V321.Node Node { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Node; } }

        public global::GeoSik.Ogc.Gml.V321.directedNode directedNode { get { return rootObject as global::GeoSik.Ogc.Gml.V321.directedNode; } }

        public global::GeoSik.Ogc.Gml.V321.Edge Edge { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Edge; } }

        public global::GeoSik.Ogc.Gml.V321.directedEdge directedEdge { get { return rootObject as global::GeoSik.Ogc.Gml.V321.directedEdge; } }

        public global::GeoSik.Ogc.Gml.V321.Face Face { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Face; } }

        public global::GeoSik.Ogc.Gml.V321.directedFace directedFace { get { return rootObject as global::GeoSik.Ogc.Gml.V321.directedFace; } }

        public global::GeoSik.Ogc.Gml.V321.TopoSolid TopoSolid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoSolid; } }

        public global::GeoSik.Ogc.Gml.V321.directedTopoSolid directedTopoSolid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.directedTopoSolid; } }

        public global::GeoSik.Ogc.Gml.V321.TopoPoint TopoPoint { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoPoint; } }

        public global::GeoSik.Ogc.Gml.V321.topoPointProperty topoPointProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoPointProperty; } }

        public global::GeoSik.Ogc.Gml.V321.TopoCurve TopoCurve { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoCurve; } }

        public global::GeoSik.Ogc.Gml.V321.topoCurveProperty topoCurveProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoCurveProperty; } }

        public global::GeoSik.Ogc.Gml.V321.TopoSurface TopoSurface { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoSurface; } }

        public global::GeoSik.Ogc.Gml.V321.topoSurfaceProperty topoSurfaceProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoSurfaceProperty; } }

        public global::GeoSik.Ogc.Gml.V321.TopoVolume TopoVolume { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoVolume; } }

        public global::GeoSik.Ogc.Gml.V321.topoVolumeProperty topoVolumeProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoVolumeProperty; } }

        public global::GeoSik.Ogc.Gml.V321.TopoComplex TopoComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TopoComplex; } }

        public global::GeoSik.Ogc.Gml.V321.subComplex subComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.subComplex; } }

        public global::GeoSik.Ogc.Gml.V321.superComplex superComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.superComplex; } }

        public global::GeoSik.Ogc.Gml.V321.maximalComplex maximalComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.maximalComplex; } }

        public global::GeoSik.Ogc.Gml.V321.topoPrimitiveMember topoPrimitiveMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoPrimitiveMember; } }

        public global::GeoSik.Ogc.Gml.V321.topoPrimitiveMembers topoPrimitiveMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoPrimitiveMembers; } }

        public global::GeoSik.Ogc.Gml.V321.BooleanList BooleanList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.BooleanList; } }

        public global::GeoSik.Ogc.Gml.V321.CategoryList CategoryList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CategoryList; } }

        public global::GeoSik.Ogc.Gml.V321.CountList CountList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CountList; } }

        public global::GeoSik.Ogc.Gml.V321.QuantityList QuantityList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.QuantityList; } }

        public global::GeoSik.Ogc.Gml.V321.valueProperty valueProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueProperty; } }

        public global::GeoSik.Ogc.Gml.V321.valueComponent valueComponent { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueComponent; } }

        public global::GeoSik.Ogc.Gml.V321.valueComponents valueComponents { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueComponents; } }

        public global::GeoSik.Ogc.Gml.V321.CompositeValue CompositeValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CompositeValue; } }

        public global::GeoSik.Ogc.Gml.V321.ValueArray ValueArray { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ValueArray; } }

        public global::GeoSik.Ogc.Gml.V321.CategoryExtent CategoryExtent { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CategoryExtent; } }

        public global::GeoSik.Ogc.Gml.V321.CountExtent CountExtent { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CountExtent; } }

        public global::GeoSik.Ogc.Gml.V321.QuantityExtent QuantityExtent { get { return rootObject as global::GeoSik.Ogc.Gml.V321.QuantityExtent; } }

        public global::GeoSik.Ogc.Gml.V321.Grid Grid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Grid; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractImplicitGeometry AbstractImplicitGeometry { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractImplicitGeometry; } }

        public global::GeoSik.Ogc.Gml.V321.RectifiedGrid RectifiedGrid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.RectifiedGrid; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCoverage AbstractCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractDiscreteCoverage AbstractDiscreteCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractDiscreteCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverage AbstractContinuousCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.domainSet domainSet { get { return rootObject as global::GeoSik.Ogc.Gml.V321.domainSet; } }

        public global::GeoSik.Ogc.Gml.V321.rangeSet rangeSet { get { return rootObject as global::GeoSik.Ogc.Gml.V321.rangeSet; } }

        public global::GeoSik.Ogc.Gml.V321.DataBlock DataBlock { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DataBlock; } }

        public global::GeoSik.Ogc.Gml.V321.rangeParameters rangeParameters { get { return rootObject as global::GeoSik.Ogc.Gml.V321.rangeParameters; } }

        public global::GeoSik.Ogc.Gml.V321.tupleList tupleList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.tupleList; } }

        public global::GeoSik.Ogc.Gml.V321.doubleOrNilReasonTupleList doubleOrNilReasonTupleList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.doubleOrNilReasonTupleList; } }

        public global::GeoSik.Ogc.Gml.V321.File File { get { return rootObject as global::GeoSik.Ogc.Gml.V321.File; } }

        public global::GeoSik.Ogc.Gml.V321.coverageFunction coverageFunction { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coverageFunction; } }

        public global::GeoSik.Ogc.Gml.V321.CoverageMappingRule CoverageMappingRule { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CoverageMappingRule; } }

        public global::GeoSik.Ogc.Gml.V321.GridFunction GridFunction { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GridFunction; } }

        public global::GeoSik.Ogc.Gml.V321.MultiPointCoverage MultiPointCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiPointCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.MultiCurveCoverage MultiCurveCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiCurveCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.MultiSurfaceCoverage MultiSurfaceCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiSurfaceCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.MultiSolidCoverage MultiSolidCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MultiSolidCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.GridCoverage GridCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GridCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.RectifiedGridCoverage RectifiedGridCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.RectifiedGridCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCRS AbstractCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCRS; } }

        public global::GeoSik.Ogc.Gml.V321.scope scope { get { return rootObject as global::GeoSik.Ogc.Gml.V321.scope; } }

        public global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxis CoordinateSystemAxis { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxis; } }

        public global::GeoSik.Ogc.Gml.V321.axisAbbrev axisAbbrev { get { return rootObject as global::GeoSik.Ogc.Gml.V321.axisAbbrev; } }

        public global::GeoSik.Ogc.Gml.V321.axisDirection axisDirection { get { return rootObject as global::GeoSik.Ogc.Gml.V321.axisDirection; } }

        public global::GeoSik.Ogc.Gml.V321.minimumValue minimumValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.minimumValue; } }

        public global::GeoSik.Ogc.Gml.V321.maximumValue maximumValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.maximumValue; } }

        public global::GeoSik.Ogc.Gml.V321.rangeMeaning rangeMeaning { get { return rootObject as global::GeoSik.Ogc.Gml.V321.rangeMeaning; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystem AbstractCoordinateSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystem; } }

        public global::GeoSik.Ogc.Gml.V321.axis axis { get { return rootObject as global::GeoSik.Ogc.Gml.V321.axis; } }

        public global::GeoSik.Ogc.Gml.V321.EllipsoidalCS EllipsoidalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.EllipsoidalCS; } }

        public global::GeoSik.Ogc.Gml.V321.CartesianCS CartesianCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CartesianCS; } }

        public global::GeoSik.Ogc.Gml.V321.VerticalCS VerticalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.VerticalCS; } }

        public global::GeoSik.Ogc.Gml.V321.TimeCS TimeCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeCS; } }

        public global::GeoSik.Ogc.Gml.V321.LinearCS LinearCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LinearCS; } }

        public global::GeoSik.Ogc.Gml.V321.UserDefinedCS UserDefinedCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.UserDefinedCS; } }

        public global::GeoSik.Ogc.Gml.V321.SphericalCS SphericalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.SphericalCS; } }

        public global::GeoSik.Ogc.Gml.V321.PolarCS PolarCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.PolarCS; } }

        public global::GeoSik.Ogc.Gml.V321.CylindricalCS CylindricalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CylindricalCS; } }

        public global::GeoSik.Ogc.Gml.V321.AffineCS AffineCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AffineCS; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractDatum AbstractDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractDatum; } }

        public global::GeoSik.Ogc.Gml.V321.anchorDefinition anchorDefinition { get { return rootObject as global::GeoSik.Ogc.Gml.V321.anchorDefinition; } }

        public global::GeoSik.Ogc.Gml.V321.realizationEpoch realizationEpoch { get { return rootObject as global::GeoSik.Ogc.Gml.V321.realizationEpoch; } }

        public global::GeoSik.Ogc.Gml.V321.GeodeticDatum GeodeticDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeodeticDatum; } }

        public global::GeoSik.Ogc.Gml.V321.primeMeridian primeMeridian { get { return rootObject as global::GeoSik.Ogc.Gml.V321.primeMeridian; } }

        public global::GeoSik.Ogc.Gml.V321.ellipsoid ellipsoid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ellipsoid; } }

        public global::GeoSik.Ogc.Gml.V321.Ellipsoid1 Ellipsoid1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Ellipsoid1; } }

        public global::GeoSik.Ogc.Gml.V321.semiMajorAxis semiMajorAxis { get { return rootObject as global::GeoSik.Ogc.Gml.V321.semiMajorAxis; } }

        public global::GeoSik.Ogc.Gml.V321.PrimeMeridian1 PrimeMeridian1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.PrimeMeridian1; } }

        public global::GeoSik.Ogc.Gml.V321.greenwichLongitude greenwichLongitude { get { return rootObject as global::GeoSik.Ogc.Gml.V321.greenwichLongitude; } }

        public global::GeoSik.Ogc.Gml.V321.EngineeringDatum EngineeringDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.EngineeringDatum; } }

        public global::GeoSik.Ogc.Gml.V321.ImageDatum ImageDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ImageDatum; } }

        public global::GeoSik.Ogc.Gml.V321.pixelInCell pixelInCell { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pixelInCell; } }

        public global::GeoSik.Ogc.Gml.V321.VerticalDatum VerticalDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.VerticalDatum; } }

        public global::GeoSik.Ogc.Gml.V321.TemporalDatum TemporalDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TemporalDatum; } }

        public global::GeoSik.Ogc.Gml.V321.origin origin { get { return rootObject as global::GeoSik.Ogc.Gml.V321.origin; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperation AbstractCoordinateOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperation; } }

        public global::GeoSik.Ogc.Gml.V321.operationVersion operationVersion { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationVersion; } }

        public global::GeoSik.Ogc.Gml.V321.sourceCRS sourceCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.sourceCRS; } }

        public global::GeoSik.Ogc.Gml.V321.targetCRS targetCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.targetCRS; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractSingleOperation AbstractSingleOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractSingleOperation; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversion AbstractGeneralConversion { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversion; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformation AbstractGeneralTransformation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformation; } }

        public global::GeoSik.Ogc.Gml.V321.ConcatenatedOperation ConcatenatedOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ConcatenatedOperation; } }

        public global::GeoSik.Ogc.Gml.V321.coordOperation coordOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordOperation; } }

        public global::GeoSik.Ogc.Gml.V321.PassThroughOperation PassThroughOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.PassThroughOperation; } }

        public global::GeoSik.Ogc.Gml.V321.modifiedCoordinate modifiedCoordinate { get { return rootObject as global::GeoSik.Ogc.Gml.V321.modifiedCoordinate; } }

        public global::GeoSik.Ogc.Gml.V321.Conversion Conversion { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Conversion; } }

        public global::GeoSik.Ogc.Gml.V321.method method { get { return rootObject as global::GeoSik.Ogc.Gml.V321.method; } }

        public global::GeoSik.Ogc.Gml.V321.parameterValue parameterValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.parameterValue; } }

        public global::GeoSik.Ogc.Gml.V321.Transformation Transformation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Transformation; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValue AbstractGeneralParameterValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValue; } }

        public global::GeoSik.Ogc.Gml.V321.ParameterValue1 ParameterValue1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ParameterValue1; } }

        public global::GeoSik.Ogc.Gml.V321.value value { get { return rootObject as global::GeoSik.Ogc.Gml.V321.value; } }

        public global::GeoSik.Ogc.Gml.V321.stringValue stringValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.stringValue; } }

        public global::GeoSik.Ogc.Gml.V321.integerValue integerValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.integerValue; } }

        public global::GeoSik.Ogc.Gml.V321.booleanValue booleanValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.booleanValue; } }

        public global::GeoSik.Ogc.Gml.V321.valueList valueList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueList; } }

        public global::GeoSik.Ogc.Gml.V321.integerValueList integerValueList { get { return rootObject as global::GeoSik.Ogc.Gml.V321.integerValueList; } }

        public global::GeoSik.Ogc.Gml.V321.valueFile valueFile { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueFile; } }

        public global::GeoSik.Ogc.Gml.V321.operationParameter operationParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationParameter; } }

        public global::GeoSik.Ogc.Gml.V321.ParameterValueGroup ParameterValueGroup { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ParameterValueGroup; } }

        public global::GeoSik.Ogc.Gml.V321.group group { get { return rootObject as global::GeoSik.Ogc.Gml.V321.group; } }

        public global::GeoSik.Ogc.Gml.V321.OperationMethod OperationMethod { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OperationMethod; } }

        public global::GeoSik.Ogc.Gml.V321.formula formula { get { return rootObject as global::GeoSik.Ogc.Gml.V321.formula; } }

        public global::GeoSik.Ogc.Gml.V321.sourceDimensions sourceDimensions { get { return rootObject as global::GeoSik.Ogc.Gml.V321.sourceDimensions; } }

        public global::GeoSik.Ogc.Gml.V321.targetDimensions targetDimensions { get { return rootObject as global::GeoSik.Ogc.Gml.V321.targetDimensions; } }

        public global::GeoSik.Ogc.Gml.V321.parameter parameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.parameter; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameter AbstractGeneralOperationParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameter; } }

        public global::GeoSik.Ogc.Gml.V321.minimumOccurs minimumOccurs { get { return rootObject as global::GeoSik.Ogc.Gml.V321.minimumOccurs; } }

        public global::GeoSik.Ogc.Gml.V321.OperationParameter1 OperationParameter1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OperationParameter1; } }

        public global::GeoSik.Ogc.Gml.V321.OperationParameterGroup OperationParameterGroup { get { return rootObject as global::GeoSik.Ogc.Gml.V321.OperationParameterGroup; } }

        public global::GeoSik.Ogc.Gml.V321.maximumOccurs maximumOccurs { get { return rootObject as global::GeoSik.Ogc.Gml.V321.maximumOccurs; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractSingleCRS AbstractSingleCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractSingleCRS; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRS AbstractGeneralDerivedCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRS; } }

        public global::GeoSik.Ogc.Gml.V321.conversion1 conversion1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.conversion1; } }

        public global::GeoSik.Ogc.Gml.V321.CompoundCRS CompoundCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.CompoundCRS; } }

        public global::GeoSik.Ogc.Gml.V321.componentReferenceSystem componentReferenceSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.componentReferenceSystem; } }

        public global::GeoSik.Ogc.Gml.V321.GeodeticCRS GeodeticCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeodeticCRS; } }

        public global::GeoSik.Ogc.Gml.V321.ellipsoidalCS1 ellipsoidalCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ellipsoidalCS1; } }

        public global::GeoSik.Ogc.Gml.V321.cartesianCS1 cartesianCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.cartesianCS1; } }

        public global::GeoSik.Ogc.Gml.V321.sphericalCS1 sphericalCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.sphericalCS1; } }

        public global::GeoSik.Ogc.Gml.V321.geodeticDatum1 geodeticDatum1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geodeticDatum1; } }

        public global::GeoSik.Ogc.Gml.V321.VerticalCRS VerticalCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.VerticalCRS; } }

        public global::GeoSik.Ogc.Gml.V321.verticalCS1 verticalCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.verticalCS1; } }

        public global::GeoSik.Ogc.Gml.V321.verticalDatum1 verticalDatum1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.verticalDatum1; } }

        public global::GeoSik.Ogc.Gml.V321.ProjectedCRS ProjectedCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ProjectedCRS; } }

        public global::GeoSik.Ogc.Gml.V321.baseGeodeticCRS baseGeodeticCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.baseGeodeticCRS; } }

        public global::GeoSik.Ogc.Gml.V321.DerivedCRS DerivedCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DerivedCRS; } }

        public global::GeoSik.Ogc.Gml.V321.baseCRS baseCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.baseCRS; } }

        public global::GeoSik.Ogc.Gml.V321.derivedCRSType derivedCRSType { get { return rootObject as global::GeoSik.Ogc.Gml.V321.derivedCRSType; } }

        public global::GeoSik.Ogc.Gml.V321.coordinateSystem coordinateSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinateSystem; } }

        public global::GeoSik.Ogc.Gml.V321.EngineeringCRS EngineeringCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.EngineeringCRS; } }

        public global::GeoSik.Ogc.Gml.V321.cylindricalCS1 cylindricalCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.cylindricalCS1; } }

        public global::GeoSik.Ogc.Gml.V321.linearCS1 linearCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.linearCS1; } }

        public global::GeoSik.Ogc.Gml.V321.polarCS1 polarCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.polarCS1; } }

        public global::GeoSik.Ogc.Gml.V321.userDefinedCS1 userDefinedCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.userDefinedCS1; } }

        public global::GeoSik.Ogc.Gml.V321.engineeringDatum1 engineeringDatum1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.engineeringDatum1; } }

        public global::GeoSik.Ogc.Gml.V321.ImageCRS ImageCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ImageCRS; } }

        public global::GeoSik.Ogc.Gml.V321.affineCS1 affineCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.affineCS1; } }

        public global::GeoSik.Ogc.Gml.V321.imageDatum1 imageDatum1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.imageDatum1; } }

        public global::GeoSik.Ogc.Gml.V321.TemporalCRS TemporalCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TemporalCRS; } }

        public global::GeoSik.Ogc.Gml.V321.timeCS1 timeCS1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.timeCS1; } }

        public global::GeoSik.Ogc.Gml.V321.temporalDatum1 temporalDatum1 { get { return rootObject as global::GeoSik.Ogc.Gml.V321.temporalDatum1; } }

        public global::GeoSik.Ogc.Gml.V321.Observation Observation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Observation; } }

        public global::GeoSik.Ogc.Gml.V321.@using @using { get { return rootObject as global::GeoSik.Ogc.Gml.V321.@using; } }

        public global::GeoSik.Ogc.Gml.V321.target target { get { return rootObject as global::GeoSik.Ogc.Gml.V321.target; } }

        public global::GeoSik.Ogc.Gml.V321.subject subject { get { return rootObject as global::GeoSik.Ogc.Gml.V321.subject; } }

        public global::GeoSik.Ogc.Gml.V321.resultOf resultOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.resultOf; } }

        public global::GeoSik.Ogc.Gml.V321.DirectedObservation DirectedObservation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DirectedObservation; } }

        public global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistance DirectedObservationAtDistance { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistance; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitive AbstractTimeTopologyPrimitive { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitive; } }

        public global::GeoSik.Ogc.Gml.V321.TimeTopologyComplex TimeTopologyComplex { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeTopologyComplex; } }

        public global::GeoSik.Ogc.Gml.V321.TimeNode TimeNode { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeNode; } }

        public global::GeoSik.Ogc.Gml.V321.TimeEdge TimeEdge { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeEdge; } }

        public global::GeoSik.Ogc.Gml.V321.TimeReferenceSystem TimeReferenceSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeReferenceSystem; } }

        public global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystem TimeCoordinateSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystem; } }

        public global::GeoSik.Ogc.Gml.V321.TimeCalendar TimeCalendar { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeCalendar; } }

        public global::GeoSik.Ogc.Gml.V321.TimeCalendarEra TimeCalendarEra { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeCalendarEra; } }

        public global::GeoSik.Ogc.Gml.V321.TimeClock TimeClock { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeClock; } }

        public global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystem TimeOrdinalReferenceSystem { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystem; } }

        public global::GeoSik.Ogc.Gml.V321.TimeOrdinalEra TimeOrdinalEra { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TimeOrdinalEra; } }

        public global::GeoSik.Ogc.Gml.V321.@Null @Null { get { return rootObject as global::GeoSik.Ogc.Gml.V321.@Null; } }

        public global::GeoSik.Ogc.Gml.V321.anchorPoint anchorPoint { get { return rootObject as global::GeoSik.Ogc.Gml.V321.anchorPoint; } }

        public global::GeoSik.Ogc.Gml.V321.datumRef datumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.datumRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesPrimeMeridian usesPrimeMeridian { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesPrimeMeridian; } }

        public global::GeoSik.Ogc.Gml.V321.usesEllipsoid usesEllipsoid { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesEllipsoid; } }

        public global::GeoSik.Ogc.Gml.V321.geodeticDatumRef geodeticDatumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geodeticDatumRef; } }

        public global::GeoSik.Ogc.Gml.V321.ellipsoidRef ellipsoidRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ellipsoidRef; } }

        public global::GeoSik.Ogc.Gml.V321.primeMeridianRef primeMeridianRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.primeMeridianRef; } }

        public global::GeoSik.Ogc.Gml.V321.engineeringDatumRef engineeringDatumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.engineeringDatumRef; } }

        public global::GeoSik.Ogc.Gml.V321.imageDatumRef imageDatumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.imageDatumRef; } }

        public global::GeoSik.Ogc.Gml.V321.verticalDatumRef verticalDatumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.verticalDatumRef; } }

        public global::GeoSik.Ogc.Gml.V321.temporalDatumRef temporalDatumRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.temporalDatumRef; } }

        public global::GeoSik.Ogc.Gml.V321.coordinateOperationRef coordinateOperationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinateOperationRef; } }

        public global::GeoSik.Ogc.Gml.V321.singleOperationRef singleOperationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.singleOperationRef; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractOperation AbstractOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractOperation; } }

        public global::GeoSik.Ogc.Gml.V321.operationRef operationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationRef; } }

        public global::GeoSik.Ogc.Gml.V321.generalConversionRef generalConversionRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.generalConversionRef; } }

        public global::GeoSik.Ogc.Gml.V321.generalTransformationRef generalTransformationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.generalTransformationRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesSingleOperation usesSingleOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesSingleOperation; } }

        public global::GeoSik.Ogc.Gml.V321.concatenatedOperationRef concatenatedOperationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.concatenatedOperationRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesOperation usesOperation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesOperation; } }

        public global::GeoSik.Ogc.Gml.V321.passThroughOperationRef passThroughOperationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.passThroughOperationRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesMethod usesMethod { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesMethod; } }

        public global::GeoSik.Ogc.Gml.V321.usesValue usesValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesValue; } }

        public global::GeoSik.Ogc.Gml.V321.conversionRef conversionRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.conversionRef; } }

        public global::GeoSik.Ogc.Gml.V321.transformationRef transformationRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.transformationRef; } }

        public global::GeoSik.Ogc.Gml.V321.dmsAngleValue dmsAngleValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dmsAngleValue; } }

        public global::GeoSik.Ogc.Gml.V321.valueOfParameter valueOfParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valueOfParameter; } }

        public global::GeoSik.Ogc.Gml.V321.includesValue includesValue { get { return rootObject as global::GeoSik.Ogc.Gml.V321.includesValue; } }

        public global::GeoSik.Ogc.Gml.V321.valuesOfGroup valuesOfGroup { get { return rootObject as global::GeoSik.Ogc.Gml.V321.valuesOfGroup; } }

        public global::GeoSik.Ogc.Gml.V321.methodFormula methodFormula { get { return rootObject as global::GeoSik.Ogc.Gml.V321.methodFormula; } }

        public global::GeoSik.Ogc.Gml.V321.usesParameter usesParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesParameter; } }

        public global::GeoSik.Ogc.Gml.V321.operationMethodRef operationMethodRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationMethodRef; } }

        public global::GeoSik.Ogc.Gml.V321.abstractGeneralOperationParameterRef abstractGeneralOperationParameterRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.abstractGeneralOperationParameterRef; } }

        public global::GeoSik.Ogc.Gml.V321.operationParameterRef operationParameterRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationParameterRef; } }

        public global::GeoSik.Ogc.Gml.V321.includesParameter includesParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.includesParameter; } }

        public global::GeoSik.Ogc.Gml.V321.operationParameterGroupRef operationParameterGroupRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.operationParameterGroupRef; } }

        public global::GeoSik.Ogc.Gml.V321.referenceSystemRef referenceSystemRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.referenceSystemRef; } }

        public global::GeoSik.Ogc.Gml.V321.crsRef crsRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.crsRef; } }

        public global::GeoSik.Ogc.Gml.V321.coordinateSystemAxisRef coordinateSystemAxisRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinateSystemAxisRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesAxis usesAxis { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesAxis; } }

        public global::GeoSik.Ogc.Gml.V321.coordinateSystemRef coordinateSystemRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinateSystemRef; } }

        public global::GeoSik.Ogc.Gml.V321.ellipsoidalCSRef ellipsoidalCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ellipsoidalCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.cartesianCSRef cartesianCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.cartesianCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.verticalCSRef verticalCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.verticalCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.TemporalCS TemporalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.TemporalCS; } }

        public global::GeoSik.Ogc.Gml.V321.temporalCSRef temporalCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.temporalCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.linearCSRef linearCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.linearCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.userDefinedCSRef userDefinedCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.userDefinedCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.sphericalCSRef sphericalCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.sphericalCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.polarCSRef polarCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.polarCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.cylindricalCSRef cylindricalCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.cylindricalCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCS ObliqueCartesianCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCS; } }

        public global::GeoSik.Ogc.Gml.V321.obliqueCartesianCSRef obliqueCartesianCSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.obliqueCartesianCSRef; } }

        public global::GeoSik.Ogc.Gml.V321.singleCRSRef singleCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.singleCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.definedByConversion definedByConversion { get { return rootObject as global::GeoSik.Ogc.Gml.V321.definedByConversion; } }

        public global::GeoSik.Ogc.Gml.V321.includesSingleCRS includesSingleCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.includesSingleCRS; } }

        public global::GeoSik.Ogc.Gml.V321.compoundCRSRef compoundCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.compoundCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesEllipsoidalCS usesEllipsoidalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesEllipsoidalCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesCartesianCS usesCartesianCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesCartesianCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesSphericalCS usesSphericalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesSphericalCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesGeodeticDatum usesGeodeticDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesGeodeticDatum; } }

        public global::GeoSik.Ogc.Gml.V321.usesVerticalCS usesVerticalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesVerticalCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesVerticalDatum usesVerticalDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesVerticalDatum; } }

        public global::GeoSik.Ogc.Gml.V321.verticalCRSRef verticalCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.verticalCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.baseGeographicCRS baseGeographicCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.baseGeographicCRS; } }

        public global::GeoSik.Ogc.Gml.V321.projectedCRSRef projectedCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.projectedCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesCS usesCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesCS; } }

        public global::GeoSik.Ogc.Gml.V321.derivedCRSRef derivedCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.derivedCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesEngineeringDatum usesEngineeringDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesEngineeringDatum; } }

        public global::GeoSik.Ogc.Gml.V321.engineeringCRSRef engineeringCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.engineeringCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesAffineCS usesAffineCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesAffineCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesImageDatum usesImageDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesImageDatum; } }

        public global::GeoSik.Ogc.Gml.V321.usesObliqueCartesianCS usesObliqueCartesianCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesObliqueCartesianCS; } }

        public global::GeoSik.Ogc.Gml.V321.imageCRSRef imageCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.imageCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.usesTimeCS usesTimeCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesTimeCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesTemporalCS usesTemporalCS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesTemporalCS; } }

        public global::GeoSik.Ogc.Gml.V321.usesTemporalDatum usesTemporalDatum { get { return rootObject as global::GeoSik.Ogc.Gml.V321.usesTemporalDatum; } }

        public global::GeoSik.Ogc.Gml.V321.temporalCRSRef temporalCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.temporalCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.GeographicCRS GeographicCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeographicCRS; } }

        public global::GeoSik.Ogc.Gml.V321.geographicCRSRef geographicCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geographicCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.GeocentricCRS GeocentricCRS { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GeocentricCRS; } }

        public global::GeoSik.Ogc.Gml.V321.geocentricCRSRef geocentricCRSRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.geocentricCRSRef; } }

        public global::GeoSik.Ogc.Gml.V321.dmsAngle dmsAngle { get { return rootObject as global::GeoSik.Ogc.Gml.V321.dmsAngle; } }

        public global::GeoSik.Ogc.Gml.V321.degrees degrees { get { return rootObject as global::GeoSik.Ogc.Gml.V321.degrees; } }

        public global::GeoSik.Ogc.Gml.V321.decimalMinutes decimalMinutes { get { return rootObject as global::GeoSik.Ogc.Gml.V321.decimalMinutes; } }

        public global::GeoSik.Ogc.Gml.V321.minutes minutes { get { return rootObject as global::GeoSik.Ogc.Gml.V321.minutes; } }

        public global::GeoSik.Ogc.Gml.V321.seconds seconds { get { return rootObject as global::GeoSik.Ogc.Gml.V321.seconds; } }

        public global::GeoSik.Ogc.Gml.V321.member member { get { return rootObject as global::GeoSik.Ogc.Gml.V321.member; } }

        public global::GeoSik.Ogc.Gml.V321.members members { get { return rootObject as global::GeoSik.Ogc.Gml.V321.members; } }

        public global::GeoSik.Ogc.Gml.V321.metaDataProperty metaDataProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.metaDataProperty; } }

        public global::GeoSik.Ogc.Gml.V321.Bag Bag { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Bag; } }

        public global::GeoSik.Ogc.Gml.V321.Array Array { get { return rootObject as global::GeoSik.Ogc.Gml.V321.Array; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractMetaData AbstractMetaData { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractMetaData; } }

        public global::GeoSik.Ogc.Gml.V321.GenericMetaData GenericMetaData { get { return rootObject as global::GeoSik.Ogc.Gml.V321.GenericMetaData; } }

        public global::GeoSik.Ogc.Gml.V321.coordinates coordinates { get { return rootObject as global::GeoSik.Ogc.Gml.V321.coordinates; } }

        public global::GeoSik.Ogc.Gml.V321.pointRep pointRep { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pointRep; } }

        public global::GeoSik.Ogc.Gml.V321.location location { get { return rootObject as global::GeoSik.Ogc.Gml.V321.location; } }

        public global::GeoSik.Ogc.Gml.V321.LocationString LocationString { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LocationString; } }

        public global::GeoSik.Ogc.Gml.V321.LocationKeyWord LocationKeyWord { get { return rootObject as global::GeoSik.Ogc.Gml.V321.LocationKeyWord; } }

        public global::GeoSik.Ogc.Gml.V321.priorityLocation priorityLocation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.priorityLocation; } }

        public global::GeoSik.Ogc.Gml.V321.featureMember featureMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.featureMember; } }

        public global::GeoSik.Ogc.Gml.V321.featureProperty featureProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.featureProperty; } }

        public global::GeoSik.Ogc.Gml.V321.featureMembers featureMembers { get { return rootObject as global::GeoSik.Ogc.Gml.V321.featureMembers; } }

        public global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollection AbstractFeatureCollection { get { return rootObject as global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollection; } }

        public global::GeoSik.Ogc.Gml.V321.FeatureCollection FeatureCollection { get { return rootObject as global::GeoSik.Ogc.Gml.V321.FeatureCollection; } }

        public global::GeoSik.Ogc.Gml.V321.track track { get { return rootObject as global::GeoSik.Ogc.Gml.V321.track; } }

        public global::GeoSik.Ogc.Gml.V321.DefinitionCollection DefinitionCollection { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DefinitionCollection; } }

        public global::GeoSik.Ogc.Gml.V321.definitionMember definitionMember { get { return rootObject as global::GeoSik.Ogc.Gml.V321.definitionMember; } }

        public global::GeoSik.Ogc.Gml.V321.indirectEntry indirectEntry { get { return rootObject as global::GeoSik.Ogc.Gml.V321.indirectEntry; } }

        public global::GeoSik.Ogc.Gml.V321.DefinitionProxy DefinitionProxy { get { return rootObject as global::GeoSik.Ogc.Gml.V321.DefinitionProxy; } }

        public global::GeoSik.Ogc.Gml.V321.definitionRef definitionRef { get { return rootObject as global::GeoSik.Ogc.Gml.V321.definitionRef; } }

        public global::GeoSik.Ogc.Gml.V321.MappingRule MappingRule { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MappingRule; } }

        public global::GeoSik.Ogc.Gml.V321.centerOf centerOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.centerOf; } }

        public global::GeoSik.Ogc.Gml.V321.position position { get { return rootObject as global::GeoSik.Ogc.Gml.V321.position; } }

        public global::GeoSik.Ogc.Gml.V321.extentOf extentOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.extentOf; } }

        public global::GeoSik.Ogc.Gml.V321.edgeOf edgeOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.edgeOf; } }

        public global::GeoSik.Ogc.Gml.V321.centerLineOf centerLineOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.centerLineOf; } }

        public global::GeoSik.Ogc.Gml.V321.multiLocation multiLocation { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiLocation; } }

        public global::GeoSik.Ogc.Gml.V321.multiCenterOf multiCenterOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiCenterOf; } }

        public global::GeoSik.Ogc.Gml.V321.multiPosition multiPosition { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiPosition; } }

        public global::GeoSik.Ogc.Gml.V321.multiCenterLineOf multiCenterLineOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiCenterLineOf; } }

        public global::GeoSik.Ogc.Gml.V321.multiEdgeOf multiEdgeOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiEdgeOf; } }

        public global::GeoSik.Ogc.Gml.V321.multiCoverage multiCoverage { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiCoverage; } }

        public global::GeoSik.Ogc.Gml.V321.multiExtentOf multiExtentOf { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiExtentOf; } }

        public global::GeoSik.Ogc.Gml.V321.polygonPatches polygonPatches { get { return rootObject as global::GeoSik.Ogc.Gml.V321.polygonPatches; } }

        public global::GeoSik.Ogc.Gml.V321.trianglePatches trianglePatches { get { return rootObject as global::GeoSik.Ogc.Gml.V321.trianglePatches; } }

        public global::GeoSik.Ogc.Gml.V321.multiPointDomain multiPointDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiPointDomain; } }

        public global::GeoSik.Ogc.Gml.V321.multiCurveDomain multiCurveDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiCurveDomain; } }

        public global::GeoSik.Ogc.Gml.V321.multiSurfaceDomain multiSurfaceDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiSurfaceDomain; } }

        public global::GeoSik.Ogc.Gml.V321.multiSolidDomain multiSolidDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiSolidDomain; } }

        public global::GeoSik.Ogc.Gml.V321.gridDomain gridDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.gridDomain; } }

        public global::GeoSik.Ogc.Gml.V321.rectifiedGridDomain rectifiedGridDomain { get { return rootObject as global::GeoSik.Ogc.Gml.V321.rectifiedGridDomain; } }

        public global::GeoSik.Ogc.Gml.V321.generalOperationParameter generalOperationParameter { get { return rootObject as global::GeoSik.Ogc.Gml.V321.generalOperationParameter; } }

        public global::GeoSik.Ogc.Gml.V321.MovingObjectStatus MovingObjectStatus { get { return rootObject as global::GeoSik.Ogc.Gml.V321.MovingObjectStatus; } }

        public global::GeoSik.Ogc.Gml.V321.status status { get { return rootObject as global::GeoSik.Ogc.Gml.V321.status; } }

        public global::GeoSik.Ogc.Gml.V321.statusReference statusReference { get { return rootObject as global::GeoSik.Ogc.Gml.V321.statusReference; } }

        public global::GeoSik.Ogc.Gml.V321.topoComplexProperty topoComplexProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.topoComplexProperty; } }

        public global::GeoSik.Ogc.Gml.V321.multiPointProperty multiPointProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiPointProperty; } }

        public global::GeoSik.Ogc.Gml.V321.multiCurveProperty multiCurveProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiCurveProperty; } }

        public global::GeoSik.Ogc.Gml.V321.multiSurfaceProperty multiSurfaceProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiSurfaceProperty; } }

        public global::GeoSik.Ogc.Gml.V321.multiSolidProperty multiSolidProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiSolidProperty; } }

        public global::GeoSik.Ogc.Gml.V321.multiGeometryProperty multiGeometryProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.multiGeometryProperty; } }

        public global::GeoSik.Ogc.Gml.V321.pointArrayProperty pointArrayProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.pointArrayProperty; } }

        public global::GeoSik.Ogc.Gml.V321.curveArrayProperty curveArrayProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.curveArrayProperty; } }

        public global::GeoSik.Ogc.Gml.V321.surfaceArrayProperty surfaceArrayProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.surfaceArrayProperty; } }

        public global::GeoSik.Ogc.Gml.V321.solidArrayProperty solidArrayProperty { get { return rootObject as global::GeoSik.Ogc.Gml.V321.solidArrayProperty; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent EX_TemporalExtent { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent EX_VerticalExtent { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon EX_BoundingPolygon { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_Extent EX_Extent { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_Extent; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent AbstractEX_GeographicExtent { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox EX_GeographicBoundingBox { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent EX_SpatialTemporalExtent { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent; } }

        public global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription EX_GeographicDescription { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription; } }

        public global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier RS_Identifier { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem MD_ReferenceSystem { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier MD_Identifier { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem AbstractRS_ReferenceSystem { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty CI_ResponsibleParty { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Citation CI_Citation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Citation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Address CI_Address { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Address; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource CI_OnlineResource { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Contact CI_Contact { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Contact; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone CI_Telephone { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Date CI_Date { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Date; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_Series CI_Series { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_Series; } }

        public global::GeoSik.Iso.Ts19139.Gmd.URL URL { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.URL; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_RoleCode CI_RoleCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_RoleCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode CI_PresentationFormCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode CI_OnLineFunctionCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode CI_DateTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation MD_GridSpatialRepresentation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation MD_VectorSpatialRepresentation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation AbstractMD_SpatialRepresentation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable MD_Georeferenceable { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension MD_Dimension { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified MD_Georectified { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects MD_GeometricObjects { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_PixelOrientationCode MD_PixelOrientationCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_PixelOrientationCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode MD_TopologyLevelCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode MD_GeometricObjectTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode MD_CellGeometryCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode MD_DimensionNameTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation MD_ExtendedElementInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation MD_MetadataExtensionInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ObligationCode MD_ObligationCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ObligationCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode MD_DatatypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription MD_FeatureCatalogueDescription { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription MD_CoverageDescription { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription MD_ImageDescription { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation AbstractMD_ContentInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension MD_RangeDimension { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Band MD_Band { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Band; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode MD_CoverageContentTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode MD_ImagingConditionCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation MD_ApplicationSchemaInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference MD_PortrayalCatalogueReference { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference; } }

        public global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep LI_ProcessStep { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep; } }

        public global::GeoSik.Iso.Ts19139.Gmd.LI_Source LI_Source { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.LI_Source; } }

        public global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage LI_Lineage { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult DQ_ConformanceResult { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult DQ_QuantitativeResult { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result AbstractDQ_Result { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity DQ_TemporalValidity { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency DQ_TemporalConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement DQ_AccuracyOfATimeMeasurement { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy DQ_QuantitativeAttributeAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy DQ_NonQuantitativeAttributeAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness DQ_ThematicClassificationCorrectness { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy DQ_RelativeInternalPositionalAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy DQ_GriddedDataPositionalAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy DQ_AbsoluteExternalPositionalAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency DQ_TopologicalConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency DQ_FormatConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency DQ_DomainConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency DQ_ConceptualConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission DQ_CompletenessOmission { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission DQ_CompletenessCommission { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy AbstractDQ_TemporalAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy AbstractDQ_ThematicAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy AbstractDQ_PositionalAccuracy { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency AbstractDQ_LogicalConsistency { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness AbstractDQ_Completeness { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element AbstractDQ_Element { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality DQ_DataQuality { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope DQ_Scope { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode DQ_EvaluationMethodTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints MD_Constraints { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints MD_LegalConstraints { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints MD_SecurityConstraints { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode MD_ClassificationCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode MD_RestrictionCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Medium MD_Medium { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Medium; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions MD_DigitalTransferOptions { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess MD_StandardOrderProcess { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor MD_Distributor { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution MD_Distribution { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Format MD_Format { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Format; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits MD_DistributionUnits { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode MD_MediumFormatCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode MD_MediumNameCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation MD_MaintenanceInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription MD_ScopeDescription { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode MD_MaintenanceFrequencyCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode MD_ScopeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification AbstractMD_Identification { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic MD_BrowseGraphic { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification MD_DataIdentification { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification MD_ServiceIdentification { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction MD_RepresentativeFraction { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Usage MD_Usage { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Usage; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords MD_Keywords { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_Association DS_Association { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_Association; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation MD_AggregateInformation { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution MD_Resolution { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_TopicCategoryCode MD_TopicCategoryCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_TopicCategoryCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode MD_CharacterSetCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode MD_SpatialRepresentationTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode MD_ProgressCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode MD_KeywordTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode DS_AssociationTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode DS_InitiativeTypeCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText PT_FreeText { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText; } }

        public global::GeoSik.Iso.Ts19139.Gmd.PT_Locale PT_Locale { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.PT_Locale; } }

        public global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString LocalisedCharacterString { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString; } }

        public global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer PT_LocaleContainer { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer; } }

        public global::GeoSik.Iso.Ts19139.Gmd.LanguageCode LanguageCode { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.LanguageCode; } }

        public global::GeoSik.Iso.Ts19139.Gmd.Country Country { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.Country; } }

        public global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata MD_Metadata { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata; } }

        public global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate AbstractDS_Aggregate { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet DS_DataSet { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate DS_OtherAggregate { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_Series DS_Series { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_Series; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative DS_Initiative { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_Platform DS_Platform { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_Platform; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor DS_Sensor { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries DS_ProductionSeries { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries; } }

        public global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate DS_StereoMate { get { return rootObject as global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate; } }

        public global::GeoSik.Iso.Ts19139.Gts.TM_PeriodDuration TM_PeriodDuration { get { return rootObject as global::GeoSik.Iso.Ts19139.Gts.TM_PeriodDuration; } }

        private XRoot()
        {
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Record root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.AbstractObject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.TypeName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.MemberName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Multiplicity root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.MultiplicityRange root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Measure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Length root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Angle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Scale root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Distance root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.CharacterString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Boolean root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.AbstractGenericName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.LocalName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.ScopedName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.DateTime root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Date root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.@Decimal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Real root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Integer root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.UnlimitedInteger root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.RecordType root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gco.Binary root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractObject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Boolean root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Category root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Count root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Quantity root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractScalarValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractScalarValueList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.domainOfValidity root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.secondDefiningParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.SecondDefiningParameter1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinateOperationAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.formulaCitation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGML root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.abstractAssociationRole root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.abstractStrictAssociationRole root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.abstractReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.abstractInlineProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.reversePropertyName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.description root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.descriptionReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.name root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.targetElement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.associationName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.defaultCodeSpace root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.gmlProfileSchema root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Definition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.remarks root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Dictionary root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dictionaryEntry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.unitOfMeasure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.UnitDefinition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.quantityType root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.quantityTypeReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.catalogSymbol root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.BaseUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DerivedUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.derivationUnitTerm root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ConventionalUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.conversionToPreferredUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.roughConversionToPreferredUnit root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.measure root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.angle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeometry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pos root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.posList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.vector root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Envelope root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeometricPrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Point root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pointProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.curveProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LineString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.surfaceProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Polygon root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.exterior root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.interior root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractRing root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LinearRing root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Curve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.baseCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OrientableCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCurveSegment root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.segments root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LineStringSegment root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ArcString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Arc root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Circle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ArcStringByBulge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ArcByBulge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ArcByCenterPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CircleByCenterPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CubicSpline root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.BSpline root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Bezier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OffsetCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AffinePlacement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Clothoid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeodesicString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Geodesic root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Surface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.baseSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OrientableSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractSurfacePatch root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.patches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.PolygonPatch root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Triangle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Rectangle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Ring root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.curveMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractParametricCurveSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGriddedSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Cone root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Cylinder root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Sphere root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.PolyhedralSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TriangulatedSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Tin root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.solidProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Solid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Shell root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.surfaceMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeometricAggregate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiGeometry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geometryMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geometryMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pointMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pointMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.curveMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.surfaceMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.solidMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.solidMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimeObject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimePrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.validTime root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimeComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimeGeometricPrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeInstant root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimePeriod root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.timePosition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.duration root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.timeInterval root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractFeature root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.boundedBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.EnvelopeWithTimePeriod root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.locationName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.locationReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.direction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dataSource root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dataSourceReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DynamicFeature root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DynamicFeatureCollection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dynamicMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimeSlice root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.history root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeometricComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CompositeCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CompositeSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CompositeSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTopology root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTopoPrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Node root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.directedNode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Edge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.directedEdge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Face root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.directedFace root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.directedTopoSolid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoPointProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoCurve root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoCurveProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoSurface root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoSurfaceProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoVolume root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoVolumeProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TopoComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.subComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.superComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.maximalComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoPrimitiveMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoPrimitiveMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.BooleanList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CategoryList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CountList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.QuantityList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueComponent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueComponents root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CompositeValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ValueArray root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CategoryExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CountExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.QuantityExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Grid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractImplicitGeometry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.RectifiedGrid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractDiscreteCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractContinuousCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.domainSet root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.rangeSet root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DataBlock root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.rangeParameters root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.tupleList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.doubleOrNilReasonTupleList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.File root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coverageFunction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CoverageMappingRule root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GridFunction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiPointCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiCurveCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiSurfaceCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MultiSolidCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GridCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.RectifiedGridCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.scope root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CoordinateSystemAxis root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.axisAbbrev root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.axisDirection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.minimumValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.maximumValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.rangeMeaning root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.axis root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.EllipsoidalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CartesianCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.VerticalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LinearCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.UserDefinedCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.SphericalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.PolarCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CylindricalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AffineCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.anchorDefinition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.realizationEpoch root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeodeticDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.primeMeridian root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ellipsoid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Ellipsoid1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.semiMajorAxis root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.PrimeMeridian1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.greenwichLongitude root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.EngineeringDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ImageDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pixelInCell root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.VerticalDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TemporalDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.origin root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractCoordinateOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationVersion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.sourceCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.targetCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractSingleOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeneralConversion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeneralTransformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ConcatenatedOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.PassThroughOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.modifiedCoordinate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Conversion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.method root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.parameterValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Transformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeneralParameterValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ParameterValue1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.value root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.stringValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.integerValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.booleanValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.integerValueList root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueFile root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ParameterValueGroup root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.group root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OperationMethod root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.formula root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.sourceDimensions root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.targetDimensions root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.parameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeneralOperationParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.minimumOccurs root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OperationParameter1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.OperationParameterGroup root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.maximumOccurs root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractSingleCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractGeneralDerivedCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.conversion1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.CompoundCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.componentReferenceSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeodeticCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ellipsoidalCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.cartesianCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.sphericalCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geodeticDatum1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.VerticalCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.verticalCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.verticalDatum1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ProjectedCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.baseGeodeticCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DerivedCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.baseCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.derivedCRSType root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinateSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.EngineeringCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.cylindricalCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.linearCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.polarCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.userDefinedCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.engineeringDatum1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ImageCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.affineCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.imageDatum1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TemporalCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.timeCS1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.temporalDatum1 root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Observation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.@using root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.target root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.subject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.resultOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DirectedObservation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DirectedObservationAtDistance root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractTimeTopologyPrimitive root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeTopologyComplex root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeNode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeEdge root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeReferenceSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeCoordinateSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeCalendar root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeCalendarEra root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeClock root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeOrdinalReferenceSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TimeOrdinalEra root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.@Null root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.anchorPoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.datumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesPrimeMeridian root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesEllipsoid root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geodeticDatumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ellipsoidRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.primeMeridianRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.engineeringDatumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.imageDatumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.verticalDatumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.temporalDatumRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinateOperationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.singleOperationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.generalConversionRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.generalTransformationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesSingleOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.concatenatedOperationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesOperation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.passThroughOperationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesMethod root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.conversionRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.transformationRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dmsAngleValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valueOfParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.includesValue root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.valuesOfGroup root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.methodFormula root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationMethodRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.abstractGeneralOperationParameterRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationParameterRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.includesParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.operationParameterGroupRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.referenceSystemRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.crsRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinateSystemAxisRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesAxis root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinateSystemRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ellipsoidalCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.cartesianCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.verticalCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.TemporalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.temporalCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.linearCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.userDefinedCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.sphericalCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.polarCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.cylindricalCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.ObliqueCartesianCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.obliqueCartesianCSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.singleCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.definedByConversion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.includesSingleCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.compoundCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesEllipsoidalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesCartesianCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesSphericalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesGeodeticDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesVerticalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesVerticalDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.verticalCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.baseGeographicCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.projectedCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.derivedCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesEngineeringDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.engineeringCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesAffineCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesImageDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesObliqueCartesianCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.imageCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesTimeCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesTemporalCS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.usesTemporalDatum root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.temporalCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeographicCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geographicCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GeocentricCRS root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.geocentricCRSRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.dmsAngle root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.degrees root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.decimalMinutes root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.minutes root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.seconds root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.member root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.members root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.metaDataProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Bag root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.Array root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractMetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.GenericMetaData root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.coordinates root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pointRep root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.location root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LocationString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.LocationKeyWord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.priorityLocation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.featureMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.featureProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.featureMembers root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.AbstractFeatureCollection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.FeatureCollection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.track root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DefinitionCollection root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.definitionMember root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.indirectEntry root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.DefinitionProxy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.definitionRef root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MappingRule root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.centerOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.position root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.extentOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.edgeOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.centerLineOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiLocation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiCenterOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiPosition root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiCenterLineOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiEdgeOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiCoverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiExtentOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.polygonPatches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.trianglePatches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiPointDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiCurveDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiSurfaceDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiSolidDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.gridDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.rectifiedGridDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.generalOperationParameter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.MovingObjectStatus root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.status root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.statusReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.topoComplexProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiPointProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiCurveProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiSurfaceProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiSolidProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.multiGeometryProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.pointArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.curveArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.surfaceArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Ogc.Gml.V321.solidArrayProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_TemporalExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_VerticalExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_BoundingPolygon root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_Extent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractEX_GeographicExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicBoundingBox root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_SpatialTemporalExtent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.EX_GeographicDescription root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.RS_Identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ReferenceSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractRS_ReferenceSystem root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_ResponsibleParty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Citation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Address root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_OnlineResource root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Contact root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Telephone root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Date root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_Series root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.URL root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_RoleCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_PresentationFormCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_OnLineFunctionCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.CI_DateTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_GridSpatialRepresentation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_VectorSpatialRepresentation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_SpatialRepresentation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Georeferenceable root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Dimension root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Georectified root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjects root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_PixelOrientationCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_TopologyLevelCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_GeometricObjectTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_CellGeometryCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_DimensionNameTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ExtendedElementInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_MetadataExtensionInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ObligationCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_DatatypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_FeatureCatalogueDescription root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageDescription root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ImageDescription root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_ContentInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_RangeDimension root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Band root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_CoverageContentTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ImagingConditionCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ApplicationSchemaInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_PortrayalCatalogueReference root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.LI_ProcessStep root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.LI_Source root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.LI_Lineage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConformanceResult root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeResult root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Result root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalValidity root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_TemporalConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_AccuracyOfATimeMeasurement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_QuantitativeAttributeAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_NonQuantitativeAttributeAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_ThematicClassificationCorrectness root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_RelativeInternalPositionalAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_GriddedDataPositionalAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_AbsoluteExternalPositionalAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_TopologicalConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_FormatConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_DomainConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_ConceptualConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessOmission root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_CompletenessCommission root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_TemporalAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_ThematicAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_PositionalAccuracy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_LogicalConsistency root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Completeness root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDQ_Element root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_DataQuality root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_Scope root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DQ_EvaluationMethodTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Constraints root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_LegalConstraints root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_SecurityConstraints root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ClassificationCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_RestrictionCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Medium root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_DigitalTransferOptions root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_StandardOrderProcess root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Distributor root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Distribution root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Format root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_DistributionUnits root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumFormatCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_MediumNameCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeDescription root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_MaintenanceFrequencyCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ScopeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractMD_Identification root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_BrowseGraphic root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_DataIdentification root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ServiceIdentification root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_RepresentativeFraction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Usage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Keywords root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_Association root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_AggregateInformation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Resolution root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_TopicCategoryCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_CharacterSetCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_SpatialRepresentationTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_ProgressCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_KeywordTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_AssociationTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_InitiativeTypeCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.PT_FreeText root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.PT_Locale root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.LocalisedCharacterString root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.PT_LocaleContainer root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.LanguageCode root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.Country root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.MD_Metadata root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.AbstractDS_Aggregate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_DataSet root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_OtherAggregate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_Series root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_Initiative root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_Platform root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_Sensor root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_ProductionSeries root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gmd.DS_StereoMate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRoot(global::GeoSik.Iso.Ts19139.Gts.TM_PeriodDuration root)
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
#pragma warning restore 108, 1591, 3002, 3003, 3009
