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

#pragma warning disable 108, 114, 1591, 3002, 3003, 3005, 3009
namespace GeoSik.Ogc.WebCatalog.Csw.V202.Types
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
    using GeoSik.Ogc.Ows.V100.Types;


    [XmlSchemaProviderAttribute("AbstractRecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractRecordType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AbstractRecordType(XElement xe) { return (AbstractRecordType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractRecordType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AbstractRecordType", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static XmlQualifiedName AbstractRecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AbstractRecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type encapsulates all of the standard DCMI metadata terms,
    ///            including the Dublin Core refinements; these terms may be mapped
    ///            to the profile-specific information model.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: ((DCelement)*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DCMIRecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DCMIRecordType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecordType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.DCelement> DCelementField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator DCMIRecordType(XElement xe) { return XTypedServices.ToXTypedElement<DCMIRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DCMIRecordType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type encapsulates all of the standard DCMI metadata terms,
        ///            including the Dublin Core refinements; these terms may be mapped
        ///            to the profile-specific information model.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*)
        /// </para>
        /// </summary>
        public DCMIRecordType()
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
        /// Regular expression: ((DCelement)*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.DCelement> DCelement
        {
            get
            {
                if ((this.DCelementField==null))
                {
                    this.DCelementField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.DCelement>(this, LinqToXsdTypeManager.Instance, XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), XName.Get("abstract", "http://purl.org/dc/terms/"), XName.Get("accessRights", "http://purl.org/dc/terms/"), XName.Get("alternative", "http://purl.org/dc/terms/"), XName.Get("audience", "http://purl.org/dc/terms/"), XName.Get("available", "http://purl.org/dc/terms/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("created", "http://purl.org/dc/terms/"), XName.Get("dateAccepted", "http://purl.org/dc/terms/"), XName.Get("dateCopyrighted", "http://purl.org/dc/terms/"), XName.Get("dateSubmitted", "http://purl.org/dc/terms/"), XName.Get("educationLevel", "http://purl.org/dc/terms/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("issued", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("license", "http://purl.org/dc/terms/"), XName.Get("mediator", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"), XName.Get("modified", "http://purl.org/dc/terms/"), XName.Get("provenance", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"), XName.Get("rightsHolder", "http://purl.org/dc/terms/"), XName.Get("spatial", "http://purl.org/dc/terms/"), XName.Get("tableOfContents", "http://purl.org/dc/terms/"), XName.Get("temporal", "http://purl.org/dc/terms/"), XName.Get("valid", "http://purl.org/dc/terms/"), XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("creator", "http://purl.org/dc/elements/1.1/"), XName.Get("subject", "http://purl.org/dc/elements/1.1/"), XName.Get("description", "http://purl.org/dc/elements/1.1/"), XName.Get("publisher", "http://purl.org/dc/elements/1.1/"), XName.Get("contributor", "http://purl.org/dc/elements/1.1/"), XName.Get("date", "http://purl.org/dc/elements/1.1/"), XName.Get("type", "http://purl.org/dc/elements/1.1/"), XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("source", "http://purl.org/dc/elements/1.1/"), XName.Get("language", "http://purl.org/dc/elements/1.1/"), XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("coverage", "http://purl.org/dc/elements/1.1/"), XName.Get("rights", "http://purl.org/dc/elements/1.1/"));
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
                        this.DCelementField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.DCelement>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), XName.Get("abstract", "http://purl.org/dc/terms/"), XName.Get("accessRights", "http://purl.org/dc/terms/"), XName.Get("alternative", "http://purl.org/dc/terms/"), XName.Get("audience", "http://purl.org/dc/terms/"), XName.Get("available", "http://purl.org/dc/terms/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("created", "http://purl.org/dc/terms/"), XName.Get("dateAccepted", "http://purl.org/dc/terms/"), XName.Get("dateCopyrighted", "http://purl.org/dc/terms/"), XName.Get("dateSubmitted", "http://purl.org/dc/terms/"), XName.Get("educationLevel", "http://purl.org/dc/terms/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("issued", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("license", "http://purl.org/dc/terms/"), XName.Get("mediator", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"), XName.Get("modified", "http://purl.org/dc/terms/"), XName.Get("provenance", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"), XName.Get("rightsHolder", "http://purl.org/dc/terms/"), XName.Get("spatial", "http://purl.org/dc/terms/"), XName.Get("tableOfContents", "http://purl.org/dc/terms/"), XName.Get("temporal", "http://purl.org/dc/terms/"), XName.Get("valid", "http://purl.org/dc/terms/"), XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("creator", "http://purl.org/dc/elements/1.1/"), XName.Get("subject", "http://purl.org/dc/elements/1.1/"), XName.Get("description", "http://purl.org/dc/elements/1.1/"), XName.Get("publisher", "http://purl.org/dc/elements/1.1/"), XName.Get("contributor", "http://purl.org/dc/elements/1.1/"), XName.Get("date", "http://purl.org/dc/elements/1.1/"), XName.Get("type", "http://purl.org/dc/elements/1.1/"), XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("source", "http://purl.org/dc/elements/1.1/"), XName.Get("language", "http://purl.org/dc/elements/1.1/"), XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("coverage", "http://purl.org/dc/elements/1.1/"), XName.Get("rights", "http://purl.org/dc/elements/1.1/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.DCelement>(this.DCelementField, value);
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
                return XName.Get("DCMIRecordType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DCMIRecordType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.DCelement));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName DCMIRecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DCMIRecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type defines a brief representation of the common record
    ///            format.  It extends AbstractRecordType to include only the
    ///             dc:identifier and dc:type properties.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (identifier+, title+, type?, BoundingBox*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BriefRecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed partial class BriefRecordType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecordType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier> identifierField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title> titleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBoxField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator BriefRecordType(XElement xe) { return XTypedServices.ToXTypedElement<BriefRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BriefRecordType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/")), new SubstitutedContentModelEntity(XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/")), new NamedContentModelEntity(XName.Get("type", "http://purl.org/dc/elements/1.1/")), new SubstitutedContentModelEntity(XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a brief representation of the common record
        ///            format.  It extends AbstractRecordType to include only the
        ///             dc:identifier and dc:type properties.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public BriefRecordType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: identifier, bibliographicCitation
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.identifier> identifier
        {
            get
            {
                if ((this.identifierField==null))
                {
                    this.identifierField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier>(this, LinqToXsdTypeManager.Instance, XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"));
                }
                return this.identifierField;
            }
            set
            {
                if ((value==null))
                {
                    this.identifierField=null;
                } else
                {
                    if ((this.identifierField==null))
                    {
                        this.identifierField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.identifier>(this.identifierField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: title, alternative
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.title> title
        {
            get
            {
                if ((this.titleField==null))
                {
                    this.titleField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title>(this, LinqToXsdTypeManager.Instance, XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/"));
                }
                return this.titleField;
            }
            set
            {
                if ((value==null))
                {
                    this.titleField=null;
                } else
                {
                    if ((this.titleField==null))
                    {
                        this.titleField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.title>(this.titleField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public GeoSik.DublinCore.Elements.V11.type type
        {
            get
            {
                XElement x=this.GetElement(XName.Get("type", "http://purl.org/dc/elements/1.1/"));
                return ((GeoSik.DublinCore.Elements.V11.type)(x));
            }
            set
            {
                this.SetElement(XName.Get("type", "http://purl.org/dc/elements/1.1/"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                if ((this.BoundingBoxField==null))
                {
                    this.BoundingBoxField=new XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this, LinqToXsdTypeManager.Instance, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
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
                        this.BoundingBoxField=XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this.BoundingBoxField, value);
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
                return XName.Get("BriefRecordType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<BriefRecordType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.identifier));
            localElementDictionary.Add(XName.Get("title", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.title));
            localElementDictionary.Add(XName.Get("type", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.type));
            localElementDictionary.Add(XName.Get("BoundingBox", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.BoundingBox));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName BriefRecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BriefRecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type defines a summary representation of the common record
    ///            format.  It extends AbstractRecordType to include the core
    ///            properties.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SummaryRecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed partial class SummaryRecordType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecordType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier> identifierField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title> titleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.DublinCore.Elements.V11.subject> subjectField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.format> formatField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.relation> relationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.DublinCore.Terms.modified> modifiedField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.DublinCore.Terms.@abstract> @abstractField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<GeoSik.DublinCore.Terms.spatial> spatialField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBoxField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SummaryRecordType(XElement xe) { return XTypedServices.ToXTypedElement<SummaryRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SummaryRecordType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/")), new SubstitutedContentModelEntity(XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/")), new NamedContentModelEntity(XName.Get("type", "http://purl.org/dc/elements/1.1/")), new NamedContentModelEntity(XName.Get("subject", "http://purl.org/dc/elements/1.1/")), new SubstitutedContentModelEntity(XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/")), new SubstitutedContentModelEntity(XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/")), new NamedContentModelEntity(XName.Get("modified", "http://purl.org/dc/terms/")), new NamedContentModelEntity(XName.Get("abstract", "http://purl.org/dc/terms/")), new NamedContentModelEntity(XName.Get("spatial", "http://purl.org/dc/terms/")), new SubstitutedContentModelEntity(XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a summary representation of the common record
        ///            format.  It extends AbstractRecordType to include the core
        ///            properties.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public SummaryRecordType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: identifier, bibliographicCitation
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.identifier> identifier
        {
            get
            {
                if ((this.identifierField==null))
                {
                    this.identifierField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier>(this, LinqToXsdTypeManager.Instance, XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"));
                }
                return this.identifierField;
            }
            set
            {
                if ((value==null))
                {
                    this.identifierField=null;
                } else
                {
                    if ((this.identifierField==null))
                    {
                        this.identifierField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.identifier>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), XName.Get("bibliographicCitation", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.identifier>(this.identifierField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: title, alternative
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.title> title
        {
            get
            {
                if ((this.titleField==null))
                {
                    this.titleField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title>(this, LinqToXsdTypeManager.Instance, XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/"));
                }
                return this.titleField;
            }
            set
            {
                if ((value==null))
                {
                    this.titleField=null;
                } else
                {
                    if ((this.titleField==null))
                    {
                        this.titleField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.title>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("title", "http://purl.org/dc/elements/1.1/"), XName.Get("alternative", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.title>(this.titleField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public GeoSik.DublinCore.Elements.V11.type type
        {
            get
            {
                XElement x=this.GetElement(XName.Get("type", "http://purl.org/dc/elements/1.1/"));
                return ((GeoSik.DublinCore.Elements.V11.type)(x));
            }
            set
            {
                this.SetElement(XName.Get("type", "http://purl.org/dc/elements/1.1/"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.subject> subject
        {
            get
            {
                if ((this.subjectField==null))
                {
                    this.subjectField=new XTypedList<GeoSik.DublinCore.Elements.V11.subject>(this, LinqToXsdTypeManager.Instance, XName.Get("subject", "http://purl.org/dc/elements/1.1/"));
                }
                return this.subjectField;
            }
            set
            {
                if ((value==null))
                {
                    this.subjectField=null;
                } else
                {
                    if ((this.subjectField==null))
                    {
                        this.subjectField=XTypedList<GeoSik.DublinCore.Elements.V11.subject>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("subject", "http://purl.org/dc/elements/1.1/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.subject>(this.subjectField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: format, extent, medium
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.format> format
        {
            get
            {
                if ((this.formatField==null))
                {
                    this.formatField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.format>(this, LinqToXsdTypeManager.Instance, XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"));
                }
                return this.formatField;
            }
            set
            {
                if ((value==null))
                {
                    this.formatField=null;
                } else
                {
                    if ((this.formatField==null))
                    {
                        this.formatField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.format>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("format", "http://purl.org/dc/elements/1.1/"), XName.Get("extent", "http://purl.org/dc/terms/"), XName.Get("medium", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.format>(this.formatField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: relation, conformsTo, hasFormat, hasPart, hasVersion, isFormatOf, isPartOf, isReferencedBy, isReplacedBy, isRequiredBy, isVersionOf, references, replaces, requires
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.relation> relation
        {
            get
            {
                if ((this.relationField==null))
                {
                    this.relationField=new XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.relation>(this, LinqToXsdTypeManager.Instance, XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"));
                }
                return this.relationField;
            }
            set
            {
                if ((value==null))
                {
                    this.relationField=null;
                } else
                {
                    if ((this.relationField==null))
                    {
                        this.relationField=XTypedSubstitutedList<GeoSik.DublinCore.Elements.V11.relation>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("relation", "http://purl.org/dc/elements/1.1/"), XName.Get("conformsTo", "http://purl.org/dc/terms/"), XName.Get("hasFormat", "http://purl.org/dc/terms/"), XName.Get("hasPart", "http://purl.org/dc/terms/"), XName.Get("hasVersion", "http://purl.org/dc/terms/"), XName.Get("isFormatOf", "http://purl.org/dc/terms/"), XName.Get("isPartOf", "http://purl.org/dc/terms/"), XName.Get("isReferencedBy", "http://purl.org/dc/terms/"), XName.Get("isReplacedBy", "http://purl.org/dc/terms/"), XName.Get("isRequiredBy", "http://purl.org/dc/terms/"), XName.Get("isVersionOf", "http://purl.org/dc/terms/"), XName.Get("references", "http://purl.org/dc/terms/"), XName.Get("replaces", "http://purl.org/dc/terms/"), XName.Get("requires", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Elements.V11.relation>(this.relationField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.modified> modified
        {
            get
            {
                if ((this.modifiedField==null))
                {
                    this.modifiedField=new XTypedList<GeoSik.DublinCore.Terms.modified>(this, LinqToXsdTypeManager.Instance, XName.Get("modified", "http://purl.org/dc/terms/"));
                }
                return this.modifiedField;
            }
            set
            {
                if ((value==null))
                {
                    this.modifiedField=null;
                } else
                {
                    if ((this.modifiedField==null))
                    {
                        this.modifiedField=XTypedList<GeoSik.DublinCore.Terms.modified>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("modified", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Terms.modified>(this.modifiedField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.@abstract> @abstract
        {
            get
            {
                if ((this.@abstractField==null))
                {
                    this.@abstractField=new XTypedList<GeoSik.DublinCore.Terms.@abstract>(this, LinqToXsdTypeManager.Instance, XName.Get("abstract", "http://purl.org/dc/terms/"));
                }
                return this.@abstractField;
            }
            set
            {
                if ((value==null))
                {
                    this.@abstractField=null;
                } else
                {
                    if ((this.@abstractField==null))
                    {
                        this.@abstractField=XTypedList<GeoSik.DublinCore.Terms.@abstract>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("abstract", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Terms.@abstract>(this.@abstractField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.spatial> spatial
        {
            get
            {
                if ((this.spatialField==null))
                {
                    this.spatialField=new XTypedList<GeoSik.DublinCore.Terms.spatial>(this, LinqToXsdTypeManager.Instance, XName.Get("spatial", "http://purl.org/dc/terms/"));
                }
                return this.spatialField;
            }
            set
            {
                if ((value==null))
                {
                    this.spatialField=null;
                } else
                {
                    if ((this.spatialField==null))
                    {
                        this.spatialField=XTypedList<GeoSik.DublinCore.Terms.spatial>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("spatial", "http://purl.org/dc/terms/"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.DublinCore.Terms.spatial>(this.spatialField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                if ((this.BoundingBoxField==null))
                {
                    this.BoundingBoxField=new XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this, LinqToXsdTypeManager.Instance, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
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
                        this.BoundingBoxField=XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this.BoundingBoxField, value);
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
                return XName.Get("SummaryRecordType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<SummaryRecordType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("identifier", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.identifier));
            localElementDictionary.Add(XName.Get("title", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.title));
            localElementDictionary.Add(XName.Get("type", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.type));
            localElementDictionary.Add(XName.Get("subject", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.subject));
            localElementDictionary.Add(XName.Get("format", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.format));
            localElementDictionary.Add(XName.Get("relation", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.relation));
            localElementDictionary.Add(XName.Get("modified", "http://purl.org/dc/terms/"), typeof(GeoSik.DublinCore.Terms.modified));
            localElementDictionary.Add(XName.Get("abstract", "http://purl.org/dc/terms/"), typeof(GeoSik.DublinCore.Terms.@abstract));
            localElementDictionary.Add(XName.Get("spatial", "http://purl.org/dc/terms/"), typeof(GeoSik.DublinCore.Terms.spatial));
            localElementDictionary.Add(XName.Get("BoundingBox", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.BoundingBox));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SummaryRecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SummaryRecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type extends DCMIRecordType to add ows:BoundingBox;
    ///            it may be used to specify a spatial envelope for the
    ///            catalogued resource.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed partial class RecordType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.DCMIRecordType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<EmptyType> AnyTextField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBoxField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator RecordType(XElement xe) { return XTypedServices.ToXTypedElement<RecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static RecordType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type extends DCMIRecordType to add ows:BoundingBox;
        ///            it may be used to specify a spatial envelope for the
        ///            catalogued resource.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
        /// </para>
        /// </summary>
        public RecordType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<EmptyType> AnyText
        {
            get
            {
                if ((this.AnyTextField==null))
                {
                    this.AnyTextField=new XTypedList<EmptyType>(this, LinqToXsdTypeManager.Instance, XName.Get("AnyText", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.AnyTextField;
            }
            set
            {
                if ((value==null))
                {
                    this.AnyTextField=null;
                } else
                {
                    if ((this.AnyTextField==null))
                    {
                        this.AnyTextField=XTypedList<EmptyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("AnyText", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<EmptyType>(this.AnyTextField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                if ((this.BoundingBoxField==null))
                {
                    this.BoundingBoxField=new XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this, LinqToXsdTypeManager.Instance, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
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
                        this.BoundingBoxField=XTypedSubstitutedList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("BoundingBox", "http://www.opengis.net/ows"), XName.Get("WGS84BoundingBox", "http://www.opengis.net/ows"));
                    } else
                    {
                        XTypedServices.SetList<GeoSik.Ogc.Ows.V100.Types.BoundingBox>(this.BoundingBoxField, value);
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
                return XName.Get("RecordType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<RecordType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DC-element", "http://purl.org/dc/elements/1.1/"), typeof(GeoSik.DublinCore.Elements.V11.DCelement));
            localElementDictionary.Add(XName.Get("AnyText", "http://www.opengis.net/cat/csw/2.0.2"), typeof(EmptyType));
            localElementDictionary.Add(XName.Get("BoundingBox", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.BoundingBox));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName RecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    [XmlSchemaProviderAttribute("EmptyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class EmptyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator EmptyType(XElement xe) { return XTypedServices.ToXTypedElement<EmptyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public EmptyType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("EmptyType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<EmptyType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName EmptyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("EmptyType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Base type for all request messages except GetCapabilities. The 
    ///            attributes identify the relevant service type and version.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RequestBaseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class RequestBaseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string serviceFixedValue="CSW";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string versionFixedValue="2.0.2";

        public static explicit operator RequestBaseType(XElement xe) { return (RequestBaseType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            Base type for all request messages except GetCapabilities. The 
        ///            attributes identify the relevant service type and version.
        ///         
        /// </para>
        /// </summary>
        public RequestBaseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string service
        {
            get
            {
                return serviceFixedValue;
            }
            set
            {
                if (value.Equals(serviceFixedValue))
                {
                } else
                {
                    throw new Xml.Schema.Linq.LinqToXsdFixedValueException(value, serviceFixedValue);
                }
                this.SetAttribute(XName.Get("service", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
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
                return versionFixedValue;
            }
            set
            {
                if (value.Equals(versionFixedValue))
                {
                } else
                {
                    throw new Xml.Schema.Linq.LinqToXsdFixedValueException(value, versionFixedValue);
                }
                this.SetAttribute(XName.Get("version", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("RequestBaseType", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static XmlQualifiedName RequestBaseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RequestBaseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Request for a description of service capabilities. See OGC 05-008 
    ///            for more information.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (AcceptVersions?, Sections?, AcceptFormats?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetCapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetCapabilitiesType: global::GeoSik.Ogc.Ows.V100.Types.GetCapabilitiesType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string serviceDefaultValue="http://www.opengis.net/cat/csw";

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
        /// 
        ///            Request for a description of service capabilities. See OGC 05-008 
        ///            for more information.
        ///         
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string service
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("service", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, serviceDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("service", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
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
                return XName.Get("GetCapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2");
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
            localElementDictionary.Add(XName.Get("AcceptVersions", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.AcceptVersionsType));
            localElementDictionary.Add(XName.Get("Sections", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.SectionsType));
            localElementDictionary.Add(XName.Get("AcceptFormats", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.AcceptFormatsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GetCapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetCapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// This type extends ows:CapabilitiesBaseType defined in OGC-05-008 
    ///         to include information about supported OGC filter components. A 
    ///         profile may extend this type to describe additional capabilities.
    /// </para>
    /// <para>
    /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?, Filter_Capabilities)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("CapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class CapabilitiesType: global::GeoSik.Ogc.Ows.V100.Types.CapabilitiesBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator CapabilitiesType(XElement xe) { return XTypedServices.ToXTypedElement<CapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static CapabilitiesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("ServiceIdentification", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("ServiceProvider", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("OperationsMetadata", "http://www.opengis.net/ows")), new NamedContentModelEntity(XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// This type extends ows:CapabilitiesBaseType defined in OGC-05-008 
        ///         to include information about supported OGC filter components. A 
        ///         profile may extend this type to describe additional capabilities.
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?, Filter_Capabilities)
        /// </para>
        /// </summary>
        public CapabilitiesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?, Filter_Capabilities)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.Filter_Capabilities Filter_Capabilities
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc"));
                return ((GeoSik.Ogc.Filter.V110.Filter_Capabilities)(x));
            }
            set
            {
                this.SetElement(XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("CapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<CapabilitiesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ServiceIdentification", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.ServiceIdentification));
            localElementDictionary.Add(XName.Get("ServiceProvider", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.ServiceProvider));
            localElementDictionary.Add(XName.Get("OperationsMetadata", "http://www.opengis.net/ows"), typeof(GeoSik.Ogc.Ows.V100.Types.OperationsMetadata));
            localElementDictionary.Add(XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc"), typeof(GeoSik.Ogc.Filter.V110.Filter_Capabilities));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName CapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("CapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// This request allows a user to discover elements of the
    ///         information model supported by the catalogue. If no TypeName 
    ///         elements are included, then all of the schemas for the 
    ///         information model must be returned.
    ///      
    ///         schemaLanguage - preferred schema language
    ///                          (W3C XML Schema by default)
    ///         outputFormat - preferred output format (application/xml by default)
    /// </para>
    /// <para>
    /// Regular expression: (TypeName*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DescribeRecordTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DescribeRecordType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<System.Xml.XmlQualifiedName> TypeNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string outputFormatDefaultValue="application/xml";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static System.Uri schemaLanguageDefaultValue=new Uri("http://www.w3.org/XML/Schema");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DescribeRecordType(XElement xe) { return XTypedServices.ToXTypedElement<DescribeRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DescribeRecordType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("TypeName", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// This request allows a user to discover elements of the
        ///         information model supported by the catalogue. If no TypeName 
        ///         elements are included, then all of the schemas for the 
        ///         information model must be returned.
        ///      
        ///         schemaLanguage - preferred schema language
        ///                          (W3C XML Schema by default)
        ///         outputFormat - preferred output format (application/xml by default)
        /// </para>
        /// <para>
        /// Regular expression: (TypeName*)
        /// </para>
        /// </summary>
        public DescribeRecordType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (TypeName*)
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> TypeName
        {
            get
            {
                if ((this.TypeNameField==null))
                {
                    this.TypeNameField=new XSimpleList<System.Xml.XmlQualifiedName>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype, XName.Get("TypeName", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.TypeNameField;
            }
            set
            {
                if ((value==null))
                {
                    this.TypeNameField=null;
                } else
                {
                    if ((this.TypeNameField==null))
                    {
                        this.TypeNameField=XSimpleList<System.Xml.XmlQualifiedName>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype, value, XName.Get("TypeName", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<System.Xml.XmlQualifiedName>(this.TypeNameField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("outputFormat", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, outputFormatDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("outputFormat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri schemaLanguage
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("schemaLanguage", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, schemaLanguageDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("schemaLanguage", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("DescribeRecordType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DescribeRecordType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("TypeName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Xml.XmlQualifiedName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DescribeRecordTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DescribeRecordType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// The response contains a list of matching schema components
    ///         in the requested schema language.
    /// </para>
    /// <para>
    /// Regular expression: (SchemaComponent*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DescribeRecordResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DescribeRecordResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SchemaComponentType> SchemaComponentField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DescribeRecordResponseType(XElement xe) { return XTypedServices.ToXTypedElement<DescribeRecordResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DescribeRecordResponseType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SchemaComponent", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// The response contains a list of matching schema components
        ///         in the requested schema language.
        /// </para>
        /// <para>
        /// Regular expression: (SchemaComponent*)
        /// </para>
        /// </summary>
        public DescribeRecordResponseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (SchemaComponent*)
        /// </para>
        /// </summary>
        public IList<SchemaComponentType> SchemaComponent
        {
            get
            {
                if ((this.SchemaComponentField==null))
                {
                    this.SchemaComponentField=new XTypedList<SchemaComponentType>(this, LinqToXsdTypeManager.Instance, XName.Get("SchemaComponent", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.SchemaComponentField;
            }
            set
            {
                if ((value==null))
                {
                    this.SchemaComponentField=null;
                } else
                {
                    if ((this.SchemaComponentField==null))
                    {
                        this.SchemaComponentField=XTypedList<SchemaComponentType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("SchemaComponent", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<SchemaComponentType>(this.SchemaComponentField, value);
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
                return XName.Get("DescribeRecordResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DescribeRecordResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("SchemaComponent", "http://www.opengis.net/cat/csw/2.0.2"), typeof(SchemaComponentType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DescribeRecordResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DescribeRecordResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// A schema component includes a schema fragment (type
    ///         definition) or an entire schema from some target namespace;
    ///         the schema language is identified by URI. If the component
    ///         is a schema fragment its parent MUST be referenced (parentSchema).
    /// </para>
    /// <para>
    /// Regular expression: (any)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SchemaComponentTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SchemaComponentType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator SchemaComponentType(XElement xe) { return XTypedServices.ToXTypedElement<SchemaComponentType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SchemaComponentType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// A schema component includes a schema fragment (type
        ///         definition) or an entire schema from some target namespace;
        ///         the schema language is identified by URI. If the component
        ///         is a schema fragment its parent MUST be referenced (parentSchema).
        /// </para>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public SchemaComponentType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri targetNamespace
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("targetNamespace", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("targetNamespace", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri parentSchema
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("parentSchema", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("parentSchema", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri schemaLanguage
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("schemaLanguage", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("schemaLanguage", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SchemaComponentType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<SchemaComponentType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##any", "http://www.opengis.net/cat/csw/2.0.2"), 2)));
            validationStates=new FSM(1, new Set<int>(2), transitions);
        }

        public static XmlQualifiedName SchemaComponentTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SchemaComponentType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///         The principal means of searching the catalogue. The matching 
    ///         catalogue entries may be included with the response. The client 
    ///         may assign a requestId (absolute URI). A distributed search is 
    ///         performed if the DistributedSearch element is present and the 
    ///         catalogue is a member of a federation. Profiles may allow 
    ///         alternative query expressions.
    /// </para>
    /// <para>
    /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordsType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<System.Uri> ResponseHandlerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string resultTypeDefaultValue="hits";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string outputFormatDefaultValue="application/xml";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static decimal startPositionDefaultValue=System.Xml.XmlConvert.ToDecimal("1");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static decimal maxRecordsDefaultValue=System.Xml.XmlConvert.ToDecimal("10");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator GetRecordsType(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetRecordsType()
        {
            BuildElementDictionary();
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// 
        ///         The principal means of searching the catalogue. The matching 
        ///         catalogue entries may be included with the response. The client 
        ///         may assign a requestId (absolute URI). A distributed search is 
        ///         performed if the DistributedSearch element is present and the 
        ///         catalogue is a member of a federation. Profiles may allow 
        ///         alternative query expressions.
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public GetRecordsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public DistributedSearchType DistributedSearch
        {
            get
            {
                XElement x=this.GetElement(XName.Get("DistributedSearch", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((DistributedSearchType)(x));
            }
            set
            {
                this.SetElement(XName.Get("DistributedSearch", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public IList<System.Uri> ResponseHandler
        {
            get
            {
                if ((this.ResponseHandlerField==null))
                {
                    this.ResponseHandlerField=new XSimpleList<System.Uri>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.ResponseHandlerField;
            }
            set
            {
                if ((value==null))
                {
                    this.ResponseHandlerField=null;
                } else
                {
                    if ((this.ResponseHandlerField==null))
                    {
                        this.ResponseHandlerField=XSimpleList<System.Uri>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, value, XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<System.Uri>(this.ResponseHandlerField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: AbstractQuery, Query
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public AbstractQuery AbstractQuery
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((AbstractQuery)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri requestId
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("requestId", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("requestId", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string resultType
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("resultType", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, resultTypeDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("resultType", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("outputFormat", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, outputFormatDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("outputFormat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri outputSchema
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("outputSchema", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("outputSchema", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public decimal startPosition
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("startPosition", ""));
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype, startPositionDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("startPosition", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public decimal maxRecords
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("maxRecords", ""));
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype, maxRecordsDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("maxRecords", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
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
                return XName.Get("GetRecordsType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetRecordsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DistributedSearch", "http://www.opengis.net/cat/csw/2.0.2"), typeof(DistributedSearchType));
            localElementDictionary.Add(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), typeof(AbstractQuery));
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(XName.Get("DistributedSearch", "http://www.opengis.net/cat/csw/2.0.2"), 2), new SingleTransition(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"), 3), new SingleTransition(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 8)));
            transitions.Add(2, new Transitions(new SingleTransition(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"), 2), new SingleTransition(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 8)));
            transitions.Add(3, new Transitions(new SingleTransition(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"), 3), new SingleTransition(XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2"), 6), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 8)));
            validationStates=new FSM(1, new Set<int>(new int[] {
                            6,
                            8}), transitions);
        }

        public static XmlQualifiedName GetRecordsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetRecordsType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class ResultType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "results",
                        "hits",
                        "validate"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private ResultType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Governs the behaviour of a distributed search.
    ///         hopCount     - the maximum number of message hops before
    ///                        the search is terminated. Each catalogue node 
    ///                        decrements this value when the request is received, 
    ///                        and must not forward the request if hopCount=0.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DistributedSearchTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DistributedSearchType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static decimal hopCountDefaultValue=System.Xml.XmlConvert.ToDecimal("2");

        public static explicit operator DistributedSearchType(XElement xe) { return XTypedServices.ToXTypedElement<DistributedSearchType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Governs the behaviour of a distributed search.
        ///         hopCount     - the maximum number of message hops before
        ///                        the search is terminated. Each catalogue node 
        ///                        decrements this value when the request is received, 
        ///                        and must not forward the request if hopCount=0.
        /// </para>
        /// </summary>
        public DistributedSearchType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public decimal hopCount
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("hopCount", ""));
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype, hopCountDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("hopCount", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.PositiveInteger).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DistributedSearchType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DistributedSearchType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName DistributedSearchTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DistributedSearchType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    [XmlSchemaProviderAttribute("AbstractQueryTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractQueryType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AbstractQueryType(XElement xe) { return (AbstractQueryType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractQueryType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AbstractQueryType", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static XmlQualifiedName AbstractQueryTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AbstractQueryType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Specifies a query to execute against instances of one or
    ///         more object types. A set of ElementName elements may be included 
    ///         to specify an adhoc view of the csw:Record instances in the result 
    ///         set. Otherwise, use ElementSetName to specify a predefined view. 
    ///         The Constraint element contains a query filter expressed in a 
    ///         supported query language. A sorting criterion that specifies a 
    ///         property to sort by may be included.
    ///
    ///         typeNames - a list of object types to query.
    /// </para>
    /// <para>
    /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("QueryTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class QueryType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractQueryType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<System.Xml.XmlQualifiedName> ElementNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator QueryType(XElement xe) { return XTypedServices.ToXTypedElement<QueryType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static QueryType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Specifies a query to execute against instances of one or
        ///         more object types. A set of ElementName elements may be included 
        ///         to specify an adhoc view of the csw:Record instances in the result 
        ///         set. Otherwise, use ElementSetName to specify a predefined view. 
        ///         The Constraint element contains a query filter expressed in a 
        ///         supported query language. A sorting criterion that specifies a 
        ///         property to sort by may be included.
        ///
        ///         typeNames - a list of object types to query.
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public QueryType()
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
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public ElementSetName ElementSetName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((ElementSetName)(x));
            }
            set
            {
                this.SetElement(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> ElementName
        {
            get
            {
                if ((this.ElementNameField==null))
                {
                    this.ElementNameField=new XSimpleList<System.Xml.XmlQualifiedName>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype, XName.Get("ElementName", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.ElementNameField;
            }
            set
            {
                if ((value==null))
                {
                    this.ElementNameField=null;
                } else
                {
                    if ((this.ElementNameField==null))
                    {
                        this.ElementNameField=XSimpleList<System.Xml.XmlQualifiedName>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype, value, XName.Get("ElementName", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<System.Xml.XmlQualifiedName>(this.ElementNameField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public Constraint Constraint
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((Constraint)(x));
            }
            set
            {
                this.SetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.SortBy SortBy
        {
            get
            {
                XElement x=this.GetElement(XName.Get("SortBy", "http://www.opengis.net/ogc"));
                return ((GeoSik.Ogc.Filter.V110.SortBy)(x));
            }
            set
            {
                this.SetElement(XName.Get("SortBy", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> typeNames
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("typeNames", ""));
                return XTypedServices.ParseListValue<System.Xml.XmlQualifiedName>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
            }
            set
            {
                this.SetListAttribute(XName.Get("typeNames", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
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
                return XName.Get("QueryType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<QueryType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(ElementSetName));
            localElementDictionary.Add(XName.Get("ElementName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Xml.XmlQualifiedName));
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), typeof(Constraint));
            localElementDictionary.Add(XName.Get("SortBy", "http://www.opengis.net/ogc"), typeof(GeoSik.Ogc.Filter.V110.SortBy));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName QueryTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("QueryType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// The exact syntax is defined in an application profile. If querying 
    ///       against the common record properties, only a single type may be 
    ///       specified (Record).
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class TypeNameListType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.ListSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName), null, new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName), null));

        private TypeNameListType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// A search constraint that adheres to one of the following syntaxes:
    ///         Filter   - OGC filter expression
    ///         CqlText  - OGC CQL predicate
    /// </para>
    /// <para>
    /// Regular expression: (Filter | CqlText)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("QueryConstraintTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class QueryConstraintType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator QueryConstraintType(XElement xe) { return XTypedServices.ToXTypedElement<QueryConstraintType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static QueryConstraintType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new NamedContentModelEntity(XName.Get("Filter", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("CqlText", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// A search constraint that adheres to one of the following syntaxes:
        ///         Filter   - OGC filter expression
        ///         CqlText  - OGC CQL predicate
        /// </para>
        /// <para>
        /// Regular expression: (Filter | CqlText)
        /// </para>
        /// </summary>
        public QueryConstraintType()
        {
        }

        public QueryConstraintType(GeoSik.Ogc.Filter.V110.Filter Filter)
        {
            this.Filter=Filter;
        }

        public QueryConstraintType(string CqlText)
        {
            this.CqlText=CqlText;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Filter | CqlText)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.Filter Filter
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Filter", "http://www.opengis.net/ogc"));
                return ((GeoSik.Ogc.Filter.V110.Filter)(x));
            }
            set
            {
                this.SetElement(XName.Get("Filter", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Filter | CqlText)
        /// </para>
        /// </summary>
        public string CqlText
        {
            get
            {
                XElement x=this.GetElement(XName.Get("CqlText", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("CqlText", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Query language version
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
                return XName.Get("QueryConstraintType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<QueryConstraintType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Filter", "http://www.opengis.net/ogc"), typeof(GeoSik.Ogc.Filter.V110.Filter));
            localElementDictionary.Add(XName.Get("CqlText", "http://www.opengis.net/cat/csw/2.0.2"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName QueryConstraintTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("QueryConstraintType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    [XmlSchemaProviderAttribute("ElementSetNameTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ElementSetNameType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator ElementSetNameType(XElement xe) { return XTypedServices.ToXTypedElement<ElementSetNameType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ElementSetNameType()
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
                this.SetValueWithValidation(value, "TypedValue", global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.ElementSetType.TypeDefinition);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> typeNames
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("typeNames", ""));
                return XTypedServices.ParseListValue<System.Xml.XmlQualifiedName>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
            }
            set
            {
                this.SetListAttribute(XName.Get("typeNames", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ElementSetNameType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<ElementSetNameType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName ElementSetNameTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ElementSetNameType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Named subsets of catalogue object properties; these
    ///         views are mapped to a specific information model and
    ///         are defined in an application profile.
    /// </para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class ElementSetType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "brief",
                        "summary",
                        "full"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private ElementSetType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            The response message for a GetRecords request. Some or all of the 
    ///            matching records may be included as children of the SearchResults 
    ///            element. The RequestId is only included if the client specified it.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (RequestId?, SearchStatus, SearchResults)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordsResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordsResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GetRecordsResponseType(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordsResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetRecordsResponseType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("SearchStatus", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("SearchResults", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            The response message for a GetRecords request. Some or all of the 
        ///            matching records may be included as children of the SearchResults 
        ///            element. The RequestId is only included if the client specified it.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public GetRecordsResponseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public System.Uri RequestId
        {
            get
            {
                XElement x=this.GetElement(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public RequestStatusType SearchStatus
        {
            get
            {
                XElement x=this.GetElement(XName.Get("SearchStatus", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((RequestStatusType)(x));
            }
            set
            {
                this.SetElement(XName.Get("SearchStatus", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public SearchResultsType SearchResults
        {
            get
            {
                XElement x=this.GetElement(XName.Get("SearchResults", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((SearchResultsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("SearchResults", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
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
                return XName.Get("GetRecordsResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetRecordsResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("SearchStatus", "http://www.opengis.net/cat/csw/2.0.2"), typeof(RequestStatusType));
            localElementDictionary.Add(XName.Get("SearchResults", "http://www.opengis.net/cat/csw/2.0.2"), typeof(SearchResultsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GetRecordsResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetRecordsResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This element provides information about the status of the
    ///            search request.
    ///
    ///            status    - status of the search
    ///            timestamp - the date and time when the result set was modified 
    ///                        (ISO 8601 format: YYYY-MM-DDThh:mm:ss[+|-]hh:mm).
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RequestStatusTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RequestStatusType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator RequestStatusType(XElement xe) { return XTypedServices.ToXTypedElement<RequestStatusType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            This element provides information about the status of the
        ///            search request.
        ///
        ///            status    - status of the search
        ///            timestamp - the date and time when the result set was modified 
        ///                        (ISO 8601 format: YYYY-MM-DDThh:mm:ss[+|-]hh:mm).
        ///         
        /// </para>
        /// </summary>
        public RequestStatusType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<System.DateTime> timestamp
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("timestamp", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<System.DateTime>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("timestamp", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("RequestStatusType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<RequestStatusType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName RequestStatusTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RequestStatusType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Includes representations of result set members if maxRecords > 0.
    ///         The items must conform to one of the csw:Record views or a 
    ///         profile-specific representation. 
    ///         
    ///         resultSetId  - id of the result set (a URI).
    ///         elementSet  - The element set that has been returned
    ///                       (i.e., "brief", "summary", "full")
    ///         recordSchema  - schema reference for included records(URI)
    ///         numberOfRecordsMatched  - number of records matched by the query
    ///         numberOfRecordsReturned - number of records returned to client
    ///         nextRecord - position of next record in the result set
    ///                      (0 if no records remain).
    ///         expires - the time instant when the result set expires and 
    ///                   is discarded (ISO 8601 format)
    /// </para>
    /// <para>
    /// Regular expression: ((AbstractRecord* | any))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SearchResultsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SearchResultsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<AbstractRecord> AbstractRecordField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator SearchResultsType(XElement xe) { return XTypedServices.ToXTypedElement<SearchResultsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SearchResultsType()
        {
            BuildElementDictionary();
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Includes representations of result set members if maxRecords > 0.
        ///         The items must conform to one of the csw:Record views or a 
        ///         profile-specific representation. 
        ///         
        ///         resultSetId  - id of the result set (a URI).
        ///         elementSet  - The element set that has been returned
        ///                       (i.e., "brief", "summary", "full")
        ///         recordSchema  - schema reference for included records(URI)
        ///         numberOfRecordsMatched  - number of records matched by the query
        ///         numberOfRecordsReturned - number of records returned to client
        ///         nextRecord - position of next record in the result set
        ///                      (0 if no records remain).
        ///         expires - the time instant when the result set expires and 
        ///                   is discarded (ISO 8601 format)
        /// </para>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public SearchResultsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: AbstractRecord, DCMIRecord, BriefRecord, SummaryRecord, Record
        /// </para>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IList<AbstractRecord> AbstractRecord
        {
            get
            {
                if ((this.AbstractRecordField==null))
                {
                    this.AbstractRecordField=new XTypedSubstitutedList<AbstractRecord>(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.AbstractRecordField;
            }
            set
            {
                if ((value==null))
                {
                    this.AbstractRecordField=null;
                } else
                {
                    if ((this.AbstractRecordField==null))
                    {
                        this.AbstractRecordField=XTypedSubstitutedList<AbstractRecord>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<AbstractRecord>(this.AbstractRecordField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri resultSetId
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("resultSetId", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("resultSetId", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string elementSet
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("elementSet", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("elementSet", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri recordSchema
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("recordSchema", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("recordSchema", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public decimal numberOfRecordsMatched
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("numberOfRecordsMatched", ""));
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("numberOfRecordsMatched", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public decimal numberOfRecordsReturned
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("numberOfRecordsReturned", ""));
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("numberOfRecordsReturned", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> nextRecord
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nextRecord", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("nextRecord", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<System.DateTime> expires
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("expires", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<System.DateTime>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("expires", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
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
                return XName.Get("SearchResultsType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<SearchResultsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(AbstractRecord));
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 3)));
            transitions.Add(3, new Transitions(new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 3)));
            validationStates=new FSM(1, new Set<int>(new int[] {
                            1,
                            3}), transitions);
        }

        public static XmlQualifiedName SearchResultsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SearchResultsType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Convenience operation to retrieve default record representations 
    ///            by identifier.
    ///            Id - object identifier (a URI) that provides a reference to a 
    ///                 catalogue item (or a result set if the catalogue supports 
    ///                 persistent result sets).
    ///            ElementSetName - one of "brief, "summary", or "full"
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (Id+, ElementSetName?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordByIdTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordByIdType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<System.Uri> IdField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string outputFormatDefaultValue="application/xml";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GetRecordByIdType(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordByIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetRecordByIdType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Id", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            Convenience operation to retrieve default record representations 
        ///            by identifier.
        ///            Id - object identifier (a URI) that provides a reference to a 
        ///                 catalogue item (or a result set if the catalogue supports 
        ///                 persistent result sets).
        ///            ElementSetName - one of "brief, "summary", or "full"
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (Id+, ElementSetName?)
        /// </para>
        /// </summary>
        public GetRecordByIdType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Id+, ElementSetName?)
        /// </para>
        /// </summary>
        public IList<System.Uri> Id
        {
            get
            {
                if ((this.IdField==null))
                {
                    this.IdField=new XSimpleList<System.Uri>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, XName.Get("Id", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.IdField;
            }
            set
            {
                if ((value==null))
                {
                    this.IdField=null;
                } else
                {
                    if ((this.IdField==null))
                    {
                        this.IdField=XSimpleList<System.Uri>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, value, XName.Get("Id", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<System.Uri>(this.IdField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Id+, ElementSetName?)
        /// </para>
        /// </summary>
        public ElementSetName ElementSetName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((ElementSetName)(x));
            }
            set
            {
                this.SetElement(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("outputFormat", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, outputFormatDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("outputFormat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri outputSchema
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("outputSchema", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("outputSchema", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("GetRecordByIdType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetRecordByIdType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Id", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(ElementSetName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GetRecordByIdTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetRecordByIdType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Returns a representation of the matching entry. If there is no 
    ///         matching record, the response message must be empty.
    /// </para>
    /// <para>
    /// Regular expression: ((AbstractRecord* | any))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordByIdResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordByIdResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<AbstractRecord> AbstractRecordField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator GetRecordByIdResponseType(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordByIdResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetRecordByIdResponseType()
        {
            BuildElementDictionary();
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Returns a representation of the matching entry. If there is no 
        ///         matching record, the response message must be empty.
        /// </para>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public GetRecordByIdResponseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: AbstractRecord, DCMIRecord, BriefRecord, SummaryRecord, Record
        /// </para>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IList<AbstractRecord> AbstractRecord
        {
            get
            {
                if ((this.AbstractRecordField==null))
                {
                    this.AbstractRecordField=new XTypedSubstitutedList<AbstractRecord>(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.AbstractRecordField;
            }
            set
            {
                if ((value==null))
                {
                    this.AbstractRecordField=null;
                } else
                {
                    if ((this.AbstractRecordField==null))
                    {
                        this.AbstractRecordField=XTypedSubstitutedList<AbstractRecord>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<AbstractRecord>(this.AbstractRecordField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
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
                return XName.Get("GetRecordByIdResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetRecordByIdResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(AbstractRecord));
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2"), 1), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 3)));
            transitions.Add(3, new Transitions(new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 3)));
            validationStates=new FSM(1, new Set<int>(new int[] {
                            1,
                            3}), transitions);
        }

        public static XmlQualifiedName GetRecordByIdResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetRecordByIdResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Requests the actual values of some specified request parameter 
    ///        or other data element.
    /// </para>
    /// <para>
    /// Regular expression: ((PropertyName | ParameterName))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetDomainTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetDomainType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator GetDomainType(XElement xe) { return XTypedServices.ToXTypedElement<GetDomainType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetDomainType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Requests the actual values of some specified request parameter 
        ///        or other data element.
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName))
        /// </para>
        /// </summary>
        public GetDomainType()
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
        /// Regular expression: ((PropertyName | ParameterName))
        /// </para>
        /// </summary>
        public System.Uri PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName))
        /// </para>
        /// </summary>
        public System.Uri ParameterName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("GetDomainType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetDomainType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName GetDomainTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetDomainType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Returns the actual values for some property. In general this is a
    ///         subset of the value domain (that is, set of permissible values),
    ///         although in some cases these may be the same.
    /// </para>
    /// <para>
    /// Regular expression: (DomainValues+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetDomainResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetDomainResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DomainValuesType> DomainValuesField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GetDomainResponseType(XElement xe) { return XTypedServices.ToXTypedElement<GetDomainResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GetDomainResponseType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DomainValues", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Returns the actual values for some property. In general this is a
        ///         subset of the value domain (that is, set of permissible values),
        ///         although in some cases these may be the same.
        /// </para>
        /// <para>
        /// Regular expression: (DomainValues+)
        /// </para>
        /// </summary>
        public GetDomainResponseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DomainValues+)
        /// </para>
        /// </summary>
        public IList<DomainValuesType> DomainValues
        {
            get
            {
                if ((this.DomainValuesField==null))
                {
                    this.DomainValuesField=new XTypedList<DomainValuesType>(this, LinqToXsdTypeManager.Instance, XName.Get("DomainValues", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.DomainValuesField;
            }
            set
            {
                if ((value==null))
                {
                    this.DomainValuesField=null;
                } else
                {
                    if ((this.DomainValuesField==null))
                    {
                        this.DomainValuesField=XTypedList<DomainValuesType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("DomainValues", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<DomainValuesType>(this.DomainValuesField, value);
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
                return XName.Get("GetDomainResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<GetDomainResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("DomainValues", "http://www.opengis.net/cat/csw/2.0.2"), typeof(DomainValuesType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GetDomainResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GetDomainResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DomainValuesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DomainValuesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator DomainValuesType(XElement xe) { return XTypedServices.ToXTypedElement<DomainValuesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DomainValuesType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public DomainValuesType()
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
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public System.Uri PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public System.Uri ParameterName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public ListOfValuesType ListOfValues
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ListOfValues", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((ListOfValuesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ListOfValues", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public ConceptualSchemeType ConceptualScheme
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ConceptualScheme", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((ConceptualSchemeType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ConceptualScheme", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName), (ListOfValues | ConceptualScheme | RangeOfValues)?)
        /// </para>
        /// </summary>
        public RangeOfValuesType RangeOfValues
        {
            get
            {
                XElement x=this.GetElement(XName.Get("RangeOfValues", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((RangeOfValuesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("RangeOfValues", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Xml.XmlQualifiedName type
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("type", ""));
                return XTypedServices.ParseValue<System.Xml.XmlQualifiedName>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("type", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.QName).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri uom
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("uom", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("uom", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("DomainValuesType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DomainValuesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("ParameterName", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("ListOfValues", "http://www.opengis.net/cat/csw/2.0.2"), typeof(ListOfValuesType));
            localElementDictionary.Add(XName.Get("ConceptualScheme", "http://www.opengis.net/cat/csw/2.0.2"), typeof(ConceptualSchemeType));
            localElementDictionary.Add(XName.Get("RangeOfValues", "http://www.opengis.net/cat/csw/2.0.2"), typeof(RangeOfValuesType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName DomainValuesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DomainValuesType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Value+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ListOfValuesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ListOfValuesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<XTypedElement> ValueField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ListOfValuesType(XElement xe) { return XTypedServices.ToXTypedElement<ListOfValuesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ListOfValuesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Value+)
        /// </para>
        /// </summary>
        public ListOfValuesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Value+)
        /// </para>
        /// </summary>
        public IList<XTypedElement> Value
        {
            get
            {
                if ((this.ValueField==null))
                {
                    this.ValueField=new XTypedList<XTypedElement>(this, LinqToXsdTypeManager.Instance, XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"));
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
                        this.ValueField=XTypedList<XTypedElement>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<XTypedElement>(this.ValueField, value);
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
                return XName.Get("ListOfValuesType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<ListOfValuesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"), typeof(XTypedElement));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ListOfValuesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ListOfValuesType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Name, Document, Authority)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ConceptualSchemeTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ConceptualSchemeType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator ConceptualSchemeType(XElement xe) { return XTypedServices.ToXTypedElement<ConceptualSchemeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ConceptualSchemeType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("Document", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("Authority", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Name, Document, Authority)
        /// </para>
        /// </summary>
        public ConceptualSchemeType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Name, Document, Authority)
        /// </para>
        /// </summary>
        public string Name
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Name, Document, Authority)
        /// </para>
        /// </summary>
        public System.Uri Document
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Document", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Document", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Name, Document, Authority)
        /// </para>
        /// </summary>
        public System.Uri Authority
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Authority", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Authority", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("ConceptualSchemeType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<ConceptualSchemeType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"), typeof(string));
            localElementDictionary.Add(XName.Get("Document", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("Authority", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName ConceptualSchemeTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ConceptualSchemeType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (MinValue, MaxValue)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RangeOfValuesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RangeOfValuesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator RangeOfValuesType(XElement xe) { return XTypedServices.ToXTypedElement<RangeOfValuesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static RangeOfValuesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("MinValue", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("MaxValue", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (MinValue, MaxValue)
        /// </para>
        /// </summary>
        public RangeOfValuesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (MinValue, MaxValue)
        /// </para>
        /// </summary>
        public XTypedElement MinValue
        {
            get
            {
                XElement x=this.GetElement(XName.Get("MinValue", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((XTypedElement)(x));
            }
            set
            {
                this.SetElement(XName.Get("MinValue", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (MinValue, MaxValue)
        /// </para>
        /// </summary>
        public XTypedElement MaxValue
        {
            get
            {
                XElement x=this.GetElement(XName.Get("MaxValue", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((XTypedElement)(x));
            }
            set
            {
                this.SetElement(XName.Get("MaxValue", "http://www.opengis.net/cat/csw/2.0.2"), value);
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
                return XName.Get("RangeOfValuesType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<RangeOfValuesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("MinValue", "http://www.opengis.net/cat/csw/2.0.2"), typeof(XTypedElement));
            localElementDictionary.Add(XName.Get("MaxValue", "http://www.opengis.net/cat/csw/2.0.2"), typeof(XTypedElement));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName RangeOfValuesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RangeOfValuesType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// This is a general acknowledgement response message for all requests 
    ///         that may be processed in an asynchronous manner.
    ///         EchoedRequest - Echoes the submitted request message
    ///         RequestId     - identifier for polling purposes (if no response 
    ///                         handler is available, or the URL scheme is
    ///                         unsupported)
    /// </para>
    /// <para>
    /// Regular expression: (EchoedRequest, RequestId?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AcknowledgementTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class AcknowledgementType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator AcknowledgementType(XElement xe) { return XTypedServices.ToXTypedElement<AcknowledgementType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static AcknowledgementType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("EchoedRequest", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// This is a general acknowledgement response message for all requests 
        ///         that may be processed in an asynchronous manner.
        ///         EchoedRequest - Echoes the submitted request message
        ///         RequestId     - identifier for polling purposes (if no response 
        ///                         handler is available, or the URL scheme is
        ///                         unsupported)
        /// </para>
        /// <para>
        /// Regular expression: (EchoedRequest, RequestId?)
        /// </para>
        /// </summary>
        public AcknowledgementType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (EchoedRequest, RequestId?)
        /// </para>
        /// </summary>
        public EchoedRequestType EchoedRequest
        {
            get
            {
                XElement x=this.GetElement(XName.Get("EchoedRequest", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((EchoedRequestType)(x));
            }
            set
            {
                this.SetElement(XName.Get("EchoedRequest", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (EchoedRequest, RequestId?)
        /// </para>
        /// </summary>
        public System.Uri RequestId
        {
            get
            {
                XElement x=this.GetElement(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.DateTime timeStamp
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("timeStamp", ""));
                return XTypedServices.ParseValue<System.DateTime>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("timeStamp", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
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
                return XName.Get("AcknowledgementType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<AcknowledgementType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("EchoedRequest", "http://www.opengis.net/cat/csw/2.0.2"), typeof(EchoedRequestType));
            localElementDictionary.Add(XName.Get("RequestId", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName AcknowledgementTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AcknowledgementType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Includes a copy of the request message body.
    /// </para>
    /// <para>
    /// Regular expression: (any)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("EchoedRequestTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class EchoedRequestType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator EchoedRequestType(XElement xe) { return XTypedServices.ToXTypedElement<EchoedRequestType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static EchoedRequestType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Includes a copy of the request message body.
        /// </para>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public EchoedRequestType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("EchoedRequestType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<EchoedRequestType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##any", "http://www.opengis.net/cat/csw/2.0.2"), 2)));
            validationStates=new FSM(1, new Set<int>(2), transitions);
        }

        public static XmlQualifiedName EchoedRequestTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("EchoedRequestType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Users may insert, update, or delete catalogue entries. If the 
    ///            verboseResponse attribute has the value "true", then one or more 
    ///            csw:InsertResult elements must be included in the response.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: ((Insert | Update | Delete)+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TransactionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TransactionType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<InsertType> InsertField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<UpdateType> UpdateField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<DeleteType> DeleteField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool verboseResponseDefaultValue=System.Xml.XmlConvert.ToBoolean("false");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator TransactionType(XElement xe) { return XTypedServices.ToXTypedElement<TransactionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TransactionType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// 
        ///            Users may insert, update, or delete catalogue entries. If the 
        ///            verboseResponse attribute has the value "true", then one or more 
        ///            csw:InsertResult elements must be included in the response.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public TransactionType()
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
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<InsertType> Insert
        {
            get
            {
                if ((this.InsertField==null))
                {
                    this.InsertField=new XTypedList<InsertType>(this, LinqToXsdTypeManager.Instance, XName.Get("Insert", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.InsertField;
            }
            set
            {
                if ((value==null))
                {
                    this.InsertField=null;
                } else
                {
                    if ((this.InsertField==null))
                    {
                        this.InsertField=XTypedList<InsertType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Insert", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<InsertType>(this.InsertField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<UpdateType> Update
        {
            get
            {
                if ((this.UpdateField==null))
                {
                    this.UpdateField=new XTypedList<UpdateType>(this, LinqToXsdTypeManager.Instance, XName.Get("Update", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.UpdateField;
            }
            set
            {
                if ((value==null))
                {
                    this.UpdateField=null;
                } else
                {
                    if ((this.UpdateField==null))
                    {
                        this.UpdateField=XTypedList<UpdateType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Update", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<UpdateType>(this.UpdateField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<DeleteType> Delete
        {
            get
            {
                if ((this.DeleteField==null))
                {
                    this.DeleteField=new XTypedList<DeleteType>(this, LinqToXsdTypeManager.Instance, XName.Get("Delete", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.DeleteField;
            }
            set
            {
                if ((value==null))
                {
                    this.DeleteField=null;
                } else
                {
                    if ((this.DeleteField==null))
                    {
                        this.DeleteField=XTypedList<DeleteType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Delete", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<DeleteType>(this.DeleteField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool verboseResponse
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("verboseResponse", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, verboseResponseDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("verboseResponse", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri requestId
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("requestId", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("requestId", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("TransactionType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<TransactionType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Insert", "http://www.opengis.net/cat/csw/2.0.2"), typeof(InsertType));
            localElementDictionary.Add(XName.Get("Update", "http://www.opengis.net/cat/csw/2.0.2"), typeof(UpdateType));
            localElementDictionary.Add(XName.Get("Delete", "http://www.opengis.net/cat/csw/2.0.2"), typeof(DeleteType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName TransactionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TransactionType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Submits one or more records to the catalogue. The representation
    ///            is defined by the application profile. The handle attribute
    ///            may be included to specify a local identifier for the action 
    ///            (it must be unique within the context of the transaction).
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (any)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("InsertTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class InsertType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator InsertType(XElement xe) { return XTypedServices.ToXTypedElement<InsertType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static InsertType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// 
        ///            Submits one or more records to the catalogue. The representation
        ///            is defined by the application profile. The handle attribute
        ///            may be included to specify a local identifier for the action 
        ///            (it must be unique within the context of the transaction).
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public InsertType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri typeName
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("typeName", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("typeName", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string handle
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("handle", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("handle", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("InsertType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<InsertType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 2)));
            transitions.Add(2, new Transitions(new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 2)));
            validationStates=new FSM(1, new Set<int>(2), transitions);
        }

        public static XmlQualifiedName InsertTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("InsertType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Update statements may replace an entire record or only update part 
    ///            of a record:
    ///            1) To replace an existing record, include a new instance of the 
    ///               record;
    ///            2) To update selected properties of an existing record, include
    ///               a set of RecordProperty elements. The scope of the update
    ///               statement  is determined by the Constraint element.
    ///               The 'handle' is a local identifier for the action.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: ((any | (RecordProperty+, Constraint)))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UpdateTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UpdateType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<RecordProperty> RecordPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator UpdateType(XElement xe) { return XTypedServices.ToXTypedElement<UpdateType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UpdateType()
        {
            BuildElementDictionary();
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// 
        ///            Update statements may replace an entire record or only update part 
        ///            of a record:
        ///            1) To replace an existing record, include a new instance of the 
        ///               record;
        ///            2) To update selected properties of an existing record, include
        ///               a set of RecordProperty elements. The scope of the update
        ///               statement  is determined by the Constraint element.
        ///               The 'handle' is a local identifier for the action.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: ((any | (RecordProperty+, Constraint)))
        /// </para>
        /// </summary>
        public UpdateType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((any | (RecordProperty+, Constraint)))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.GetWildCards(WildCard.DefaultWildCard);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((any | (RecordProperty+, Constraint)))
        /// </para>
        /// </summary>
        public IList<RecordProperty> RecordProperty
        {
            get
            {
                if ((this.RecordPropertyField==null))
                {
                    this.RecordPropertyField=new XTypedList<RecordProperty>(this, LinqToXsdTypeManager.Instance, XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.RecordPropertyField;
            }
            set
            {
                if ((value==null))
                {
                    this.RecordPropertyField=null;
                } else
                {
                    if ((this.RecordPropertyField==null))
                    {
                        this.RecordPropertyField=XTypedList<RecordProperty>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<RecordProperty>(this.RecordPropertyField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((any | (RecordProperty+, Constraint)))
        /// </para>
        /// </summary>
        public Constraint Constraint
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((Constraint)(x));
            }
            set
            {
                this.SetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string handle
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("handle", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("handle", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
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
                return XName.Get("UpdateType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<UpdateType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"), typeof(RecordProperty));
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), typeof(Constraint));
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"), 4), new SingleTransition(new WildCard("##other", "http://www.opengis.net/cat/csw/2.0.2"), 2)));
            transitions.Add(4, new Transitions(new SingleTransition(XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2"), 4), new SingleTransition(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), 6)));
            validationStates=new FSM(1, new Set<int>(new int[] {
                            2,
                            6}), transitions);
        }

        public static XmlQualifiedName UpdateTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UpdateType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Deletes one or more catalogue items that satisfy some set of 
    ///            conditions.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (Constraint)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DeleteTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DeleteType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DeleteType(XElement xe) { return XTypedServices.ToXTypedElement<DeleteType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DeleteType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            Deletes one or more catalogue items that satisfy some set of 
        ///            conditions.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (Constraint)
        /// </para>
        /// </summary>
        public DeleteType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Constraint)
        /// </para>
        /// </summary>
        public Constraint Constraint
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((Constraint)(x));
            }
            set
            {
                this.SetElement(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri typeName
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("typeName", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("typeName", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string handle
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("handle", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("handle", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
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
                return XName.Get("DeleteType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<DeleteType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2"), typeof(Constraint));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DeleteTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DeleteType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Name, Value?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RecordPropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RecordPropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator RecordPropertyType(XElement xe) { return XTypedServices.ToXTypedElement<RecordPropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static RecordPropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Name, Value?)
        /// </para>
        /// </summary>
        public RecordPropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// 
        ///                  The Name element contains the name of a property
        ///                  to be updated.  The name may be a path expression.
        ///               
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Name, Value?)
        /// </para>
        /// </summary>
        public string Name
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// 
        ///                  The Value element contains the replacement value for the
        ///                  named property.
        ///               
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Name, Value?)
        /// </para>
        /// </summary>
        public XTypedElement Value
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((XTypedElement)(x));
            }
            set
            {
                this.SetElement(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"), value);
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
                return XName.Get("RecordPropertyType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<RecordPropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Name", "http://www.opengis.net/cat/csw/2.0.2"), typeof(string));
            localElementDictionary.Add(XName.Get("Value", "http://www.opengis.net/cat/csw/2.0.2"), typeof(XTypedElement));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName RecordPropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("RecordPropertyType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            The response for a transaction request that was successfully
    ///            completed. If the transaction failed for any reason, a service 
    ///            exception report indicating a TransactionFailure is returned
    ///            instead.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (TransactionSummary, InsertResult*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TransactionResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TransactionResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<InsertResultType> InsertResultField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TransactionResponseType(XElement xe) { return XTypedServices.ToXTypedElement<TransactionResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TransactionResponseType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("TransactionSummary", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("InsertResult", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            The response for a transaction request that was successfully
        ///            completed. If the transaction failed for any reason, a service 
        ///            exception report indicating a TransactionFailure is returned
        ///            instead.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (TransactionSummary, InsertResult*)
        /// </para>
        /// </summary>
        public TransactionResponseType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (TransactionSummary, InsertResult*)
        /// </para>
        /// </summary>
        public TransactionSummaryType TransactionSummary
        {
            get
            {
                XElement x=this.GetElement(XName.Get("TransactionSummary", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((TransactionSummaryType)(x));
            }
            set
            {
                this.SetElement(XName.Get("TransactionSummary", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (TransactionSummary, InsertResult*)
        /// </para>
        /// </summary>
        public IList<InsertResultType> InsertResult
        {
            get
            {
                if ((this.InsertResultField==null))
                {
                    this.InsertResultField=new XTypedList<InsertResultType>(this, LinqToXsdTypeManager.Instance, XName.Get("InsertResult", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.InsertResultField;
            }
            set
            {
                if ((value==null))
                {
                    this.InsertResultField=null;
                } else
                {
                    if ((this.InsertResultField==null))
                    {
                        this.InsertResultField=XTypedList<InsertResultType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("InsertResult", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<InsertResultType>(this.InsertResultField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
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
                return XName.Get("TransactionResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<TransactionResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("TransactionSummary", "http://www.opengis.net/cat/csw/2.0.2"), typeof(TransactionSummaryType));
            localElementDictionary.Add(XName.Get("InsertResult", "http://www.opengis.net/cat/csw/2.0.2"), typeof(InsertResultType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TransactionResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TransactionResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///         Reports the total number of catalogue items modified by a transaction 
    ///         request (i.e, inserted, updated, deleted). If the client did not 
    ///         specify a requestId, the server may assign one (a URI value).
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (totalInserted?, totalUpdated?, totalDeleted?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TransactionSummaryTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TransactionSummaryType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator TransactionSummaryType(XElement xe) { return XTypedServices.ToXTypedElement<TransactionSummaryType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static TransactionSummaryType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("totalInserted", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("totalUpdated", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("totalDeleted", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///         Reports the total number of catalogue items modified by a transaction 
        ///         request (i.e, inserted, updated, deleted). If the client did not 
        ///         specify a requestId, the server may assign one (a URI value).
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (totalInserted?, totalUpdated?, totalDeleted?)
        /// </para>
        /// </summary>
        public TransactionSummaryType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (totalInserted?, totalUpdated?, totalDeleted?)
        /// </para>
        /// </summary>
        public System.Nullable<decimal> totalInserted
        {
            get
            {
                XElement x=this.GetElement(XName.Get("totalInserted", "http://www.opengis.net/cat/csw/2.0.2"));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("totalInserted", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (totalInserted?, totalUpdated?, totalDeleted?)
        /// </para>
        /// </summary>
        public System.Nullable<decimal> totalUpdated
        {
            get
            {
                XElement x=this.GetElement(XName.Get("totalUpdated", "http://www.opengis.net/cat/csw/2.0.2"));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("totalUpdated", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (totalInserted?, totalUpdated?, totalDeleted?)
        /// </para>
        /// </summary>
        public System.Nullable<decimal> totalDeleted
        {
            get
            {
                XElement x=this.GetElement(XName.Get("totalDeleted", "http://www.opengis.net/cat/csw/2.0.2"));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("totalDeleted", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri requestId
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("requestId", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("requestId", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("TransactionSummaryType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<TransactionSummaryType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("totalInserted", "http://www.opengis.net/cat/csw/2.0.2"), typeof(decimal));
            localElementDictionary.Add(XName.Get("totalUpdated", "http://www.opengis.net/cat/csw/2.0.2"), typeof(decimal));
            localElementDictionary.Add(XName.Get("totalDeleted", "http://www.opengis.net/cat/csw/2.0.2"), typeof(decimal));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName TransactionSummaryTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("TransactionSummaryType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Returns a "brief" view of any newly created catalogue records.
    ///            The handle attribute may reference a particular statement in
    ///            the corresponding transaction request.
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (BriefRecord+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("InsertResultTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class InsertResultType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<BriefRecord> BriefRecordField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator InsertResultType(XElement xe) { return XTypedServices.ToXTypedElement<InsertResultType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static InsertResultType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///            Returns a "brief" view of any newly created catalogue records.
        ///            The handle attribute may reference a particular statement in
        ///            the corresponding transaction request.
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (BriefRecord+)
        /// </para>
        /// </summary>
        public InsertResultType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (BriefRecord+)
        /// </para>
        /// </summary>
        public IList<BriefRecord> BriefRecord
        {
            get
            {
                if ((this.BriefRecordField==null))
                {
                    this.BriefRecordField=new XTypedList<BriefRecord>(this, LinqToXsdTypeManager.Instance, XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.BriefRecordField;
            }
            set
            {
                if ((value==null))
                {
                    this.BriefRecordField=null;
                } else
                {
                    if ((this.BriefRecordField==null))
                    {
                        this.BriefRecordField=XTypedList<BriefRecord>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<BriefRecord>(this.BriefRecordField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri handleRef
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("handleRef", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("handleRef", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
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
                return XName.Get("InsertResultType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<InsertResultType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2"), typeof(BriefRecord));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName InsertResultTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("InsertResultType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///         Requests that the catalogue attempt to harvest a resource from some 
    ///         network location identified by the source URL.
    ///
    ///         Source          - a URL from which the resource is retrieved
    ///         ResourceType    - normally a URI that specifies the type of the resource
    ///                           (DCMES v1.1) being harvested if it is known.
    ///         ResourceFormat  - a media type indicating the format of the 
    ///                           resource being harvested.  The default is 
    ///                           "application/xml".
    ///         ResponseHandler - a reference to some endpoint to which the 
    ///                           response shall be forwarded when the
    ///                           harvest operation has been completed
    ///         HarvestInterval - an interval expressed using the ISO 8601 syntax; 
    ///                           it specifies the interval between harvest 
    ///                           attempts (e.g., P6M indicates an interval of 
    ///                           six months).
    ///         
    /// </para>
    /// <para>
    /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("HarvestTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class HarvestType: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.RequestBaseType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<System.Uri> ResponseHandlerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator HarvestType(XElement xe) { return XTypedServices.ToXTypedElement<HarvestType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static HarvestType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Source", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("ResourceType", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("ResourceFormat", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("HarvestInterval", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// 
        ///         Requests that the catalogue attempt to harvest a resource from some 
        ///         network location identified by the source URL.
        ///
        ///         Source          - a URL from which the resource is retrieved
        ///         ResourceType    - normally a URI that specifies the type of the resource
        ///                           (DCMES v1.1) being harvested if it is known.
        ///         ResourceFormat  - a media type indicating the format of the 
        ///                           resource being harvested.  The default is 
        ///                           "application/xml".
        ///         ResponseHandler - a reference to some endpoint to which the 
        ///                           response shall be forwarded when the
        ///                           harvest operation has been completed
        ///         HarvestInterval - an interval expressed using the ISO 8601 syntax; 
        ///                           it specifies the interval between harvest 
        ///                           attempts (e.g., P6M indicates an interval of 
        ///                           six months).
        ///         
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public HarvestType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public System.Uri Source
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Source", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("Source", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ResourceType", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ResourceType", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public string ResourceFormat
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ResourceFormat", "http://www.opengis.net/cat/csw/2.0.2"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("ResourceFormat", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public System.Nullable<System.TimeSpan> HarvestInterval
        {
            get
            {
                XElement x=this.GetElement(XName.Get("HarvestInterval", "http://www.opengis.net/cat/csw/2.0.2"));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<System.TimeSpan>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Duration).Datatype);
            }
            set
            {
                this.SetElement(XName.Get("HarvestInterval", "http://www.opengis.net/cat/csw/2.0.2"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Duration).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public IList<System.Uri> ResponseHandler
        {
            get
            {
                if ((this.ResponseHandlerField==null))
                {
                    this.ResponseHandlerField=new XSimpleList<System.Uri>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"));
                }
                return this.ResponseHandlerField;
            }
            set
            {
                if ((value==null))
                {
                    this.ResponseHandlerField=null;
                } else
                {
                    if ((this.ResponseHandlerField==null))
                    {
                        this.ResponseHandlerField=XSimpleList<System.Uri>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype, value, XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"));
                    } else
                    {
                        XTypedServices.SetList<System.Uri>(this.ResponseHandlerField, value);
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
                return XName.Get("HarvestType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<HarvestType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Source", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
            localElementDictionary.Add(XName.Get("ResourceType", "http://www.opengis.net/cat/csw/2.0.2"), typeof(string));
            localElementDictionary.Add(XName.Get("ResourceFormat", "http://www.opengis.net/cat/csw/2.0.2"), typeof(string));
            localElementDictionary.Add(XName.Get("HarvestInterval", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.TimeSpan));
            localElementDictionary.Add(XName.Get("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2"), typeof(System.Uri));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName HarvestTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("HarvestType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (Acknowledgement | TransactionResponse)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("HarvestResponseTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class HarvestResponseType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator HarvestResponseType(XElement xe) { return XTypedServices.ToXTypedElement<HarvestResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static HarvestResponseType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new NamedContentModelEntity(XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2")), new NamedContentModelEntity(XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Acknowledgement | TransactionResponse)
        /// </para>
        /// </summary>
        public HarvestResponseType()
        {
        }

        public HarvestResponseType(Acknowledgement Acknowledgement)
        {
            this.Acknowledgement=Acknowledgement;
        }

        public HarvestResponseType(TransactionResponse TransactionResponse)
        {
            this.TransactionResponse=TransactionResponse;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Acknowledgement | TransactionResponse)
        /// </para>
        /// </summary>
        public Acknowledgement Acknowledgement
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((Acknowledgement)(x));
            }
            set
            {
                this.SetElement(XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Acknowledgement | TransactionResponse)
        /// </para>
        /// </summary>
        public TransactionResponse TransactionResponse
        {
            get
            {
                XElement x=this.GetElement(XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2"));
                return ((TransactionResponse)(x));
            }
            set
            {
                this.SetElement(XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2"), value);
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
                return XName.Get("HarvestResponseType", "http://www.opengis.net/cat/csw/2.0.2");
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
            return XTypedServices.CloneXTypedElement<HarvestResponseType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2"), typeof(Acknowledgement));
            localElementDictionary.Add(XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2"), typeof(TransactionResponse));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName HarvestResponseTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("HarvestResponseType", "http://www.opengis.net/cat/csw/2.0.2");
        }
    }

    [XmlSchemaProviderAttribute("AbstractRecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractRecord: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AbstractRecordType ContentField;

        public static explicit operator AbstractRecord(XElement xe) { return (AbstractRecord)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected AbstractRecord(bool setNull)
        {
        }

        public AbstractRecord()
        {
            throw new InvalidOperationException();
        }

        public AbstractRecord(AbstractRecordType content)
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

        public AbstractRecordType Content
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
                return XName.Get("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static AbstractRecord Load(string xmlFile)
        {
            return ((AbstractRecord)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractRecord Load(System.IO.TextReader xmlFile)
        {
            return ((AbstractRecord)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractRecord Parse(string xml)
        {
            return ((AbstractRecord)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(AbstractRecordType ContentField)
        {
            this.ContentField=((AbstractRecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(AbstractRecordType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AbstractRecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type encapsulates all of the standard DCMI metadata terms,
    ///            including the Dublin Core refinements; these terms may be mapped
    ///            to the profile-specific information model.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DCMIRecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DCMIRecord: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecord, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DCMIRecordType ContentField;

        public static explicit operator DCMIRecord(XElement xe) { return XTypedServices.ToXTypedElement<DCMIRecord, DCMIRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            This type encapsulates all of the standard DCMI metadata terms,
        ///            including the Dublin Core refinements; these terms may be mapped
        ///            to the profile-specific information model.
        ///         
        /// </para>
        /// </summary>
        public DCMIRecord() :
            base(true)
        {
            SetInnerType(new DCMIRecordType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type encapsulates all of the standard DCMI metadata terms,
        ///            including the Dublin Core refinements; these terms may be mapped
        ///            to the profile-specific information model.
        ///         
        /// </para>
        /// </summary>
        public DCMIRecord(DCMIRecordType content) :
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

        public new DCMIRecordType Content
        {
            get
            {
                return ContentField;
            }
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
        /// Regular expression: ((DCelement)*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.DCelement> DCelement
        {
            get
            {
                return this.ContentField.DCelement;
            }
            set
            {
                this.ContentField.DCelement=value;
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
                return XName.Get("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2");
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

        public new static DCMIRecord Load(string xmlFile)
        {
            return XTypedServices.Load<DCMIRecord, DCMIRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DCMIRecord Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DCMIRecord, DCMIRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static DCMIRecord Parse(string xml)
        {
            return XTypedServices.Parse<DCMIRecord, DCMIRecordType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new DCMIRecord(((DCMIRecordType)(this.Content.Clone())));
        }

        private void SetInnerType(DCMIRecordType ContentField)
        {
            this.ContentField=((DCMIRecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DCMIRecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type defines a brief representation of the common record
    ///            format.  It extends AbstractRecordType to include only the
    ///             dc:identifier and dc:type properties.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BriefRecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BriefRecord: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecord, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BriefRecordType ContentField;

        public static explicit operator BriefRecord(XElement xe) { return XTypedServices.ToXTypedElement<BriefRecord, BriefRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a brief representation of the common record
        ///            format.  It extends AbstractRecordType to include only the
        ///             dc:identifier and dc:type properties.
        ///         
        /// </para>
        /// </summary>
        public BriefRecord() :
            base(true)
        {
            SetInnerType(new BriefRecordType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a brief representation of the common record
        ///            format.  It extends AbstractRecordType to include only the
        ///             dc:identifier and dc:type properties.
        ///         
        /// </para>
        /// </summary>
        public BriefRecord(BriefRecordType content) :
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

        public new BriefRecordType Content
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
        /// Substitution members: identifier, bibliographicCitation
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.identifier> identifier
        {
            get
            {
                return this.ContentField.identifier;
            }
            set
            {
                this.ContentField.identifier=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: title, alternative
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.title> title
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
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public GeoSik.DublinCore.Elements.V11.type type
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
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                return this.ContentField.BoundingBox;
            }
            set
            {
                this.ContentField.BoundingBox=value;
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
                return XName.Get("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2");
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

        public new static BriefRecord Load(string xmlFile)
        {
            return XTypedServices.Load<BriefRecord, BriefRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static BriefRecord Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<BriefRecord, BriefRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static BriefRecord Parse(string xml)
        {
            return XTypedServices.Parse<BriefRecord, BriefRecordType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new BriefRecord(((BriefRecordType)(this.Content.Clone())));
        }

        private void SetInnerType(BriefRecordType ContentField)
        {
            this.ContentField=((BriefRecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BriefRecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type defines a summary representation of the common record
    ///            format.  It extends AbstractRecordType to include the core
    ///            properties.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SummaryRecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SummaryRecord: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecord, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SummaryRecordType ContentField;

        public static explicit operator SummaryRecord(XElement xe) { return XTypedServices.ToXTypedElement<SummaryRecord, SummaryRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a summary representation of the common record
        ///            format.  It extends AbstractRecordType to include the core
        ///            properties.
        ///         
        /// </para>
        /// </summary>
        public SummaryRecord() :
            base(true)
        {
            SetInnerType(new SummaryRecordType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type defines a summary representation of the common record
        ///            format.  It extends AbstractRecordType to include the core
        ///            properties.
        ///         
        /// </para>
        /// </summary>
        public SummaryRecord(SummaryRecordType content) :
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

        public new SummaryRecordType Content
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
        /// Substitution members: identifier, bibliographicCitation
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.identifier> identifier
        {
            get
            {
                return this.ContentField.identifier;
            }
            set
            {
                this.ContentField.identifier=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: title, alternative
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.title> title
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
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public GeoSik.DublinCore.Elements.V11.type type
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
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.subject> subject
        {
            get
            {
                return this.ContentField.subject;
            }
            set
            {
                this.ContentField.subject=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: format, extent, medium
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.format> format
        {
            get
            {
                return this.ContentField.format;
            }
            set
            {
                this.ContentField.format=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: relation, conformsTo, hasFormat, hasPart, hasVersion, isFormatOf, isPartOf, isReferencedBy, isReplacedBy, isRequiredBy, isVersionOf, references, replaces, requires
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Elements.V11.relation> relation
        {
            get
            {
                return this.ContentField.relation;
            }
            set
            {
                this.ContentField.relation=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.modified> modified
        {
            get
            {
                return this.ContentField.modified;
            }
            set
            {
                this.ContentField.modified=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.@abstract> @abstract
        {
            get
            {
                return this.ContentField.@abstract;
            }
            set
            {
                this.ContentField.@abstract=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.DublinCore.Terms.spatial> spatial
        {
            get
            {
                return this.ContentField.spatial;
            }
            set
            {
                this.ContentField.spatial=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: (identifier+, title+, type?, subject*, format*, relation*, modified*, @abstract*, spatial*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                return this.ContentField.BoundingBox;
            }
            set
            {
                this.ContentField.BoundingBox=value;
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
                return XName.Get("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2");
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

        public new static SummaryRecord Load(string xmlFile)
        {
            return XTypedServices.Load<SummaryRecord, SummaryRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static SummaryRecord Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<SummaryRecord, SummaryRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static SummaryRecord Parse(string xml)
        {
            return XTypedServices.Parse<SummaryRecord, SummaryRecordType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new SummaryRecord(((SummaryRecordType)(this.Content.Clone())));
        }

        private void SetInnerType(SummaryRecordType ContentField)
        {
            this.ContentField=((SummaryRecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType SummaryRecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            This type extends DCMIRecordType to add ows:BoundingBox;
    ///            it may be used to specify a spatial envelope for the
    ///            catalogued resource.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("RecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Record: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractRecord, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RecordType ContentField;

        public static explicit operator Record(XElement xe) { return XTypedServices.ToXTypedElement<Record, RecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            This type extends DCMIRecordType to add ows:BoundingBox;
        ///            it may be used to specify a spatial envelope for the
        ///            catalogued resource.
        ///         
        /// </para>
        /// </summary>
        public Record() :
            base(true)
        {
            SetInnerType(new RecordType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            This type extends DCMIRecordType to add ows:BoundingBox;
        ///            it may be used to specify a spatial envelope for the
        ///            catalogued resource.
        ///         
        /// </para>
        /// </summary>
        public Record(RecordType content) :
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

        public new RecordType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<EmptyType> AnyText
        {
            get
            {
                return this.ContentField.AnyText;
            }
            set
            {
                this.ContentField.AnyText=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: BoundingBox, WGS84BoundingBox
        /// </para>
        /// <para>
        /// Regular expression: ((DCelement)*, AnyText*, BoundingBox*)
        /// </para>
        /// </summary>
        public IList<GeoSik.Ogc.Ows.V100.Types.BoundingBox> BoundingBox
        {
            get
            {
                return this.ContentField.BoundingBox;
            }
            set
            {
                this.ContentField.BoundingBox=value;
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
                return XName.Get("Record", "http://www.opengis.net/cat/csw/2.0.2");
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

        public new static Record Load(string xmlFile)
        {
            return XTypedServices.Load<Record, RecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Record Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Record, RecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Record Parse(string xml)
        {
            return XTypedServices.Parse<Record, RecordType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Record(((RecordType)(this.Content.Clone())));
        }

        private void SetInnerType(RecordType ContentField)
        {
            this.ContentField=((RecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Record", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Request for a description of service capabilities. See OGC 05-008 
    ///            for more information.
    ///         
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
        /// 
        ///            Request for a description of service capabilities. See OGC 05-008 
        ///            for more information.
        ///         
        /// </para>
        /// </summary>
        public GetCapabilities()
        {
            SetInnerType(new GetCapabilitiesType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            Request for a description of service capabilities. See OGC 05-008 
        ///            for more information.
        ///         
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
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string service
        {
            get
            {
                return this.ContentField.service;
            }
            set
            {
                this.ContentField.service=value;
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
                return XName.Get("GetCapabilities", "http://www.opengis.net/cat/csw/2.0.2");
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
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetCapabilities", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This type extends ows:CapabilitiesBaseType defined in OGC-05-008 
    ///         to include information about supported OGC filter components. A 
    ///         profile may extend this type to describe additional capabilities.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("CapabilitiesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Capabilities: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CapabilitiesType ContentField;

        public static explicit operator Capabilities(XElement xe) { return XTypedServices.ToXTypedElement<Capabilities, CapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This type extends ows:CapabilitiesBaseType defined in OGC-05-008 
        ///         to include information about supported OGC filter components. A 
        ///         profile may extend this type to describe additional capabilities.
        /// </para>
        /// </summary>
        public Capabilities()
        {
            SetInnerType(new CapabilitiesType());
        }

        /// <summary>
        /// <para>
        /// This type extends ows:CapabilitiesBaseType defined in OGC-05-008 
        ///         to include information about supported OGC filter components. A 
        ///         profile may extend this type to describe additional capabilities.
        /// </para>
        /// </summary>
        public Capabilities(CapabilitiesType content)
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

        public CapabilitiesType Content
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
        /// Regular expression: (ServiceIdentification?, ServiceProvider?, OperationsMetadata?, Filter_Capabilities)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.Filter_Capabilities Filter_Capabilities
        {
            get
            {
                return this.ContentField.Filter_Capabilities;
            }
            set
            {
                this.ContentField.Filter_Capabilities=value;
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
                return XName.Get("Capabilities", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static Capabilities Load(string xmlFile)
        {
            return XTypedServices.Load<Capabilities, CapabilitiesType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Capabilities Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Capabilities, CapabilitiesType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Capabilities Parse(string xml)
        {
            return XTypedServices.Parse<Capabilities, CapabilitiesType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Capabilities(((CapabilitiesType)(this.Content.Clone())));
        }

        private void SetInnerType(CapabilitiesType ContentField)
        {
            this.ContentField=((CapabilitiesType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType CapabilitiesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Capabilities", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This request allows a user to discover elements of the
    ///         information model supported by the catalogue. If no TypeName 
    ///         elements are included, then all of the schemas for the 
    ///         information model must be returned.
    ///      
    ///         schemaLanguage - preferred schema language
    ///                          (W3C XML Schema by default)
    ///         outputFormat - preferred output format (application/xml by default)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DescribeRecordSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DescribeRecord: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DescribeRecordType ContentField;

        public static explicit operator DescribeRecord(XElement xe) { return XTypedServices.ToXTypedElement<DescribeRecord, DescribeRecordType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This request allows a user to discover elements of the
        ///         information model supported by the catalogue. If no TypeName 
        ///         elements are included, then all of the schemas for the 
        ///         information model must be returned.
        ///      
        ///         schemaLanguage - preferred schema language
        ///                          (W3C XML Schema by default)
        ///         outputFormat - preferred output format (application/xml by default)
        /// </para>
        /// </summary>
        public DescribeRecord()
        {
            SetInnerType(new DescribeRecordType());
        }

        /// <summary>
        /// <para>
        /// This request allows a user to discover elements of the
        ///         information model supported by the catalogue. If no TypeName 
        ///         elements are included, then all of the schemas for the 
        ///         information model must be returned.
        ///      
        ///         schemaLanguage - preferred schema language
        ///                          (W3C XML Schema by default)
        ///         outputFormat - preferred output format (application/xml by default)
        /// </para>
        /// </summary>
        public DescribeRecord(DescribeRecordType content)
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

        public DescribeRecordType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (TypeName*)
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> TypeName
        {
            get
            {
                return this.ContentField.TypeName;
            }
            set
            {
                this.ContentField.TypeName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                return this.ContentField.outputFormat;
            }
            set
            {
                this.ContentField.outputFormat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri schemaLanguage
        {
            get
            {
                return this.ContentField.schemaLanguage;
            }
            set
            {
                this.ContentField.schemaLanguage=value;
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
                return XName.Get("DescribeRecord", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static DescribeRecord Load(string xmlFile)
        {
            return XTypedServices.Load<DescribeRecord, DescribeRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DescribeRecord Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DescribeRecord, DescribeRecordType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DescribeRecord Parse(string xml)
        {
            return XTypedServices.Parse<DescribeRecord, DescribeRecordType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new DescribeRecord(((DescribeRecordType)(this.Content.Clone())));
        }

        private void SetInnerType(DescribeRecordType ContentField)
        {
            this.ContentField=((DescribeRecordType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DescribeRecordSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DescribeRecord", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// The response contains a list of matching schema components
    ///         in the requested schema language.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DescribeRecordResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DescribeRecordResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DescribeRecordResponseType ContentField;

        public static explicit operator DescribeRecordResponse(XElement xe) { return XTypedServices.ToXTypedElement<DescribeRecordResponse, DescribeRecordResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// The response contains a list of matching schema components
        ///         in the requested schema language.
        /// </para>
        /// </summary>
        public DescribeRecordResponse()
        {
            SetInnerType(new DescribeRecordResponseType());
        }

        /// <summary>
        /// <para>
        /// The response contains a list of matching schema components
        ///         in the requested schema language.
        /// </para>
        /// </summary>
        public DescribeRecordResponse(DescribeRecordResponseType content)
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

        public DescribeRecordResponseType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (SchemaComponent*)
        /// </para>
        /// </summary>
        public IList<SchemaComponentType> SchemaComponent
        {
            get
            {
                return this.ContentField.SchemaComponent;
            }
            set
            {
                this.ContentField.SchemaComponent=value;
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
                return XName.Get("DescribeRecordResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static DescribeRecordResponse Load(string xmlFile)
        {
            return XTypedServices.Load<DescribeRecordResponse, DescribeRecordResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DescribeRecordResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DescribeRecordResponse, DescribeRecordResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DescribeRecordResponse Parse(string xml)
        {
            return XTypedServices.Parse<DescribeRecordResponse, DescribeRecordResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new DescribeRecordResponse(((DescribeRecordResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(DescribeRecordResponseType ContentField)
        {
            this.ContentField=((DescribeRecordResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DescribeRecordResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DescribeRecordResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///         The principal means of searching the catalogue. The matching 
    ///         catalogue entries may be included with the response. The client 
    ///         may assign a requestId (absolute URI). A distributed search is 
    ///         performed if the DistributedSearch element is present and the 
    ///         catalogue is a member of a federation. Profiles may allow 
    ///         alternative query expressions.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecords: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetRecordsType ContentField;

        public static explicit operator GetRecords(XElement xe) { return XTypedServices.ToXTypedElement<GetRecords, GetRecordsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///         The principal means of searching the catalogue. The matching 
        ///         catalogue entries may be included with the response. The client 
        ///         may assign a requestId (absolute URI). A distributed search is 
        ///         performed if the DistributedSearch element is present and the 
        ///         catalogue is a member of a federation. Profiles may allow 
        ///         alternative query expressions.
        /// </para>
        /// </summary>
        public GetRecords()
        {
            SetInnerType(new GetRecordsType());
        }

        /// <summary>
        /// <para>
        /// 
        ///         The principal means of searching the catalogue. The matching 
        ///         catalogue entries may be included with the response. The client 
        ///         may assign a requestId (absolute URI). A distributed search is 
        ///         performed if the DistributedSearch element is present and the 
        ///         catalogue is a member of a federation. Profiles may allow 
        ///         alternative query expressions.
        /// </para>
        /// </summary>
        public GetRecords(GetRecordsType content)
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

        public GetRecordsType Content
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
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public DistributedSearchType DistributedSearch
        {
            get
            {
                return this.ContentField.DistributedSearch;
            }
            set
            {
                this.ContentField.DistributedSearch=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public IList<System.Uri> ResponseHandler
        {
            get
            {
                return this.ContentField.ResponseHandler;
            }
            set
            {
                this.ContentField.ResponseHandler=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: AbstractQuery, Query
        /// </para>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public AbstractQuery AbstractQuery
        {
            get
            {
                return this.ContentField.AbstractQuery;
            }
            set
            {
                this.ContentField.AbstractQuery=value;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (DistributedSearch?, ResponseHandler*, (AbstractQuery | any))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.ContentField.Any;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri requestId
        {
            get
            {
                return this.ContentField.requestId;
            }
            set
            {
                this.ContentField.requestId=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string resultType
        {
            get
            {
                return this.ContentField.resultType;
            }
            set
            {
                this.ContentField.resultType=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                return this.ContentField.outputFormat;
            }
            set
            {
                this.ContentField.outputFormat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri outputSchema
        {
            get
            {
                return this.ContentField.outputSchema;
            }
            set
            {
                this.ContentField.outputSchema=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public decimal startPosition
        {
            get
            {
                return this.ContentField.startPosition;
            }
            set
            {
                this.ContentField.startPosition=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public decimal maxRecords
        {
            get
            {
                return this.ContentField.maxRecords;
            }
            set
            {
                this.ContentField.maxRecords=value;
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
                return XName.Get("GetRecords", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetRecords Load(string xmlFile)
        {
            return XTypedServices.Load<GetRecords, GetRecordsType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecords Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetRecords, GetRecordsType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecords Parse(string xml)
        {
            return XTypedServices.Parse<GetRecords, GetRecordsType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetRecords(((GetRecordsType)(this.Content.Clone())));
        }

        private void SetInnerType(GetRecordsType ContentField)
        {
            this.ContentField=((GetRecordsType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetRecordsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetRecords", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AbstractQuerySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractQuery: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AbstractQueryType ContentField;

        public static explicit operator AbstractQuery(XElement xe) { return (AbstractQuery)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected AbstractQuery(bool setNull)
        {
        }

        public AbstractQuery()
        {
            throw new InvalidOperationException();
        }

        public AbstractQuery(AbstractQueryType content)
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

        public AbstractQueryType Content
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
                return XName.Get("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static AbstractQuery Load(string xmlFile)
        {
            return ((AbstractQuery)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractQuery Load(System.IO.TextReader xmlFile)
        {
            return ((AbstractQuery)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static AbstractQuery Parse(string xml)
        {
            return ((AbstractQuery)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(AbstractQueryType ContentField)
        {
            this.ContentField=((AbstractQueryType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(AbstractQueryType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AbstractQuerySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("AbstractQuery", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Specifies a query to execute against instances of one or
    ///         more object types. A set of ElementName elements may be included 
    ///         to specify an adhoc view of the csw:Record instances in the result 
    ///         set. Otherwise, use ElementSetName to specify a predefined view. 
    ///         The Constraint element contains a query filter expressed in a 
    ///         supported query language. A sorting criterion that specifies a 
    ///         property to sort by may be included.
    ///
    ///         typeNames - a list of object types to query.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("QuerySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Query: global::GeoSik.Ogc.WebCatalog.Csw.V202.Types.AbstractQuery, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private QueryType ContentField;

        public static explicit operator Query(XElement xe) { return XTypedServices.ToXTypedElement<Query, QueryType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Specifies a query to execute against instances of one or
        ///         more object types. A set of ElementName elements may be included 
        ///         to specify an adhoc view of the csw:Record instances in the result 
        ///         set. Otherwise, use ElementSetName to specify a predefined view. 
        ///         The Constraint element contains a query filter expressed in a 
        ///         supported query language. A sorting criterion that specifies a 
        ///         property to sort by may be included.
        ///
        ///         typeNames - a list of object types to query.
        /// </para>
        /// </summary>
        public Query() :
            base(true)
        {
            SetInnerType(new QueryType());
        }

        /// <summary>
        /// <para>
        /// Specifies a query to execute against instances of one or
        ///         more object types. A set of ElementName elements may be included 
        ///         to specify an adhoc view of the csw:Record instances in the result 
        ///         set. Otherwise, use ElementSetName to specify a predefined view. 
        ///         The Constraint element contains a query filter expressed in a 
        ///         supported query language. A sorting criterion that specifies a 
        ///         property to sort by may be included.
        ///
        ///         typeNames - a list of object types to query.
        /// </para>
        /// </summary>
        public Query(QueryType content) :
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

        public new QueryType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public ElementSetName ElementSetName
        {
            get
            {
                return this.ContentField.ElementSetName;
            }
            set
            {
                this.ContentField.ElementSetName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> ElementName
        {
            get
            {
                return this.ContentField.ElementName;
            }
            set
            {
                this.ContentField.ElementName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public Constraint Constraint
        {
            get
            {
                return this.ContentField.Constraint;
            }
            set
            {
                this.ContentField.Constraint=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: ((ElementSetName | ElementName+), Constraint?, SortBy?)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.SortBy SortBy
        {
            get
            {
                return this.ContentField.SortBy;
            }
            set
            {
                this.ContentField.SortBy=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public IList<System.Xml.XmlQualifiedName> typeNames
        {
            get
            {
                return this.ContentField.typeNames;
            }
            set
            {
                this.ContentField.typeNames=value;
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
                return XName.Get("Query", "http://www.opengis.net/cat/csw/2.0.2");
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

        public new static Query Load(string xmlFile)
        {
            return XTypedServices.Load<Query, QueryType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Query Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Query, QueryType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Query Parse(string xml)
        {
            return XTypedServices.Parse<Query, QueryType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Query(((QueryType)(this.Content.Clone())));
        }

        private void SetInnerType(QueryType ContentField)
        {
            this.ContentField=((QueryType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType QuerySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Query", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// A search constraint that adheres to one of the following syntaxes:
    ///         Filter   - OGC filter expression
    ///         CqlText  - OGC CQL predicate
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ConstraintSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Constraint: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private QueryConstraintType ContentField;

        public static explicit operator Constraint(XElement xe) { return XTypedServices.ToXTypedElement<Constraint, QueryConstraintType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// A search constraint that adheres to one of the following syntaxes:
        ///         Filter   - OGC filter expression
        ///         CqlText  - OGC CQL predicate
        /// </para>
        /// </summary>
        public Constraint()
        {
            SetInnerType(new QueryConstraintType());
        }

        /// <summary>
        /// <para>
        /// A search constraint that adheres to one of the following syntaxes:
        ///         Filter   - OGC filter expression
        ///         CqlText  - OGC CQL predicate
        /// </para>
        /// </summary>
        public Constraint(QueryConstraintType content)
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

        public QueryConstraintType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Filter | CqlText)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Filter.V110.Filter Filter
        {
            get
            {
                return this.ContentField.Filter;
            }
            set
            {
                this.ContentField.Filter=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Filter | CqlText)
        /// </para>
        /// </summary>
        public string CqlText
        {
            get
            {
                return this.ContentField.CqlText;
            }
            set
            {
                this.ContentField.CqlText=value;
            }
        }

        /// <summary>
        /// <para>
        /// Query language version
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string version
        {
            get
            {
                return this.ContentField.version;
            }
            set
            {
                this.ContentField.version=value;
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
                return XName.Get("Constraint", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static Constraint Load(string xmlFile)
        {
            return XTypedServices.Load<Constraint, QueryConstraintType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Constraint Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Constraint, QueryConstraintType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Constraint Parse(string xml)
        {
            return XTypedServices.Parse<Constraint, QueryConstraintType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Constraint(((QueryConstraintType)(this.Content.Clone())));
        }

        private void SetInnerType(QueryConstraintType ContentField)
        {
            this.ContentField=((QueryConstraintType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ConstraintSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Constraint", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("ElementSetNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ElementSetName: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ElementSetNameType ContentField;

        public static explicit operator ElementSetName(XElement xe) { return XTypedServices.ToXTypedElement<ElementSetName, ElementSetNameType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ElementSetName()
        {
            SetInnerType(new ElementSetNameType());
        }

        public ElementSetName(ElementSetNameType content)
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

        public ElementSetNameType Content
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
        public IList<System.Xml.XmlQualifiedName> typeNames
        {
            get
            {
                return this.ContentField.typeNames;
            }
            set
            {
                this.ContentField.typeNames=value;
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
                return XName.Get("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static ElementSetName Load(string xmlFile)
        {
            return XTypedServices.Load<ElementSetName, ElementSetNameType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static ElementSetName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<ElementSetName, ElementSetNameType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static ElementSetName Parse(string xml)
        {
            return XTypedServices.Parse<ElementSetName, ElementSetNameType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new ElementSetName(((ElementSetNameType)(this.Content.Clone())));
        }

        private void SetInnerType(ElementSetNameType ContentField)
        {
            this.ContentField=((ElementSetNameType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ElementSetNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            The response message for a GetRecords request. Some or all of the 
    ///            matching records may be included as children of the SearchResults 
    ///            element. The RequestId is only included if the client specified it.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordsResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordsResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetRecordsResponseType ContentField;

        public static explicit operator GetRecordsResponse(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordsResponse, GetRecordsResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            The response message for a GetRecords request. Some or all of the 
        ///            matching records may be included as children of the SearchResults 
        ///            element. The RequestId is only included if the client specified it.
        ///         
        /// </para>
        /// </summary>
        public GetRecordsResponse()
        {
            SetInnerType(new GetRecordsResponseType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            The response message for a GetRecords request. Some or all of the 
        ///            matching records may be included as children of the SearchResults 
        ///            element. The RequestId is only included if the client specified it.
        ///         
        /// </para>
        /// </summary>
        public GetRecordsResponse(GetRecordsResponseType content)
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

        public GetRecordsResponseType Content
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
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public System.Uri RequestId
        {
            get
            {
                return this.ContentField.RequestId;
            }
            set
            {
                this.ContentField.RequestId=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public RequestStatusType SearchStatus
        {
            get
            {
                return this.ContentField.SearchStatus;
            }
            set
            {
                this.ContentField.SearchStatus=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (RequestId?, SearchStatus, SearchResults)
        /// </para>
        /// </summary>
        public SearchResultsType SearchResults
        {
            get
            {
                return this.ContentField.SearchResults;
            }
            set
            {
                this.ContentField.SearchResults=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string version
        {
            get
            {
                return this.ContentField.version;
            }
            set
            {
                this.ContentField.version=value;
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
                return XName.Get("GetRecordsResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetRecordsResponse Load(string xmlFile)
        {
            return XTypedServices.Load<GetRecordsResponse, GetRecordsResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordsResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetRecordsResponse, GetRecordsResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordsResponse Parse(string xml)
        {
            return XTypedServices.Parse<GetRecordsResponse, GetRecordsResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetRecordsResponse(((GetRecordsResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(GetRecordsResponseType ContentField)
        {
            this.ContentField=((GetRecordsResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetRecordsResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetRecordsResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Convenience operation to retrieve default record representations 
    ///            by identifier.
    ///            Id - object identifier (a URI) that provides a reference to a 
    ///                 catalogue item (or a result set if the catalogue supports 
    ///                 persistent result sets).
    ///            ElementSetName - one of "brief, "summary", or "full"
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordByIdSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordById: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetRecordByIdType ContentField;

        public static explicit operator GetRecordById(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordById, GetRecordByIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            Convenience operation to retrieve default record representations 
        ///            by identifier.
        ///            Id - object identifier (a URI) that provides a reference to a 
        ///                 catalogue item (or a result set if the catalogue supports 
        ///                 persistent result sets).
        ///            ElementSetName - one of "brief, "summary", or "full"
        ///         
        /// </para>
        /// </summary>
        public GetRecordById()
        {
            SetInnerType(new GetRecordByIdType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            Convenience operation to retrieve default record representations 
        ///            by identifier.
        ///            Id - object identifier (a URI) that provides a reference to a 
        ///                 catalogue item (or a result set if the catalogue supports 
        ///                 persistent result sets).
        ///            ElementSetName - one of "brief, "summary", or "full"
        ///         
        /// </para>
        /// </summary>
        public GetRecordById(GetRecordByIdType content)
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

        public GetRecordByIdType Content
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
        /// Regular expression: (Id+, ElementSetName?)
        /// </para>
        /// </summary>
        public IList<System.Uri> Id
        {
            get
            {
                return this.ContentField.Id;
            }
            set
            {
                this.ContentField.Id=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Id+, ElementSetName?)
        /// </para>
        /// </summary>
        public ElementSetName ElementSetName
        {
            get
            {
                return this.ContentField.ElementSetName;
            }
            set
            {
                this.ContentField.ElementSetName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string outputFormat
        {
            get
            {
                return this.ContentField.outputFormat;
            }
            set
            {
                this.ContentField.outputFormat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri outputSchema
        {
            get
            {
                return this.ContentField.outputSchema;
            }
            set
            {
                this.ContentField.outputSchema=value;
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
                return XName.Get("GetRecordById", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetRecordById Load(string xmlFile)
        {
            return XTypedServices.Load<GetRecordById, GetRecordByIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordById Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetRecordById, GetRecordByIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordById Parse(string xml)
        {
            return XTypedServices.Parse<GetRecordById, GetRecordByIdType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetRecordById(((GetRecordByIdType)(this.Content.Clone())));
        }

        private void SetInnerType(GetRecordByIdType ContentField)
        {
            this.ContentField=((GetRecordByIdType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetRecordByIdSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetRecordById", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Returns a representation of the matching entry. If there is no 
    ///         matching record, the response message must be empty.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetRecordByIdResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetRecordByIdResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetRecordByIdResponseType ContentField;

        public static explicit operator GetRecordByIdResponse(XElement xe) { return XTypedServices.ToXTypedElement<GetRecordByIdResponse, GetRecordByIdResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Returns a representation of the matching entry. If there is no 
        ///         matching record, the response message must be empty.
        /// </para>
        /// </summary>
        public GetRecordByIdResponse()
        {
            SetInnerType(new GetRecordByIdResponseType());
        }

        /// <summary>
        /// <para>
        /// Returns a representation of the matching entry. If there is no 
        ///         matching record, the response message must be empty.
        /// </para>
        /// </summary>
        public GetRecordByIdResponse(GetRecordByIdResponseType content)
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

        public GetRecordByIdResponseType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Substitution members: AbstractRecord, DCMIRecord, BriefRecord, SummaryRecord, Record
        /// </para>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IList<AbstractRecord> AbstractRecord
        {
            get
            {
                return this.ContentField.AbstractRecord;
            }
            set
            {
                this.ContentField.AbstractRecord=value;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((AbstractRecord* | any))
        /// </para>
        /// </summary>
        public IEnumerable<XElement> Any
        {
            get
            {
                return this.ContentField.Any;
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
                return XName.Get("GetRecordByIdResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetRecordByIdResponse Load(string xmlFile)
        {
            return XTypedServices.Load<GetRecordByIdResponse, GetRecordByIdResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordByIdResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetRecordByIdResponse, GetRecordByIdResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetRecordByIdResponse Parse(string xml)
        {
            return XTypedServices.Parse<GetRecordByIdResponse, GetRecordByIdResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetRecordByIdResponse(((GetRecordByIdResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(GetRecordByIdResponseType ContentField)
        {
            this.ContentField=((GetRecordByIdResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetRecordByIdResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetRecordByIdResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Requests the actual values of some specified request parameter 
    ///        or other data element.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetDomainSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetDomain: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetDomainType ContentField;

        public static explicit operator GetDomain(XElement xe) { return XTypedServices.ToXTypedElement<GetDomain, GetDomainType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Requests the actual values of some specified request parameter 
        ///        or other data element.
        /// </para>
        /// </summary>
        public GetDomain()
        {
            SetInnerType(new GetDomainType());
        }

        /// <summary>
        /// <para>
        /// Requests the actual values of some specified request parameter 
        ///        or other data element.
        /// </para>
        /// </summary>
        public GetDomain(GetDomainType content)
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

        public GetDomainType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName))
        /// </para>
        /// </summary>
        public System.Uri PropertyName
        {
            get
            {
                return this.ContentField.PropertyName;
            }
            set
            {
                this.ContentField.PropertyName=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((PropertyName | ParameterName))
        /// </para>
        /// </summary>
        public System.Uri ParameterName
        {
            get
            {
                return this.ContentField.ParameterName;
            }
            set
            {
                this.ContentField.ParameterName=value;
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
                return XName.Get("GetDomain", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetDomain Load(string xmlFile)
        {
            return XTypedServices.Load<GetDomain, GetDomainType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetDomain Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetDomain, GetDomainType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetDomain Parse(string xml)
        {
            return XTypedServices.Parse<GetDomain, GetDomainType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetDomain(((GetDomainType)(this.Content.Clone())));
        }

        private void SetInnerType(GetDomainType ContentField)
        {
            this.ContentField=((GetDomainType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetDomainSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetDomain", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Returns the actual values for some property. In general this is a
    ///         subset of the value domain (that is, set of permissible values),
    ///         although in some cases these may be the same.
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GetDomainResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GetDomainResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GetDomainResponseType ContentField;

        public static explicit operator GetDomainResponse(XElement xe) { return XTypedServices.ToXTypedElement<GetDomainResponse, GetDomainResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// Returns the actual values for some property. In general this is a
        ///         subset of the value domain (that is, set of permissible values),
        ///         although in some cases these may be the same.
        /// </para>
        /// </summary>
        public GetDomainResponse()
        {
            SetInnerType(new GetDomainResponseType());
        }

        /// <summary>
        /// <para>
        /// Returns the actual values for some property. In general this is a
        ///         subset of the value domain (that is, set of permissible values),
        ///         although in some cases these may be the same.
        /// </para>
        /// </summary>
        public GetDomainResponse(GetDomainResponseType content)
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

        public GetDomainResponseType Content
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
        /// Regular expression: (DomainValues+)
        /// </para>
        /// </summary>
        public IList<DomainValuesType> DomainValues
        {
            get
            {
                return this.ContentField.DomainValues;
            }
            set
            {
                this.ContentField.DomainValues=value;
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
                return XName.Get("GetDomainResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static GetDomainResponse Load(string xmlFile)
        {
            return XTypedServices.Load<GetDomainResponse, GetDomainResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetDomainResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GetDomainResponse, GetDomainResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GetDomainResponse Parse(string xml)
        {
            return XTypedServices.Parse<GetDomainResponse, GetDomainResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GetDomainResponse(((GetDomainResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(GetDomainResponseType ContentField)
        {
            this.ContentField=((GetDomainResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GetDomainResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GetDomainResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// This is a general acknowledgement response message for all requests 
    ///         that may be processed in an asynchronous manner.
    ///         EchoedRequest - Echoes the submitted request message
    ///         RequestId     - identifier for polling purposes (if no response 
    ///                         handler is available, or the URL scheme is
    ///                         unsupported)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("AcknowledgementSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Acknowledgement: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AcknowledgementType ContentField;

        public static explicit operator Acknowledgement(XElement xe) { return XTypedServices.ToXTypedElement<Acknowledgement, AcknowledgementType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// This is a general acknowledgement response message for all requests 
        ///         that may be processed in an asynchronous manner.
        ///         EchoedRequest - Echoes the submitted request message
        ///         RequestId     - identifier for polling purposes (if no response 
        ///                         handler is available, or the URL scheme is
        ///                         unsupported)
        /// </para>
        /// </summary>
        public Acknowledgement()
        {
            SetInnerType(new AcknowledgementType());
        }

        /// <summary>
        /// <para>
        /// This is a general acknowledgement response message for all requests 
        ///         that may be processed in an asynchronous manner.
        ///         EchoedRequest - Echoes the submitted request message
        ///         RequestId     - identifier for polling purposes (if no response 
        ///                         handler is available, or the URL scheme is
        ///                         unsupported)
        /// </para>
        /// </summary>
        public Acknowledgement(AcknowledgementType content)
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

        public AcknowledgementType Content
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
        /// Regular expression: (EchoedRequest, RequestId?)
        /// </para>
        /// </summary>
        public EchoedRequestType EchoedRequest
        {
            get
            {
                return this.ContentField.EchoedRequest;
            }
            set
            {
                this.ContentField.EchoedRequest=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (EchoedRequest, RequestId?)
        /// </para>
        /// </summary>
        public System.Uri RequestId
        {
            get
            {
                return this.ContentField.RequestId;
            }
            set
            {
                this.ContentField.RequestId=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.DateTime timeStamp
        {
            get
            {
                return this.ContentField.timeStamp;
            }
            set
            {
                this.ContentField.timeStamp=value;
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
                return XName.Get("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static Acknowledgement Load(string xmlFile)
        {
            return XTypedServices.Load<Acknowledgement, AcknowledgementType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Acknowledgement Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Acknowledgement, AcknowledgementType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Acknowledgement Parse(string xml)
        {
            return XTypedServices.Parse<Acknowledgement, AcknowledgementType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Acknowledgement(((AcknowledgementType)(this.Content.Clone())));
        }

        private void SetInnerType(AcknowledgementType ContentField)
        {
            this.ContentField=((AcknowledgementType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AcknowledgementSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Acknowledgement", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            Users may insert, update, or delete catalogue entries. If the 
    ///            verboseResponse attribute has the value "true", then one or more 
    ///            csw:InsertResult elements must be included in the response.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TransactionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Transaction: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TransactionType ContentField;

        public static explicit operator Transaction(XElement xe) { return XTypedServices.ToXTypedElement<Transaction, TransactionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            Users may insert, update, or delete catalogue entries. If the 
        ///            verboseResponse attribute has the value "true", then one or more 
        ///            csw:InsertResult elements must be included in the response.
        ///         
        /// </para>
        /// </summary>
        public Transaction()
        {
            SetInnerType(new TransactionType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            Users may insert, update, or delete catalogue entries. If the 
        ///            verboseResponse attribute has the value "true", then one or more 
        ///            csw:InsertResult elements must be included in the response.
        ///         
        /// </para>
        /// </summary>
        public Transaction(TransactionType content)
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

        public TransactionType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<InsertType> Insert
        {
            get
            {
                return this.ContentField.Insert;
            }
            set
            {
                this.ContentField.Insert=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<UpdateType> Update
        {
            get
            {
                return this.ContentField.Update;
            }
            set
            {
                this.ContentField.Update=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Setter: Appends
        /// </para>
        /// <para>
        /// Regular expression: ((Insert | Update | Delete)+)
        /// </para>
        /// </summary>
        public IList<DeleteType> Delete
        {
            get
            {
                return this.ContentField.Delete;
            }
            set
            {
                this.ContentField.Delete=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool verboseResponse
        {
            get
            {
                return this.ContentField.verboseResponse;
            }
            set
            {
                this.ContentField.verboseResponse=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri requestId
        {
            get
            {
                return this.ContentField.requestId;
            }
            set
            {
                this.ContentField.requestId=value;
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
                return XName.Get("Transaction", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static Transaction Load(string xmlFile)
        {
            return XTypedServices.Load<Transaction, TransactionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Transaction Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Transaction, TransactionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Transaction Parse(string xml)
        {
            return XTypedServices.Parse<Transaction, TransactionType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Transaction(((TransactionType)(this.Content.Clone())));
        }

        private void SetInnerType(TransactionType ContentField)
        {
            this.ContentField=((TransactionType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TransactionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Transaction", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("RecordPropertySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class RecordProperty: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RecordPropertyType ContentField;

        public static explicit operator RecordProperty(XElement xe) { return XTypedServices.ToXTypedElement<RecordProperty, RecordPropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public RecordProperty()
        {
            SetInnerType(new RecordPropertyType());
        }

        public RecordProperty(RecordPropertyType content)
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

        public RecordPropertyType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// 
        ///                  The Name element contains the name of a property
        ///                  to be updated.  The name may be a path expression.
        ///               
        /// </para>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Name, Value?)
        /// </para>
        /// </summary>
        public string Name
        {
            get
            {
                return this.ContentField.Name;
            }
            set
            {
                this.ContentField.Name=value;
            }
        }

        /// <summary>
        /// <para>
        /// 
        ///                  The Value element contains the replacement value for the
        ///                  named property.
        ///               
        /// </para>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Name, Value?)
        /// </para>
        /// </summary>
        public XTypedElement Value
        {
            get
            {
                return this.ContentField.Value;
            }
            set
            {
                this.ContentField.Value=value;
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
                return XName.Get("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static RecordProperty Load(string xmlFile)
        {
            return XTypedServices.Load<RecordProperty, RecordPropertyType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static RecordProperty Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<RecordProperty, RecordPropertyType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static RecordProperty Parse(string xml)
        {
            return XTypedServices.Parse<RecordProperty, RecordPropertyType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new RecordProperty(((RecordPropertyType)(this.Content.Clone())));
        }

        private void SetInnerType(RecordPropertyType ContentField)
        {
            this.ContentField=((RecordPropertyType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType RecordPropertySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("RecordProperty", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///            The response for a transaction request that was successfully
    ///            completed. If the transaction failed for any reason, a service 
    ///            exception report indicating a TransactionFailure is returned
    ///            instead.
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("TransactionResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class TransactionResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TransactionResponseType ContentField;

        public static explicit operator TransactionResponse(XElement xe) { return XTypedServices.ToXTypedElement<TransactionResponse, TransactionResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///            The response for a transaction request that was successfully
        ///            completed. If the transaction failed for any reason, a service 
        ///            exception report indicating a TransactionFailure is returned
        ///            instead.
        ///         
        /// </para>
        /// </summary>
        public TransactionResponse()
        {
            SetInnerType(new TransactionResponseType());
        }

        /// <summary>
        /// <para>
        /// 
        ///            The response for a transaction request that was successfully
        ///            completed. If the transaction failed for any reason, a service 
        ///            exception report indicating a TransactionFailure is returned
        ///            instead.
        ///         
        /// </para>
        /// </summary>
        public TransactionResponse(TransactionResponseType content)
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

        public TransactionResponseType Content
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
        /// Regular expression: (TransactionSummary, InsertResult*)
        /// </para>
        /// </summary>
        public TransactionSummaryType TransactionSummary
        {
            get
            {
                return this.ContentField.TransactionSummary;
            }
            set
            {
                this.ContentField.TransactionSummary=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (TransactionSummary, InsertResult*)
        /// </para>
        /// </summary>
        public IList<InsertResultType> InsertResult
        {
            get
            {
                return this.ContentField.InsertResult;
            }
            set
            {
                this.ContentField.InsertResult=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string version
        {
            get
            {
                return this.ContentField.version;
            }
            set
            {
                this.ContentField.version=value;
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
                return XName.Get("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static TransactionResponse Load(string xmlFile)
        {
            return XTypedServices.Load<TransactionResponse, TransactionResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static TransactionResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<TransactionResponse, TransactionResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static TransactionResponse Parse(string xml)
        {
            return XTypedServices.Parse<TransactionResponse, TransactionResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new TransactionResponse(((TransactionResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(TransactionResponseType ContentField)
        {
            this.ContentField=((TransactionResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TransactionResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("TransactionResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    /// <summary>
    /// <para>
    /// 
    ///         Requests that the catalogue attempt to harvest a resource from some 
    ///         network location identified by the source URL.
    ///
    ///         Source          - a URL from which the resource is retrieved
    ///         ResourceType    - normally a URI that specifies the type of the resource
    ///                           (DCMES v1.1) being harvested if it is known.
    ///         ResourceFormat  - a media type indicating the format of the 
    ///                           resource being harvested.  The default is 
    ///                           "application/xml".
    ///         ResponseHandler - a reference to some endpoint to which the 
    ///                           response shall be forwarded when the
    ///                           harvest operation has been completed
    ///         HarvestInterval - an interval expressed using the ISO 8601 syntax; 
    ///                           it specifies the interval between harvest 
    ///                           attempts (e.g., P6M indicates an interval of 
    ///                           six months).
    ///         
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("HarvestSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Harvest: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HarvestType ContentField;

        public static explicit operator Harvest(XElement xe) { return XTypedServices.ToXTypedElement<Harvest, HarvestType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        /// <summary>
        /// <para>
        /// 
        ///         Requests that the catalogue attempt to harvest a resource from some 
        ///         network location identified by the source URL.
        ///
        ///         Source          - a URL from which the resource is retrieved
        ///         ResourceType    - normally a URI that specifies the type of the resource
        ///                           (DCMES v1.1) being harvested if it is known.
        ///         ResourceFormat  - a media type indicating the format of the 
        ///                           resource being harvested.  The default is 
        ///                           "application/xml".
        ///         ResponseHandler - a reference to some endpoint to which the 
        ///                           response shall be forwarded when the
        ///                           harvest operation has been completed
        ///         HarvestInterval - an interval expressed using the ISO 8601 syntax; 
        ///                           it specifies the interval between harvest 
        ///                           attempts (e.g., P6M indicates an interval of 
        ///                           six months).
        ///         
        /// </para>
        /// </summary>
        public Harvest()
        {
            SetInnerType(new HarvestType());
        }

        /// <summary>
        /// <para>
        /// 
        ///         Requests that the catalogue attempt to harvest a resource from some 
        ///         network location identified by the source URL.
        ///
        ///         Source          - a URL from which the resource is retrieved
        ///         ResourceType    - normally a URI that specifies the type of the resource
        ///                           (DCMES v1.1) being harvested if it is known.
        ///         ResourceFormat  - a media type indicating the format of the 
        ///                           resource being harvested.  The default is 
        ///                           "application/xml".
        ///         ResponseHandler - a reference to some endpoint to which the 
        ///                           response shall be forwarded when the
        ///                           harvest operation has been completed
        ///         HarvestInterval - an interval expressed using the ISO 8601 syntax; 
        ///                           it specifies the interval between harvest 
        ///                           attempts (e.g., P6M indicates an interval of 
        ///                           six months).
        ///         
        /// </para>
        /// </summary>
        public Harvest(HarvestType content)
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

        public HarvestType Content
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
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public System.Uri Source
        {
            get
            {
                return this.ContentField.Source;
            }
            set
            {
                this.ContentField.Source=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get
            {
                return this.ContentField.ResourceType;
            }
            set
            {
                this.ContentField.ResourceType=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public string ResourceFormat
        {
            get
            {
                return this.ContentField.ResourceFormat;
            }
            set
            {
                this.ContentField.ResourceFormat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public System.Nullable<System.TimeSpan> HarvestInterval
        {
            get
            {
                return this.ContentField.HarvestInterval;
            }
            set
            {
                this.ContentField.HarvestInterval=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (Source, ResourceType, ResourceFormat?, HarvestInterval?, ResponseHandler*)
        /// </para>
        /// </summary>
        public IList<System.Uri> ResponseHandler
        {
            get
            {
                return this.ContentField.ResponseHandler;
            }
            set
            {
                this.ContentField.ResponseHandler=value;
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
                return XName.Get("Harvest", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static Harvest Load(string xmlFile)
        {
            return XTypedServices.Load<Harvest, HarvestType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Harvest Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Harvest, HarvestType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Harvest Parse(string xml)
        {
            return XTypedServices.Parse<Harvest, HarvestType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Harvest(((HarvestType)(this.Content.Clone())));
        }

        private void SetInnerType(HarvestType ContentField)
        {
            this.ContentField=((HarvestType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType HarvestSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Harvest", "http://www.opengis.net/cat/csw/2.0.2")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("HarvestResponseSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class HarvestResponse: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HarvestResponseType ContentField;

        public static explicit operator HarvestResponse(XElement xe) { return XTypedServices.ToXTypedElement<HarvestResponse, HarvestResponseType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public HarvestResponse()
        {
            SetInnerType(new HarvestResponseType());
        }

        public HarvestResponse(HarvestResponseType content)
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

        public HarvestResponseType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Acknowledgement | TransactionResponse)
        /// </para>
        /// </summary>
        public Acknowledgement Acknowledgement
        {
            get
            {
                return this.ContentField.Acknowledgement;
            }
            set
            {
                this.ContentField.Acknowledgement=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (Acknowledgement | TransactionResponse)
        /// </para>
        /// </summary>
        public TransactionResponse TransactionResponse
        {
            get
            {
                return this.ContentField.TransactionResponse;
            }
            set
            {
                this.ContentField.TransactionResponse=value;
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
                return XName.Get("HarvestResponse", "http://www.opengis.net/cat/csw/2.0.2");
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

        public static HarvestResponse Load(string xmlFile)
        {
            return XTypedServices.Load<HarvestResponse, HarvestResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static HarvestResponse Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<HarvestResponse, HarvestResponseType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static HarvestResponse Parse(string xml)
        {
            return XTypedServices.Parse<HarvestResponse, HarvestResponseType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new HarvestResponse(((HarvestResponseType)(this.Content.Clone())));
        }

        private void SetInnerType(HarvestResponseType ContentField)
        {
            this.ContentField=((HarvestResponseType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType HarvestResponseSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("HarvestResponse", "http://www.opengis.net/cat/csw/2.0.2")]));
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


        public AbstractRecord AbstractRecord { get { return rootObject as AbstractRecord; } }

        public DCMIRecord DCMIRecord { get { return rootObject as DCMIRecord; } }

        public BriefRecord BriefRecord { get { return rootObject as BriefRecord; } }

        public SummaryRecord SummaryRecord { get { return rootObject as SummaryRecord; } }

        public Record Record { get { return rootObject as Record; } }

        public GetCapabilities GetCapabilities { get { return rootObject as GetCapabilities; } }

        public Capabilities Capabilities { get { return rootObject as Capabilities; } }

        public DescribeRecord DescribeRecord { get { return rootObject as DescribeRecord; } }

        public DescribeRecordResponse DescribeRecordResponse { get { return rootObject as DescribeRecordResponse; } }

        public GetRecords GetRecords { get { return rootObject as GetRecords; } }

        public AbstractQuery AbstractQuery { get { return rootObject as AbstractQuery; } }

        public Query Query { get { return rootObject as Query; } }

        public Constraint Constraint { get { return rootObject as Constraint; } }

        public ElementSetName ElementSetName { get { return rootObject as ElementSetName; } }

        public GetRecordsResponse GetRecordsResponse { get { return rootObject as GetRecordsResponse; } }

        public GetRecordById GetRecordById { get { return rootObject as GetRecordById; } }

        public GetRecordByIdResponse GetRecordByIdResponse { get { return rootObject as GetRecordByIdResponse; } }

        public GetDomain GetDomain { get { return rootObject as GetDomain; } }

        public GetDomainResponse GetDomainResponse { get { return rootObject as GetDomainResponse; } }

        public Acknowledgement Acknowledgement { get { return rootObject as Acknowledgement; } }

        public Transaction Transaction { get { return rootObject as Transaction; } }

        public RecordProperty RecordProperty { get { return rootObject as RecordProperty; } }

        public TransactionResponse TransactionResponse { get { return rootObject as TransactionResponse; } }

        public Harvest Harvest { get { return rootObject as Harvest; } }

        public HarvestResponse HarvestResponse { get { return rootObject as HarvestResponse; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(AbstractRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DCMIRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(BriefRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(SummaryRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Record root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetCapabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Capabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DescribeRecord root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DescribeRecordResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetRecords root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(AbstractQuery root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Query root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Constraint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(ElementSetName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetRecordsResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetRecordById root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetRecordByIdResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetDomain root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GetDomainResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Acknowledgement root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Transaction root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(RecordProperty root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(TransactionResponse root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Harvest root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(HarvestResponse root)
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
#pragma warning restore 108, 114, 1591, 3002, 3003, 3005, 3009
