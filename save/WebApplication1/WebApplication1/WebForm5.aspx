<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat ="server">
        <asp:ListItem Value = "1" Text="First"></asp:ListItem>
        <asp:ListItem Value = "2" Text="Second"></asp:ListItem>
        <asp:ListItem >Third</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat ="server" Text="Button" OnClick="Button1_Click"/><br />
        <asp:Label ID="Label1" runat ="server"></asp:Label>

    </form>
</body>
</html>
