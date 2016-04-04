<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WOB.PublicSite.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Login to your account:</p>
<p>
    Email:</p>
<p>
    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
</p>
<p>
    Password:</p>
<p>
    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="bLogin" runat="server" Text="Login" OnClick="bLogin_Click" />
</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
</asp:Content>
