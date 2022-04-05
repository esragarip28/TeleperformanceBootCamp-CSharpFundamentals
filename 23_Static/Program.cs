using System;

namespace _23_Static
{
    /*
     we can use static keyword with;
     class, method, variable
     When system work, CLI splits ram into 5.
     -stack
     -heap
     -static
     If we use static class, all members of the class must be static.
     We cannot create instance from abstrac class.
     If we want to only one instance, we can use abstract keyword.
     For example, Console class in C# is an abstract class.
     Static method serves to Class, non-static members serves to instances
     Static classes not use in inheritance. 
     Static classes not implements interface. 
     We can make static constructon if we want.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.StudentNo);
            Personal personal = new Personal();
            // we cannot access GetName after creating instance from nonn-static Personal class
            //personal.GetName();
            Console.ReadKey();
        }
    }
}
