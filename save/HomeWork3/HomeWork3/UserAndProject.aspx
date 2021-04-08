<%@ Page Title="" Language="C#" MasterPageFile="~/homeworkmaste.Master" AutoEventWireup="true" CodeBehind="UserAndProject.aspx.cs" Inherits="HomeWork3.UserAndProject" %>

<%@ Register Src="~/table.ascx" TagPrefix="uc1" TagName="table" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:table runat="server" id="table" />
</asp:Content>
