using _06._2_AccessModifierLib;
using System;

namespace _06_AccessModifiers
{
    internal class Program
    {
        /*
         * Access modifiers is necessary for encapsulation
         * private: it can accessible from the class in which it is defined 
         * public: accessible by all classes
         * protected: It is accessible by the class in which it is defined and its subclasses
         * internal: It is accessible within the project. Assembly
         * protected-internal:It works as or.
         */
        static void Main(string[] args)
        {
            Person person = new();
            //we access internal and public method but we cannot access protected and private.
            person.InternalMethod();
            person.PublicMethod();
            //we call Product class by using _06._2_AccessModifierLib
            Product product = new Product();
            product.PublicMethod();
            Console.ReadKey();
        }
    }
}
