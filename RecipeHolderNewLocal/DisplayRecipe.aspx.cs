using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecipeHolderNewLocal
{
	public partial class DisplayRecipe : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            tmplbl.Text = Session["Recipe1"].ToString();
		}

        // btn_DisplayNote_Click() displays the content of
        // Session["Recipe1"] in the DisplayRecipe.aspx page.
        protected void btn_DisplayNote_Click(object sender, EventArgs e)
        {
            txtB_DisplaySessionContent.Text =
                Session["Recipe1"].ToString();
        }
    }
}