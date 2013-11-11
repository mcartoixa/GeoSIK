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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Common.Logging;
using Xml.Schema.Linq;

namespace GeoSik.Ogc
{

    public abstract class OgcRequestProcessor<TRequest, TResponse>
        where TRequest:
            Ows.IRequest
        where TResponse:
            IXmlSerializable
    {

        private OgcRequestProcessor()
        {
        }

        protected OgcRequestProcessor(OgcService service)
        {
            Debug.Assert(service!=null);
            if (service==null)
                throw new ArgumentNullException("service");

            _Service=service;
        }

        public TResponse Process(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return Process(CreateRequest(parameters));
        }

        public virtual TResponse Process(TRequest request)
        {
            Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing started"));
            Logger.Debug(CultureInfo.InvariantCulture, m => m("> {0}", OgcService.ToTraceString(request)));

            CheckRequest(request);

            TResponse ret=ProcessRequest(request);

            var args=new Ows.OwsRequestEventArgs<TRequest, TResponse>(request, ret);
            OnProcessed(args);

            Debug.Assert(args.Response!=null);
            Logger.Debug(CultureInfo.InvariantCulture, m => m("< {0}", OgcService.ToTraceString(args.Response)));
            Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing finished"));
            return args.Response;
        }

        protected virtual void CheckRequest(TRequest request)
        {
            Service.CheckRequest(request);
        }

        protected abstract TRequest CreateRequest(NameValueCollection parameters);
        protected abstract TResponse ProcessRequest(TRequest request);

        protected virtual void OnProcessed(Ows.OwsRequestEventArgs<TRequest, TResponse> e)
        {
            var eh=Processed;
            if (eh!=null)
                eh(this, e);
        }

        protected ILog Logger
        {
            get
            {
                return Service.InternalLogger;
            }
        }

        protected OgcService Service
        {
            get
            {
                return _Service;
            }
        }

        public event EventHandler<Ows.OwsRequestEventArgs<TRequest, TResponse>> Processed;

        private OgcService _Service;
    }
}
