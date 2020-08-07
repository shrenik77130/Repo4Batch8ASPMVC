<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="WebApp2HtmlApproach.Page2"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                for(int i=1;i<=100;i++)
                {
                    %>
                        <p><%= i %></p>
                    <%
                }
            %>
        </div>


        <div>
            <%
                WebApp2HtmlApproach.Employee e1 = new WebApp2HtmlApproach.Employee(101,"Pravin","Bangalore",18000.00);

            %>

            <h4>Emp Code = <%= e1.empcode %></h4>
            <h4>Emp Name = <%= e1.empname %></h4>
            <h4>Emp Salary = <%= e1.salary %></h4>
            <h4>Emp Location = <%= e1.location %></h4>

        </div>
    </form>
</body>
</html>
