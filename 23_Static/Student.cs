using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Static
{
    static class Student
    {
        public static int StudentNo { get; set; }
    }

    class Personal
    {
        public String NationalIdentity { get; set; }
        public static string GetName()
        {
            // we cannot access non-static members of Personal class in this static method.
            return "Personal Name";
        }
    }
}
