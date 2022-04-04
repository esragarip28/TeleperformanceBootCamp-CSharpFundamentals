using System;

namespace _09_Inheritance
{
    /*
     When we create an instance from subclass, also, an instance from super class will be created.
     This super class instance will be in ram.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftwareEngineer softwareEngineer = new();
            softwareEngineer.languages.Add("C#");
            Console.WriteLine(softwareEngineer.languages[0]);
            Person person = new SoftwareEngineer();
            Person person1 = new Person();  
            if(person1 is SoftwareEngineer)
            {
                //SoftwareEngineer softwareEngineer1= (SoftwareEngineer)person1;
                SoftwareEngineer softwareEngineer1=person1 as SoftwareEngineer;
                softwareEngineer1.Name = "Esra";
                Console.WriteLine(softwareEngineer1);
            }
            if (person1.GetType() == typeof(SoftwareEngineer))
            {

            }
            Console.WriteLine(softwareEngineer.GetType().BaseType.BaseType.Name);
            
        }
    }
}
