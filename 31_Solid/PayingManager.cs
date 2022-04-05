using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid
{
    class PayingManager
    {
        IPayable payable;
        public PayingManager(IPayable payable)
        {
            this.payable = payable;
        }
        public bool Pay(decimal price)
        {
            return payable.Pay(price);
        }
    }
}
