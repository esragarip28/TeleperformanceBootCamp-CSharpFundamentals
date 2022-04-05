using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Events
{
    delegate void HandUpHandler(Student student);
    class Student
    {
        /*Event must be delegate type.*/
        public string Name { get; set; }

        public event HandUpHandler HandUp;
        public void AskQuestion()
        {
            HandUp(this);
        }

      
    }
}
