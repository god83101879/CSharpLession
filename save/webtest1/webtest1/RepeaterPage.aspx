<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterPage.aspx.cs" Inherits="webtest1.RepeaterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                <ItemTemplate>
                    ID: <%# Eval("ID") %> <br />  <!--Eval是個方法-->
                    Name: <%# Eval("Name") %> <br />
                    Birthday: <%# Eval("Birthday", "{0: yyyy-MM-dd}") %> <br />
                    <asp:Literal runat ="server" ID="ltName"> - </asp:Literal>
                    <br />
                    <asp:Button runat="server" Text="Button" CommandName="DeleteItem" CommandArgument='<%# Eval("ID")%>'/>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
