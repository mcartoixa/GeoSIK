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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using Microsoft.SqlServer.Types;
using Csw202=OgcToolkit.Ogc.WebCatalog.Csw.V202;

namespace OgcToolkit.Services.Csw.V202
{

    /// <summary>Interface implemented by a record type.</summary>
    public interface IRecord
    {

        IRecordConverter GetConverter(XmlNamespaceManager namespaceManager);
    }

    public interface IRecordConverter
    {

        IXmlSerializable Convert(IRecord record, string elementSet);
        IXmlSerializable Convert(IRecord record, IEnumerable<string> elements, bool mayRootPathBeImplied);
    }
}
