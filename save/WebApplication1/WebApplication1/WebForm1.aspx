<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Daniel的網頁</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 runat="server" id="h1_1">我是大標題</h1>
            <h2>我是中標題</h2>
            <!--介紹-->

            <% for (int i = 0; i < 20; i++) %>
            <% { %>
            <% if (i % 2 = 0) %>
            <% { %>
            <p>哎呀 <% = i%></p>
            <% } %>
            <p>123</p>
            <% } %>
            <div>
                <% = DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss") %>
            </div>
        </div>
    </form>
</body>
</html>
