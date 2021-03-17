using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class lessontest : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            //this.plc1.Controls.Add(new Button() { Text = "按我" });
            this.plc1.Controls.Add(new TextBox());

            /*foreach (Control ctlA in this.plc1.Controls)
            {
                if (ctlA is Button)
                    Response.Write((ctlA as Button).Text + "<br/>");
            }*/
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.plc1.Controls)
            {
                if(item is TextBox)
                {
                    Response.Write($"{(item as TextBox).Text}<br/>");
                }
            }

            //TextBox txtbox = this.plc1.Controls[0] as TextBox;
            //Response.Write($"{txtbox.Text}");
        }
    }
}