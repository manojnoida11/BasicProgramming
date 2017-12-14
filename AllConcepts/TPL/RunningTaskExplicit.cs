using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllConcepts
{
   /*For greater control over task execution 
    */
    public class RunningTaskExplicit
    {
        public void Test()
        {
            Thread.CurrentThread.Name = "Main";


            var tasks = new List<Task>();
            Task taskA = new Task(() => DoSomeStuff());
            tasks.Add(taskA);
            taskA.Start();

            Task taskB = new Task(() => DoSomeOtherStuff());
            tasks.Add(taskB);
            taskB.Start();


            Console.WriteLine("Hello from thread -{0}", Thread.CurrentThread.Name);
            Task.WaitAll(tasks.ToArray());
            //taskB.Wait();
            Console.WriteLine("ok I AM DONE");
        }

        private void DoSomeStuff()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Task A Doing something at - "  + DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
        }

        private void DoSomeOtherStuff()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Task B Doing something at - " + DateTime.Now.ToString());
                Thread.Sleep(500);
            }
        }


    }

    
}
