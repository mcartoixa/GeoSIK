using System;
using System.Collections.Generic;
using DataAnnotations=System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.SqlServer.Types;
using Csw202Service=OgcToolkit.Services.Csw.V202;

namespace OgcToolkit.WebSample.Models.LinqToSql
{

    [DataAnnotations.MetadataType(typeof(RecordMetaData))]
    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    partial class Record:
        Csw202Service.IRecord
    {

        Csw202Service.IRecordConverter Csw202Service.IRecord.GetConverter(XmlNamespaceManager namespaceManager)
        {
            return new Csw202Service.RecordConverter(namespaceManager);
        }

        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws, Order=8, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.BoundingBox)]
        public SqlGeometry BoundingBox
        {
            get
            {
                if (Coverage!=null)
                {
                    using (var ms=new MemoryStream(Coverage.ToArray()))
                        using (var br=new BinaryReader(ms))
                        {
                            var ret=new SqlGeometry();
                            ret.Read(br);
                            return ret;
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
                            value.Write(bw);
                            Coverage=ms.ToArray();
                        }
                } else
                    Coverage=null;
            }
        }

        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Crs)]
        public string BoundingBoxCrs
        {
            get
            {
                if ((BoundingBox==null) || BoundingBox.STSrid.IsNull)
                    return null;

                return new Srid(BoundingBox.STSrid.Value).Crs.ToString();
            }
        }
    }

    /* Linq to SQL does not handle complex types... */
    //public class RecordSubject
    //{

    //    [XmlText(typeof(string), DataType="string")]
    //    public string Subject { get; set; }

    //    [XmlAttribute("scheme")]
    //    public string SubjectScheme { get; set; }
    //}

    public class RecordMetaData
    {

        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=0, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Identifier)]
        public string Identifier { get; set; }

        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=1, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Title)]
        public string Title { get; set; }

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Subject)]
        public string Subject { get; set; }

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
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws)] // Mandatory synonym: will be used by LINQ to SQL requests instead of BoundingBox...
        public Binary Coverage { get; set; }

        [XmlElement("relation", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=9, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.Association)]
        public string RelationId { get; set; }

        [XmlElement("AnyText", Namespace=Namespaces.OgcWebCatalogCswV202, DataType="string", Order=10, IsNullable=false)]
        [Csw202Service.CoreQueryable(Csw202Service.CoreQueryableNames.AnyText)]
        public string AnyText { get; set; }
    }
}
