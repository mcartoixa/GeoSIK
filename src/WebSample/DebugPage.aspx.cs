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
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace GeoSik.WebSample
{
    public partial class DebugPage: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var parameters=new NameValueCollection();
            parameters["service"]="CSW";
            parameters["version"]="2.0.2";
            parameters["request"]="GetCapabilities";

            try
            {
                var sb=new StringBuilder();
                using (var xw=XmlWriter.Create(sb))
                {
                    IXmlSerializable response=Services.Ows.ServiceLocatorInstance.InvokeService(parameters);
                    response.WriteXml(xw);
                }
                _Label1.Text=HttpUtility.HtmlEncode(sb.ToString());
            } catch (Exception ex)
            {
                _Label1.Text=
                    ex.Message+
                    "<br />"+
                    ex.StackTrace
                ;
                if (ex.InnerException!=null)
                    _Label1.Text+=
                        "<br />"+
                        ex.InnerException.Message+
                        "<br />"+
                        ex.InnerException.StackTrace
                    ;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool success=false;
            try
            {
                HttpRuntime.UnloadAppDomain();
                success=true;
            } catch
            {
            }

            if (success)
                return;

            File.SetLastWriteTimeUtc(Path.Combine(Request.PhysicalApplicationPath, "Web.config"), DateTime.UtcNow);
        }
    }
}
