using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class SelectMany
    {
        //Selectmany is used to flatten the list.
        public void TestSelectMany()
        {
            List<Department> DepartmentList = Program.FillDepartment();
            var v = DepartmentList.Where(d => d.DeptName == "S01").SelectMany(e => e.EmployeesDeptWise);
           
            foreach (Employee e in v)
            {
                Console.WriteLine(e.Name);
            }

            v = DepartmentList.Where(d => d.DeptName == "S01").SelectMany(e => e.EmployeesDeptWise).Where(e => e.Sex == "Female");
        }
    }
}
