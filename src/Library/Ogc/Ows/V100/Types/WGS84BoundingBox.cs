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
using System.Diagnostics;
using Microsoft.Practices.ServiceLocation;

namespace GeoSik.Ogc.Ows.V100.Types
{

#pragma warning disable 3009
    partial class WGS84BoundingBox
    {

        /// <summary>Gets or sets the spatial reference of the current bounding box.</summary>
        protected override ICoordinateSystem CoordinateSystem
        {
            get
            {
                return CommonServiceLocator.GetCoordinateSystemProvider().Wgs84;
            }
            set
            {
                Debug.Assert(value.Equals(CommonServiceLocator.GetCoordinateSystemProvider().Wgs84));
                // Do nothing
            }
        }
    }
#pragma warning restore 3009
}
