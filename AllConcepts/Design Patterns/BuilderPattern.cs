using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    /********************************************************************************************
* Source - http://www.tutorialspoint.com/design_pattern/builder_pattern.htm
* Builder pattern builds a complex object using simple objects and using a step by step approach.
   * A builder class builds the final object step by step. This builder is independent of other objects.
   * Implementation-
   * We have considered a business case of fast food restaurant where a typical meal could be a burger and a cold drink. 
   * Burger could be either a veg burger or chicken burger and will be packed by wrapper.
   * Cold drink could be either a coke or pepsi and will be packed in a bottle.
   * We are going to create an item interface representing food items such as burgers and cold drinks and concrete classes implementing the
   * item interface, and a packing interface representing the packaging of food items and concrete classes implementing the packing interface such that
   * burgers would be packed in wrapper and colddrinks would be packed in bottle.
   * We then create a Meal class having arraylist of item and a mealbuilder class to build different type of meal objects.
* ******************************************************************************************/

    public interface Item
    {
        string Name();
        double price();
    }
    

    public class VegBurger : Item
    {
        public string Name()
        {
            return "Mac Aloo Tikki";
        }

        public double price()
        {
            return 25.5;
        }
    }

    public class ChickenBurger : Item
    {
        public string Name()
        {
            return "Mac Chicken";
        }

        public double price()
        {
            return 50.5;
        }
    }

    public class Coke : Item
    {
        public string Name()
        {
            return "Coke";
        }

        public double price()
        {
            return 12;
        }
    }

    public class Pepsi : Item
    {
        public string Name()
        {
            return "Pepsi";
        }

        public double price()
        {
            return 15;
        }
    }

    public class Meal
    {
        List<Item> mealItems = new List<Item>();
        public void AddItem(Item item)
        {
            mealItems.Add(item);
        }

        public double getCost()
        {
            double cost = 0;
            foreach (Item it in mealItems)
            {
                cost += it.price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (Item it in mealItems)
            {
                Console.WriteLine("Name - {0}, Price {1}", it.Name(), it.price());
            }
            Console.WriteLine("Total price - " + this.getCost());
        }
    }

    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal vegMeal = new Meal();
            vegMeal.AddItem(new VegBurger());
            vegMeal.AddItem(new Coke());
            return vegMeal;
            
        }

        public Meal PrepareNonVegMeal()
        {
            Meal nonVegMeal = new Meal();
            nonVegMeal.AddItem(new ChickenBurger());
            nonVegMeal.AddItem(new Pepsi());
            return nonVegMeal;
        }
    }


    public class BuilderPattern
    {
        public void TestBuilderPattern()
        {
            MealBuilder mealbuilder = new MealBuilder();
            Meal _meal = mealbuilder.PrepareVegMeal();
           _meal.ShowItems();

           mealbuilder = new MealBuilder();
           _meal = mealbuilder.PrepareNonVegMeal();
           _meal.ShowItems();

        }
    }
}
