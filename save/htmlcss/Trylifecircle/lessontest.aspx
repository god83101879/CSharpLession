<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lessontest.aspx.cs" Inherits="Trylifecircle.lessontest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder runat="server" ID="plc1"> </asp:PlaceHolder>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button_Click"/>
        </div>
    </form>
</body>
</html>
