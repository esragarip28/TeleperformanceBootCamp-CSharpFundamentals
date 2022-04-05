using System;

namespace _22_Struct
{
    class Program
    {
        /*struct not support inheritance*/
        /*struct is a value type
         struct is fast, we can access data in a heartbeat.
         But if our size is bigger than 16kb we should not prefer it.
         Struct cannot be abstract.
         Struct not include abstract and virtual method.
         Struct can implements interfaces.
         We have to assign value to values of struct.
         In struc t we can not write constructor without parameters. because its variables have to get value when struct enters ram.
         */

        /*In class, when we define constructor with parameter, our default constructor not usable if we define it in the class, but
         this situation is not valid for struct. If we dont write default constructor, it behaves as if there is default const.*/
        /*base type of struct is ValueType. Struct extends from ValueType*/
        public static void Main(string[] args)
        {

            //we can create instance from struct as normal class
            Coordinat coordinat = new Coordinat();
            coordinat.X = 10;
            Console.WriteLine("Summation of num1 and num2: "+Calculate(10, 20, Operation.Sum));
            Console.WriteLine("Multiplication of num1 and num2: "+Calculate(20,20,Operation.Multiplication));

            Console.WriteLine("-----------------------------------\n" +
                "Operations:");
            string[] operations = Enum.GetNames(typeof(Operation));
            foreach(string operation in operations)
            {
                Console.WriteLine(operation);
            }
        }

        public static double Calculate(int num1, int num2,Operation operation)
        {
            if (operation == Operation.Sum)
            {
                return num1 + num2;
            }
            else if (operation == Operation.Division)
            {
                return num1 - num2;
            }
            else if (operation == Operation.Multiplication)
            {
                return num1 * num2;
            }
            else if (operation == Operation.Division)
            {
                try { return num1 / num2; }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else throw new Exception();
        }
        public enum Operation
        {
            /*we can give default value to enum variables
             Enum is a value type
             */
            Sum,
            Division,
            Multiplication,
            Subraction
        }
    }
}
