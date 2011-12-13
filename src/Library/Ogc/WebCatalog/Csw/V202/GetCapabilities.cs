using System;
using System.Xml.Serialization;
using OgcToolkit.Services.Ows;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{

#pragma warning disable 3009
    partial class GetCapabilities:
        IRequest
    {

        [XmlIgnore]
        string IRequest.Version
        {
            get { return null; }
        }

        [XmlIgnore]
        string IRequest.Service
        {
            get { return this.Content.service; }
        }
    }
#pragma warning restore 3009
}
