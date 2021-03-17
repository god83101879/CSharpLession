using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace webtest1
{
    public partial class RepeaterPage : System.Web.UI.Page
    {
        protected void Page_Init(Object sender, EventArgs e)
        {
            /*DataTable dt = BulidDataTable();

            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();*/
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BulidDataTable();

            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }
        public static DataTable BulidDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns.Add("NumberCol", typeof(int));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2021, 1, 1);
            for (var i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] = "UserName" + i;
                dr["Birthday"] = baseDate.AddDays(i);
                dr["NumberCol"] = i;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Literal ltl = e.Item.FindControl("ltName") as Literal ;

                if (ltl == null)
                {
                    return;
                }
                else
                {
                    DataRowView drv = e.Item.DataItem as DataRowView;
                    int? NumberCol = drv.Row.Field<int?>
                    ("NumberCol");

                    if (NumberCol.HasValue && NumberCol.Value == 3)
                    {
                        ltl.Text = "Success~~";
                    }
                    //drv["NumberCol"];
                }
            }
        }

        protected void Repater1_ItemCommand(Object source, RepeaterCommandEventArgs e)
        {
            string cmdName = e.CommandName;
            string cmdArgu = e.CommandArgument.ToString();

            if ("DeleteItem" == cmdName)
            {
                //資料刪除
                // BulidDataTable(cmdArgu); //DataBaseExecutor.DeleteTestTable1(cmdArgu);
                // DataTable dt = DataBaseExecutor.ReadTestTable1DT();

                this.Repeater1.DataSource = BulidDataTable(); //dt;
                this.Repeater1.DataBind();

            }
        }
    }
}