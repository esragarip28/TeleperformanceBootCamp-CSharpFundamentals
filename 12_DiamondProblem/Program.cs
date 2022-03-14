using System;

namespace _12_DiamondProblem
{
    internal class Program
    {
        /*
         In C#  there is no multiple inheritants.
         */
        static void Main(string[] args)
        {
            A a=new A();
           
        }
    }
     class A
    {
        public void Test()
        {
            Console.WriteLine("A class");
        }
    }

    class B
    {
        public void Test()
        {
            Console.WriteLine("B class");
        }
    }
    //class C : B, A
    //{
    //some languages solved diamond problem as like this.
    //    public void A.Test()
    //    {

    //    }
    //    public void B.Test()
    //    {

    //    }
    //    public new void Test()
    //    {
    //        baseA.Test();
    //        baseB.Test();
    //    }


    //}

}
