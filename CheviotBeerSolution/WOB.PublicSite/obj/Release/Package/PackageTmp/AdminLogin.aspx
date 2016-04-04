<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WOB.PublicSite.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Login to edit list of Beers, among other things.</p>
    <p>
        UserName:</p>
    <p>
        <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:</p>
    <p>
        <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="bLogin" runat="server" Text="Login" OnClick="bLogin_Click" />
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>
