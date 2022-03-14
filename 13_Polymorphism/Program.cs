using System;

namespace _13_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Nightingale();
            bird.Speak();
            bird = new Crow();
            bird.Speak();
            bird = new Sparrow();
            bird.Speak();
            Sparrow sparrow = new Sparrow();    
            sparrow.Speak();
            Console.ReadKey();
        }
    }
}
