using System;

namespace _22_Struct
{
    class Program
    {
        /*struct not support inheritance*/
        public static void Main(string[] args)
        {

            //we can create instance from struch as normal class
            Coordinat coordinat = new Coordinat();
            coordinat.X = 10;
          
            Calculate(10,20,Operation.Sum);
            
        }

        public static void Calculate(int num1, int num2,Operation operation)
        {

        }
        public enum Operation
        {
            Sum,
            Division,
            Multiplication,
            Subraction
        }
    }
}
