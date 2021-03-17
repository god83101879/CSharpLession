<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GriedViewPage.aspx.cs" Inherits="webtest1.GriedViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="編號" />
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Birthday" DataFormatString="{0:yyyy/MM/dd}" HeaderText="生日" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
