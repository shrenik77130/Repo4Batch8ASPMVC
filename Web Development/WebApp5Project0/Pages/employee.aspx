<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="WebApp5Project0.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-sm">
            <h1 class="m-1 text-primary">Employee Create</h1>

            <div class="row">
                <div class="col-md-4">
                    <% if (saveStatus == true)
                        {%>
                    <div class="row m-1">
                        <div class="col-md-12">

                            <div class="alert alert-success" role="alert">
                                Employee Save Successfull
                            </div>

                        </div>
                    </div>
                    <%}
                        else if (saveFailedStatus == true)
                        {%>
                    <div class="row m-1">
                        <div class="col-md-12">

                            <div class="alert alert-danger" role="alert">
                                Faild to save Employee Record
                            </div>

                        </div>
                    </div>
                    <%} %>

                    <div class="row m-1">
                        <div class="col-md-12">
                            <input type="text" placeholder="Employee Id" id="txtEmpId" class="form-control" runat="server" required="required" />
                        </div>
                    </div>

                    <div class="row m-1">
                        <div class="col-md-12">
                            <input type="text" placeholder="Employee Name" id="txtEmpName" class="form-control" runat="server" required="required" />
                        </div>
                    </div>

                    <div class="row m-1">
                        <div class="col-md-12">
                            <input type="text" placeholder="Salary" id="txtSalary" class="form-control" runat="server" required="required" />
                        </div>
                    </div>

                    <div class="row m-1">
                        <div class="col-md-12">
                            <input type="text" placeholder="Department" id="txtDepartment" class="form-control" runat="server" required="required" />
                        </div>
                    </div>

                    <div class="row m-1">
                        <div class="col-md-12">
                            <input type="submit" value="Save" id="btnSaveEmployee" class="btn btn-primary" runat="server" onserverclick="btnSaveEmployee_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-md-8">
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>Emp Code</th>
                                <th>Emp Name</th>
                                <th>Department</th>
                                <th>Salary</th>
                            </tr>
                        </thead>

                        <tbody>
                            <% LinkedList<Entity.Employee> empTable = employeeService.ListEmployee(); %>
                            <% for (int i = 0; i < empTable.Count; i++) {
                                    Entity.Employee emp = (Entity.Employee)empTable.ElementAt(i);
                                    %>
                            <tr>
                                <td><%= emp.empcode %></td>
                                <td><%= emp.empname %></td>
                                <td><%= emp.deptname %></td>
                                <td><%= emp.salary %></td>
                            </tr>
                            <%} %>
                        </tbody>
                    </table>
                </div>

            </div>
        </div>

    </form>
</body>
</html>
