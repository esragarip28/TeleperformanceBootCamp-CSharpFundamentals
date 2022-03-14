using System;

namespace _01_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Marty";
            //if(name is "Marty")
            //{

            //}
            //if(name is not "Marty")
            //{

            //}

            //=> lambda operator
            //_discard operator
            string result = name switch
            {
                "Marty" => "name is equal to Marty",
                "Stanley" => "name is equal to Stanley",
                _ => "name is not equal to anything"
            };

            int number = 10;
            switch (number)
            {
                case < 5:
                    break;
                case < 8:
                    break;
                default:
                    break;
            }

            Console.WriteLine(number switch
            {
                1 => "the values is 1",
                _ => "the value is not 1"
            });

            Console.WriteLine(number > 0 ? "positive" : "negative");

            string day = DateTime.Now.DayOfWeek switch
            {
                0 => "Sunday",
                _ => "the day is not sunday"
            };
            Console.WriteLine(day);

            string day2 = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday when DateTime.Now.Hour > 12 => "Monday",
                DayOfWeek.Wednesday => "Wednesday",
                _ => "default"
            };
            Console.WriteLine(day2);
        }
    }
}