using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Department
    {
        public string DeptName
        {
            get;
            set;
        }

        private List<Employee> _employeedeptwise = new List<Employee>();
        public List<Employee> EmployeesDeptWise
        {
            get { return _employeedeptwise; }
            set { _employeedeptwise = value; }
        }
    }
}
