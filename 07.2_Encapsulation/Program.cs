using _07._1_EncapsulationLib;
using System;

namespace _07._2_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //to access student class' field (the class internal) ,in lib we create a new class. In new class, we create new method and define some rules to access Student class' field.
            Protecter protecter = new();
            protecter.GetStudentName("****");
        }
    }
}
