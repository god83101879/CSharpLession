<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControltest.ascx.cs" Inherits="htmlcss.UserControltest" %>

<div>
    <a runat="server" id="aLinkFirst" href="#">First</a>

    <a runat="server" id="aPage1" href="#">1</a>
    <a runat="server" id="aPage2" href="#">2</a>
    <a runat="server" id="aPage3" href="#">3</a>

    <a runat="Server" id="aLinkLast" href="#">Last</a>
</div>
<div>
    <asp:Literal runat="Server" ID="ltCurrentPage" />
    <asp:Literal runat="Server" ID="ltTotalPage" />
</div>
