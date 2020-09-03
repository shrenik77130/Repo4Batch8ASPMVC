<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="text"  id="txtUsername" placeholder="Username" runat="server"/>
        <br />
        <input type="password" id="txtPassword" placeholder="Password" runat="server"/>
        <br />
        <input type="submit" id="btnLogin" value="Login" runat="server" onserverclick="btnLogin_Click"/>
    </div>
    </form>
</body>
</html>
