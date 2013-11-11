////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using GeoSik.Ogc.Ows;

namespace GeoSik.WebSample.Services
{

    public class Ows:
        IOwsGetMethod,
        IOwsPostMethod
    {

        public Message Execute(string service, string version, string request)
        {
            NameValueCollection parameters=WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters;

            IXmlSerializable response=ServiceLocatorInstance.InvokeService(parameters);
            return CreateMessage(response, OperationContext.Current.IncomingMessageVersion);
        }

        public Message Execute(IRequest request)
        {
            IXmlSerializable response=ServiceLocatorInstance.InvokeService(request);
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

        internal static ServiceLocator ServiceLocatorInstance
        {
            get
            {
                if (_Instance==null)
                    lock (syncRoot)
                        if (_Instance==null)
                            _Instance=new ServiceLocator(Assembly.GetExecutingAssembly());

                return _Instance;
            }
        }

        private static volatile ServiceLocator _Instance;
        private static object syncRoot=new object();
    }
}
