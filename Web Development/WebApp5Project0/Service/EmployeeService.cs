using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using WebApp5Project0;

namespace Service
{
   [Serializable]
    public class EmployeeService
    {
        public Employee SaveEmployee(Employee employee)
        {
            try
            {
                DbHelper.employeeList.AddLast(employee);
                return employee;
            }
            catch (Exception ex)
            {
             //   System.Web.UI.Page.Session["error"] = ex.ToString();
                HttpContext.Current.Response.Redirect("~/error.aspx");
            }

            return null;
        }

        public Employee UpdateEmployee(Employee employee,int id)
        {
            return null;
        }

        public void DeleteEmployee(int id)
        {

        }

        public Employee FindEmployeeById(int id)
        {
            return null;
        }

        public LinkedList<Employee> ListEmployee()
        {
            return DbHelper.employeeList;
        }
    }
}