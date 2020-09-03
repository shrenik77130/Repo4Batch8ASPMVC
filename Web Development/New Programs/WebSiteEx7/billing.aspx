<%@ Page Language="C#" AutoEventWireup="true" CodeFile="billing.aspx.cs" Inherits="billing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:20px;padding:10px;border:1px solid;width:50%;">
        <asp:Label ID="LProdname" runat="server">[]</asp:Label>
        <br />
        <asp:Label ID="LPrice" runat="server">[]</asp:Label>
        <br />
        <asp:Label ID="LQtys" runat="server">[]</asp:Label>
        <br />
        <asp:Label>Tax Rate : </asp:Label>
        <asp:Label ID="LTaxrate" Text="5" runat="server">5</asp:Label> <asp:Label>%</asp:Label>
        <br />
        <asp:Label ID="Ltotal" runat="server">[]</asp:Label>
    </div>
    </form>
</body>
</html>
