using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    /* Anonymous methods provide the technique to pass code block as a delegate parameter.
     * They are the methods just with body and without name.
     * You need not to specify the return types of anonymous methods and it is inferred from delegate itself.
     */
    public class AnonymousMethods
    {
        delegate int TwoIntOps(int x, int y);
        public void TestAnonymousMethod()
        {
            TwoIntOps del = delegate(int x, int y)
            {
                return x + y;
            };

            int c = del(10, 20);
            Console.WriteLine("Sum using anonymous method - " + c.ToString());

            TwoIntOps del1 = delegate(int x, int y)
            {
                return x - y;
            };

            c = del1(20, 15);
            Console.WriteLine("diff using anonymous method - " + c.ToString());
        }
    }
}
