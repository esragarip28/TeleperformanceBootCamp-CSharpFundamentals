using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid
{
    class PayingWithDebitCard : IPayable
    {
        public bool Pay(decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
