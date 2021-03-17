using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace htmlcss
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public enum SourceType
        {
            Inner = 0,
            Outer = 1  //UserControltest.aspx   SType="Inner" 需重建後儲存重開才看得到
        }

        public SourceType Stype { get; set;}
        public string HeaderText { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltHeader.Text = this.HeaderText;
        }

        public void SetHeaderText(string txt)
        {
            if (this.Stype == SourceType.Inner)
                txt = "Inner" + txt;
            else
                txt = "Outter" + txt;
            this.HeaderText = txt;
            this.ltHeader.Text = txt;
        }
    }
}