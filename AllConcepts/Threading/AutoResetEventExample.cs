using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllConcepts
{
    public class AutoResetEventExample
    {
        AutoResetEvent objAuto = new AutoResetEvent(false);
        public void TestAutoEvent()
        {
            Thread thrd = new Thread(WorkerMethod);
            thrd.Start();
            Console.ReadLine();
            objAuto.Set();
            Console.ReadLine();
            objAuto.Set();
        }

        public void WorkerMethod()
        {
            Console.WriteLine("Worker starting");
            objAuto.WaitOne();
            Console.WriteLine("Worker finishing first time");
            objAuto.WaitOne();
            Console.WriteLine("worker finishing second time");
        }
    }
}
