<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        單行<asp:TextBox ID="TextBox1" runat="server" Enabled="true"></asp:TextBox> <br />
        多行<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox> <br />
        密碼<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox> <br />
        數字<asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
