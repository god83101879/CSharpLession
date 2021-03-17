<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weekhw2.aspx.cs" Inherits="weekhw2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> <%--表單段落、建立表單用 runat="server"表示此功能在服務器端本身使用(如果編寫時不使用 無法在方法內呼叫ID使用)--%>
        <div>   
            <!--下拉式選單 選擇個人資料表及專案資料表 Text為顯示出來的名稱-->
            <asp:DropDownList ID="DropDownList1" runat="server">   
                <asp:ListItem Text ="Personals資料表" Value ="Personals" />
                <asp:ListItem Text ="Projects資料表" Value ="Projects" />
            </asp:DropDownList>     
            <!--下拉式選單 選擇插入\更新\刪除-->
            <asp:DropDownList ID="DropDownList2" runat="server">     
                <asp:ListItem Text="插入" Value="Insert" />
                <asp:ListItem Text="更新" Value="Update" />
                <asp:ListItem Text="刪除" Value="Delete" />
            </asp:DropDownList>
            <!--選好上列兩項按下更換目標後變更-->
            <asp:Button ID="Button1" runat="server" Text="更換目標" OnClick="Button1_Click" /> <br /> 
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="false"></asp:RadioButtonList><br />

            <!--選完之後顯示之標籤 會因選項不同而顯示不同-->
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text1" runat="server" Visible="false"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text2" runat="server" Visible="false"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text3" runat="server" Visible="false"></asp:TextBox>
            <br />

            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text4" runat="server" Visible="false"></asp:TextBox>
            <br />

            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text5" runat="server" Visible="false"></asp:TextBox>
            <br />

            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="Text6" runat="server" Visible="false"></asp:TextBox>
            <br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <!--上述標籤輸入完畢後可點此按鈕更新\刪除\插入-->
            <asp:Button ID="Button2" runat="server" Text="text" Visible="false" OnClick="Button2_Click" />
&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button  runat="server" Text="查詢Personals資料表" OnClick="Unnamed1_Click"/> <%--OnClick==>寫入功能方法aspx.cs--%>
            <asp:Button  runat="server" Text="查詢Projects資料表" OnClick="Unnamed2_Click"/>
            <br />
            <asp:GridView ID="GridView1" runat="server"> <%--按下按鈕後顯示資料來源中的資料用--%>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
