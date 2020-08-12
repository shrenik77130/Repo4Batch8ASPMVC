<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="WebApp3AspEvents.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGetPerson" runat="server" Text="Get Person" OnClick="btnGetPerson_Click" />


           
            <% if (p1 != null)
                {%>
            <table>
                <tr>
                    <th>Sr.No</th>
                    <th>Person Name</th>
                    <th>Gender</th>
                    <th>Age</th>
                </tr>

                <% for (int i = 0; i < p1.getListOfPerson().Length; i++)
                    { %>
                <tr>
                    <td><%= p1.getListOfPerson()[i].personid %></td>
                    <td><%= p1.getListOfPerson()[i].personname %></td>
                    <td><%= p1.getListOfPerson()[i].gender %></td>
                    <td><%= p1.getListOfPerson()[i].age %></td>
                </tr>
                <%}
                    } %>
            </table>
        </div>
    </form>
</body>
</html>
