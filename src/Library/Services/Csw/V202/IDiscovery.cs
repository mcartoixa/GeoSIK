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
