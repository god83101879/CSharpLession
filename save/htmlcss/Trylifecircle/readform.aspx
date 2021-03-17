<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="readform.aspx.cs" Inherits="Trylifecircle.readform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="我是增加" OnClick ="btnAdd_Click"/>
            <asp:Button ID="Button2" runat="server" Text="我是移除" OnClick ="btn_Click"/>
        </div>
    </form>
</body>
</html>
