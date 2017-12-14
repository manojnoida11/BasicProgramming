using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllConcepts
{
    public class CancellableTasks
    {
        public void Test()
        {
            var ts = new CancellationTokenSource();
            CancellationToken ct = ts.Token;

            //Task.Factory.StartNew(() =>
            //    {
            //        while (true)
            //        {
            //            Thread.Sleep(1000);
            //            Console.WriteLine("Inside while at -" + DateTime.Now.ToString());
            //            if (ct.IsCancellationRequested)
            //            {
            //                Console.WriteLine("task canceled");
            //                break;
            //            }
            //        }
            //    }, ct);

            Task.Factory.StartNew(() => DoTask(ct));

            //Simulate waiting for 10 seconds
            Thread.Sleep(10000);

            //can't wait anymore cancel the task..
            ts.Cancel();
            Console.ReadLine();
        }

        void DoTask(CancellationToken ct)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Inside while at -" + DateTime.Now.ToString());
                if (ct.IsCancellationRequested)
                {
                    Console.WriteLine("task canceled");
                    break;
                }
            }
        }
    }
}
