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

namespace OgcToolkit.WebSample
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