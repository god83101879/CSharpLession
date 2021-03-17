using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace htmlcss
{
    public partial class userctrlpage1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ltMsg.Text = "This is literal in UC";
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            this.ltMsg.Text = " -- ";
        }
    }
}