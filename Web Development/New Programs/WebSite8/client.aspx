<%@ Page Language="C#" AutoEventWireup="true" CodeFile="client.aspx.cs" Inherits="client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Welcome Client</h2>
        <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
        <asp:Button ID="btnRequestData" runat="server" Text="Request Server" OnClick="btnRequestData_Click" />
        
        <br />
        <table cellpadding="10" cellspacing="10" border="1">
            <%
                ClientData R=null;
                if (Session["clientrecords"] != null)
                {
                    R = (ClientData)Session["clientrecords"];

                    Response.Write("Total Clients = " + R.clientid.Length);
               

                    for (int i = 0; i < R.clientid.Length;i++)
                    {
                        %>
                            <tr>
                                <td><%= R.clientid[i] %></td>
                                <td><%= R.cliientname[i] %></td>
                                <td><%= R.emailid[i] %></td>
                            </tr>
                        <%
                    }
                }
            %>
        </table>       
    </div>
    </form>
</body>
</html>
