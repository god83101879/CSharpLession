<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <img src="web1/gura.jpg" />
            <img src="https://img.4gamers.com.tw/puku-clone-version/0f8c6821b78526fe91416977ce2d4db7-2865dae9701ca6da393457f2ef59ba3a2b803735.jpg" />
        </asp:PlaceHolder>
            <asp:Image ID="Image1" runat="server" Visible="false"/>

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="1"></asp:ListItem>
            <asp:ListItem Text="2"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button_Click"/>
    </form>

    <% Response.Write("123"); %>
</body>
</html>
