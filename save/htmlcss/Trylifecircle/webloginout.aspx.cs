using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trylifecircle.Utility;

namespace Trylifecircle
{
    public partial class webloginout : System.Web.UI.Page
    {
        private const string _sessionKey = "IsLogined";
        private const string _sessionKey_Account = "Account";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (loginhelper.HasLogined())
            {
                this.ltAccount.Text = loginhelper.GetCurrentUserInfo();
            }
            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            //{
            //    this.ltAccount.Text = this.Session[_sessionKey_Account] as string;
            //}
        }
    }
}