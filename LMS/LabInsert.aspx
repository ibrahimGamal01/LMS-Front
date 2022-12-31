<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabInsert.aspx.cs" Inherits="LMS.LabInsert" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Lab</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Display form elements for inserting data into the Lab table -->
            <label for="txtLabID">Lab ID:</label>
            <asp:TextBox ID="txtLabID" runat="server"></asp:TextBox>
            <br />
            <label for="txtLabName">Lab Name:</label>
            <asp:TextBox ID="txtLabName" runat="server"></asp:TextBox>
            <br />
            <label for="txtLabLocation">Lab Location:</label>
            <asp:TextBox ID="txtLabLocation" runat="server"></asp:TextBox>
            <br />
            <label for="txtLabCategory">Lab Category:</label>
            <asp:TextBox ID="txtLabCategory" runat="server"></asp:TextBox>
            <br />
            <label for="txtLabManagerID">Lab Manager ID:</label>
            <asp:TextBox ID="txtLabManagerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <!-- Button for inserting the data into the Lab table -->
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>