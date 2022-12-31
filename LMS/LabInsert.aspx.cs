using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LMS
{
    public partial class LabInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This method is called on page load. You can use it to initialize form elements or perform any other tasks.
        }

       protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the values from the form elements
            int labID = Convert.ToInt32(txtLabID.Text);
            int labManagerID = Convert.ToInt32(txtLabManagerID.Text);
            string labName = txtLabName.Text;
            string labLocation = txtLabLocation.Text;
            string labCategory = txtLabCategory.Text;

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the INSERT command
            string insertSql = "INSERT INTO Lab (LabID, LabManagerID, LabName, LabLocation, LabCategory) VALUES (@labID, @labManagerID, @labName, @labLocation, @labCategory)";
            SqlCommand insertCommand = new SqlCommand(insertSql, connection);
            insertCommand.Parameters.AddWithValue("@labID", labID);
            insertCommand.Parameters.AddWithValue("@labManagerID", labManagerID);
            insertCommand.Parameters.AddWithValue("@labName", labName);
            insertCommand.Parameters.AddWithValue("@labLocation", labLocation);
            insertCommand.Parameters.AddWithValue("@labCategory", labCategory);
            insertCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);

        }
    }
}