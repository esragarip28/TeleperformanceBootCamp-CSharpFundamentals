using System;

namespace _08_ClassInitializer
{
    class Program
    {
        static void Main(string[] args)
        {

            //indeed,object initializer(but it defines as class initializer)
            //we dont have to use ()
            /*Car car=new Car{
                Brand = "BMW",
                Model = "X6",
                Power = 1000,
                Color = "Black"
            }*/
            Car car = new Car() {
                //order of field is not important
                Brand = "BMW",
                Model = "X6",
                Power = 1000,
                Color = "Black"
            };  
            Console.WriteLine(car.Model);
        }
    }
}
