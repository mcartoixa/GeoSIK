using System;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Services.Csw.V202.Tests
{

    public class DiscoveryTests
    {

        [Theory]
        [InlineData("http://www.test.com/", "http___www_test_com_")]
        public void GetResourceNameFromNamespace_ShouldReplaceInvalidChars(string input, string expected)
        {
            string result=Discovery.GetResourceNameFromNamespace(input);
            Assert.Equal<string>(expected, result);
        }
    }
}
