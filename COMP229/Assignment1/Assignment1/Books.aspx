<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs"
     Inherits="Assignment1.Books" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Title %>.</h2>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book_panel.jpg" Width="380px"/><br />
        <br />
        <h3> Best Sellers <%: DateTime.Now.Year %></h3>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/best.jpg" Width="840px" />
        <br />
        <br />
        <h3>New York Best Sellers <%: DateTime.Now.Year %></h3>
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/ny.jpg" Width="840px" />
    </div>
</asp:Content>
