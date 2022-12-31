using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace LMS
{
    public partial class AdminUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            // Get the selected Admin ID from the form
            int LabManagerID = Convert.ToInt32(txtLabManagerID.Text);

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the SELECT command
            string selectSql = "SELECT * FROM LabManager WHERE LabManagerID = @LabManagerID";
            SqlCommand selectCommand = new SqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@LabManagerID", LabManagerID);
            SqlDataReader reader = selectCommand.ExecuteReader();

            // Check if a record was found
            if (reader.Read())
            {
                // Populate the form elements with the selected Admin's data
                txtFirstName.Text = reader["FirstName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtPassword.Text = reader["Password"].ToString();
            }
            else
            {
                // Display an error message if the Admin was not found
                lblError.Text = "Admin not found";
            }

            // Close the connection
            connection.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the updated Admin data from the form
            int LabManagerID = Convert.ToInt32(txtLabManagerID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the UPDATE command
            string updateSql = "UPDATE LabManager SET FirstName = @firstName, LastName = @lastName, Email = @email, Password = @password WHERE LabManagerID = @LabManagerID";
            SqlCommand updateCommand = new SqlCommand(updateSql, connection);
            updateCommand.Parameters.AddWithValue("@firstName", firstName);
            updateCommand.Parameters.AddWithValue("@lastName", lastName);
            updateCommand.Parameters.AddWithValue("@email", email);
            updateCommand.Parameters.AddWithValue("@password", password);
            updateCommand.Parameters.AddWithValue("@LabManagerID", LabManagerID);
            updateCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the ID of the Admin to delete
            int LabManagerID = Convert.ToInt32(txtLabManagerID.Text);
            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the DELETE command
            string deleteSql = "DELETE FROM LabManager WHERE LabManagerID = @LabManagerID";
            SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);
            deleteCommand.Parameters.AddWithValue("@LabManagerID", LabManagerID);
            deleteCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}



