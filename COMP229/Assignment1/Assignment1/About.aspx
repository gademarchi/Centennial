<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="About.aspx.cs"
     Inherits="Assignment1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Library Collection</h3>
    <p>You are creating web site that will allow its users to track their home library collection.</p>
    <p>In this assignment you are to decide on the general design of your web site.</p>
    <p>Your web site should include for this assignment at minimum satisfy the following requirements:</p>
    <p>Home page describes how the “Library collection” works so a user is aware what this web site is about.</p>
    <p>Home page also has a banner that has navigation links to following pages</p>
    <p>Home</p>
    <p>Books – a page that allows a user to see the books</p>
    <p>Add book – a page that allows a user to add a new book</p>
    <p>Search – a page that allows a user to search for books</p>
    <p>You can add any additional navigation that you wish.</p>
    <p>Create pages so the navigations in point 2. works. At this point there will be not much content in the pages.</p>
    <p>Make sure you use Master page(s) to make the site consistent</p>
    <p>Make sure a user can navigate from any page to the 4 pages outlined in the point 2.</p>
</asp:Content>
