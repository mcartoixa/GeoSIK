////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Xml.Serialization;
using OgcToolkit.Services.Ows;

namespace OgcToolkit.Ogc.WebCatalog.Csw.V202
{

#pragma warning disable 3009
    partial class GetRecords:
        IRequest
    {

        [XmlIgnore]
        string IRequest.Version
        {
            get { return Content.version; }
        }

        [XmlIgnore]
        string IRequest.Service
        {
            get { return Content.service; }
        }
    }
#pragma warning restore 3009
}
