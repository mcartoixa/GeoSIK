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
