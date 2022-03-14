using System;

namespace _15_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Marty",
                Surname = "McFly",
            };
            
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student);
            Console.WriteLine(student.ToString());

            Console.ReadKey();

        }
    }
}
