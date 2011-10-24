using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OgcToolkit.WebSample.Services
{

    public class Ows:
        IOwsGetMethod,
        IOwsPostMethod
    {

        public Message Execute(string service, string version, string request)
        {
            NameValueCollection parameters=WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters;

            IXmlSerializable response=OgcToolkit.Services.Ows.ServiceLocator.Instance.InvokeService(parameters);
            return CreateMessage(response, OperationContext.Current.IncomingMessageVersion);
        }

        public Message Execute(OgcToolkit.Services.IOwsRequest request)
        {
            IXmlSerializable response=OgcToolkit.Services.Ows.ServiceLocator.Instance.InvokeService(request);
            return CreateMessage(response, OperationContext.Current.IncomingMessageVersion);
        }

        private static Message CreateMessage(IXmlSerializable response, MessageVersion version)
        {
            StringBuilder serialized=new StringBuilder();
            using (var xw=XmlWriter.Create(serialized))
                response.WriteXml(xw);
            var xr=XmlReader.Create(new StringReader(serialized.ToString()));
            return Message.CreateMessage(version, "ExecuteResponse", xr);
        }
    }
}
