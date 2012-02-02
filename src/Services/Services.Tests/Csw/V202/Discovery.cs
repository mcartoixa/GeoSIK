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
using System.Collections.Specialized;
using Xunit;
using Xunit.Extensions;

namespace GeoSik.Services.Csw.V202.Tests
{

    public partial class DiscoveryTests
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
