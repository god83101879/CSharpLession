<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="1" Text="First"></aspListItem>
            <asp:ListItem Value="2">second</aspListItem>
            <asp:ListItem >third</aspListItem>
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1" Text="First"></aspListItem>
            <asp:ListItem Value="2">second</aspListItem>
            <asp:ListItem >third</aspListItem>
        </asp:RadioButtonList>
        <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
