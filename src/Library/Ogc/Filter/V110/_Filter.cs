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

#pragma warning disable 108, 114, 3002, 3003, 3008, 3009
namespace GeoSik.Ogc.Filter.V110
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
    /// Regular expression: (Spatial_Capabilities, Scalar_Capabilities, Id_Capabilities)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Filter_CapabilitiesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Filter_Capabilities: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Filter_Capabilities(XElement xe) { return XTypedServices.ToXTypedElement<Filter_Capabilities>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Filter_Capabilities()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("Spatial_Capabilities", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("Scalar_Capabilities", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("Id_Capabilities", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (Spatial_Capabilities, Scalar_Capabilities, Id_Capabilities)
        /// </para>
        /// </summary>
        public Filter_Capabilities()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Spatial_Capabilities, Scalar_Capabilities, Id_Capabilities)
        /// </para>
        /// </summary>
        public Spatial_CapabilitiesType Spatial_Capabilities
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Spatial_Capabilities", "http://www.opengis.net/ogc"));
                return ((Spatial_CapabilitiesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Spatial_Capabilities", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Spatial_Capabilities, Scalar_Capabilities, Id_Capabilities)
        /// </para>
        /// </summary>
        public Scalar_CapabilitiesType Scalar_Capabilities
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Scalar_Capabilities", "http://www.opengis.net/ogc"));
                return ((Scalar_CapabilitiesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Scalar_Capabilities", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (Spatial_Capabilities, Scalar_Capabilities, Id_Capabilities)
        /// </para>
        /// </summary>
        public Id_CapabilitiesType Id_Capabilities
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Id_Capabilities", "http://www.opengis.net/ogc"));
                return ((Id_CapabilitiesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Id_Capabilities", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("Filter_Capabilities", "http://www.opengis.net/ogc");
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

        public static Filter_Capabilities Load(string xmlFile)
        {
            return XTypedServices.Load<Filter_Capabilities>(xmlFile);
        }

        public static Filter_Capabilities Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Filter_Capabilities>(xmlFile);
        }

        public static Filter_Capabilities Parse(string xml)
        {
            return XTypedServices.Parse<Filter_Capabilities>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<Filter_Capabilities>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("Spatial_Capabilities", "http://www.opengis.net/ogc"), typeof(Spatial_CapabilitiesType));
            localElementDictionary.Add(XName.Get("Scalar_Capabilities", "http://www.opengis.net/ogc"), typeof(Scalar_CapabilitiesType));
            localElementDictionary.Add(XName.Get("Id_Capabilities", "http://www.opengis.net/ogc"), typeof(Id_CapabilitiesType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlSchemaType Filter_CapabilitiesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Filter_Capabilities", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("LogicalOperatorsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class LogicalOperators: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator LogicalOperators(XElement xe) { return XTypedServices.ToXTypedElement<LogicalOperators>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public LogicalOperators()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("LogicalOperators", "http://www.opengis.net/ogc");
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

        public static LogicalOperators Load(string xmlFile)
        {
            return XTypedServices.Load<LogicalOperators>(xmlFile);
        }

        public static LogicalOperators Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<LogicalOperators>(xmlFile);
        }

        public static LogicalOperators Parse(string xml)
        {
            return XTypedServices.Parse<LogicalOperators>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<LogicalOperators>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType LogicalOperatorsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("LogicalOperators", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("SimpleArithmeticSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SimpleArithmetic: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator SimpleArithmetic(XElement xe) { return XTypedServices.ToXTypedElement<SimpleArithmetic>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public SimpleArithmetic()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SimpleArithmetic", "http://www.opengis.net/ogc");
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

        public static SimpleArithmetic Load(string xmlFile)
        {
            return XTypedServices.Load<SimpleArithmetic>(xmlFile);
        }

        public static SimpleArithmetic Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<SimpleArithmetic>(xmlFile);
        }

        public static SimpleArithmetic Parse(string xml)
        {
            return XTypedServices.Parse<SimpleArithmetic>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<SimpleArithmetic>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType SimpleArithmeticSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SimpleArithmetic", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("EIDSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class EID: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator EID(XElement xe) { return XTypedServices.ToXTypedElement<EID>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public EID()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("EID", "http://www.opengis.net/ogc");
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

        public static EID Load(string xmlFile)
        {
            return XTypedServices.Load<EID>(xmlFile);
        }

        public static EID Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<EID>(xmlFile);
        }

        public static EID Parse(string xml)
        {
            return XTypedServices.Parse<EID>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<EID>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType EIDSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("EID", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("FIDSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FID: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator FID(XElement xe) { return XTypedServices.ToXTypedElement<FID>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public FID()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("FID", "http://www.opengis.net/ogc");
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

        public static FID Load(string xmlFile)
        {
            return XTypedServices.Load<FID>(xmlFile);
        }

        public static FID Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<FID>(xmlFile);
        }

        public static FID Parse(string xml)
        {
            return XTypedServices.Parse<FID>(xml);
        }

        public override XTypedElement Clone()
        {
            return XTypedServices.CloneXTypedElement<FID>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType FIDSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("FID", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("ExpressionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class ExpressionType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator ExpressionType(XElement xe) { return (ExpressionType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ExpressionType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ExpressionType", "http://www.opengis.net/ogc");
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

        public static XmlQualifiedName ExpressionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ExpressionType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BinaryOperatorTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BinaryOperatorType: global::GeoSik.Ogc.Filter.V110.ExpressionType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<expression> expressionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator BinaryOperatorType(XElement xe) { return XTypedServices.ToXTypedElement<BinaryOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BinaryOperatorType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public BinaryOperatorType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                if ((this.expressionField==null))
                {
                    this.expressionField=new XTypedSubstitutedList<expression>(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                }
                return this.expressionField;
            }
            set
            {
                if ((value==null))
                {
                    this.expressionField=null;
                } else
                {
                    if ((this.expressionField==null))
                    {
                        this.expressionField=XTypedSubstitutedList<expression>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<expression>(this.expressionField, value);
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
                return XName.Get("BinaryOperatorType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<BinaryOperatorType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName BinaryOperatorTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BinaryOperatorType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression*)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("FunctionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FunctionType: global::GeoSik.Ogc.Filter.V110.ExpressionType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<expression> expressionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator FunctionType(XElement xe) { return XTypedServices.ToXTypedElement<FunctionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static FunctionType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression*)
        /// </para>
        /// </summary>
        public FunctionType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression*)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                if ((this.expressionField==null))
                {
                    this.expressionField=new XTypedSubstitutedList<expression>(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                }
                return this.expressionField;
            }
            set
            {
                if ((value==null))
                {
                    this.expressionField=null;
                } else
                {
                    if ((this.expressionField==null))
                    {
                        this.expressionField=XTypedSubstitutedList<expression>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<expression>(this.expressionField, value);
                    }
                }
            }
        }

        /// <summary>
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
                return XName.Get("FunctionType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FunctionType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName FunctionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FunctionType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (any)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("LiteralTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class LiteralType: global::GeoSik.Ogc.Filter.V110.ExpressionType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator LiteralType(XElement xe) { return XTypedServices.ToXTypedElement<LiteralType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static LiteralType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)
        /// </para>
        /// </summary>
        public LiteralType()
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
                return XName.Get("LiteralType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<LiteralType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##any", "http://www.opengis.net/ogc"), 2)));
            validationStates=new FSM(1, new Set<int>(new int[] {
                            2,
                            1}), transitions);
        }

        public static XmlQualifiedName LiteralTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("LiteralType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("PropertyNameTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyNameType: global::GeoSik.Ogc.Filter.V110.ExpressionType, IXMetaData, IXmlSerializable
    {

        public static explicit operator PropertyNameType(XElement xe) { return XTypedServices.ToXTypedElement<PropertyNameType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyNameType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("PropertyNameType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<PropertyNameType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName PropertyNameTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("PropertyNameType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (SortProperty+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SortByTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SortByType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SortPropertyType> SortPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SortByType(XElement xe) { return XTypedServices.ToXTypedElement<SortByType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SortByType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SortProperty", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (SortProperty+)
        /// </para>
        /// </summary>
        public SortByType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (SortProperty+)
        /// </para>
        /// </summary>
        public IList<SortPropertyType> SortProperty
        {
            get
            {
                if ((this.SortPropertyField==null))
                {
                    this.SortPropertyField=new XTypedList<SortPropertyType>(this, LinqToXsdTypeManager.Instance, XName.Get("SortProperty", "http://www.opengis.net/ogc"));
                }
                return this.SortPropertyField;
            }
            set
            {
                if ((value==null))
                {
                    this.SortPropertyField=null;
                } else
                {
                    if ((this.SortPropertyField==null))
                    {
                        this.SortPropertyField=XTypedList<SortPropertyType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("SortProperty", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<SortPropertyType>(this.SortPropertyField, value);
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
                return XName.Get("SortByType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<SortByType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("SortProperty", "http://www.opengis.net/ogc"), typeof(SortPropertyType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SortByTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SortByType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName, SortOrder?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SortPropertyTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SortPropertyType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SortPropertyType(XElement xe) { return XTypedServices.ToXTypedElement<SortPropertyType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SortPropertyType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("PropertyName", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("SortOrder", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName, SortOrder?)
        /// </para>
        /// </summary>
        public SortPropertyType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, SortOrder?)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                return ((PropertyName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, SortOrder?)
        /// </para>
        /// </summary>
        public string SortOrder
        {
            get
            {
                XElement x=this.GetElement(XName.Get("SortOrder", "http://www.opengis.net/ogc"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetElementWithValidation(XName.Get("SortOrder", "http://www.opengis.net/ogc"), value, "SortOrder", global::GeoSik.Ogc.Filter.V110.SortOrderType.TypeDefinition);
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
                return XName.Get("SortPropertyType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<SortPropertyType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
            localElementDictionary.Add(XName.Get("SortOrder", "http://www.opengis.net/ogc"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SortPropertyTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SortPropertyType", "http://www.opengis.net/ogc");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class SortOrderType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "DESC",
                        "ASC"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private SortOrderType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (GeometryOperands, SpatialOperators)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Spatial_CapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Spatial_CapabilitiesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Spatial_CapabilitiesType(XElement xe) { return XTypedServices.ToXTypedElement<Spatial_CapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Spatial_CapabilitiesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("GeometryOperands", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("SpatialOperators", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (GeometryOperands, SpatialOperators)
        /// </para>
        /// </summary>
        public Spatial_CapabilitiesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (GeometryOperands, SpatialOperators)
        /// </para>
        /// </summary>
        public GeometryOperandsType GeometryOperands
        {
            get
            {
                XElement x=this.GetElement(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"));
                return ((GeometryOperandsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (GeometryOperands, SpatialOperators)
        /// </para>
        /// </summary>
        public SpatialOperatorsType SpatialOperators
        {
            get
            {
                XElement x=this.GetElement(XName.Get("SpatialOperators", "http://www.opengis.net/ogc"));
                return ((SpatialOperatorsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("SpatialOperators", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("Spatial_CapabilitiesType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<Spatial_CapabilitiesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"), typeof(GeometryOperandsType));
            localElementDictionary.Add(XName.Get("SpatialOperators", "http://www.opengis.net/ogc"), typeof(SpatialOperatorsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Spatial_CapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Spatial_CapabilitiesType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (GeometryOperand+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("GeometryOperandsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GeometryOperandsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> GeometryOperandField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator GeometryOperandsType(XElement xe) { return XTypedServices.ToXTypedElement<GeometryOperandsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static GeometryOperandsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("GeometryOperand", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (GeometryOperand+)
        /// </para>
        /// </summary>
        public GeometryOperandsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (GeometryOperand+)
        /// </para>
        /// </summary>
        public IList<string> GeometryOperand
        {
            get
            {
                if ((this.GeometryOperandField==null))
                {
                    this.GeometryOperandField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("GeometryOperand", "http://www.opengis.net/ogc"));
                }
                return this.GeometryOperandField;
            }
            set
            {
                if ((value==null))
                {
                    this.GeometryOperandField=null;
                } else
                {
                    if ((this.GeometryOperandField==null))
                    {
                        this.GeometryOperandField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("GeometryOperand", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.GeometryOperandField, value);
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
                return XName.Get("GeometryOperandsType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<GeometryOperandsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("GeometryOperand", "http://www.opengis.net/ogc"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName GeometryOperandsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GeometryOperandsType", "http://www.opengis.net/ogc");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class GeometryOperandType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "gml:Envelope",
                        "gml:Point",
                        "gml:LineString",
                        "gml:Polygon",
                        "gml:ArcByCenterPoint",
                        "gml:CircleByCenterPoint",
                        "gml:Arc",
                        "gml:Circle",
                        "gml:ArcByBulge",
                        "gml:Bezier",
                        "gml:Clothoid",
                        "gml:CubicSpline",
                        "gml:Geodesic",
                        "gml:OffsetCurve",
                        "gml:Triangle",
                        "gml:PolyhedralSurface",
                        "gml:TriangulatedSurface",
                        "gml:Tin",
                        "gml:Solid"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private GeometryOperandType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (SpatialOperator+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SpatialOperatorsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SpatialOperatorsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SpatialOperatorType> SpatialOperatorField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SpatialOperatorsType(XElement xe) { return XTypedServices.ToXTypedElement<SpatialOperatorsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SpatialOperatorsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("SpatialOperator", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (SpatialOperator+)
        /// </para>
        /// </summary>
        public SpatialOperatorsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Regular expression: (SpatialOperator+)
        /// </para>
        /// </summary>
        public IList<SpatialOperatorType> SpatialOperator
        {
            get
            {
                if ((this.SpatialOperatorField==null))
                {
                    this.SpatialOperatorField=new XTypedList<SpatialOperatorType>(this, LinqToXsdTypeManager.Instance, XName.Get("SpatialOperator", "http://www.opengis.net/ogc"));
                }
                return this.SpatialOperatorField;
            }
            set
            {
                if ((value==null))
                {
                    this.SpatialOperatorField=null;
                } else
                {
                    if ((this.SpatialOperatorField==null))
                    {
                        this.SpatialOperatorField=XTypedList<SpatialOperatorType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("SpatialOperator", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<SpatialOperatorType>(this.SpatialOperatorField, value);
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
                return XName.Get("SpatialOperatorsType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<SpatialOperatorsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("SpatialOperator", "http://www.opengis.net/ogc"), typeof(SpatialOperatorType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SpatialOperatorsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SpatialOperatorsType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (GeometryOperands?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("SpatialOperatorTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SpatialOperatorType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator SpatialOperatorType(XElement xe) { return XTypedServices.ToXTypedElement<SpatialOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static SpatialOperatorType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("GeometryOperands", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (GeometryOperands?)
        /// </para>
        /// </summary>
        public SpatialOperatorType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (GeometryOperands?)
        /// </para>
        /// </summary>
        public GeometryOperandsType GeometryOperands
        {
            get
            {
                XElement x=this.GetElement(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"));
                return ((GeometryOperandsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
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
                return XName.Get("SpatialOperatorType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<SpatialOperatorType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("GeometryOperands", "http://www.opengis.net/ogc"), typeof(GeometryOperandsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName SpatialOperatorTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SpatialOperatorType", "http://www.opengis.net/ogc");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class SpatialOperatorNameType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "BBOX",
                        "Equals",
                        "Disjoint",
                        "Intersects",
                        "Touches",
                        "Crosses",
                        "Within",
                        "Contains",
                        "Overlaps",
                        "Beyond",
                        "DWithin"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private SpatialOperatorNameType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (LogicalOperators?, ComparisonOperators?, ArithmeticOperators?)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Scalar_CapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Scalar_CapabilitiesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator Scalar_CapabilitiesType(XElement xe) { return XTypedServices.ToXTypedElement<Scalar_CapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Scalar_CapabilitiesType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("LogicalOperators", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("ComparisonOperators", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("ArithmeticOperators", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (LogicalOperators?, ComparisonOperators?, ArithmeticOperators?)
        /// </para>
        /// </summary>
        public Scalar_CapabilitiesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (LogicalOperators?, ComparisonOperators?, ArithmeticOperators?)
        /// </para>
        /// </summary>
        public LogicalOperators LogicalOperators
        {
            get
            {
                XElement x=this.GetElement(XName.Get("LogicalOperators", "http://www.opengis.net/ogc"));
                return ((LogicalOperators)(x));
            }
            set
            {
                this.SetElement(XName.Get("LogicalOperators", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (LogicalOperators?, ComparisonOperators?, ArithmeticOperators?)
        /// </para>
        /// </summary>
        public ComparisonOperatorsType ComparisonOperators
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ComparisonOperators", "http://www.opengis.net/ogc"));
                return ((ComparisonOperatorsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ComparisonOperators", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (LogicalOperators?, ComparisonOperators?, ArithmeticOperators?)
        /// </para>
        /// </summary>
        public ArithmeticOperatorsType ArithmeticOperators
        {
            get
            {
                XElement x=this.GetElement(XName.Get("ArithmeticOperators", "http://www.opengis.net/ogc"));
                return ((ArithmeticOperatorsType)(x));
            }
            set
            {
                this.SetElement(XName.Get("ArithmeticOperators", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("Scalar_CapabilitiesType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<Scalar_CapabilitiesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("LogicalOperators", "http://www.opengis.net/ogc"), typeof(LogicalOperators));
            localElementDictionary.Add(XName.Get("ComparisonOperators", "http://www.opengis.net/ogc"), typeof(ComparisonOperatorsType));
            localElementDictionary.Add(XName.Get("ArithmeticOperators", "http://www.opengis.net/ogc"), typeof(ArithmeticOperatorsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName Scalar_CapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Scalar_CapabilitiesType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (ComparisonOperator)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ComparisonOperatorsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ComparisonOperatorsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XSimpleList<string> ComparisonOperatorField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator ComparisonOperatorsType(XElement xe) { return XTypedServices.ToXTypedElement<ComparisonOperatorsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ComparisonOperatorsType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (ComparisonOperator)+
        /// </para>
        /// </summary>
        public ComparisonOperatorsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (ComparisonOperator)+
        /// </para>
        /// </summary>
        public IList<string> ComparisonOperator
        {
            get
            {
                if ((this.ComparisonOperatorField==null))
                {
                    this.ComparisonOperatorField=new XSimpleList<string>(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, XName.Get("ComparisonOperator", "http://www.opengis.net/ogc"));
                }
                return this.ComparisonOperatorField;
            }
            set
            {
                if ((value==null))
                {
                    this.ComparisonOperatorField=null;
                } else
                {
                    if ((this.ComparisonOperatorField==null))
                    {
                        this.ComparisonOperatorField=XSimpleList<string>.Initialize(this, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, value, XName.Get("ComparisonOperator", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<System.String>(this.ComparisonOperatorField, value);
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
                return XName.Get("ComparisonOperatorsType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<ComparisonOperatorsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("ComparisonOperator", "http://www.opengis.net/ogc"), typeof(string));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName ComparisonOperatorsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ComparisonOperatorsType", "http://www.opengis.net/ogc");
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public sealed class ComparisonOperatorType
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static Xml.Schema.Linq.SimpleTypeValidator TypeDefinition=new Xml.Schema.Linq.AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new Xml.Schema.Linq.RestrictionFacets(((Xml.Schema.Linq.RestrictionFlags)(16)), new object[] {
                        "LessThan",
                        "GreaterThan",
                        "LessThanEqualTo",
                        "GreaterThanEqualTo",
                        "EqualTo",
                        "NotEqualTo",
                        "Like",
                        "Between",
                        "NullCheck"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));

        private ComparisonOperatorType()
        {
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (SimpleArithmetic | Functions)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("ArithmeticOperatorsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class ArithmeticOperatorsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<SimpleArithmetic> SimpleArithmeticField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<FunctionsType> FunctionsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator ArithmeticOperatorsType(XElement xe) { return XTypedServices.ToXTypedElement<ArithmeticOperatorsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static ArithmeticOperatorsType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (SimpleArithmetic | Functions)+
        /// </para>
        /// </summary>
        public ArithmeticOperatorsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (SimpleArithmetic | Functions)+
        /// </para>
        /// </summary>
        public IList<SimpleArithmetic> SimpleArithmetic
        {
            get
            {
                if ((this.SimpleArithmeticField==null))
                {
                    this.SimpleArithmeticField=new XTypedList<SimpleArithmetic>(this, LinqToXsdTypeManager.Instance, XName.Get("SimpleArithmetic", "http://www.opengis.net/ogc"));
                }
                return this.SimpleArithmeticField;
            }
            set
            {
                if ((value==null))
                {
                    this.SimpleArithmeticField=null;
                } else
                {
                    if ((this.SimpleArithmeticField==null))
                    {
                        this.SimpleArithmeticField=XTypedList<SimpleArithmetic>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("SimpleArithmetic", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<SimpleArithmetic>(this.SimpleArithmeticField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (SimpleArithmetic | Functions)+
        /// </para>
        /// </summary>
        public IList<FunctionsType> Functions
        {
            get
            {
                if ((this.FunctionsField==null))
                {
                    this.FunctionsField=new XTypedList<FunctionsType>(this, LinqToXsdTypeManager.Instance, XName.Get("Functions", "http://www.opengis.net/ogc"));
                }
                return this.FunctionsField;
            }
            set
            {
                if ((value==null))
                {
                    this.FunctionsField=null;
                } else
                {
                    if ((this.FunctionsField==null))
                    {
                        this.FunctionsField=XTypedList<FunctionsType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Functions", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<FunctionsType>(this.FunctionsField, value);
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
                return XName.Get("ArithmeticOperatorsType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<ArithmeticOperatorsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("SimpleArithmetic", "http://www.opengis.net/ogc"), typeof(SimpleArithmetic));
            localElementDictionary.Add(XName.Get("Functions", "http://www.opengis.net/ogc"), typeof(FunctionsType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName ArithmeticOperatorsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ArithmeticOperatorsType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (FunctionNames)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("FunctionsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FunctionsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator FunctionsType(XElement xe) { return XTypedServices.ToXTypedElement<FunctionsType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static FunctionsType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("FunctionNames", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (FunctionNames)
        /// </para>
        /// </summary>
        public FunctionsType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (FunctionNames)
        /// </para>
        /// </summary>
        public FunctionNamesType FunctionNames
        {
            get
            {
                XElement x=this.GetElement(XName.Get("FunctionNames", "http://www.opengis.net/ogc"));
                return ((FunctionNamesType)(x));
            }
            set
            {
                this.SetElement(XName.Get("FunctionNames", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("FunctionsType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FunctionsType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("FunctionNames", "http://www.opengis.net/ogc"), typeof(FunctionNamesType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName FunctionsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FunctionsType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (FunctionName)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("FunctionNamesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FunctionNamesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<FunctionNameType> FunctionNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator FunctionNamesType(XElement xe) { return XTypedServices.ToXTypedElement<FunctionNamesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static FunctionNamesType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (FunctionName)+
        /// </para>
        /// </summary>
        public FunctionNamesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (FunctionName)+
        /// </para>
        /// </summary>
        public IList<FunctionNameType> FunctionName
        {
            get
            {
                if ((this.FunctionNameField==null))
                {
                    this.FunctionNameField=new XTypedList<FunctionNameType>(this, LinqToXsdTypeManager.Instance, XName.Get("FunctionName", "http://www.opengis.net/ogc"));
                }
                return this.FunctionNameField;
            }
            set
            {
                if ((value==null))
                {
                    this.FunctionNameField=null;
                } else
                {
                    if ((this.FunctionNameField==null))
                    {
                        this.FunctionNameField=XTypedList<FunctionNameType>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("FunctionName", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<FunctionNameType>(this.FunctionNameField, value);
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
                return XName.Get("FunctionNamesType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FunctionNamesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("FunctionName", "http://www.opengis.net/ogc"), typeof(FunctionNameType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName FunctionNamesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FunctionNamesType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("FunctionNameTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FunctionNameType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator FunctionNameType(XElement xe) { return XTypedServices.ToXTypedElement<FunctionNameType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public FunctionNameType()
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
        public string nArgs
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("nArgs", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("nArgs", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("FunctionNameType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FunctionNameType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName FunctionNameTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FunctionNameType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (EID | FID)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("Id_CapabilitiesTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Id_CapabilitiesType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<EID> EIDField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<FID> FIDField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator Id_CapabilitiesType(XElement xe) { return XTypedServices.ToXTypedElement<Id_CapabilitiesType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static Id_CapabilitiesType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (EID | FID)+
        /// </para>
        /// </summary>
        public Id_CapabilitiesType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (EID | FID)+
        /// </para>
        /// </summary>
        public IList<EID> EID
        {
            get
            {
                if ((this.EIDField==null))
                {
                    this.EIDField=new XTypedList<EID>(this, LinqToXsdTypeManager.Instance, XName.Get("EID", "http://www.opengis.net/ogc"));
                }
                return this.EIDField;
            }
            set
            {
                if ((value==null))
                {
                    this.EIDField=null;
                } else
                {
                    if ((this.EIDField==null))
                    {
                        this.EIDField=XTypedList<EID>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("EID", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<EID>(this.EIDField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (EID | FID)+
        /// </para>
        /// </summary>
        public IList<FID> FID
        {
            get
            {
                if ((this.FIDField==null))
                {
                    this.FIDField=new XTypedList<FID>(this, LinqToXsdTypeManager.Instance, XName.Get("FID", "http://www.opengis.net/ogc"));
                }
                return this.FIDField;
            }
            set
            {
                if ((value==null))
                {
                    this.FIDField=null;
                } else
                {
                    if ((this.FIDField==null))
                    {
                        this.FIDField=XTypedList<FID>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("FID", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<FID>(this.FIDField, value);
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
                return XName.Get("Id_CapabilitiesType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<Id_CapabilitiesType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("EID", "http://www.opengis.net/ogc"), typeof(EID));
            localElementDictionary.Add(XName.Get("FID", "http://www.opengis.net/ogc"), typeof(FID));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName Id_CapabilitiesTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("Id_CapabilitiesType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("FilterTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FilterType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<_Id> _IdField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator FilterType(XElement xe) { return XTypedServices.ToXTypedElement<FilterType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static FilterType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("spatialOps", "http://www.opengis.net/ogc"), XName.Get("Equals", "http://www.opengis.net/ogc"), XName.Get("Disjoint", "http://www.opengis.net/ogc"), XName.Get("Touches", "http://www.opengis.net/ogc"), XName.Get("Within", "http://www.opengis.net/ogc"), XName.Get("Overlaps", "http://www.opengis.net/ogc"), XName.Get("Crosses", "http://www.opengis.net/ogc"), XName.Get("Intersects", "http://www.opengis.net/ogc"), XName.Get("Contains", "http://www.opengis.net/ogc"), XName.Get("DWithin", "http://www.opengis.net/ogc"), XName.Get("Beyond", "http://www.opengis.net/ogc"), XName.Get("BBOX", "http://www.opengis.net/ogc")), new SubstitutedContentModelEntity(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc")), new SubstitutedContentModelEntity(XName.Get("logicOps", "http://www.opengis.net/ogc"), XName.Get("And", "http://www.opengis.net/ogc"), XName.Get("Or", "http://www.opengis.net/ogc"), XName.Get("Not", "http://www.opengis.net/ogc")), new SubstitutedContentModelEntity(XName.Get("_Id", "http://www.opengis.net/ogc"), XName.Get("FeatureId", "http://www.opengis.net/ogc"), XName.Get("GmlObjectId", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public FilterType()
        {
        }

        public FilterType(spatialOps spatialOps)
        {
            this.spatialOps=spatialOps;
        }

        public FilterType(comparisonOps comparisonOps)
        {
            this.comparisonOps=comparisonOps;
        }

        public FilterType(logicOps logicOps)
        {
            this.logicOps=logicOps;
        }

        public FilterType(IEnumerable<_Id> _Id)
        {
            this._IdField=XTypedSubstitutedList<_Id>.Initialize(this, LinqToXsdTypeManager.Instance, _Id, XName.Get("_Id", "http://www.opengis.net/ogc"), XName.Get("FeatureId", "http://www.opengis.net/ogc"), XName.Get("GmlObjectId", "http://www.opengis.net/ogc"));
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public spatialOps spatialOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("spatialOps", "http://www.opengis.net/ogc"), XName.Get("Equals", "http://www.opengis.net/ogc"), XName.Get("Disjoint", "http://www.opengis.net/ogc"), XName.Get("Touches", "http://www.opengis.net/ogc"), XName.Get("Within", "http://www.opengis.net/ogc"), XName.Get("Overlaps", "http://www.opengis.net/ogc"), XName.Get("Crosses", "http://www.opengis.net/ogc"), XName.Get("Intersects", "http://www.opengis.net/ogc"), XName.Get("Contains", "http://www.opengis.net/ogc"), XName.Get("DWithin", "http://www.opengis.net/ogc"), XName.Get("Beyond", "http://www.opengis.net/ogc"), XName.Get("BBOX", "http://www.opengis.net/ogc"));
                return ((spatialOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("spatialOps", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public comparisonOps comparisonOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("comparisonOps", "http://www.opengis.net/ogc"), XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc"));
                return ((comparisonOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public logicOps logicOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("logicOps", "http://www.opengis.net/ogc"), XName.Get("And", "http://www.opengis.net/ogc"), XName.Get("Or", "http://www.opengis.net/ogc"), XName.Get("Not", "http://www.opengis.net/ogc"));
                return ((logicOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("logicOps", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating, choice
        /// </para>
        /// <para>
        /// Substitution members: _Id, FeatureId, GmlObjectId
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public IList<_Id> _Id
        {
            get
            {
                if ((this._IdField==null))
                {
                    this._IdField=new XTypedSubstitutedList<_Id>(this, LinqToXsdTypeManager.Instance, XName.Get("_Id", "http://www.opengis.net/ogc"), XName.Get("FeatureId", "http://www.opengis.net/ogc"), XName.Get("GmlObjectId", "http://www.opengis.net/ogc"));
                }
                return this._IdField;
            }
            set
            {
                if ((value==null))
                {
                    this._IdField=null;
                } else
                {
                    if ((this._IdField==null))
                    {
                        this._IdField=XTypedSubstitutedList<_Id>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("_Id", "http://www.opengis.net/ogc"), XName.Get("FeatureId", "http://www.opengis.net/ogc"), XName.Get("GmlObjectId", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<_Id>(this._IdField, value);
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
                return XName.Get("FilterType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FilterType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("spatialOps", "http://www.opengis.net/ogc"), typeof(spatialOps));
            localElementDictionary.Add(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), typeof(comparisonOps));
            localElementDictionary.Add(XName.Get("logicOps", "http://www.opengis.net/ogc"), typeof(logicOps));
            localElementDictionary.Add(XName.Get("_Id", "http://www.opengis.net/ogc"), typeof(_Id));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName FilterTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FilterType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("ComparisonOpsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class ComparisonOpsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator ComparisonOpsType(XElement xe) { return (ComparisonOpsType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public ComparisonOpsType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("ComparisonOpsType", "http://www.opengis.net/ogc");
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

        public static XmlQualifiedName ComparisonOpsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("ComparisonOpsType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("SpatialOpsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class SpatialOpsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator SpatialOpsType(XElement xe) { return (SpatialOpsType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public SpatialOpsType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("SpatialOpsType", "http://www.opengis.net/ogc");
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

        public static XmlQualifiedName SpatialOpsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("SpatialOpsType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("LogicOpsTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class LogicOpsType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator LogicOpsType(XElement xe) { return (LogicOpsType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public LogicOpsType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("LogicOpsType", "http://www.opengis.net/ogc");
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

        public static XmlQualifiedName LogicOpsTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("LogicOpsType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("AbstractIdTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class AbstractIdType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator AbstractIdType(XElement xe) { return (AbstractIdType)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public AbstractIdType()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("AbstractIdType", "http://www.opengis.net/ogc");
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

        public static XmlQualifiedName AbstractIdTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("AbstractIdType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("FeatureIdTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FeatureIdType: global::GeoSik.Ogc.Filter.V110.AbstractIdType, IXMetaData, IXmlSerializable
    {

        public static explicit operator FeatureIdType(XElement xe) { return XTypedServices.ToXTypedElement<FeatureIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public FeatureIdType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string fid
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fid", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("fid", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("FeatureIdType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<FeatureIdType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName FeatureIdTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("FeatureIdType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("GmlObjectIdTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GmlObjectIdType: global::GeoSik.Ogc.Filter.V110.AbstractIdType, IXMetaData, IXmlSerializable
    {

        public static explicit operator GmlObjectIdType(XElement xe) { return XTypedServices.ToXTypedElement<GmlObjectIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public GmlObjectIdType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string id
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("id", "http://www.opengis.net/gml"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("id", "http://www.opengis.net/gml"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Id).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("GmlObjectIdType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<GmlObjectIdType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName GmlObjectIdTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("GmlObjectIdType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression+)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BinaryComparisonOpTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BinaryComparisonOpType: global::GeoSik.Ogc.Filter.V110.ComparisonOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<expression> expressionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool matchCaseDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator BinaryComparisonOpType(XElement xe) { return XTypedServices.ToXTypedElement<BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BinaryComparisonOpType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public BinaryComparisonOpType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                if ((this.expressionField==null))
                {
                    this.expressionField=new XTypedSubstitutedList<expression>(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                }
                return this.expressionField;
            }
            set
            {
                if ((value==null))
                {
                    this.expressionField=null;
                } else
                {
                    if ((this.expressionField==null))
                    {
                        this.expressionField=XTypedSubstitutedList<expression>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<expression>(this.expressionField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("matchCase", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, matchCaseDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("matchCase", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
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
                return XName.Get("BinaryComparisonOpType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<BinaryComparisonOpType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName BinaryComparisonOpTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BinaryComparisonOpType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName, Literal)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("PropertyIsLikeTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsLikeType: global::GeoSik.Ogc.Filter.V110.ComparisonOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool matchCaseDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator PropertyIsLikeType(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsLikeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static PropertyIsLikeType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("PropertyName", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName, Literal)
        /// </para>
        /// </summary>
        public PropertyIsLikeType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, Literal)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                return ((PropertyName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, Literal)
        /// </para>
        /// </summary>
        public Literal Literal
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Literal", "http://www.opengis.net/ogc"));
                return ((Literal)(x));
            }
            set
            {
                this.SetElement(XName.Get("Literal", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string wildCard
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("wildCard", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("wildCard", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string singleChar
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("singleChar", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("singleChar", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string escapeChar
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("escapeChar", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("escapeChar", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("matchCase", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, matchCaseDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("matchCase", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
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
                return XName.Get("PropertyIsLikeType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<PropertyIsLikeType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
            localElementDictionary.Add(XName.Get("Literal", "http://www.opengis.net/ogc"), typeof(Literal));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName PropertyIsLikeTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("PropertyIsLikeType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("PropertyIsNullTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsNullType: global::GeoSik.Ogc.Filter.V110.ComparisonOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator PropertyIsNullType(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsNullType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static PropertyIsNullType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("PropertyName", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName)
        /// </para>
        /// </summary>
        public PropertyIsNullType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                return ((PropertyName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("PropertyIsNullType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<PropertyIsNullType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName PropertyIsNullTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("PropertyIsNullType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression, LowerBoundary, UpperBoundary)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("PropertyIsBetweenTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsBetweenType: global::GeoSik.Ogc.Filter.V110.ComparisonOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator PropertyIsBetweenType(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsBetweenType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static PropertyIsBetweenType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("LowerBoundary", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("UpperBoundary", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public PropertyIsBetweenType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public expression expression
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                return ((expression)(x));
            }
            set
            {
                this.SetElement(XName.Get("expression", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public LowerBoundaryType LowerBoundary
        {
            get
            {
                XElement x=this.GetElement(XName.Get("LowerBoundary", "http://www.opengis.net/ogc"));
                return ((LowerBoundaryType)(x));
            }
            set
            {
                this.SetElement(XName.Get("LowerBoundary", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public UpperBoundaryType UpperBoundary
        {
            get
            {
                XElement x=this.GetElement(XName.Get("UpperBoundary", "http://www.opengis.net/ogc"));
                return ((UpperBoundaryType)(x));
            }
            set
            {
                this.SetElement(XName.Get("UpperBoundary", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("PropertyIsBetweenType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<PropertyIsBetweenType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
            localElementDictionary.Add(XName.Get("LowerBoundary", "http://www.opengis.net/ogc"), typeof(LowerBoundaryType));
            localElementDictionary.Add(XName.Get("UpperBoundary", "http://www.opengis.net/ogc"), typeof(UpperBoundaryType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName PropertyIsBetweenTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("PropertyIsBetweenType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("LowerBoundaryTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class LowerBoundaryType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator LowerBoundaryType(XElement xe) { return XTypedServices.ToXTypedElement<LowerBoundaryType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static LowerBoundaryType()
        {
            BuildElementDictionary();
            contentModel=new ChoiceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression)
        /// </para>
        /// </summary>
        public LowerBoundaryType()
        {
        }

        public LowerBoundaryType(expression expression)
        {
            this.expression=expression;
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression)
        /// </para>
        /// </summary>
        public expression expression
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                return ((expression)(x));
            }
            set
            {
                this.SetElement(XName.Get("expression", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("LowerBoundaryType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<LowerBoundaryType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName LowerBoundaryTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("LowerBoundaryType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (expression)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UpperBoundaryTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UpperBoundaryType: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator UpperBoundaryType(XElement xe) { return XTypedServices.ToXTypedElement<UpperBoundaryType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UpperBoundaryType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new SubstitutedContentModelEntity(XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (expression)
        /// </para>
        /// </summary>
        public UpperBoundaryType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression)
        /// </para>
        /// </summary>
        public expression expression
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("expression", "http://www.opengis.net/ogc"), XName.Get("Add", "http://www.opengis.net/ogc"), XName.Get("Sub", "http://www.opengis.net/ogc"), XName.Get("Mul", "http://www.opengis.net/ogc"), XName.Get("Div", "http://www.opengis.net/ogc"), XName.Get("PropertyName", "http://www.opengis.net/ogc"), XName.Get("Function", "http://www.opengis.net/ogc"), XName.Get("Literal", "http://www.opengis.net/ogc"));
                return ((expression)(x));
            }
            set
            {
                this.SetElement(XName.Get("expression", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("UpperBoundaryType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<UpperBoundaryType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("expression", "http://www.opengis.net/ogc"), typeof(expression));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName UpperBoundaryTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UpperBoundaryType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BinarySpatialOpTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BinarySpatialOpType: global::GeoSik.Ogc.Filter.V110.SpatialOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<PropertyName> PropertyNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator BinarySpatialOpType(XElement xe) { return XTypedServices.ToXTypedElement<BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BinarySpatialOpType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public BinarySpatialOpType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
        {
            get
            {
                if ((this.PropertyNameField==null))
                {
                    this.PropertyNameField=new XTypedList<PropertyName>(this, LinqToXsdTypeManager.Instance, XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                }
                return this.PropertyNameField;
            }
            set
            {
                if ((value==null))
                {
                    this.PropertyNameField=null;
                } else
                {
                    if ((this.PropertyNameField==null))
                    {
                        this.PropertyNameField=XTypedList<PropertyName>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<PropertyName>(this.PropertyNameField, value);
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("_Geometry", "http://www.opengis.net/gml"), XName.Get("_GeometricPrimitive", "http://www.opengis.net/gml"), XName.Get("Point", "http://www.opengis.net/gml"), XName.Get("_Curve", "http://www.opengis.net/gml"), XName.Get("LineString", "http://www.opengis.net/gml"), XName.Get("_Surface", "http://www.opengis.net/gml"), XName.Get("Polygon", "http://www.opengis.net/gml"), XName.Get("_Ring", "http://www.opengis.net/gml"), XName.Get("LinearRing", "http://www.opengis.net/gml"), XName.Get("Curve", "http://www.opengis.net/gml"), XName.Get("OrientableCurve", "http://www.opengis.net/gml"), XName.Get("Surface", "http://www.opengis.net/gml"), XName.Get("OrientableSurface", "http://www.opengis.net/gml"), XName.Get("Ring", "http://www.opengis.net/gml"), XName.Get("PolyhedralSurface", "http://www.opengis.net/gml"), XName.Get("TriangulatedSurface", "http://www.opengis.net/gml"), XName.Get("Tin", "http://www.opengis.net/gml"), XName.Get("_Solid", "http://www.opengis.net/gml"), XName.Get("Solid", "http://www.opengis.net/gml"), XName.Get("_GeometricAggregate", "http://www.opengis.net/gml"), XName.Get("MultiGeometry", "http://www.opengis.net/gml"), XName.Get("MultiPoint", "http://www.opengis.net/gml"), XName.Get("MultiCurve", "http://www.opengis.net/gml"), XName.Get("MultiSurface", "http://www.opengis.net/gml"), XName.Get("MultiSolid", "http://www.opengis.net/gml"), XName.Get("MultiPolygon", "http://www.opengis.net/gml"), XName.Get("MultiLineString", "http://www.opengis.net/gml"));
                return ((GeoSik.Ogc.Gml.V311._Geometry)(x));
            }
            set
            {
                this.SetElement(XName.Get("_Geometry", "http://www.opengis.net/gml"), value);
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Envelope", "http://www.opengis.net/gml"));
                return ((GeoSik.Ogc.Gml.V311.Envelope)(x));
            }
            set
            {
                this.SetElement(XName.Get("Envelope", "http://www.opengis.net/gml"), value);
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
                return XName.Get("BinarySpatialOpType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<BinarySpatialOpType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
            localElementDictionary.Add(XName.Get("_Geometry", "http://www.opengis.net/gml"), typeof(GeoSik.Ogc.Gml.V311._Geometry));
            localElementDictionary.Add(XName.Get("Envelope", "http://www.opengis.net/gml"), typeof(GeoSik.Ogc.Gml.V311.Envelope));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName BinarySpatialOpTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BinarySpatialOpType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName?, Envelope)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BBOXTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BBOXType: global::GeoSik.Ogc.Filter.V110.SpatialOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator BBOXType(XElement xe) { return XTypedServices.ToXTypedElement<BBOXType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BBOXType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("PropertyName", "http://www.opengis.net/ogc")), new NamedContentModelEntity(XName.Get("Envelope", "http://www.opengis.net/gml")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName?, Envelope)
        /// </para>
        /// </summary>
        public BBOXType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName?, Envelope)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                return ((PropertyName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName?, Envelope)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Envelope", "http://www.opengis.net/gml"));
                return ((GeoSik.Ogc.Gml.V311.Envelope)(x));
            }
            set
            {
                this.SetElement(XName.Get("Envelope", "http://www.opengis.net/gml"), value);
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
                return XName.Get("BBOXType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<BBOXType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
            localElementDictionary.Add(XName.Get("Envelope", "http://www.opengis.net/gml"), typeof(GeoSik.Ogc.Gml.V311.Envelope));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName BBOXTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BBOXType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (PropertyName, _Geometry, Distance)
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("DistanceBufferTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DistanceBufferType: global::GeoSik.Ogc.Filter.V110.SpatialOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;

        public static explicit operator DistanceBufferType(XElement xe) { return XTypedServices.ToXTypedElement<DistanceBufferType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static DistanceBufferType()
        {
            BuildElementDictionary();
            contentModel=new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("PropertyName", "http://www.opengis.net/ogc")), new SubstitutedContentModelEntity(XName.Get("_Geometry", "http://www.opengis.net/gml"), XName.Get("_GeometricPrimitive", "http://www.opengis.net/gml"), XName.Get("Point", "http://www.opengis.net/gml"), XName.Get("_Curve", "http://www.opengis.net/gml"), XName.Get("LineString", "http://www.opengis.net/gml"), XName.Get("_Surface", "http://www.opengis.net/gml"), XName.Get("Polygon", "http://www.opengis.net/gml"), XName.Get("_Ring", "http://www.opengis.net/gml"), XName.Get("LinearRing", "http://www.opengis.net/gml"), XName.Get("Curve", "http://www.opengis.net/gml"), XName.Get("OrientableCurve", "http://www.opengis.net/gml"), XName.Get("Surface", "http://www.opengis.net/gml"), XName.Get("OrientableSurface", "http://www.opengis.net/gml"), XName.Get("Ring", "http://www.opengis.net/gml"), XName.Get("PolyhedralSurface", "http://www.opengis.net/gml"), XName.Get("TriangulatedSurface", "http://www.opengis.net/gml"), XName.Get("Tin", "http://www.opengis.net/gml"), XName.Get("_Solid", "http://www.opengis.net/gml"), XName.Get("Solid", "http://www.opengis.net/gml"), XName.Get("_GeometricAggregate", "http://www.opengis.net/gml"), XName.Get("MultiGeometry", "http://www.opengis.net/gml"), XName.Get("MultiPoint", "http://www.opengis.net/gml"), XName.Get("MultiCurve", "http://www.opengis.net/gml"), XName.Get("MultiSurface", "http://www.opengis.net/gml"), XName.Get("MultiSolid", "http://www.opengis.net/gml"), XName.Get("MultiPolygon", "http://www.opengis.net/gml"), XName.Get("MultiLineString", "http://www.opengis.net/gml")), new NamedContentModelEntity(XName.Get("Distance", "http://www.opengis.net/ogc")));
        }

        /// <summary>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public DistanceBufferType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
        {
            get
            {
                XElement x=this.GetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"));
                return ((PropertyName)(x));
            }
            set
            {
                this.SetElement(XName.Get("PropertyName", "http://www.opengis.net/ogc"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("_Geometry", "http://www.opengis.net/gml"), XName.Get("_GeometricPrimitive", "http://www.opengis.net/gml"), XName.Get("Point", "http://www.opengis.net/gml"), XName.Get("_Curve", "http://www.opengis.net/gml"), XName.Get("LineString", "http://www.opengis.net/gml"), XName.Get("_Surface", "http://www.opengis.net/gml"), XName.Get("Polygon", "http://www.opengis.net/gml"), XName.Get("_Ring", "http://www.opengis.net/gml"), XName.Get("LinearRing", "http://www.opengis.net/gml"), XName.Get("Curve", "http://www.opengis.net/gml"), XName.Get("OrientableCurve", "http://www.opengis.net/gml"), XName.Get("Surface", "http://www.opengis.net/gml"), XName.Get("OrientableSurface", "http://www.opengis.net/gml"), XName.Get("Ring", "http://www.opengis.net/gml"), XName.Get("PolyhedralSurface", "http://www.opengis.net/gml"), XName.Get("TriangulatedSurface", "http://www.opengis.net/gml"), XName.Get("Tin", "http://www.opengis.net/gml"), XName.Get("_Solid", "http://www.opengis.net/gml"), XName.Get("Solid", "http://www.opengis.net/gml"), XName.Get("_GeometricAggregate", "http://www.opengis.net/gml"), XName.Get("MultiGeometry", "http://www.opengis.net/gml"), XName.Get("MultiPoint", "http://www.opengis.net/gml"), XName.Get("MultiCurve", "http://www.opengis.net/gml"), XName.Get("MultiSurface", "http://www.opengis.net/gml"), XName.Get("MultiSolid", "http://www.opengis.net/gml"), XName.Get("MultiPolygon", "http://www.opengis.net/gml"), XName.Get("MultiLineString", "http://www.opengis.net/gml"));
                return ((GeoSik.Ogc.Gml.V311._Geometry)(x));
            }
            set
            {
                this.SetElement(XName.Get("_Geometry", "http://www.opengis.net/gml"), value);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public DistanceType Distance
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Distance", "http://www.opengis.net/ogc"));
                return ((DistanceType)(x));
            }
            set
            {
                this.SetElement(XName.Get("Distance", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("DistanceBufferType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<DistanceBufferType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("PropertyName", "http://www.opengis.net/ogc"), typeof(PropertyName));
            localElementDictionary.Add(XName.Get("_Geometry", "http://www.opengis.net/gml"), typeof(GeoSik.Ogc.Gml.V311._Geometry));
            localElementDictionary.Add(XName.Get("Distance", "http://www.opengis.net/ogc"), typeof(DistanceType));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return contentModel;
        }

        public static XmlQualifiedName DistanceBufferTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DistanceBufferType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("DistanceTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DistanceType: XTypedElement, IXMetaData, IXmlSerializable
    {

        public static explicit operator DistanceType(XElement xe) { return XTypedServices.ToXTypedElement<DistanceType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public DistanceType()
        {
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

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public System.Uri units
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("units", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("units", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("DistanceType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<DistanceType>(this);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName DistanceTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("DistanceType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("BinaryLogicOpTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BinaryLogicOpType: global::GeoSik.Ogc.Filter.V110.LogicOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<comparisonOps> comparisonOpsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<spatialOps> spatialOpsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedSubstitutedList<logicOps> logicOpsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<Function> FunctionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator BinaryLogicOpType(XElement xe) { return XTypedServices.ToXTypedElement<BinaryLogicOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static BinaryLogicOpType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public BinaryLogicOpType()
        {
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<comparisonOps> comparisonOps
        {
            get
            {
                if ((this.comparisonOpsField==null))
                {
                    this.comparisonOpsField=new XTypedSubstitutedList<comparisonOps>(this, LinqToXsdTypeManager.Instance, XName.Get("comparisonOps", "http://www.opengis.net/ogc"), XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc"));
                }
                return this.comparisonOpsField;
            }
            set
            {
                if ((value==null))
                {
                    this.comparisonOpsField=null;
                } else
                {
                    if ((this.comparisonOpsField==null))
                    {
                        this.comparisonOpsField=XTypedSubstitutedList<comparisonOps>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("comparisonOps", "http://www.opengis.net/ogc"), XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<comparisonOps>(this.comparisonOpsField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<spatialOps> spatialOps
        {
            get
            {
                if ((this.spatialOpsField==null))
                {
                    this.spatialOpsField=new XTypedSubstitutedList<spatialOps>(this, LinqToXsdTypeManager.Instance, XName.Get("spatialOps", "http://www.opengis.net/ogc"), XName.Get("Equals", "http://www.opengis.net/ogc"), XName.Get("Disjoint", "http://www.opengis.net/ogc"), XName.Get("Touches", "http://www.opengis.net/ogc"), XName.Get("Within", "http://www.opengis.net/ogc"), XName.Get("Overlaps", "http://www.opengis.net/ogc"), XName.Get("Crosses", "http://www.opengis.net/ogc"), XName.Get("Intersects", "http://www.opengis.net/ogc"), XName.Get("Contains", "http://www.opengis.net/ogc"), XName.Get("DWithin", "http://www.opengis.net/ogc"), XName.Get("Beyond", "http://www.opengis.net/ogc"), XName.Get("BBOX", "http://www.opengis.net/ogc"));
                }
                return this.spatialOpsField;
            }
            set
            {
                if ((value==null))
                {
                    this.spatialOpsField=null;
                } else
                {
                    if ((this.spatialOpsField==null))
                    {
                        this.spatialOpsField=XTypedSubstitutedList<spatialOps>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("spatialOps", "http://www.opengis.net/ogc"), XName.Get("Equals", "http://www.opengis.net/ogc"), XName.Get("Disjoint", "http://www.opengis.net/ogc"), XName.Get("Touches", "http://www.opengis.net/ogc"), XName.Get("Within", "http://www.opengis.net/ogc"), XName.Get("Overlaps", "http://www.opengis.net/ogc"), XName.Get("Crosses", "http://www.opengis.net/ogc"), XName.Get("Intersects", "http://www.opengis.net/ogc"), XName.Get("Contains", "http://www.opengis.net/ogc"), XName.Get("DWithin", "http://www.opengis.net/ogc"), XName.Get("Beyond", "http://www.opengis.net/ogc"), XName.Get("BBOX", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<spatialOps>(this.spatialOpsField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<logicOps> logicOps
        {
            get
            {
                if ((this.logicOpsField==null))
                {
                    this.logicOpsField=new XTypedSubstitutedList<logicOps>(this, LinqToXsdTypeManager.Instance, XName.Get("logicOps", "http://www.opengis.net/ogc"), XName.Get("And", "http://www.opengis.net/ogc"), XName.Get("Or", "http://www.opengis.net/ogc"), XName.Get("Not", "http://www.opengis.net/ogc"));
                }
                return this.logicOpsField;
            }
            set
            {
                if ((value==null))
                {
                    this.logicOpsField=null;
                } else
                {
                    if ((this.logicOpsField==null))
                    {
                        this.logicOpsField=XTypedSubstitutedList<logicOps>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("logicOps", "http://www.opengis.net/ogc"), XName.Get("And", "http://www.opengis.net/ogc"), XName.Get("Or", "http://www.opengis.net/ogc"), XName.Get("Not", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<logicOps>(this.logicOpsField, value);
                    }
                }
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<Function> Function
        {
            get
            {
                if ((this.FunctionField==null))
                {
                    this.FunctionField=new XTypedList<Function>(this, LinqToXsdTypeManager.Instance, XName.Get("Function", "http://www.opengis.net/ogc"));
                }
                return this.FunctionField;
            }
            set
            {
                if ((value==null))
                {
                    this.FunctionField=null;
                } else
                {
                    if ((this.FunctionField==null))
                    {
                        this.FunctionField=XTypedList<Function>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("Function", "http://www.opengis.net/ogc"));
                    } else
                    {
                        XTypedServices.SetList<Function>(this.FunctionField, value);
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
                return XName.Get("BinaryLogicOpType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<BinaryLogicOpType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), typeof(comparisonOps));
            localElementDictionary.Add(XName.Get("spatialOps", "http://www.opengis.net/ogc"), typeof(spatialOps));
            localElementDictionary.Add(XName.Get("logicOps", "http://www.opengis.net/ogc"), typeof(logicOps));
            localElementDictionary.Add(XName.Get("Function", "http://www.opengis.net/ogc"), typeof(Function));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName BinaryLogicOpTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("BinaryLogicOpType", "http://www.opengis.net/ogc");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("UnaryLogicOpTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class UnaryLogicOpType: global::GeoSik.Ogc.Filter.V110.LogicOpsType, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary=new Dictionary<XName, System.Type>();

        public static explicit operator UnaryLogicOpType(XElement xe) { return XTypedServices.ToXTypedElement<UnaryLogicOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static UnaryLogicOpType()
        {
            BuildElementDictionary();
        }

        /// <summary>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public UnaryLogicOpType()
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
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public comparisonOps comparisonOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("comparisonOps", "http://www.opengis.net/ogc"), XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc"), XName.Get("PropertyIsLike", "http://www.opengis.net/ogc"), XName.Get("PropertyIsNull", "http://www.opengis.net/ogc"), XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc"));
                return ((comparisonOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), value);
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
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public spatialOps spatialOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("spatialOps", "http://www.opengis.net/ogc"), XName.Get("Equals", "http://www.opengis.net/ogc"), XName.Get("Disjoint", "http://www.opengis.net/ogc"), XName.Get("Touches", "http://www.opengis.net/ogc"), XName.Get("Within", "http://www.opengis.net/ogc"), XName.Get("Overlaps", "http://www.opengis.net/ogc"), XName.Get("Crosses", "http://www.opengis.net/ogc"), XName.Get("Intersects", "http://www.opengis.net/ogc"), XName.Get("Contains", "http://www.opengis.net/ogc"), XName.Get("DWithin", "http://www.opengis.net/ogc"), XName.Get("Beyond", "http://www.opengis.net/ogc"), XName.Get("BBOX", "http://www.opengis.net/ogc"));
                return ((spatialOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("spatialOps", "http://www.opengis.net/ogc"), value);
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
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public logicOps logicOps
        {
            get
            {
                XTypedElement x=XTypedServices.ToSubstitutedXTypedElement(this, LinqToXsdTypeManager.Instance, XName.Get("logicOps", "http://www.opengis.net/ogc"), XName.Get("And", "http://www.opengis.net/ogc"), XName.Get("Or", "http://www.opengis.net/ogc"), XName.Get("Not", "http://www.opengis.net/ogc"));
                return ((logicOps)(x));
            }
            set
            {
                this.SetElement(XName.Get("logicOps", "http://www.opengis.net/ogc"), value);
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
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public Function Function
        {
            get
            {
                XElement x=this.GetElement(XName.Get("Function", "http://www.opengis.net/ogc"));
                return ((Function)(x));
            }
            set
            {
                this.SetElement(XName.Get("Function", "http://www.opengis.net/ogc"), value);
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
                return XName.Get("UnaryLogicOpType", "http://www.opengis.net/ogc");
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
            return XTypedServices.CloneXTypedElement<UnaryLogicOpType>(this);
        }

        private static void BuildElementDictionary()
        {
            localElementDictionary.Add(XName.Get("comparisonOps", "http://www.opengis.net/ogc"), typeof(comparisonOps));
            localElementDictionary.Add(XName.Get("spatialOps", "http://www.opengis.net/ogc"), typeof(spatialOps));
            localElementDictionary.Add(XName.Get("logicOps", "http://www.opengis.net/ogc"), typeof(logicOps));
            localElementDictionary.Add(XName.Get("Function", "http://www.opengis.net/ogc"), typeof(Function));
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlQualifiedName UnaryLogicOpTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("UnaryLogicOpType", "http://www.opengis.net/ogc");
        }
    }

    [XmlSchemaProviderAttribute("AddSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Add: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryOperatorType ContentField;

        public static explicit operator Add(XElement xe) { return XTypedServices.ToXTypedElement<Add, BinaryOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Add() :
            base(true)
        {
            SetInnerType(new BinaryOperatorType());
        }

        public Add(BinaryOperatorType content) :
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

        public new BinaryOperatorType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
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
                return XName.Get("Add", "http://www.opengis.net/ogc");
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

        public new static Add Load(string xmlFile)
        {
            return XTypedServices.Load<Add, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Add Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Add, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Add Parse(string xml)
        {
            return XTypedServices.Parse<Add, BinaryOperatorType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Add(((BinaryOperatorType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryOperatorType ContentField)
        {
            this.ContentField=((BinaryOperatorType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AddSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Add", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("SubSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Sub: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryOperatorType ContentField;

        public static explicit operator Sub(XElement xe) { return XTypedServices.ToXTypedElement<Sub, BinaryOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Sub() :
            base(true)
        {
            SetInnerType(new BinaryOperatorType());
        }

        public Sub(BinaryOperatorType content) :
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

        public new BinaryOperatorType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
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
                return XName.Get("Sub", "http://www.opengis.net/ogc");
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

        public new static Sub Load(string xmlFile)
        {
            return XTypedServices.Load<Sub, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Sub Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Sub, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Sub Parse(string xml)
        {
            return XTypedServices.Parse<Sub, BinaryOperatorType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Sub(((BinaryOperatorType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryOperatorType ContentField)
        {
            this.ContentField=((BinaryOperatorType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType SubSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Sub", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("MulSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Mul: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryOperatorType ContentField;

        public static explicit operator Mul(XElement xe) { return XTypedServices.ToXTypedElement<Mul, BinaryOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Mul() :
            base(true)
        {
            SetInnerType(new BinaryOperatorType());
        }

        public Mul(BinaryOperatorType content) :
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

        public new BinaryOperatorType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
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
                return XName.Get("Mul", "http://www.opengis.net/ogc");
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

        public new static Mul Load(string xmlFile)
        {
            return XTypedServices.Load<Mul, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Mul Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Mul, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Mul Parse(string xml)
        {
            return XTypedServices.Parse<Mul, BinaryOperatorType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Mul(((BinaryOperatorType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryOperatorType ContentField)
        {
            this.ContentField=((BinaryOperatorType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType MulSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Mul", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("DivSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Div: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryOperatorType ContentField;

        public static explicit operator Div(XElement xe) { return XTypedServices.ToXTypedElement<Div, BinaryOperatorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Div() :
            base(true)
        {
            SetInnerType(new BinaryOperatorType());
        }

        public Div(BinaryOperatorType content) :
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

        public new BinaryOperatorType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
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
                return XName.Get("Div", "http://www.opengis.net/ogc");
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

        public new static Div Load(string xmlFile)
        {
            return XTypedServices.Load<Div, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Div Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Div, BinaryOperatorType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Div Parse(string xml)
        {
            return XTypedServices.Parse<Div, BinaryOperatorType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Div(((BinaryOperatorType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryOperatorType ContentField)
        {
            this.ContentField=((BinaryOperatorType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DivSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Div", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyNameSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyName: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyNameType ContentField;

        public static explicit operator PropertyName(XElement xe) { return XTypedServices.ToXTypedElement<PropertyName, PropertyNameType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyName() :
            base(true)
        {
            SetInnerType(new PropertyNameType());
        }

        public PropertyName(PropertyNameType content) :
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

        public new PropertyNameType Content
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
                return XName.Get("PropertyName", "http://www.opengis.net/ogc");
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

        public new static PropertyName Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyName, PropertyNameType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyName Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyName, PropertyNameType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyName Parse(string xml)
        {
            return XTypedServices.Parse<PropertyName, PropertyNameType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyName(((PropertyNameType)(this.Content.Clone())));
        }

        private void SetInnerType(PropertyNameType ContentField)
        {
            this.ContentField=((PropertyNameType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyNameSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyName", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("FunctionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Function: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FunctionType ContentField;

        public static explicit operator Function(XElement xe) { return XTypedServices.ToXTypedElement<Function, FunctionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Function() :
            base(true)
        {
            SetInnerType(new FunctionType());
        }

        public Function(FunctionType content) :
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

        public new FunctionType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression*)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string name
        {
            get
            {
                return this.ContentField.name;
            }
            set
            {
                this.ContentField.name=value;
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
                return XName.Get("Function", "http://www.opengis.net/ogc");
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

        public new static Function Load(string xmlFile)
        {
            return XTypedServices.Load<Function, FunctionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Function Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Function, FunctionType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Function Parse(string xml)
        {
            return XTypedServices.Parse<Function, FunctionType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Function(((FunctionType)(this.Content.Clone())));
        }

        private void SetInnerType(FunctionType ContentField)
        {
            this.ContentField=((FunctionType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType FunctionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Function", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("LiteralSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Literal: global::GeoSik.Ogc.Filter.V110.expression, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LiteralType ContentField;

        public static explicit operator Literal(XElement xe) { return XTypedServices.ToXTypedElement<Literal, LiteralType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Literal() :
            base(true)
        {
            SetInnerType(new LiteralType());
        }

        public Literal(LiteralType content) :
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

        public new LiteralType Content
        {
            get
            {
                return ContentField;
            }
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
                return XName.Get("Literal", "http://www.opengis.net/ogc");
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

        public new static Literal Load(string xmlFile)
        {
            return XTypedServices.Load<Literal, LiteralType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Literal Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Literal, LiteralType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Literal Parse(string xml)
        {
            return XTypedServices.Parse<Literal, LiteralType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Literal(((LiteralType)(this.Content.Clone())));
        }

        private void SetInnerType(LiteralType ContentField)
        {
            this.ContentField=((LiteralType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType LiteralSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Literal", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("expressionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class expression: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExpressionType ContentField;

        public static explicit operator expression(XElement xe) { return (expression)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected expression(bool setNull)
        {
        }

        public expression()
        {
            throw new InvalidOperationException();
        }

        public expression(ExpressionType content)
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

        public ExpressionType Content
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
                return XName.Get("expression", "http://www.opengis.net/ogc");
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

        public static expression Load(string xmlFile)
        {
            return ((expression)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static expression Load(System.IO.TextReader xmlFile)
        {
            return ((expression)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static expression Parse(string xml)
        {
            return ((expression)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(ExpressionType ContentField)
        {
            this.ContentField=((ExpressionType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(ExpressionType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType expressionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("expression", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("SortBySchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class SortBy: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SortByType ContentField;

        public static explicit operator SortBy(XElement xe) { return XTypedServices.ToXTypedElement<SortBy, SortByType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public SortBy()
        {
            SetInnerType(new SortByType());
        }

        public SortBy(SortByType content)
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

        public SortByType Content
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
        /// Regular expression: (SortProperty+)
        /// </para>
        /// </summary>
        public IList<SortPropertyType> SortProperty
        {
            get
            {
                return this.ContentField.SortProperty;
            }
            set
            {
                this.ContentField.SortProperty=value;
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
                return XName.Get("SortBy", "http://www.opengis.net/ogc");
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

        public static SortBy Load(string xmlFile)
        {
            return XTypedServices.Load<SortBy, SortByType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static SortBy Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<SortBy, SortByType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static SortBy Parse(string xml)
        {
            return XTypedServices.Parse<SortBy, SortByType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new SortBy(((SortByType)(this.Content.Clone())));
        }

        private void SetInnerType(SortByType ContentField)
        {
            this.ContentField=((SortByType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType SortBySchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("SortBy", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("_IdSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class _Id: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AbstractIdType ContentField;

        public static explicit operator _Id(XElement xe) { return (_Id)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected _Id(bool setNull)
        {
        }

        public _Id()
        {
            throw new InvalidOperationException();
        }

        public _Id(AbstractIdType content)
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

        public AbstractIdType Content
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
                return XName.Get("_Id", "http://www.opengis.net/ogc");
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

        public static _Id Load(string xmlFile)
        {
            return ((_Id)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static _Id Load(System.IO.TextReader xmlFile)
        {
            return ((_Id)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static _Id Parse(string xml)
        {
            return ((_Id)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(AbstractIdType ContentField)
        {
            this.ContentField=((AbstractIdType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(AbstractIdType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType _IdSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("_Id", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("FeatureIdSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class FeatureId: global::GeoSik.Ogc.Filter.V110._Id, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FeatureIdType ContentField;

        public static explicit operator FeatureId(XElement xe) { return XTypedServices.ToXTypedElement<FeatureId, FeatureIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public FeatureId() :
            base(true)
        {
            SetInnerType(new FeatureIdType());
        }

        public FeatureId(FeatureIdType content) :
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

        public new FeatureIdType Content
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
        /// </summary>
        public string fid
        {
            get
            {
                return this.ContentField.fid;
            }
            set
            {
                this.ContentField.fid=value;
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
                return XName.Get("FeatureId", "http://www.opengis.net/ogc");
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

        public new static FeatureId Load(string xmlFile)
        {
            return XTypedServices.Load<FeatureId, FeatureIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static FeatureId Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<FeatureId, FeatureIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static FeatureId Parse(string xml)
        {
            return XTypedServices.Parse<FeatureId, FeatureIdType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new FeatureId(((FeatureIdType)(this.Content.Clone())));
        }

        private void SetInnerType(FeatureIdType ContentField)
        {
            this.ContentField=((FeatureIdType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType FeatureIdSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("FeatureId", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("GmlObjectIdSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class GmlObjectId: global::GeoSik.Ogc.Filter.V110._Id, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GmlObjectIdType ContentField;

        public static explicit operator GmlObjectId(XElement xe) { return XTypedServices.ToXTypedElement<GmlObjectId, GmlObjectIdType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public GmlObjectId() :
            base(true)
        {
            SetInnerType(new GmlObjectIdType());
        }

        public GmlObjectId(GmlObjectIdType content) :
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

        public new GmlObjectIdType Content
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
                return XName.Get("GmlObjectId", "http://www.opengis.net/ogc");
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

        public new static GmlObjectId Load(string xmlFile)
        {
            return XTypedServices.Load<GmlObjectId, GmlObjectIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static GmlObjectId Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<GmlObjectId, GmlObjectIdType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static GmlObjectId Parse(string xml)
        {
            return XTypedServices.Parse<GmlObjectId, GmlObjectIdType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new GmlObjectId(((GmlObjectIdType)(this.Content.Clone())));
        }

        private void SetInnerType(GmlObjectIdType ContentField)
        {
            this.ContentField=((GmlObjectIdType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType GmlObjectIdSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("GmlObjectId", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("FilterSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Filter: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FilterType ContentField;

        public static explicit operator Filter(XElement xe) { return XTypedServices.ToXTypedElement<Filter, FilterType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Filter()
        {
            SetInnerType(new FilterType());
        }

        public Filter(FilterType content)
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

        public FilterType Content
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
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public spatialOps spatialOps
        {
            get
            {
                return this.ContentField.spatialOps;
            }
            set
            {
                this.ContentField.spatialOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public comparisonOps comparisonOps
        {
            get
            {
                return this.ContentField.comparisonOps;
            }
            set
            {
                this.ContentField.comparisonOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public logicOps logicOps
        {
            get
            {
                return this.ContentField.logicOps;
            }
            set
            {
                this.ContentField.logicOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, repeating, choice
        /// </para>
        /// <para>
        /// Substitution members: _Id, FeatureId, GmlObjectId
        /// </para>
        /// <para>
        /// Regular expression: (spatialOps | comparisonOps | logicOps | _Id+)
        /// </para>
        /// </summary>
        public IList<_Id> _Id
        {
            get
            {
                return this.ContentField._Id;
            }
            set
            {
                this.ContentField._Id=value;
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
                return XName.Get("Filter", "http://www.opengis.net/ogc");
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

        public static Filter Load(string xmlFile)
        {
            return XTypedServices.Load<Filter, FilterType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Filter Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Filter, FilterType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Filter Parse(string xml)
        {
            return XTypedServices.Parse<Filter, FilterType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Filter(((FilterType)(this.Content.Clone())));
        }

        private void SetInnerType(FilterType ContentField)
        {
            this.ContentField=((FilterType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType FilterSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Filter", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("comparisonOpsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class comparisonOps: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComparisonOpsType ContentField;

        public static explicit operator comparisonOps(XElement xe) { return (comparisonOps)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected comparisonOps(bool setNull)
        {
        }

        public comparisonOps()
        {
            throw new InvalidOperationException();
        }

        public comparisonOps(ComparisonOpsType content)
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

        public ComparisonOpsType Content
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
                return XName.Get("comparisonOps", "http://www.opengis.net/ogc");
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

        public static comparisonOps Load(string xmlFile)
        {
            return ((comparisonOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static comparisonOps Load(System.IO.TextReader xmlFile)
        {
            return ((comparisonOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static comparisonOps Parse(string xml)
        {
            return ((comparisonOps)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(ComparisonOpsType ContentField)
        {
            this.ContentField=((ComparisonOpsType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(ComparisonOpsType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType comparisonOpsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("comparisonOps", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsEqualToSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsEqualTo: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsEqualTo(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsEqualTo, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsEqualTo() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsEqualTo(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsEqualTo", "http://www.opengis.net/ogc");
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

        public new static PropertyIsEqualTo Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsEqualTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsEqualTo Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsEqualTo, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsEqualTo(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsEqualToSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsEqualTo", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsNotEqualToSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsNotEqualTo: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsNotEqualTo(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsNotEqualTo, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsNotEqualTo() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsNotEqualTo(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsNotEqualTo", "http://www.opengis.net/ogc");
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

        public new static PropertyIsNotEqualTo Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsNotEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsNotEqualTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsNotEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsNotEqualTo Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsNotEqualTo, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsNotEqualTo(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsNotEqualToSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsNotEqualTo", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsLessThanSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsLessThan: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsLessThan(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsLessThan, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsLessThan() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsLessThan(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsLessThan", "http://www.opengis.net/ogc");
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

        public new static PropertyIsLessThan Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsLessThan, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsLessThan Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsLessThan, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsLessThan Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsLessThan, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsLessThan(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsLessThanSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsLessThan", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsGreaterThanSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsGreaterThan: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsGreaterThan(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsGreaterThan, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsGreaterThan() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsGreaterThan(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsGreaterThan", "http://www.opengis.net/ogc");
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

        public new static PropertyIsGreaterThan Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsGreaterThan, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsGreaterThan Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsGreaterThan, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsGreaterThan Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsGreaterThan, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsGreaterThan(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsGreaterThanSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsGreaterThan", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsLessThanOrEqualToSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsLessThanOrEqualTo: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsLessThanOrEqualTo(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsLessThanOrEqualTo, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsLessThanOrEqualTo() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsLessThanOrEqualTo(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc");
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

        public new static PropertyIsLessThanOrEqualTo Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsLessThanOrEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsLessThanOrEqualTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsLessThanOrEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsLessThanOrEqualTo Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsLessThanOrEqualTo, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsLessThanOrEqualTo(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsLessThanOrEqualToSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsLessThanOrEqualTo", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsGreaterThanOrEqualToSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsGreaterThanOrEqualTo: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryComparisonOpType ContentField;

        public static explicit operator PropertyIsGreaterThanOrEqualTo(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsGreaterThanOrEqualTo, BinaryComparisonOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsGreaterThanOrEqualTo() :
            base(true)
        {
            SetInnerType(new BinaryComparisonOpType());
        }

        public PropertyIsGreaterThanOrEqualTo(BinaryComparisonOpType content) :
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

        public new BinaryComparisonOpType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression+)
        /// </para>
        /// </summary>
        public IList<expression> expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc");
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

        public new static PropertyIsGreaterThanOrEqualTo Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsGreaterThanOrEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsGreaterThanOrEqualTo Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsGreaterThanOrEqualTo, BinaryComparisonOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsGreaterThanOrEqualTo Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsGreaterThanOrEqualTo, BinaryComparisonOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsGreaterThanOrEqualTo(((BinaryComparisonOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryComparisonOpType ContentField)
        {
            this.ContentField=((BinaryComparisonOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsGreaterThanOrEqualToSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsGreaterThanOrEqualTo", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsLikeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsLike: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyIsLikeType ContentField;

        public static explicit operator PropertyIsLike(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsLike, PropertyIsLikeType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsLike() :
            base(true)
        {
            SetInnerType(new PropertyIsLikeType());
        }

        public PropertyIsLike(PropertyIsLikeType content) :
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

        public new PropertyIsLikeType Content
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
        /// Regular expression: (PropertyName, Literal)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
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
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, Literal)
        /// </para>
        /// </summary>
        public Literal Literal
        {
            get
            {
                return this.ContentField.Literal;
            }
            set
            {
                this.ContentField.Literal=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string wildCard
        {
            get
            {
                return this.ContentField.wildCard;
            }
            set
            {
                this.ContentField.wildCard=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string singleChar
        {
            get
            {
                return this.ContentField.singleChar;
            }
            set
            {
                this.ContentField.singleChar=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// </summary>
        public string escapeChar
        {
            get
            {
                return this.ContentField.escapeChar;
            }
            set
            {
                this.ContentField.escapeChar=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool matchCase
        {
            get
            {
                return this.ContentField.matchCase;
            }
            set
            {
                this.ContentField.matchCase=value;
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
                return XName.Get("PropertyIsLike", "http://www.opengis.net/ogc");
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

        public new static PropertyIsLike Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsLike, PropertyIsLikeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsLike Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsLike, PropertyIsLikeType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsLike Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsLike, PropertyIsLikeType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsLike(((PropertyIsLikeType)(this.Content.Clone())));
        }

        private void SetInnerType(PropertyIsLikeType ContentField)
        {
            this.ContentField=((PropertyIsLikeType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsLikeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsLike", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsNullSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsNull: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyIsNullType ContentField;

        public static explicit operator PropertyIsNull(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsNull, PropertyIsNullType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsNull() :
            base(true)
        {
            SetInnerType(new PropertyIsNullType());
        }

        public PropertyIsNull(PropertyIsNullType content) :
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

        public new PropertyIsNullType Content
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
        /// Regular expression: (PropertyName)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
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
                return XName.Get("PropertyIsNull", "http://www.opengis.net/ogc");
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

        public new static PropertyIsNull Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsNull, PropertyIsNullType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsNull Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsNull, PropertyIsNullType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsNull Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsNull, PropertyIsNullType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsNull(((PropertyIsNullType)(this.Content.Clone())));
        }

        private void SetInnerType(PropertyIsNullType ContentField)
        {
            this.ContentField=((PropertyIsNullType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsNullSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsNull", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("PropertyIsBetweenSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class PropertyIsBetween: global::GeoSik.Ogc.Filter.V110.comparisonOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyIsBetweenType ContentField;

        public static explicit operator PropertyIsBetween(XElement xe) { return XTypedServices.ToXTypedElement<PropertyIsBetween, PropertyIsBetweenType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public PropertyIsBetween() :
            base(true)
        {
            SetInnerType(new PropertyIsBetweenType());
        }

        public PropertyIsBetween(PropertyIsBetweenType content) :
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

        public new PropertyIsBetweenType Content
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
        /// Substitution members: expression, Add, Sub, Mul, Div, PropertyName, Function, Literal
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public expression expression
        {
            get
            {
                return this.ContentField.expression;
            }
            set
            {
                this.ContentField.expression=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public LowerBoundaryType LowerBoundary
        {
            get
            {
                return this.ContentField.LowerBoundary;
            }
            set
            {
                this.ContentField.LowerBoundary=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (expression, LowerBoundary, UpperBoundary)
        /// </para>
        /// </summary>
        public UpperBoundaryType UpperBoundary
        {
            get
            {
                return this.ContentField.UpperBoundary;
            }
            set
            {
                this.ContentField.UpperBoundary=value;
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
                return XName.Get("PropertyIsBetween", "http://www.opengis.net/ogc");
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

        public new static PropertyIsBetween Load(string xmlFile)
        {
            return XTypedServices.Load<PropertyIsBetween, PropertyIsBetweenType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static PropertyIsBetween Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<PropertyIsBetween, PropertyIsBetweenType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static PropertyIsBetween Parse(string xml)
        {
            return XTypedServices.Parse<PropertyIsBetween, PropertyIsBetweenType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new PropertyIsBetween(((PropertyIsBetweenType)(this.Content.Clone())));
        }

        private void SetInnerType(PropertyIsBetweenType ContentField)
        {
            this.ContentField=((PropertyIsBetweenType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType PropertyIsBetweenSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("PropertyIsBetween", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("spatialOpsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class spatialOps: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SpatialOpsType ContentField;

        public static explicit operator spatialOps(XElement xe) { return (spatialOps)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected spatialOps(bool setNull)
        {
        }

        public spatialOps()
        {
            throw new InvalidOperationException();
        }

        public spatialOps(SpatialOpsType content)
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

        public SpatialOpsType Content
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
                return XName.Get("spatialOps", "http://www.opengis.net/ogc");
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

        public static spatialOps Load(string xmlFile)
        {
            return ((spatialOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static spatialOps Load(System.IO.TextReader xmlFile)
        {
            return ((spatialOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static spatialOps Parse(string xml)
        {
            return ((spatialOps)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(SpatialOpsType ContentField)
        {
            this.ContentField=((SpatialOpsType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(SpatialOpsType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType spatialOpsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("spatialOps", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("EqualsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Equals: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Equals(XElement xe) { return XTypedServices.ToXTypedElement<Equals, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Equals() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Equals(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Equals", "http://www.opengis.net/ogc");
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

        public new static Equals Load(string xmlFile)
        {
            return XTypedServices.Load<Equals, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Equals Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Equals, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Equals Parse(string xml)
        {
            return XTypedServices.Parse<Equals, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Equals(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType EqualsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Equals", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("DisjointSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Disjoint: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Disjoint(XElement xe) { return XTypedServices.ToXTypedElement<Disjoint, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Disjoint() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Disjoint(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Disjoint", "http://www.opengis.net/ogc");
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

        public new static Disjoint Load(string xmlFile)
        {
            return XTypedServices.Load<Disjoint, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Disjoint Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Disjoint, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Disjoint Parse(string xml)
        {
            return XTypedServices.Parse<Disjoint, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Disjoint(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DisjointSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Disjoint", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("TouchesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Touches: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Touches(XElement xe) { return XTypedServices.ToXTypedElement<Touches, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Touches() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Touches(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Touches", "http://www.opengis.net/ogc");
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

        public new static Touches Load(string xmlFile)
        {
            return XTypedServices.Load<Touches, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Touches Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Touches, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Touches Parse(string xml)
        {
            return XTypedServices.Parse<Touches, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Touches(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType TouchesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Touches", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("WithinSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Within: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Within(XElement xe) { return XTypedServices.ToXTypedElement<Within, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Within() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Within(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Within", "http://www.opengis.net/ogc");
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

        public new static Within Load(string xmlFile)
        {
            return XTypedServices.Load<Within, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Within Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Within, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Within Parse(string xml)
        {
            return XTypedServices.Parse<Within, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Within(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType WithinSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Within", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("OverlapsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Overlaps: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Overlaps(XElement xe) { return XTypedServices.ToXTypedElement<Overlaps, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Overlaps() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Overlaps(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Overlaps", "http://www.opengis.net/ogc");
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

        public new static Overlaps Load(string xmlFile)
        {
            return XTypedServices.Load<Overlaps, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Overlaps Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Overlaps, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Overlaps Parse(string xml)
        {
            return XTypedServices.Parse<Overlaps, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Overlaps(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType OverlapsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Overlaps", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("CrossesSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Crosses: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Crosses(XElement xe) { return XTypedServices.ToXTypedElement<Crosses, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Crosses() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Crosses(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Crosses", "http://www.opengis.net/ogc");
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

        public new static Crosses Load(string xmlFile)
        {
            return XTypedServices.Load<Crosses, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Crosses Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Crosses, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Crosses Parse(string xml)
        {
            return XTypedServices.Parse<Crosses, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Crosses(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType CrossesSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Crosses", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("IntersectsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Intersects: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Intersects(XElement xe) { return XTypedServices.ToXTypedElement<Intersects, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Intersects() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Intersects(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Intersects", "http://www.opengis.net/ogc");
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

        public new static Intersects Load(string xmlFile)
        {
            return XTypedServices.Load<Intersects, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Intersects Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Intersects, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Intersects Parse(string xml)
        {
            return XTypedServices.Parse<Intersects, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Intersects(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType IntersectsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Intersects", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("ContainsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Contains: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinarySpatialOpType ContentField;

        public static explicit operator Contains(XElement xe) { return XTypedServices.ToXTypedElement<Contains, BinarySpatialOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Contains() :
            base(true)
        {
            SetInnerType(new BinarySpatialOpType());
        }

        public Contains(BinarySpatialOpType content) :
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

        public new BinarySpatialOpType Content
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public IList<PropertyName> PropertyName
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
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
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
        /// Regular expression: (PropertyName, (PropertyName | _Geometry | Envelope))
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("Contains", "http://www.opengis.net/ogc");
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

        public new static Contains Load(string xmlFile)
        {
            return XTypedServices.Load<Contains, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Contains Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Contains, BinarySpatialOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Contains Parse(string xml)
        {
            return XTypedServices.Parse<Contains, BinarySpatialOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Contains(((BinarySpatialOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinarySpatialOpType ContentField)
        {
            this.ContentField=((BinarySpatialOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType ContainsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Contains", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("DWithinSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class DWithin: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DistanceBufferType ContentField;

        public static explicit operator DWithin(XElement xe) { return XTypedServices.ToXTypedElement<DWithin, DistanceBufferType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public DWithin() :
            base(true)
        {
            SetInnerType(new DistanceBufferType());
        }

        public DWithin(DistanceBufferType content) :
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

        public new DistanceBufferType Content
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
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
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
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public DistanceType Distance
        {
            get
            {
                return this.ContentField.Distance;
            }
            set
            {
                this.ContentField.Distance=value;
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
                return XName.Get("DWithin", "http://www.opengis.net/ogc");
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

        public new static DWithin Load(string xmlFile)
        {
            return XTypedServices.Load<DWithin, DistanceBufferType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static DWithin Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<DWithin, DistanceBufferType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static DWithin Parse(string xml)
        {
            return XTypedServices.Parse<DWithin, DistanceBufferType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new DWithin(((DistanceBufferType)(this.Content.Clone())));
        }

        private void SetInnerType(DistanceBufferType ContentField)
        {
            this.ContentField=((DistanceBufferType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType DWithinSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("DWithin", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("BeyondSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Beyond: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DistanceBufferType ContentField;

        public static explicit operator Beyond(XElement xe) { return XTypedServices.ToXTypedElement<Beyond, DistanceBufferType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Beyond() :
            base(true)
        {
            SetInnerType(new DistanceBufferType());
        }

        public Beyond(DistanceBufferType content) :
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

        public new DistanceBufferType Content
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
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
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
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Substitution members: _Geometry, _GeometricPrimitive, Point, _Curve, LineString, _Surface, Polygon, _Ring, LinearRing, Curve, OrientableCurve, Surface, OrientableSurface, Ring, PolyhedralSurface, TriangulatedSurface, Tin, _Solid, Solid, _GeometricAggregate, MultiGeometry, MultiPoint, MultiCurve, MultiSurface, MultiSolid, MultiPolygon, MultiLineString
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311._Geometry _Geometry
        {
            get
            {
                return this.ContentField._Geometry;
            }
            set
            {
                this.ContentField._Geometry=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName, _Geometry, Distance)
        /// </para>
        /// </summary>
        public DistanceType Distance
        {
            get
            {
                return this.ContentField.Distance;
            }
            set
            {
                this.ContentField.Distance=value;
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
                return XName.Get("Beyond", "http://www.opengis.net/ogc");
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

        public new static Beyond Load(string xmlFile)
        {
            return XTypedServices.Load<Beyond, DistanceBufferType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Beyond Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Beyond, DistanceBufferType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Beyond Parse(string xml)
        {
            return XTypedServices.Parse<Beyond, DistanceBufferType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Beyond(((DistanceBufferType)(this.Content.Clone())));
        }

        private void SetInnerType(DistanceBufferType ContentField)
        {
            this.ContentField=((DistanceBufferType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BeyondSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Beyond", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("BBOXSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class BBOX: global::GeoSik.Ogc.Filter.V110.spatialOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BBOXType ContentField;

        public static explicit operator BBOX(XElement xe) { return XTypedServices.ToXTypedElement<BBOX, BBOXType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public BBOX() :
            base(true)
        {
            SetInnerType(new BBOXType());
        }

        public BBOX(BBOXType content) :
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

        public new BBOXType Content
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
        /// Regular expression: (PropertyName?, Envelope)
        /// </para>
        /// </summary>
        public PropertyName PropertyName
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
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (PropertyName?, Envelope)
        /// </para>
        /// </summary>
        public GeoSik.Ogc.Gml.V311.Envelope Envelope
        {
            get
            {
                return this.ContentField.Envelope;
            }
            set
            {
                this.ContentField.Envelope=value;
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
                return XName.Get("BBOX", "http://www.opengis.net/ogc");
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

        public new static BBOX Load(string xmlFile)
        {
            return XTypedServices.Load<BBOX, BBOXType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static BBOX Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<BBOX, BBOXType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static BBOX Parse(string xml)
        {
            return XTypedServices.Parse<BBOX, BBOXType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new BBOX(((BBOXType)(this.Content.Clone())));
        }

        private void SetInnerType(BBOXType ContentField)
        {
            this.ContentField=((BBOXType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType BBOXSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("BBOX", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("logicOpsSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public abstract partial class logicOps: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LogicOpsType ContentField;

        public static explicit operator logicOps(XElement xe) { return (logicOps)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected logicOps(bool setNull)
        {
        }

        public logicOps()
        {
            throw new InvalidOperationException();
        }

        public logicOps(LogicOpsType content)
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

        public LogicOpsType Content
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
                return XName.Get("logicOps", "http://www.opengis.net/ogc");
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

        public static logicOps Load(string xmlFile)
        {
            return ((logicOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static logicOps Load(System.IO.TextReader xmlFile)
        {
            return ((logicOps)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static logicOps Parse(string xml)
        {
            return ((logicOps)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        private void SetInnerType(LogicOpsType ContentField)
        {
            this.ContentField=((LogicOpsType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(LogicOpsType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType logicOpsSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("logicOps", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("AndSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class And: global::GeoSik.Ogc.Filter.V110.logicOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryLogicOpType ContentField;

        public static explicit operator And(XElement xe) { return XTypedServices.ToXTypedElement<And, BinaryLogicOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public And() :
            base(true)
        {
            SetInnerType(new BinaryLogicOpType());
        }

        public And(BinaryLogicOpType content) :
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

        public new BinaryLogicOpType Content
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
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<comparisonOps> comparisonOps
        {
            get
            {
                return this.ContentField.comparisonOps;
            }
            set
            {
                this.ContentField.comparisonOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<spatialOps> spatialOps
        {
            get
            {
                return this.ContentField.spatialOps;
            }
            set
            {
                this.ContentField.spatialOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<logicOps> logicOps
        {
            get
            {
                return this.ContentField.logicOps;
            }
            set
            {
                this.ContentField.logicOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<Function> Function
        {
            get
            {
                return this.ContentField.Function;
            }
            set
            {
                this.ContentField.Function=value;
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
                return XName.Get("And", "http://www.opengis.net/ogc");
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

        public new static And Load(string xmlFile)
        {
            return XTypedServices.Load<And, BinaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static And Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<And, BinaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static And Parse(string xml)
        {
            return XTypedServices.Parse<And, BinaryLogicOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new And(((BinaryLogicOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryLogicOpType ContentField)
        {
            this.ContentField=((BinaryLogicOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType AndSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("And", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("OrSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Or: global::GeoSik.Ogc.Filter.V110.logicOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BinaryLogicOpType ContentField;

        public static explicit operator Or(XElement xe) { return XTypedServices.ToXTypedElement<Or, BinaryLogicOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Or() :
            base(true)
        {
            SetInnerType(new BinaryLogicOpType());
        }

        public Or(BinaryLogicOpType content) :
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

        public new BinaryLogicOpType Content
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
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<comparisonOps> comparisonOps
        {
            get
            {
                return this.ContentField.comparisonOps;
            }
            set
            {
                this.ContentField.comparisonOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<spatialOps> spatialOps
        {
            get
            {
                return this.ContentField.spatialOps;
            }
            set
            {
                this.ContentField.spatialOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<logicOps> logicOps
        {
            get
            {
                return this.ContentField.logicOps;
            }
            set
            {
                this.ContentField.logicOps=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: required, choice
        /// </para>
        /// <para>
        /// Regular expression: (comparisonOps | spatialOps | logicOps | Function)+
        /// </para>
        /// </summary>
        public IList<Function> Function
        {
            get
            {
                return this.ContentField.Function;
            }
            set
            {
                this.ContentField.Function=value;
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
                return XName.Get("Or", "http://www.opengis.net/ogc");
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

        public new static Or Load(string xmlFile)
        {
            return XTypedServices.Load<Or, BinaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Or Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Or, BinaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Or Parse(string xml)
        {
            return XTypedServices.Parse<Or, BinaryLogicOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Or(((BinaryLogicOpType)(this.Content.Clone())));
        }

        private void SetInnerType(BinaryLogicOpType ContentField)
        {
            this.ContentField=((BinaryLogicOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType OrSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Or", "http://www.opengis.net/ogc")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("NotSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class Not: global::GeoSik.Ogc.Filter.V110.logicOps, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private UnaryLogicOpType ContentField;

        public static explicit operator Not(XElement xe) { return XTypedServices.ToXTypedElement<Not, UnaryLogicOpType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        public Not() :
            base(true)
        {
            SetInnerType(new UnaryLogicOpType());
        }

        public Not(UnaryLogicOpType content) :
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

        public new UnaryLogicOpType Content
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
        /// Substitution members: comparisonOps, PropertyIsEqualTo, PropertyIsNotEqualTo, PropertyIsLessThan, PropertyIsGreaterThan, PropertyIsLessThanOrEqualTo, PropertyIsGreaterThanOrEqualTo, PropertyIsLike, PropertyIsNull, PropertyIsBetween
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public comparisonOps comparisonOps
        {
            get
            {
                return this.ContentField.comparisonOps;
            }
            set
            {
                this.ContentField.comparisonOps=value;
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
        /// Substitution members: spatialOps, Equals, Disjoint, Touches, Within, Overlaps, Crosses, Intersects, Contains, DWithin, Beyond, BBOX
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public spatialOps spatialOps
        {
            get
            {
                return this.ContentField.spatialOps;
            }
            set
            {
                this.ContentField.spatialOps=value;
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
        /// Substitution members: logicOps, And, Or, Not
        /// </para>
        /// <para>
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public logicOps logicOps
        {
            get
            {
                return this.ContentField.logicOps;
            }
            set
            {
                this.ContentField.logicOps=value;
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
        /// Regular expression: ((comparisonOps | spatialOps | logicOps | Function))
        /// </para>
        /// </summary>
        public Function Function
        {
            get
            {
                return this.ContentField.Function;
            }
            set
            {
                this.ContentField.Function=value;
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
                return XName.Get("Not", "http://www.opengis.net/ogc");
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

        public new static Not Load(string xmlFile)
        {
            return XTypedServices.Load<Not, UnaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public static Not Load(System.IO.TextReader xmlFile)
        {
            return XTypedServices.Load<Not, UnaryLogicOpType>(xmlFile, LinqToXsdTypeManager.Instance);
        }

        public new static Not Parse(string xml)
        {
            return XTypedServices.Parse<Not, UnaryLogicOpType>(xml, LinqToXsdTypeManager.Instance);
        }

        public override XTypedElement Clone()
        {
            return new Not(((UnaryLogicOpType)(this.Content.Clone())));
        }

        private void SetInnerType(UnaryLogicOpType ContentField)
        {
            this.ContentField=((UnaryLogicOpType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
            base.SetSubstitutionMember(ContentField);
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType NotSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("Not", "http://www.opengis.net/ogc")]));
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


        public Filter_Capabilities Filter_Capabilities { get { return rootObject as Filter_Capabilities; } }

        public LogicalOperators LogicalOperators { get { return rootObject as LogicalOperators; } }

        public SimpleArithmetic SimpleArithmetic { get { return rootObject as SimpleArithmetic; } }

        public EID EID { get { return rootObject as EID; } }

        public FID FID { get { return rootObject as FID; } }

        public Add Add { get { return rootObject as Add; } }

        public Sub Sub { get { return rootObject as Sub; } }

        public Mul Mul { get { return rootObject as Mul; } }

        public Div Div { get { return rootObject as Div; } }

        public PropertyName PropertyName { get { return rootObject as PropertyName; } }

        public Function Function { get { return rootObject as Function; } }

        public Literal Literal { get { return rootObject as Literal; } }

        public expression expression { get { return rootObject as expression; } }

        public SortBy SortBy { get { return rootObject as SortBy; } }

        public _Id _Id { get { return rootObject as _Id; } }

        public FeatureId FeatureId { get { return rootObject as FeatureId; } }

        public GmlObjectId GmlObjectId { get { return rootObject as GmlObjectId; } }

        public Filter Filter { get { return rootObject as Filter; } }

        public comparisonOps comparisonOps { get { return rootObject as comparisonOps; } }

        public PropertyIsEqualTo PropertyIsEqualTo { get { return rootObject as PropertyIsEqualTo; } }

        public PropertyIsNotEqualTo PropertyIsNotEqualTo { get { return rootObject as PropertyIsNotEqualTo; } }

        public PropertyIsLessThan PropertyIsLessThan { get { return rootObject as PropertyIsLessThan; } }

        public PropertyIsGreaterThan PropertyIsGreaterThan { get { return rootObject as PropertyIsGreaterThan; } }

        public PropertyIsLessThanOrEqualTo PropertyIsLessThanOrEqualTo { get { return rootObject as PropertyIsLessThanOrEqualTo; } }

        public PropertyIsGreaterThanOrEqualTo PropertyIsGreaterThanOrEqualTo { get { return rootObject as PropertyIsGreaterThanOrEqualTo; } }

        public PropertyIsLike PropertyIsLike { get { return rootObject as PropertyIsLike; } }

        public PropertyIsNull PropertyIsNull { get { return rootObject as PropertyIsNull; } }

        public PropertyIsBetween PropertyIsBetween { get { return rootObject as PropertyIsBetween; } }

        public spatialOps spatialOps { get { return rootObject as spatialOps; } }

        public Equals Equals { get { return rootObject as Equals; } }

        public Disjoint Disjoint { get { return rootObject as Disjoint; } }

        public Touches Touches { get { return rootObject as Touches; } }

        public Within Within { get { return rootObject as Within; } }

        public Overlaps Overlaps { get { return rootObject as Overlaps; } }

        public Crosses Crosses { get { return rootObject as Crosses; } }

        public Intersects Intersects { get { return rootObject as Intersects; } }

        public Contains Contains { get { return rootObject as Contains; } }

        public DWithin DWithin { get { return rootObject as DWithin; } }

        public Beyond Beyond { get { return rootObject as Beyond; } }

        public BBOX BBOX { get { return rootObject as BBOX; } }

        public logicOps logicOps { get { return rootObject as logicOps; } }

        public And And { get { return rootObject as And; } }

        public Or Or { get { return rootObject as Or; } }

        public Not Not { get { return rootObject as Not; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(Filter_Capabilities root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(LogicalOperators root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(SimpleArithmetic root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(EID root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(FID root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Add root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Sub root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Mul root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Div root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyName root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Function root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Literal root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(expression root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(SortBy root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(_Id root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(FeatureId root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(GmlObjectId root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Filter root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(comparisonOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsNotEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsLessThan root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsGreaterThan root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsLessThanOrEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsGreaterThanOrEqualTo root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsLike root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsNull root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(PropertyIsBetween root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(spatialOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Equals root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Disjoint root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Touches root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Within root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Overlaps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Crosses root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Intersects root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Contains root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(DWithin root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Beyond root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(BBOX root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(logicOps root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(And root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Or root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(Not root)
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
#pragma warning restore 108, 114, 3002, 3003, 3008, 3009
