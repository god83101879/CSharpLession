<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webjs.aspx.cs" Inherits="BasicWebForm.webjs" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
        <script src="jstest.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="id2"></div>
                <p>123</p>
                <p id="id1">123</p>
                <p>123</p>
        

            <input id="inp1" runat="server" type="text" value="AAA" />

            <button type="button" onclick="func1()">alertval</button>
            <button type="button" onclick="func2()">appendtext</button>
            <button type="button" onclick="func3()">appendhtml</button>

            <input type="text" id="inpKeyUp" onkeyup="inpKeyUp_KeyUp()" />
            
            <script>
                <asp:Literal runat="server" ID="ltArr"></asp:Literal>
                //var arr2 = [{ UserName: "John", Age: 17, Sex: "Female" }, { UserName: "Mary", Age: 16, Sex: "Female" }, { UserName: "Johnny", Age: 18, Sex: "Male" }]
            </script>
        </div>

       
    </form>
</body>
</html>
