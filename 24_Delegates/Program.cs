using System;

namespace _24_Delegates
{
    delegate void MyHandler(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new();
            //helper.AddMethod(delegate ()
            //{
            //    Console.WriteLine("method added");
            //});
            //helper.HandlerMethod();
            //helper.AddMethod(() => Console.WriteLine("method added"));
            //helper.HandlerMethod();

            helper.AddMethod(x => Console.WriteLine(x));
            helper.AddMethod(x => { x += 5; Console.WriteLine(x); });
            helper.HandlerMethod(5);
            Console.ReadKey();
        }
    }

    class Helper
    {
        MyHandler handler;
        public void AddMethod(MyHandler handler)
        {
            this.handler = handler;
        }

        public void HandlerMethod(int num)
        {
            handler(num);
        }
    }
}
