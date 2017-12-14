using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllConcepts
{
    /*Parallel.Invoke methods take the action delegates and you can pass any number of methods you want to 
     * execute simultaneously in asynchronous fashion.
     */
    public class ParallelInvokeDemo
    {
        public void Test()
        {
            Test1();
        }

        private void Test1()
        {
            Parallel.Invoke(() => Test3(), () => Test2());
            //test3 and test2 will be executed simultaneously and control will come here only after both
            //methods get executed.
            Console.WriteLine("i am here test1");
        }
        private void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("test 2");
            }
        }

        private void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("test 3");
            }
        }
       
    }
}
