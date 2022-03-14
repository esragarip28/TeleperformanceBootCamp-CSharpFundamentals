using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polymorphism
{
    internal class Bird
    {
        public virtual void Speak()
        {
            Console.WriteLine("Bird is speaking");
        }
    }
}
