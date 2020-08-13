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

        protected void Page_Load(object sender, EventArgs e)
        {

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

                EmployeeService employeeService = new EmployeeService();

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