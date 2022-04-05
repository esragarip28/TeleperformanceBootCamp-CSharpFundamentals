using System;

namespace _29_MultipleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string, int> genericClass = new GenericClass<string, int>();
        }
    }

    class GenericClass<TName, TId>
    {

    }

    //Generic Constraints
    //T:class: T must be reference type
    class GenericClass2<T> where T:class
    {

    }
}
