using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Ows100=OgcToolkit.Ogc.Ows.V100; //TODO: should be v2.0.0

namespace OgcToolkit.Services.Ows.V200
{

    public class PoxErrorHandler:
        V100.PoxErrorHandler
    {

        protected override Message CreateMessage(FaultException fex, MessageVersion version)
        {
            var fexd=fex as WebFaultException<Ows100.ExceptionReport>;
            if (fexd==null)
                WebOperationContext.Current.OutgoingResponse.StatusCode=HttpStatusCode.InternalServerError;
            else
                WebOperationContext.Current.OutgoingResponse.StatusCode=fexd.StatusCode;

            return base.CreateMessage(fex, version);
        }

    }
}
