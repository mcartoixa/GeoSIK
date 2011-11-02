using System;
using System.Xml.Serialization;
using OgcToolkit.Services.Ows;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{
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

    partial class DescribeRecord:
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
}
