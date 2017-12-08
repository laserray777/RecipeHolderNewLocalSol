<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayRecipe.aspx.cs" Inherits="RecipeHolderNewLocal.DisplayRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to DisplayRecipe.aspx</h2>
    <asp:Label ID="tmplbl" runat="server" BackColor="Yellow" Text="Temporary Label"></asp:Label>

     <header> 
    <asp:Button ID="btn_DisplayNote" runat="server" Text="Display Note" OnClick="btn_DisplayNote_Click"  Width="100"  /><br /><br />
    <style>
        .CenterLine1 { color: green;
                       text-align: center;
                       margin: 100px,0,0,0;
                     }
    </style>
    </header>
    // TextBox to display the entered note after it has been
    // saved in Session["Recipe1"]
    <asp:TextBox ID="txtB_DisplaySessionContent" runat="server"
      TextMode="MultiLine" Height="400" Width="800" 
         BackColor="Violet"  ></asp:TextBox>

         
</asp:Content>
