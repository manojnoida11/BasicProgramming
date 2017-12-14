using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Where
    {
       
        public void TestWhere()
        {
            List<Employee> EmployeeList = Program.FillList();
            
            //Using Lambda.
            var v = EmployeeList.Where(e => (e.Designation == "SSE" && e.Sex == "Male"));
            foreach (Employee emp in v)
            {
                Console.WriteLine(emp.Name);
            }


            //Call Linq Mehtod
            UsingLinq();

        }

        public void UsingLinq()
        {
            List<Employee> EmployeeList = Program.FillList();

            var v = from e in EmployeeList
                    where e.Designation == "SSE" && e.Sex == "Male"
                    select e;

            foreach (Employee emp in v)
            {
                Console.WriteLine(emp.Name);
            }

        }
    }
}
