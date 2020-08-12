<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="WebApp3AspEvents.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnUsername" runat="server" Text="Show Username" OnClick="btnUsername_Click" />
            <br />

            <asp:TextBox ID="txtNewUsername" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnChangeUsername" runat="server" Text="Change Username" OnClick="btnChangeUsername_Click" />
        </div>


    </form>
</body>
</html>
