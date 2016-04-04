<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="WOB.PublicSite.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Create an account to reserve special release beer, among other things</p>
    <p>
        Maximum of 16 characters per field.</p>
<p>
    &nbsp;FirstName:</p>
<p>
    <asp:TextBox ID="tbFirstName" runat="server" MaxLength="16"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredField" ControlToValidate="tbFirstName" ValidationGroup="vgSubmit"></asp:RequiredFieldValidator>
</p>
<p>
    LastName:</p>
<p>
    <asp:TextBox ID="tbLastName" runat="server" MaxLength="16"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLastName" ErrorMessage="RequiredField" ValidationGroup="vgSubmit"></asp:RequiredFieldValidator>
</p>
<p>
    Email:</p>
<p>
    <asp:TextBox ID="tbEmail" runat="server" MaxLength="16"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" ErrorMessage="RequiredField" ValidationGroup="vgSubmit"></asp:RequiredFieldValidator>
</p>
<p>
    Password:</p>
<p>
    <asp:TextBox ID="tbPassword" runat="server" MaxLength="16"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbPassword" ErrorMessage="RequiredField" ValidationGroup="vgSubmit"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Button ID="bSubmit" runat="server" Text="Submit" OnClick="bSubmit_Click" ValidationGroup="vgSubmit" />
</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return to Homepage</asp:HyperLink>
</p>
<p>
</p>
</asp:Content>
