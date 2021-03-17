<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppandAPP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Birthday:<asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
            <br />
            NumberColumn<asp:TextBox ID="txtNumberCol" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnCLick="Button1_Click" />
        </div>
    </form>
</body>
</html>
