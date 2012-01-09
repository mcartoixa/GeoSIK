using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using Microsoft.SqlServer.Types;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;

namespace OgcToolkit.Services.Csw.V202
{

    /// <summary>Interface implemented by a record type.</summary>
    public interface IRecord
    {

        IRecordConverter GetConverter(XmlNamespaceManager namespaceManager);
    }

    public interface IRecordConverter
    {

        IXmlSerializable Convert(IRecord record, string elementSet);
        IXmlSerializable Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied);
    }
}
