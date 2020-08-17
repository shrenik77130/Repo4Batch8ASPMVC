<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="WebApp6DatabaseConnection.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Exception on Asp Page</h1>
            <hr />
            <p><%= errormsg %></p>
        </div>
    </form>
</body>
</html>
