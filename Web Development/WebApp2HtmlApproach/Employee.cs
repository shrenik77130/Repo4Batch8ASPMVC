using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2HtmlApproach
{
    public class Employee
    {
        public int empcode;
        public string empname;
        public string location;
        public double salary;

        public Employee()
        {
            this.empcode = -1;
            this.empname = "#UnknownEmpName";
            this.location = "#UnknownEmpLocation";
            this.salary = -1;
        }

        public Employee(int empcode, string empname, string location,double salary)
        {
            this.empcode = empcode;
            this.empname = empname;
            this.location = location;
            this.salary = salary;
        }
    }
}