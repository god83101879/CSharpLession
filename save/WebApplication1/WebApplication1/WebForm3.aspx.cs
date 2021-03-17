using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Method1(object sender)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Button btn2 = (Button)sender;
            if (btn.ID == this.Button1.ID)
            {
                this.lblMsg.ForeColor = Color.Red; //this都是指最接近自己的class 在C#定義是這
                this.lblMsg.Text = "Button1";
            }
            else 
            {
                this.lblMsg.ForeColor = Color.Blue;
                this.lblMsg.Text = "Button2";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}