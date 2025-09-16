<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="DepartmentWeb.Department" %>

<!DOCTYPE html>
<head runat="server">
    <title>Department Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Department</h2>
            <asp:TextBox ID="txtDeptName" runat="server" Placeholder="Department Name"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtDeptID" runat="server" Placeholder="Department ID"></asp:TextBox><br /><br />

            <asp:TextBox ID="txtLocation" runat="server" Placeholder="Location"></asp:TextBox><br /><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add Department" OnClick="btnAdd_Click" /><br /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>

            <h2>All Departments</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" Visible="false"></asp:GridView>
        </div>
    </form>
</body>
</html>
