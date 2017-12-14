using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Average
    {
        public void DoAverageDemo()
        {
            List<Employee> EmployeeList = Program.FillList();
           
            //Get average salary of SSEs using lambda..
             double Avg = EmployeeList.Where(e => e.Designation == "SSE").Select(e => e.Salary).Average();

            //Get average salary of SEs using linq
             Avg = (from r in EmployeeList where r.Designation == "SE" select r.Salary).Average();
        }
    }
}
