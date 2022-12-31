<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabManagerUpdate.aspx.cs" Inherits="LMS.AdminUpdate" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Update</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Input form for selecting the Admin to update by ID -->
            <asp:Label ID="lblLabManagerID" runat="server" Text="Enter Admin ID: "></asp:Label>
            <asp:TextBox ID="txtLabManagerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
            <br />
            <br />

            <!-- Form for updating the selected Admin's data -->
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <br />
            <br />
            <!-- Button for deleting the selected Admin -->
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>