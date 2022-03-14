using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ToString
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname{ get; set; }

        public override string ToString()
        {
            return "toString method was overrided";
        }
    }
}
