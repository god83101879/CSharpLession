using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.DropDownList1.SelectedValue = "2";

                this.DropDownList1.Items.Clear();

                this.DropDownList1.Items.Add(new ListItem("Item", "1"));
                this.DropDownList1.Items.Add(new ListItem("Item", "32"));
                this.DropDownList1.Items.Add(new ListItem("Item", "33"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Val1 = this.DropDownList1.SelectedValue;
            if (Val1 == "1")
            {
                Label1.Text = "First";
                Label1.ForeColor = Color.Green;
            }
            else if (Val1 == "2")
            {
                Label1.Text = "First";
                Label1.ForeColor = Color.Blue;
            }
            else
            {
                Label1.Text = "First";
                Label1.ForeColor = Color.Red;
            }
        }
    }
}