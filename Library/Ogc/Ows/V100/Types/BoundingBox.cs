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
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Practices.ServiceLocation;

namespace GeoSik.Ogc.Ows.V100.Types
{

#pragma warning disable 3009
    partial class BoundingBox:
        IGeometryTap
    {

        /// <summary>Applies a geometry type call sequence to the specified <paramref name="sink" />.</summary>
        public void Populate(IGeometrySink sink)
        {
            sink.SetCoordinateSystem(CoordinateSystem);

            sink.BeginGeometry(GeometryType.Polygon);

            if (
                (LowerCorner!=null) && (LowerCorner.Count==2) &&
                (UpperCorner!=null) && (UpperCorner.Count==2)
            )
            {
                double minlon=Math.Min(LowerCorner[0], UpperCorner[0]);
                double maxlon=Math.Max(LowerCorner[0], UpperCorner[0]);
                double minlat=Math.Min(LowerCorner[1], UpperCorner[1]);
                double maxlat=Math.Max(LowerCorner[1], UpperCorner[1]);

                sink.BeginFigure(minlon, minlat, null);
                sink.AddLine(maxlon, minlat, null);
                sink.AddLine(maxlon, maxlat, null);
                sink.AddLine(minlon, maxlat, null);
                sink.AddLine(minlon, minlat, null);
                sink.EndFigure();
            }

            sink.EndGeometry();
        }

        /// <summary>Fills the current bounding box with the specified geometry information.</summary>
        /// <param name="g">THe geometry to fill this bounding box with.</param>
        public void InitFromGeometry(ISimpleGeometry g)
        {
            if (g==null)
            {
                LowerCorner=null;
                UpperCorner=null;
                return;
            }

            CoordinateSystem=g.CoordinateSystem;

            var lc=new List<double>(2);
            var uc=new List<double>(2);

            ISimpleGeometry env=g.Envelope();

            var envelope=env as Gml.V311.Envelope;
            if (envelope==null)
            {
                envelope=new Gml.V311.Envelope();
                env.Populate(envelope);
            }
            Debug.Assert(envelope!=null);

            lc.Add(envelope.lowerCorner.TypedValue[0]);
            lc.Add(envelope.lowerCorner.TypedValue[1]);
            uc.Add(envelope.upperCorner.TypedValue[0]);
            uc.Add(envelope.upperCorner.TypedValue[1]);

            // Bug in LinqToXsd : serialization is culture dependent...
            //LowerCorner=lc;
            //UpperCorner=uc;
            LowerCorner=new List<double>();
            foreach (XElement el in Untyped.Descendants("{http://www.opengis.net/ows}LowerCorner"))
                el.Value=string.Join(
                    " ",
                    lc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
                );
            UpperCorner=new List<double>();
            foreach (XElement el in Untyped.Descendants("{http://www.opengis.net/ows}UpperCorner"))
                el.Value=string.Join(
                    " ",
                    uc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
                );
        }

        /// <summary>Gets or sets the spatial reference of the current bounding box.</summary>
        protected virtual ICoordinateSystem CoordinateSystem
        {
            get
            {
                ICoordinateSystem ret=null;
                if (crs!=null)
                {
                    Srid id=Srid.CreateFromCrs(crs);
                    ret=CommonServiceLocator.GetCoordinateSystemProvider().GetById(id);
                } else
                    ret=CommonServiceLocator.GetCoordinateSystemProvider().Wgs84;
                return ret;
            }
            set
            {
                if (value!=null)
                    crs=new Srid(value.Code).Crs;
                else
                    crs=null;
            }
        }
    }
#pragma warning restore 3009
}
