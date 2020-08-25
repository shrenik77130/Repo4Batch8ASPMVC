<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="WebApp6DatabaseConnection.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDeptId" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtDeptName" runat="server"></asp:TextBox>
            <asp:Button ID="btnInsertQuery" runat="server" Text="Insert using Query" OnClick="btnInsertQuery_Click" />
            <asp:Button ID="btnUsingParameters" runat="server" Text="Insert using Parameters" OnClick="btnUsingParameters_Click" />
            <asp:Button ID="btnUsingStoredProcedure" runat="server" Text="Insert using Stored Procedure" OnClick="btnUsingStoredProcedure_Click" />
        </div>
    </form>
</body>
</html>
