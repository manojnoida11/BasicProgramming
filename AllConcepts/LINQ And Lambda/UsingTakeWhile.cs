using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    
     /*Difference between where and take while - takewhile stops filtering once condition satisfies.
      * Where executes till the end and returns all the data matching the criteria.
      * */
    class UsingTakeWhile
    {
        public void TestTakeWhile()
        {
            List<Employee> EmployeeList = Program.FillList();
            var v = EmployeeList.TakeWhile(e => e.Name == "MANOJ");
            foreach (Employee e in v)
            {
                Console.WriteLine(e.Name);
            }

        }
    }
}
