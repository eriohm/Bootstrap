<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditContact.aspx.cs" Inherits="Bootstrap.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contactlist" runat="server">
     <h1 style="margin-left:150px; font-size:large; color:white; margin-top: 80px">Choose contact to update:</h1>
        <div style="float:left; margin-left:150px; color:white"><asp:ListBox ID="ListBoxContacts" runat="server" Height="677px" Width="314px" AutoPostBack="True" BackColor="Transparent" Font-Size="Medium" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox></div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contactfields" runat="server">
    <div style="margin-left:800px">
            <asp:Label ID="LabelFirstName" runat="server" Text="Firstname:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxFirstName" runat="server" BackColor="Transparent" OnTextChanged="TextBoxFirstName_TextChanged"></asp:TextBox></dl>
            <asp:Label ID="LabelLastName" runat="server" Text="Lastname:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxLastName" runat="server" BackColor="Transparent" OnTextChanged="TextBoxLastName_TextChanged"></asp:TextBox></dl>
            <asp:Label ID="LabelSSN" runat="server" Text="SSN:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxSSN" runat="server" BackColor="Transparent" OnTextChanged="TextBoxSSN_TextChanged"></asp:TextBox></dl>
            <asp:Label ID="LabelPhone" runat="server" Text="Phone Number:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxPhone" runat="server" BackColor="Transparent" OnTextChanged="TextBoxPhone_TextChanged"></asp:TextBox></dl>
            <asp:Label ID="LabelStreet" runat="server" Text="Street:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxStreet" runat="server" BackColor="Transparent" OnTextChanged="TextBoxStreet_TextChanged"></asp:TextBox></dl>
            <asp:Label ID="LabelCity" runat="server" Text="City:"></asp:Label>
            <dl><asp:TextBox ID="TextBoxCity" runat="server" BackColor="Transparent" OnTextChanged="TextBoxCity_TextChanged"></asp:TextBox></dl>
     </div>
        <p style="height: 53px; float:left; margin-left:800px; color:black">
        <asp:Button ID="ButtonEdit" runat="server" Text="Update contact" OnClick="ButtonOk_Click" Width="150px" />
        </p>
</asp:Content>