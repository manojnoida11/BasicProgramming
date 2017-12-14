using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class UsingActionDelegate
    {
        Action<int, int> myActionDelegate;
        private void AddTwoNums(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum = {0}", c.ToString());
        }
        public void Test()
        {
            //Using Lambda
            myActionDelegate = (i, j) => AddTwoNums(i, j);
            myActionDelegate(10, 20);

            //Simple assignment also works..
            myActionDelegate = AddTwoNums;
            myActionDelegate(30, 40);

            //Can also use Anonymous method
            myActionDelegate = delegate(int x, int y)
            {
                int c = x + y;
                Console.WriteLine("From anonymous mehtod Sum = {0}", c.ToString());
            };
            myActionDelegate(100, 200);


        }
    }
}
