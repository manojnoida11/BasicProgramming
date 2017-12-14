using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Count
    {
        public void TestCountDemo()
        {
            List<Employee> EmployeeList = Program.FillList();
            

            int iSSECount = EmployeeList.Count(e => e.Designation == "SSE");
            int iTotalCount = EmployeeList.Count;

            int iSECount = (from r in EmployeeList where r.Designation == "SE" select r).Count();

            
           
        }
    }
}
