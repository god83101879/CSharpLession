<%@ Page Title="" Language="C#" MasterPageFile="~/lifems.Master" AutoEventWireup="true" CodeBehind="lifecircleweb.aspx.cs" Inherits="Trylifecircle.lifecircleweb" %>

<%@ Register Src="~/lifecircle1.ascx" TagPrefix="uc1" TagName="lifecircle1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" Onclick="Button1_Click"/>
    <uc1:lifecircle1 runat="server" ID="lifecircle1" />
</asp:Content>
