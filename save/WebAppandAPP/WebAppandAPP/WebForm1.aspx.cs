using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppandAPP
{
    public partial class WebForm1 : 
        System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*protected void Button1_Click(Object sender, EventArgs e)
        {
            string newID = this.txtID.Text;

            string name = this.txtName.Text;

            string bir = this.txtBirthday.Text;

            string num = this.txtNumberCol.Text;

            DBTool.InsertIntoTestTable1(newID, name, bir, num);
        }*/

        protected void Button1_Click(Object sender, EventArgs e)
        {
            string newID = this.txtID.Text;

            string name = this.txtName.Text;

            string bir = this.txtBirthday.Text;

            string num = this.txtNumberCol.Text;

            DBTool.DeleteTestTablel(newID);
        }

    }
}