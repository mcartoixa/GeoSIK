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

#pragma warning disable 1591, 3002, 3009
namespace GeoSik.Iso.Ts19139.Gss
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
    /// Regular expression: (Point)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GM_Point_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GM_Point_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GM_Point_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<GM_Point_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GM_Point_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Point", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Point)?
        /// </para>
        /// </summary>
        public GM_Point_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Point)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.Point Point
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Point", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.Point)(x));
            }
            set
            {
                this.SetElement(XName.Get("Point", "http://www.opengis.net/gml/3.2"), value);
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
                return XName.Get("GM_Point_PropertyType", "http://www.isotc211.org/2005/gss");
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
            return XTypedServices.CloneXTypedElement<GM_Point_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Point", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.Point));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GM_Point_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GM_Point_PropertyType", "http://www.isotc211.org/2005/gss");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (AbstractGeometry)?
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GM_Object_PropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GM_Object_PropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string typeFixedValue="simple";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GM_Object_PropertyType(XElement xe) { return XTypedServices.ToXTypedElement<GM_Object_PropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GM_Object_PropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("AbstractGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeometricPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("Point", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractCurve", "http://www.opengis.net/gml/3.2"), XName.Get("LineString", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSurface", "http://www.opengis.net/gml/3.2"), XName.Get("Polygon", "http://www.opengis.net/gml/3.2"), XName.Get("Curve", "http://www.opengis.net/gml/3.2"), XName.Get("OrientableCurve", "http://www.opengis.net/gml/3.2"), XName.Get("Surface", "http://www.opengis.net/gml/3.2"), XName.Get("OrientableSurface", "http://www.opengis.net/gml/3.2"), XName.Get("PolyhedralSurface", "http://www.opengis.net/gml/3.2"), XName.Get("TriangulatedSurface", "http://www.opengis.net/gml/3.2"), XName.Get("Tin", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSolid", "http://www.opengis.net/gml/3.2"), XName.Get("Solid", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeometricAggregate", "http://www.opengis.net/gml/3.2"), XName.Get("MultiGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("MultiPoint", "http://www.opengis.net/gml/3.2"), XName.Get("MultiCurve", "http://www.opengis.net/gml/3.2"), XName.Get("MultiSurface", "http://www.opengis.net/gml/3.2"), XName.Get("MultiSolid", "http://www.opengis.net/gml/3.2"), XName.Get("GeometricComplex", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeCurve", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeSurface", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeSolid", "http://www.opengis.net/gml/3.2"), XName.Get("Grid", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractImplicitGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("RectifiedGrid", "http://www.opengis.net/gml/3.2")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (AbstractGeometry)?
        /// </para>
        /// </summary>
        public GM_Object_PropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: AbstractGeometry, AbstractGeometricPrimitive, Point, AbstractCurve, LineString, AbstractSurface, Polygon, Curve, OrientableCurve, Surface, OrientableSurface, PolyhedralSurface, TriangulatedSurface, Tin, AbstractSolid, Solid, AbstractGeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, GeometricComplex, CompositeCurve, CompositeSurface, CompositeSolid, Grid, AbstractImplicitGeometry, RectifiedGrid
        /// </para>
        /// <para>
        /// Regular expression: (AbstractGeometry)?
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V321.AbstractGeometry AbstractGeometry
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("AbstractGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeometricPrimitive", "http://www.opengis.net/gml/3.2"), XName.Get("Point", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractCurve", "http://www.opengis.net/gml/3.2"), XName.Get("LineString", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSurface", "http://www.opengis.net/gml/3.2"), XName.Get("Polygon", "http://www.opengis.net/gml/3.2"), XName.Get("Curve", "http://www.opengis.net/gml/3.2"), XName.Get("OrientableCurve", "http://www.opengis.net/gml/3.2"), XName.Get("Surface", "http://www.opengis.net/gml/3.2"), XName.Get("OrientableSurface", "http://www.opengis.net/gml/3.2"), XName.Get("PolyhedralSurface", "http://www.opengis.net/gml/3.2"), XName.Get("TriangulatedSurface", "http://www.opengis.net/gml/3.2"), XName.Get("Tin", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractSolid", "http://www.opengis.net/gml/3.2"), XName.Get("Solid", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractGeometricAggregate", "http://www.opengis.net/gml/3.2"), XName.Get("MultiGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("MultiPoint", "http://www.opengis.net/gml/3.2"), XName.Get("MultiCurve", "http://www.opengis.net/gml/3.2"), XName.Get("MultiSurface", "http://www.opengis.net/gml/3.2"), XName.Get("MultiSolid", "http://www.opengis.net/gml/3.2"), XName.Get("GeometricComplex", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeCurve", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeSurface", "http://www.opengis.net/gml/3.2"), XName.Get("CompositeSolid", "http://www.opengis.net/gml/3.2"), XName.Get("Grid", "http://www.opengis.net/gml/3.2"), XName.Get("AbstractImplicitGeometry", "http://www.opengis.net/gml/3.2"), XName.Get("RectifiedGrid", "http://www.opengis.net/gml/3.2"));
                return ((GeoSik.Ogc.Gml.V321.AbstractGeometry)(x));
            }
            set
            {
                this.SetElement(XName.Get("AbstractGeometry", "http://www.opengis.net/gml/3.2"), value);
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
                return XName.Get("GM_Object_PropertyType", "http://www.isotc211.org/2005/gss");
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
            return XTypedServices.CloneXTypedElement<GM_Object_PropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("AbstractGeometry", "http://www.opengis.net/gml/3.2"), typeof(GeoSik.Ogc.Gml.V321.AbstractGeometry));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GM_Object_PropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GM_Object_PropertyType", "http://www.isotc211.org/2005/gss");
        }
    }
}
#pragma warning restore 1591, 3002, 3009
