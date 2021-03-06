﻿////////////////////////////////////////////////////////////////////////////////
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
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Common.Logging;
using DC11 = GeoSik.DublinCore.Elements.V11;
using DCTerms = GeoSik.DublinCore.Terms;
using Ows100 = GeoSik.Ogc.Ows.V100.Types;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Converts a <see cref="IRecord" /> instances to CSW records.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class RecordConverter:
        IRecordConverter
    {

        /// <summary>Creates a new instance of the <see cref="RecordConverter" /> class.</summary>
        /// <param name="namespaceManager">The namespace manager to use.</param>
        public RecordConverter(XmlNamespaceManager namespaceManager)
        {
            _NamespaceManager=namespaceManager;
        }

        /// <summary>Converts the specified <paramref name="record" /> usig the specified element set.</summary>
        /// <param name="record">The record to convert.</param>
        /// <param name="elementSet">The element set to use.</param>
        /// <returns>The converted record.</returns>
        public Types.AbstractRecord Convert(IRecord record, string elementSet)
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
                return Convert(record, elements, false, typeof(Types.BriefRecord));

            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:abstract", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:format", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:modified", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:relation", csw, dc));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:spatial", csw, dct));
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/{1}:subject", csw, dc));
            if (elementSet=="summary")
                return Convert(record, elements, false, typeof(Types.SummaryRecord));

            elements.Clear();
            elements.Add(string.Format(CultureInfo.InvariantCulture, "/{0}:Record/*", csw, dc));
            return Convert(record, elements, false, typeof(Types.Record));
        }

        /// <summary>Converts the specified <paramref name="record" /> using the specified <paramref name="elements" />.</summary>
        /// <param name="record">The record to convert.</param>
        /// <param name="elements">The XPath definitions of the lements to return.</param>
        /// <param name="mayRootPathBeImplied"><c>true</c> if the root path may not be part of the XPath expressions; <c>false</c> if not.</param>
        /// <returns>The converted record.</returns>
        public Types.AbstractRecord Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied)
        {
            return Convert(record, elements, mayRootPathBeImplied, typeof(Types.Record));
        }

        private Types.AbstractRecord Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied, Type recordType)
        {
            Action<Types.AbstractRecord, IRecord, Filter.XPathTypeNavigator> converter=ConvertFullRecordField;
            if (recordType==typeof(Types.BriefRecord))
                converter=ConvertBriefRecordField;
            else if (recordType==typeof(Types.SummaryRecord))
                converter=ConvertSummaryRecordField;
            else
                recordType=typeof(Types.Record);

            var ret=Activator.CreateInstance(recordType) as Types.AbstractRecord;
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

        Task<IXmlSerializable> IRecordConverter.ConvertAsync(IRecord record, string elementSet, CancellationToken cancellationToken)
        {
            return Task.FromResult((IXmlSerializable)Convert(record, elementSet));
        }

        Task<IXmlSerializable> IRecordConverter.ConvertAsync(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied, CancellationToken cancellationToken)
        {
            return Task.FromResult((IXmlSerializable)Convert(record, elements, mayRootPathBeImplied));
        }

        protected virtual IList<DC11.DCelement> CreateRecordField(IRecord record, Filter.XPathTypeNavigator navigator)
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
                case "created":
                    e=new DCTerms.created();
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
                case "valid":
                    e=new DCTerms.valid();
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

                    e.Untyped.Add(v);
                    ret.Add(e);
                }
            }

            return ret;
        }

        private void ConvertBriefRecordField(Types.AbstractRecord briefRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=briefRecord as Types.BriefRecord;

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

        private void ConvertSummaryRecordField(Types.AbstractRecord summaryRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=summaryRecord as Types.SummaryRecord;

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

        private void ConvertFullRecordField(Types.AbstractRecord fullRecord, IRecord record, Filter.XPathTypeNavigator navigator)
        {
            var r=fullRecord as Types.Record;

            if (navigator.LocalName=="BoundingBox")
            {
                object value=navigator.GetValue(record);
                if (value==null)
                    return;

                // Covariance is a feature of .NET 4.0 http://msdn.microsoft.com/en-us/library/dd233059.aspx
                var ensg=value as IEnumerable<ISimpleGeometry>;
                if (ensg==null)
                {
                    var geom=value as ISimpleGeometry;
                    if (geom!=null)
                        ensg=new ISimpleGeometry[] { geom };
                }

                foreach (ISimpleGeometry g in ensg)
                {
                    try
                    {
                        var box=new Ows100.BoundingBox();
                        box.InitFromGeometry(g);
                        r.BoundingBox.Add(box);
                    } catch (Exception ex)
                    {
                        try
                        {
                            Logger.Error(CultureInfo.InvariantCulture, m => m("Exception {0} occured while creating bounding box for geometry \"{1}\". Message: \"{2}\".", ex.GetType(), g, ex.Message));
                        } catch (Exception eex)
                        {
                            Logger.Error(CultureInfo.InvariantCulture, m => m("Exception {0} occured while logging exception {1}. Message: \"{2}\".", eex.GetType(), ex.GetType(), eex.Message));
                        }
                    }
                }

                return;
            }

            IList<DC11.DCelement> elements=CreateRecordField(record, navigator);
            foreach (DC11.DCelement e in elements)
                r.Content.DCelement.Add(e);
        }

        private ILog Logger
        {
            get
            {
                if (_Logger==null)
                    _Logger=LogManager.GetLogger<RecordConverter>();

                return _Logger;
            }
        }

        private XmlNamespaceManager _NamespaceManager;
        private ILog _Logger;
    }
}
