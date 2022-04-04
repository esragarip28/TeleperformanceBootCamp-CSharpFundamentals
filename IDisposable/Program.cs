using System;
using System.IO;

namespace IDisposable
{
    class Program
    {
        /*
         Some instance accesses core of the ram,  so sometimes we need to dispose this instance after
        we used them.
        By means of using block we specify that, when our task is done, dispose the instance from ram.
        If our instance not implements IDisposable interface, we can use it in using block.
        Also, in the example, the system will can Dispose() method automatically after work is done.
         */
        static void Main(string[] args)
        {
            //IDisposable
            using (StreamReader reader=new StreamReader(""))
            {
               // reader.Dispose();
            }
        }
    
    }
}
