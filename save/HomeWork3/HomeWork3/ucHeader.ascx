<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHeader.ascx.cs" Inherits="HomeWork3.ucHeader" %>
<div class="BlockArea">
    <%--<div id="Logo">--%>
    <asp:HyperLink ID="Hyper" runat="server" ImageUrl="https://i.pinimg.com/originals/2a/c4/58/2ac45868f16c88f0aedcbf91752f8fa3.gif" NavigateUrl="https://www.youtube.com/watch?v=TzJW3OUSxKs" Target="_blank" />
    <%-- </div>--%>
    <div id="WebName">
        <h1><a href="MSindex.aspx"><span>HomeWorkpage</span></a></h1>
    </div>

    <div class="login">
        <span>
           <a href="MSlogin.aspx" id="headlog">登入</a>
        </span>
    </div>
</div>