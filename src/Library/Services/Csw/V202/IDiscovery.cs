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
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Csw.V202
{

    [ServiceContract]
    public interface IDiscovery
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Csw202.Capabilities GetCapabilities(Csw202.GetCapabilities request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        [ServiceKnownType(typeof(Csw202.GetRecordsResponse))]
        [ServiceKnownType(typeof(Csw202.Acknowledgement))]
        Csw202.IGetRecordsResponse GetRecords(Csw202.GetRecords request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Csw202.DescribeRecordResponse DescribeRecord(Csw202.DescribeRecord request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Csw202.GetDomainResponse GetDomain(Csw202.GetDomain request);

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Csw202.GetRecordByIdResponse GetRecordById(Csw202.GetRecordById request);
    }
}
