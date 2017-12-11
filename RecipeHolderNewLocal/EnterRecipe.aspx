<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterRecipe.aspx.cs" Inherits="RecipeHolderNewLocal.EnterRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Welcome to the EnterRecipe page!</h2>
    This page enters typed notes into the TextBox -
    txtB_InitialEnterNote - and upon pressing the 
    TAB key on the keyboard or clicking outside the textbox,
    a txtB_InitalEnterNote_TextChanged event handler is called. 
    This handler saves the typed note
    in a session variable named Recipe1. It then redirects the user 
    to the DisplayRecipe.aspx page where an option to save the note
    to the Recipes table 
    in the azure SqlDatabase - RecipeHolder_db exists.<br />
    ==============================================================

      <h3>Enter Your Notes OR Recipe Here</h3>
    <h3>How to enter:</h3>
    Place cursor in the textbox labelled "Enter Notes". Erase the
    phrase "Enter Notes". Place cursor in top left corner of the
    textbox control and begin entering data. Use the "Enter" key
    to go to the next line. When you are ready to submit your 
    document, press the TAB key or click the mouse on any area
    outside the textbox.<br /><br />
    <%-- TextBox control in which to initially enter the recipe/note. --%>
      <asp:TextBox ID="txtB_InitialEnterNote" runat="server" MaxLength="1024"  
        OnTextChanged="txtB_InitialEnterNote_TextChanged" BorderColor="#0033CC" 
          AutoPostBack="true" EnableViewState="true"
         TextMode="MultiLine" Width="800"  >
         Enter Notes</asp:TextBox>
</asp:Content>
