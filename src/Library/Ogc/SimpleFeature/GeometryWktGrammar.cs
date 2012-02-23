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
using System.Linq;
using System.Text;
using Irony.Parsing;
using Irony.Interpreter.Ast;

namespace GeoSik.Ogc.SimpleFeature
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>OGC Geometry Well-Known Text grammar as defined in <a href="http://portal.opengeospatial.org/files/?artifact_id=25355">OGC 06-103r4 §7.2</a>.</summary>
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

            var numeric_literal=new NumberLiteral("numeric literal", NumberOptions.AllowSign);

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
            var left_paren=ToTerm("(", "left paren");
            var right_paren=ToTerm(")", "right paren");
            var left_bracket=ToTerm("[", "left bracket");
            var right_bracket=ToTerm("]", "right bracket");
            var comma=ToTerm(",", "comma");

            var x=new NonTerminal("x", numeric_literal);
            var y=new NonTerminal("y", numeric_literal);
            var z=new NonTerminal("z", Empty | numeric_literal);
            var m=new NonTerminal("m", Empty | numeric_literal);

            var geometry_tagged_text=new NonTerminal("geometry tagged text");
            var geometry_tagged_text_series=new NonTerminal("geometry tagged text series");
            var point_tagged_text=new NonTerminal("point tagged text");
            var linestring_tagged_text=new NonTerminal("linestring tagged text");
            var polygon_tagged_text=new NonTerminal("polygon tagged text");
            var triangle_tagged_text=new NonTerminal("triangle tagged text");
            var polyhedralsurface_tagged_text=new NonTerminal("polyhedralsurface tagged text");
            var tin_tagged_text=new NonTerminal("tin tagged text");
            var multipoint_tagged_text=new NonTerminal("multipoint tagged text");
            var multilinestring_tagged_text=new NonTerminal("multilinestring tagged text");
            var multipolygon_tagged_text=new NonTerminal("multipolygon tagged text");
            var geometrycollection_tagged_text=new NonTerminal("geometrycollection tagged text");

            var point=x + y;
            var point_series=new NonTerminal("point series");
            var point_text=new NonTerminal("point text", empty_set | left_paren + point + right_paren);
            var point_text_series=new NonTerminal("point text series");
            var linestring_text=new NonTerminal("linestring text", empty_set | left_paren + point_series + right_paren);
            var linestring_text_series=new NonTerminal("linestring text series");
            var polygon_text=new NonTerminal("polygon text", empty_set | left_paren + linestring_text_series + right_paren);
            var polygon_text_series=new NonTerminal("polygon text series");
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

            Delimiters="(),[]";
            MarkPunctuation(left_paren, right_paren, comma);
            MarkTransient(geometry_tagged_text);

            Root=geometry_tagged_text;
            LanguageFlags=LanguageFlags.Default;
        }
    }
}
