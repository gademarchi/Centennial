<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Library Collection</h1><br />
    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/book_panel.jpg"  Height="480" />
    <br />
 

  <div class="container"  style="object-position" >
    <label><b>E-mail: </b></label>
    <input type="text" placeholder="Enter E-mail" name="uname" required><br />
    <br />
    <label><b>Password: </b></label>
    <input type="password" placeholder="Enter Password" name="psw" required><br />
    <br />
    <button type="submit">Login</button>
    <input type="checkbox" checked="checked"> Remember me
  </div>

  <div class="container" style="background-color:#f1f1f1">
    <button type="button" class="cancelbtn">Cancel</button>
    <span class="psw">Forgot <a href="#">password?</a></span>
  </div>


</asp:Content>
