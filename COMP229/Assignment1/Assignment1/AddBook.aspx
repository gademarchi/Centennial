<%@ Page Title="Add Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Assignment1.AddBook" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Title %>.</h2>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book_panel.jpg" Width="380px"  ImageAlign="Middle"/><br />
        <br />
        <asp:TextBox ID="txtTitle" placeholder="Enter the Book Title" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtAuthor" placeholder="Enter the Author's Name" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtPublisher" placeholder="Enter the Publisher" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtISBN" placeholder="Enter the ISBN number" runat="server"></asp:TextBox>
    </div>
</asp:Content>
