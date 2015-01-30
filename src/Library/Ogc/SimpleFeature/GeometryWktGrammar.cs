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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Common.Logging;
using Irony;
using Irony.Ast;
using Irony.Parsing;
using Irony.Interpreter.Ast;

namespace GeoSik.Ogc.SimpleFeature
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>OGC Geometry Well-Known Text grammar as defined in <see href="http://portal.opengeospatial.org/files/?artifact_id=25355">OGC 06-103r4 §7.2</see>.</summary>
    /// <remarks>
    ///   <para>Only 2 dimension WKT representations are supported at this time.</para>
    /// </remarks>
    ///
    ////////////////////////////////////////////////////////////////////////////

    [Language("GWKT", "1.2.1", "OGC Geometry Well-Known Text 1.2.1 grammar")]
    public class GeometryWktGrammar:
        Grammar
    {

        /// <summary>Creates a new instance of the <see cref="GeometryWktGrammar" /> class.</summary>
        public GeometryWktGrammar():
            base(false)
        {
            GrammarComments="OGC Geometry Well-Known Text grammar as defined in [OGC 06-103r4 §7.2]";

            var numeric_literal=new NumberLiteral("numeric literal", NumberOptions.AllowSign, typeof(LiteralValueNode));

            var GEOMETRYCOLLECTION=ToTerm("GEOMETRYCOLLECTION");
            var LINESTRING=ToTerm("LINESTRING");
            var MULTILINESTRING=ToTerm("MULTILINESTRING");
            var MULTIPOINT=ToTerm("MULTIPOINT");
            var MULTIPOLYGON=ToTerm("MULTIPOLYGON");
            var POINT=ToTerm("POINT");
            var POLYGON=ToTerm("POLYGON");
            var POLYHEDRALSURFACE=ToTerm("POLYHEDRALSURFACE");
            var TIN=ToTerm("TIN");
            var TRIANGLE=ToTerm("TRIANGLE");

            var empty_set=ToTerm("EMPTY", "empty set");
            var comma=ToTerm(",", "comma");
            var left_paren=ToTerm("(", "left paren");
            var right_paren=ToTerm(")", "right paren");
            left_paren.SetFlag(TermFlags.IsOpenBrace);
            left_paren.IsPairFor=right_paren;
            right_paren.SetFlag(TermFlags.IsCloseBrace);
            right_paren.IsPairFor=left_paren;

            var x=new NonTerminal("x", numeric_literal);
            var y=new NonTerminal("y", numeric_literal);
            var z=new NonTerminal("z", Empty | numeric_literal);
            var m=new NonTerminal("m", Empty | numeric_literal);

            var geometry_tagged_text=new NonTerminal("geometry tagged text");
            var geometry_tagged_text_series=new NonTerminal("geometry tagged text series", typeof(WktAst.SeriesNode));
            var point_tagged_text=new NonTerminal("point tagged text", typeof(WktAst.PointTaggedTextNode));
            var linestring_tagged_text=new NonTerminal("linestring tagged text", typeof(WktAst.MultiPointNode));
            var polygon_tagged_text=new NonTerminal("polygon tagged text", typeof(WktAst.MultiLineStringNode));
            var triangle_tagged_text=new NonTerminal("triangle tagged text", typeof(WktAst.MultiLineStringNode));
            var polyhedralsurface_tagged_text=new NonTerminal("polyhedralsurface tagged text", typeof(WktAst.MultiPolygonNode));
            var tin_tagged_text=new NonTerminal("tin tagged text", typeof(WktAst.MultiPolygonNode));
            var multipoint_tagged_text=new NonTerminal("multipoint tagged text", typeof(WktAst.MultiPointNode));
            var multilinestring_tagged_text=new NonTerminal("multilinestring tagged text", typeof(WktAst.MultiLineStringNode));
            var multipolygon_tagged_text=new NonTerminal("multipolygon tagged text", typeof(WktAst.MultiPolygonNode));
            var geometrycollection_tagged_text=new NonTerminal("geometrycollection tagged text", typeof(WktAst.GeometryCollectionTaggedTextNode));

            var point=new NonTerminal("point", x + y);
            point.AstConfig.NodeType=typeof(WktAst.PointNode);
            var point_series=new NonTerminal("point series", typeof(WktAst.SeriesNode));
            var point_text=new NonTerminal("point text", empty_set | left_paren + point + right_paren);
            var point_text_series=new NonTerminal("point text series", typeof(WktAst.SeriesNode));
            var linestring_text=new NonTerminal("linestring text", empty_set | left_paren + point_series + right_paren);
            var linestring_text_series=new NonTerminal("linestring text series", typeof(WktAst.SeriesNode));
            var polygon_text=new NonTerminal("polygon text", empty_set | left_paren + linestring_text_series + right_paren);
            var polygon_text_series=new NonTerminal("polygon text series", typeof(WktAst.SeriesNode));
            var polyhedralsurface_text=new NonTerminal("polyhedralsurface text", empty_set | left_paren + polygon_text_series + right_paren);
            var multipoint_text=new NonTerminal("multipoint text", empty_set | left_paren + point_text_series + right_paren);
            var multilinestring_text=new NonTerminal("multilinestring text", empty_set | left_paren + linestring_text_series + right_paren);
            var multipolygon_text=new NonTerminal("multipolygon text", empty_set | left_paren + polygon_text_series + right_paren);
            var geometrycollection_text=new NonTerminal("geometrycollection text", empty_set | left_paren + geometry_tagged_text_series + right_paren);

            geometry_tagged_text_series.Rule=MakePlusRule(geometry_tagged_text_series, comma, geometry_tagged_text);
            point_series.Rule=MakePlusRule(point_series, comma, point);
            point_text_series.Rule=MakePlusRule(point_text_series, comma, point_text);
            linestring_text_series.Rule=MakePlusRule(linestring_text_series, comma, linestring_text);
            polygon_text_series.Rule=MakePlusRule(polygon_text_series, comma, polygon_text);

            geometry_tagged_text.Rule=point_tagged_text | linestring_tagged_text | polygon_tagged_text | triangle_tagged_text | polyhedralsurface_tagged_text | tin_tagged_text | multipoint_tagged_text | multilinestring_tagged_text | multipolygon_tagged_text | geometrycollection_tagged_text;
            point_tagged_text.Rule=POINT + point_text;
            linestring_tagged_text.Rule=LINESTRING + linestring_text;
            polygon_tagged_text.Rule=POLYGON + polygon_text;
            triangle_tagged_text.Rule=TRIANGLE + polygon_text;
            polyhedralsurface_tagged_text.Rule=POLYHEDRALSURFACE + polyhedralsurface_text;
            tin_tagged_text.Rule=TIN + polyhedralsurface_text;
            multipoint_tagged_text.Rule=MULTIPOINT + multipoint_text;
            multilinestring_tagged_text.Rule=MULTILINESTRING + multilinestring_text;
            multipolygon_tagged_text.Rule=MULTIPOLYGON + multipolygon_text;
            geometrycollection_tagged_text.Rule=GEOMETRYCOLLECTION + geometrycollection_text;

            MarkPunctuation(left_paren, right_paren, comma);
            MarkTransient(geometry_tagged_text, geometrycollection_text, linestring_text, multilinestring_text, multipoint_text, multipolygon_text, point_text, polygon_text, polyhedralsurface_text, m, x, y, z);

            Root=geometry_tagged_text;
            LanguageFlags=LanguageFlags.CreateAst;
        }

        /// <summary>Returns true if a character is whitespace or delimiter. Used in quick-scanning versions of some terminals. </summary>
        /// <param name="ch">The character to check.</param>
        /// <returns>True if a character is whitespace or delimiter; otherwise, false.</returns>
        /// <remarks>Does not have to be completely accurate, should recognize most common characters that are special chars by themselves
        /// and may never be part of other multi-character tokens. </remarks>
        public override bool IsWhitespaceOrDelimiter(char ch)
        {
            switch (ch)
            {
            case ' ':
            case '\t':
            case '\r':
            case '\n':
            case '\v': //whitespaces
            case '(':
            case ')':
            case ',':
            case (char)0: //EOF
                return true;
            default:
                return false;
            }
        }

        /// <summary>Populates the specified <paramref name="sink" /> with the specified <paramref name="text" /> and <paramref name="coordinateSystem" />.</summary>
        /// <param name="sink">The object to fill.</param>
        /// <param name="text">The WKT representation of the source geometry.</param>
        /// <param name="coordinateSystem">The coordinate system of the WKT representation.</param>
        public static void Populate(IGeometrySink sink, string text, ICoordinateSystem coordinateSystem)
        {
            Debug.Assert(sink!=null);
            if (sink==null)
                throw new ArgumentNullException("sink");
            Debug.Assert(coordinateSystem!=null);
            if (coordinateSystem==null)
                throw new ArgumentNullException("coordinateSystem");

            sink.SetCoordinateSystem(coordinateSystem);
            if (string.IsNullOrEmpty(text))
                return;

            // Parse the WKT
            var parser=new Parser(LanguageData);
            ParseTree tree=parser.Parse(text);

            if (tree.ParserMessages.Count>0)
            {
                var logger=LogManager.GetCurrentClassLogger();
                var exl=new List<Exception>();

                foreach (LogMessage lm in tree.ParserMessages)
                    switch (lm.Level)
                    {
                    case ErrorLevel.Error:
                        logger.Error(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", lm.Location.Line, lm.Location.Column, lm.Message));
                        exl.Add(
                            new ArgumentException(
                                string.Format(
                                    parser.Context.Culture,
                                    "({0},{1}): {2}: {3}",
                                    lm.Location.Line,
                                    lm.Location.Column,
                                    lm.Level,
                                    lm.Message
                                ),
                                "text"
                            )
                        );
                        break;
                    case ErrorLevel.Info:
                        logger.Info(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", lm.Location.Line, lm.Location.Column, lm.Message));
                        break;
                    default:
                        logger.Warn(CultureInfo.InvariantCulture, m => m("({0},{1}): {2}", lm.Location.Line, lm.Location.Column, lm.Message));
                        break;
                    }

                if (exl.Count>0)
                    throw new AggregateException(exl);
            }

            // Fill the sink
            ((IGeometryTap)tree.Root.AstNode).Populate(sink);
        }

        /// <summary>Builds the AST for the specified language data and parse tree.</summary>
        /// <param name="language">The language data.</param>
        /// <param name="parseTree">The parse tree to build the AST against.</param>
        public override void BuildAst(LanguageData language, ParseTree parseTree)
        {
            if(!LanguageFlags.IsSet(LanguageFlags.CreateAst))
                return;

            var astContext=new AstContext(language);
            astContext.DefaultNodeType=typeof(NotSupportedNode);
            var astBuilder=new AstBuilder(astContext);
            astBuilder.BuildAst(parseTree);
        }

        private static LanguageData LanguageData
        {
            get
            {
                if (_LanguageData==null)
                {
                    _LanguageData=new LanguageData(new GeometryWktGrammar());

                    if (_LanguageData.Errors.Count>0)
                    {
                        var logger=LogManager.GetCurrentClassLogger();
                        foreach (GrammarError ge in _LanguageData.Errors)
                            switch (ge.Level)
                            {
                            case GrammarErrorLevel.InternalError:
                            case GrammarErrorLevel.Error:
                                logger.Error(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            case GrammarErrorLevel.Info:
                                logger.Info(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            case GrammarErrorLevel.NoError:
                                logger.Trace(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            default:
                                logger.Warn(CultureInfo.InvariantCulture, m => m(ge.Message));
                                break;
                            }
                    }
                }

                return _LanguageData;
            }
        }

        private static LanguageData _LanguageData;
    }
}
