using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Department
    {
        public int deptid;
        public string deptname;

        public Department() { }

        public Department(int deptid, string deptname)
        {
            this.deptid = deptid;
            this.deptname = deptname;
        }
    }
}