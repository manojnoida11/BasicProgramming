using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllConcepts
{
    public class ThreadJoin
    {
        /*Thread.Join blocks the current thread and makes it wait until the thread on which join method is invoked completes.
         * 
         */
        public void Test()
        {
            Thread t1 = new Thread(TestMethod1);
            t1.Start();

            Thread t2 = new Thread(TestMethod2);
            t2.Start();

            //Main thread will be suspended until t1 completes it's work.
            t1.Join();
            Console.WriteLine("Thread1 has completed it's task");

            t2.Join();
            Console.WriteLine("Thread2 has completed it's task");

            Console.WriteLine("End of test method");
        }
        public void TestMethod1()
        {
            Console.WriteLine("I am method 1");
        }

        public void TestMethod2()
        {
            Console.WriteLine("I am method 2");
        }
    }
}
