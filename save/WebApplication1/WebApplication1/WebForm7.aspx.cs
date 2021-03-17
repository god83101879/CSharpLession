using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = string.Empty;
            // Read RadioButtonList 
            string rdbVal = this.RadioButtonList1.SelectedValue;
            this.Label1.Text += rdbVal + " is Selected.";
            // Read CheckBoxList
            foreach (ListItem li in this.CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    this.Label1.Text += li.Text + " is Checked. <br/>";
                }
            }
        }
    }
}