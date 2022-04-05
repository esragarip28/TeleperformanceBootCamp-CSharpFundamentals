using System;

namespace _24_Delegates
{
    delegate void MyHandler(int num);
    delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Sum);
            myDelegate += Subtract;
            myDelegate();
            myDelegate-=Sum;
            //myDelegate() or myDelegate.invoke()
            myDelegate.Invoke();
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

        static void Sum()
        {
            Console.WriteLine("Calling sum method...");
        }
        static void Subtract()
        {
            Console.WriteLine("Calling subtract method...");
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
