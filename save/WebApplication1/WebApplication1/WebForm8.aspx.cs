using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Image1.ImageUrl = "https://img.4gamers.com.tw/puku-clone-version/0f8c6821b78526fe91416977ce2d4db7-2865dae9701ca6da393457f2ef59ba3a2b803735.jpg";

            Response.Write("123");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string val = this.DropDownList1.SelectedValue;

            if (val == "1")
            {
                this.PlaceHolder1.Visible = true;
                this.Image1.Visible = false;
            }
            else
            {
                this.PlaceHolder1.Visible = false;
                this.Image1.Visible = true;
            }
        }
    }
}