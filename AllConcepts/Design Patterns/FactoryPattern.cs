using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public interface IVehicle
    {
        void GetMessage();
    }

    public class Car : IVehicle
    {
        public void GetMessage()
        {
            Console.WriteLine("I am a car");
        }
    }

    public class Bike : IVehicle
    {
        public void GetMessage()
        {
            Console.WriteLine("I am a bike");
        }
    }

    public class Truck : IVehicle
    {

        public void GetMessage()
        {
            Console.WriteLine("I am a truck");
        }
    }
    public class FactoryPattern
    {
        public void TestFactoryPattern()
        {

            IVehicle vehicle = null;
            string[] arr = new string []{ "Truck", "Car", "Bike" };
            Random rand = new Random();
            int iVal = rand.Next(1, 3);
            if (iVal == 1)
            {
                vehicle = new Truck();
            }

            if (iVal == 2)
                vehicle = new Bike();

            if (iVal == 3)
                vehicle = new Car();

            vehicle.GetMessage();
        }

    }
}
