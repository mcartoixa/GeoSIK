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
namespace OgcToolkit.W3.Smil20.Language
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
    using OgcToolkit.Ogc.Gml.V311;


    /// <summary>
    /// <para>
    /// Regular expression: (any)*
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("animateTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animateType: global::OgcToolkit.W3.Smil20.animatePrototype, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncToleranceDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string calcModeDefaultValue="linear";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool skipcontentDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator animateType(XElement xe) { return XTypedServices.ToXTypedElement<animateType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static animateType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
        /// </para>
        /// </summary>
        public animateType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("class", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("class", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("alt", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("alt", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("longdesc", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("longdesc", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("begin", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("begin", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("end", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("end", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("dur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("dur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatDur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatDur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatCount", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatCount", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeat", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("min", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("min", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("max", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("max", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehavior", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehavior", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncTolerance", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("syncTolerance", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehaviorDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehaviorDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncToleranceDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncToleranceDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncToleranceDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restart", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restart", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restartDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restartDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fill", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fill", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fillDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fillDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("targetElement", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("targetElement", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("calcMode", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, calcModeDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("calcMode", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("skip-content", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, skipcontentDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("skip-content", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("animateType", "http://www.w3.org/2001/SMIL20/Language");
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
            return XTypedServices.CloneXTypedElement<animateType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##other", "http://www.w3.org/2001/SMIL20/Language"), 1)));
            validationStates=new FSM(1, new Set<int>(1), transitions);
        }

        public static XmlQualifiedName animateTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("animateType", "http://www.w3.org/2001/SMIL20/Language");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (any)*
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("animateMotionTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animateMotionType: global::OgcToolkit.W3.Smil20.animateMotionPrototype, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncToleranceDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string calcModeDefaultValue="linear";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool skipcontentDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator animateMotionType(XElement xe) { return XTypedServices.ToXTypedElement<animateMotionType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static animateMotionType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
        /// </para>
        /// </summary>
        public animateMotionType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("class", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("class", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("alt", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("alt", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("longdesc", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("longdesc", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("begin", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("begin", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("end", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("end", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("dur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("dur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatDur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatDur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatCount", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatCount", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeat", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("min", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("min", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("max", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("max", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehavior", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehavior", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncTolerance", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("syncTolerance", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehaviorDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehaviorDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncToleranceDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncToleranceDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncToleranceDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restart", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restart", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restartDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restartDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fill", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fill", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fillDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fillDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("targetElement", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("targetElement", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("calcMode", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, calcModeDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("calcMode", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("skip-content", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, skipcontentDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("skip-content", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("animateMotionType", "http://www.w3.org/2001/SMIL20/Language");
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
            return XTypedServices.CloneXTypedElement<animateMotionType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##other", "http://www.w3.org/2001/SMIL20/Language"), 1)));
            validationStates=new FSM(1, new Set<int>(1), transitions);
        }

        public static XmlQualifiedName animateMotionTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("animateMotionType", "http://www.w3.org/2001/SMIL20/Language");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (any)*
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("animateColorTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animateColorType: global::OgcToolkit.W3.Smil20.animateColorPrototype, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncToleranceDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string calcModeDefaultValue="linear";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool skipcontentDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator animateColorType(XElement xe) { return XTypedServices.ToXTypedElement<animateColorType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static animateColorType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
        /// </para>
        /// </summary>
        public animateColorType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("class", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("class", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("alt", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("alt", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("longdesc", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("longdesc", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("begin", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("begin", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("end", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("end", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("dur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("dur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatDur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatDur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatCount", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatCount", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeat", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("min", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("min", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("max", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("max", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehavior", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehavior", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncTolerance", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("syncTolerance", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehaviorDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehaviorDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncToleranceDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncToleranceDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncToleranceDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restart", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restart", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restartDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restartDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fill", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fill", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fillDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fillDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("targetElement", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("targetElement", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("calcMode", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, calcModeDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("calcMode", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("skip-content", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, skipcontentDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("skip-content", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("animateColorType", "http://www.w3.org/2001/SMIL20/Language");
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
            return XTypedServices.CloneXTypedElement<animateColorType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##other", "http://www.w3.org/2001/SMIL20/Language"), 1)));
            validationStates=new FSM(1, new Set<int>(1), transitions);
        }

        public static XmlQualifiedName animateColorTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("animateColorType", "http://www.w3.org/2001/SMIL20/Language");
        }
    }

    /// <summary>
    /// <para>
    /// Regular expression: (any)*
    /// </para>
    /// </summary>
    [XmlSchemaProviderAttribute("setTypeSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class setType: global::OgcToolkit.W3.Smil20.setPrototype, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncBehaviorDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string syncToleranceDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string restartDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultValue="default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static string fillDefaultDefaultValue="inherit";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool skipcontentDefaultValue=System.Xml.XmlConvert.ToBoolean("true");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FSM validationStates;

        public static explicit operator setType(XElement xe) { return XTypedServices.ToXTypedElement<setType>(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        static setType()
        {
            InitFSM();
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
        /// </para>
        /// </summary>
        public setType()
        {
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("class", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("class", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("lang", "http://www.w3.org/XML/1998/namespace"), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Language).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("alt", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("alt", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("longdesc", ""));
                return XTypedServices.ParseValue<System.Uri>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("longdesc", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyUri).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("begin", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("begin", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("end", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("end", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("dur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("dur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatDur", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatDur", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeatCount", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeatCount", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Decimal).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("repeat", ""));
                if ((x==null))
                {
                    return null;
                }
                return XTypedServices.ParseValue<decimal>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("repeat", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("min", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("min", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("max", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("max", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehavior", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehavior", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncTolerance", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("syncTolerance", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncBehaviorDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncBehaviorDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncBehaviorDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("syncToleranceDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, syncToleranceDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("syncToleranceDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restart", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restart", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("restartDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, restartDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("restartDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fill", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fill", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("fillDefault", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype, fillDefaultDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("fillDefault", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("targetElement", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
            set
            {
                this.SetAttribute(XName.Get("targetElement", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Idref).Datatype);
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                XAttribute x=this.Attribute(XName.Get("skip-content", ""));
                return XTypedServices.ParseValue<bool>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype, skipcontentDefaultValue);
            }
            set
            {
                this.SetAttribute(XName.Get("skip-content", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName
        {
            get
            {
                return XName.Get("setType", "http://www.w3.org/2001/SMIL20/Language");
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
            return XTypedServices.CloneXTypedElement<setType>(this);
        }

        FSM IXMetaData.GetValidationStates()
        {
            return validationStates;
        }

        private static void InitFSM()
        {
            Dictionary<int, Transitions> transitions=new Dictionary<int, Transitions>();
            transitions.Add(1, new Transitions(new SingleTransition(new WildCard("##other", "http://www.w3.org/2001/SMIL20/Language"), 1)));
            validationStates=new FSM(1, new Set<int>(1), transitions);
        }

        public static XmlQualifiedName setTypeSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            return new XmlQualifiedName("setType", "http://www.w3.org/2001/SMIL20/Language");
        }
    }

    [XmlSchemaProviderAttribute("animateSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animate: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private animateType ContentField;

        public static explicit operator animate(XElement xe) { return (animate)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected animate(bool setNull)
        {
        }

        public animate()
        {
            SetInnerType(new animateType());
        }

        public animate(animateType content)
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

        public animateType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                return this.ContentField.@class;
            }
            set
            {
                this.ContentField.@class=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                return this.ContentField.lang;
            }
            set
            {
                this.ContentField.lang=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                return this.ContentField.alt;
            }
            set
            {
                this.ContentField.alt=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                return this.ContentField.longdesc;
            }
            set
            {
                this.ContentField.longdesc=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                return this.ContentField.begin;
            }
            set
            {
                this.ContentField.begin=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                return this.ContentField.end;
            }
            set
            {
                this.ContentField.end=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                return this.ContentField.dur;
            }
            set
            {
                this.ContentField.dur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                return this.ContentField.repeatDur;
            }
            set
            {
                this.ContentField.repeatDur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                return this.ContentField.repeatCount;
            }
            set
            {
                this.ContentField.repeatCount=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                return this.ContentField.repeat;
            }
            set
            {
                this.ContentField.repeat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                return this.ContentField.min;
            }
            set
            {
                this.ContentField.min=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                return this.ContentField.max;
            }
            set
            {
                this.ContentField.max=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                return this.ContentField.syncBehavior;
            }
            set
            {
                this.ContentField.syncBehavior=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                return this.ContentField.syncTolerance;
            }
            set
            {
                this.ContentField.syncTolerance=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                return this.ContentField.syncBehaviorDefault;
            }
            set
            {
                this.ContentField.syncBehaviorDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                return this.ContentField.syncToleranceDefault;
            }
            set
            {
                this.ContentField.syncToleranceDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                return this.ContentField.restart;
            }
            set
            {
                this.ContentField.restart=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                return this.ContentField.restartDefault;
            }
            set
            {
                this.ContentField.restartDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                return this.ContentField.fill;
            }
            set
            {
                this.ContentField.fill=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                return this.ContentField.fillDefault;
            }
            set
            {
                this.ContentField.fillDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                return this.ContentField.targetElement;
            }
            set
            {
                this.ContentField.targetElement=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                return this.ContentField.calcMode;
            }
            set
            {
                this.ContentField.calcMode=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                return this.ContentField.skipcontent;
            }
            set
            {
                this.ContentField.skipcontent=value;
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
                return XName.Get("animate", "http://www.w3.org/2001/SMIL20/Language");
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

        public static animate Load(string xmlFile)
        {
            return ((animate)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animate Load(System.IO.TextReader xmlFile)
        {
            return ((animate)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animate Parse(string xml)
        {
            return ((animate)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new animate(((animateType)(this.Content.Clone())));
        }

        private void SetInnerType(animateType ContentField)
        {
            this.ContentField=((animateType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(animateType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType animateSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("animate", "http://www.w3.org/2001/SMIL20/Language")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("animateMotionSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animateMotion: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private animateMotionType ContentField;

        public static explicit operator animateMotion(XElement xe) { return (animateMotion)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected animateMotion(bool setNull)
        {
        }

        public animateMotion()
        {
            SetInnerType(new animateMotionType());
        }

        public animateMotion(animateMotionType content)
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

        public animateMotionType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                return this.ContentField.@class;
            }
            set
            {
                this.ContentField.@class=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                return this.ContentField.lang;
            }
            set
            {
                this.ContentField.lang=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                return this.ContentField.alt;
            }
            set
            {
                this.ContentField.alt=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                return this.ContentField.longdesc;
            }
            set
            {
                this.ContentField.longdesc=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                return this.ContentField.begin;
            }
            set
            {
                this.ContentField.begin=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                return this.ContentField.end;
            }
            set
            {
                this.ContentField.end=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                return this.ContentField.dur;
            }
            set
            {
                this.ContentField.dur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                return this.ContentField.repeatDur;
            }
            set
            {
                this.ContentField.repeatDur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                return this.ContentField.repeatCount;
            }
            set
            {
                this.ContentField.repeatCount=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                return this.ContentField.repeat;
            }
            set
            {
                this.ContentField.repeat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                return this.ContentField.min;
            }
            set
            {
                this.ContentField.min=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                return this.ContentField.max;
            }
            set
            {
                this.ContentField.max=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                return this.ContentField.syncBehavior;
            }
            set
            {
                this.ContentField.syncBehavior=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                return this.ContentField.syncTolerance;
            }
            set
            {
                this.ContentField.syncTolerance=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                return this.ContentField.syncBehaviorDefault;
            }
            set
            {
                this.ContentField.syncBehaviorDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                return this.ContentField.syncToleranceDefault;
            }
            set
            {
                this.ContentField.syncToleranceDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                return this.ContentField.restart;
            }
            set
            {
                this.ContentField.restart=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                return this.ContentField.restartDefault;
            }
            set
            {
                this.ContentField.restartDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                return this.ContentField.fill;
            }
            set
            {
                this.ContentField.fill=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                return this.ContentField.fillDefault;
            }
            set
            {
                this.ContentField.fillDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                return this.ContentField.targetElement;
            }
            set
            {
                this.ContentField.targetElement=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                return this.ContentField.calcMode;
            }
            set
            {
                this.ContentField.calcMode=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                return this.ContentField.skipcontent;
            }
            set
            {
                this.ContentField.skipcontent=value;
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
                return XName.Get("animateMotion", "http://www.w3.org/2001/SMIL20/Language");
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

        public static animateMotion Load(string xmlFile)
        {
            return ((animateMotion)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animateMotion Load(System.IO.TextReader xmlFile)
        {
            return ((animateMotion)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animateMotion Parse(string xml)
        {
            return ((animateMotion)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new animateMotion(((animateMotionType)(this.Content.Clone())));
        }

        private void SetInnerType(animateMotionType ContentField)
        {
            this.ContentField=((animateMotionType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(animateMotionType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType animateMotionSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("animateMotion", "http://www.w3.org/2001/SMIL20/Language")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("animateColorSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class animateColor: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private animateColorType ContentField;

        public static explicit operator animateColor(XElement xe) { return (animateColor)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected animateColor(bool setNull)
        {
        }

        public animateColor()
        {
            SetInnerType(new animateColorType());
        }

        public animateColor(animateColorType content)
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

        public animateColorType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                return this.ContentField.@class;
            }
            set
            {
                this.ContentField.@class=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                return this.ContentField.lang;
            }
            set
            {
                this.ContentField.lang=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                return this.ContentField.alt;
            }
            set
            {
                this.ContentField.alt=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                return this.ContentField.longdesc;
            }
            set
            {
                this.ContentField.longdesc=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                return this.ContentField.begin;
            }
            set
            {
                this.ContentField.begin=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                return this.ContentField.end;
            }
            set
            {
                this.ContentField.end=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                return this.ContentField.dur;
            }
            set
            {
                this.ContentField.dur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                return this.ContentField.repeatDur;
            }
            set
            {
                this.ContentField.repeatDur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                return this.ContentField.repeatCount;
            }
            set
            {
                this.ContentField.repeatCount=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                return this.ContentField.repeat;
            }
            set
            {
                this.ContentField.repeat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                return this.ContentField.min;
            }
            set
            {
                this.ContentField.min=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                return this.ContentField.max;
            }
            set
            {
                this.ContentField.max=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                return this.ContentField.syncBehavior;
            }
            set
            {
                this.ContentField.syncBehavior=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                return this.ContentField.syncTolerance;
            }
            set
            {
                this.ContentField.syncTolerance=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                return this.ContentField.syncBehaviorDefault;
            }
            set
            {
                this.ContentField.syncBehaviorDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                return this.ContentField.syncToleranceDefault;
            }
            set
            {
                this.ContentField.syncToleranceDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                return this.ContentField.restart;
            }
            set
            {
                this.ContentField.restart=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                return this.ContentField.restartDefault;
            }
            set
            {
                this.ContentField.restartDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                return this.ContentField.fill;
            }
            set
            {
                this.ContentField.fill=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                return this.ContentField.fillDefault;
            }
            set
            {
                this.ContentField.fillDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                return this.ContentField.targetElement;
            }
            set
            {
                this.ContentField.targetElement=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string calcMode
        {
            get
            {
                return this.ContentField.calcMode;
            }
            set
            {
                this.ContentField.calcMode=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                return this.ContentField.skipcontent;
            }
            set
            {
                this.ContentField.skipcontent=value;
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
                return XName.Get("animateColor", "http://www.w3.org/2001/SMIL20/Language");
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

        public static animateColor Load(string xmlFile)
        {
            return ((animateColor)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animateColor Load(System.IO.TextReader xmlFile)
        {
            return ((animateColor)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static animateColor Parse(string xml)
        {
            return ((animateColor)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new animateColor(((animateColorType)(this.Content.Clone())));
        }

        private void SetInnerType(animateColorType ContentField)
        {
            this.ContentField=((animateColorType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(animateColorType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType animateColorSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("animateColor", "http://www.w3.org/2001/SMIL20/Language")]));
            if ((element!=null))
            {
                return element.ElementSchemaType;
            }
            return null;
        }
    }

    [XmlSchemaProviderAttribute("setSchemaProvider")]
    [System.CodeDom.Compiler.GeneratedCode("LinqToXsd", "2.0.2")]
    public partial class set: XTypedElement, IXMetaData, IXmlSerializable
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private setType ContentField;

        public static explicit operator set(XElement xe) { return (set)XTypedServices.ToXTypedElement(xe, LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }

        protected set(bool setNull)
        {
        }

        public set()
        {
            SetInnerType(new setType());
        }

        public set(setType content)
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

        public setType Content
        {
            get
            {
                return ContentField;
            }
        }

        /// <summary>
        /// <para>
        /// Regular expression: (any)*
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
        public string @class
        {
            get
            {
                return this.ContentField.@class;
            }
            set
            {
                this.ContentField.@class=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string lang
        {
            get
            {
                return this.ContentField.lang;
            }
            set
            {
                this.ContentField.lang=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string alt
        {
            get
            {
                return this.ContentField.alt;
            }
            set
            {
                this.ContentField.alt=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Uri longdesc
        {
            get
            {
                return this.ContentField.longdesc;
            }
            set
            {
                this.ContentField.longdesc=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string begin
        {
            get
            {
                return this.ContentField.begin;
            }
            set
            {
                this.ContentField.begin=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string end
        {
            get
            {
                return this.ContentField.end;
            }
            set
            {
                this.ContentField.end=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string dur
        {
            get
            {
                return this.ContentField.dur;
            }
            set
            {
                this.ContentField.dur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string repeatDur
        {
            get
            {
                return this.ContentField.repeatDur;
            }
            set
            {
                this.ContentField.repeatDur=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeatCount
        {
            get
            {
                return this.ContentField.repeatCount;
            }
            set
            {
                this.ContentField.repeatCount=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public System.Nullable<decimal> repeat
        {
            get
            {
                return this.ContentField.repeat;
            }
            set
            {
                this.ContentField.repeat=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string min
        {
            get
            {
                return this.ContentField.min;
            }
            set
            {
                this.ContentField.min=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string max
        {
            get
            {
                return this.ContentField.max;
            }
            set
            {
                this.ContentField.max=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehavior
        {
            get
            {
                return this.ContentField.syncBehavior;
            }
            set
            {
                this.ContentField.syncBehavior=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncTolerance
        {
            get
            {
                return this.ContentField.syncTolerance;
            }
            set
            {
                this.ContentField.syncTolerance=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncBehaviorDefault
        {
            get
            {
                return this.ContentField.syncBehaviorDefault;
            }
            set
            {
                this.ContentField.syncBehaviorDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string syncToleranceDefault
        {
            get
            {
                return this.ContentField.syncToleranceDefault;
            }
            set
            {
                this.ContentField.syncToleranceDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restart
        {
            get
            {
                return this.ContentField.restart;
            }
            set
            {
                this.ContentField.restart=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string restartDefault
        {
            get
            {
                return this.ContentField.restartDefault;
            }
            set
            {
                this.ContentField.restartDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fill
        {
            get
            {
                return this.ContentField.fill;
            }
            set
            {
                this.ContentField.fill=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string fillDefault
        {
            get
            {
                return this.ContentField.fillDefault;
            }
            set
            {
                this.ContentField.fillDefault=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public string targetElement
        {
            get
            {
                return this.ContentField.targetElement;
            }
            set
            {
                this.ContentField.targetElement=value;
            }
        }

        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public bool skipcontent
        {
            get
            {
                return this.ContentField.skipcontent;
            }
            set
            {
                this.ContentField.skipcontent=value;
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
                return XName.Get("set", "http://www.w3.org/2001/SMIL20/Language");
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

        public static set Load(string xmlFile)
        {
            return ((set)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static set Load(System.IO.TextReader xmlFile)
        {
            return ((set)(XTypedServices.ToXTypedElement(XElement.Load(xmlFile), LinqToXsdTypeManager.Instance)));
        }

        public static set Parse(string xml)
        {
            return ((set)(XTypedServices.ToXTypedElement(XElement.Parse(xml), LinqToXsdTypeManager.Instance)));
        }

        public override XTypedElement Clone()
        {
            return new set(((setType)(this.Content.Clone())));
        }

        private void SetInnerType(setType ContentField)
        {
            this.ContentField=((setType)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }

        protected virtual void SetSubstitutionMember(setType ContentField)
        {
            this.ContentField=ContentField;
        }

        ContentModelEntity IXMetaData.GetContentModel()
        {
            return ContentModelEntity.Default;
        }

        public static XmlSchemaType setSchemaProvider(XmlSchemaSet schemas)
        {
            LinqToXsdTypeManager.AddSchemas(schemas);
            XmlSchemaElement element=((XmlSchemaElement)(schemas.GlobalElements[new XmlQualifiedName("set", "http://www.w3.org/2001/SMIL20/Language")]));
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


        public animate animate { get { return rootObject as animate; } }

        public animateMotion animateMotion { get { return rootObject as animateMotion; } }

        public animateColor animateColor { get { return rootObject as animateColor; } }

        public set set { get { return rootObject as set; } }

        private XRootNamespace()
        {
        }

        public XRootNamespace(animate root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(animateMotion root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(animateColor root)
        {
            this.doc=new XDocument(root.Untyped);
            this.rootObject=root;
        }

        public XRootNamespace(set root)
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
