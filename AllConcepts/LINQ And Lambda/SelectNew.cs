using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class SelectNew
    {
        public void TestSelectNewDemo()
        {
            List<Employee> EmployeeList = Program.FillList();

            //Add mr. prefix for male and ms. for female candidates
            var v = from r in EmployeeList where r.Sex == "Female"
                    select  new
                        {
                            EmployeeName = r.Name
                        };

            foreach (var emp in v)
            {
                Console.WriteLine(emp.EmployeeName);
            }


            ////Add mr. prefix for male and ms. for female candidates
            

            //foreach (var emp in v)
            //{
            //    Console.WriteLine(emp.EmployeeName);
            //}
        }
    }
}
