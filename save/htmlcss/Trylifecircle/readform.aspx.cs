using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class readform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["key"] = 123;
            //Session["key1"] = 456;

            //this.Session.Remove("key1");
        }

        protected void btnAdd_Click(object senser, EventArgs e)
        {
            this.Session["key1"] = 123;
            this.Response.Write("Add sucess");
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            this.Session.Remove("key1");
            this.Response.Write("Remove success");
        }
    }
}