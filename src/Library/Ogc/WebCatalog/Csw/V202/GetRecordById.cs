using System;
using System.Xml.Serialization;
using OgcToolkit.Services.Ows;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{

#pragma warning disable 3009
    partial class GetRecordById:
        IRequest
    {

        [XmlIgnore]
        string IRequest.Version
        {
            get { return Content.version; }
        }

        [XmlIgnore]
        string IRequest.Service
        {
            get { return Content.service; }
        }
    }
#pragma warning restore 3009
}
