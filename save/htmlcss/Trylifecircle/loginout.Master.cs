using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trylifecircle
{
    public partial class loginout : System.Web.UI.MasterPage
    {
        private const string _sessionKey = "IsLogined";
        private const string _sessionKey_Account = "Account";
        protected void Page_Load(object sender, EventArgs e)
        {
            bool? val = this.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                this.ltAccount.Text = this.Session[_sessionKey_Account] as string;
                this.plc1.Visible = false;
                this.plc2.Visible = true;
            }
            else
            {
                this.plc1.Visible = true;
                this.plc2.Visible = false;
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            bool? val = this.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                this.Session.Remove(_sessionKey);
                this.Session.Remove(_sessionKey_Account);
                this.plc1.Visible = false;
                this.plc2.Visible = true;

                Response.Redirect("~/login.aspx");
            }
        }
    }
}