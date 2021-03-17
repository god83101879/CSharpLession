<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webtest1.aspx.cs" Inherits="webtest1.webtest1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 134px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 134px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th>欄1</th>
                    <th>欄2</th>
                    <th>欄3</th>
                    <th>欄4</th>
                </tr>
                <asp:Literal Text="" ID="Literal" runat="server" />
                <%--<tr>
                    <th>第一列 - 值1</th>
                    <th>第一列 - 值2</th>
                    <th rowspan="2">第一列 - 值3第二列 - 值3</th>
                </tr>
                <tr>
                    <th>第二列 - 值1</th>
                    <th>第二列 - 值2</th>
                </tr> --%>
             </table>
        </div>
    </form>
</body>
</html>
