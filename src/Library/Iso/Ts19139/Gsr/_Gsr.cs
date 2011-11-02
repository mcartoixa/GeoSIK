#pragma warning disable 3002, 3009
namespace OgcToolkit.Iso.Ts19139.Gsr
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
    /// Regular expression: (AbstractCRS)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SC_CRS_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SC_CRS_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SC_CRS_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SC_CRS_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SC_CRS_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("AbstractCRS", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSingleCRS", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeneralDerivedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("CompoundCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeodeticCRS", "http://www.opengis.net/gml/3.2"), XName.Get("VerticalCRS", "http://www.opengis.net/gml/3.2"), XName.Get("ProjectedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("EngineeringCRS", "http://www.opengis.net/gml/3.2"), XName.Get("ImageCRS", "http://www.opengis.net/gml/3.2"), XName.Get("TemporalCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeographicCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeocentricCRS", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (AbstractCRS)?
        /// </para>
        /// </summary>
        public SC_CRS_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: AbstractCRS, AbstractSingleCRS, AbstractGeneralDerivedCRS, CompoundCRS, GeodeticCRS, VerticalCRS, ProjectedCRS, DerivedCRS, EngineeringCRS, ImageCRS, TemporalCRS, GeographicCRS, GeocentricCRS
        /// </para>
        /// <para>
        /// Regular expression: (AbstractCRS)?
        /// </para>
        /// </summary>
        public OgcToolkit.Ogc.Gml.V321.AbstractCRS AbstractCRS
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractCRS", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSingleCRS", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeneralDerivedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("CompoundCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeodeticCRS", "http://www.opengis.net/gml/3.2"), XName.Get("VerticalCRS", "http://www.opengis.net/gml/3.2"), XName.Get("ProjectedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("DerivedCRS", "http://www.opengis.net/gml/3.2"), XName.Get("EngineeringCRS", "http://www.opengis.net/gml/3.2"), XName.Get("ImageCRS", "http://www.opengis.net/gml/3.2"), XName.Get("TemporalCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeographicCRS", "http://www.opengis.net/gml/3.2"), XName.Get("GeocentricCRS", "http://www.opengis.net/gml/3.2"));
                return ((OgcToolkit.Ogc.Gml.V321.AbstractCRS)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractCRS", "http://www.opengis.net/gml/3.2"), value);
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
                return XName.Get("SC_CRS_PropertyType", "http://www.isotc211.org/2005/gsr");
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
            return XTypedServices.CloneXTypedElement<SC_CRS_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractCRS", "http://www.opengis.net/gml/3.2"), typeof(OgcToolkit.Ogc.Gml.V321.AbstractCRS));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SC_CRS_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SC_CRS_PropertyType", "http://www.isotc211.org/2005/gsr");
        }
    }
}
#pragma warning restore 3002, 3009
