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
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Ows.V100
{

    public class PoxErrorHandler:
        ErrorHandler
    {

        protected override Message CreateMessage(FaultException fex, MessageVersion version)
        {
            var fexd=fex as WebFaultException<Ows100.ExceptionReport>;
            if (fexd==null)
            {
                var oex=new OwsException(OwsExceptionCode.NoApplicableCode, fex);
                fexd=new WebFaultException<Ows100.ExceptionReport>((Ows100.ExceptionReport)oex, HttpStatusCode.InternalServerError);
            }

            return WebOperationContext.Current.CreateXmlResponse<Ows100.ExceptionReport>(fexd.Detail);
        }

    }
}
