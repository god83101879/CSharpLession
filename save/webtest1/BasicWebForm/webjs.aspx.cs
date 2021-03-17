using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebForm
{
    public partial class webjs : System.Web.UI.Page
    {
        class UserInfo
        {
            public string UserName { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
        }

        List<UserInfo> list = new List<UserInfo>()
        {
            new UserInfo() { UserName = "John", Age = 18, Sex="Male"},
            new UserInfo() { UserName = "Dan", Age = 19, Sex="Female"}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            //            this.ltArr.Text = //script前後不能有空格
            //            @"  
            //var arr2 = [{ UserName: 'John', Age: 17, Sex: 'Female' }, { UserName: 'Mary', Age: 16, Sex: 'Female' }, { UserName: 'Johnny', Age: 18, Sex: 'Male' }]
            //              ";
            this.ltArr.Text = $"var arr2 = [{{ UserName: '{list[1].UserName}', Age: {list[1].Age}, Sex: '{list[1].Sex}' }}];";
        }
    }
}