using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace weekhw2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //sender引數用於傳遞指向事件源物件的引用。表示触发事件的那个控件。例如button的話sender就是按鈕本身那麼這個sender就代表這個button自己。
        { //e引數是是EventArgs型別。簡單來理解就是記錄事件傳遞過來的額外資訊。一般用於傳遞使用者點選的位置啊，鍵盤按下的鍵等事件的額外資訊。
            if (!IsPostBack)
            {
                DropDownList1.SelectedValue = "Personals";
                DropDownList2.SelectedValue = "Insert";
                Button2.Text = "插入";
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string[] readcol = { "PersonalAccount", "Name", "PhoneNumber", "EMail", "LineID", "AuthorizationCode", "Authority", "CreateTime", "Creator" };
            GridView1.DataSource = SQL.readTable("Personals", readcol);
            GridView1.DataBind();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string[] readcol = { "ProjectID", "ProjectName", "TeamID", "TeamName", "ScheduleDeadLine", "CreateTime", "Creator" };
            GridView1.DataSource = SQL.readTable("Projects", readcol);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label7.Text = "";
            if (DropDownList2.SelectedValue == "Insert")
            {
                Button2.Text = "插入";
                Button2.Visible = true;
                if (DropDownList1.SelectedValue == "Personals")
                {
                    Text1.Visible = true;
                    Label1.Text = "授權碼: ";
                    Text2.Visible = true;
                    Label2.Text = "權限: ";
                    Text3.Visible = true;
                    Label3.Text = "建立時間: ";
                    Text4.Visible = true;
                    Label4.Text = "建立者: ";
                    Text5.Visible = false;
                    Label5.Text = "";
                    Text6.Visible = false;
                    Label6.Text = "";
                    RadioButtonList1.Visible = false;
                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    Text1.Visible = true;
                    Label1.Text = "專案名稱: ";
                    Text2.Visible = true;
                    Label2.Text = "小組組別: ";
                    Text3.Visible = true;
                    Label3.Text = "小組名稱: ";
                    Text4.Visible = true;
                    Label4.Text = "時程期限: ";
                    Text5.Visible = true;
                    Label5.Text = "建立時間: ";
                    Text6.Visible = true;
                    Label6.Text = "建立者: ";
                    RadioButtonList1.Visible = false;
                }
            }
            else if (DropDownList2.SelectedValue == "Update")
            {
                Button2.Text = "更新";
                Button2.Visible = true;
                if (DropDownList1.SelectedValue == "Personals")
                {
                    Text1.Visible = true;
                    Label1.Text = "帳號: ";
                    Text2.Visible = true;
                    Label2.Text = "姓名: ";
                    Text3.Visible = true;
                    Label3.Text = "電話號碼: ";
                    Text4.Visible = true;
                    Label4.Text = "電子郵件: ";
                    Text5.Visible = true;
                    Label5.Text = "LineID";
                    Text6.Visible = true;
                    Label6.Text = "欲更改之資料授權碼";
                    RadioButtonList1.Visible = false;
                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    Text1.Visible = true;
                    Label1.Text = "專案名: ";
                    Text2.Visible = true;
                    Label2.Text = "小組組別: ";
                    Text3.Visible = true;
                    Label3.Text = "小組名稱: ";
                    Text4.Visible = true;
                    Label4.Text = "時程期限: ";
                    Text5.Visible = true;
                    Label5.Text = "欲更改之專案ID";
                    Text6.Visible = false;
                    Label6.Text = "";
                    RadioButtonList1.Visible = false;
                }
            }
            else if (DropDownList2.SelectedValue == "Delete")
            {
                Button2.Text = "刪除";
                Button2.Visible = true;
                Text1.Visible = false;
                Label1.Text = "";
                Text2.Visible = false;
                Label2.Text = "";
                Text3.Visible = false;
                Label3.Text = "";
                Text4.Visible = false;
                Label4.Text = "";
                Text5.Visible = false;
                Label5.Text = "";
                Text6.Visible = false;
                Label6.Text = "";
                RadioButtonList1.Visible = true;
                this.RadioButtonList1.Items.Clear();
                if (DropDownList1.SelectedValue == "Personals")
                {
                    string[] readcol = { "PersonalID", "PersonalAccount", "Name" };
                    string wantdelete = "";
                    foreach (DataRow item in SQL.readTable("Personals", readcol).Rows)
                    {
                        wantdelete = $"ID:{item[0]}   帳號:{item[1]}    姓名:{item[2]}";
                        RadioButtonList1.Items.Add(new ListItem($"{wantdelete}", $"{item[0]}"));
                    }
                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    string[] readcol = { "ProjectID", "ProjectName", "TeamName" };
                    string wantdelete = "";
                    foreach (DataRow item in SQL.readTable("Projects", readcol).Rows)
                    {
                        wantdelete = $"ID:{item[0]}   專案:{item[1]}   負責組:{item[2]}";
                        RadioButtonList1.Items.Add(new ListItem($"{wantdelete}", $"{item[0]}"));
                    }
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedValue == "Insert")
            {
                if (DropDownList1.SelectedValue == "Personals")
                {
                    string[] insertcol = { "AuthorizationCode", "Authority", "CreateTime", "Creator" };
                    string[] insertcolp = { "@AuthorizationCode", "@Authority", "@CreateTime", "@Creator" };
                    List<string> personalinsert = new List<string>(); //List< String >:泛型，非定長，可變。
                    personalinsert.Add(Text1.Text);
                    personalinsert.Add(Text2.Text);
                    personalinsert.Add(Text3.Text);
                    personalinsert.Add(Text4.Text);
                    SQL.InsertTable("Personals", insertcol, insertcolp, personalinsert);
                    Label7.Text = "插入資料完成";
                    string[] readcol = { "PersonalAccount", "Name", "PhoneNumber", "EMail", "LineID", "AuthorizationCode", "Authority", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Personals", readcol);
                    GridView1.DataBind();

                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    string[] insertcol = { "ProjectName", "TeamID", "TeamName", "ScheduleDeadline", "CreateTime", "Creator" };
                    string[] insertcolp = { "@ProjectName", "@TeamID", "@TeamName", "@ScheduleDeadline", "@CreateTime", "@Creator" };
                    List<string> personalinsert = new List<string>();
                    personalinsert.Add(Text1.Text);
                    personalinsert.Add(Text2.Text);
                    personalinsert.Add(Text3.Text);
                    personalinsert.Add(Text4.Text);
                    personalinsert.Add(Text5.Text);
                    personalinsert.Add(Text6.Text);
                    SQL.InsertTable("Projects", insertcol, insertcolp, personalinsert);
                    Label7.Text = "插入資料完成";
                    string[] readcol = { "ProjectID", "ProjectName", "TeamID", "TeamName", "DeadLine", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Projects", readcol);
                    GridView1.DataBind();
                }
            }
            else if (DropDownList2.SelectedValue == "Update")
            {
                if (DropDownList1.SelectedValue == "Personals")
                {
                    string[] updatecol = { "PersonalAccount=@PersonalAccount", "Name=@Name", "PhoneNumber=@PhoneNumber", "EMail=@EMail", "LineID=@LineID" };
                    string wherep = "AuthorizationCode=@AuthorizationCode";
                    string[] updatecolp = { "@PersonalAccount", "@Name", "@PhoneNumber", "@EMail", "@LineID", "@AuthorizationCode" };
                    List<string> userupdate = new List<string>();
                    userupdate.Add(Text1.Text);
                    userupdate.Add(Text2.Text);
                    userupdate.Add(Text3.Text);
                    userupdate.Add(Text4.Text);
                    userupdate.Add(Text5.Text);
                    userupdate.Add(Text6.Text);
                    SQL.UpdateTable("Personals", updatecol, wherep, updatecolp, userupdate);
                    Label7.Text = "更新資料完成";
                    string[] readcol = { "PersonalAccount", "Name", "PhoneNumber", "EMail", "LineID", "AuthorizationCode", "Authority", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Personals", readcol);
                    GridView1.DataBind();
                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    string[] updatecol = { "ProjectName=@ProjectName", "TeamID=@TeamID", "TeamName=@TeamName", "ScheduleDeadline=@ScheduleDeadline" };
                    string wherep = "ProjectID=@ProjectID";
                    string[] updatecolp = { "@ProjectName", "@TeamID", "@TeamName", "@ScheduleDeadline", "@ProjectID" };
                    List<string> userupdate = new List<string>();
                    userupdate.Add(Text1.Text);
                    userupdate.Add(Text2.Text);
                    userupdate.Add(Text3.Text);
                    userupdate.Add(Text4.Text);
                    userupdate.Add(Text5.Text);
                    SQL.UpdateTable("Projects", updatecol, wherep, updatecolp, userupdate);
                    Label7.Text = "更新資料完成";
                    string[] readcol = { "ProjectID", "ProjectName", "TeamID", "TeamName", "DeadLine", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Projects", readcol);
                    GridView1.DataBind();
                }
            }
            else if (DropDownList2.SelectedValue == "Delete")
            {
                if (DropDownList1.SelectedValue == "Personals")
                {
                    string rdbVal = this.RadioButtonList1.SelectedValue;
                    SQL.DeleteTable("Personals", "PersonalID", "@PersonalID", rdbVal);
                    string[] readcol = { "PersonalAccount", "Name", "PhoneNumber", "EMail", "LineID", "AuthorizationCode", "Authority", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Personals", readcol);
                    GridView1.DataBind();
                    this.RadioButtonList1.Items.Clear();
                    string[] readcol2 = { "PersonalID", "PersonalAccount", "Name" };
                    string wantdelete = "";
                    foreach (DataRow item in SQL.readTable("Personals", readcol).Rows)
                    {
                        wantdelete = $"ID:{item[0]}   帳號:{item[1]}    姓名:{item[2]}";
                        RadioButtonList1.Items.Add(new ListItem($"{wantdelete}", $"{item[0]}"));
                    }

                }
                else if (DropDownList1.SelectedValue == "Projects")
                {
                    string rdbVal = this.RadioButtonList1.SelectedValue;
                    SQL.DeleteTable("Projects", "ProjectID", "@ProjectID", rdbVal);
                    string[] readcol = { "ProjectID", "ProjectName", "TeamID", "TeamName", "ScheduleDeadline", "CreateTime", "Creator" };
                    GridView1.DataSource = SQL.readTable("Projects", readcol);
                    GridView1.DataBind();
                    this.RadioButtonList1.Items.Clear();
                    string[] readcol2 = { "ProjectID", "ProjectName", "TeamName" };
                    string wantdelete = "";
                    foreach (DataRow item in SQL.readTable("Projects", readcol).Rows)
                    {
                        wantdelete = $"ID:{item[0]}   專案:{item[1]}   負責組:{item[2]}";
                        RadioButtonList1.Items.Add(new ListItem($"{wantdelete}", $"{item[0]}"));
                    }
                }
            }

        }
    }
}