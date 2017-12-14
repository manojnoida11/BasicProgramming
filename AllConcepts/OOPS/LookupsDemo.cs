using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    /*Dictionary <TKey, TValue> supports only one value per key. 
     * The class Lookup<TKey, TElement> resembles a dictionary but maps to a collection of values. 
        Lookup<TKey, TElement> cannot be created as a normal dictionary. 
     * Instead, you have to invoke the method ToLookup which returns a Lookup<TKey, TElement> object.  
     * ToLookup is an extension method that is available to every class implanting IEnumerable<T>. 
     */
    public class LookupsDemo
    {
        public void TestLookup()
        {
            var racers = new List<Racer>();
            Racer racer = new Racer();
            racer.FirstName = "Manoj";
            racer.LastName = "Kumar";
            racer.Country = "India";
            racer.Age = 31;
            racers.Add(racer);


            racer = new Racer();
            racer.FirstName = "Mike";
            racer.LastName = "Arthton";
            racer.Country = "England";
            racer.Age = 22;
            racers.Add(racer);

            racer = new Racer();
            racer.FirstName = "Ravi";
            racer.LastName = "Mishra";
            racer.Country = "India";
            racer.Age = 26;
            racers.Add(racer);

            racer = new Racer();
            racer.FirstName = "Prem";
            racer.LastName = "Kumar";
            racer.Country = "India";
            racer.Age = 31;
            racers.Add(racer);

            //Since List implenets IEnumerable<T>, it can call ToLookup Method.

            var lookupracers = racers.ToLookup(r => r.Country);

            foreach (Racer r in lookupracers["India"])
            {
                Console.WriteLine(r.FirstName);
            }
        }
    }

    class Racer
    {
       
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }

}
