using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp5Project0
{
    public partial class employee : System.Web.UI.Page
    {
        protected bool saveStatus = false;
        protected bool saveFailedStatus = false;
        protected EmployeeService employeeService;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                employeeService = new EmployeeService();
                ViewState["employeeService"] = employeeService;
            }
            else
            {
                employeeService = (EmployeeService)ViewState["employeeService"];
            }
        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee(
                    int.Parse(txtEmpId.Value),
                    txtEmpName.Value,
                    double.Parse(txtSalary.Value),
                    txtDepartment.Value);


                if (employeeService.SaveEmployee(employee) != null)
                    saveStatus = true;
                else
                    saveFailedStatus = true;
            }
            catch(Exception ex)
            {
                Session["error"] = ex;
                Response.Redirect("error.aspx");
            }

            

        }
    }
}