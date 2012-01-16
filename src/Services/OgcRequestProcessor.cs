using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Xml.Schema.Linq;
using Ows=OgcToolkit.Ogc.Ows;

namespace OgcToolkit.Services
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
            Service.Logger.Trace(CultureInfo.InvariantCulture, m => m("Request processing started"));

            CheckRequest(request);

            TResponse ret=ProcessRequest(request);

            var args=new Ows.OwsRequestEventArgs<TRequest, TResponse>(request, ret);
            OnProcessed(args);

            Debug.Assert(args.Response!=null);
            Service.Logger.Trace(CultureInfo.InvariantCulture, m => m("Request processing finished"));
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
