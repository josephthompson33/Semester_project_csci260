<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListOfUsers.aspx.cs" Inherits="WOB.PublicSite.ListOfUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rUsers" runat="server">

   <HeaderTemplate>

       <table>

           <tr>

               <td>

                   <strong>Name</strong>

               </td>

               <td>

                   <strong>Email</strong>

               </td>

               <td></td>

               <td></td>

           </tr>

   </HeaderTemplate>

   <ItemTemplate>

       <tr>

           <td><%# Eval("FirstName") %> <%# Eval("LastName") %></td>

           <td><%# Eval("Email") %></td>

           <td>

               <asp:Button ID="bDeleteUser" runat="server" CommandArgument='<%# Eval("UserID") %>'

OnClick="bDeleteUser_Click" Text="Delete" />

           </td>

           <td>

               <asp:HyperLink ID="hlEditUser" runat="server" NavigateURL='<%# "UpdateUser.aspx?UserID=" + Eval("UserID") %>'

Text="Edit" />

           </td>

       </tr>

   </ItemTemplate>

   <FooterTemplate>

       </table>

   </FooterTemplate>

</asp:Repeater>
</asp:Content>
