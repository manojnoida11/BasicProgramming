using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class ShallowCopy
    {
        public static string CompanyName = "My Company";
        public int Age;
        public string EmployeeName;
        public clsRefSalaryShallow EmpSalary;

        public ShallowCopy CreateShallowCopy(ShallowCopy inputcls)
        {
            return (ShallowCopy)inputcls.MemberwiseClone();
        }

        public void TestShallowCopy()
        {
            ShallowCopy obShallow = new ShallowCopy();
            obShallow.Age = 25;
            obShallow.EmployeeName = "Manoj Kumar";

            clsRefSalaryShallow clsRef = new clsRefSalaryShallow(1000);
            obShallow.EmpSalary = clsRef;

            //Perform a shallow copy and assign to m2
            ShallowCopy m2 = obShallow.CreateShallowCopy(obShallow);

            //Modify the clsref salary to 2000;
            clsRef.Salary = 2000;

            //so the m1 salary object becomes 2000;
            int EmpSalary = obShallow.EmpSalary.Salary;
            int iShallowCopySalary = m2.EmpSalary.Salary;
        }
    }

    public class clsRefSalaryShallow
    {
        public int Salary;
        public clsRefSalaryShallow(int _salary)
        {
            Salary = _salary;

        }
    }
}
