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
using Ows100=GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{

    [ServiceContract]
    public interface IDiscovery
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Types.Capabilities GetCapabilities(Types.GetCapabilities request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        [ServiceKnownType(typeof(Types.GetRecordsResponse))]
        [ServiceKnownType(typeof(Types.Acknowledgement))]
        Types.IGetRecordsResponse GetRecords(Types.GetRecords request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Types.DescribeRecordResponse DescribeRecord(Types.DescribeRecord request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Types.GetDomainResponse GetDomain(Types.GetDomain request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Types.GetRecordByIdResponse GetRecordById(Types.GetRecordById request);
    }
}
