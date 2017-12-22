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
    public partial class Table_Of_Contents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet_TOC = new DataSet();
            int i = 0;
            string sql = null;

            connectionString = "Server=tcp:recipeserver.database.windows.net,1433;Database=RecipeHolderNewLocalSol_db;User ID=laserray777@recipeserver;Password='Programmer38';Trusted_Connection=False;Encrypt=True;Connection Timeout=30";
            sql = "SELECT RecipeID, RecipeName, RecipeSource, RecipeContents, RecipeDate FROM dbo.Recipes";

            // create the connection to the database.
            conn = new SqlConnection(connectionString);
            // use a try block to run the code.
            cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                
                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet_TOC);

                // bind the dataSet_TOC to the gridview_TOC.
                gridview_TOC.DataSource = dataSet_TOC;
                gridview_TOC.DataBind();

              
            }
            catch (Exception ex)
            {
                lblTOCOpenConn.Text = String.Format("Failed to open Connection for ROC pasge, Message:  {0}", ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                adapter.Dispose();
                cmd.Dispose(); // was unable to put this in finally block.



            }
        }
    }
}