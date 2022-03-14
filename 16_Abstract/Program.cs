using System;

namespace _16_Abstract
{
    internal class Program
    {
        /*
         If we use abstract, we have to override method however, When using virtual method we dont have to override.
         If there is common behavior we need to use virtual, but there is not common behavior we should use abstract.
         */
        static void Main(string[] args)
        {

            Student student = new UniversityStudent();
            student.Study();
            Student student1 = new HighSchoolStudent();
            student1.Study();
            //we can not use new keyword with abstract class.
            //Student student2 = new Student();
        }
    }
}
