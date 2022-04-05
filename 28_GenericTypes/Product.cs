using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_GenericTypes
{
    class Product<T>
    {
        public T ProductId { get; set; }
        public string Name { get; set; }

        public void Test(T product)
        {

        }

    }
}
