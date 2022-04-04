using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Abstraction
{
    abstract class Pencil
    {
        public Pencil() { }
        public string Brand { set; get; }
        public string Color { set; get; }
        public abstract void Write();
    }
}
