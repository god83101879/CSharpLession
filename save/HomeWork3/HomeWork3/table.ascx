﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="table.ascx.cs" Inherits="HomeWork3.table" %>

<div>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:DropDownList runat="server" ID="DropDownList1">
        <asp:ListItem Text="Users資料表" Value="Users" />
        <asp:ListItem Text="Projects資料表" Value="Projects" />
    </asp:DropDownList>
    <asp:DropDownList runat="server" ID="DropDownList2">
        <asp:ListItem Text="插入" Value="Insert" />
        <asp:ListItem Text="更新" Value="Update" />
        <asp:ListItem Text="刪除" Value="Delete" />
    </asp:DropDownList><asp:Button Text="更換目標" runat="server" ID="Button1" OnClick="Button1_Click" /><br />
    <asp:RadioButtonList runat="server" ID="RadioButtonList1" Visible="false">
    </asp:RadioButtonList>
    <asp:Label Text="" runat="server" ID="Labell" /><asp:TextBox runat="server" ID="Text1" Visible="False" /><br />
    <asp:Label Text="" runat="server" ID="Label2" /><asp:TextBox runat="server" ID="Text2" Visible="False" /><br />
    <asp:Label Text="" runat="server" ID="Label3" /><asp:TextBox runat="server" ID="Text3" Visible="False" /><br />
    <asp:Label Text="" runat="server" ID="Label4" /><asp:TextBox runat="server" ID="Text4" Visible="False" /><br />
    <asp:Label Text="" runat="server" ID="Label5" /><asp:TextBox runat="server" ID="Text5" Visible="False" /><br />
    <asp:Label Text="" runat="server" ID="Label6" /><asp:TextBox runat="server" ID="Text6" Visible="False" /><br />

    <asp:Button Text="text" runat="server" ID="Button2" Visible="false" OnClick="Button2_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button Text="查詢Users資料表" runat="server" OnClick="Unnamed1_Click" />
    <asp:Button Text="查詢Projects資料表" runat="server" OnClick="Unnamed2_Click" />

    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>
            <div id="DBDataArea">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("License"): Eval("ProjectID") %><br />
                 <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("Account"): Eval("ProjectName") %><br />
                <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("Name"): Eval("TeamID") %><br />
                <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("Phone"): Eval("TeamName") %><br />
                <asp:Literal ID="Literal5" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("Mail"): Eval("DeadLine","{0: yyyy/MM/dd}") %><br />
                <asp:Literal ID="Literal6" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("LineID"): Eval("CreateDate","{0: yyyy/MM/dd}") %><br />
                <asp:Literal ID="Literal7" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("Privilege"): Eval("WhoCreate") %><br />
                <asp:Literal ID="Literal8" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("CreateDate","{0: yyyy/MM/dd}"): Eval("ProjectName") %><br />
                <asp:Literal ID="Literal9" runat="server"></asp:Literal>
                <%# HiddenField1.Value=="User"?Eval("WhoCreate"): Eval("ProjectName") %><br />
            </div>
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
</div>
