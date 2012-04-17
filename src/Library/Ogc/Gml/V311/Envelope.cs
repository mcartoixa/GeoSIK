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

namespace GeoSik.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Envelope:
        ISimpleGeometry,
        IGeometryTap,
        IGeometrySink
    {

        public void Populate(IGeometrySink sink)
        {
            if (srsName!=null)
                sink.SetCoordinateSystem(CoordinateSystem);

            sink.BeginGeometry(GeometryType.Polygon);

            if (
                (lowerCorner!=null) && (lowerCorner.TypedValue!=null) && (lowerCorner.TypedValue.Count==2) &&
                (upperCorner!=null) && (upperCorner.TypedValue!=null) && (upperCorner.TypedValue.Count==2)
            )
            {
                double minlon=Math.Min(lowerCorner.TypedValue[0], upperCorner.TypedValue[0]);
                double maxlon=Math.Max(lowerCorner.TypedValue[0], upperCorner.TypedValue[0]);
                double minlat=Math.Min(lowerCorner.TypedValue[1], upperCorner.TypedValue[1]);
                double maxlat=Math.Max(lowerCorner.TypedValue[1], upperCorner.TypedValue[1]);

                sink.BeginFigure(minlon, minlat, null);
                sink.AddLine(maxlon, minlat, null);
                sink.AddLine(maxlon, maxlat, null);
                sink.AddLine(minlon, maxlat, null);
                sink.AddLine(minlon, minlat, null);
                sink.EndFigure();
            }

            sink.EndGeometry();
        }

        internal protected void SetCoordinateSystem(ICoordinateSystem system)
        {
            CoordinateSystem=system;
        }

        internal protected void BeginGeometry(GeometryType type)
        {
        }

        internal protected void BeginFigure(double x, double y, double? z)
        {
            AddLine(x, y, z);
        }

        internal protected void AddLine(double x, double y, double? z)
        {
            // Bug in LinqToXsd: serialization is culture dependent...
            // lowerCorner.TypedValue[0]=x;
            // lowerCorner.TypedValue[1]=y;

            IList<double> lc=null;
            if (lowerCorner==null)
            {
                lowerCorner=new DirectPositionType();
                lc=new double[] { x, y };
            } else
            {
                lc=new List<double>(lowerCorner.TypedValue);

                if (lc[0]>x)
                    lc[0]=x;
                if (lc[1]>y)
                    lc[1]=y;
            }

            IList<double> uc=null;
            if (upperCorner==null)
            {
                upperCorner=new DirectPositionType();
                uc=new double[] { x, y };
            } else
            {
                uc=new List<double>(upperCorner.TypedValue);

                if (uc[0]<x)
                    uc[0]=x;
                if (uc[1]<y)
                    uc[1]=y;
            }

            lowerCorner.Untyped.Value=string.Join(
                " ",
                lc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );
            upperCorner.Untyped.Value=string.Join(
                " ",
                uc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
            );
        }

        internal protected void EndFigure()
        {
        }

        internal protected void EndGeometry()
        {
        }

        void IGeometrySink.SetCoordinateSystem(ICoordinateSystem system)
        {
            SetCoordinateSystem(system);
        }

        void IGeometrySink.BeginGeometry(GeometryType type)
        {
            BeginGeometry(type);
        }

        void IGeometrySink.BeginFigure(double x, double y, double? z)
        {
            BeginFigure(x, y, z);
        }

        void IGeometrySink.AddLine(double x, double y, double? z)
        {
            AddLine(x, y, z);
        }

        void IGeometrySink.EndFigure()
        {
            EndFigure();
        }

        void IGeometrySink.EndGeometry()
        {
            EndGeometry();
        }

        ISimpleGeometry ISimpleGeometry.Envelope()
        {
            return this;
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                if (srsName==null)
                    return ServiceLocator.Current.GetInstance<ICoordinateSystemProvider>().Wgs84;

                return ServiceLocator.Current.GetInstance<ICoordinateSystemProvider>().GetById(Srid.CreateFromCrs(srsName));
            }
            internal set
            {
                if (value!=null)
                {
                    srsName=new Srid(value.Code).Crs;
                    srsDimension=value.Dimension;
                } else
                {
                    srsName=null;
                    srsDimension=null;
                }
            }
        }

        //public SqlGeometry Geometry
        //{
        //    get
        //    {
        //        if ((lowerCorner==null) || (lowerCorner.TypedValue==null))
        //            return null;
        //        if ((upperCorner==null) || (upperCorner.TypedValue==null))
        //            return null;

        //        Debug.Assert(lowerCorner.TypedValue.Count==2);
        //        Debug.Assert(upperCorner.TypedValue.Count==2);

        //        var builder=new SqlGeometryBuilder();
        //        if (srsName!=null)
        //            builder.SetSrid(Srid.CreateFromCrs(srsName).Value);
        //        else
        //            builder.SetSrid(4326); // WGS84
        //        builder.BeginGeometry(OpenGisGeometryType.LineString);
        //        builder.BeginFigure(lowerCorner.TypedValue[0], lowerCorner.TypedValue[1]);
        //        builder.AddLine(upperCorner.TypedValue[0], upperCorner.TypedValue[1]);
        //        builder.EndFigure();
        //        builder.EndGeometry();

        //        return builder.ConstructedGeometry.STEnvelope();
        //    }
        //    set
        //    {
        //        if (value==null)
        //        {
        //            lowerCorner=null;
        //            upperCorner=null;
        //        }

        //        srsName=new Srid(value.STSrid.Value).Crs;

        //        var lc=new List<double>(2);
        //        var uc=new List<double>(2);

        //        var envelope=value.STEnvelope();
        //        var p1=envelope.STPointN(1);
        //        var p2=envelope.STPointN(3);

        //        var xmin=Math.Min(p1.STX.Value, p2.STX.Value);
        //        var ymin=Math.Min(p1.STY.Value, p2.STY.Value);
        //        var xmax=Math.Max(p1.STX.Value, p2.STX.Value);
        //        var ymax=Math.Max(p1.STY.Value, p2.STY.Value);

        //        lc.Add(xmin);
        //        lc.Add(ymin);
        //        uc.Add(xmax);
        //        uc.Add(ymax);

        //        // Bug in LinqToXsd: serialization is culture dependent...
        //        //lowerCorner=lc;
        //        //upperCorner=uc;

        //        lowerCorner=new DirectPositionType() {
        //            TypedValue=new List<double>()
        //        };
        //        foreach (XElement el in lowerCorner.Untyped.Descendants("{http://www.opengis.net/gml}DirectPositionType"))
        //            el.Value=string.Join(
        //                " ",
        //                lc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
        //            );
        //        upperCorner=new DirectPositionType() {
        //            TypedValue=new List<double>()
        //        };
        //        foreach (XElement el in upperCorner.Untyped.Descendants("{http://www.opengis.net/gml}DirectPositionType"))
        //            el.Value=string.Join(
        //                " ",
        //                uc.Select<double, string>(d => d.ToString(CultureInfo.InvariantCulture))
        //            );
        //    }
        //}
    }
#pragma warning restore 3009
}
