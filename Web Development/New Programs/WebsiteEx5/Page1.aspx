<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="#" method="POST" runat="server">
        <br />
        <input type="text" id="txtMessage" runat="server" />
        <input type="submit" value="Count" runat="server" onserverclick="countPostBack"/>
        <br />
    </form>

</body>
</html>
