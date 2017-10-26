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
using System.Threading;
using System.Threading.Tasks;
using Csw202 = GeoSik.Ogc.WebCatalog.Csw.V202;

namespace GeoSik.WebSample.Services
{
    public class Csw:
        ICsw
    {

        public Task<Csw202.Types.Capabilities> GetCapabilitiesAsync(Csw202.Types.GetCapabilities request, CancellationToken cancellationToken)
        {
            return _Implementation.GetCapabilitiesAsync(request, CancellationToken.None);
        }

        public Task<Csw202.Types.IGetRecordsResponse> GetRecordsAsync(Csw202.Types.GetRecords request, CancellationToken cancellationToken)
        {
            return _Implementation.GetRecordsAsync(request, cancellationToken);
        }

        public Task<Csw202.Types.DescribeRecordResponse> DescribeRecordAsync(Csw202.Types.DescribeRecord request, CancellationToken cancellationToken)
        {
            return _Implementation.DescribeRecordAsync(request, cancellationToken);
        }

        public Task<Csw202.Types.GetDomainResponse> GetDomainAsync(Csw202.Types.GetDomain request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Csw202.Types.GetRecordByIdResponse> GetRecordByIdAsync(Csw202.Types.GetRecordById request, CancellationToken cancellationToken)
        {
            return _Implementation.GetRecordByIdAsync(request, cancellationToken);
        }

        private Csw202.IDiscovery _Implementation=new Discovery();
    }
}
