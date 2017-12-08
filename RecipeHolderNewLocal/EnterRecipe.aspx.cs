using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecipeHolderNewLocal
{
    public partial class EnterRecipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtB_InitialEnterNote_TextChanged(object sender, EventArgs e)
        {
            Session.Add("Recipe1", txtB_InitialEnterNote.Text);
            // redirect to DisplayRecipe.aspx
            Response.Redirect("~/DisplayRecipe.aspx");
        }
    }
}