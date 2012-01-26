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

#pragma warning disable 108, 114, 3002, 3009
namespace OgcToolkit.DublinCore.Terms
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
    [XmlSchemaProviderAttribute("@abstractSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class @abstract: global::OgcToolkit.DublinCore.Elements.V11.description, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator @abstract(XElement xe) { return XTypedServices.ToXTypedElement<@abstract, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public @abstract() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public @abstract(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("abstract", "http://purl.org/dc/terms/");
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

        public new static @abstract Load(string xmlFile)
        {
            return XTypedServices.Load<@abstract, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static @abstract Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<@abstract, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static @abstract Parse(string xml)
        {
            return XTypedServices.Parse<@abstract, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new @abstract(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType @abstractSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("abstract", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("accessRightsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class accessRights: global::OgcToolkit.DublinCore.Elements.V11.rights, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator accessRights(XElement xe) { return XTypedServices.ToXTypedElement<accessRights, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public accessRights() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public accessRights(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("accessRights", "http://purl.org/dc/terms/");
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

        public new static accessRights Load(string xmlFile)
        {
            return XTypedServices.Load<accessRights, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static accessRights Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<accessRights, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static accessRights Parse(string xml)
        {
            return XTypedServices.Parse<accessRights, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new accessRights(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType accessRightsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("accessRights", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("alternativeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class alternative: global::OgcToolkit.DublinCore.Elements.V11.title, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator alternative(XElement xe) { return XTypedServices.ToXTypedElement<alternative, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public alternative() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public alternative(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("alternative", "http://purl.org/dc/terms/");
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

        public new static alternative Load(string xmlFile)
        {
            return XTypedServices.Load<alternative, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static alternative Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<alternative, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static alternative Parse(string xml)
        {
            return XTypedServices.Parse<alternative, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new alternative(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType alternativeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("alternative", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("audienceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class audience: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator audience(XElement xe) { return (audience)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected audience(bool setNull) :
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
        public audience() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public audience(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("audience", "http://purl.org/dc/terms/");
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

        public new static audience Load(string xmlFile)
        {
            return ((audience)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static audience Load(System.IO.TextReader xmlFile)
        {
            return ((audience)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public new static audience Parse(string xml)
        {
            return ((audience)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new audience(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=ContentField;
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType audienceSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("audience", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("availableSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class available: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator available(XElement xe) { return XTypedServices.ToXTypedElement<available, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public available() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public available(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("available", "http://purl.org/dc/terms/");
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

        public new static available Load(string xmlFile)
        {
            return XTypedServices.Load<available, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static available Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<available, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static available Parse(string xml)
        {
            return XTypedServices.Parse<available, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new available(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType availableSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("available", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("bibliographicCitationSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class bibliographicCitation: global::OgcToolkit.DublinCore.Elements.V11.identifier, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator bibliographicCitation(XElement xe) { return XTypedServices.ToXTypedElement<bibliographicCitation, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public bibliographicCitation() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public bibliographicCitation(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("bibliographicCitation", "http://purl.org/dc/terms/");
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

        public new static bibliographicCitation Load(string xmlFile)
        {
            return XTypedServices.Load<bibliographicCitation, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static bibliographicCitation Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<bibliographicCitation, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static bibliographicCitation Parse(string xml)
        {
            return XTypedServices.Parse<bibliographicCitation, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new bibliographicCitation(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType bibliographicCitationSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("bibliographicCitation", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("conformsToSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class conformsTo: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator conformsTo(XElement xe) { return XTypedServices.ToXTypedElement<conformsTo, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public conformsTo() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public conformsTo(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("conformsTo", "http://purl.org/dc/terms/");
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

        public new static conformsTo Load(string xmlFile)
        {
            return XTypedServices.Load<conformsTo, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static conformsTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<conformsTo, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static conformsTo Parse(string xml)
        {
            return XTypedServices.Parse<conformsTo, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new conformsTo(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType conformsToSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("conformsTo", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("createdSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class created: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator created(XElement xe) { return XTypedServices.ToXTypedElement<created, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public created() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public created(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("created", "http://purl.org/dc/terms/");
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

        public new static created Load(string xmlFile)
        {
            return XTypedServices.Load<created, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static created Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<created, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static created Parse(string xml)
        {
            return XTypedServices.Parse<created, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new created(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType createdSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("created", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("dateAcceptedSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class dateAccepted: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateAccepted(XElement xe) { return XTypedServices.ToXTypedElement<dateAccepted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public dateAccepted() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateAccepted(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("dateAccepted", "http://purl.org/dc/terms/");
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

        public new static dateAccepted Load(string xmlFile)
        {
            return XTypedServices.Load<dateAccepted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateAccepted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateAccepted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateAccepted Parse(string xml)
        {
            return XTypedServices.Parse<dateAccepted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateAccepted(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType dateAcceptedSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("dateAccepted", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("dateCopyrightedSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class dateCopyrighted: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateCopyrighted(XElement xe) { return XTypedServices.ToXTypedElement<dateCopyrighted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public dateCopyrighted() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateCopyrighted(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("dateCopyrighted", "http://purl.org/dc/terms/");
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

        public new static dateCopyrighted Load(string xmlFile)
        {
            return XTypedServices.Load<dateCopyrighted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateCopyrighted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateCopyrighted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateCopyrighted Parse(string xml)
        {
            return XTypedServices.Parse<dateCopyrighted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateCopyrighted(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType dateCopyrightedSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("dateCopyrighted", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("dateSubmittedSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class dateSubmitted: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateSubmitted(XElement xe) { return XTypedServices.ToXTypedElement<dateSubmitted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public dateSubmitted() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateSubmitted(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("dateSubmitted", "http://purl.org/dc/terms/");
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

        public new static dateSubmitted Load(string xmlFile)
        {
            return XTypedServices.Load<dateSubmitted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateSubmitted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateSubmitted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateSubmitted Parse(string xml)
        {
            return XTypedServices.Parse<dateSubmitted, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateSubmitted(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType dateSubmittedSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("dateSubmitted", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("educationLevelSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class educationLevel: global::OgcToolkit.DublinCore.Terms.audience, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator educationLevel(XElement xe) { return XTypedServices.ToXTypedElement<educationLevel, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public educationLevel() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public educationLevel(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("educationLevel", "http://purl.org/dc/terms/");
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

        public new static educationLevel Load(string xmlFile)
        {
            return XTypedServices.Load<educationLevel, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static educationLevel Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<educationLevel, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static educationLevel Parse(string xml)
        {
            return XTypedServices.Parse<educationLevel, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new educationLevel(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType educationLevelSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("educationLevel", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("extentSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class extent: global::OgcToolkit.DublinCore.Elements.V11.format, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator extent(XElement xe) { return XTypedServices.ToXTypedElement<extent, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public extent() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public extent(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("extent", "http://purl.org/dc/terms/");
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

        public new static extent Load(string xmlFile)
        {
            return XTypedServices.Load<extent, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static extent Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<extent, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static extent Parse(string xml)
        {
            return XTypedServices.Parse<extent, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new extent(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType extentSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("extent", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("hasFormatSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class hasFormat: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasFormat(XElement xe) { return XTypedServices.ToXTypedElement<hasFormat, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public hasFormat() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasFormat(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("hasFormat", "http://purl.org/dc/terms/");
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

        public new static hasFormat Load(string xmlFile)
        {
            return XTypedServices.Load<hasFormat, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasFormat Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasFormat, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasFormat Parse(string xml)
        {
            return XTypedServices.Parse<hasFormat, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasFormat(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType hasFormatSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("hasFormat", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("hasPartSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class hasPart: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasPart(XElement xe) { return XTypedServices.ToXTypedElement<hasPart, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public hasPart() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasPart(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("hasPart", "http://purl.org/dc/terms/");
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

        public new static hasPart Load(string xmlFile)
        {
            return XTypedServices.Load<hasPart, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasPart Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasPart, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasPart Parse(string xml)
        {
            return XTypedServices.Parse<hasPart, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasPart(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType hasPartSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("hasPart", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("hasVersionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class hasVersion: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasVersion(XElement xe) { return XTypedServices.ToXTypedElement<hasVersion, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public hasVersion() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasVersion(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("hasVersion", "http://purl.org/dc/terms/");
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

        public new static hasVersion Load(string xmlFile)
        {
            return XTypedServices.Load<hasVersion, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasVersion Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasVersion, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasVersion Parse(string xml)
        {
            return XTypedServices.Parse<hasVersion, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasVersion(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType hasVersionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("hasVersion", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isFormatOfSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isFormatOf: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isFormatOf(XElement xe) { return XTypedServices.ToXTypedElement<isFormatOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isFormatOf() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isFormatOf(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isFormatOf", "http://purl.org/dc/terms/");
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

        public new static isFormatOf Load(string xmlFile)
        {
            return XTypedServices.Load<isFormatOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isFormatOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isFormatOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isFormatOf Parse(string xml)
        {
            return XTypedServices.Parse<isFormatOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isFormatOf(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isFormatOfSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isFormatOf", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isPartOfSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isPartOf: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isPartOf(XElement xe) { return XTypedServices.ToXTypedElement<isPartOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isPartOf() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isPartOf(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isPartOf", "http://purl.org/dc/terms/");
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

        public new static isPartOf Load(string xmlFile)
        {
            return XTypedServices.Load<isPartOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isPartOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isPartOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isPartOf Parse(string xml)
        {
            return XTypedServices.Parse<isPartOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isPartOf(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isPartOfSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isPartOf", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isReferencedBySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isReferencedBy: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isReferencedBy(XElement xe) { return XTypedServices.ToXTypedElement<isReferencedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isReferencedBy() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isReferencedBy(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isReferencedBy", "http://purl.org/dc/terms/");
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

        public new static isReferencedBy Load(string xmlFile)
        {
            return XTypedServices.Load<isReferencedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isReferencedBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isReferencedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isReferencedBy Parse(string xml)
        {
            return XTypedServices.Parse<isReferencedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isReferencedBy(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isReferencedBySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isReferencedBy", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isReplacedBySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isReplacedBy: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isReplacedBy(XElement xe) { return XTypedServices.ToXTypedElement<isReplacedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isReplacedBy() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isReplacedBy(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isReplacedBy", "http://purl.org/dc/terms/");
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

        public new static isReplacedBy Load(string xmlFile)
        {
            return XTypedServices.Load<isReplacedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isReplacedBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isReplacedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isReplacedBy Parse(string xml)
        {
            return XTypedServices.Parse<isReplacedBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isReplacedBy(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isReplacedBySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isReplacedBy", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isRequiredBySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isRequiredBy: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isRequiredBy(XElement xe) { return XTypedServices.ToXTypedElement<isRequiredBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isRequiredBy() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isRequiredBy(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isRequiredBy", "http://purl.org/dc/terms/");
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

        public new static isRequiredBy Load(string xmlFile)
        {
            return XTypedServices.Load<isRequiredBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isRequiredBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isRequiredBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isRequiredBy Parse(string xml)
        {
            return XTypedServices.Parse<isRequiredBy, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isRequiredBy(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isRequiredBySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isRequiredBy", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("issuedSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class issued: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator issued(XElement xe) { return XTypedServices.ToXTypedElement<issued, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public issued() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public issued(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("issued", "http://purl.org/dc/terms/");
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

        public new static issued Load(string xmlFile)
        {
            return XTypedServices.Load<issued, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static issued Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<issued, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static issued Parse(string xml)
        {
            return XTypedServices.Parse<issued, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new issued(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType issuedSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("issued", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("isVersionOfSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class isVersionOf: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isVersionOf(XElement xe) { return XTypedServices.ToXTypedElement<isVersionOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public isVersionOf() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public isVersionOf(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("isVersionOf", "http://purl.org/dc/terms/");
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

        public new static isVersionOf Load(string xmlFile)
        {
            return XTypedServices.Load<isVersionOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isVersionOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isVersionOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isVersionOf Parse(string xml)
        {
            return XTypedServices.Parse<isVersionOf, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isVersionOf(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType isVersionOfSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("isVersionOf", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("licenseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class license: global::OgcToolkit.DublinCore.Elements.V11.rights, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator license(XElement xe) { return XTypedServices.ToXTypedElement<license, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public license() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public license(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("license", "http://purl.org/dc/terms/");
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

        public new static license Load(string xmlFile)
        {
            return XTypedServices.Load<license, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static license Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<license, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static license Parse(string xml)
        {
            return XTypedServices.Parse<license, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new license(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType licenseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("license", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("mediatorSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class mediator: global::OgcToolkit.DublinCore.Terms.audience, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator mediator(XElement xe) { return XTypedServices.ToXTypedElement<mediator, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public mediator() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public mediator(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("mediator", "http://purl.org/dc/terms/");
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

        public new static mediator Load(string xmlFile)
        {
            return XTypedServices.Load<mediator, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static mediator Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<mediator, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static mediator Parse(string xml)
        {
            return XTypedServices.Parse<mediator, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new mediator(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType mediatorSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("mediator", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("mediumSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class medium: global::OgcToolkit.DublinCore.Elements.V11.format, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator medium(XElement xe) { return XTypedServices.ToXTypedElement<medium, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public medium() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public medium(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("medium", "http://purl.org/dc/terms/");
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

        public new static medium Load(string xmlFile)
        {
            return XTypedServices.Load<medium, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static medium Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<medium, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static medium Parse(string xml)
        {
            return XTypedServices.Parse<medium, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new medium(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType mediumSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("medium", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("modifiedSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class modified: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator modified(XElement xe) { return XTypedServices.ToXTypedElement<modified, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public modified() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public modified(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("modified", "http://purl.org/dc/terms/");
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

        public new static modified Load(string xmlFile)
        {
            return XTypedServices.Load<modified, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static modified Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<modified, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static modified Parse(string xml)
        {
            return XTypedServices.Parse<modified, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new modified(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType modifiedSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("modified", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("provenanceSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class provenance: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator provenance(XElement xe) { return XTypedServices.ToXTypedElement<provenance, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public provenance() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public provenance(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("provenance", "http://purl.org/dc/terms/");
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

        public new static provenance Load(string xmlFile)
        {
            return XTypedServices.Load<provenance, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static provenance Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<provenance, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static provenance Parse(string xml)
        {
            return XTypedServices.Parse<provenance, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new provenance(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType provenanceSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("provenance", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("referencesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class references: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator references(XElement xe) { return XTypedServices.ToXTypedElement<references, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public references() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public references(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("references", "http://purl.org/dc/terms/");
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

        public new static references Load(string xmlFile)
        {
            return XTypedServices.Load<references, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static references Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<references, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static references Parse(string xml)
        {
            return XTypedServices.Parse<references, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new references(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType referencesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("references", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("replacesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class replaces: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator replaces(XElement xe) { return XTypedServices.ToXTypedElement<replaces, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public replaces() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public replaces(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("replaces", "http://purl.org/dc/terms/");
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

        public new static replaces Load(string xmlFile)
        {
            return XTypedServices.Load<replaces, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static replaces Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<replaces, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static replaces Parse(string xml)
        {
            return XTypedServices.Parse<replaces, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new replaces(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType replacesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("replaces", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("requiresSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class requires: global::OgcToolkit.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator requires(XElement xe) { return XTypedServices.ToXTypedElement<requires, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public requires() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public requires(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("requires", "http://purl.org/dc/terms/");
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

        public new static requires Load(string xmlFile)
        {
            return XTypedServices.Load<requires, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static requires Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<requires, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static requires Parse(string xml)
        {
            return XTypedServices.Parse<requires, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new requires(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType requiresSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("requires", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("rightsHolderSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class rightsHolder: global::OgcToolkit.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator rightsHolder(XElement xe) { return XTypedServices.ToXTypedElement<rightsHolder, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public rightsHolder() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public rightsHolder(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("rightsHolder", "http://purl.org/dc/terms/");
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

        public new static rightsHolder Load(string xmlFile)
        {
            return XTypedServices.Load<rightsHolder, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static rightsHolder Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<rightsHolder, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static rightsHolder Parse(string xml)
        {
            return XTypedServices.Parse<rightsHolder, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new rightsHolder(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType rightsHolderSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("rightsHolder", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("spatialSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class spatial: global::OgcToolkit.DublinCore.Elements.V11.coverage, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator spatial(XElement xe) { return XTypedServices.ToXTypedElement<spatial, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public spatial() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public spatial(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("spatial", "http://purl.org/dc/terms/");
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

        public new static spatial Load(string xmlFile)
        {
            return XTypedServices.Load<spatial, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static spatial Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<spatial, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static spatial Parse(string xml)
        {
            return XTypedServices.Parse<spatial, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new spatial(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType spatialSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("spatial", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("tableOfContentsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class tableOfContents: global::OgcToolkit.DublinCore.Elements.V11.description, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator tableOfContents(XElement xe) { return XTypedServices.ToXTypedElement<tableOfContents, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public tableOfContents() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public tableOfContents(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("tableOfContents", "http://purl.org/dc/terms/");
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

        public new static tableOfContents Load(string xmlFile)
        {
            return XTypedServices.Load<tableOfContents, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static tableOfContents Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<tableOfContents, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static tableOfContents Parse(string xml)
        {
            return XTypedServices.Parse<tableOfContents, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new tableOfContents(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType tableOfContentsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("tableOfContents", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("temporalSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class temporal: global::OgcToolkit.DublinCore.Elements.V11.coverage, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator temporal(XElement xe) { return XTypedServices.ToXTypedElement<temporal, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public temporal() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public temporal(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("temporal", "http://purl.org/dc/terms/");
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

        public new static temporal Load(string xmlFile)
        {
            return XTypedServices.Load<temporal, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static temporal Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<temporal, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static temporal Parse(string xml)
        {
            return XTypedServices.Parse<temporal, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new temporal(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType temporalSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("temporal", "http://purl.org/dc/terms/")]));
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
    [XmlSchemaProviderAttribute("validSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class valid: global::OgcToolkit.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator valid(XElement xe) { return XTypedServices.ToXTypedElement<valid, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
        public valid() :
            base(true)
        {
            SetInnerType(new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral());
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
        public valid(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new OgcToolkit.DublinCore.Elements.V11.SimpleLiteral Content
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
                return XName.Get("valid", "http://purl.org/dc/terms/");
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

        public new static valid Load(string xmlFile)
        {
            return XTypedServices.Load<valid, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static valid Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<valid, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static valid Parse(string xml)
        {
            return XTypedServices.Parse<valid, OgcToolkit.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new valid(((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(OgcToolkit.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((OgcToolkit.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType validSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("valid", "http://purl.org/dc/terms/")]));
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


        public @abstract @abstract { get { return rootObject as @abstract; } }

        public accessRights accessRights { get { return rootObject as accessRights; } }

        public alternative alternative { get { return rootObject as alternative; } }

        public audience audience { get { return rootObject as audience; } }

        public available available { get { return rootObject as available; } }

        public bibliographicCitation bibliographicCitation { get { return rootObject as bibliographicCitation; } }

        public conformsTo conformsTo { get { return rootObject as conformsTo; } }

        public created created { get { return rootObject as created; } }

        public dateAccepted dateAccepted { get { return rootObject as dateAccepted; } }

        public dateCopyrighted dateCopyrighted { get { return rootObject as dateCopyrighted; } }

        public dateSubmitted dateSubmitted { get { return rootObject as dateSubmitted; } }

        public educationLevel educationLevel { get { return rootObject as educationLevel; } }

        public extent extent { get { return rootObject as extent; } }

        public hasFormat hasFormat { get { return rootObject as hasFormat; } }

        public hasPart hasPart { get { return rootObject as hasPart; } }

        public hasVersion hasVersion { get { return rootObject as hasVersion; } }

        public isFormatOf isFormatOf { get { return rootObject as isFormatOf; } }

        public isPartOf isPartOf { get { return rootObject as isPartOf; } }

        public isReferencedBy isReferencedBy { get { return rootObject as isReferencedBy; } }

        public isReplacedBy isReplacedBy { get { return rootObject as isReplacedBy; } }

        public isRequiredBy isRequiredBy { get { return rootObject as isRequiredBy; } }

        public issued issued { get { return rootObject as issued; } }

        public isVersionOf isVersionOf { get { return rootObject as isVersionOf; } }

        public license license { get { return rootObject as license; } }

        public mediator mediator { get { return rootObject as mediator; } }

        public medium medium { get { return rootObject as medium; } }

        public modified modified { get { return rootObject as modified; } }

        public provenance provenance { get { return rootObject as provenance; } }

        public references references { get { return rootObject as references; } }

        public replaces replaces { get { return rootObject as replaces; } }

        public requires requires { get { return rootObject as requires; } }

        public rightsHolder rightsHolder { get { return rootObject as rightsHolder; } }

        public spatial spatial { get { return rootObject as spatial; } }

        public tableOfContents tableOfContents { get { return rootObject as tableOfContents; } }

        public temporal temporal { get { return rootObject as temporal; } }

        public valid valid { get { return rootObject as valid; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(@abstract root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(accessRights root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(alternative root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(audience root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(available root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(bibliographicCitation root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(conformsTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(created root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(dateAccepted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(dateCopyrighted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(dateSubmitted root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(educationLevel root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(extent root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(hasFormat root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(hasPart root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(hasVersion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isFormatOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isPartOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isReferencedBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isReplacedBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isRequiredBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(issued root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(isVersionOf root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(license root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(mediator root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(medium root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(modified root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(provenance root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(references root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(replaces root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(requires root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(rightsHolder root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(spatial root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(tableOfContents root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(temporal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(valid root)
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
