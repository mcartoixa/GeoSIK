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
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeoSik.Ogc
{

    public interface IOperatorImplementationProvider
    {

        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId="1#")]
        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId="2#")]
        [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId="3#")]
        [SuppressMessage("Microsoft.Design", "CA1007:UseGenericsWhereAppropriate")]
        MethodInfo GetImplementation(string operatorName, ref Type[] arguments, ref object[] values, out object instance);
    }
}
