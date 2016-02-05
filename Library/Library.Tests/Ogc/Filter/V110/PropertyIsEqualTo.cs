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
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Ogc.Filter.V110.Tests
{

    public class PropertyIsEqualToTests
    {

        [Theory]
        [InlineData(11, "10")]
        [InlineData(20, "10")]
        public void Filter_ShouldFindStringConstraintInSimpleNode(int number, string selection)
        {
            // WHERE /SimpleType/String==selection
            // simpleTypes.String==selection
            string constraint=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/String</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsEqualTo>",
                selection
            );

            var Filter=FilterTests.CreateFilter(constraint);
            var selected=FilterTests.CreateCollection(number).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(Filter);

            Assert.Equal<int>(1, selected.Count<FilterTests.SimpleType>());
            Assert.Equal<string>(selection, selected.First<FilterTests.SimpleType>().String);
        }

        [Theory]
        [InlineData(11, 10)]
        [InlineData(20, 10)]
        public void Filter_ShouldFindIntegerConstraintInSimpleNode(int number, int selection)
        {
            // WHERE /SimpleType/Integer==selection
            // simpleTypes.Integer==selection
            string constraint=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/Integer</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsEqualTo>",
                selection
            );

            var Filter=FilterTests.CreateFilter(constraint);
            var selected=FilterTests.CreateCollection(number).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(Filter);

            Assert.Equal<int>(1, selected.Count<FilterTests.SimpleType>());
            Assert.Equal<int>(selection, selected.First<FilterTests.SimpleType>().Integer);
        }

        [Theory]
        [InlineData(11, 10, 1)]
        [InlineData(20, 10, 10)]
        public void Filter_ShouldFindIntegerConstraintInEnumerableNode(int number, int selection, int expectedNumber)
        {
            // WHERE /SimpleType/IntegerList==selection
            // simpleTypes.IntegerList.Any<int>(i => i==selection)
            string constraint=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/IntegerList</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsEqualTo>",
                selection
            );

            var Filter=FilterTests.CreateFilter(constraint);
            var selected=FilterTests.CreateCollection(number).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(Filter);

            Assert.Equal<int>(expectedNumber, selected.Count<FilterTests.SimpleType>());
            foreach (FilterTests.SimpleType t in selected)
                Assert.True(t.IntegerList.Contains<int>(selection));
        }

        [Theory]
        [InlineData(11, 10, 0)]
        [InlineData(12, 10, 1)]
        [InlineData(20, 10, 9)]
        public void Filter_ShouldFindIntegerConstraintInComplexEnumerableNode(int number, int selection, int expectedNumber)
        {
            // WHERE /SimpleType/PreviousList/Integer==selection
            // simpleTypes.PreviousList.Any<SimpleType>(t => t.Integer==selection)
            string constraint=string.Format(
                CultureInfo.InvariantCulture,
                "<ogc:PropertyIsEqualTo><ogc:PropertyName>/SimpleType/PreviousList/Integer</ogc:PropertyName><ogc:Literal>{0}</ogc:Literal></ogc:PropertyIsEqualTo>",
                selection
            );

            var Filter=FilterTests.CreateFilter(constraint);
            var selected=FilterTests.CreateCollection(number).AsQueryable<FilterTests.SimpleType>().Where<FilterTests.SimpleType>(Filter);

            Assert.Equal<int>(expectedNumber, selected.Count<FilterTests.SimpleType>());
            foreach (FilterTests.SimpleType t in selected)
                Assert.True(t.PreviousList.Any<FilterTests.SimpleType>(p => p.Integer==selection));
        }
    }
}
