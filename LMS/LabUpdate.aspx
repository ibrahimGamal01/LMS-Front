<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabUpdate.aspx.cs" Inherits="LMS.LabUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Lab</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Input form for selecting the Lab to update by ID -->
            <label for="txtLabID">Lab ID:</label>
            <asp:TextBox ID="txtLabID" runat="server"></asp:TextBox>
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
            <br />
            <br />

            <!-- Form for updating the selected Lab's data -->
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
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <br />
            <br />

            <!-- Button for deleting the selected Lab -->
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>            
        </div>
    </form>
</body>
</html>
