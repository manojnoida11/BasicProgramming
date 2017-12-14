using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AllConcepts
{
    public class ParallelFor
    {
        void MultiplyByTwo(int number)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Number passed {0}, Current Number {1}", number, number * 2);
            Console.WriteLine( number * 2);
        }

        public void Test()
        {
            Parallel.For(0, 100, i => MultiplyByTwo(i));
            Console.WriteLine("I am here now!! Abshishek changed the messge!!!");

        }

       
    }
}
