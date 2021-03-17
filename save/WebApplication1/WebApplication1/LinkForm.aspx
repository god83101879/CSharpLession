<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkForm.aspx.cs" Inherits="WebApplication1.LinkForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a runat="server" id="aLink" href="LinkTo.aspx" target="_blank">LinkTo</a>
        <a href="LinkTo.aspx" target="_self">LinkTo</a>
        <a href="LinkTo.aspx" target="_parent">LinkTo</a>
        <a href="LinkTo.aspx" target="_top">LinkTo</a>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
    </form>
</body>
</html>
