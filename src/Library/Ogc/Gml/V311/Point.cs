////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3009
    partial class Point
    {

        internal protected override void Populate(IGeometrySink sink)
        {
            sink.BeginGeometry(OpenGisGeometryType.Point);

            Debug.Assert((pos.TypedValue!=null) && (pos.TypedValue.Count==2));
            sink.BeginFigure(pos.TypedValue[0], pos.TypedValue[1], null, null);
            sink.EndFigure();
            sink.EndGeometry();
        }

        public override SqlGeometry Geometry
        {
            get
            {
                if ((pos==null) || (pos.TypedValue==null) || (pos.TypedValue.Count<2))
                    return null;

                return base.Geometry;
            }
            set
            {
                base.Geometry=value;
            }
        }
    }
#pragma warning restore 3009
}
