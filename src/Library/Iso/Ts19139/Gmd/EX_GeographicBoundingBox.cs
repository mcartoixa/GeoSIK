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
using Microsoft.Practices.ServiceLocation;

namespace GeoSik.Iso.Ts19139.Gmd
{

#pragma warning disable 3009
    partial class EX_GeographicBoundingBox
    {

        /// <summary>Fills the current bounding box with the specified geometry information.</summary>
        /// <param name="g">THe geometry to fill this bounding box with.</param>
        public void InitFromGeometry(ISimpleGeometry g)
        {
            if (g==null)
            {
                westBoundLongitude=null;
                eastBoundLongitude=null;
                southBoundLatitude=null;
                northBoundLatitude=null;
                return;
            }

            var lc=new List<decimal>(2);
            var uc=new List<decimal>(2);

            // Make sure it is WGS 84, and a GML 3.1.1 instance
            var builder=new Ogc.Gml.V311.GmlGeometryBuilder(ServiceLocator.Current.GetInstance<ICoordinateSystemProvider>().Wgs84);
            g.Populate(builder);

            var envelope=builder.ConstructedGeometry.Envelope() as Ogc.Gml.V311.Envelope;

            lc.Add(Convert.ToDecimal(envelope.lowerCorner.TypedValue[0]));
            lc.Add(Convert.ToDecimal(envelope.lowerCorner.TypedValue[1]));
            uc.Add(Convert.ToDecimal(envelope.upperCorner.TypedValue[0]));
            uc.Add(Convert.ToDecimal(envelope.upperCorner.TypedValue[1]));

            westBoundLongitude=new Gco.Decimal_PropertyType() {
                Decimal=new Gco.Decimal(lc[0])
            };
            eastBoundLongitude=new Gco.Decimal_PropertyType() {
                Decimal=new Gco.Decimal(uc[0])
            };
            southBoundLatitude=new Gco.Decimal_PropertyType() {
                Decimal=new Gco.Decimal(lc[1])
            };
            northBoundLatitude=new Gco.Decimal_PropertyType() {
                Decimal=new Gco.Decimal(uc[1])
            };
        }
    }
#pragma warning restore 3009
}
