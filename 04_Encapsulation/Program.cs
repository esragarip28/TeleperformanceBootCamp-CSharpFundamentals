using System;

namespace _04_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("esra");
            Console.WriteLine(person.GetName());
            Person person2 = new();
            //person2.SetName("e");  this will throw an error
            person2.SetBirthYear(new DateTime(1998,05,10));
            Console.WriteLine(person2.GetBirthDate());

        }
    }
}
