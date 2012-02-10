////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using Csw202Service=GeoSik.Services.Csw.V202;
using SqlTypes=Microsoft.SqlServer.Types;

namespace GeoSik.WebSample.Models.ModelFirst
{

    [MetadataType(typeof(MFRecordMetaData))]
    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    partial class MFRecord:
        Csw202Service.IRecord
    {

        Csw202Service.IRecordConverter Csw202Service.IRecord.GetConverter(XmlNamespaceManager namespaceManager)
        {
            return new Csw202Service.RecordConverter(namespaceManager);
        }

        [NotMapped]
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws, Order=8, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.BoundingBox)]
        public IGeometry BoundingBox
        {
            get
            {
                if (Coverage!=null)
                {
                    using (var ms=new MemoryStream(Coverage))
                        using (var br=new BinaryReader(ms))
                        {
                            var g=new SqlTypes.SqlGeography();
                            g.Read(br);
                            return new SqlServer.SqlGeographyWrapper(g);
                        }
                }

                return null;
            }
            set
            {
                if (value!=null)
                {
                    using (var ms=new MemoryStream())
                        using (var bw=new BinaryWriter(ms))
                        {
                            ((SqlTypes.SqlGeography)((SqlServer.SqlGeographyWrapper)value)).Write(bw);
                            Coverage=ms.ToArray();
                        }
                } else
                    Coverage=null;
            }
        }
    }

    [MetadataType(typeof(MFRecordSubjectMetaData))]
    partial class MFRecordSubject
    {
    }

    public class MFRecordMetaData
    {

        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=0, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Identifier)]
        public string Identifier { get; set; }

        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=1, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Title)]
        public string Title { get; set; }

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Subject)]
        public MFRecordSubject Subject { get; set; }

        [XmlElement("abstract", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=3, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Abstract)]
        public string Description { get; set; }

        [XmlElement("date", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=4)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Modified)]
        public string Date { get; set; }

        [XmlElement("type", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=5, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Type)]
        public string Type { get; set; }

        [XmlElement("format", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=6, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Format)]
        public string Format { get; set; }

        [XmlElement("spatial", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=7, IsNullable=false)]
        public string Spatial { get; set; }

        [XmlIgnore]
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws)] // Mandatory synonym: will be used by LINQ to Entities requests instead of BoundingBox...
        public byte[] Coverage { get; set; }

        [XmlElement("relation", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=9, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Association)]
        public string Relation { get; set; }

        [XmlElement("AnyText", Namespace=Namespaces.OgcWebCatalogCswV202, DataType="string", Order=10, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.AnyText)]
        public string AnyText { get; set; }

        [XmlIgnore]
        public MFRecord Records1 { get; set; }
        [XmlIgnore]
        public MFRecord Records2 { get; set; }
        [XmlIgnore]
        public EntityReference<MFRecord> Records2Reference { get; set; }
    }

    public class MFRecordSubjectMetaData
    {

        [XmlText(typeof(string), DataType="string")]
        public string Subject { get; set; }

        [XmlAttribute("scheme")]
        public string SubjectScheme { get; set; }
    }
}
