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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Microsoft.SqlServer.Types;
using Csw202=GeoSik.Ogc.WebCatalog.Csw.V202;
using DC11=GeoSik.DublinCore.Elements.V11;
using DCTerms=GeoSik.DublinCore.Terms;
using Filter=GeoSik.Ogc.Filter;
using Ows100=GeoSik.Ogc.Ows.V100;

namespace GeoSik.Services.Csw.V202
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

            IList<DC11.DCelement> elements=CreateRecordField(record, navigator);
            if (elements.Count==0)
                return;

            switch (navigator.LocalName)
            {
            case "identifier":
                r.identifier=elements.Cast<DC11.identifier>().ToList<DC11.identifier>();
                break;
            case "title":
                r.title=elements.Cast<DC11.title>().ToList<DC11.title>();
                break;
            case "type":
                r.type=(DC11.type)elements[0];
                break;
            }

        }

        private void ConvertSummaryRecordField(Csw202.AbstractRecord summaryRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=summaryRecord as Csw202.SummaryRecord;

            IList<DC11.DCelement> elements=CreateRecordField(record, navigator);
            if (elements.Count==0)
                return;

            switch (navigator.LocalName)
            {
            case "abstract":
                r.@abstract=elements.Cast<DCTerms.@abstract>().ToList<DCTerms.@abstract>();
                break;
            case "format":
                r.format=elements.Cast<DC11.format>().ToList<DC11.format>();
                break;
            case "identifier":
                r.identifier=elements.Cast<DC11.identifier>().ToList<DC11.identifier>();
                break;
            case "modified":
                r.modified=elements.Cast<DCTerms.modified>().ToList<DCTerms.modified>();
                break;
            case "relation":
                r.relation=elements.Cast<DC11.relation>().ToList<DC11.relation>();
                break;
            case "spatial":
                r.spatial=elements.Cast<DCTerms.spatial>().ToList<DCTerms.spatial>();
                break;
            case "subject":
                r.subject=elements.Cast<DC11.subject>().ToList<DC11.subject>();
                break;
            case "title":
                r.title=elements.Cast<DC11.title>().ToList<DC11.title>();
                break;
            case "type":
                r.type=(DC11.type)elements[0];
                break;
            }
        }

        private void ConvertFullRecordField(Csw202.AbstractRecord fullRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=fullRecord as Csw202.Record;

            if (navigator.LocalName=="BoundingBox")
            {
                var v=navigator.GetValue(record);
                if (v==null)
                    return;
                if (!(v is IEnumerable<SqlGeometry>))
                    v=new SqlGeometry[] { (SqlGeometry)v };

                foreach (SqlGeometry g in (IEnumerable<SqlGeometry>)v)
                    r.BoundingBox.Add(
                        new Ows100.BoundingBox() {
                            Geometry=g
                        }
                    );
                return;
            }

            IList<DC11.DCelement> elements=CreateRecordField(record, navigator);
            foreach (DC11.DCelement e in elements)
                r.Content.DCelement.Add(e);
        }

        private static IList<DC11.DCelement> CreateRecordField(IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var ret=new List<DC11.DCelement>();

            object value=navigator.GetValue(record);
            if (value==null)
                return ret;

            if ((value is string) || !(value is IEnumerable))
                value=new object[] { value };

            foreach (object v in (IEnumerable)value)
            {
                DC11.DCelement e=null;
                switch (navigator.LocalName)
                {
                case "abstract":
                    e=new DCTerms.@abstract();
                    break;
                case "creator":
                    e=new DC11.creator();
                    break;
                case "contributor":
                    e=new DC11.contributor();
                    break;
                case "date":
                    e=new DC11.date();
                    break;
                case "description":
                    e=new DC11.description();
                    break;
                case "format":
                    e=new DC11.format();
                    break;
                case "identifier":
                    e=new DC11.identifier();
                    break;
                case "language":
                    e=new DC11.language();
                    break;
                case "modified":
                    e=new DCTerms.modified();
                    break;
                case "publisher":
                    e=new DC11.publisher();
                    break;
                case "relation":
                    e=new DC11.relation();
                    break;
                case "rights":
                    e=new DC11.rights();
                    break;
                case "source":
                    e=new DC11.source();
                    break;
                case "spatial":
                    e=new DCTerms.spatial();
                    break;
                case "subject":
                    e=new DC11.subject();
                    break;
                case "title":
                    e=new DC11.title();
                    break;
                case "type":
                    e=new DC11.type();
                    break;
                }

                if (e!=null)
                {
                    if (navigator.MoveToAttribute("scheme", string.Empty))
                    {
                        object sch=navigator.GetValue(record);
                        if (sch!=null)
                            e.scheme=new Uri(sch.ToString());
                    }

                    e.Untyped.Add(value);
                    ret.Add(e);
                }
            }

            return ret;
        }

        private XmlNamespaceManager _NamespaceManager;
    }
}
