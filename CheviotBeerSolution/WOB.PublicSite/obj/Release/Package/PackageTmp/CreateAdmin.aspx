<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateAdmin.aspx.cs" Inherits="WOB.PublicSite.CreateAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Here, you can create new Admin Users who are able to do all of the things that you are.</p>
<p>
    UserName</p>
<p>
    <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
</p>
<p>
    Password:</p>
<p>
    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="bSubmit" runat="server" OnClick="bSubmit_Click" Text="Submit" />
</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminDefault.aspx">Return To Admin HomePage</asp:HyperLink>
</p>
<p>
    &nbsp;</p>
</asp:Content>
