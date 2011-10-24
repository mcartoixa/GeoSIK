using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OgcToolkit.WebSample
{
    public class Global: System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            OgcToolkit.Services.Csw.V202.Discovery.GettingServiceEndPoints+=Discovery202_GettingServiceEndPoints;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

            OgcToolkit.Services.Csw.V202.Discovery.GettingServiceEndPoints-=Discovery202_GettingServiceEndPoints;
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

        static void Discovery202_GettingServiceEndPoints(object sender, OgcToolkit.Services.OwsServiceEndPointsEventArgs e)
        {
            Uri baseUri=null;
            if (HttpContext.Current!=null)
                baseUri=new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "{0}://{1}{2}/",
                        HttpContext.Current.Request.Url.Scheme,
                        HttpContext.Current.Request.Url.Authority,
                        HttpContext.Current.Request.ApplicationPath.TrimEnd('/')
                    )
                );
            else if (WebOperationContext.Current!=null)
                baseUri=new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "{0}://{1}/",
                        WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri.Scheme,
                        WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri.Authority
                    )
                );

            if (baseUri==null)
                return;

            e.EndPoints.Add(
                new OgcToolkit.Services.OwsEndPoint()
                {
                    AddOperationName=false,
                    BaseUri=new Uri(baseUri, "Services/Ows.svc/"),
                    Method=OgcToolkit.Services.OwsMethod.Get
                }
            );
            //e.EndPoints.Add(
            //    new Isogeo.Ogc.Services.OwsEndPoint() {
            //        AddOperationName=false,
            //        BaseUri=new Uri(baseUri, "Services/Ows.svc/xml/"),
            //        Method=Isogeo.Ogc.Services.OwsMethod.Xml
            //    }
            //);
            e.EndPoints.Add(
                new OgcToolkit.Services.OwsEndPoint()
                {
                    AddOperationName=true,
                    BaseUri=new Uri(baseUri, "Services/Csw.svc/xml/"),
                    Method=OgcToolkit.Services.OwsMethod.Xml
                }
            );
        }

    }
}
