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
using System.Diagnostics;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace GeoSik.Ogc.Ows.Mvc
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>Action result that outputs XML to the response stream output.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

    public class XmlSerializableResult:
        ActionResult
    {

        /// <summary>Creates a new instance of the <see cref="XmlSerializableResult" /> class.</summary>
        private XmlSerializableResult()
        { }

        /// <summary>Creates a new instance of the <see cref="XmlSerializableResult" /> class.</summary>
        /// <param name="result">The result to serialize to the response stream output.</param>
        public XmlSerializableResult(IXmlSerializable result)
        {
            Debug.Assert(result!=null);
            if (result==null)
                throw new ArgumentNullException("result");

            _Result=result;
        }

        /// <summary>Deserializes the <see cref="Result" /> to the response stream output.</summary>
        /// <param name="context">The context in which the result is executed.
        /// The context information includes the controller, HTTP content, request context, and route data.</param>
        public override void ExecuteResult(ControllerContext context)
        {
            var xws=new XmlWriterSettings();
            xws.CloseOutput=false;
#if !DEBUG
            xws.Indent=false;
#endif
            using (var xw=XmlWriter.Create(context.HttpContext.Response.Output, xws))
                _Result.WriteXml(xw);
            context.HttpContext.Response.ContentType="text/xml";
        }

        /// <summary>Gets the object to deserialize to the response stream output.</summary>
        public IXmlSerializable Result
        {
            get
            {
                return _Result;
            }
        }

        private IXmlSerializable _Result;
    }
}
