﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FrontEndHomework.Homework5.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table id="tableList" border="1">
            <tr>
                <th>Book name</th>
                <th>ISBN</th>
                <th>Price</th>
            </tr>
        </table>
    </form>
    <script src="Main.js"></script>
    <script>
        var itemArr = <%= this.ArrText %>;

        init(itemArr);
    </script>
</body>
</html>