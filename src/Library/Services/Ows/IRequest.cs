using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OgcToolkit.Services.Ows
{

    public interface IRequest:
        IXmlSerializable
    {
        [XmlIgnore]
        string Version { get; }
        [XmlIgnore]
        string Service { get; }
    }
}
