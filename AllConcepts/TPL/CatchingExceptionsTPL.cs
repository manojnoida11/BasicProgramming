using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AllConcepts
{
    public class CatchingExceptionsTPL
    {
        int Divide(int a, int b)
        {
           return a / b;
        }
        
        public void Test()
        {
            #region variables
            int i;
            int j;
            Console.WriteLine("Enter Dividend");
            i = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Quotient");
            j = Convert.ToInt16(Console.ReadLine());
            #endregion

            Task<int> t1 = Task<int>.Factory.StartNew(() => 
                {int c;
                    if (j == 0)
                    {
                        throw new DivideByZeroException("This is divide by zero");
                    }
                    c = Divide(i, j);
                    return c;
                });
            try
            {
                t1.Wait();
                int output = t1.Result;
                Console.WriteLine("Task completed, Output -" + output.ToString());
            }
            catch (AggregateException ae)
            {
                    if (t1.Status == TaskStatus.Faulted)
                    {
                        foreach (var e in ae.InnerExceptions)
                        {
                            if (e is DivideByZeroException)
                            {
                                Console.WriteLine(e.Message);
                            }
                            else
                            {
                                throw e; 
                            }
                        }
                    }
            }
            
        }
    }
}
