using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{

    /// <summary>Interface implemented by an answer to the <see cref="GetRecords" /> request.</summary>
    /// <remarks>
    ///   <para><a href="http://portal.opengeospatial.org/files/?artifact_id=20555">[OCG 07-006r1 §10.8]</a> specifies that an answer to the <see cref="GetRecords" />
    /// request can either be <see cref="GetRecordsResponse" /> or <see cref="Acknoledgement" />.</para>
    /// </remarks>
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Justification="We need to be able to identify GetRecords responses, IXmlSerializable instances")]
    public interface IGetRecordsResponse:
        IXmlSerializable
    {
    }
}
