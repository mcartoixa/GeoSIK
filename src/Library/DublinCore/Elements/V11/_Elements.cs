#pragma warning disable 108, 114, 3002, 3009
namespace OgcToolkit.DublinCore.Elements.V11
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
    using OgcToolkit.Ogc.Ows.V100;


    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SimpleLiteralSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SimpleLiteral: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator SimpleLiteral(XElement xe) { return XTypedServices.ToXTypedElement<SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public SimpleLiteral()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri scheme
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("scheme", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("scheme", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SimpleLiteral", "http://purl.org/dc/elements/1.1/");
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
            return XTypedServices.CloneXTypedElement<SimpleLiteral>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName SimpleLiteralSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SimpleLiteral", "http://purl.org/dc/elements/1.1/");
        }
    }

    /// <summary>
    /// <para>
    /// This type definition is included as a convenience for schema authors 
    ///      who need a container element for all of the DC elements.
    /// </para>
    /// <para>
    /// Regular expression: (((DCelement)*))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("elementContainerSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class elementContainer: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<DCelement> DCelementField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator elementContainer(XElement xe) { return XTypedServices.ToXTypedElement<elementContainer>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static elementContainer()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// This type definition is included as a convenience for schema authors 
        ///      who need a container element for all of the DC elements.
        /// </para>
        /// <para>
        /// Regular expression: (((DCelement)*))
        /// </para>
        /// </summary>
        public elementContainer()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: DC-element, abstract, accessRights, alternative, audience, available, bibliographicCitation, conformsTo, created, dateAccepted, dateCopyrighted, dateSubmitted, educationLevel, extent, hasFormat, hasPart, hasVersion, isFormatOf, isPartOf, isReferencedBy, isReplacedBy, isRequiredBy, issued, isVersionOf, license, mediator, medium, modified, provenance, references, replaces, requires, rightsHolder, spatial, tableOfContents, temporal, valid, title, creator, subject, description, publisher, contributor, date, type, format, identifier, source, language, relation, coverage, rights
        /// </para>
        /// <para>
        /// Regular expression: (((DCelement)*))
        /// </para>
        /// </summary>
        public IList<DCelement> DCelement
        {
            get
            {
                if ((this.DCelementField==null))
                {
                    this.DCelementField=new XTypedSubstitutedList<DCelement>(this, LinqToXsdTypeManager.Instance, XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), XName.Get("abstract", "http://purl.org/dc/terms/"), XName.Get("accessRights", "http://purl.org/dc/terms/"), XName.Get("alternative", "http://purl.org/dc/terms/"), XName.Get("audience", "http://purl.org/dc/terms/"), XName.Get("available", "http://purl.org/dc/terms/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("created", "http://purl.org/dc/terms/"), XName.Get("dateAccepted", "http://purl.org/dc/terms/"), XName.Get("dateCopyrighted", "http://purl.org/dc/terms/"), XName.Get("dateSubmitted", "http://purl.org/dc/terms/"), XName.Get("educationLevel", "http://purl.org/dc/terms/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("issued", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("license", "http://purl.org/dc/terms/"), XName.Get("mediator", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"), XName.Get("modified", "http://purl.org/dc/terms/"), XName.Get("provenance", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"), XName.Get("rightsHolder", "http://purl.org/dc/terms/"), XName.Get("spatial", "http://purl.org/dc/terms/"), XName.Get("tableOfContents", "http://purl.org/dc/terms/"), XName.Get("temporal", "http://purl.org/dc/terms/"), XName.Get("valid", "http://purl.org/dc/terms/"), XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("creator", "http://purl.org/dc/elements/1.1/"), XName.Get("subject", "http://purl.org/dc/elements/1.1/"), XName.Get("description", "http://purl.org/dc/elements/1.1/"), XName.Get("publisher", "http://purl.org/dc/elements/1.1/"), XName.Get("contributor", "http://purl.org/dc/elements/1.1/"), XName.Get("date", "http://purl.org/dc/elements/1.1/"), XName.Get("type", "http://purl.org/dc/elements/1.1/"), XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("source", "http://purl.org/dc/elements/1.1/"), XName.Get("language", "http://purl.org/dc/elements/1.1/"), XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("coverage", "http://purl.org/dc/elements/1.1/"), XName.Get("rights", "http://purl.org/dc/elements/1.1/"));
                }
                return this.DCelementField;
            }
            set
            {
                if ((value==null))
                {
                    this.DCelementField=null;
                } else
                {
                    if ((this.DCelementField==null))
                    {
                        this.DCelementField=XTypedSubstitutedList<DCelement>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), XName.Get("abstract", "http://purl.org/dc/terms/"), XName.Get("accessRights", "http://purl.org/dc/terms/"), XName.Get("alternative", "http://purl.org/dc/terms/"), XName.Get("audience", "http://purl.org/dc/terms/"), XName.Get("available", "http://purl.org/dc/terms/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("created", "http://purl.org/dc/terms/"), XName.Get("dateAccepted", "http://purl.org/dc/terms/"), XName.Get("dateCopyrighted", "http://purl.org/dc/terms/"), XName.Get("dateSubmitted", "http://purl.org/dc/terms/"), XName.Get("educationLevel", "http://purl.org/dc/terms/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("issued", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("license", "http://purl.org/dc/terms/"), XName.Get("mediator", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"), XName.Get("modified", "http://purl.org/dc/terms/"), XName.Get("provenance", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"), XName.Get("rightsHolder", "http://purl.org/dc/terms/"), XName.Get("spatial", "http://purl.org/dc/terms/"), XName.Get("tableOfContents", "http://purl.org/dc/terms/"), XName.Get("temporal", "http://purl.org/dc/terms/"), XName.Get("valid", "http://purl.org/dc/terms/"), XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("creator", "http://purl.org/dc/elements/1.1/"), XName.Get("subject", "http://purl.org/dc/elements/1.1/"), XName.Get("description", "http://purl.org/dc/elements/1.1/"), XName.Get("publisher", "http://purl.org/dc/elements/1.1/"), XName.Get("contributor", "http://purl.org/dc/elements/1.1/"), XName.Get("date", "http://purl.org/dc/elements/1.1/"), XName.Get("type", "http://purl.org/dc/elements/1.1/"), XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("source", "http://purl.org/dc/elements/1.1/"), XName.Get("language", "http://purl.org/dc/elements/1.1/"), XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("coverage", "http://purl.org/dc/elements/1.1/"), XName.Get("rights", "http://purl.org/dc/elements/1.1/"));
                    } else
                    {
                        XTypedServices.SetList<DCelement>(this.DCelementField, value);
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
                return XName.Get("elementContainer", "http://purl.org/dc/elements/1.1/");
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
            return XTypedServices.CloneXTypedElement<elementContainer>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), typeof(DCelement));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName elementContainerSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("elementContainer", "http://purl.org/dc/elements/1.1/");
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DCelementSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class DCelement: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator DCelement(XElement xe) { return (DCelement)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected DCelement(bool setNull)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public DCelement()
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public DCelement(SimpleLiteral content)
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

        public SimpleLiteral Content
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
        public System.Uri scheme
        {
            get
            {
                return this.ContentField.scheme;
            }
            set
            {
                this.ContentField.scheme=value;
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
                return XName.Get("DC-element", "http://purl.org/dc/elements/1.1/");
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

        public static DCelement Load(string xmlFile)
        {
            return ((DCelement)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static DCelement Load(System.IO.TextReader xmlFile)
        {
            return ((DCelement)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static DCelement Parse(string xml)
        {
            return ((DCelement)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DCelementSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DC-element", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("titleSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class title: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator title(XElement xe) { return (title)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected title(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public title() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public title(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("title", "http://purl.org/dc/elements/1.1/");
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

        public new static title Load(string xmlFile)
        {
            return ((title)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static title Load(System.IO.TextReader xmlFile)
        {
            return ((title)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static title Parse(string xml)
        {
            return ((title)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new title(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType titleSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("title", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("creatorSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class creator: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator creator(XElement xe) { return XTypedServices.ToXTypedElement<creator, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public creator() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public creator(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("creator", "http://purl.org/dc/elements/1.1/");
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

        public new static creator Load(string xmlFile)
        {
            return XTypedServices.Load<creator, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static creator Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<creator, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static creator Parse(string xml)
        {
            return XTypedServices.Parse<creator, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new creator(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType creatorSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("creator", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("subjectSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class subject: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator subject(XElement xe) { return XTypedServices.ToXTypedElement<subject, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public subject() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public subject(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("subject", "http://purl.org/dc/elements/1.1/");
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

        public new static subject Load(string xmlFile)
        {
            return XTypedServices.Load<subject, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static subject Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<subject, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static subject Parse(string xml)
        {
            return XTypedServices.Parse<subject, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new subject(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType subjectSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("subject", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("descriptionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class description: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator description(XElement xe) { return (description)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected description(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public description() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public description(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("description", "http://purl.org/dc/elements/1.1/");
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

        public new static description Load(string xmlFile)
        {
            return ((description)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static description Load(System.IO.TextReader xmlFile)
        {
            return ((description)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static description Parse(string xml)
        {
            return ((description)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new description(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType descriptionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("description", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("publisherSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class publisher: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator publisher(XElement xe) { return XTypedServices.ToXTypedElement<publisher, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public publisher() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public publisher(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("publisher", "http://purl.org/dc/elements/1.1/");
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

        public new static publisher Load(string xmlFile)
        {
            return XTypedServices.Load<publisher, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static publisher Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<publisher, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static publisher Parse(string xml)
        {
            return XTypedServices.Parse<publisher, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new publisher(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType publisherSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("publisher", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("contributorSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class contributor: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator contributor(XElement xe) { return XTypedServices.ToXTypedElement<contributor, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public contributor() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public contributor(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("contributor", "http://purl.org/dc/elements/1.1/");
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

        public new static contributor Load(string xmlFile)
        {
            return XTypedServices.Load<contributor, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static contributor Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<contributor, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static contributor Parse(string xml)
        {
            return XTypedServices.Parse<contributor, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new contributor(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType contributorSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("contributor", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("dateSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class date: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator date(XElement xe) { return (date)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected date(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public date() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public date(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("date", "http://purl.org/dc/elements/1.1/");
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

        public new static date Load(string xmlFile)
        {
            return ((date)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static date Load(System.IO.TextReader xmlFile)
        {
            return ((date)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static date Parse(string xml)
        {
            return ((date)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new date(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType dateSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("date", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("typeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class type: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator type(XElement xe) { return XTypedServices.ToXTypedElement<type, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public type() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public type(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("type", "http://purl.org/dc/elements/1.1/");
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

        public new static type Load(string xmlFile)
        {
            return XTypedServices.Load<type, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static type Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<type, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static type Parse(string xml)
        {
            return XTypedServices.Parse<type, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new type(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType typeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("type", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("formatSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class format: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator format(XElement xe) { return (format)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected format(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public format() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public format(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("format", "http://purl.org/dc/elements/1.1/");
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

        public new static format Load(string xmlFile)
        {
            return ((format)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static format Load(System.IO.TextReader xmlFile)
        {
            return ((format)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static format Parse(string xml)
        {
            return ((format)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new format(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType formatSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("format", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("identifierSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class identifier: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator identifier(XElement xe) { return (identifier)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected identifier(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public identifier() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public identifier(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("identifier", "http://purl.org/dc/elements/1.1/");
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

        public new static identifier Load(string xmlFile)
        {
            return ((identifier)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static identifier Load(System.IO.TextReader xmlFile)
        {
            return ((identifier)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static identifier Parse(string xml)
        {
            return ((identifier)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new identifier(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType identifierSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("identifier", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("sourceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class source: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator source(XElement xe) { return XTypedServices.ToXTypedElement<source, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public source() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public source(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("source", "http://purl.org/dc/elements/1.1/");
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

        public new static source Load(string xmlFile)
        {
            return XTypedServices.Load<source, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static source Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<source, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static source Parse(string xml)
        {
            return XTypedServices.Parse<source, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new source(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType sourceSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("source", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("languageSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class language: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator language(XElement xe) { return XTypedServices.ToXTypedElement<language, SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public language() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public language(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("language", "http://purl.org/dc/elements/1.1/");
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

        public new static language Load(string xmlFile)
        {
            return XTypedServices.Load<language, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static language Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<language, SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static language Parse(string xml)
        {
            return XTypedServices.Parse<language, SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new language(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType languageSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("language", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("relationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class relation: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator relation(XElement xe) { return (relation)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected relation(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public relation() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public relation(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("relation", "http://purl.org/dc/elements/1.1/");
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

        public new static relation Load(string xmlFile)
        {
            return ((relation)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static relation Load(System.IO.TextReader xmlFile)
        {
            return ((relation)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static relation Parse(string xml)
        {
            return ((relation)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new relation(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType relationSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("relation", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("coverageSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class coverage: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator coverage(XElement xe) { return (coverage)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected coverage(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public coverage() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public coverage(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("coverage", "http://purl.org/dc/elements/1.1/");
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

        public new static coverage Load(string xmlFile)
        {
            return ((coverage)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static coverage Load(System.IO.TextReader xmlFile)
        {
            return ((coverage)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static coverage Parse(string xml)
        {
            return ((coverage)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new coverage(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType coverageSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("coverage", "http://purl.org/dc/elements/1.1/")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is the default type for all of the DC elements. It defines a 
    ///      complexType SimpleLiteral which permits mixed content but disallows 
    ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
    ///      does permit the derivation of other types which would permit child 
    ///      elements. The scheme attribute may be used as a qualifier to reference 
    ///      an encoding scheme that describes the value domain for a given property.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("rightsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class rights: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleLiteral ContentField;

        public static explicit operator rights(XElement xe) { return (rights)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected rights(bool setNull) :
            base(true)
        {
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public rights() :
            base(true)
        {
            SetInnerType(new SimpleLiteral());
        }

        /// <summary>
        /// <para>
        /// This is the default type for all of the DC elements. It defines a 
        ///      complexType SimpleLiteral which permits mixed content but disallows 
        ///      child elements by use of minOcccurs/maxOccurs. However, this complexType 
        ///      does permit the derivation of other types which would permit child 
        ///      elements. The scheme attribute may be used as a qualifier to reference 
        ///      an encoding scheme that describes the value domain for a given property.
        /// </para>
        /// </summary>
        public rights(SimpleLiteral content) :
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

        public new SimpleLiteral Content
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
                return XName.Get("rights", "http://purl.org/dc/elements/1.1/");
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

        public new static rights Load(string xmlFile)
        {
            return ((rights)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static rights Load(System.IO.TextReader xmlFile)
        {
            return ((rights)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static rights Parse(string xml)
        {
            return ((rights)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new rights(((SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(SimpleLiteral ContentField)
        {
            this.ContentField=((SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType rightsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("rights", "http://purl.org/dc/elements/1.1/")]));
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


        public DCelement DCelement { get { return rootObject as DCelement; } }

        public title title { get { return rootObject as title; } }

        public creator creator { get { return rootObject as creator; } }

        public subject subject { get { return rootObject as subject; } }

        public description description { get { return rootObject as description; } }

        public publisher publisher { get { return rootObject as publisher; } }

        public contributor contributor { get { return rootObject as contributor; } }

        public date date { get { return rootObject as date; } }

        public type type { get { return rootObject as type; } }

        public format format { get { return rootObject as format; } }

        public identifier identifier { get { return rootObject as identifier; } }

        public source source { get { return rootObject as source; } }

        public language language { get { return rootObject as language; } }

        public relation relation { get { return rootObject as relation; } }

        public coverage coverage { get { return rootObject as coverage; } }

        public rights rights { get { return rootObject as rights; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(DCelement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(title root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(creator root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(subject root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(description root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(publisher root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(contributor root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(date root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(type root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(format root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(identifier root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(source root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(language root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(relation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(coverage root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(rights root)
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
#pragma warning restore 108, 114, 3002, 3009
