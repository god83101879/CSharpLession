using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace htmlcss
{
    public partial class WebFormsite1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 masterPage = (this.Master as Site1);
            //masterPage.HeaderText = "this is set by page";
            masterPage.SetHeaderText("Header Text");
            masterPage.Stype = Site1.SourceType.Inner;
        }
    }
}