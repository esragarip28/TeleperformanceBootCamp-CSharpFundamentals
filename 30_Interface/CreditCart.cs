using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interface
{
    class CreditCart : IPayabale, IGiveableRefund
    {
        public void GiveRefund()
        {
            throw new NotImplementedException();
        }

        public void Pay(decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
