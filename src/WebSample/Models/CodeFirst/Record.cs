using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.SqlServer.Types;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;
using Csw202Service=OgcToolkit.Services.Csw.V202;

namespace OgcToolkit.WebSample.Models.CodeFirst
{

    /* Code first does not support the call of custom stored procedures with LINQ... */

    public class CFRecordContext:
        DbContext
    {

        public CFRecordContext(string nameOrConnectionString):
            base(nameOrConnectionString)
        {
        }

        public DbSet<CFRecord> Records { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Record>().HasRequired(r => r.Subject).WithRequiredPrincipal();


            //modelBuilder.Entity<Record>().ToTable("OgcRecords");
            //modelBuilder.Entity<RecordSubject>().ToTable("OgcRecords");
        }
    }

    [Table("Records", Schema="Ogc.Csw")]
    [XmlRoot("Record", Namespace=Namespaces.OgcWebCatalogCswV202, IsNullable=false)]
    public class CFRecord:
        Csw202Service.IRecord
    {

        Csw202Service.IRecordConverter Csw202Service.IRecord.GetConverter(XmlNamespaceManager namespaceManager)
        {
            return new Csw202Service.RecordConverter(namespaceManager);
        }

        [Key]
        [Column("Identifier", TypeName="varchar")]
        [XmlElement("identifier", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=0, IsNullable=false)]
        public string Id { get; set; }

        [Column("Title", TypeName="nvarchar")]
        [XmlElement("title", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=1, IsNullable=false)]
        public string Title { get; set; }

        [XmlElement("subject", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=2, IsNullable=false)]
        public RecordSubject Subject { get; set; }

        [Column("Description", TypeName="nvarchar")]
        [XmlElement("abstract", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=3, IsNullable=false)]
        public string Abstract { get; set; }

        [Column("Date", TypeName="date")]
        [XmlElement("date", Namespace=Namespaces.DublinCoreElementsV11, DataType="date", Order=4)]
        public DateTime? Date { get; set; }

        [Column("Type", TypeName="varchar")]
        [XmlElement("type", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=5, IsNullable=false)]
        public string Type { get; set; }

        [Column("Format", TypeName="varchar")]
        [XmlElement("format", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=6, IsNullable=false)]
        public string Format { get; set; }

        [Column("Spatial", TypeName="varchar")]
        [XmlElement("spatial", Namespace=Namespaces.DublinCoreTerms, DataType="string", Order=7, IsNullable=false)]
        public string Spatial { get; set; }

        [Column("Coverage", TypeName="varbinary")]
        [XmlIgnore]
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws)] // Mandatory synonym: will be used by LINQ to Entities requests instead of the following...
        public byte[] Coverage { get; set; }

        [NotMapped]
        [XmlElement("BoundingBox", Namespace=Namespaces.OgcOws, Order=8, IsNullable=false)]
        public SqlGeometry BoundingBox
        {
            get
            {
                if (Coverage!=null)
                {
                    using (var ms=new MemoryStream(Coverage))
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

        [Column("Relation", TypeName="varchar")]
        [XmlElement("relation", Namespace=Namespaces.DublinCoreElementsV11, DataType="string", Order=9, IsNullable=false)]
        public string RelationId { get; set; }

        //[XmlIgnore]
        //[ForeignKey("Id")]
        //public virtual Record Relation { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [XmlElement("AnyText", Namespace=Namespaces.OgcWebCatalogCswV202, DataType="string", Order=9, IsNullable=false)]
        public string AnyText { get; set; }
    }

    [ComplexType]
    public class RecordSubject
    {

        [Column("Subject", TypeName="nvarchar")]
        [XmlText(typeof(string), DataType="string")]
        public string Subject { get; set; }

        [Column("SubjectScheme", TypeName="varchar")]
        [XmlAttribute("scheme")]
        public string SubjectScheme { get; set; }
    }
}
