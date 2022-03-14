using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    internal class Nightingale:Bird
    {
        public override void Speak()
        {
            Console.WriteLine("Nightingale is speaking");
        }
    }
}
