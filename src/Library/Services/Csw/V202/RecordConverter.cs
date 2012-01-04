using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Microsoft.SqlServer.Types;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;
using DC11=OgcToolkit.DublinCore.Elements.V11;
using DCTerms=OgcToolkit.DublinCore.Terms;
using Filter=OgcToolkit.Ogc.Filter;
using Ows100=OgcToolkit.Ogc.Ows.V100;

namespace OgcToolkit.Services.Csw.V202
{

    public class RecordConverter:
        IRecordConverter
    {

        public RecordConverter(XmlNamespaceManager namespaceManager)
        {
            _NamespaceManager=namespaceManager;
        }

        public Csw202.AbstractRecord Convert(IRecord record, string elementSet)
        {
            var elements=new List<string>();

            string csw=_NamespaceManager.LookupPrefix(Namespaces.OgcWebCatalogCswV202);
            if (string.IsNullOrEmpty(csw))
            {
                _NamespaceManager.AddNamespace("csw", Namespaces.OgcWebCatalogCswV202);
                csw="csw";
            }

            string dc=_NamespaceManager.LookupPrefix(Namespaces.DublinCoreElementsV11);
            if (string.IsNullOrEmpty(dc))
            {
                _NamespaceManager.AddNamespace("dc", Namespaces.DublinCoreElementsV11);
                dc="dc";
            }

            string dct=_NamespaceManager.LookupPrefix(Namespaces.DublinCoreTerms);
            if (string.IsNullOrEmpty(dct))
            {
                _NamespaceManager.AddNamespace("dct", Namespaces.DublinCoreTerms);
                dct="dct";
            }

            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:identifier", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:title", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:type", csw, dc));
            if (elementSet=="brief")
                return Convert(record, elements, false, typeof(Csw202.BriefRecord));

            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:abstract", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:format", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:modified", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:relation", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:spatial", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:subject", csw, dc));
            if (elementSet=="summary")
                return Convert(record, elements, false, typeof(Csw202.SummaryRecord));

            elements.Clear();
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/*", csw, dc));
            return Convert(record, elements, false, typeof(Csw202.Record));
        }

        public Csw202.AbstractRecord Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied)
        {
            return Convert(record, elements, mayRootPathBeImplied, typeof(Csw202.Record));
        }

        public Csw202.AbstractRecord Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied, Type recordType)
        {
            Action<Csw202.AbstractRecord, IRecord, Filter.XPathTypeNavigator> converter=ConvertFullRecordField;
            if (recordType==typeof(Csw202.BriefRecord))
                converter=ConvertBriefRecordField;
            else if (recordType==typeof(Csw202.SummaryRecord))
                converter=ConvertSummaryRecordField;
            else
                recordType=typeof(Csw202.Record);

            var ret=Activator.CreateInstance(recordType) as Csw202.AbstractRecord;
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+_NamespaceManager.LookupPrefix(Namespaces.DublinCoreElementsV11), Namespaces.DublinCoreElementsV11)
            );

            var xptn=new Filter.XPathTypeNavigator(record.GetType());
            foreach (string element in elements)
            {
                XPathNodeIterator xpni=xptn.Select(element, _NamespaceManager, mayRootPathBeImplied);
                while (xpni.MoveNext())
                    converter(ret, record, (Filter.XPathTypeNavigator)xpni.Current);
            }

            return ret;
        }

        IXmlSerializable IRecordConverter.Convert(IRecord record, string elementSet)
        {
            return Convert(record, elementSet);
        }

        IXmlSerializable IRecordConverter.Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied)
        {
            return Convert(record, elements, mayRootPathBeImplied);
        }

        private void ConvertBriefRecordField(Csw202.AbstractRecord briefRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=briefRecord as Csw202.BriefRecord;

            DC11.DCelement element=CreateRecordField(record, navigator);
            if (element==null)
                return;

            switch (navigator.LocalName)
            {
            case "identifier":
                r.identifier=new DC11.identifier[] {
                    (DC11.identifier)element
                };
                break;
            case "title":
                r.title=new DC11.title[] {
                    (DC11.title)element
                };
                break;
            case "type":
                r.type=(DC11.type)element;
                break;
            }

        }

        private void ConvertSummaryRecordField(Csw202.AbstractRecord summaryRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=summaryRecord as Csw202.SummaryRecord;

            DC11.DCelement element=CreateRecordField(record, navigator);
            if (element==null)
                return;

            switch (navigator.LocalName)
            {
            case "abstract":
                r.@abstract=new DCTerms.@abstract[] {
                    (DCTerms.@abstract)element
                };
                break;
            case "format":
                r.format=new DC11.format[] {
                    (DC11.format)element
                };
                break;
            case "identifier":
                r.identifier=new DC11.identifier[] {
                    (DC11.identifier)element
                };
                break;
            case "modified":
                r.modified=new DCTerms.modified[] {
                    (DCTerms.modified)element
                };
                break;
            case "relation":
                r.relation=new DC11.relation[] {
                    (DC11.relation)element
                };
                break;
            case "spatial":
                r.spatial=new DCTerms.spatial[] {
                    (DCTerms.spatial)element
                };
                break;
            case "subject":
                r.subject=new DC11.subject[] {
                    (DC11.subject)element
                };
                break;
            case "title":
                r.title=new DC11.title[] {
                    (DC11.title)element
                };
                break;
            case "type":
                r.type=(DC11.type)element;
                break;
            }
        }

        private void ConvertFullRecordField(Csw202.AbstractRecord fullRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=fullRecord as Csw202.Record;

            if (navigator.LocalName=="BoundingBox")
            {
                SqlGeometry g=navigator.GetValue(record) as SqlGeometry;
                if (g!=null)
                {
                    r.BoundingBox.Add(
                        new Ows100.BoundingBox() {
                            Geometry=g
                        }
                    );
                }
                return;
            }

            DC11.DCelement element=CreateRecordField(record, navigator);
            if (element!=null)
                r.Content.DCelement.Add(element);
        }

        private static DC11.DCelement CreateRecordField(IRecord record, Filter.XPathTypeNavigator navigator)
        {
            object value=navigator.GetValue(record);
            if (value==null)
                return null;

            DC11.DCelement ret=null;
            switch (navigator.LocalName)
            {
            case "abstract":
                ret=new DCTerms.@abstract();
                break;
            case "creator":
                ret=new DC11.creator();
                break;
            case "contributor":
                ret=new DC11.contributor();
                break;
            case "date":
                ret=new DC11.date();
                break;
            case "description":
                ret=new DC11.description();
                break;
            case "format":
                ret=new DC11.format();
                break;
            case "identifier":
                ret=new DC11.identifier();
                break;
            case "language":
                ret=new DC11.language();
                break;
            case "modified":
                ret=new DCTerms.modified();
                break;
            case "publisher":
                ret=new DC11.publisher();
                break;
            case "relation":
                ret=new DC11.relation();
                break;
            case "rights":
                ret=new DC11.rights();
                break;
            case "source":
                ret=new DC11.source();
                break;
            case "spatial":
                ret=new DCTerms.spatial();
                break;
            case "subject":
                ret=new DC11.subject();
                break;
            case "title":
                ret=new DC11.title();
                break;
            case "type":
                ret=new DC11.type();
                break;
            }

            if (ret!=null)
            {
                if (navigator.MoveToAttribute("scheme", string.Empty))
                {
                    object sch=navigator.GetValue(record);
                    if (sch!=null)
                        ret.scheme=new Uri(sch.ToString());
                }

                ret.Untyped.Add(value);
            }

            return ret;
        }

        private XmlNamespaceManager _NamespaceManager;
    }
}
