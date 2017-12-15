using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RecipeHolderNewLocal
{
	public partial class DisplayRecipe : System.Web.UI.Page
	{
        Int32 insertedRecipeID;
		protected void Page_Load(object sender, EventArgs e)
		{

            
		}

        // btn_DisplayNote_Click() displays the content of
        // Session["Recipe1"] in the DisplayRecipe.aspx page.
        protected void btn_DisplayNote_Click(object sender, EventArgs e)
        {
            txtB_DisplaySessionContent.Text =
                Session["Recipe1"].ToString();
        }

        protected void btnSaveNote_Click(object sender, EventArgs e)
        {
            // Get a name for the recipe from the end user.
            var recipeName = txtB_RecipeName.Text;

            // I am now going to attempt to build a recipe.Entity (a database row)
            // in code and store that entity in the azure sql
            // database - RecipeHolderNewLocalSol_db. see Documentation.txt.
            var connectionstring =
            "Server=tcp:recipeserver.database.windows.net,1433;" +
            "Database = RecipeHolderNewLocalSol_db;" +
            "User ID=laserray777@recipeserver;" +
            "Password='Programmer38';Trusted_Connection=False;Encrypt=True;" +
            "Connection Timeout=30";
                        
             using (SqlConnection conn = new SqlConnection(
                       connectionstring))
             {
                // Set up commasnd object to use to execute
                // stored procedure - sp_InsertRecipe,
                SqlCommand SPCmd = new SqlCommand("sp_InsertRecipe", conn);
                SPCmd.CommandType = CommandType.StoredProcedure;
                // SqlParameter for the RecipeName column.
                SqlParameter paramname = new SqlParameter();
                paramname = SPCmd.Parameters.Add("@RecipeName", SqlDbType.NVarChar, 50);
                paramname.Direction = ParameterDirection.Input;
                SqlParameter paramsource = new SqlParameter();
                paramsource = SPCmd.Parameters.Add("@RecipeSource", SqlDbType.NVarChar, 50);
                paramsource.Direction = ParameterDirection.Input;
                SqlParameter paramcontents = new SqlParameter();
                paramcontents = SPCmd.Parameters.Add("@RecipeContents", SqlDbType.NVarChar, -1);
                paramcontents.Direction = ParameterDirection.Input;
                SqlParameter paramdate = new SqlParameter();
                paramdate = SPCmd.Parameters.Add("@RecipeDate", SqlDbType.DateTime);
                paramdate.Direction = ParameterDirection.Input;
                paramname.Value = recipeName;
                paramsource.Value = ((Context.User.Identity.Name.ToString()) != "") ? Context.User.Identity.Name.ToString() : "Anonymous";
                paramcontents.Value = Session["Recipe1"].ToString();
                paramdate.Value = DateTime.Now.ToString();
                try
                {
                    conn.Open();
                    insertedRecipeID = (int)SPCmd.ExecuteScalar();
                    lblSuccessWrite.Text = String.Format("recipe {0} was written to the database, with RecipeID of: {1}", recipeName, insertedRecipeID);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("conn failed to open: {0}", ex.Message);
                    lblOpenError.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();   
                }
             }              
            
        }
    }
}