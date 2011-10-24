using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace OgcToolkit.Services.Ows.V100
{

    public class PoxFaultBehavior:
        IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            var eh=new PoxErrorHandler();

            foreach (ChannelDispatcherBase cdb in serviceHostBase.ChannelDispatchers)
                ((ChannelDispatcher)cdb).ErrorHandlers.Insert(0, eh);
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }
    }

    public class PoxFaultBehaviorExtensionElement:
        BehaviorExtensionElement
    {

        public override Type BehaviorType
        {
            get { return typeof(PoxFaultBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new PoxFaultBehavior();
        }
    }

}