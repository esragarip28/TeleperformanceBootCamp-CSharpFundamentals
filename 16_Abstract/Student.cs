using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Abstract
{
    internal abstract class Student
    {
        //Abstract method has not method body.
        public abstract void Study();
    }

    class HighSchoolStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Student is studying with friends");
        }
    }
    class UniversityStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("Student is studying in library");

        }
    }
}
