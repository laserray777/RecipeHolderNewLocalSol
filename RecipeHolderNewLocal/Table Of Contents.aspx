<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Table Of Contents.aspx.cs" Inherits="RecipeHolderNewLocal.Table_Of_Contents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to the Table Of Contents page!</h2>
    <asp:GridView ID="gridview_TOC" runat="server" 
        Caption="Table Of Contents"></asp:GridView>
    <asp:Label ID="lblTOCOpenMessage" runat="server" Text="Did TOC page Open connection: "></asp:Label><asp:Label ID="lblTOCOpenConn" runat="server" Text="Label"></asp:Label>
</asp:Content>
