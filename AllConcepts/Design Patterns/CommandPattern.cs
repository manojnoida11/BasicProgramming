using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public interface Order
    {
        void Execute();
    }

    public class Stock
    {
        public string stockName = "abc";
        public int quantity = 10;

        public void BuyOrder(Stock stk)
        {
            Console.WriteLine("Order {0}, bought in qty {1}", stk.stockName, stk.quantity);
        }

        public void SellOrder(Stock stk)
        {
            Console.WriteLine("Order {0}, sold in qty {1}", stk.stockName, stk.quantity);
        }
    }

    public class BuyOrder : Order
    {
        Stock abcStock;
        public BuyOrder(Stock _stock)
        {
            abcStock = _stock;
        }
        public void Execute()
        {
            abcStock.BuyOrder(abcStock);
        }
    }

    public class SellOrder : Order
    {
        Stock abcStock;
        public SellOrder(Stock _stock)
        {
            abcStock = _stock;
        }
        public void Execute()
        {
            abcStock.SellOrder(abcStock);
        }
    }

    //Create a command invoker class
    public class Broker
    {
        private List<Order> OrderList = new List<Order>();
        public void TakeOrder(Order ord)
        {
            OrderList.Add(ord);
        }

        public void PlaceOrder()
        {
            foreach (Order ord in OrderList)
            {
                ord.Execute();
            }
        }
    }
    public class CommandPattern
    {
        public void TestCommandPattern()
        {
            Stock stk = new Stock();
            stk.stockName = "Ambuja Cement";
            stk.quantity = 50;

            Broker cmdBroker = new Broker();
            BuyOrder _ordbuy = new BuyOrder(stk);
            cmdBroker.TakeOrder(_ordbuy);

            stk = new Stock();
            stk.stockName = "HCL";
            stk.quantity = 100;
            SellOrder _ordsell = new SellOrder(stk);
            cmdBroker.TakeOrder(_ordsell);

            cmdBroker.PlaceOrder();
        }
    }
}
