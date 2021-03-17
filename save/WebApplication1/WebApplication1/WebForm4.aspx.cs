using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox2.Text = @"1234";

            this.HiddenField1.Value = "123";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string aaa = this.TextBox1.Text;
            string aaa1 = this.TextBox2.Text;
            string aaa2 = this.TextBox3.Text;
            string aaa3 = this.TextBox4.Text;

            string hfValue = this.HiddenField1.Value;

        }
    }
}