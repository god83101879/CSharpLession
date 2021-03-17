<%@ Page Language="C#" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ltMsg.Text = "123";
    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"></head>
<body>
     <asp:Literal runat="server" ID="ltMsg"></asp:Literal>
</body>
</html>
