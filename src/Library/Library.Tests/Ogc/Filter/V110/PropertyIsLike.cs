using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Ogc.Filter.V110.Tests
{

    public class PropertyIsLikeTests
    {

        [Theory]
        [InlineData("TEST", "%", "_", null, "TEST")]
        [InlineData("%TE%ST%", "%", "_", null, "%TE%ST%")]
        [InlineData("_TE_ST_", "%", "_", null, "_TE_ST_")]
        [InlineData("%TE_%ST_", "%", "_", null, "%TE_%ST_")]
        [InlineData("TEST", "%", "_", 'e', "TEST")]
        [InlineData("%TEe%ST%", "%", "_", 'e', "%TEe%ST%")]
        [InlineData("_TEe_ST_", "%", "_", 'e', "_TEe_ST_")]
        [InlineData("e%TE_%STe_", "%", "_", 'e', "e%TE_%STe_")]
        [InlineData("wTEST", "w", "s", null, "%TEST")]
        [InlineData("wTEwSTw", "w", "s", null, "%TE%ST%")]
        [InlineData("sTEST", "w", "s", null, "_TEST")]
        [InlineData("sTEsSTs", "w", "s", null, "_TE_ST_")]
        [InlineData("wTEswSTs", "w", "s", null, "%TE_%ST_")]
        [InlineData("wTEST", "w", "s", 'e', "%TEST")]
        [InlineData("wTEwSTw", "w", "s", 'e', "%TE%ST%")]
        [InlineData("wTEewSTw", "w", "s", 'e', "%TEewST%")]
        [InlineData("sTEST", "w", "s", 'e', "_TEST")]
        [InlineData("sTEsSTs", "w", "s", 'e', "_TE_ST_")]
        [InlineData("sTEesSTs", "w", "s", 'e', "_TEesST_")]
        [InlineData("wTEswSTs", "w", "s", 'e', "%TE_%ST_")]
        [InlineData("ewTEswSTes", "w", "s", 'e', "ewTE_%STes")]
        [InlineData("*TE?ST*", "*", "?", null, "%TE_ST%")]
        [InlineData("*TE?*ST?", "*", "?", null, "%TE_%ST_")]
        [InlineData("*TE?ST*", "*", "?", '\\', "%TE_ST%")]
        [InlineData("*TE?*ST?", "*", "?", '\\', "%TE_%ST_")]
        [InlineData(@"*TE?\*ST?", "*", "?", '\\', @"%TE_\*ST_")]
        public void TranslateToSqlLikePattern_ShouldReturnTranslatedPattern(string input, string wildCard, string singleChar, char? escapeChar, string expected)
        {
            string pattern=PropertyIsLike.PropertyIsLikeExpressionCreator.TranslateToSqlLikePattern(input, wildCard, singleChar, escapeChar);

            Assert.Equal<string>(expected, pattern);
        }
    }
}
