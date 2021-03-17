using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class lifems : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            Response.Write("MasterPage_MSPreInit <br/>");
        }
        protected void Page_Init(Object sender, EventArgs e)
        {
            Response.Write("MasterPage_MSInit <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("MasterPage_MSLoad <br/>");
        }
        protected void Page_PreRender(Object sender, EventArgs e)
        {
            Response.Write("MasterPage_MSPreRender <br/>");
        }
        protected void Button1_Click(Object sender, EventArgs e)
        {
            Response.Write("MasterButton1_MSClick <br/>");
        }
    }
}