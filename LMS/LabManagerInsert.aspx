<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabManagerInsert.aspx.cs" Inherits="LMS.AdminForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Add form elements for the Admin table here -->
            <label>Lab Manager ID:</label>
            <asp:TextBox ID="txtAdminID" runat="server" />
            <br />
            <label>First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server" />
            <br />
            <label>Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server" />
            <br />
            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" />
            <br />
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" />
            <br />
            <!-- Add a button for submitting the form -->
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
