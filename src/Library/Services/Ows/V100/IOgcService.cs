using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ows=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services
{

    [ServiceContract]
    public interface IOgcService
    {

        [OperationContract]
        [FaultContract(typeof(Ows.ExceptionReport))]
        Ows.CapabilitiesBaseType GetCapabilities(Ows.GetCapabilities request);
    }
}
