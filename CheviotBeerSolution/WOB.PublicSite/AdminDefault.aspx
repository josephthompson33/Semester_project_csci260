<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminDefault.aspx.cs" Inherits="WOB.PublicSite.AdminDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CreateAdmin.aspx">Create New Admin User</asp:HyperLink>
</p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListOfUsers.aspx">List Of All users</asp:HyperLink>
    <br />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
