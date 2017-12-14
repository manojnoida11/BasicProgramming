using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllConcepts
{
    public class AsyncCallsUsingDelegates
    {
        private delegate string GetMessage();

        public void TestAsyncCalls()
        {
            GetMessage del = this.CallMethodAsync;
            del.BeginInvoke(new AsyncCallback(CallBackMethod), del);
            Console.WriteLine("Waiting in main method for the delegate to complete call asynchronously");
        }

        void CallBackMethod(IAsyncResult ar)
        {
            GetMessage del = (GetMessage)ar.AsyncState;
            string str = del.EndInvoke(ar);
            Console.WriteLine(str);
        }
        private string CallMethodAsync()
        {
            Thread.Sleep(5000);
            return "Method ended at - " + DateTime.Now.ToString();
        }

        
    }
}
