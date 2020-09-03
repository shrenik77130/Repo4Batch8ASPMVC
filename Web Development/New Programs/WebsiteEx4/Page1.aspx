<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:10px;padding:10px;width:40%;border:1px solid;">
            <h3 style="color:white;background-color:red;margin:5px;padding:5px;">
                Please Login
            </h3>     

            <div style="margin:5px;padding:5px;">
                <asp:TextBox ID="username" runat="server"></asp:TextBox>
            </div>
       
            <div style="margin:5px;padding:5px;">
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            </div>    

             <div style="margin:5px;padding:5px;">
                <asp:Button ID="buttonLogin" Text="Login" runat="server" OnClick="buttonLogin_Click"></asp:Button>
            </div>
            
         </div>
    </form>
</body>
</html>
