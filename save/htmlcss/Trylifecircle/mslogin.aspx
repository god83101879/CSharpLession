<%@ Page Title="" Language="C#" MasterPageFile="~/loginout.Master" AutoEventWireup="true" CodeBehind="mslogin.aspx.cs" Inherits="Trylifecircle.mslogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:PlaceHolder runat="server" ID="plc1">帳號<asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
            <br />
            密碼<asp:TextBox ID="txtPassword" runat="server" type="password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="登入" OnClick="btnLogin_Click" />
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="plc2" Visible="false">
            <asp:Literal runat="server" ID="ltAccount"></asp:Literal>
            <asp:Button ID="btnnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </asp:PlaceHolder>
    </div>
</asp:Content>
