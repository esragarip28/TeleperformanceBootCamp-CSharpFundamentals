using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid
{
    class PayingFactory
    {
        public static IPayable GetPaying(string type)
        {
            if (type.Equals("Credit Card"))
            {
                return new PayingWithCreditCard();
            }
            else if (type.Equals("Debit Card"))
            {
                return new PayingWithDebitCard();
            }
            else throw new Exception();
        }
    }
}
