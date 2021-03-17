using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class lifecircleweb : System.Web.UI.Page
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            Response.Write("WebFrom1.Page_PreInit <br/>");
        }
        protected void Page_Init(Object sender, EventArgs e)
        {
            Response.Write("WebFrom1.Page_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("WebFrom1.Page_Load <br/>");
        }
        protected void Page_PreRender(Object sender, EventArgs e)
        {
            Response.Write("WebFrom1.Page_PreRender <br/>");
        }
        protected void Button1_Click(Object sender, EventArgs e)
        {
            Response.Write("WebFrom1.Button1_Click <br/>");
        }
    }
}