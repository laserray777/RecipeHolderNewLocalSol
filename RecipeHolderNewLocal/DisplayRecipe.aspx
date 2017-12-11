<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayRecipe.aspx.cs" Inherits="RecipeHolderNewLocal.DisplayRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to DisplayRecipe.aspx</h2>

     <header> 
    <asp:Button ID="btn_DisplayNote" runat="server" Text="Display Note" OnClick="btn_DisplayNote_Click"  Width="100"  /><br /><br />
    <style>
        .CenterLine1 { color: green;
                       text-align: center;
                       margin: 100px,0,0,0;
                     }
    </style>
    </header>
    <asp:Table ID="Table1" runat="server" BorderColor="Yellow"
        Height="200px" Width="1200px"  BorderWidth="5">
        <asp:TableRow ID="tblRow0" runat="server"  
             Height="50px" Width="800px" ForeColor="Violet" >
            <asp:TableCell Height="10" Width="600" Text="I am in cell1"
                 BorderColor="DeepPink" BorderWidth="5"
                 ID="cell1">
            TextBox to display the entered note after it has been
            saved in Session["Recipe1"].
    <asp:TextBox ID="txtB_DisplaySessionContent" runat="server"
      TextMode="MultiLine" Height="400" Width="800" 
         BackColor="Violet"  ></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell Height="10" Width="400" Text="I am another cell!"
                 BorderColor="Blue" BorderWidth="5"
                 ID="cell2" HorizontalAlign="Center">
                <br />
                <div style="text-align:center;">
                 <asp:Label ID="Label1" runat="server" Text="Label" >Recipe or Note Name:</asp:Label> 
                 <br />
                 <asp:TextBox ID="TextBox1" runat="server" Width="200">Enter Name</asp:TextBox>
                </div>
                <br />
                <div style="text-align:center;">
                 <asp:Button ID="btnSaveNote" runat="server" Text="Save Note"  
                       OnClick="btnSaveNote_Click" Width="150" />
                </div>
         
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <%--
     TextBox to display the entered note after it has been
     saved in Session["Recipe1"].
    <asp:TextBox ID="txtB_DisplaySessionContent" runat="server"
      TextMode="MultiLine" Height="400" Width="750" 
         BackColor="Violet"  ></asp:TextBox>
    --%>

    <%-- Set up field elements for the end-user to give the note a name. 
     <asp:Label ID="lblRecipeNamePrompt" runat="server" Text="Label" >Recipe or Note Name:</asp:Label>
     <asp:TextBox ID="txtB_RecipeName" runat="server" Width="200">Enter Name</asp:TextBox>
    
           <asp:Button ID="btnSaveNote" runat="server" Text="Save Note"  
           OnClick="btnSaveNote_Click" Width="150"/>
    --%>     
</asp:Content>
