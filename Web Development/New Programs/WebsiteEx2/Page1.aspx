<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input type="button" value="Html Button" runat="server"/>
        <asp:Button ID="Button1" runat="server" Text="Asp Button" />
        
        <style>
            input[type="button"] {
                font-family:Consolas;
                color:red;
                margin:20px;
            }
        </style>
    </form>
</body>
</html>
