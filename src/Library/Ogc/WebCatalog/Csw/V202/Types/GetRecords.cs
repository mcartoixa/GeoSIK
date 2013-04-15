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
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GeoSik.Ogc.WebCatalog.Csw.V202.Types
{

#pragma warning disable 3009
    partial class GetRecords:
        Ows.IRequest
    {

        /// <summary>Transforms the current request in a collection of corresponding key-value pairs.</summary>
        /// <returns>The collection of key-value pairs.</returns>
        NameValueCollection Ows.IRequest.ToKeyValuePairs()
        {
            var ret = new NameValueCollection();

            ret.Add( "request", "GetRecords" );
            ret.Add( "service", this.Content.service );
            ret.Add( "version", this.Content.version );

            // namespace
            var namespaceManager = new XmlNamespaceManager( new NameTable() );
            XNamespace dn = this.Untyped.GetDefaultNamespace();
            if( dn != XNamespace.None )
                namespaceManager.AddNamespace( string.Empty, dn.NamespaceName );
            var namespaces = from at in this.Untyped.Attributes()
                             where at.IsNamespaceDeclaration
                             select new {
                                 Prefix = at.Parent.GetPrefixOfNamespace( at.Value ),
                                 Uri = at.Value
                             };
            namespaces.ToList().ForEach( n => namespaceManager.AddNamespace( n.Prefix, n.Uri ) );
            ret.Add(
                "namespace",
                string.Join(
                    ",",
                    namespaceManager.Cast<string>().Select( s => string.Concat( "xmlns(", s != string.Empty ? string.Concat( s, "=" ) : string.Empty, namespaceManager.LookupNamespace( s ), ")" ) )
                )
            );

            if( !string.IsNullOrEmpty( this.resultType ) )
                ret.Add( "resulttype", this.resultType );
            if( this.requestId != null )
                ret.Add( "requestid", this.requestId.ToString() );
            if( !string.IsNullOrEmpty( this.outputFormat ) )
                ret.Add( "outputformat", this.outputFormat );
            if( outputSchema != null )
                ret.Add( "outputschema", outputSchema.ToString() );
            ret.Add( "startposition", this.startPosition.ToString( "N", CultureInfo.InvariantCulture ) );
            ret.Add( "maxrecords", this.maxRecords.ToString( "N", CultureInfo.InvariantCulture ) );

            var query=this.AbstractQuery as Query;
            if( query != null )
            {
                var tnElement=Content.AbstractQuery.Untyped.Attribute("typeNames");
                if (tnElement!=null)
                    ret.Add("typenames", string.Join(",", tnElement.Value.Split(' ')));

                if ( query.Untyped.Elements("{http://www.opengis.net/cat/csw/2.0.2}ElementSetName").Any<XElement>() && !string.IsNullOrEmpty(query.ElementSetName.TypedValue))
                    ret.Add( "elementsetname", query.ElementSetName.TypedValue );
                if ((query.ElementName!=null) && (query.ElementName.Count>0))
                {
                    var elementNames=from el in query.Untyped.Descendants()
                                     where el.Name=="{http://www.opengis.net/cat/csw/2.0.2}ElementName"
                                     select el.Value;
                    ret.Add("elementname", string.Join(",", elementNames));
                }

                if( query.Constraint != null ) {
                    if( !string.IsNullOrWhiteSpace( query.Constraint.CqlText ) ) {
                        ret.Add( "constraintlanguage", "CQL_TEXT" );
                        ret.Add( "constraint", string.Concat("\"", query.Constraint.CqlText, "\"" ));
                    }
                    //if( !string.IsNullOrWhiteSpace( query.Constraint.Filter ) ) {
                    //    ret.Add( "constraintlanguage", "FILTER" );
                    //    ret.Add( "constraint", query.Constraint.Untyped. );
                    //}
                }
            }

            return ret;
        }

        /// <summary>Gets the version of this request.</summary>
        [XmlIgnore]
        string Ows.IRequest.Version
        {
            get { return Content.version; }
        }

        /// <summary>Gets the name of the service concerned by this request.</summary>
        [XmlIgnore]
        string Ows.IRequest.Service
        {
            get { return Content.service; }
        }
    }
#pragma warning restore 3009
}
