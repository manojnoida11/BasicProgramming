using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public interface IDebitCard
    {
        void CardNumber();
    }

    public interface ICreditCard
    {
        void CardNumber();
    }

    public class Customer : IDebitCard, ICreditCard
    {
        //Common Implementation
        public void CardNumber()
        {
            Console.WriteLine("General Implementation");
        }

        //Explicit Implementation
        void IDebitCard.CardNumber()
        {
            Console.WriteLine("Debit card Implementation");
        }

        void ICreditCard.CardNumber()
        {
            Console.WriteLine("Credit card implementation");
        }
    }
    public class ExplicitImplicitInterfaces
    {
        public void Test()
        {
            Customer objCustomer = new Customer();
            IDebitCard objDebitCustomer = new Customer();
            ICreditCard objCreditCustomer = new Customer();

            //Calling general implementation
            objCustomer.CardNumber();

            //Calling debit card implementation explicitly
            objDebitCustomer.CardNumber();

            //Calling credit card implementation explicitly
            objCreditCustomer.CardNumber();
        }
    }
}
