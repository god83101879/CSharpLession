using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.CheckBox1.Checked = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = "";

            if (this.CheckBox1.Checked)
            {
                this.Label1.Text = "Checkbox1 is checked. <br />";
            }

            if (this.CheckBox2.Checked)
            {
                this.Label1.Text = "Checkbox2 is checked. <br />";
            }

            if (this.RadioButton1.Checked)
            {
                this.Label1.Text += "Radio1 checked. <br />";
            }

            else if (this.RadioButton2.Checked)
            {
                this.Label1.Text += "Radio2 checked. <br />";
            }
        }
    }
}