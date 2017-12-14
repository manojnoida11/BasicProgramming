using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class skipWhile
    {
        public void TestSkipWhile()
        {
            int[] arrVal = { 4, 3, 2, 1, 0, 5, -1, -2, -3, -4, 2 };

            var v = arrVal.SkipWhile(a => a > 2);
            foreach (int i in v)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
