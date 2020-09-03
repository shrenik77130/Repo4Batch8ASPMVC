<%@ Page Language="C#" AutoEventWireup="true" CodeFile="server.aspx.cs" Inherits="server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Welcome Server</h2>
        <asp:Label ID="LclientName" runat="server">[]</asp:Label>
        <br />
        <asp:Button ID="btnResponseClient" runat="server" Text="Respond Client" OnClick="btnResponseClient_Click" />
    </div>
    </form>
</body>
</html>
