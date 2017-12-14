using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Max
    {
        public void DoMaxDemo()
        {
            List<Employee> EmployeeList = Program.FillList();
            //Getting the maximum salary overall..
            int sum = EmployeeList.Select(e => e.Salary).Max();

            //Getting the maximum salary of SSEs
            sum = EmployeeList.Where(e => e.Designation == "SSE").Select(e => e.Salary).Max();

            //Get the maximum salary of SE using linq
            sum = (from e in EmployeeList where e.Designation == "SE" select e.Salary).Max();
        }
    }
}
