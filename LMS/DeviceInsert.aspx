<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceInsert.aspx.cs" Inherits="LMS.DeviceInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Device</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Form for inserting a new Device -->
            <label for="txtDeviceID">Device ID:</label>
            <asp:TextBox ID="txtDeviceID" runat="server"></asp:TextBox>
            <br />
            <label for="txtDeviceName">Device Name:</label>
            <asp:TextBox ID="txtDeviceName" runat="server"></asp:TextBox>
            <br />
            <label for="txtDeviceType">Device Type:</label>
            <asp:TextBox ID="txtDeviceType" runat="server"></asp:TextBox>
            <br />
            <label for="fileDeviceImage">Device Image:</label>
            <asp:FileUpload ID="fileDeviceImage" runat="server" />
            <br />
            <label for="txtLabID">Lab ID:</label>
            <asp:TextBox ID="txtLabID" runat="server"></asp:TextBox>
            <br />
            <br />
            <!-- Button for inserting the new Device -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
