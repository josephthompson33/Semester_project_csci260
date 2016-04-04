<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="WOB.PublicSite.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Change any of the fields shown to the new desired value:</p>
<p>
    Email:</p>
<p>
    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredField" ValidationGroup="vgChange"></asp:RequiredFieldValidator>
</p>
<p>
    FirstName:</p>
<p>
    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredField" ValidationGroup="vgChange"></asp:RequiredFieldValidator>
</p>
<p>
    LastName:</p>
<p>
    <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredField" ValidationGroup="vgChange"></asp:RequiredFieldValidator>
</p>
    <p>
        Password:</p>
    <p>
        <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredField" ValidationGroup="vgChange"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Button ID="bChange" runat="server" OnClick="bChange_Click" Text="Change" ValidationGroup="vgChange" />
</p>
<p>
</p>
<p>
</p>
</asp:Content>
