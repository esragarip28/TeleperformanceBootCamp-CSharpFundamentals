using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    internal class Sparrow:Bird
    {

        public new void Speak()
        {
            Console.WriteLine("Sparrow is speaking");
        }
    }
}
