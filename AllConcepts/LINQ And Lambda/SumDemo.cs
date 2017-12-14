using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class SumDemo
    {
        public void TestSumDemo()
        {
            //Get the sum of salary paid to SSE's
            List<Employee> EmployeeList = Program.FillList();
            int sum = EmployeeList.Where(e => e.Designation == "SSE").Select(e => e.Salary).Sum();

            //GET The sum of salary paid to SE's using linq
            sum = (from e in EmployeeList where e.Designation == "SE" select e.Salary).Sum();

            //Grouping all the designaiton and calculating sum
            var grp = from e in EmployeeList group e by e.Designation;
            foreach (var v in grp)
            {
                Console.WriteLine("***********************Designation - " + v.Key + "*********************");
                sum = (from e in v select e.Salary).Sum();
                Console.WriteLine("sum using linq" + sum.ToString());

                sum = v.Select(e => e.Salary).Sum();
                Console.WriteLine("Sum using lambda" + sum.ToString());
            }
                 
        }
    }
}
