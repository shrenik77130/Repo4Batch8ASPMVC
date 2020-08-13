<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="WebApp5Project0.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <% if (saveStatus == true)
            {%>
        <div class="row m-1">
            <div class="col-md-4">

                <div class="alert alert-success" role="alert">
                    Employee Save Successfull
                </div>

            </div>
        </div>
        <%}
            else if(saveFailedStatus==true)
            {%>
        <div class="row m-1">
            <div class="col-md-4">

                <div class="alert alert-danger" role="alert">
                    Faild to save Employee Record
                </div>

            </div>
        </div>
        <%} %>

        <div class="row m-1">
            <div class="col-md-4">
                <input type="text" placeholder="Employee Id" id="txtEmpId" class="form-control" runat="server" />
            </div>
        </div>

        <div class="row m-1">
            <div class="col-md-4">
                <input type="text" placeholder="Employee Name" id="txtEmpName" class="form-control" runat="server" />
            </div>
        </div>

        <div class="row m-1">
            <div class="col-md-4">
                <input type="text" placeholder="Salary" id="txtSalary" class="form-control" runat="server" />
            </div>
        </div>

        <div class="row m-1">
            <div class="col-md-4">
                <input type="text" placeholder="Department" id="txtDepartment" class="form-control" runat="server" />
            </div>
        </div>

        <div class="row m-1">
            <div class="col-md-4">
                <input type="submit" value="Save" id="btnSaveEmployee" class="btn btn-primary" runat="server" onserverclick="btnSaveEmployee_Click" />
            </div>
        </div>
    </form>
</body>
</html>
