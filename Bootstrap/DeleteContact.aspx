<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteContact.aspx.cs" Inherits="Bootstrap.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contactlist" runat="server">
     <h1 style="margin-left:150px; font-size:large; color:white; margin-top: 80px">Choose contact to eliminate:</h1>
        <div style="float:left; margin-left:150px; color:white"><asp:ListBox ID="ListBoxContacts" runat="server" Height="677px" Width="314px" AutoPostBack="True" BackColor="Transparent" Font-Size="Medium" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox></div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contactfields" runat="server">
        <p style="height: 53px; float:left; margin-left:150px; color:black">
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete contact" OnClick="ButtonOk_Click" Width="150px" />
        </p>
</asp:Content>
