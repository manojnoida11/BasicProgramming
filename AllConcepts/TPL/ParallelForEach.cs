using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConcepts
{
    public class ParallelForEach
    {
        List<Person> personList = new List<Person>();
        public void Test()
        {
            for(int i = 1; i < 20000; i++)
            {
                Person per = new Person();
                per.Age = i;
                personList.Add(per);
            }

            //Now we have filled up the list we will demonstrate parallel.foreach
            Parallel.ForEach(personList, item => PrintAge(item));
        }

        void PrintAge(Person obj)
        {
            Console.WriteLine("Age of person is - " + obj.Age.ToString());
        }

    }

    public class Person
    {

        public int Age
        { get; set; }
    
    }

}
