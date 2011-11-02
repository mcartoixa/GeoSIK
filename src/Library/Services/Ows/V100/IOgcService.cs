using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Ows.V100
{

    [ServiceContract]
    public interface IOgcService
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport))]
        Ows100.CapabilitiesBaseType GetCapabilities(Ows100.GetCapabilities request);
    }
}
