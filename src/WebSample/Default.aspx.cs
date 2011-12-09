using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OgcToolkit.WebSample
{
    public partial class _Default: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _RecordDataSource_ContextCreating(object sender, EntityDataSourceContextCreatingEventArgs e)
        {
            //var context=new Models.CodeFirst.RecordContext("RecordsSource");
            //e.Context=((IObjectContextAdapter)context).ObjectContext;
        }
    }
}
