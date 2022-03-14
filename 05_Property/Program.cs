using System;

namespace _05_Property
{
    internal class Program
    {
        /*
         *property keyword came to C# with version 2.0
         *property represents setter and getter methods
         *Properties consist of setter,getter and fields.
         *Property is not variable but it hold variable.
         **/

        static void Main(string[] args)
        {
            Product product = new();
            product.Name = "Computer";
            Console.WriteLine(product.Name);
            product.ExpireDate = DateTime.Now;
            Console.WriteLine(product.ExpireDate);
            product.Stock = -100;
            Console.WriteLine(product.Stock);   

        }
    }
}
