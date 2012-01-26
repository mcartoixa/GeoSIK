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
using System.Globalization;
using System.Linq;
using System.ServiceModel.Web;
using System.Xml.Linq;
using System.Web;
using Xml.Schema.Linq;
using OgcToolkit.Services;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.WebSample.Services
{

    [OwsDescription(Discovery.Service, Discovery.Version)]
    public class Discovery:
        OgcToolkit.Services.Csw.V202.Discovery,
        IDisposable
    {

        public class GetCapabilitiesProcessor:
            GetCapabilitiesProcessorBase
        {

            public GetCapabilitiesProcessor(Discovery service):
                base(service)
            {}

            protected override Ows100.ServiceProvider CreateServiceProviderSection()
            {
                Ows100.ServiceProvider ret=base.CreateServiceProviderSection();

                ret.ProviderSite=new Ows100.OnlineResourceType() {
                    href=new Uri("http://www.isogeo.fr/")
                };

                ret.ServiceContact=new Ows100.ResponsiblePartySubsetType() {
                    ContactInfo=new Ows100.ContactInfo() {
                        Address=new Ows100.AddressType() {
                            City="Paris",
                            Country="France",
                            ElectronicMailAddress=new string[] { "mathieu.cartoixa@isogeo.fr" },
                            PostalCode="75017"
                        }
                    }
                };

                return ret;
            }

            protected override IEnumerable<OwsEndPoint> GetEndPoints()
            {
                var ret=new List<OwsEndPoint>();

                Uri baseUri=null;
                if (HttpContext.Current!=null)
                    baseUri=new Uri(
                        string.Format(
                            CultureInfo.InvariantCulture,
                            "{0}://{1}{2}/",
                            HttpContext.Current.Request.Url.Scheme,
                            HttpContext.Current.Request.Url.Authority,
                            HttpContext.Current.Request.ApplicationPath.TrimEnd('/')
                        )
                    );
                else if (WebOperationContext.Current!=null)
                    baseUri=new Uri(
                        string.Format(
                            CultureInfo.InvariantCulture,
                            "{0}://{1}/",
                            WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri.Scheme,
                            WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri.Authority
                        )
                    );

                if (baseUri==null)
                    return ret;

                ret.Add(
                    new OgcToolkit.Services.OwsEndPoint() {
                        AddOperationName=false,
                        BaseUri=new Uri(baseUri, "Services/Ows.svc/"),
                        Method=OgcToolkit.Services.OwsMethod.Get
                    }
                );
                //e.EndPoints.Add(
                //    new Isogeo.Ogc.Services.OwsEndPoint() {
                //        AddOperationName=false,
                //        BaseUri=new Uri(baseUri, "Services/Ows.svc/xml/"),
                //        Method=Isogeo.Ogc.Services.OwsMethod.Xml
                //    }
                //);
                ret.Add(
                    new OgcToolkit.Services.OwsEndPoint() {
                        AddOperationName=true,
                        BaseUri=new Uri(baseUri, "Services/Csw.svc/xml/"),
                        Method=OgcToolkit.Services.OwsMethod.Xml
                    }
                );

                return ret;
            }
        }

        ~Discovery()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_RecordContext!=null)
                    _RecordContext.Dispose();
            }

            _RecordContext=null;
        }

        protected override OgcToolkit.Services.Csw.V202.Discovery.GetCapabilitiesProcessorBase CreateGetCapabilitiesProcessor()
        {
            return new GetCapabilitiesProcessor(this);
        }

        public override IEnumerable<IXMetaData> SupportedRecordTypes
        {
            get
            {
                return _SupportedRecordTypesInstances;
            }
        }

        protected override IQueryable GetRecordsSource(Uri outputSchema)
        {
            return RecordContext.MFRecords;
        }

        //protected override IOperatorImplementationProvider GetOperatorImplementationProvider()
        //{
        //    return new Models.CodeFirst.OperatorsImplementationProvider();
        //}

        protected override IOperatorImplementationProvider GetOperatorImplementationProvider()
        {
            return new Models.ModelFirst.OperatorsImplementationProvider();
        }

        //protected override IOperatorImplementationProvider GetOperatorImplementationProvider()
        //{
        //    return new Models.LinqToSql.OperatorsImplementationProvider(RecordContext);
        //}

        public override string ProviderName
        {
            get { return "Isogeo"; }
        }

        //protected Models.CodeFirst.RecordContext RecordContext
        //{
        //    get
        //    {
        //        if (_RecordContext==null)
        //            _RecordContext=new Models.CodeFirst.RecordContext("RecordsSource");

        //        return _RecordContext;
        //    }
        //}

        protected Models.ModelFirst.MFConceptualEntities RecordContext
        {
            get
            {
                if (_RecordContext==null)
                    _RecordContext=new Models.ModelFirst.MFConceptualEntities();

                return _RecordContext;
            }
        }

        //protected Models.LinqToSql.RecordsDataContext RecordContext
        //{
        //    get
        //    {
        //        if (_RecordContext==null)
        //            _RecordContext=new Models.LinqToSql.RecordsDataContext();

        //        return _RecordContext;
        //    }
        //}

        //private Models.CodeFirst.RecordContext _RecordContext;
        private Models.ModelFirst.MFConceptualEntities _RecordContext;
        //private Models.LinqToSql.RecordsDataContext _RecordContext;
        private static readonly IXMetaData[] _SupportedRecordTypesInstances=new IXMetaData[] { new Csw202.Record()/*, new Gmd.MD_Metadata()*/ };
    }

}
