using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.SqlServer.Types;
using Csw202Service=OgcToolkit.Services.Csw.V202;

namespace OgcToolkit.WebSample.Models.LinqToSql
{

    [MetadataType(typeof(RecordMetaData))]
    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    partial class Record:
        Csw202Service.IRecord
    {

        Csw202Service.IRecordConverter Csw202Service.IRecord.GetConverter(XmlNamespaceManager namespaceManager)
        {
            return new Csw202Service.RecordConverter(namespaceManager);
        }

        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        partial void OnSubjectSchemeChanging(string value);
        partial void OnSubjectSchemeChanged();

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        public RecordSubject RecordSubject
        {
            get
            {
                if (_RecordSubject==null)
                    _RecordSubject=new RecordSubject();
                return _RecordSubject;
            }
        }

        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws, Order=8, IsNullable=false)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(DbType="NVarChar(512)")]
        private string Subject
        {
            get
            {
                return RecordSubject.Subject;
            }
            set
            {
                if ((RecordSubject.Subject!=value))
                {
                    this.OnSubjectChanging(value);
                    this.SendPropertyChanging();
                    RecordSubject.Subject=value;
                    this.SendPropertyChanged("Subject");
                    this.OnSubjectChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(DbType="VarChar(256)")]
        private string SubjectScheme
        {
            get
            {
                return RecordSubject.Subject;
            }
            set
            {
                if ((RecordSubject.Subject!=value))
                {
                    this.OnSubjectSchemeChanging(value);
                    this.SendPropertyChanging();
                    RecordSubject.SubjectScheme=value;
                    this.SendPropertyChanged("SubjectScheme");
                    this.OnSubjectSchemeChanged();
                }
            }
        }

        string Csw202Service.IRecord.Id
        {
            get
            {
                return Identifier;
            }
        }

        private RecordSubject _RecordSubject;
    }

    public class RecordSubject
    {

        [XmlText(typeof(string), DataType="string")]
        public string Subject { get; set; }

        [XmlAttribute("scheme")]
        public string SubjectScheme { get; set; }
    }

    public class RecordMetaData
    {

        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=0, IsNullable=false)]
        public string Identifier { get; set; }

        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=1, IsNullable=false)]
        public string Title { get; set; }

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        public RecordSubject Subject { get; set; }

        [XmlElement("abstract", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=3, IsNullable=false)]
        public string Abstract { get; set; }

        [XmlElement("date", Namespace=Namespaces.DublinCoreElementsV11, DataType="date", Order=4)]
        public DateTime? Date { get; set; }

        [XmlElement("type", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=5, IsNullable=false)]
        public string Type { get; set; }

        [XmlElement("format", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=6, IsNullable=false)]
        public string Format { get; set; }

        [XmlElement("spatial", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=7, IsNullable=false)]
        public string Spatial { get; set; }

        [XmlIgnore]
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws)] // Mandatory synonym: will be used by LINQ to SQL requests instead of BoundingBox...
        public byte[] Coverage { get; set; }

        [XmlElement("relation", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=9, IsNullable=false)]
        public string RelationId { get; set; }
    }
}
