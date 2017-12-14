using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllConcepts
{
    public class RunningTasksImplicit
    {
        public void DoSomeWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread {0} exucting DoSomeWork at {1}",
                    Thread.CurrentThread.ManagedThreadId.ToString(), DateTime.Now.ToString());
                Thread.Sleep(200);
            }
        }

        public void DoSomeOtherWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread {0} exucting DoSomeOtherWork at {1}",
                    Thread.CurrentThread.ManagedThreadId.ToString(), DateTime.Now.ToString());
                Thread.Sleep(200);
            }
        }

        public void TestRunningTaskImplicit()
        {
            Parallel.Invoke(() => DoSomeWork(), () => DoSomeOtherWork());
        }
    }
}
