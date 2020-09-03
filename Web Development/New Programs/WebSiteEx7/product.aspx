<%@ Page Language="C#" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Product Purchase Window</h2>
        <hr />

        <table cellspacing="10" cellpadding="10">
            <tr>
                <td>Product name</td>
                <td>
                    <input type="text" id="txtProdname" value="" runat="server"/>
                </td>
            </tr>

            <tr>
                <td>Price</td>
                <td>
                    <input type="text" id="txtPrice" value="" runat="server"/>
                </td>
            </tr>

            <tr>
                <td>Qtys</td>
                <td>
                    <input type="number" id="txtQtys" value="" runat="server"/>
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <input type="submit" id="btnSubmit" value="Purchase" runat="server" onserverclick="purchase"/>
                </td>
                
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
