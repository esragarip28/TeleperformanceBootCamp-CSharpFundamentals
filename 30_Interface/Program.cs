using System;

namespace _30_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayabale payabale = new CreditCart();
            payabale.Pay(200);
            payabale = new Transfer();
            payabale.Pay(500);

            //we cannot write the following code
            //IGiveableRefund giveableRefund = new Transfer();

            IGiveableRefund giveableRefund = new CreditCart();
            giveableRefund.GiveRefund(); 
             

        }
    }
}
