using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Csw202=OgcToolkit.Services.Csw.V202;

namespace OgcToolkit.WebSample.Services
{
    public class Csw:
        ICsw
    {

        public Ogc.WebCatalog.Csw.V202.Capabilities GetCapabilities(Ogc.WebCatalog.Csw.V202.GetCapabilities request)
        {
            return _Implementation.GetCapabilities(request);
        }

        public Ogc.WebCatalog.Csw.V202.IGetRecordsResponse GetRecords(Ogc.WebCatalog.Csw.V202.GetRecords request)
        {
            return _Implementation.GetRecords(request);
        }

        public Ogc.WebCatalog.Csw.V202.DescribeRecordResponse DescribeRecord(Ogc.WebCatalog.Csw.V202.DescribeRecord request)
        {
            return _Implementation.DescribeRecord(request);
        }

        public Ogc.WebCatalog.Csw.V202.GetDomainResponse GetDomain(Ogc.WebCatalog.Csw.V202.GetDomain request)
        {
            throw new NotImplementedException();
        }

        public Ogc.WebCatalog.Csw.V202.GetRecordByIdResponse GetRecordById(Ogc.WebCatalog.Csw.V202.GetRecordById request)
        {
            return _Implementation.GetRecordById(request);
        }

        private Discovery _Implementation=new Discovery();
    }
}
