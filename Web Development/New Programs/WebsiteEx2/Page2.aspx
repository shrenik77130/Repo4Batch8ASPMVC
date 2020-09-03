<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="#" method="POST">
    <div style="margin-left:50px;border:1px solid;padding:10px;">
        <h3>Sign Up</h3>
        <hr />
        <input type="text" placeholder="Name" />
        <br /><br />
        <input type="email" placeholder="Email Id"/>
        <br /><br />
        <input type="text" placeholder="Username" />
        <br /><br />
        <input type="password" placeholder="Password" />
        <br /><br />
        <input type="submit" value="Sign Up" runat="server"/>
    </div>
    </form>
</body>
</html>
