using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Events
{
    class Instructor
    {

        public void Teach()
        {
            Console.WriteLine("Instructor is teaching about events");
        }

        public void GiveRightToSpeak(Student student)
        {
            Console.WriteLine(student.Name + " you can ask your question");
        }
    }
}
