<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="WebApp6DatabaseConnection.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnShowDepartments" runat="server" Text="Show Departments" OnClick="btnShowDepartments_Click" />

            <table>
                <thead>
                    <tr>
                        <th>Dept Id</th>
                        <th>Dept Name</th>
                        <th>#</th>
                    </tr>
                </thead>

                <tbody>
                    <% if (deptList != null)
                        {
                            for (int i = 0; i < deptList.Count; i++)
                            {
                                Entity.Department d = (Entity.Department)deptList.ElementAt(i);

                    %>

                    <tr>
                        <td><%= d.deptid %></td>
                        <td><%= d.deptname %></td>
                        <td><a href="#">Edit</a></td>
                    </tr>

                    <%}
                    }%>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>

<!--
CREATE VIEW viewDepartment AS
SELECT D.deptid,D.deptname FROM Department D;

-->