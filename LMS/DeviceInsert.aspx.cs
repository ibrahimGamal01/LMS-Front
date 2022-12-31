using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LMS
{
    public partial class DeviceInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the values from the form elements
            int deviceID = Convert.ToInt32(txtDeviceID.Text);
            string deviceName = txtDeviceName.Text;
            string deviceType = txtDeviceType.Text;
            string deviceImagePath = "";
            int labID = Convert.ToInt32(txtLabID.Text);

            // Save the image to the server and get the file path
            if (fileDeviceImage.HasFile)
            {
                // Get the file name and create the save path
                string fileName = System.IO.Path.GetFileName(fileDeviceImage.FileName);
                string serverPath = Server.MapPath("~/DeviceImages/");
                string savePath = serverPath + fileName;

                // Save the file to the server
                fileDeviceImage.SaveAs(savePath);

                // Get the path of the saved file
                deviceImagePath = "~/DeviceImages/" + fileName;
            }

            // Create a connection to the database
            string connectionString = "Data Source=DESKTOP-PF2OANV;Initial Catalog=lab;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create and execute the INSERT command
            string insertSql = "INSERT INTO Device (DeviceID, DeviceName, DeviceType, DeviceImage, LabID) VALUES (@deviceID, @deviceName, @deviceType, @deviceImage, @labID)";
            SqlCommand insertCommand = new SqlCommand(insertSql, connection);
            insertCommand.Parameters.AddWithValue("@deviceID", deviceID);
            insertCommand.Parameters.AddWithValue("@deviceName", deviceName);
            insertCommand.Parameters.AddWithValue("@deviceType", deviceType);
            insertCommand.Parameters.AddWithValue("@deviceImage", deviceImagePath);
            insertCommand.Parameters.AddWithValue("@labID", labID);
            insertCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
        }
    }

}