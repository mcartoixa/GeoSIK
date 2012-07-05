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
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using GeoSik.Ogc.Ows;
using GeoSik.Ogc.WebCatalog.Csw.V202.Types;
using Xunit;
using Xunit.Extensions;
using Moq;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Tests
{
    partial class DiscoveryTests
    {

        public class GetCapabilitiesTests
        {
        }

        public class GetCapabilitiesProcessorBaseTests
        {

            [Theory]
            [InlineData("http://www.isotc211.org/2005/gmd", null, "gmd")]
            [InlineData("http://www.opengis.net/cat/csw/2.0.2", null, "csw")]
            [InlineData("http://www.opengis.net/gml", null, "gml")]
            [InlineData("http://www.opengis.net/ows", null, "ows")]
            public void CreateUniquePrefix_ShouldReturnCorrectPrefixes(string ns, string basePrefix, string expected)
            {
                XNamespace @namespace=XNamespace.Get(ns);
                string prefix=Discovery.GetCapabilitiesProcessorBase.CreateUniquePrefix(@namespace, new XElement("Foo"), basePrefix);

                Assert.Equal<string>(expected, prefix);
            }
        }

        // Gives access to protected methods
        public class GetCapabilitiesProcessorAccessor:
            Discovery.GetCapabilitiesProcessorBase
        {

            public GetCapabilitiesProcessorAccessor(Discovery service) :
                base(service)
            {}

            public new GetCapabilities CreateRequest(NameValueCollection parameters)
            {
                return base.CreateRequest(parameters);
            }
        }
    }
}
