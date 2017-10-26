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

using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Ows100 =GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{

    [ServiceContract]
    public interface IDiscovery
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Task<Types.Capabilities> GetCapabilitiesAsync(Types.GetCapabilities request, CancellationToken cancellationToken);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        [ServiceKnownType(typeof(Types.GetRecordsResponse))]
        [ServiceKnownType(typeof(Types.Acknowledgement))]
        Task<Types.IGetRecordsResponse> GetRecordsAsync(Types.GetRecords request, CancellationToken cancellationToken);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Task<Types.DescribeRecordResponse> DescribeRecordAsync(Types.DescribeRecord request, CancellationToken cancellationToken);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Task<Types.GetDomainResponse> GetDomainAsync(Types.GetDomain request, CancellationToken cancellationToken);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Task<Types.GetRecordByIdResponse> GetRecordByIdAsync(Types.GetRecordById request, CancellationToken cancellationToken);
    }
}
