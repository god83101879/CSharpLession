using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace webtest1
{
    public partial class webtest1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BulidDataTable();

            string outputText = string.Empty;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                String id = dr["ID"].ToString();
                String name = dr["Name"].ToString();
                String Birthday = dr["Birthday"].ToString();
                String NumberCol= dr["NumberCol"].ToString();

                outputText += "<tr>";

                outputText += $"<td>{id}</td>";
                outputText += $"<td>{name}</td>";
                outputText += $"<td>{Birthday}</td>";
                outputText += $"<td>{NumberCol}</td>";

                outputText += "</tr>";
            }
            this.Literal.Text = outputText;
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

/*string[,] arr =
{
                // "aa", "bb"
                { "a1" , "a2" , "a3" , "a4"},
                { "b1" , "b2" , "b3" , "b4"},
                { "c1" , "c2" , "c3" , "c4"},
            };

string outputText = string.Empty;

for (int i = 0; i < 3; i++) //i<arr.Length
{
    outputText += "<tr>";

    for (int j = 0; j < 4; j++)
    {
        outputText += $"<td> {arr[i, j]}</td>"; //可加按鈕或其他的
    }
    outputText += "</tr>";
    /*    $@"
        <tr>
            <td>{arr[i]}</td>
            <td>第一列 - 值2</td>
            <td>第一列 - 值3</td>
        </tr>
        ";*/
//}

/*
//轉型
int numCol = Convert.ToInt32(NumberCol);
int numCol2 = dr.Field<int>("NumberCol");
int? numCol3 = dr.Field<int?>("NumberCol"); //?允許null

if (numCol3.HasValue)
    outputText += $"<td>{numCol3.Value}</td>";
else
    outputText += $"<td>-</td>";

// null 1
if (!dr.IsNull("NumberCol"))
    outputText += $"<td>{NumberCol}</td>";
else
    outputText += $"<td>-</td>";

// null 2
outputText += $"<td>{((!dr.IsNull("NumberCol")) ? NumberCol : "-")}</td>";

// null 3
if (dr["NumberCol"] == null)
    outputText += $"<td>{NumberCol}</td>";
else
    outputText += $"<td>-</td>";
*/