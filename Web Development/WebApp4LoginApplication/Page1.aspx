<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="WebApp4LoginApplication.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login App</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="col">

            <div class="m-1 p-2 border border-secondary" style="width:400px;">

                <h1>Login Here</h1>
                <% if (invalidStatus == true)
                    { %>
                <div class="alert alert-danger m-1" role="alert">
                    Invalid Username or Password
                </div>
                <% } %>

                <input type="text" name="username" id="txtUsername" placeholder="Username" runat="server" class="form-control  m-1" />
                <input type="password" name="password" id="txtPassword" placeholder="Password" runat="server" class="form-control  m-1" />
                <input type="submit" value="Login" class="btn btn-primary" runat="server" onserverclick="btnLogin_click" />

            </div>
        </div>
    </form>
</body>
</html>
