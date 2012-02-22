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
using ProjNet.CoordinateSystems;
using FCommon=OSGeo.FDO.Common;
using FGeometry=OSGeo.FDO.Geometry;

namespace GeoSik.Fdo
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Class used to build <see cref="FdoGeometry" /> instances.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public sealed class FdoGeometryBuilder:
        GeometryTransformerSink,
        IGeometryBuilder,
        IDisposable
    {

        /// <summary>Creates a new instance of the <see cref="FdoGeometryBuilder" /> class.</summary>
        public FdoGeometryBuilder():
            base()
        {
        }

        /// <summary>Creates a new instance of the <see cref="FdoGeometryBuilder" /> class.</summary>
        /// <param name="targetSystem">The target coordinate system. If different from the source, transformations will occur.</param>
        public FdoGeometryBuilder(ICoordinateSystem targetSystem):
            base(targetSystem)
        {
        }

        /// <summary>Finalizes the current instance.</summary>
        ~FdoGeometryBuilder()
        {
            Dispose(false);
        }

        /// <summary>Releases native resources associated with the current instance.</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Starts the call sequence for the specified <see cref="GeometryType" />.</summary>
        /// <param name="type">The type of the geometry to build.</param>
        public override void BeginGeometry(GeometryType type)
        {
            _GeometryType=GeometryTypeUtils.Convert(type);
        }

        /// <summary>Defines a point other than the starting point of a geometry figure.</summary>
        /// <param name="x">The eastings of the point, in the target coordinate system.</param>
        /// <param name="y">The northings of the point, in the target coordinate system.</param>
        /// <param name="z">The elevation of the point, in the target coordinate system.</param>
        protected override void DoBeginFigure(double x, double y, double? z)
        {
            _Figures.AddLast(new FGeometry.DirectPositionCollection());
            DoAddLine(x, y, z);
        }

        /// <summary>Defines the starting point of a geometry figure.</summary>
        /// <param name="x">The easting of the point, in the target coordinate system.</param>
        /// <param name="y">The northing of the point, in the target coordinate system..</param>
        /// <param name="z">The elevation of the point, in the target coordinate system..</param>
        protected override void DoAddLine(double x, double y, double? z)
        {
            LinkedListNode<FGeometry.DirectPositionCollection> last=_Figures.Last;
            if (z.HasValue)
                last.Value.Add(_Factory.CreatePositionXYZ(x, y, z.Value));
            else
                last.Value.Add(_Factory.CreatePositionXY(x, y));
        }

        /// <summary>Returns the geometry defined by the specified WKT representation, in the specified coordinate system.</summary>
        /// <param name="text">The WKT representation of the geometry.</param>
        /// <param name="system">The coordinate system of the WKT representation.</param>
        public void Parse(string text, ICoordinateSystem system)
        {
            Debug.Assert(system!=null);
            if (system==null)
                throw new ArgumentNullException("system");

            var g=Factory.CreateGeometry(text);

            if ((TargetSystem!=null) && ((system!=TargetSystem) || !system.EqualParams(TargetSystem)))
            {
                if (_Geometry!=null)
                {
                    _Geometry.Dispose();
                    _Geometry=null;
                }
                using (var orig=new FdoGeometry(g, system))
                    orig.Populate(this);
            } else
                _Geometry=new FdoGeometry(g, system);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Geometry!=null)
                    _Geometry.Dispose();

                foreach (FGeometry.DirectPositionCollection dpc in _Figures)
                    if (!dpc.Disposed)
                        dpc.Dispose();
            }

            _Factory=null;
            _Geometry=null;

            if (_Figures!=null)
                _Figures.Clear();
            _Figures=null;
        }

        /// <summary>Returns the geometry resulting from the actions on the current <see cref="FdoGeometryBuilder" />.</summary>
        /// <remarks>
        ///   <para>It is the responsibility of the caller to <see cref="IDisposable.Dispose()" /> the returned geometry.</para>
        /// </remarks>
        public FdoGeometry ConstructedGeometry
        {
            get
            {
                if (_Geometry==null)
                {
                    switch (_GeometryType)
                    {
                    case FCommon.GeometryType.GeometryType_Point:
                        using (FGeometry.IDirectPosition p=_Figures.First.Value[0])
                            _Geometry=new FdoGeometry(Factory.CreatePoint(p), TargetSystem);
                        break;
                    case FCommon.GeometryType.GeometryType_Polygon:
                        using (FGeometry.ILinearRing exterior=Factory.CreateLinearRing(_Figures.First.Value))
                            using (var interior=new FGeometry.LinearRingCollection())
                            {
                                LinkedListNode<FGeometry.DirectPositionCollection> current=_Figures.First;
                                while (current.Next!=_Figures.First)
                                    interior.Add(Factory.CreateLinearRing(current.Value));

                                _Geometry=new FdoGeometry(Factory.CreatePolygon(exterior, interior), TargetSystem);
                            }
                        break;
                    default:
                        //TODO: implement other geometry types...
                        throw new NotImplementedException();
                    }
                }

                // return a copy
                return new FdoGeometry(_Factory.CreateGeometry(FdoGeometry.ToGeometry(_Geometry)), TargetSystem);
            }
        }

        ISimpleGeometry IGeometryBuilder.ConstructedGeometry
        {
            get
            {
                return ConstructedGeometry;
            }
        }

        internal static FGeometry.FgfGeometryFactory Factory
        {
            get
            {
                if (_Factory==null)
                    lock (_SyncRoot)
                        if (_Factory==null)
                            _Factory=new FGeometry.FgfGeometryFactory();

                return _Factory;
            }
        }

        private FCommon.GeometryType _GeometryType;
        private LinkedList<FGeometry.DirectPositionCollection> _Figures=new LinkedList<FGeometry.DirectPositionCollection>();

        private FdoGeometry _Geometry;

        private static FGeometry.FgfGeometryFactory _Factory;
        private static object _SyncRoot=new object();
    }
}
