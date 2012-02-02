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

#pragma warning disable 108, 114, 3002, 3009
namespace GeoSik.DublinCore.Terms
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
    using GeoSik.Ogc.Ows.V100;


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
    public partial class @abstract: global::GeoSik.DublinCore.Elements.V11.description, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator @abstract(XElement xe) { return XTypedServices.ToXTypedElement<@abstract, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public @abstract(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<@abstract, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static @abstract Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<@abstract, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static @abstract Parse(string xml)
        {
            return XTypedServices.Parse<@abstract, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new @abstract(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class accessRights: global::GeoSik.DublinCore.Elements.V11.rights, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator accessRights(XElement xe) { return XTypedServices.ToXTypedElement<accessRights, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public accessRights(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<accessRights, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static accessRights Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<accessRights, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static accessRights Parse(string xml)
        {
            return XTypedServices.Parse<accessRights, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new accessRights(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class alternative: global::GeoSik.DublinCore.Elements.V11.title, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator alternative(XElement xe) { return XTypedServices.ToXTypedElement<alternative, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public alternative(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<alternative, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static alternative Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<alternative, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static alternative Parse(string xml)
        {
            return XTypedServices.Parse<alternative, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new alternative(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class audience: global::GeoSik.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public audience(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return new audience(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        protected virtual void SetSubstitutionMember(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
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
    public partial class available: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator available(XElement xe) { return XTypedServices.ToXTypedElement<available, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public available(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<available, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static available Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<available, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static available Parse(string xml)
        {
            return XTypedServices.Parse<available, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new available(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class bibliographicCitation: global::GeoSik.DublinCore.Elements.V11.identifier, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator bibliographicCitation(XElement xe) { return XTypedServices.ToXTypedElement<bibliographicCitation, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public bibliographicCitation(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<bibliographicCitation, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static bibliographicCitation Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<bibliographicCitation, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static bibliographicCitation Parse(string xml)
        {
            return XTypedServices.Parse<bibliographicCitation, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new bibliographicCitation(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class conformsTo: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator conformsTo(XElement xe) { return XTypedServices.ToXTypedElement<conformsTo, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public conformsTo(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<conformsTo, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static conformsTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<conformsTo, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static conformsTo Parse(string xml)
        {
            return XTypedServices.Parse<conformsTo, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new conformsTo(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class created: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator created(XElement xe) { return XTypedServices.ToXTypedElement<created, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public created(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<created, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static created Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<created, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static created Parse(string xml)
        {
            return XTypedServices.Parse<created, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new created(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class dateAccepted: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateAccepted(XElement xe) { return XTypedServices.ToXTypedElement<dateAccepted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateAccepted(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<dateAccepted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateAccepted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateAccepted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateAccepted Parse(string xml)
        {
            return XTypedServices.Parse<dateAccepted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateAccepted(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class dateCopyrighted: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateCopyrighted(XElement xe) { return XTypedServices.ToXTypedElement<dateCopyrighted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateCopyrighted(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<dateCopyrighted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateCopyrighted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateCopyrighted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateCopyrighted Parse(string xml)
        {
            return XTypedServices.Parse<dateCopyrighted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateCopyrighted(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class dateSubmitted: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator dateSubmitted(XElement xe) { return XTypedServices.ToXTypedElement<dateSubmitted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public dateSubmitted(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<dateSubmitted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static dateSubmitted Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<dateSubmitted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static dateSubmitted Parse(string xml)
        {
            return XTypedServices.Parse<dateSubmitted, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new dateSubmitted(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class educationLevel: global::GeoSik.DublinCore.Terms.audience, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator educationLevel(XElement xe) { return XTypedServices.ToXTypedElement<educationLevel, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public educationLevel(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<educationLevel, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static educationLevel Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<educationLevel, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static educationLevel Parse(string xml)
        {
            return XTypedServices.Parse<educationLevel, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new educationLevel(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class extent: global::GeoSik.DublinCore.Elements.V11.format, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator extent(XElement xe) { return XTypedServices.ToXTypedElement<extent, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public extent(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<extent, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static extent Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<extent, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static extent Parse(string xml)
        {
            return XTypedServices.Parse<extent, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new extent(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class hasFormat: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasFormat(XElement xe) { return XTypedServices.ToXTypedElement<hasFormat, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasFormat(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<hasFormat, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasFormat Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasFormat, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasFormat Parse(string xml)
        {
            return XTypedServices.Parse<hasFormat, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasFormat(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class hasPart: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasPart(XElement xe) { return XTypedServices.ToXTypedElement<hasPart, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasPart(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<hasPart, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasPart Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasPart, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasPart Parse(string xml)
        {
            return XTypedServices.Parse<hasPart, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasPart(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class hasVersion: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator hasVersion(XElement xe) { return XTypedServices.ToXTypedElement<hasVersion, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public hasVersion(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<hasVersion, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static hasVersion Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<hasVersion, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static hasVersion Parse(string xml)
        {
            return XTypedServices.Parse<hasVersion, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new hasVersion(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isFormatOf: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isFormatOf(XElement xe) { return XTypedServices.ToXTypedElement<isFormatOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isFormatOf(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isFormatOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isFormatOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isFormatOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isFormatOf Parse(string xml)
        {
            return XTypedServices.Parse<isFormatOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isFormatOf(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isPartOf: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isPartOf(XElement xe) { return XTypedServices.ToXTypedElement<isPartOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isPartOf(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isPartOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isPartOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isPartOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isPartOf Parse(string xml)
        {
            return XTypedServices.Parse<isPartOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isPartOf(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isReferencedBy: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isReferencedBy(XElement xe) { return XTypedServices.ToXTypedElement<isReferencedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isReferencedBy(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isReferencedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isReferencedBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isReferencedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isReferencedBy Parse(string xml)
        {
            return XTypedServices.Parse<isReferencedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isReferencedBy(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isReplacedBy: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isReplacedBy(XElement xe) { return XTypedServices.ToXTypedElement<isReplacedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isReplacedBy(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isReplacedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isReplacedBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isReplacedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isReplacedBy Parse(string xml)
        {
            return XTypedServices.Parse<isReplacedBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isReplacedBy(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isRequiredBy: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isRequiredBy(XElement xe) { return XTypedServices.ToXTypedElement<isRequiredBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isRequiredBy(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isRequiredBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isRequiredBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isRequiredBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isRequiredBy Parse(string xml)
        {
            return XTypedServices.Parse<isRequiredBy, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isRequiredBy(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class issued: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator issued(XElement xe) { return XTypedServices.ToXTypedElement<issued, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public issued(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<issued, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static issued Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<issued, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static issued Parse(string xml)
        {
            return XTypedServices.Parse<issued, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new issued(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class isVersionOf: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator isVersionOf(XElement xe) { return XTypedServices.ToXTypedElement<isVersionOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public isVersionOf(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<isVersionOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static isVersionOf Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<isVersionOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static isVersionOf Parse(string xml)
        {
            return XTypedServices.Parse<isVersionOf, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new isVersionOf(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class license: global::GeoSik.DublinCore.Elements.V11.rights, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator license(XElement xe) { return XTypedServices.ToXTypedElement<license, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public license(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<license, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static license Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<license, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static license Parse(string xml)
        {
            return XTypedServices.Parse<license, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new license(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class mediator: global::GeoSik.DublinCore.Terms.audience, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator mediator(XElement xe) { return XTypedServices.ToXTypedElement<mediator, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public mediator(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<mediator, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static mediator Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<mediator, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static mediator Parse(string xml)
        {
            return XTypedServices.Parse<mediator, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new mediator(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class medium: global::GeoSik.DublinCore.Elements.V11.format, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator medium(XElement xe) { return XTypedServices.ToXTypedElement<medium, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public medium(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<medium, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static medium Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<medium, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static medium Parse(string xml)
        {
            return XTypedServices.Parse<medium, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new medium(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class modified: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator modified(XElement xe) { return XTypedServices.ToXTypedElement<modified, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public modified(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<modified, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static modified Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<modified, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static modified Parse(string xml)
        {
            return XTypedServices.Parse<modified, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new modified(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class provenance: global::GeoSik.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator provenance(XElement xe) { return XTypedServices.ToXTypedElement<provenance, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public provenance(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<provenance, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static provenance Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<provenance, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static provenance Parse(string xml)
        {
            return XTypedServices.Parse<provenance, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new provenance(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class references: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator references(XElement xe) { return XTypedServices.ToXTypedElement<references, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public references(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<references, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static references Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<references, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static references Parse(string xml)
        {
            return XTypedServices.Parse<references, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new references(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class replaces: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator replaces(XElement xe) { return XTypedServices.ToXTypedElement<replaces, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public replaces(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<replaces, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static replaces Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<replaces, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static replaces Parse(string xml)
        {
            return XTypedServices.Parse<replaces, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new replaces(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class requires: global::GeoSik.DublinCore.Elements.V11.relation, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator requires(XElement xe) { return XTypedServices.ToXTypedElement<requires, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public requires(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<requires, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static requires Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<requires, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static requires Parse(string xml)
        {
            return XTypedServices.Parse<requires, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new requires(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class rightsHolder: global::GeoSik.DublinCore.Elements.V11.DCelement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator rightsHolder(XElement xe) { return XTypedServices.ToXTypedElement<rightsHolder, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public rightsHolder(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<rightsHolder, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static rightsHolder Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<rightsHolder, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static rightsHolder Parse(string xml)
        {
            return XTypedServices.Parse<rightsHolder, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new rightsHolder(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class spatial: global::GeoSik.DublinCore.Elements.V11.coverage, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator spatial(XElement xe) { return XTypedServices.ToXTypedElement<spatial, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public spatial(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<spatial, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static spatial Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<spatial, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static spatial Parse(string xml)
        {
            return XTypedServices.Parse<spatial, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new spatial(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class tableOfContents: global::GeoSik.DublinCore.Elements.V11.description, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator tableOfContents(XElement xe) { return XTypedServices.ToXTypedElement<tableOfContents, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public tableOfContents(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<tableOfContents, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static tableOfContents Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<tableOfContents, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static tableOfContents Parse(string xml)
        {
            return XTypedServices.Parse<tableOfContents, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new tableOfContents(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class temporal: global::GeoSik.DublinCore.Elements.V11.coverage, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator temporal(XElement xe) { return XTypedServices.ToXTypedElement<temporal, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public temporal(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<temporal, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static temporal Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<temporal, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static temporal Parse(string xml)
        {
            return XTypedServices.Parse<temporal, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new temporal(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
    public partial class valid: global::GeoSik.DublinCore.Elements.V11.date, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField;

        public static explicit operator valid(XElement xe) { return XTypedServices.ToXTypedElement<valid, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

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
            SetInnerType(new GeoSik.DublinCore.Elements.V11.SimpleLiteral());
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
        public valid(GeoSik.DublinCore.Elements.V11.SimpleLiteral content) :
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

        public new GeoSik.DublinCore.Elements.V11.SimpleLiteral Content
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
            return XTypedServices.Load<valid, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static valid Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<valid, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static valid Parse(string xml)
        {
            return XTypedServices.Parse<valid, GeoSik.DublinCore.Elements.V11.SimpleLiteral>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new valid(((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(this.Content.Clone())));
        }

        private void SetInnerType(GeoSik.DublinCore.Elements.V11.SimpleLiteral ContentField)
        {
            this.ContentField=((GeoSik.DublinCore.Elements.V11.SimpleLiteral)(XTypedServices.GetCloneIfRooted(ContentField)));
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
