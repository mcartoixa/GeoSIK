using System;
using System.Collections.Generic;
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

namespace OgcToolkit.Services.Ows
{

    /// <summary>Handles OWS exceptions according to [OGC 06-121r9, §8].</summary>
    public class ErrorHandler:
        IErrorHandler
    {

        public bool HandleError(Exception error)
        {
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            var aex=error as AggregateException;
            if (aex!=null)
                if (aex.InnerExceptions.Count>1)
                    error=new OwsException(OwsExceptionCode.NoApplicableCode, _Reason, error);
                else
                    error=aex.InnerExceptions[0];

            var fex=error as FaultException;
            if (fex==null)
            {
                if (error is NotImplementedException)
                    error=new OwsException(OwsExceptionCode.OperationNotSupported, _Reason, error);

                var oex=error as OwsException;
                if (oex!=null)
                {
                    // [OGC 06-121r9, §8.6]
                    var status=HttpStatusCode.InternalServerError;
                    switch (oex.Code)
                    {
                    case OwsExceptionCode.InvalidParameterValue:
                    case OwsExceptionCode.InvalidUpdateSequence:
                    case OwsExceptionCode.MissingParameterValue:
                        status=HttpStatusCode.BadRequest;
                        break;
                    case OwsExceptionCode.OperationNotSupported:
                    case OwsExceptionCode.OptionNotSupported:
                        status=HttpStatusCode.NotImplemented;
                        break;
                    }
                    fex=new WebFaultException<Ows100.ExceptionReport>((Ows100.ExceptionReport)oex, status);
                } else
                {
                    FaultCode fc=FaultCode.CreateReceiverFaultCode("InternalServerError", "http://schemas.microsoft.com/2009/WebFault");
                    fex=new FaultException(_Reason, fc);
                }
            }

            fault=CreateMessage(fex, version);
        }

        protected virtual Message CreateMessage(FaultException fex, MessageVersion version)
        {
            MessageFault mf=fex.CreateMessageFault();
            return Message.CreateMessage(version, mf, null);
        }

        private const string _Reason="A server error has occured.";
    }
}
