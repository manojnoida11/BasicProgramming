using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class UsingFunctionDelegate
    {
        private Func<int, int, int> myFunc;
        private int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public void Test()
        {
            //Using Lambda
            myFunc = (i, j) => AddTwoNumbers(i, j);
            int c = myFunc(10, 20);
            Console.WriteLine("Sum From Lambda - " + c.ToString());

            //Simple assignment;
            myFunc = AddTwoNumbers;
            c = myFunc(30, 40);
            Console.WriteLine("Sum From assignment - " + c.ToString());

            //Using Anonymous
            myFunc = delegate(int x, int y)
            {
                return x + y;
     
            };
            c = myFunc(100, 200);
            Console.WriteLine("Sum From anobymous - " + c.ToString());
        }
    }
}
