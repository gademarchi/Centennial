<%@ Page  Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Assignment1.Search" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Title %>.</h2>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book_panel.jpg" Width="400px"  ImageAlign="Middle"/><br />
        <br />
        <asp:TextBox ID="txtSTitle" placeholder="Search a Book by the..."  Width="400px" runat="server"></asp:TextBox><br />
        <asp:RadioButton ID="RadioButton1"  Text="Title" runat="server" /> &nbsp&nbsp
        <asp:RadioButton ID="RadioButton2" Text="Author" runat="server" />&nbsp&nbsp
        <asp:RadioButton ID="RadioButton3" Text="ISBN" runat="server" />&nbsp&nbsp
        <br />
        <asp:Button ID="search" runat="server" Text="Search" /> &nbsp&nbsp
        <asp:Button ID="btnClear" runat="server" Text="Clear" /> &nbsp&nbsp
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />&nbsp&nbsp

    </div>
</asp:Content>

