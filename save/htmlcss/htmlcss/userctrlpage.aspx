<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userctrlpage.aspx.cs" Inherits="htmlcss.userctrlpage" %>

<%@ Register Src="~/userctrlpage1.ascx" TagPrefix="uc1" TagName="userctrlpage1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        123321
        123321
        <uc1:userctrlpage1 runat="server" id="userctrlpage1" />
        <uc1:userctrlpage1 runat="server" id="userctrlpage2" />
    </form>
</body>
</html>
