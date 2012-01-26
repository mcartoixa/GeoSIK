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

#pragma warning disable 3002, 3009
namespace OgcToolkit.Iso.Ts19139.Gts
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
    using OgcToolkit.Iso.Ts19139.Gco;


    /// <summary>
    /// <para>
    /// Regular expression: (AbstractTimePrimitive)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TM_Primitive_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TM_Primitive_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TM_Primitive_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<TM_Primitive_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TM_Primitive_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("AbstractTimePrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractTimeGeometricPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("TimeInstant", "http://www.opengis.net/gml/3.2"), XName.Get("TimePeriod", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractTimeTopologyPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("TimeNode", "http://www.opengis.net/gml/3.2"), XName.Get("TimeEdge", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (AbstractTimePrimitive)?
        /// </para>
        /// </summary>
        public TM_Primitive_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: AbstractTimePrimitive, AbstractTimeGeometricPrimitive, TimeInstant, TimePeriod, AbstractTimeTopologyPrimitive, TimeNode, TimeEdge
        /// </para>
        /// <para>
        /// Regular expression: (AbstractTimePrimitive)?
        /// </para>
        /// </summary>
        public OgcToolkit.Ogc.Gml.V321.AbstractTimePrimitive AbstractTimePrimitive
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractTimePrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractTimeGeometricPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("TimeInstant", "http://www.opengis.net/gml/3.2"), XName.Get("TimePeriod", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractTimeTopologyPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("TimeNode", "http://www.opengis.net/gml/3.2"), XName.Get("TimeEdge", "http://www.opengis.net/gml/3.2"));
                return ((OgcToolkit.Ogc.Gml.V321.AbstractTimePrimitive)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractTimePrimitive", "http://www.opengis.net/gml/3.2"), value);
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
                return XTypedServices.ParseUnionValue(x, global::OgcToolkit.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::OgcToolkit.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("TM_Primitive_PropertyType", "http://www.isotc211.org/2005/gts");
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
            return XTypedServices.CloneXTypedElement<TM_Primitive_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractTimePrimitive", "http://www.opengis.net/gml/3.2"), typeof(OgcToolkit.Ogc.Gml.V321.AbstractTimePrimitive));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TM_Primitive_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TM_Primitive_PropertyType", "http://www.isotc211.org/2005/gts");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (TM_PeriodDuration)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TM_PeriodDuration_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TM_PeriodDuration_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TM_PeriodDuration_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<TM_PeriodDuration_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TM_PeriodDuration_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (TM_PeriodDuration)?
        /// </para>
        /// </summary>
        public TM_PeriodDuration_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (TM_PeriodDuration)?
        /// </para>
        /// </summary>
        public TM_PeriodDuration TM_PeriodDuration
        {
            get
            {
                XElement x=this.GetElement(XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts"));
                if ((x==null))
                {
                    return null;
                }
                return ((TM_PeriodDuration)(x));
            }
            set
            {
                this.SetElement(XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts"), value);
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
                return XTypedServices.ParseUnionValue(x, global::OgcToolkit.Ogc.Gml.V321.NilReasonType.TypeDefinition);
            }
            set
            {
                this.SetUnionAttribute(value, "nilReason", this, XName.Get("nilReason", "http://www.isotc211.org/2005/gco"), global::OgcToolkit.Ogc.Gml.V321.NilReasonType.TypeDefinition);
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
                return XName.Get("TM_PeriodDuration_PropertyType", "http://www.isotc211.org/2005/gts");
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
            return XTypedServices.CloneXTypedElement<TM_PeriodDuration_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts"), typeof(TM_PeriodDuration));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TM_PeriodDuration_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TM_PeriodDuration_PropertyType", "http://www.isotc211.org/2005/gts");
        }
    }

    [XmlSchemaProviderAttribute("TM_PeriodDurationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TM_PeriodDuration: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator TM_PeriodDuration(XElement xe) { return XTypedServices.ToXTypedElement<TM_PeriodDuration>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public TM_PeriodDuration()
        {
        }

        public TM_PeriodDuration(System.TimeSpan content)
        {
            this.TypedValue=content;
        }

        public System.TimeSpan TypedValue
        {
            get
            {
                XElement x=this.Untyped;
                return XTypedServices.ParseValue<System.TimeSpan>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Duration).Datatype);
            }
            set
            {
                this.SetValue(value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Duration).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("TM_PeriodDuration", "http://www.isotc211.org/2005/gts");
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

        public static TM_PeriodDuration Load(string xmlFile)
        {
            return XTypedServices.Load<TM_PeriodDuration>(xmlFile);
        }

        public static TM_PeriodDuration Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<TM_PeriodDuration>(xmlFile);
        }

        public static TM_PeriodDuration Parse(string xml)
        {
            return XTypedServices.Parse<TM_PeriodDuration>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<TM_PeriodDuration>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TM_PeriodDurationSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("TM_PeriodDuration", "http://www.isotc211.org/2005/gts")]));
            if ((element!=null))
            {
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


        public TM_PeriodDuration TM_PeriodDuration { get { return rootObject as TM_PeriodDuration; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(TM_PeriodDuration root)
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
}
#pragma warning restore 3002, 3009
