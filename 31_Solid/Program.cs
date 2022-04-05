using System;

namespace _01_Solid
{
    class Program
    {
        /*
         S - Single-responsiblity Principle
         O - Open-closed Principle : open for extension and close for modification.
         L - Liskov Substitution Principle
         I - Interface Segregation Principle
         D - Dependency Inversion Principle 
         */

        static void Main(string[] args)
        {
            //IPayable payable = new PayingWithCreditCard();
            //PayingManager payingManager = new PayingManager(payable);
            //payable.Pay(100);

            string type = "Credit Card";
            IPayable payable = PayingFactory.GetPaying(type);
            decimal price = 500;
            payable.Pay(price);
        }
    }
}

