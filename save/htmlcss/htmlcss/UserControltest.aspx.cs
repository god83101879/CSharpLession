using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace htmlcss
{
    public partial class UserControltest1 : System.Web.UI.Page
    {
        /*protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseExecutor.ReadTEstTable1DT();

            ucPager.TotalSize = dt.Rows.Count;
            ucPager.Url = "~/UserControltest.aspx";

            this.repList.DataSource = dt;
            this.repList.DataBind();
        }*/

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BulidDataTable();

            UserControltest.TotalSize = dt.Rows.Count;  //呼叫UserControltest.ascx.cs
            UserControltest.Url = "~/UserControl.aspx";
            UserControltest.Bind();

            this.repList.DataSource = dt;
            this.repList.DataBind();
        }
        public static DataTable BulidDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns.Add("NumberCol", typeof(string));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2021, 1, 1);
            for (var i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] = "UserName" + i;
                dr["Birthday"] = baseDate.AddDays(i);
                dr["NumberCol"] = "";
                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}