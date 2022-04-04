using System;

namespace _17_Abstraction
{
    class Program
    {
        /* we cannot create instance from abstract class*/
        /*
         * we can add fields, contructor, method with body, abstract method in abtract class
         */
        static void Main(string[] args)
        {


            Pencil pencil = new CrayonPen();
            pencil.Write();
            Pencil pencil2 = new BallPen();
            pencil2.Write();
            pencil2.Color = "Black";
            pencil2.Brand = "X Brand";
            Console.ReadKey();

        }
    }
}
