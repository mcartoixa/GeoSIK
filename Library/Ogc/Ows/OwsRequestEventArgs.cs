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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xml.Schema.Linq;

namespace GeoSik.Ogc.Ows
{

#pragma warning disable 3024
    /// <summary>Handles arguments for an OWS request processing related event.</summary>
    /// <typeparam name="TRequest">The type of the request being processed.</typeparam>
    /// <typeparam name="TResponse">The type of the response to the <typeparamref name="TRequest" /> being processed.</typeparam>
    public class OwsRequestEventArgs<TRequest, TResponse>:
        EventArgs
        where TRequest:
            IRequest
        where TResponse:
            IXmlSerializable
    {

        internal OwsRequestEventArgs(TRequest request, TResponse response)
        {
            Debug.Assert(request!=null);
            if (request==null)
                throw new ArgumentNullException("request");
            Debug.Assert(response!=null);
            if (response==null)
                throw new ArgumentNullException("response");

            Request=request;
            _Response=response;
        }

        public TRequest Request
        {
            get;
            private set;
        }

        public TResponse Response
        {
            get
            {
                return _Response;
            }
            set
            {
                Debug.Assert(value!=null);
                if (value==null)
                    throw new ArgumentNullException("value");

                _Response=value;
            }
        }

        private TResponse _Response;
    }
#pragma warning restore 3024

}
