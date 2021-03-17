<%@ Page Title="" Language="C#" MasterPageFile="~/MStest.Master" AutoEventWireup="true" CodeBehind="usemsWebForm.aspx.cs" Inherits="htmlcss.usemsWebForm" %>

<%@ Register Src="~/userctrlpage1.ascx" TagPrefix="uc1" TagName="userctrlpage1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:userctrlpage1 runat="server" ID="userctrlpage1" />
    <uc1:userctrlpage1 runat="server" ID="userctrlpage2" />
</asp:Content>
