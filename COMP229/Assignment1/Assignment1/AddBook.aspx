<%@ Page Title="Add Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="AddBook.aspx.cs" Inherits="Assignment1.AddBook" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Title %>.</h2>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book_panel.jpg" Width="400px"  ImageAlign="Middle"/><br />
        <br />
        <asp:TextBox ID="txtTitle" placeholder="Enter the Book Title"  Width="400px" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtAuthor" placeholder="Enter the Author's Name" Width="400px" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtPublisher" placeholder="Enter the Publisher" Width="400px" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtISBN" placeholder="Enter the ISBN number" Width="400px" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtEdition" placeholder="Enter the Edition" Width="400px" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Published"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />
        <br />
        <asp:TextBox ID="txtDescription" placeholder="Enter a Description" Width="400px" Height="120px" TextMode="MultiLine" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Book" /> &nbsp&nbsp
        <asp:Button ID="btnClear" runat="server" Text="Clear" /> &nbsp&nbsp
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />&nbsp&nbsp

    </div>
</asp:Content>
