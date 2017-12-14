using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    /* A lambda expression is an anonymous function that you can use to create delegates or expressoin tree types.
         */
    public class LambdaExpressions
    {
        delegate int TwoIntOps(int x, int y);

        private int AddTwoNums(int x, int y)
        {
            return x + y;
        }
        public void TestLambdaExpression()
        {
            //Executing the block anonymously using lambda
            TwoIntOps op = (x, y) =>
            {
                return x + y;
            };

            int c = op(10, 20);
            Console.WriteLine("Sum  using lambda expression - " + c.ToString());

            //Giving a reference of method using Lambda
            TwoIntOps op1 = (x, y) => AddTwoNums(x, y);
            c = op1(20, 30);
        }
        
    }
}
