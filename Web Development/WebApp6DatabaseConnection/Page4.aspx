<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page4.aspx.cs" Inherits="WebApp6DatabaseConnection.Page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="deptid" DataSourceID="restaurentDataSource">
                <Columns>
                    <asp:BoundField DataField="deptid" HeaderText="deptid" ReadOnly="True" SortExpression="deptid" />
                    <asp:BoundField DataField="deptname" HeaderText="deptname" SortExpression="deptname" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="restaurentDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
