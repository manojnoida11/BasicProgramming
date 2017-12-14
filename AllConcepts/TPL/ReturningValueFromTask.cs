using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConcepts
{
    public class ReturningValueFromTask
    {
        private int AddTwoNums(int x, int y)
        {
            return x + y;
        }

        public void Test()
        {
            int []arr = new int[] { 10, 20 };
            Task<int> t1 = Task<int>.Factory.StartNew(() => AddTwoNums(10, 20));
            int i = t1.Result;
        }

         
    }
}
