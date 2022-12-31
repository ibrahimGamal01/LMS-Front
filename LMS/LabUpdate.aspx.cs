using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LMS
{
    public partial class LabUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            // Get the LabID from the form
            int labID = Convert.ToInt32(txtLabID.Text);

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the SELECT command
            string selectSql = "SELECT * FROM Lab WHERE LabID = @labID";
            SqlCommand selectCommand = new SqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@labID", labID);
            SqlDataReader reader = selectCommand.ExecuteReader();

            // If a row is returned, fill the form with the Lab's data
            if (reader.Read())
            {
                txtLabName.Text = reader["LabName"].ToString();
                txtLabLocation.Text = reader["LabLocation"].ToString();
                txtLabCategory.Text = reader["LabCategory"].ToString();
                txtLabManagerID.Text = reader["LabManagerID"].ToString();
            }
            else
            {
                // If no rows are returned, display an error message
                lblError.Text = "Error: No Lab found with the given ID.";
            }

            // Close the connection
            connection.Close();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
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

            // Create and execute the UPDATE command
            string updateSql = "UPDATE Lab SET LabName = @labName, LabLocation = @labLocation, LabCategory = @labCategory, LabManagerID = @labManagerID WHERE LabID = @labID";
            SqlCommand updateCommand = new SqlCommand(updateSql, connection);
            updateCommand.Parameters.AddWithValue("@labName", labName);
            updateCommand.Parameters.AddWithValue("@labLocation", labLocation);
            updateCommand.Parameters.AddWithValue("@labCategory", labCategory);
            updateCommand.Parameters.AddWithValue("@labManagerID", labManagerID);
            updateCommand.Parameters.AddWithValue("@labID", labID);
            updateCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the LabID of the row to delete
            int labID = Convert.ToInt32(txtLabID.Text);

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the DELETE command
            string deleteSql = "DELETE FROM Lab WHERE LabID = @labID";
            SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);
            deleteCommand.Parameters.AddWithValue("@labID", labID);
            deleteCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}