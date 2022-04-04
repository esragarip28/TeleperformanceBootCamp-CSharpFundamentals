using System;
using System.Dynamic;

namespace _08._1_var_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var: anonymous type
            var person = new
            {
                Name = "Esra",
                Surname = "Garip",
                City = "Giresun",
                BirthYear = 1998
            };

            var student = new
            {
                Ad = "X School",
                Address = new
                {
                    City = "Giresun",
                    Street = "Tirebolu"
                }
            };

            //Dynamic CLR
            //dynamic
            //object will be resolved at runtime
            //dynamic product=new { };
            dynamic product = new ExpandoObject();
            product.Name = "Laptop";
            product.price = 10000;
            product.Stock = 10;

            //output
            Console.WriteLine(person.BirthYear);
            Console.WriteLine(student.Address.Street);
            Console.WriteLine(product.Name);
            Console.ReadKey();


        }
    }
}
 