using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AllConcepts
{
    
    public class ReflectionDemo
    {
        public int AddTwoNums(int a, int b)
        {
            return a + b;
        }

        public void Test()
        {
            ReflectionDemo classObj = new ReflectionDemo();
            Type t = classObj.GetType();

            MethodInfo mehtodInfo = t.GetMethod("AddTwoNums");
            object[] paramObj = new object[] { 10, 20 };
            object sum = mehtodInfo.Invoke(classObj, paramObj);
            Console.WriteLine("Sum = " +  sum.ToString());
        }
    }
}
