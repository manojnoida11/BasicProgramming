using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    //Orderby clause is used to sort the colleciton.
    //Then by is used if you wnat multiple sorting. it is used after order by clause.

    public class OrderByAndThenBy
    {
        private List<Employee> EmployeeList = new List<Employee>();

        public void TestOrderBy()
        {
            Console.WriteLine("1 - Order by");
            Console.WriteLine("2 - Order by descending");
            Console.WriteLine("3 - Then By");
            string str = Console.ReadLine();
            this.EmployeeList = Program.FillList();
            //First using Lambda
            Console.WriteLine("**************Order by****************************");
            
                var v = this.EmployeeList.OrderBy((e) => e.Name);
                Console.WriteLine("********* Order by using Lambda*********************");
                foreach (Employee emp in v)
                {
                    Console.WriteLine(emp.Name);
                }

                Console.WriteLine("********* Order by using Linq*********************");
                var vlinq = from e in EmployeeList orderby e.Name select e;
                foreach (Employee emp in vlinq)
                {
                    Console.WriteLine(emp.Name);
                }
            

            Console.WriteLine("**************Order by Descending****************************");
                v = this.EmployeeList.OrderByDescending(e => e.Name);
                foreach (Employee e in v)
                {
                    Console.WriteLine(e.Name);
                }

                vlinq = from e in EmployeeList orderby e.Name descending select e;
                foreach (Employee e in vlinq)
                {
                    Console.WriteLine(e.Name);
                }

            

            Console.WriteLine("**************Order and then by****************************");
                v = this.EmployeeList.OrderBy(e => e.Name).ThenBy(e => e.Sex);
                foreach (Employee e in v)
                {
                    Console.WriteLine(e.Name);
                }
            
        }
    }
}
