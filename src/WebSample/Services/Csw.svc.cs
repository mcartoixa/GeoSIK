////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

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
