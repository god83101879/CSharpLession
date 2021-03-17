<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello World!!
        </div>
        <asp:TextBox ID="TextBox2" runat="server" Enabled="false"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="class1"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" ToolTip="Hello"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
    </form>
</body>
</html>
