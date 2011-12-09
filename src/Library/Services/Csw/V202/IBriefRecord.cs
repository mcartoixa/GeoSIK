using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OgcToolkit.Services.Csw.V202
{

    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    public interface IBriefRecord
    {

        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, Order=0, IsNullable=false)]
        Guid Id { get; set; }
        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, Order=1, IsNullable=false)]
        string Title { get; set; }
        [XmlElement("type", Namespace=Namespaces.DublinCoreElementsV11, Order=2, IsNullable=false)]
        string Type { get; set; }
    }

}
