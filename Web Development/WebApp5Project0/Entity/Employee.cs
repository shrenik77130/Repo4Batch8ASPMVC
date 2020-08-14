using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Employee
    {
        public int empcode { get; private set; }
        public string empname { get; private set; }

        public double salary { get; private set; }

        public string deptname { get; private set; }

        public Employee() { }

        public Employee(int empcode, string empname, double salary, string deptname) 
        {
            this.empcode = empcode;
            this.empname = empname;
            this.salary = salary;
            this.deptname = deptname;
        }

        override
        public string ToString()
        {
            return $"{this.empcode,10} {this.empname,20} {this.salary,10} {this.deptname,20}";
        }

    }
}