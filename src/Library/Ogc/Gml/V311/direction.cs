using System;
using System.Diagnostics;
using System.Xml.Schema;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3003, 3009
    partial class direction
    {

        // Not sure about this one...
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static SimpleTypeValidator TypeDefinition=new UnionSimpleTypeValidator(
            XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyAtomicType),
            null,
            new SimpleTypeValidator[] {
                    new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double), null),
                    new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new RestrictionFacets(RestrictionFlags.Enumeration, new object[] {
                        "N",
                        "NNE",
                        "NE",
                        "ENE",
                        "E",
                        "ESE",
                        "SE",
                        "SSE",
                        "S",
                        "SSW",
                        "SW",
                        "WSW",
                        "W",
                        "WNW",
                        "NW",
                        "NNW"}, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve)),
                    new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), null),
                    new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), null)
            }
        );
    }
#pragma warning restore 3003, 3009
}