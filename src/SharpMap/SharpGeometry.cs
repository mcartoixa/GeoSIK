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
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ProjNet.CoordinateSystems;
using SmGeometries=SharpMap.Geometries;

namespace GeoSik.SharpMap
{

#pragma warning disable 3001, 3002
    public class SharpGeometry:
        IGeometry
    {

        private SharpGeometry()
        {
        }

        public SharpGeometry(SmGeometries.Geometry geometry)
        {
            Debug.Assert(geometry!=null);
            if (geometry==null)
                throw new ArgumentNullException("geometry");
            Debug.Assert(geometry.SpatialReference!=null);
            if (geometry.SpatialReference==null)
                throw new ArgumentException("", "geometry");

            _Geometry=geometry;
        }

        public IGeometry Centroid()
        {
            var pol=_Geometry as SmGeometries.Polygon;
            if (pol!=null)
                return new SharpGeometry(pol.Centroid);

            throw new NotSupportedException();
        }

        public double Distance(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Distance(other._Geometry);
        }

        public bool Disjoint(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Disjoint(other._Geometry);
        }

        public bool Touches(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Touches(other._Geometry);
        }

        public bool Within(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Within(other._Geometry);
        }

        public bool Overlaps(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Overlaps(other._Geometry);
        }

        public bool Crosses(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Crosses(other._Geometry);
        }

        public bool Intersects(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Intersects(other._Geometry);
        }

        public bool Contains(IGeometry geometry)
        {
            SharpGeometry other=Convert(geometry);
            return _Geometry.Contains(other._Geometry);
        }

        public bool Relate(IGeometry geometry)
        {
            throw new NotImplementedException();
        }

        public ISimpleGeometry Envelope()
        {
            return new SharpGeometry(_Geometry.Envelope());
        }

        public void Populate(IGeometrySink sink)
        {
            sink.SetCoordinateSystem(CoordinateSystem);
            sink.BeginGeometry(GeometryTypeUtils.Convert(_Geometry.GeometryType));

            switch (_Geometry.GeometryType)
            {
            case SmGeometries.GeometryType2.LineString:
                CreateFigure(sink, ((SmGeometries.LineString)_Geometry).Vertices);
                break;
            case SmGeometries.GeometryType2.Point:
                CreateFigure(sink, new SmGeometries.Point[] { (SmGeometries.Point)_Geometry });
                break;
            case SmGeometries.GeometryType2.Polygon:
                {
                    var pol=(SmGeometries.Polygon)_Geometry;
                    CreateFigure(sink, pol.ExteriorRing.Vertices);

                    if (pol.InteriorRings!=null)
                        foreach (SmGeometries.LinearRing lr in pol.InteriorRings)
                            CreateFigure(sink, lr.Vertices);
                }
                break;
            default:
                //TODO: implement other geometry types...
                throw new NotSupportedException();
            }

            sink.EndGeometry();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        private static SharpGeometry Convert(IGeometry geometry)
        {
            var sg=geometry as SharpGeometry;
            if (sg!=null)
                return sg;

            var sgb=new SharpGeometryBuilder();
            geometry.Populate(sgb);
            return (SharpGeometry)sgb.ConstructedGeometry;
        }

        private static void CreateFigure(IGeometrySink sink, IList<SmGeometries.Point> points)
        {
            if ((points==null) || (points.Count==0))
                return;

            var p0=points[0];
            var p03=p0 as SmGeometries.Point3D;
            if (p03!=null)
                sink.BeginFigure(p03.X, p03.Y, p03.Z);
            else
                sink.BeginFigure(p0.X, p0.Y, null);

            for (int i=1; i<points.Count; ++i)
            {
                var pi=points[i];
                var pi3=pi as SmGeometries.Point3D;
                if (pi3!=null)
                    sink.AddLine(pi3.X, pi3.Y, pi3.Z);
                else
                    sink.AddLine(pi.X, pi.Y, null);
            }

            sink.EndFigure();
        }

        public static SmGeometries.Geometry ToGeometry(SharpGeometry wrapper)
        {
            return wrapper._Geometry;
        }

        public static SharpGeometry ToSharpGeometry(SmGeometries.Geometry geometry)
        {
            return new SharpGeometry(geometry);
        }

        public static implicit operator SmGeometries.Geometry(SharpGeometry wrapper)
        {
            return wrapper._Geometry;
        }

        public static explicit operator SharpGeometry(SmGeometries.Geometry geometry)
        {
            return new SharpGeometry(geometry);
        }

        public ICoordinateSystem CoordinateSystem
        {
            get
            {
                return _Geometry.SpatialReference;
            }
        }

        private SmGeometries.Geometry _Geometry;
    }
#pragma warning restore 3001, 3002
}
