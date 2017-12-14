using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllConcepts
{
    public class ManualResetEventExample
    {

        ManualResetEvent objManual = new ManualResetEvent(false);
        public void TestManualResetEvent()
        {
            Thread thrd = new Thread(WorkerMethod);
            thrd.Start();
            Console.ReadLine();
            objManual.Set();
            Console.ReadLine();
            objManual.Set();
        }

        public void WorkerMethod()
        {
            Console.WriteLine("Worker starting");
            objManual.WaitOne();
            Console.WriteLine("Worker finishing first time");
            objManual.WaitOne();
            Console.WriteLine("worker finishing second time");
        }
    }
}
