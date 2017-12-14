using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AllConcepts
{
    class Program
    {



        static void Main(string[] args)
        {
            try
            {
             
                PrintMainMessages();
                string mainchoice = Console.ReadLine();
                PrintSubMessages(mainchoice);
                string subchoice = Console.ReadLine();
                DoOperation(mainchoice, subchoice);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("control in main's exception");
            }
            //string str = Console.ReadLine();
            //while (str != "n")
            //{
            //    TestOperations(str);
            //    Console.WriteLine("-----------------------------------------------------------------------------");
            //    PrintMessages();
            //    str = Console.ReadLine();

            //}
           
        }

     

        static int CalculateArea(int l, int b, out string message, ref string message1 )
        {
            int area = l * b;

            if (area > 100)
            {
                message = "Area too big";
                message1 = "ref area too big";
            }
            else
            {
                message = "Area is small";
                message1 = "ref Area is small";
            }
            return area;
        }

        static void DoOperation(string mainchoice, string subchoice)
        {
            if (mainchoice == "1")
            {
                MultithreadingConcepts(subchoice);
            }

            if (mainchoice == "2")
            {
                DesignPatternConcepts(subchoice);
            }

            if (mainchoice == "3")
            {
                LinqAndLambdaConcepts(subchoice);
            }

            if (mainchoice == "4")
            {
                DelegatesAndEventConcepts(subchoice);
            }

            if (mainchoice == "5")
            {
                OOPSConcepts(subchoice);
            }

            if (mainchoice == "6")
            {
                TPLConcepts(subchoice);
            }
        }

        static void PrintMainMessages()
        {
            Console.WriteLine("1- Multithreading Concepts");
            Console.WriteLine("2 - Design Pattern Concepts");
            Console.WriteLine("3 - LINQ and Lambda Concepts");
            Console.WriteLine("4 - Delegates and Events Concepts");
            Console.WriteLine("5 - OOPS Concepts");
            Console.WriteLine("6 - TPL Concepts");
        }

        static void PrintSubMessages(string iChoice)
        {
            if (iChoice == "1")
            {
                Console.WriteLine("1. Multithreading - Auto Reset Event Demo");
                Console.WriteLine("2. Multithreading - Manual Reset Event Demo");
                Console.WriteLine("3. Multithreading - Monitor Wait Pulse Demo");
                Console.WriteLine("4. Multithreading - Thread.Join Demo");
            }

            if (iChoice == "2")
            {
                Console.WriteLine("1. Design Pattern - Abstract Factory Pattern");
                Console.WriteLine("2. Design Pattern - Builder Pattern");
                Console.WriteLine("3. Design Pattern - Chain Of Responsibility Pattern");
                Console.WriteLine("4. Design Pattern - Command Pattern");
                Console.WriteLine("5. Design Pattern - Observer Pattern");
                Console.WriteLine("6. Design Pattern - State Pattern");
                Console.WriteLine("7. Design Pattern - Factory Pattern");
            }

            if (iChoice == "3")
            {
                Console.WriteLine("1. LINQ and Lambda - Anonymous Methods");
                Console.WriteLine("2. LINQ and Lambda - Average Demo");
                Console.WriteLine("3. LINQ and Lambda - Count Demo");
                Console.WriteLine("4. LINQ and Lambda - Group By Demo");
                Console.WriteLine("5. LINQ and Lambda - Join Demo");
                Console.WriteLine("6. LINQ and Lambda - Lambda expression Demo");
                Console.WriteLine("7. LINQ and Lambda - Max Demo");
                Console.WriteLine("8. LINQ and Lambda - Order by and Then By Demo");
                Console.WriteLine("9. LINQ and Lambda - Select Many Demo");
                Console.WriteLine("10. LINQ and Lambda - Select New Demo");
                Console.WriteLine("11. LINQ and Lambda - skip while Demo");
                Console.WriteLine("12. LINQ and Lambda - Sum Demo");
                Console.WriteLine("13. LINQ and Lambda - Test Linq Demo");
                Console.WriteLine("14. LINQ and Lambda - Take While Demo");
                Console.WriteLine("15. LINQ and Lambda - Where Demo");
                Console.WriteLine("16. LINQ and Lambda - Action Delegate Demo");
                Console.WriteLine("17. LINQ and Lambda - Function Delegate Demo");
            }

            if (iChoice == "4")
            {
                Console.WriteLine("1. Delegates and Events - Async calls using delegates");
                Console.WriteLine("2. Delegates and Events - Event creation using delegates");
                Console.WriteLine("3. Delegates and Events - Event creation using Event Handler");
               
            }

            if (iChoice == "5")
            {
                Console.WriteLine("1. OOPS - Dispose and Finalize");
                Console.WriteLine("2. OOPS - Equals and ReferenceEquals Methods");
                Console.WriteLine("3. OOPS - Explicit Interface Implementation");
                Console.WriteLine("4. OOPS - Reflection");
                Console.WriteLine("5. OOPS - Shallow copy demo");
                Console.WriteLine("6. OOPS - Lookups demo");


            }

            if (iChoice == "6")
            {
                Console.WriteLine("1. TPL - Running Tasks Implicitly");
                Console.WriteLine("2. TPL - Running Tasks explicitly");
                Console.WriteLine("3. TPL - Returning value from task");
                Console.WriteLine("4. TPL - Cancellable Task task");
                Console.WriteLine("5. TPL - Catching Exceptions");
                Console.WriteLine("6. TPL - Parallel For Demo");
                Console.WriteLine("7. TPL - Parallel Invoke Demo");
                Console.WriteLine("8. TPL - Parallel For Each Demo");

            }
        }

        static void TPLConcepts(string choice)
        {
            if (choice == "1")
            {
                RunningTasksImplicit obj = new RunningTasksImplicit();
                obj.TestRunningTaskImplicit();
            }

            if (choice == "2")
            {
                RunningTaskExplicit obj = new RunningTaskExplicit();
                obj.Test();
            }

            if (choice == "3")
            {
                ReturningValueFromTask obj = new ReturningValueFromTask();
                obj.Test();
            }

            if (choice == "4")
            {
                CancellableTasks obj = new CancellableTasks();
                obj.Test();
            }

            if (choice == "4")
            {
                CancellableTasks obj = new CancellableTasks();
                obj.Test();
            }

            if (choice == "5")
            {
                CatchingExceptionsTPL obj = new CatchingExceptionsTPL();
                obj.Test();
            }

            if (choice == "6")
            {
                ParallelFor obj = new ParallelFor();
                obj.Test();
            }

            if (choice == "7")
            {
                ParallelInvokeDemo obj = new ParallelInvokeDemo();
                obj.Test();
            }

            if (choice == "8")
            {
                ParallelForEach obj = new ParallelForEach();
                obj.Test();
            }
        }

        static void MultithreadingConcepts(string choice)
        {
            if (choice == "1")
            {
                AutoResetEventExample obj = new AutoResetEventExample();
                obj.TestAutoEvent();
            }

            if (choice == "2")
            {
                ManualResetEventExample obj = new ManualResetEventExample();
                obj.TestManualResetEvent();
            }

            if (choice == "3")
            {
                MonitorWaitPulseExample obj = new MonitorWaitPulseExample();
                obj.TestMonitorWaitPulseExample();
            }

            if (choice == "4")
            {
                ThreadJoin obj = new ThreadJoin();
                obj.Test();
            }
        }

        static void DesignPatternConcepts(string choice)
        {
            if (choice == "1")
            {
                AbstractFactoryPatternDemo obj = new AbstractFactoryPatternDemo();
                obj.TestAbstractFactory();
            }

            if (choice == "2")
            {
                BuilderPattern obj = new BuilderPattern();
                obj.TestBuilderPattern();
            }

            if (choice == "3")
            {
                ChainOfResponsibilityDemo obj = new ChainOfResponsibilityDemo();
                obj.TestCOR();
            }

            if (choice == "4")
            {
                CommandPattern obj = new CommandPattern();
                obj.TestCommandPattern();
            }

            if (choice == "5")
            {
                ObserverPatternDemo obj = new ObserverPatternDemo();
                obj.TestObserverPattern();
            }

            if (choice == "6")
            {
                StatePattern obj = new StatePattern();
                obj.TestStatePattern();
            }

            if (choice == "7")
            {
                FactoryPattern obj = new FactoryPattern();
                obj.TestFactoryPattern();
            }
        }

        static void LinqAndLambdaConcepts(string choice)
        {
            if (choice == "1")
            {
                AnonymousMethods obj = new AnonymousMethods();
                obj.TestAnonymousMethod();
            }

            if (choice == "2")
            {
                Average obj = new Average();
                obj.DoAverageDemo();
            }

            if (choice == "3")
            {
                Count obj = new Count();
                obj.TestCountDemo();
            }

            if (choice == "4")
            {
                GroupBy obj = new GroupBy();
                obj.TestGroupBy();
                obj.TestMaxSalaryInEachDept();
                Console.WriteLine("*********Getting the list of male employees deptwise whose salary is more than 20k**********");
                obj.GetMaleEmployeesSalaryMoreThan20KDeptWise();
               
            }

            if (choice == "5")
            {
                JoinExample obj = new JoinExample();
                obj.TestJoin();
            }

            if (choice == "6")
            {
                LambdaExpressions obj = new LambdaExpressions();
                obj.TestLambdaExpression();
            }

            if (choice == "7")
            {
                AnonymousMethods obj = new AnonymousMethods();
                obj.TestAnonymousMethod();
            }

            if (choice == "8")
            {
                OrderByAndThenBy obj = new OrderByAndThenBy();
                obj.TestOrderBy();
            }

            if (choice == "9")
            {
                SelectMany obj = new SelectMany();
                obj.TestSelectMany();
            }

            if (choice == "10")
            {
                SelectNew obj = new SelectNew();
                obj.TestSelectNewDemo();
            }

            if (choice == "11")
            {
                skipWhile obj = new skipWhile();
                obj.TestSkipWhile();
            }

            if (choice == "12")
            {
                SumDemo obj = new SumDemo();
                obj.TestSumDemo();
            }

            if (choice == "13")
            {
                TestLinq obj = new TestLinq();
                obj.DoTestLinq();
            }

            if (choice == "14")
            {
                UsingTakeWhile obj = new UsingTakeWhile();
                obj.TestTakeWhile();
            }

            if (choice == "15")
            {
                Where obj = new Where();
                obj.TestWhere();
            }

            if (choice == "16")
            {
                UsingActionDelegate obj = new UsingActionDelegate();
                obj.Test();
            }

            if (choice == "17")
            {
                UsingFunctionDelegate obj = new UsingFunctionDelegate();
                obj.Test();
            }
        }

        static void DelegatesAndEventConcepts(string choice)
        {
            if (choice == "1")
            {
                AsyncCallsUsingDelegates obj = new AsyncCallsUsingDelegates();
                obj.TestAsyncCalls();
            }

            if (choice == "2")
            {
                EventExample obj = new EventExample();
                obj.GetMessageEvent += new EventExample.GetMessage(obj_GetMessageEvent);
                obj.TestEvent("Manoj");
            }

            if (choice == "3")
            {
                EventHandlerBasedEventExample obj = new EventHandlerBasedEventExample();
                obj.DataNotification += new EventHandler<MyEventArgs>(obj_DataNotification);
                obj.TestEventHandlerBasedExample("Manoj");
            }


        }

        static void OOPSConcepts(string choice)
        {
            if (choice == "1")
            {
                using (DisposeAndFinalize obj = new DisposeAndFinalize())
                {
                    Console.WriteLine("Dispose will be called");
                } 
                    
            }

            if (choice == "2")
            {
                EqualsReferenceEquals obj = new EqualsReferenceEquals();
                obj.TestEqualsRefEquals();
            }

            if (choice == "3")
            {
                ExplicitImplicitInterfaces obj = new ExplicitImplicitInterfaces();
                obj.Test();
            }

            if (choice == "4")
            {
                ReflectionDemo  obj = new ReflectionDemo();
                obj.Test();
            }

            if (choice == "5")
            {
                ShallowCopy obj = new ShallowCopy();
                obj.TestShallowCopy();
            }

            if (choice == "6")
            {
                LookupsDemo obj = new LookupsDemo();
                obj.TestLookup();
            }
        }

        

     
        static void obj_DataNotification(object sender, MyEventArgs e)
        {
            Console.WriteLine("Hello " + e.Message);
        }

        static void obj_GetMessageEvent(string sMessage)
        {
            Console.WriteLine("Hello " + sMessage);
        }

        public static List<Department> FillDepartment()
        {
            List<Department> DepartmentList = new List<Department>();
            List<Employee> EmployeeList = new List<Employee>();
            Department obj = new Department();
            obj.DeptName = "S01";

            Employee objEmployee = new Employee();
            objEmployee.Id = 1;
            objEmployee.Name = "Manoj Kumar";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "SSE";
            objEmployee.Salary = 25000;
            obj.EmployeesDeptWise.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 2;
            objEmployee.Name = "Ravi Mehta";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "SSE";
            objEmployee.Salary = 20000;
            obj.EmployeesDeptWise.Add(objEmployee);


            objEmployee = new Employee();
            objEmployee.Id = 4;
            objEmployee.Name = "Devika Prasad";
            objEmployee.Sex = "Female";
            objEmployee.Designation = "SE";
            objEmployee.Salary = 33000;
            obj.EmployeesDeptWise.Add(objEmployee);
            DepartmentList.Add(obj);


            obj = new Department();
            obj.DeptName = "S02";
            objEmployee = new Employee();
            objEmployee.Id = 3;
            objEmployee.Name = "Sonali Prasad";
            objEmployee.Sex = "Female";
            objEmployee.Designation = "SE";
            objEmployee.Salary = 15000;
            EmployeeList.Add(objEmployee);
            obj.EmployeesDeptWise.Add(objEmployee);
            DepartmentList.Add(obj);

          

            obj = new Department();
            obj.DeptName = "S04";

            objEmployee = new Employee();
            objEmployee.Id = 5;
            objEmployee.Name = "Devesh";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "Manager";
            objEmployee.Salary = 90000;
            obj.EmployeesDeptWise.Add(objEmployee);
            DepartmentList.Add(obj);

            obj = new Department();
            obj.DeptName = "S03";

            objEmployee = new Employee();
            objEmployee.Id = 5;
            objEmployee.Name = "Somnath";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "AVP";
            objEmployee.Salary = 200000;
            obj.EmployeesDeptWise.Add(objEmployee);
            DepartmentList.Add(obj);

            return DepartmentList;
        }
        public static List<Employee> FillList()
        {
            List<Employee> EmployeeList = new List<Employee>();

            Employee objEmployee = new Employee();
            objEmployee.Id = 1;
            objEmployee.Name = "Manoj Kumar";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "SSE";
            objEmployee.Salary = 25000;
            EmployeeList.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 2;
            objEmployee.Name = "Ravi Mehta";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "SSE";
            objEmployee.Salary = 20000;
            EmployeeList.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 3;
            objEmployee.Name = "Sonali Prasad";
            objEmployee.Sex = "Female";
            objEmployee.Designation = "SE";
            objEmployee.Salary = 15000;
            EmployeeList.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 4;
            objEmployee.Name = "Devika Prasad";
            objEmployee.Sex = "Female";
            objEmployee.Designation = "SSE";
            objEmployee.Salary = 33000;
            EmployeeList.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 5;
            objEmployee.Name = "Devesh";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "Manager";
            objEmployee.Salary = 50000;
            EmployeeList.Add(objEmployee);

            objEmployee = new Employee();
            objEmployee.Id = 6;
            objEmployee.Name = "SOMNATH";
            objEmployee.Sex = "Male";
            objEmployee.Designation = "AVP";
            objEmployee.Salary = 200000;
            EmployeeList.Add(objEmployee);

            return EmployeeList;

        }
       
    }

    public class A
    {
        public void TestMethod()
        {
            try
            {
                int j = 0;
                int i = 10 / j;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                int j = 0;
                int i = 10 / j;
            }
            finally
            {
                Console.WriteLine("Control here");
                int j = 0;
                int i = 10 / j;
            }

        }
    }
}

