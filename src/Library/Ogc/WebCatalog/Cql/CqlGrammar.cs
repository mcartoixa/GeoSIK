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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Irony.Ast;
using Irony.Parsing;
using Irony.Interpreter.Ast;

namespace GeoSik.Ogc.WebCatalog.Cql
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>OGC Common Catalogue Query Language grammar as defined in <see href="http://portal.opengeospatial.org/files/?artifact_id=20555">OGC 07-006r1 §6.2.2</see>.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    [Language("CQL", "1.0", "OGC Common Catalogue Query Language 1.0 grammar")]
    public class CqlGrammar:
        Grammar
    {

        /// <summary>Creates a new instance of the <see cref="CqlGrammar" /> class.</summary>
        public CqlGrammar():
            base(true)
        {
            GrammarComments="OGC Common Catalogue Query Language grammar as defined in [OGC 07-006r1 §6.2.2]";

            // Terminals
            var identifier=new IdentifierTerminal("identifier", ":", "");
            identifier.StartCharCategories.AddRange(
                new UnicodeCategory[] {
                    UnicodeCategory.UppercaseLetter, //Ul
                    UnicodeCategory.LowercaseLetter  //Ll
                }
            );
            identifier.CharCategories.AddRange(
                new UnicodeCategory[] {
                    UnicodeCategory.UppercaseLetter, //Ul
                    UnicodeCategory.LowercaseLetter, //Ll
                    UnicodeCategory.DecimalDigitNumber //Nd
                }
            );
            //var digit_literal=new FixedLengthLiteral("digit", 1, TypeCode.Byte);
            var numeric_literal=new NumberLiteral("numeric literal", NumberOptions.AllowSign, typeof(Ast.DefaultLiteralNode));
            var unsigned_numeric_literal=new NumberLiteral("unsigned numeric literal", NumberOptions.None, typeof(Ast.DefaultLiteralNode));
            //var integer_literal=new NumberLiteral("integer literal", NumberOptions.IntOnly | NumberOptions.NoDotAfterInt);
            //var character_literal=new StringLiteral("character literal", "'", StringOptions.IsChar | StringOptions.AllowsDoubledQuote);
            var string_literal=new StringLiteral("string literal", "'", StringOptions.AllowsDoubledQuote, typeof(Ast.DefaultLiteralNode));
            var period=ToTerm(".", "period");
            var comma=ToTerm(",", "comma");
            var left_paren=ToTerm("(", "left paren");
            var right_paren=ToTerm(")", "right paren");
            left_paren.SetFlag(TermFlags.IsOpenBrace);
            left_paren.IsPairFor=right_paren;
            right_paren.SetFlag(TermFlags.IsCloseBrace);
            right_paren.IsPairFor=left_paren;

            var TRUE=ToTerm("TRUE");
            var FALSE=ToTerm("FALSE");
            var UNKNOWN=ToTerm("UNKNOWN");
            var NULL=ToTerm("NULL");

            var AFTER=ToTerm("AFTER");
            var AND=ToTerm("AND");
            var BEFORE=ToTerm("BEFORE");
            var BEYOND=ToTerm("BEYOND");
            var CONTAINS=ToTerm("CONTAINS");
            var CROSSES=ToTerm("CROSSES");
            var DISJOINT=ToTerm("DISJOINT");
            var DOESNOTEXIST=ToTerm("DOESNOTEXIST");
            var DURING=ToTerm("DURING");
            var DWITHIN=ToTerm("DWITHIN");
            var EQUALS=ToTerm("EQUALS", "Equal");
            var EXISTS=ToTerm("EXISTS");
            var INTERSECTS=ToTerm("INTERSECTS");
            var LIKE=ToTerm("LIKE");
            var NOT=ToTerm("NOT");
            var OR=ToTerm("OR");
            var OVERLAPS=ToTerm("OVERLAPS");
            var RELATE=ToTerm("RELATE");
            var TOUCHES=ToTerm("TOUCHES");
            var WITHIN=ToTerm("WITHIN");

            var equals_operator=ToTerm("=", "equals operator");
            var greater_than_operator=ToTerm(">", "greater than operator");
            var less_than_operator=ToTerm("<", "less than operator");
            var not_equals_operator=ToTerm("<>", "not equals operator");
            var greater_than_or_equals_operator=ToTerm(">=", "greater than or equals operator");
            var less_than_or_equals_operator=ToTerm("<=", "less than or equals operator");
            var date_time=new RegexBasedTerminal(name: "date-time", pattern: @"(?<fulldate>(?<dateyear>\d{4})-(?<datemonth>\d{2})-(?<dateday>\d{2}))T(?<UTCtime>(?<timehour>\d{2}):(?<timeminute>\d{2}):(?<timesecond>\d{2}(\.\d+)?)Z)");
            var duration=new RegexBasedTerminal(name: "duration", pattern: @"P((?<duryear>\d+)Y)?((?<durmonth>\d+)M)?((?<durday>\d+)D)?(T((?<durhour>\d+)H)?((?<durminute>\d+)M)?((?<dursecond>\d+)S)?)?");

            AFTER.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            AND.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            BEFORE.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            BEYOND.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            CONTAINS.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            CROSSES.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            DISJOINT.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            DURING.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            DOESNOTEXIST.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            DURING.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            DWITHIN.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            EQUALS.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            EXISTS.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            INTERSECTS.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            LIKE.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            NOT.AstConfig.NodeType=typeof(Ast.NotKeywordNode);
            OR.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            OVERLAPS.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            //RELATE.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            TOUCHES.AstConfig.NodeType=typeof(Ast.OperatorNameNode);
            WITHIN.AstConfig.NodeType=typeof(Ast.OperatorNameNode);

            date_time.AstConfig.NodeType=typeof(Ast.DateTimeLiteralNode);
            duration.AstConfig.NodeType=typeof(Ast.DurationLiteralNode);

            // Non terminals
            var optional_not=new NonTerminal("optional not", Empty | NOT);

            var attribute_name=new NonTerminal("attribute name", typeof(Ast.AttributeNameNode));
            var search_condition=new NonTerminal("search condition");
            var boolean_value_expression=new NonTerminal("boolean value expression", typeof(Ast.BooleanValueExpressionNode));
            var boolean_term=new NonTerminal("boolean term", typeof(Ast.BooleanTermNode));
            var boolean_factor=new NonTerminal("boolean factor", typeof(Ast.BooleanFactorNode));
            var boolean_primary=new NonTerminal("boolean primary");
            var predicate=new NonTerminal("predicate");
            var temporal_predicate=new NonTerminal("temporal predicate", typeof(Ast.TemporalPredicateNode));
            var date_time_expression=new NonTerminal("date-time expression");
            var existence_predicate=new NonTerminal("existence predicate", typeof(Ast.ExistencePredicateNode));
            var comparison_predicate=new NonTerminal("comparison predicate", typeof(Ast.ComparisonPredicateNode));
            var text_predicate=new NonTerminal("text predicate", typeof(Ast.TextPredicateNode));
            var null_predicate=new NonTerminal("null predicate", typeof(Ast.NullPredicateNode));
            var comp_op=new NonTerminal("comp op", equals_operator | not_equals_operator | less_than_operator | greater_than_operator | less_than_or_equals_operator | greater_than_or_equals_operator);
            var general_literal=new NonTerminal("general literal");
            var literal=new NonTerminal("literal");
            var boolean_literal=new NonTerminal("boolean literal", TRUE | FALSE | UNKNOWN);
            boolean_literal.AstConfig.NodeType=typeof(Ast.BooleanLiteralNode);
            var routine_invocation=new NonTerminal("routine invocation");
            var geoop_routine=new NonTerminal("geoop routine", typeof(Ast.GeoOperatorRoutineNode));
            var relgeoop_routine=new NonTerminal("relgeoop routine", typeof(Ast.RelativeGeoOperatorRoutineNode));
            var routine=new NonTerminal("routine");
            var geoop_name=new NonTerminal("geoop name");
            var relgeoop_name=new NonTerminal("relgeoop name");
            var argument=new NonTerminal("argument");
            var positional_arguments=new NonTerminal("positional arguments");
            var tolerance=new NonTerminal("tolerance", typeof(Ast.ToleranceNode));
            var distance_units=new NonTerminal("distance units");

            var geometry_literal=new NonTerminal("geometry literal", typeof(Ast.GeometryLiteralNode));
            var geometry_literal_series=new NonTerminal("geometry literal series");
            var point_tagged_text=new NonTerminal("Point Tagged Text");
            var linestring_tagged_text=new NonTerminal("LineString Tagged Text");
            var polygon_tagged_text=new NonTerminal("Polygon Tagged Text");
            var multipoint_tagged_text=new NonTerminal("MultiPoint Tagged Text");
            var multilinestring_tagged_text=new NonTerminal("MultiLineString Tagged Text");
            var multipolygon_tagged_text=new NonTerminal("MultiPolygon Tagged Text");
            var geometrycollection_tagged_text=new NonTerminal("GeometryCollection Tagged Text");
            var point_text=new NonTerminal("Point Text");
            var point_text_series=new NonTerminal("Point Text series");
            var point=new NonTerminal("Point");
            var point_series=new NonTerminal("Point series");
            var x=new NonTerminal("x");
            var y=new NonTerminal("y");
            var linestring_text=new NonTerminal("LineString Text");
            var linestring_text_series=new NonTerminal("LineString Text series");
            var polygon_text=new NonTerminal("Polygon Text");
            var polygon_text_series=new NonTerminal("Polygon Text series");
            var multipoint_text=new NonTerminal("MultiPoint Text");
            var multilinestring_text=new NonTerminal("MultiLineString Text");
            var multipolygon_text=new NonTerminal("MultiPolygon Text");
            var geometrycollection_text=new NonTerminal("GeometryCollection Text");
            var envelope_tagged_text=new NonTerminal("Envelope Tagged Text");
            var envelope_text=new NonTerminal("Envelope Text");
            var westboundlongitude=new NonTerminal("WestBoundLongitude", numeric_literal);
            var eastboundlongitude=new NonTerminal("EastBoundLongitude", numeric_literal);
            var northboundlongitude=new NonTerminal("NorthBoundLongitude", numeric_literal);
            var southboundlongitude=new NonTerminal("SouthBoundLongitude", numeric_literal);

            var date_time_period=new NonTerminal("date-time period", typeof(Ast.DateTimePeriodNode));

            identifier.AstConfig.NodeType=typeof(IdentifierNode);
            attribute_name.Rule=MakePlusRule(attribute_name, period, identifier);

            search_condition.Rule=boolean_value_expression;
            boolean_value_expression.Rule=MakePlusRule(boolean_value_expression, OR, boolean_term);
            boolean_term.Rule=MakePlusRule(boolean_term, AND, boolean_factor);
            boolean_factor.Rule=optional_not + boolean_primary;
            boolean_primary.Rule=predicate | routine_invocation | (left_paren + search_condition + right_paren);
            predicate.Rule=comparison_predicate | text_predicate | null_predicate | temporal_predicate | existence_predicate;
            temporal_predicate.Rule=(attribute_name + BEFORE + date_time_expression) | (attribute_name + BEFORE + OR + DURING + date_time_period) | (attribute_name + DURING + date_time_period) | (attribute_name + DURING + OR + AFTER + date_time_period) | (attribute_name + AFTER + date_time_expression);
            date_time_expression.Rule=date_time | date_time_period;
            existence_predicate.Rule=(attribute_name + EXISTS) | (attribute_name + DOESNOTEXIST);
            comparison_predicate.Rule=attribute_name + comp_op + literal;
            text_predicate.Rule=attribute_name + optional_not + LIKE + string_literal;
            null_predicate.Rule=attribute_name + "IS" + optional_not + NULL;
            general_literal.Rule=string_literal | boolean_literal | date_time_expression | geometry_literal;
            literal.Rule=numeric_literal | general_literal;
            routine_invocation.Rule=geoop_routine | relgeoop_routine | routine;
            geoop_name.Rule=EQUALS | DISJOINT | INTERSECTS | TOUCHES | CROSSES | WITHIN | CONTAINS | OVERLAPS | RELATE;
            relgeoop_name.Rule=DWITHIN | BEYOND;
            argument.Rule=literal | attribute_name;
            positional_arguments.Rule=MakePlusRule(positional_arguments, comma, argument);
            geoop_routine.Rule=geoop_name + left_paren + attribute_name + comma + geometry_literal + right_paren;
            relgeoop_routine.Rule=relgeoop_name + left_paren + attribute_name + comma + geometry_literal + comma + tolerance + right_paren;
            routine.Rule=attribute_name + left_paren + positional_arguments + right_paren;
            tolerance.Rule=unsigned_numeric_literal + comma + distance_units;
            distance_units.Rule=ToTerm("feet") | "meters" | ("statute" + "miles") | ("nautical" + "miles") | "kilometers";

            geometry_literal.Rule=point_tagged_text | linestring_tagged_text | polygon_tagged_text | multipoint_tagged_text | multilinestring_tagged_text | multipolygon_tagged_text | geometrycollection_tagged_text | envelope_tagged_text;
            geometry_literal_series.Rule=MakePlusRule(geometry_literal_series, comma, geometry_literal);
            point_tagged_text.Rule=ToTerm("POINT") + point_text;
            linestring_tagged_text.Rule=ToTerm("LINESTRING") + linestring_text;
            polygon_tagged_text.Rule=ToTerm("POLYGON") + polygon_text;
            multipoint_tagged_text.Rule=ToTerm("MULTIPOINT") + multipoint_text;
            multilinestring_tagged_text.Rule=ToTerm("MULTILINESTRING") + multilinestring_text;
            multipolygon_tagged_text.Rule=ToTerm("MULTIPOLYGON") + multipolygon_text;
            geometrycollection_tagged_text.Rule=ToTerm("GEOMETRYCOLLECTION") + geometrycollection_text;
            point_text.Rule=Empty | (left_paren + point + right_paren);
            point_text_series.Rule=MakePlusRule(point_text_series, comma, point_text);
            point.Rule=x + y;
            x.Rule=numeric_literal;
            y.Rule=numeric_literal;
            point_series.Rule=MakePlusRule(point_series, comma, point);
            linestring_text.Rule=Empty | (left_paren + point_series + right_paren);
            linestring_text_series.Rule=MakePlusRule(linestring_text_series, comma, linestring_text);
            polygon_text.Rule=Empty | (left_paren + linestring_text_series + right_paren);
            polygon_text_series.Rule=MakePlusRule(polygon_text_series, comma, polygon_text);
            multipoint_text.Rule=Empty | (left_paren + point_text_series + right_paren);
            multilinestring_text.Rule=Empty | (left_paren + linestring_text_series + right_paren);
            multipolygon_text.Rule=Empty | (left_paren + polygon_text_series + right_paren);
            geometrycollection_text.Rule=Empty | (left_paren + geometry_literal_series + right_paren);
            envelope_tagged_text.Rule=ToTerm("ENVELOPE") + envelope_text;
            envelope_text.Rule=Empty | left_paren + westboundlongitude + comma + eastboundlongitude + comma + northboundlongitude + comma + southboundlongitude + right_paren;

            date_time_period.Rule=(date_time + "/" + date_time) | (date_time + "/" + duration) | (duration + "/" + date_time);
            date_time_expression.Rule=date_time | date_time_period;

            // Operators
            RegisterOperators(10, equals_operator, not_equals_operator, greater_than_operator, greater_than_or_equals_operator, less_than_operator, less_than_or_equals_operator);
            RegisterOperators(3, NOT);
            RegisterOperators(2, OR);
            RegisterOperators(1, AND);
            RegisterOperators(0, BEYOND, WITHIN);

            _OperatorHandler=new OperatorHandler(true);
            var oid=_OperatorHandler.BuildDefaultOperatorMappings();
            oid.Clear();
            oid.Add(equals_operator.Text, ExpressionType.Equal, 10);
            oid.Add(not_equals_operator.Text, ExpressionType.NotEqual, 10);
            oid.Add(greater_than_operator.Text, ExpressionType.GreaterThan, 10);
            oid.Add(greater_than_or_equals_operator.Text, ExpressionType.GreaterThanOrEqual, 10);
            oid.Add(less_than_operator.Text, ExpressionType.LessThan, 10);
            oid.Add(less_than_or_equals_operator.Text, ExpressionType.LessThanOrEqual, 10);
            oid.Add(NOT.Text, ExpressionType.Not, 3);
            oid.Add(OR.Text, ExpressionType.OrElse, 2);
            oid.Add(AND.Text, ExpressionType.AndAlso, 1);

            oid.Add(BEYOND.Text, ExpressionType.GreaterThanOrEqual, 0);
            oid.Add(DWITHIN.Text, ExpressionType.LessThanOrEqual, 0);

            // Grammar
            Delimiters="\"%&'()*+,-./:;<=>?[]^_|{}";
            MarkMemberSelect(":");
            MarkPunctuation(left_paren, right_paren, period, comma);
            MarkTransient(argument, boolean_primary, comp_op, date_time_expression, general_literal, geometry_literal, geoop_name, literal, optional_not, predicate, relgeoop_name, search_condition);

            Root=search_condition;
            LanguageFlags=LanguageFlags.CreateAst;
        }

        /// <summary>Builds the AST for the specified language data and parse tree.</summary>
        /// <param name="language">The language data.</param>
        /// <param name="parseTree">The parse tree to build the AST against.</param>
        public override void BuildAst(LanguageData language, ParseTree parseTree)
        {
            if (!LanguageFlags.IsSet(LanguageFlags.CreateAst))
                return;

            var astContext=new InterpreterAstContext(language, _OperatorHandler);
            var astBuilder=new AstBuilder(astContext);
            astBuilder.BuildAst(parseTree);
        }

        private OperatorHandler _OperatorHandler;
    }
}
