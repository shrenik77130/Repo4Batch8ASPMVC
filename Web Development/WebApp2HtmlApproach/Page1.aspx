<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="WebApp2HtmlApproach.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page1 | Emp Form Submit</title>
</head>
<body>

    <h3>HTML Form convert to ASP Form adding runat="server"</h3>

    <form action="#" method="post" >
        
        <input type="text" id="txtEmpCode" placeholder="Emp Code" runat="server"/>
        <input type="text" id="txtEmpName" placeholder="Emp Name" runat="server"/>
        <input type="text" id="txtLocation" placeholder="Location" runat="server"/>
        <input type="text" id="ttxSalary" placeholder="Salary" runat="server"/>

        <input type="submit" value="Create Record" runat="server" onserverclick="btnSubmit_click"/>
    </form>

    <br />
    <br />

    <h3> Asp Form</h3>

    <form action="#" method="post" runat="server">
        <asp:TextBox ID="aspTxtEmpCode" runat="server" ToolTip="Enter Numeric Emp Code"></asp:TextBox>
        <asp:TextBox ID="aspTxtEmpName" runat="server"></asp:TextBox>
        <asp:TextBox ID="aspTxtLocation" runat="server"></asp:TextBox>
        <asp:TextBox ID="aspTxtSalary" runat="server"></asp:TextBox>

        <asp:Button ID="aspBtnSubmit" runat="server" Text="Create Employee" OnClick="aspBtnSubmit_Click" />

    </form>

</body>
</html>
