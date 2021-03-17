using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace htmlcss
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltPageTitle.Text = "Hi 我是爹扭";

            this.ltPageDesc.Text = "第一次接版成功，我是蘿莉控 喜歡九千多歲的鯊魚";
        }
    }
}