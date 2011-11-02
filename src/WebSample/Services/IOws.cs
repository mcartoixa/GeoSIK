using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.WebSample.Services
{
    [ServiceContract]
    public interface IOwsGetMethod
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport), Name="TestExceptionName")]
        [WebGet(UriTemplate="?service={service}&version={version}&request={request}", BodyStyle=WebMessageBodyStyle.Bare, RequestFormat=WebMessageFormat.Xml, ResponseFormat=WebMessageFormat.Xml)]
        Message Execute(string service, string version, string request);
    }

    [ServiceContract]
    [ServiceKnownType("GetRequestTypes", typeof(OgcToolkit.Services.Ows.ServiceLocator))]
    public interface IOwsPostMethod
    {

        [OperationContract]
        [FaultContract(typeof(Ows100.ExceptionReport), Name="TestExceptionName")]
        [WebInvoke(Method="POST", UriTemplate="", BodyStyle=WebMessageBodyStyle.Bare, RequestFormat=WebMessageFormat.Xml, ResponseFormat=WebMessageFormat.Xml)]
        Message Execute(OgcToolkit.Services.Ows.IRequest request);
    }
}
