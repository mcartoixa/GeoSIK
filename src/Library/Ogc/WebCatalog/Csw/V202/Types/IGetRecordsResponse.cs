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
using System.Text;
using System.Xml.Serialization;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Types
{

    /// <summary>Interface implemented by an answer to the <see cref="GetRecords" /> request.</summary>
    /// <remarks>
    ///   <para><a href="http://portal.opengeospatial.org/files/?artifact_id=20555">[OCG 07-006r1 §10.8]</a> specifies that an answer to the <see cref="GetRecords" />
    /// request can either be <see cref="GetRecordsResponse" /> or <see cref="Acknowledgement" />.</para>
    /// </remarks>
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Justification="We need to be able to identify GetRecords responses, IXmlSerializable instances")]
    public interface IGetRecordsResponse:
        IXmlSerializable
    {
    }
}
