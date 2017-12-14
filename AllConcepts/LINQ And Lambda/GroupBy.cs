using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class GroupBy
    {
        public void TestMaxSalaryInEachDept()
        {
            List<Department> DepartmentList = Program.FillDepartment();
            var v = DepartmentList.GroupBy(e => e.DeptName);
            foreach (var group in v)
            {
                Console.WriteLine(group.Key);
                var empList = group.SelectMany(e => e.EmployeesDeptWise);
                int maxSalary = empList.Select(e => e.Salary).Max();
                string strkey = group.Key;
                var k = from r in empList
                        where r.Salary == maxSalary
                        select new
                            {
                                EmpName = r.Name,
                                Salary = r.Salary,
                                Dept = strkey
                            };

                foreach (var emp in k)
                {
                    Console.WriteLine("Name - {0}, Salary - {1}, Dept - {2}", emp.EmpName, emp.Salary, emp.Dept);
                }
                
               
                //foreach(Department d  in group)
                //{
                //    Console.WriteLine("dept name - " + d.DeptName);
                //   //int maxSalary = d.EmployeesDeptWise.Select(e => e.Salary).Max();

                //   //var k = from r in d.EmployeesDeptWise where r.Salary == maxSalary
                //   //        select new
                //   //        {
                //   //            name = r.Name,
                //   //            salary = r.Salary,
                //   //            Dept =  d.DeptName
                //   //        };

                //   //foreach (var emp in k)
                //   //{
                //   //    Console.WriteLine("Name {0}, Salary- {1}, Dept - {2}", emp.name, emp.salary, emp.Dept);
                //   //}
                //}
                
            }
        }

        public void GetMaleEmployeesSalaryMoreThan20KDeptWise()
        {
            List<Department> DepartmentList = Program.FillDepartment();
            var group = DepartmentList.GroupBy(e => e.DeptName);
            foreach (var v in group)
            {
                var empList = v.SelectMany(e => e.EmployeesDeptWise);
                var vMalesSalaryMoreThan20K = empList.Where(e => e.Sex.ToUpper() == "MALE" && e.Salary > 20000);
                foreach (Employee e in vMalesSalaryMoreThan20K)
                {
                    Console.WriteLine("Name {0}, Sex {1}, Salary {2}, Dept {3}", e.Name, e.Sex, e.Salary, v.Key);
                }
            }
            
        }
        public void TestGroupBy()
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList = Program.FillList();

            Console.WriteLine("Using Lambda first************************");
            //First using Lambda
            var v = EmployeeList.GroupBy(e => e.Designation);
            foreach (var group in v)
            {
                Console.WriteLine("Group - " + group.Key);
                Console.WriteLine("**********************************************");
                foreach (Employee emp in group)
                {
                    Console.WriteLine(emp.Name);
                }
            }

            Console.WriteLine("Using LINQ********************************");

            var vlinq = from emp in EmployeeList group emp by emp.Designation;
            foreach (var group in vlinq)
            {
                Console.WriteLine("Designation " + group.Key);
                Console.WriteLine("***************************************************");
                foreach (Employee emp in group)
                {
                    Console.WriteLine(emp.Name);
                }
            }
         
        }
    }
}
