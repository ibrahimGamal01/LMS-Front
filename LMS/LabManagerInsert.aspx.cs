using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LMS
{
    public partial class AdminForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to load data from the Admin table goes here
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the values from the form elements
            int LabManagerID = Convert.ToInt32(txtAdminID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the INSERT command
            string insertSql = "INSERT INTO LabManager (LabManagerID, FirstName, LastName, Email, Password) VALUES (@LabManagerID, @firstName, @lastName, @email, @password)";
            SqlCommand insertCommand = new SqlCommand(insertSql, connection);
            insertCommand.Parameters.AddWithValue("@LabManagerID", LabManagerID);
            insertCommand.Parameters.AddWithValue("@firstName", firstName);
            insertCommand.Parameters.AddWithValue("@lastName", lastName);
            insertCommand.Parameters.AddWithValue("@email", email);
            insertCommand.Parameters.AddWithValue("@password", password);
            insertCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text="";
            txtPassword.Text="";
            txtAdminID.Text = "";

        }
    }
}
