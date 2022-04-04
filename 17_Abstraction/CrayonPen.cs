using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Abstraction
{
    class CrayonPen : Pencil
    {
      
        public override void Write()
        {
            Console.WriteLine("Crayon is writing");
        }
    }
}
