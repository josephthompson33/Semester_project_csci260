<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WOB.PublicSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CreateUser.aspx">Create An Account</asp:HyperLink>
    <br />
</p>
<p>
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/UserLogin.aspx">Login</asp:HyperLink>
</p>
<p>
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/AdminLogin.aspx">Admin users sign in here</asp:HyperLink>
</p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
    <p>
        <asp:Label ID="lMessage" runat="server"></asp:Label>
</p>
</asp:Content>
