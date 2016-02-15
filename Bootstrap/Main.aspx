<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Bootstrap.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contactlist" runat="server">
    <h1 style="margin-left:150px; font-size:large; color:white; margin-top: 80px">My Contactlist</h1>
        <div style="float:left; margin-left:150px; color:white"><asp:ListBox ID="ListBoxContacts" runat="server" Height="677px" Width="314px" AutoPostBack="True" BackColor="Transparent" Font-Size="Medium" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox></div>
</asp:Content>
