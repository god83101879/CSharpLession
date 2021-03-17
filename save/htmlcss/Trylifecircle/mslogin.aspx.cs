using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trylifecircle.Utility;

namespace Trylifecircle
{
    public partial class mslogin : System.Web.UI.Page
    {
        //private const string _sessionKey = "IsLogined";
        //private const string _sessionKey_Account = "Account";
        private string _goToUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            _goToUrl = Request.RawUrl;

            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            if(loginhelper.HasLogined())
            {
                //this.ltAccount.Text = this.Session[_sessionKey_Account] as string;
                //this.ltMessage.Text = "Success";
                this.ltAccount.Text = loginhelper.GetCurrentUserInfo();
                this.plc1.Visible = false;
                this.plc2.Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = this.txtAccount.Text;
            string pwd = this.txtPassword.Text;
            bool isSuccess = loginhelper.TryLogin(acc, pwd);

            //bool isAccountRight = string.Compare("jhong", this.txtAccount.Text, true) == 0; //==0表毫無差距
            //bool isPasswordRight = string.Compare("syuewu", this.txtPassword.Text) == 0; 

            //if (isAccountRight && isPasswordRight)
            if (isSuccess)
            {
                //this.Session["Account"] = this.txtAccount.Text;
                //this.Session[_sessionKey_Account] = this.txtAccount.Text;
                //this.Session[_sessionKey] = true;
                this.ltMessage.Text = "Success";
                this.plc1.Visible = false;
                this.plc2.Visible = true;

                Response.Redirect(this._goToUrl);
            }
            else
            {
                this.ltMessage.Text = "Fail";
                this.plc1.Visible = true;
                this.plc2.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            if(loginhelper.HasLogined())
            {
                loginhelper.Logout();
                //this.Session.Remove(_sessionKey);
                //this.Session.Remove(_sessionKey_Account);

                this.plc1.Visible = false;
                this.plc2.Visible = true;

                Response.Redirect(this._goToUrl);
            }
        }
    }
}