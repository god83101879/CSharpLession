<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Trylifecircle.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder runat="server" ID="plc1">
            帳號<asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
            <br />
            密碼<asp:TextBox ID="txtPassword" runat="server" type="password" ></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
            </asp:PlaceHolder>
            <asp:PlaceHolder runat="server" ID="plc2" Visible="false">
                <asp:Literal runat="server" ID="ltAccount"></asp:Literal>
                <asp:Button ID="btnnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click"/>
            </asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
