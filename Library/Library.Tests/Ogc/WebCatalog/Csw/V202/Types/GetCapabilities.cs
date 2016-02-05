using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Types.Tests
{

    public class GetCapabilitiesTests
    {

        [Fact]
        public void ToKeyValuePairs_ShouldEncodeDefault()
        {
            var request=new GetCapabilities();

            var result = ( (Ows.IRequest)request ).ToKeyValuePairs();

            Assert.Contains( "request", result.Cast<string>() );
            Assert.Equal("GetCapabilities", result["request"]);
            Assert.Contains( "service", result.Cast<string>() );
            Assert.Equal("CSW", result["service"]);
        }
    }
}
