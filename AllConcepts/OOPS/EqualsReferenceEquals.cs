using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class EqualsReferenceEquals
    {
        /*
         *  When comparing value types == and Equals both compare values and return true or false.
            When comparing reference types == compare reference while Equals compare contents.
            However, string is the special case. String is also a reference type but == and Equals both compare content.
         *  ReferenceEquals always compares references

         */
        public void TestEqualsRefEquals()
        {
            string s1 = "test";
            string s2 = "test";
            string s3 = "test1".Substring(0, 4);
            object s4 = s3;
            string s5 = s1.Substring(0, 4);
            int i1 = s1.GetHashCode();
            int i2 = s2.GetHashCode();
            Console.WriteLine("{0} {1} {2}", object.ReferenceEquals(s1, s2), s1 == s2, s1.Equals(s2)); //true, true, true
            
            //You  may wonder here object.ReferecneEquals(s1, s2) returned true while object.ReferenceEquals(s1, s3)
            //returned false wheras comparing the same string. The reason is while comparing s1 and s2 comparision is done at compile time
            //while for s1 and s3 it is at runtime.
            //http://stackoverflow.com/questions/9112610/referenceequals-working-wrong-with-strings
            Console.WriteLine("{0} {1} {2}", object.ReferenceEquals(s1, s3), s1 == s3, s1.Equals(s3)); //false, true, true
            Console.WriteLine("{0} {1} {2}", object.ReferenceEquals(s1, s4), s1 == s4, s1.Equals(s4)); //false, false, true
            Console.WriteLine("{0} {1} {2}", object.ReferenceEquals(s1, s5), s1 == s5, s1.Equals(s5)); //true, true, true
        }
    }
}
