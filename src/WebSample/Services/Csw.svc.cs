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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Csw202=GeoSik.Ogc.WebCatalog.Csw.V202;

namespace GeoSik.WebSample.Services
{
    public class Csw:
        ICsw
    {

        public Csw202.Types.Capabilities GetCapabilities(Csw202.Types.GetCapabilities request)
        {
            return _Implementation.GetCapabilities(request);
        }

        public Csw202.Types.IGetRecordsResponse GetRecords(Csw202.Types.GetRecords request)
        {
            return _Implementation.GetRecords(request);
        }

        public Csw202.Types.DescribeRecordResponse DescribeRecord(Csw202.Types.DescribeRecord request)
        {
            return _Implementation.DescribeRecord(request);
        }

        public Csw202.Types.GetDomainResponse GetDomain(Csw202.Types.GetDomain request)
        {
            throw new NotImplementedException();
        }

        public Csw202.Types.GetRecordByIdResponse GetRecordById(Csw202.Types.GetRecordById request)
        {
            return _Implementation.GetRecordById(request);
        }

        private Csw202.IDiscovery _Implementation=new Discovery();
    }
}
