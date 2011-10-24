using System;
using System.Xml.Serialization;
using OgcToolkit.Services;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{
    partial class GetCapabilities:
        IOwsRequest
    {

        [XmlIgnore]
        string IOwsRequest.Version
        {
            get { return null; }
        }

        [XmlIgnore]
        string IOwsRequest.Service
        {
            get { return this.Content.service; }
        }
    }

    partial class DescribeRecord:
        IOwsRequest
    {

        [XmlIgnore]
        string IOwsRequest.Version
        {
            get { return Content.version; }
        }

        [XmlIgnore]
        string IOwsRequest.Service
        {
            get { return Content.service; }
        }
    }

    partial class GetRecordById:
        IOwsRequest
    {

        [XmlIgnore]
        string IOwsRequest.Version
        {
            get { return Content.version; }
        }

        [XmlIgnore]
        string IOwsRequest.Service
        {
            get { return Content.service; }
        }
    }
}
