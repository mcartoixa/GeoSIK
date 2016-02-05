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

    public class PropertyIsLikeTests
    {

        [Theory]
        [InlineData("TEST", "%", "_", 'e', "TEST")]
        [InlineData("%TEe%ST%", "%", "_", 'e', "%TEe%ST%")]
        [InlineData("_TEe_ST_", "%", "_", 'e', "_TEe_ST_")]
        [InlineData("e%TE_%STe_", "%", "_", 'e', "e%TE_%STe_")]
        [InlineData("wTEST", "w", "s", 'e', "%TEST")]
        [InlineData("wTEwSTw", "w", "s", 'e', "%TE%ST%")]
        [InlineData("wTEewSTw", "w", "s", 'e', "%TEewST%")]
        [InlineData("sTEST", "w", "s", 'e', "_TEST")]
        [InlineData("sTEsSTs", "w", "s", 'e', "_TE_ST_")]
        [InlineData("sTEesSTs", "w", "s", 'e', "_TEesST_")]
        [InlineData("wTEswSTs", "w", "s", 'e', "%TE_%ST_")]
        [InlineData("ewTEswSTes", "w", "s", 'e', "ewTE_%STes")]
        [InlineData("*TE?ST*", "*", "?", '\\', "%TE_ST%")]
        [InlineData("*TE?*ST?", "*", "?", '\\', "%TE_%ST_")]
        [InlineData(@"*TE?\*ST?", "*", "?", '\\', @"%TE_\*ST_")]
        public void TranslateToSqlLikePattern_ShouldReturnTranslatedPattern(string input, string wildCard, string singleChar, char escapeChar, string expected)
        {
            string pattern=PropertyIsLike.PropertyIsLikeExpressionCreator.TranslateToSqlLikePattern(input, wildCard, singleChar, escapeChar);

            Assert.Equal<string>(expected, pattern);
        }
    }
}
