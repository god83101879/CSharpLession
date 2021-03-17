using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class lifecircle1 : System.Web.UI.UserControl
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            Response.Write("life1_PreInit <br/>");
        }
        protected void Page_Init(Object sender, EventArgs e)
        {
            Response.Write("life1_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("life1_Load <br/>");
        }
        protected void Page_PreRender(Object sender, EventArgs e)
        {
            Response.Write("life1_PreRender <br/>");
        }
    }
}