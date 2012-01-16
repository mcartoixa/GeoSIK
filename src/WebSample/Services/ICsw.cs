using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OgcToolkit.WebSample.Services
{

    [ServiceContract]
    public interface ICsw:
        OgcToolkit.Services.Csw.V202.IDiscovery
    {
    }
}
