using System;
using System.Collections.Generic;

namespace _28_GenericTypes
{
    class Program
    {
        /*
         *<> generic symbol
         *List class is a generic class.
         *we can create generic interface
         *we can create generic delegate
         */
        static void Main(string[] args)
        {
            #region
            List<int> numbers = new List<int>();
            List<string> texts = new List<string>();
            List<Student> students = new List<Student>();
            Console.ReadKey();
            #endregion

            Product<int> product = new Product<int>();
            product.ProductId = 1;

            TestHandler<int> handler = new TestHandler<int>(() => 50);
            
        }
    }


    //we can make multiple generic type.
    class GenericClass<TName, TId>
    {

    }

    //Generic Constraints
    //T:class: T must be reference type
    //where T: struct
    //where T:int 
    class GenericClass2<T> where T : class
    {

    }

    delegate T TestHandler<T>();

    class Student
    {

    }
    
}
