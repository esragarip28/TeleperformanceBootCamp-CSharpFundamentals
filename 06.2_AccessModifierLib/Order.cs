using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_AccessModifierLib
{
    public class Order
    {
        public Order()
        {
            Product product = new Product();
            product.ProtectedInternalMethod();
            product.PublicMethod();
        }
    }
}
