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
using System.Threading.Tasks;
using System.Xml.Serialization;
using Common.Logging;
using Xml.Schema.Linq;

namespace GeoSik.Ogc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Base implementation of an OGC service request processor.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public abstract class OgcRequestProcessor<TRequest, TResponse>
        where TRequest:
            Ows.IRequest
        where TResponse:
            IXmlSerializable
    {

        /// <summary>Creates a new instance of the <see cref="OgcRequestProcessor{TRequest,TResponse}" /> type.</summary>
        private OgcRequestProcessor()
        {
        }

        /// <summary>Creates a new instance of the <see cref="OgcRequestProcessor{TRequest,TResponse}" /> type.</summary>
        /// <param name="service">The service associated to the processor.</param>
        protected OgcRequestProcessor(OgcService service)
        {
            Debug.Assert(service!=null);
            if (service==null)
                throw new ArgumentNullException("service");

            _Service=service;
        }

        /// <summary>Processes the request specified as key/value parameters.</summary>
        /// <param name="parameters">The request parameters in key/value format.</param>
        /// <returns>The response to the request.</returns>
        public async Task<TResponse> ProcessAsync(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            return await ProcessAsync(CreateRequest(parameters));
        }

        /// <summary>Processes the specified request.</summary>
        /// <param name="request">The request to process.</param>
        /// <returns>The response to the request.</returns>
        public virtual async Task<TResponse> ProcessAsync(TRequest request)
        {
            Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing started"));
            Logger.Debug(CultureInfo.InvariantCulture, m => m("> {0}", OgcService.ToTraceString(request)));

            CheckRequest(request);

            TResponse ret=await ProcessRequestAsync(request);

            var args=new Ows.OwsRequestEventArgs<TRequest, TResponse>(request, ret);
            OnProcessed(args);

            Debug.Assert(args.Response!=null);
            Logger.Debug(CultureInfo.InvariantCulture, m => m("< {0}", OgcService.ToTraceString(args.Response)));
            Logger.Debug(CultureInfo.InvariantCulture, m => m("Request processing finished"));
            return args.Response;
        }

        /// <summary>Checks that the specified request is valid.</summary>
        /// <param name="request">The request to check.</param>
        protected virtual void CheckRequest(TRequest request)
        {
            Service.CheckRequest(request);
        }

        /// <summary>Creates a request from the specified key/value parameters.</summary>
        /// <param name="parameters">The request parameters in key/value format.</param>
        /// <returns>The request.</returns>
        protected abstract TRequest CreateRequest(NameValueCollection parameters);
        /// <summary>Processes the specified request.</summary>
        /// <param name="request">The request to process.</param>
        /// <returns>The response to the request.</returns>
        /// <remarks>
        ///   <para>The specified request should be considered as valid, as defined by the implementation
        /// of the <see cref="OgcRequestProcessor{TRequest,TResponse}.CheckRequest" /> method.</para>
        /// </remarks>
        protected abstract Task<TResponse> ProcessRequestAsync(TRequest request);

        /// <summary>Triggers the <see cref="OgcRequestProcessor{TRequest,TResponse}.Processed" /> event.</summary>
        /// <param name="e">The parameters for the event.</param>
        protected virtual void OnProcessed(Ows.OwsRequestEventArgs<TRequest, TResponse> e)
        {
            var eh=Processed;
            if (eh!=null)
                eh(this, e);
        }

        /// <summary>Gets a logger for the current processor.</summary>
        protected ILog Logger
        {
            get
            {
                return Service.InternalLogger;
            }
        }

        /// <summary>Gets the service associated to the current processor.</summary>
        protected OgcService Service
        {
            get
            {
                return _Service;
            }
        }

        /// <summary>Event triggered when a request has been processed.</summary>
        public event EventHandler<Ows.OwsRequestEventArgs<TRequest, TResponse>> Processed;

        private OgcService _Service;
    }
}
