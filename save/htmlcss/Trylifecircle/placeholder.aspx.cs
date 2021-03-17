using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class placeholder : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.plc1.Controls.Add(new Button() { Text = "Hello button" });
            lifecircle1 ctl = (lifecircle1)Page.LoadControl("~/lifecircle1.ascx");
            this.plc1.Controls.Add(ctl);

            Control ctllifecircle2 = ctl.FindControl("lifecircle2");
            Response.Write(ctllifecircle2.ClientID);

            foreach (Control ctlA in this.plc1.Controls)
            {
                if (ctlA is Button)
                    Response.Write((ctlA as Button).Text + "<br/>");
            }
        }
    }
}